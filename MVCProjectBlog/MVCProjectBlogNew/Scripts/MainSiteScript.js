$(document).ready(function () {

    var availableBlogsContainerWidth = $(".AvailableBlogsContainer").innerWidth();
    var newHeightOfDiv = availableBlogsContainerWidth/3*2;
    $(".AvailableBlogsContainer").css({
        "height": newHeightOfDiv
    });


    startUp();


    $(".fadeToggleClass").click(
        function() {
            var pressedElement = $(this);
            runEffect(pressedElement);
        });

    $(".fadeout").click(
        function () {

            fadeIn();
        });



});

function runEffect(pressedElement) {
   
    
    pressedElement.next().fadeToggle();
        //.fadeToggle();
};

function fadeOut() {
    // get effect type from


    $(".testHideDivId").fadeOut();
};

function startUp() {
    $(".testHideDivId").hide();
}