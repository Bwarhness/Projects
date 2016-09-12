$("#toggleBar").hover(function (e) {
    e.preventDefault();
    $("#toggleBar").fadeOut(150);
    $("#wrapper").removeClass("toggled");
});
$("#sidebar-wrapper").mouseleave(function (e) {
    console.log("HUEW");
    $("#wrapper").addClass("toggled");
    $("#toggleBar").delay(20).fadeIn(150);
});
function CreateArrangement() {
    $('#CreateArrangement').dialog('open');
    return null;
}
$("#CreateArrangement").dialog({
    autoOpen: false
});
