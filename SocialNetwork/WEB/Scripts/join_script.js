$(document)
    .ready(function () {

        joinTabClick();


    });


function joinTabClick() {
    $(".action__choose a")
        .on("click",
            function (e) {

                if (!$(this).parent().hasClass("is-active")) {

                    $(this).parent().addClass("is-active");
                    $(this).parent().siblings().removeClass("is-active");

                    //var target = $(this).attr("href");
                    //$(".join__body > form").not(target).hide();
                    //$(target).css("display", 'flex');
                }
            }
    );
}

var pushHistory = true;

function joinTabClick(href) {
    $(".join__action a[href=\"" + href + "\"]").trigger("click");
}

function onSuccess(elem, data) {

var href = $(elem).attr("href");
    if (history.state === null || history.state.href != href)
        history.pushState({ data: data, href: href }, "", href);
}

window.onpopstate = function(event) {
    if (event.state != null) {
        var href = event.state.href;
        joinTabClick(href);
    }
};