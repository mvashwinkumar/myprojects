ssEventDisc = null;
currencyRate = 1;
currencySymbol = "SGD $";
function initCurrencyConverter()
{

    //initialize the rates
    var currencyArray = getCurrencyListFromSelector();
    var request = {currencies: currencyArray};
    request = JSON.stringify(request);
    $.ajax({
        url: "/BasketApp/api/Currency",
        data: request,
        method: "post",
        contentType: "application/json",
    }).done(success).fail(fail);

    function success(data)
    {
        //update currency rate
        currencyData = data;
        for (key in currencyData)
        {
            $("#currencySelector option[value=" + currencyData[key].currencyCode + "]").data("rate", currencyData[key].rate);
        }
        $("#currencySelector").trigger("change");

    }

    function fail(data)
    {
        console.log(">>>>>>>>>>>>>>>fail to update currency data<<<<<<<<<<<<<<<<<<");

    }


    //set on change event     
    $("#currencySelector").change(function(event) {
        currencyRate = $(this).find(":selected").data("rate");
        currencySymbol = $(this).find(":selected").data("symbol");

        //update listing prices
        updateListingPrice();

    });
    setDefaultCurrency();
    updateListingPrice();
}

function updateListingPrice()
{
    $(".mainListPrice").each(function() {
        var thisPrice = Number($(this).data("price"));
        var thisDiscount = Number($(this).data("discount"));
        var finalPrice = thisPrice * ((100 - thisDiscount) / 100);
        finalPrice = finalPrice * currencyRate;
        var newPrice = formatCurrency(finalPrice);
        $(this).html(newPrice);
    });
}

function getCurrencyListFromSelector()
{
    var currencyList = new Array();
    $("#currencySelector option").each(function() {
        if ($(this).val() != "SGD")
        {
            currencyList.push($(this).val());
        }
    });
    return currencyList;
}



function getSubscription()
{
    var myData = {username: JSON.parse($.cookie("cart")).username};

    $("").ajaxWrapper("/BasketApp/api/Customer/getSubscriptions", success, fail, JSON.stringify(myData), "application/json");

    function success(data)
    {
        //console.log(JSON.stringify(data));
        //check if cookie already exists
        var newSubscriptionList = {};
        for (item in data)
        {
            console.log(data[item].inventoryId.inventoryId);
            var discount = (data[item].inventoryId.discount);
            newSubscriptionList[data[item].inventoryId.inventoryId] = {};
            newSubscriptionList[data[item].inventoryId.inventoryId].discount = discount;
            newSubscriptionList[data[item].inventoryId.inventoryId].name = data[item].inventoryId.name;

        }
        $.cookie("subscription", JSON.stringify(newSubscriptionList));
        refreshSubscription();
    }

    function fail(data)
    {
        console.log(">>>>>>>>>>>>>>>>>>>>>failed loading subscription<<<<<<<<<<<<<<<<<<<<<");
    }

}


//add subscription
function addSubscription(button, productId)
{
    var productId = productId;
    var button = button;
    var username = JSON.parse($.cookie("cart")).username;
    var request = {username: username, inventoryId: productId};
    $(button).ajaxWrapper("/BasketApp/api/Customer/addSubscription", success, fail, JSON.stringify(request), "application/json", null, false);

    function success(data)
    {
        $(button).text("Unsubscribe");
        $(button).data("action", "unsub");
        //add to cookie
        var subscriptionList = JSON.parse($.cookie("subscription"));
        subscriptionList[productId] = {};
        subscriptionList[productId].discount = data.discount;
        subscriptionList[productId].name = data.name;
        $.cookie("subscription", JSON.stringify(subscriptionList));
        refreshSubscription();
    }

    function fail(data)
    {
        //nothing changed
        console.log(">>>>>>>>>>>>>>>>>adding subscription fail<<<<<<<<<<<<<<<<<<<")
    }

}

//remove subscription
function removeSubscription(button, productId)
{
    var productId = productId;
    var button = button;
    var username = JSON.parse($.cookie("cart")).username;
    var request = {username: username, inventoryId: productId};
    $(button).ajaxWrapper("/BasketApp/api/Customer/removeSubscription", success, fail, JSON.stringify(request), "application/json", null, false);

    function success(data)
    {
        $(button).text("Subscribe");
        $(button).data("action", "sub");
        var subscriptionList = JSON.parse($.cookie("subscription"));
        if (subscriptionList[productId])
            delete subscriptionList[productId];
        $.cookie("subscription", JSON.stringify(subscriptionList));
        refreshSubscription();
    }

    function fail(data)
    {
        //nothing changed
        console.log(">>>>>>>>>>>>>>>>>remove subscription fail<<<<<<<<<<<<<<<<<<<")
    }

}


//toggle subscription
function toggleSubscription(button, productId)
{
    var productId = productId;
    var button = button;
    return function(target)
    {
        if ($(button).data("action") === "sub")
        {
            //subscribe
            addSubscription(button, productId);

        }
        else
        {
            //unsubscribe
            removeSubscription(button, productId);
        }
    }

}

