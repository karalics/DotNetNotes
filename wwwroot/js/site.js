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

$(".hider").click(() =>{
    var link = $(this);
    $(".is-finished").toggle(400, () => {
        if ($(".is-finished").is(":hidden")) {
            $(".hider").text("Show Finished");
        } else {
            $(".hider").text("Hide Finished");
        }
    });
        
});

