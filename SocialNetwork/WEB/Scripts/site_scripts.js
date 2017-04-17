$(document).ready(function() {
    $(".action__choose a")
        .on("click",
            function(e) {

                if (!$(this).parent().hasClass("is-active")) {

                    $(this).parent().addClass("is-active");
                    $(this).parent().siblings().removeClass("is-active");

                    var target = $(this).attr("href");
                    $(".join__body > form").not(target).hide();
                    $(target).css("display", 'flex');
                }

            });
}) 
    




// function changeAuthTab(active) {
//     if (!active.classList.contains('is-active')) {

//         removeClass();        
//         active.classList.add('is-active');
//         showRightForm();   
//     }

//     function isElementHidden(element) {
//         return window.getComputedStyle(element,null).getPropertyValue('display')  == "none";
//     }

//     function removeClass() {
//         var liElements = active.parentElement.children;

//         for (var i = 0; i < liElements.length; i++) {
//             if (liElements[i] != active) {
//                 liElements[i].classList.remove('is-active');
//             }
                
//         }
//     }

//     function showRightForm () {
//         var elements = document.querySelectorAll('div.join__body > div ');

//         for (var i = 0; i < elements.length; i++) {

//             if (isElementHidden(elements[i]))
//                 elements[i].style.display = "flex";
//             else {
//                 elements[i].style.display = "none";
//             }
//         }
//     }


// }

// function changeForm(active) {

// }

