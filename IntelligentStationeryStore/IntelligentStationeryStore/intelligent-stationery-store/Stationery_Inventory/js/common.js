function getQueryStringParams(sParam) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
        var sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] == sParam) {
            return sParameterName[1];
        }
    }
}

function getQueryString() {
    return window.location.search.substring(1);
}

function showMessage(message, interval) {
    var l_alertBox = $("<div />")
    .appendTo($("body"))
    .attr("class", "alert alert-dismissable alert-success")
    .attr("style", "position:absolute;width:200px;top:10px;left:50%;margin-left:-100px;z-index:9999");
    $("<span />")
    .appendTo(l_alertBox)
    .attr("class", "alert-link")[0].innerText = message;
    $("<button />")
    .appendTo(l_alertBox)
    .attr("type", "button")
    .attr("class", "close")
    .attr("data-dismiss", "alert")[0].innerText = "x";
    if(interval && interval != 0)
        window.setTimeout(function () { $(".alert").alert('close'); }, 2000);
}

function showAlert(message, title, type) {
    if (type === "success")
        type = "alert-success";
    else if (type === "info")
        type = "alert-info";
    else if (type === "danger")
        type = "alert-danger";
    else
        type = "alert-warning";


    var l_divOpacity = $("<div />")
    .appendTo($("body"))
    .attr("style", "position:absolute;width:100%;top:0px;left:0px;z-index:9999;background: rgba(54, 25, 25, .5)")
    .innerHeight(window.innerHeight);

    var l_alertBox = $("<div />")
    .appendTo(l_divOpacity)
    .attr("class", "alert alert-dismissable " + type)
    .attr("style", "position:relative;width:300px;top:40%;left:50%;margin-left:-150px;");

    $("<button />")
    .appendTo(l_alertBox)
    .attr("type", "button")
    .attr("class", "close")
    .attr("data-dismiss", "alert")
    .attr("aria-hidden", "true")[0].innerText = "x";

    $("<h4 />")
    .appendTo(l_alertBox)[0].innerText = title;

    $("<p />")
    .appendTo(l_alertBox)[0].innerText = message;

    var l_btnPanel = $("<p />").appendTo(l_alertBox);

    $("<button />").appendTo(l_btnPanel)
    .attr("class", "btn btn-default")
    .click(function () {
        $(".alert").alert('close');
    })[0].innerText = "OK";

    $('.alert').bind('closed.bs.alert', function () {
        $(l_divOpacity).remove();
    });
}