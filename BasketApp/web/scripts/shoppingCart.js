/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

function hoverShoppingCart()
{
    //populate the dropdown first
    //cartContents
    //cartToJsonAraray
    var cookie = $.cookie("cart");
    if (cookie)
    {
        if (Object.keys(JSON.parse(cookie).cart).length <= 0)
        {
            $("#cartContents").html("<center>No items in shopping cart</center>");
        }
        else
        {
            var result = cartToJsonArray(JSON.parse(cookie).cart);
            includes("hoverShoppingCart_template", result, "#cartContents");
        }
    }
    $(this).dropdown("toggle");
}

function showShoppingCart()
{
    //get quantity for shopping cart
    var productArray = new Array();
    var productList = JSON.parse($.cookie("cart")).cart;
    for (keys in productList)
    {
        productArray.push({inventoryId: keys});
    }
    $("").ajaxWrapper("/BasketApp/api/Products/getStock", success, function() {
        console.log("fail updating stock")
    }, JSON.stringify(productArray), "application/json");
    //

    function success(data)
    {
        var cookie = $.cookie("cart");
        if (cookie)
        {
            if (Object.keys(JSON.parse(cookie).cart).length <= 0)
                includes("shoppingCartModalEmpty_template", {}, "#modalContent");
            else
            {
                //push stock to cart
                cookie = JSON.parse(cookie).cart;
                for (i = 0; i < data.length; i++)
                {
                    var productId = data[i].inventoryId;
                    if (cookie[productId])
                        cookie[productId].stock = data[i].quantity;
                }

                var result = cartToJsonArray(cookie);
                includes("shoppingCartModal_template", result, "#modalContent");

                //init shopping cart
                initShoppingCart();
                checkCart();
                startListeners();
            }
            $("#myModal").modal("toggle");
        }
    }
}

//---------------Remove Items----------------------------------
function removeItem(target)
{
    //remove from cookie
    var selectedId = $(this).data("productid");
    var myCookie = $.cookie("cart");
    myCookie = JSON.parse(myCookie);
    delete myCookie.cart[selectedId];
    $.cookie("cart", JSON.stringify(myCookie));
    //reload the page
    $("#cartContents").fadeOut("slow", function() {
        var result = cartToJsonArray(JSON.parse($.cookie("cart")).cart);
        if (result.length > 0)
        {
            includes("shoppingCartModal_template", result, "#modalContent");
            initShoppingCart();
        }
        else
            includes("shoppingCartModalEmpty_template", {}, "#modalContent");

    });
    cartCountUpdate(); //jsUtil.js
    $("#cartContents").fadeIn("slow");
}

//-----------------------Update cart--------------------------------------
function updateCart(target)
{
    var productArray = new Array();
    var productList = JSON.parse($.cookie("cart")).cart;
    for (keys in productList)
    {
        productArray.push({inventoryId: keys});
    }
    $("#btnUpdate").ajaxWrapper("/BasketApp/api/Products/getStock", success, function() {
        console.log("fail updating stock")
    }, JSON.stringify(productArray), "application/json");

    //success function
    function success(data)
    {
        messages = "";
        $("input[id^=inputNum]").each(function(index, value) {
            var selectedId = $(this).data("productid");
            var cart = JSON.parse($.cookie("cart")).cart;
            if ($(this).val() <= 0)
            {

                delete cart[selectedId];
            }
            else
            {
                //compare with max stock in inventory
                var msg = new Array();
                $.each(data, function(k, v) {
                    if ((v.inventoryId) == selectedId)
                    {
                        //check stock
                        if ($(value).val() > v.quantity)
                        {
                            msg.push("There is insufficient stock for " + v.name + ". Only " + v.quantity + " is available");
                        }
                        else
                        {
                            cart[selectedId].qty = $(value).val(); //set quantity to input box value
                        }
                    }
                });
            }
            //update cookie
            var updateCookie = JSON.parse($.cookie("cart"));
            updateCookie.cart = cart;
            $.cookie("cart", JSON.stringify(updateCookie)); //double check
            //update cart display
            if (Object.keys(cart).length > 0)
            {
                var cookie = JSON.parse($.cookie("cart")).cart;
                for (i = 0; i < data.length; i++)
                {
                    var productId = data[i].inventoryId;
                    if (cookie[productId])
                        cookie[productId].stock = data[i].quantity;
                }
                includes("shoppingCartModal_template", cartToJsonArray(cookie), "#modalContent");
            }
            else
                includes("shoppingCartModalEmpty_template", {}, "#modalContent");
            if (msg && msg.length > 0) //there is error
            {
                //messages = "<ul>"
                $.each(msg, function(k, v) {
                    messages += "<li>" + v + "</li>";
                });
                //messages += "</ul>"



            }

            initShoppingCart();
        });
        cartCountUpdate();//update cart count
        if (messages != "")
        {
            
            $("#cartMsgPane").addClass("alert").addClass("alert-warning");
            $("#cartMsgPane").html("<ul>"+messages+"</ul>");
        }
    }
}

function initShoppingCart()
{

    $("button[id^=removeBtn]").click(removeItem);
    //updateBtn click
    $("#btnUpdate").click(updateCart);
    $("#btnCheckout").click(checkout);
    $("#btnOrder").click(order);
    $("#btnCancelCheckout").click(cancelCheckout);
}

function cancelCheckout()
{
    console.log("cancelling checkout");
    $("#cartButtonDiv").toggle(0);
    $("#checkoutButtonDiv").toggle(0);
    $("#checkoutContent").html("");
}

