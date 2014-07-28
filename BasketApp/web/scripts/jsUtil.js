/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

//---------------------Currency-----------------------------------
function toast(msg)
{
    var newToast = $("<div>").addClass("toast");

    $(newToast).html("<center>" + msg + "</center>");
    var toastWidth = 200;
    var toastHeight = 50;
    var toastWidth = $(window).width() / 3;
    $(newToast).css("width", toastWidth);

    var top = $(window).height() - 50;
    var left = ($(window).width() / 2) - (toastWidth / 2);


    $(newToast).css("top", top + 100).css("left", left);
    $(newToast).show();
    $("body").append(newToast);

    $(newToast).animate({top: top}, 800, "linear", function() {
        //after animation
        setTimeout(function() {
            $(newToast).fadeOut("slow", function() {
                $(this).remove();
            });
        }, 2000);
    });


}


function formatCurrency(num)
{
    num = num.toString().replace(/\$|\,/g, '');
    if (isNaN(num))
    {
        num = "0";
    }

    sign = (num == (num = Math.abs(num)));
    num = Math.floor(num * 100 + 0.50000000001);
    cents = num % 100;
    num = Math.floor(num / 100).toString();

    if (cents < 10)
    {
        cents = "0" + cents;
    }
    for (var i = 0; i < Math.floor((num.length - (1 + i)) / 3); i++)
    {
        num = num.substring(0, num.length - (4 * i + 3)) + ',' + num.substring(num.length - (4 * i + 3));
    }
    if (typeof currencySymbol != 'undefined')
    {
        return (((sign) ? '' : '-') + currencySymbol + num + '.' + cents);
    }
    else
        return (((sign) ? '' : '-') + "$" + num + '.' + cents);
}

//--------------------END CURRENCY--------------------------------

//-------------shopping cart number update--------------------------
function cartCountUpdate()
{
    console.log("cartUpdate callback");
    var cookie = $.cookie("cart");
    cookie = JSON.parse(cookie).cart;
    var count = Object.keys(cookie).length;
    $("#cartCounter").html(count);
}
function cartToJsonArray(cart)
{
    resultArray = new Array();
    $.each(cart, function(k, v) {
        var newObj = v;
        newObj["productId"] = k;
        resultArray.push(newObj);
    });

    return resultArray;
}
function numberValidator(target)
{
    $(target).keyUp(function() {

    });
}
//--------------Shopping cart number update---------------------------
(function($) {
//--------- Converts a form serializedArray to a JSON object---------------

    $.fn.toJson = function()
    {
        console.log("running toJson");
        var jsonObj = {};
        var formArray = this.serializeArray();
        for (var i = 0; i < formArray.length; i++)
        {
            var ff = formArray[i];
            if (jsonObj[ff.name])
            {
                if (!jsonObj.push) //if not array
                {
                    jsonObj[ff.name] = [jsonObj[ff.name]];
                    jsonObj[ff.name].push(ff.value);
                }
                else //if push is available
                {
                    jsonObj[ff.name].push(ff.value);
                }
            }
            else
            {
                jsonObj[ff.name] = ff.value;
            }
        }
        return jsonObj;
    }

}(jQuery));

(function($) {
    $.fn.ajaxWrapper = function(url, success, fail, data, contentType, myClass, changeText)
    {
        //append loading div
        toChangeText = null;
        if (changeText != null)
            toChangeText = changeText;
        else
            toChangeText = true;
        var curr = this;
        var currOrgText = this.text();
        var currClass = myClass || "btn-loading";
        this.addClass(currClass);
        this.text("...");
        //do ajax call
        var curr_contentType = contentType || "application/x-www-form-urlencoded;charset=UTF-8";

        $.ajax({
            contentType: curr_contentType,
            type: "POST",
            data: data,
            url: url,
        }).done(success).fail(fail).always(function() {
            curr.removeClass(currClass);
            if (toChangeText)
                curr.text(currOrgText);
        });

        //async o
        return this;
    }

}(jQuery));


