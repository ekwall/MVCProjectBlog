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


});