function checkCart()
{
    var result = true;
    var errorMessage = "";
    $("input[id^=inputNum_]").each(function() {
        var productId = $(this).data("productid");
        var currStock = $("#lblStock_" + productId).text();
        var cart = JSON.parse($.cookie("cart"));
        var qty = $(this).val();
        //check zero
        if (Number(qty) <= 0)
        {
            //remove the product
            delete cart.cart[productId];
            $.cookie("cart", JSON.stringify(cart));
            if (Object.keys(cart.cart).length <= 0)
            {
                //$.cookie("cart", JSON.stringify(cart));
                cartCountUpdate();
                includes("shoppingCartModalEmpty_template", {}, "#modalContent");
                result = false;
                return;
            }
        }


        if (Number(currStock) < Number(qty))
        {
            result = false;
            errorMessage += "<li>There is insufficient stock for " + $("#lblName_" + productId).text() + ".";
        }
        else
        {
            if (cart.cart[productId])
                cart.cart[productId].qty = qty;
        }
        $.cookie("cart", JSON.stringify(cart));

    });
    if (!result)
    {


        $("#cartMsgPane").show();
        $("#cartMsgPane").removeClass("alert").removeClass("alert-warning");
        $("#cartMsgPane").addClass("alert").addClass("alert-warning");
        $("#cartMsgPane").html("<ul>" + errorMessage + "</ul>");

    }
    var temp = "";
    return result;
}

function checkout()
{
    //check quantities

    if (checkCart())
    {
        //$("#cartMsgPane").hide();
        $("#cartButtonDiv").toggle(0);
        $("#checkoutButtonDiv").toggle(0);
        var address = JSON.parse($.cookie("cart")).address;
        includes("checkout_template", {address: address}, "#checkoutContent");
        $("#addressRadio1").prop("checked", true);
        $(".myradios").click(function() {

            var currRadio = $(this).prop("id");
            //find other
            $(".myradios").each(function() {
                if ($(this).prop("id") != currRadio)
                    $(this).prop("checked", false);
            })
        });
    }
}

//For making the purchase order - END OF USE CASE
function order()
{
    if (checkCart())
    {
        //Check which delivery button is chosen
        //if (checkOrder())
        var addressType = 1;
        if ($("#addressRadio1").prop("checked"))
            addressType = 0;
        var address = "";
        var validateResult = true;
        if (addressType == 0)
        {
            //built in address;
            address = $("#lblOrgAddress").text();
        }
        else
        {
            address = $("#lblNewAddress").val();
            //some validation?        
            var validator = $("#addressForm").validate({
                rules: {
                    newAddress: {
                        required: true,
                    }
                },
                errorClass: "errorClass"
            });
            validateResult = validator.form();
        }
        //$(".myRadios").find(":selected");
        //
        //authenticate the delivery address
        //
        //
        //store it for email
        //
        //order function
        //building order from cookie
        if (validateResult)
        {
            var cart = JSON.parse($.cookie("cart"));
            var username = cart.username;
            var cartArray = cartToJsonArray(cart.cart);

            var orderObj = {};
            orderObj.username = username;
            orderObj.orderItems = [];
            for (i = 0; i < cartArray.length; i++)
            {
                var newItem = {inventoryId: cartArray[i].productId, quantity: cartArray[i].qty, discount: cartArray[i].discount};
                orderObj.orderItems.push(newItem); //add to array
            }
            orderObj.address = address;
            //check here for json format
            orderObj = JSON.stringify(orderObj);//json object is good to go
            $("#btnUpdate").ajaxWrapper("/BasketApp/api/Orders/checkout", success, fail, orderObj, "application/json");
            function success(data)
            {
                //check if there is any error message
                if (data.error)
                {
                    $("#cartMsgPane").addClass("alert alert-danger");
                    $("#cartMsgPane").html("<center>" + errorMessage + "</center>");
                }
                else
                {
                    //no error
                    //get cookie for one last time
                    var cart = JSON.parse($.cookie("cart"));
                    cart = cart.cart;
                    cart = cartToJsonArray(cart);
                    //add address to cart for display
                    cart.address = address;
                    includes("CheckoutSuccess_template", cart, "#modalContent");
                    //delete cookie
                    cart = JSON.parse($.cookie("cart"));
                    cart.cart = {};
                    $.cookie("cart", JSON.stringify(cart));
                    cartCountUpdate();
                    listProducts();
                }
            }
            function fail(data)
            {
                console.log("checkout fail");
            }
        }
    }
}

function startListeners()
{
    var cart = JSON.parse($.cookie("cart"));
    cart = cartToJsonArray(cart.cart);
    if (!inventoryEvent)
        inventoryEvent = new EventSource("/BasketApp/inventory");

    for (i = 0; i < cart.length; i++)
    {
        inventoryEvent.addEventListener(cart[i].productId, updateCartInventory);
    }

    function updateCartInventory(data)
    {
        //update lblStock
        var stockData = JSON.parse(data.data);
        $("#lblStock_" + stockData.productId).text(stockData.qty);
        //check stock input value
        if ($("#inputNum_" + stockData.productId).val() > stockData.qty)
        {
            //show alert message
            $("#cartMsgPane").addClass("alert").addClass("alert-warning");
            var existingHtml = $("#cartMsgPane").html();
            $("#cartMsgPane").html(existingHtml + " <p>There is insufficient stock for " + $("#lblName_" + stockData.productId).text() + ". Please update the order quantity</p>");
            $("#btnCheckout").prop("disabled", true);
            $("#btnOrder").prop("disabled", true);
        }


    }

}
