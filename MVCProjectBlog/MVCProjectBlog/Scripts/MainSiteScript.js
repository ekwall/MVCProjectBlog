$(document).ready(function () {

    var availableBlogsContainerWidth = $(".AvailableBlogsContainer").innerWidth();
    var newHeightOfDiv = availableBlogsContainerWidth/3*2;
    $(".AvailableBlogsContainer").css({
        "height": newHeightOfDiv
    });


});