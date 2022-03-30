$(document).ready(function () {
    ///////////////////////////////////////////
    //// LOAD SESSION VARIABLES
    var dsSession = {
        companyName: "ABC Company",
        loginName: "Gary Kidney"
    };

    ///////////////////////////////////////////
    //// SETUP CONSTANTS
    var monthNames = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    var dayNames = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
    var todayDate = new Date();
    var tempDate = dayNames[todayDate.getDay()] + " " + monthNames[todayDate.getMonth()] + " " + todayDate.getDate() + ", " + todayDate.getFullYear();

    ///////////////////////////////////////////
    //// APPLY VALUES VIA JQUERY
    $("lblCrumbTrail").val("this is a page");
    $("lblCrumbTrailCurrent").val("This is a current page");
    $("lblCompanyNameLarge").val(dsSession.companyName);
    $("lblCompanyNameSmall").val(dsSession.companyName);
    $("lblLoginName").val(dsSession.loginName);
    $("lblTodaysDate").val(tempDate);
});