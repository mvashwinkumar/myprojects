$(function() {

    console.log("List Products loaded");
    //>>>>>>>mock cookie data<<<<<<<<<<<

    //>>>>>>>>>>>>>END<<<<<<<<<<<<<<<<<</script>


    maxResults = 0;
    resultsPerPage = $("#optResultsPerPage").val();
    currentPage = 1;
    //pagination setup      

    $("#optResultsPerPage").change(function() {
        console.log("change results per page");
        resultsPerPage = $(this).val();
        currentPage = 1;
        listProducts();
    });


//----------------------List Products------------------------------------>>>>>>
//-------------------------
    function listProducts()
    {
        function success(curr)
        {
            //data
            var curr = curr;
            return function(data)
            {
                maxResults = data.maxResults;

                var productList = data.products;
                var productListing = $("<div>").prop("id", "productListing");
                $(curr).append(productListing);
                var id = $(curr).prop("id");
                includes("listProducts_template", productList, "#" + id);
                var paginationOptions = {
                    currentPage: currentPage,
                    bootstrapMajorVersion: 3,
                    totalPages: Math.ceil(maxResults / resultsPerPage),
                    onPageClicked: function(e, originalEvent, type, page)
                    {
                        currentPage = page;
                        listProducts();
                    }
                }
                $("#productPagination").bootstrapPaginator(paginationOptions);
                //click function
                $("input[id^='details_']").click(function() {
                    //extract product id
                    var productId = $(this).data("productid");
                    loadProductDetails(productId);
                    //$("#myModal").modal();
                });
            };
        }

        //-----fail function------
        function fail(data)
        {
            console.log("fail");
        }
        //-------end fail-----------

        var request = {resultsPerPage: resultsPerPage, currentPage: currentPage};
        request = JSON.stringify(request);
        $("#content").divAjaxWrapper("/BasketApp/api/Products/get", success, fail, request, "application/json");
    }
//--------------------------------------------
//----------------------------------List Products------------------------------------->>>>

//-------------------------search products-------------------------------


//----------------------end search products-------------------------------



    listProducts();


    //open product details

});


function listProducts()
{
    function success(curr)
    {
        //data
        var curr = curr;
        return function(data)
        {
            maxResults = data.maxResults;

            var productList = data.products;
            var productListing = $("<div>").prop("id", "productListing");
            $(curr).append(productListing);
            var id = $(curr).prop("id");
            includes("listProducts_template", productList, "#" + id);
            var paginationOptions = {
                currentPage: currentPage,
                bootstrapMajorVersion: 3,
                totalPages: Math.ceil(maxResults / resultsPerPage),
                onPageClicked: function(e, originalEvent, type, page)
                {
                    currentPage = page;
                    listProducts();
                }
            }
            $("#productPagination").show();
            $("#productPagination").bootstrapPaginator(paginationOptions);
            //click function
            $("input[id^='details_']").click(function() {
                //extract product id
                var productId = $(this).data("productid");
                loadProductDetails(productId);
                //$("#myModal").modal();
            });
        };
    }

    //-----fail function------
    function fail(data)
    {
        console.log("fail");
    }
    //-------end fail-----------
    $("#productPagination").hide();
    var request = {resultsPerPage: resultsPerPage, currentPage: currentPage};
    request = JSON.stringify(request);
    $("#content").divAjaxWrapper("/BasketApp/api/Products/get", success, fail, request, "application/json");
}




function filterProducts()
{
    function success(curr)
    {
        //data
        var curr = curr;
        return function(data)
        {
            maxResults = data.maxResults;
            
            var productList = data.products;
            var productListing = $("<div>").prop("id", "productListing");
            $(curr).append(productListing);
            var id = $(curr).prop("id");
            productList["filter"] = "true";
            productList["keyword"] = $("#searchInput").val();
            includes("listProducts_template", productList, "#" + id);
            var paginationOptions = {
                currentPage: currentPage,
                bootstrapMajorVersion: 3,
                totalPages: Math.ceil(maxResults / resultsPerPage),
                onPageClicked: function(e, originalEvent, type, page)
                {
                    currentPage = page;
                    filterProducts();
                }
            }
            $("#productPagination").show();
            $("#productPagination").bootstrapPaginator(paginationOptions);
            //click function
            $("input[id^='details_']").click(function() {
                //extract product id
                var productId = $(this).data("productid");
                loadProductDetails(productId);
                //$("#myModal").modal();
            });
        };
    }

    //-----fail function------
    function fail(data)
    {
        console.log("fail");
    }
    //-------end fail-----------
    
    //currentPage=1;
    $("#productPagination").hide();
    var request = {resultsPerPage: resultsPerPage, currentPage: currentPage, keyword: $("#searchInput").val()};
    request = JSON.stringify(request);

    $("#content").divAjaxWrapper("/BasketApp/api/Products/filterProducts", success, fail, request, "application/json");
}
