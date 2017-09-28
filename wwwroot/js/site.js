// Write your JavaScript code.
$(".change-style").click(()=>{
    var night = 'night';
    var main = $(".main");
    if(main.hasClass(night)) {
        main.removeClass("night");
    } else {
        main.addClass("night");
    }
});