$(document).ready(function () {

    var availableBlogsContainerWidth = $(".AvailableBlogsContainer").innerWidth();
    var newHeightOfDiv = availableBlogsContainerWidth/3*2;
    $(".AvailableBlogsContainer").css({
        "height": newHeightOfDiv
    });


    

//    $(".AvailableBlogsContainer").click(
//    function(){$(this).animate({width: "400px", height:"400px"}, 500);},        
//    function(){$(this).animate({width: "400px", height:"400px"}, 500);}
    //);

    $(".fadeInCommentTest").click(
        function() {

            runEffect();
        });

    $(".fadeout").click(
        function () {

            fadeOut();
        });



});

function runEffect() {
    // get effect type from


    $(".fadeInCommentTest > div").fadeOut();
};

function fadeOut() {
    // get effect type from


    $(".testHideDivId").fadeOut();
};