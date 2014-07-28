
inventoryEvent = null;
function loadProductDetails(productId)
{
    //construct the object
    var success = function(curr)
    {
        var curr = curr;
        return function(data)
        {
            console.log("product load successful");
            //search if product already exists in cookie
            var cart = $.cookie("cart");
            cart = JSON.parse(cart).cart;
            if (cart[productId])
                data.cartQty = cart[productId];
            else
                data.cartQty = 0;
            //load product details intok the modal window
            var target = "#" + curr.prop("id");
            includes("productDetails_template", data, target);

            //subscribes to inventory update
            subscribeInventoryUpdate(data.inventoryId);

            //add to cart button
            $("#btnAddToCart").click(addToCart(productId));
            
            //subscribe button
            $("#btnSubscribe").click(toggleSubscription($("#btnSubscribe"),productId));
        }
    }

    var fail = function(data)
    {
        console.log("Loading product details failed...");
    }
    var request = JSON.stringify({productId: productId});

    //-----------------root-----------------------

    //-----------close inventory sse on modal update------------
    $("#myModal").on("hide.bs.modal", function() {
        if (inventoryEvent) {
            inventoryEvent.removeEventListener(productId, updateInventoryQuantity);
            inventoryEvent.close();
            inventoryEvent=null;
            console.log("closed inventory sse");
        }
    });
    //----------------------------------------------------------
    $("#myModal").modal();
    $("#modalContent").divAjaxWrapper("/BasketApp/api/Products/details", success, fail, request, "application/json");

}

function subscribeInventoryUpdate(productId)
{
    if(!inventoryEvent)        
        inventoryEvent = new EventSource("/BasketApp/inventory");
    inventoryEvent.addEventListener(productId, updateInventoryQuantity);
 
}

function updateInventoryQuantity(data)
{

    var updateData = JSON.parse(data.data);
    $("#lblQty").text(updateData.qty);
    
}

function addToCart(currProductId)
{
    var productId = currProductId;
    return function()
    {
        //add to cart
        //check the quantity
        var cart = $.cookie("cart");
        //cart must exists
        cart = JSON.parse(cart).cart;
        var remainingQty = $("#lblQty").data("qty");
        qtyToAdd = Number($("#qtyToAdd").val());
        if (cart[productId])
            qtyToAdd += Number(cart[productId].qty);

        if (qtyToAdd > remainingQty)
        {
            //insufficient stock
            $("#msgPane").fadeOut("slow", function() {
                $("#msgPane").html("<center>Stock is insufficient. You have added "+qtyToAdd+". Only "+remainingQty+" is available.</center>");
                $("#msgPane").removeClass("alert-success");
                $("#msgPane").addClass("alert-warning");
                $("#msgPane").fadeIn("slow");
                $("#msgPane").removeClass("hide");
            });
        }
        else if (qtyToAdd <= 0)
        {
            $("#msgPane").fadeOut("slow", function() {
                $("#msgPane").html("<center>Quantity cannot be less than zero. Please try again</center>");
                $("#msgPane").removeClass("alert-success");
                $("#msgPane").addClass("alert-warning");
                $("#msgPane").fadeIn("slow");
                $("#msgPane").removeClass("hide");
            });
        }
        else
        {
            //add to cookie

            //check if entry already exists in cart
            if (cart[productId])
            {
                var qty = cart[productId].qty;
                qty = Number(qty) + Number(qtyToAdd);
                cart[productId].qty = qty;
            }
            else //does not exists, create a new entry
            {
                var updateProduct = {name: $("#lblProductName").data("productname"), qty: $("#qtyToAdd").val(), price: $("#lblPrice").data("price"), discount:$("#hiddenDiscount").val()};
                cart[productId] = updateProduct;
            }

            //update cart
            var updateCookieCart = JSON.parse($.cookie("cart"));

            updateCookieCart.cart = cart;
            updateCookieCart = JSON.stringify(updateCookieCart);
            $.cookie("cart", updateCookieCart);

            //update navigation bar shopping cart count
            cartCountUpdate();
            //notify user 
            $("#msgPane").fadeOut("slow", function() {
                $("#msgPane").removeClass("alert-warning");
                $("#msgPane").html("<center>This item has been added to cart</center>");
                $("#msgPane").addClass("alert-success");
                $("#msgPane").fadeIn("slow");
                $("#msgPane").removeClass("hide");
            });

        }
    }

}