function refreshSubscription()
{
    var newSubscriptionList = JSON.parse($.cookie("subscription"));
    updateSubscription();
    includes("subscription_template", cartToJsonArray(newSubscriptionList), "#subscriptionNavContent");
    initSubscriptionNav();
    updateSubscription();
    if (!ssEventDisc)
    {
        ssEventDisc = new EventSource("/BasketApp/discount");
        ssEventDisc.onmessage = function(data) {
            //var tempString = JSON.parse(data.data);
            //$("#testdiv").html(JSON.stringify(tempString));
            var response = JSON.parse(data.data);
            var subscriptionList = JSON.parse($.cookie("subscription"));
            if (subscriptionList[response.productId])
                subscriptionList[response.productId].discount = response.discount;
            $.cookie("subscription", JSON.stringify(subscriptionList));

            //update discount in cart too
            var cartCookie = JSON.parse($.cookie("cart"));
            if (cartCookie.cart[response.productId])
            {
                cartCookie.cart[response.productId].discount = response.discount;
            }
            $.cookie("cart", JSON.stringify(cartCookie));
            refreshSubscription();
            if (response.discount > 0)
                toast("There is a discount for " + subscriptionList[response.productId].name + ".");
            //alert("you have discount!");

        }

    }
}

function updateSubscription()
{
    var orgSubscriptionCount = Number($("#subscriptionNotification").html());
    var subscriptionList = JSON.parse($.cookie("subscription"));
    var count = 0;
    if (subscriptionList)
    {
        for (key in subscriptionList)
        {
            if (subscriptionList[key].discount > 0)
            {
                count++;
            }
        }
    }
    //set the discount number
    if(count!=orgSubscriptionCount)
    {
        //animate the label
        $("#subscriptionNotification").animate({opacity:["toggle", "swing"]},1000, function(){
            $("#subscriptionNotification").animate({opacity:["toggle", "swing"]},500);
        });
    }
    $("#subscriptionNotification").html(count);
}

function initSubscriptionNav()
{
    //subscription click function for nav content
    $(".subscription").click(function(event) {

        loadProductDetails($(this).data("productid"));
        refreshSubscription(subscription);

    });

    $(".subscriptionRemove").click(function(event) {
        event.stopPropagation();
        removeSubscription("", $(this).data("productid"))
        refreshSubscription(subscription);

    });
}

function editCustomer() {
    //load edut customer screen passing in the data. 
    //ajax customer profile and load the template in
    var data = JSON.parse($.cookie("cart")).username;
    data = {username: data};
    $("").ajaxWrapper("/BasketApp/api/Customer/getCustomer", success, fail, JSON.stringify(data), "application/json");
    function success(data)
    {
        custData = data;
        $("#myModal").modal();
        includes("editCustomer_template", data, "#modalContent");
    }
    function fail()
    {
        console.log(">>>>>>>>>>>failed loading user data: navbar_template.html");
    }

}

function updateCustomer()
{

    var myFormValidator = $("#editCustomerForm").validate({
        rules: {
            name: "required",
            dob: "date",
            password: "required",
            address: "required",
            ConfirmPassword: {equalTo: "#PasswordTxt"}
        },
        errorClass: "errorClass"
    });
    var result = myFormValidator.form();
    //serialize form
    if (result)
    {
        var customer = $("#editCustomerForm").toJson();
        customer.username = {username: customer.username, password: customer.password};
        customer.dob = customer.dob + "T00:00:00";
        customer = JSON.stringify(customer);
        $(this).ajaxWrapper("/BasketApp/api/Customer/editCustomer", success, fail, customer, "application/json");
    }
    //------success---------
    function success(data)
    {
        //data
        if (data.error == true)
        {
            console.log("fail");
            //display the error message
            includes("errorPane_template", data, "#msgPane");
        }
        else
        {
            //everything succeeded fine Redirect to login.html.
            console.log("success");
            includes("thankyou_template", {title: "Profile updated.", message: "Profile successfully updated."}, "#modalBody");
            //setTimeout(function(){window.location.replace("login.html");},5000);         

        }
    }
    function fail(data)
    {
        //data
        console.log("add new customer fail");
    }
}

function typeAheadInit()
{
    $("#searchInput").typeahead(null, {
        source: searchProduct,
        displayKey: "name",
        templates: {
            suggestion: Handlebars.compile(
                    '<p>{{name}}  <img src="{{imgPath}}" height="16" style="float:right"></p>'
                    )
        }

    });

    function searchProduct(query, process)
    {
        return $.getJSON('/BasketApp/api/Products/filterProducts/' + query, {}, function(data) {
            return process(data);
        });

    }
}




function setDefaultCurrency()
{
    var geoLoc = navigator.geolocation.getCurrentPosition(getLatLng);
    function getLatLng(position)
    {

        var myPos = {lat: position.coords.latitude, long: position.coords.longitude};
        var myCountry = "";
        var latlng = new google.maps.LatLng(myPos.lat, myPos.long);
        var geocoder = new google.maps.Geocoder();
        geocoder.geocode({'latLng': latlng}, function(results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[6]) {
                    myCountry = results[6].formatted_address;
                }
                else
                {
                    myCountry = results[3].formatted_address;
                }
                console.log(">>>>>>>>>>>>>>>>>>>>>>" + myCountry + "<<<<<<<<<<<<<<<<<<<<<<<");
                $("#currencySelector option").each(function() {

                    if (myCountry.search($(this).data("fullname")) > -1)
                    {
                        console.log(">>>>>>>>>>>>>>>>>>>>>>" + myCountry + "<<<<<<<<<<<<<<<<<<<<<<<");
                        $(this).prop("selected", true);

                    }
                });
            }

        });
    }
}

