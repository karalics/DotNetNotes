// Write your JavaScript code.
if (localStorage.getItem("modus")=== "night"){
    $(".main").addClass("night");
    $(".change-style").text("Day Modus");    
} else {
    $(".main").removeClass("night");
    $(".change-style").text("Night Modus");    
}

/*
if (localStorage.getItem("showItemFinished")=== true){
    $(".main").addClass("is-finished");
    $(".change-style").text("Show Finished");    
} else {
    $(".main").removeClass("is-finished");
    $(".change-style").text("Hide Finished");    
}
*/

$(".change-style").click(()=>{
    var night = "night";
    var main = $(".main");
    
   if(main.hasClass(night)) {  
     main.removeClass(night);
     $(".change-style").text("Night Modus");
     localStorage.setItem("modus", "day");
    } else {
     main.addClass(night);
     $(".change-style").text("Day Modus");
     localStorage.setItem("modus", "night");
    }
});

var hidemode = localStorage.getItem("hidemode");
if (hidemode === "true"){
    $(".is-finished").hide();
    $(".hider").text("Show Finished");
} else {
    $(".is-finished").show();
    $(".hider").text("Hide Finished");
}

$(".hider").click(() =>{
    if (localStorage.getItem("hidemode") === "true") {
        $(".is-finished").show(400);
        $(".hider").text("Hide Finished");
        localStorage.setItem("hidemode", false);
    } else {
        $(".is-finished").hide(400);
        $(".hider").text("Show Finished");
        localStorage.setItem("hidemode", true);
    }
    });