//-------------ajaxWrapper for div----------------------
(function($) {
    $.fn.divAjaxWrapper = function(url, success, fail, data, contentType)
    {
        //append loading div

        $(this).fadeOut(0);
        var curr = this;
        var currOrgText = this.text();
        //var currClass = "div-loading";
        //var loaderDiv = $("<div>").prop("id", "loader");

        //$(this).append(loaderDiv);
        //includes("divLoading_template", {}, "#loader");
        


        //do ajax call
        var curr_contentType = contentType || "application/x-www-form-urlencoded;charset=UTF-8";

        $.ajax({
            contentType: curr_contentType,
            type: "POST",
            data: data,
            url: url,
        }).done(success(curr)).fail(fail).always(function() {
            //console.log(">>>removing<<<<" + $(curr).prop("id"));
            //$(curr).find("#loader").remove();
            $(curr).fadeIn("slow");            
        });

        //async o
        
        return this;
    }

}(jQuery));


//--------------HANDLEBARS TEMPLATE INJECTION-------------------------
function includes(tmpl_name, tmpl_data, target)
{

    var tmpl_dir = "/BasketApp/templates";
    var tmpl_url = tmpl_dir + "/" + tmpl_name + ".html";
    console.log("template url>>> " + tmpl_url);
    var tmpl_string;

    $.ajax({
        url: tmpl_url,
        method: 'GET',
        async: false,
        success: function(data) {
            tmpl_string = data;
        }
    });

    //console.log("template_data>>>> "+tmpl_string);

    var hFunction = Handlebars.compile(tmpl_string);

    $(target).html(hFunction(tmpl_data));
    //$(target).html("hello world");

}
//--------------END HANDLEBARS INJECTION-------------------------------


//--------------HANDLEBAR CUSTOM BLOCK-------------------------
Handlebars.registerHelper('isAuthenticated', function(context, options) {
    var result = $.cookie('verified');

    if (result != null && result == 'true')
        return options.fn(this);
    else
        return options.inverse(this);
});

Handlebars.registerHelper('currency', function(object) { //add multiply rate
    //format currency
    var result = formatCurrency((object * currencyRate));
    return result;
});



//---------------Handlebars custom block shorten-------------------------
Handlebars.registerHelper('shorten', function(object) {
    //-----How many words-------------
    var wordCount = 20;
    //-------------------------------
    var stringArray = object.split(' ');
    var result = "";
    var count = 0;
    if (stringArray.length >= wordCount)
        count = wordCount;
    else
        count = stringArray.length;

    for (i = 0; i < count; i++)
    {
        result = result + ' ' + stringArray[i];
    }
    result += "...";
    return result;
});

//TODO: Discount
Handlebars.registerHelper("mult", function(a, b, c, options) {//add another variable for discount
    if (!c)
        c = 0.0;
    return ((a * (1 - (c/100))) * b);
});

Handlebars.registerHelper("grandtotal", function(a, b, array, options) {
    var grandTotal = 0.0;
    for (i = 0; i < array.length; i++)
    {
        grandTotal += ((array[i][a] * (1 - (array[i]["discount"]/100))) * array[i][b]);
    }
    return grandTotal;
});
Handlebars.registerHelper("finalPrice", function(price, discount, options) {
    if (!discount)
        discount = 0.0;
    return (price * (1 - (discount/100)));
});

//----checks discounts-----//
Handlebars.registerHelper("hasDiscount", function(discount, options) {
    if (discount > 0)
    {
        return options.fn(this);
    }
    else
    {
        return options.inverse(this);
    }
});

Handlebars.registerHelper("isSubscribed", function(productId, options)
{
    var subscriptionList = JSON.parse($.cookie("subscription"));
    if (subscriptionList[productId])
        return options.fn(this);
    else
        return options.inverse(this);

});

Handlebars.registerHelper("radioCheck", function(value, eqValue, options)
{
    if (value === eqValue)
        return "checked";
    else
        return "";

});

Handlebars.registerHelper("dateFormat", function(date)
{
    var newDate = date.replace("T00:00:00", "");
    return newDate;
});

Handlebars.registerHelper("eq", function(a,b,options){
   if(a==b)
       return options.fn(this);
   else
       return options.inverse(this);
});

Handlebars.registerHelper("inStock", function(stock,options){
   if(stock<=0)
   {
       return options.inverse(this);
   }
   else
   {
       return options.fn(this);
   }
});