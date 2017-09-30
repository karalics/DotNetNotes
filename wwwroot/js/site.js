// Write your JavaScript code.
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

