﻿// Write your JavaScript code.
if (localStorage.getItem("modus")=== "night"){
    $(".main").addClass("night");
    $(".change-style").text("Day Modus");    
} else {
    $(".main").removeClass("night");
    $(".change-style").text("Night Modus");    
}

$(".change-style").click(()=>{
    var night = "night";
    var main = $(".main");
    
   if(main.hasClass(night)) {  
     main.removeClass("night");
     $(".change-style").text("Night Modus");
     localStorage.setItem("modus", "day");
    } else {
     main.addClass("night");
     $(".change-style").text("Day Modus");
     localStorage.setItem("modus", "night");
    }
});

$(".hider").click(() =>{
    var link = $(this);
    $(".is-finished").toggle(400, () => {
        if ($(this).is(':hidden')){
            link.text("Show Finished");
        } else {
            link.text("Hide Finished");
        }
    });
    $(".hider").text("Show Finished");

});

