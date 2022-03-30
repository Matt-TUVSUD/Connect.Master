$(document).ready(function () {

    var viewNav = {
        userGUID: ko.observable(getGSafeGUID()),
        systemNode: ko.observable("mainmenu"),

        bindForm: function () {
            ko.applyBindings(viewNav, $("#viewNav")[0]);
        },

    }

    //INITIALIZE PAGE
    viewNav.bindForm();
    loadMenu();
    
});

// SIDE NAV MENU VARIABLES AND FUNCTIONS
var navMenuVertical = null;
var loadMenu = function () {
    try {
        var zServiceName = "GetAllMenuItems";
        var zParms = ko.toJSON({
            "pGSafeGuid": getGSafeGUID(),
            "pPageType": "side"
        });
        global.callRestServiceCached(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, loadMenuSuccess, loadMenuError, null);
    } catch (pException) {
        global_hideLoading();
        alert("An error occurred while starting the menu data load call: " + pException.message);
    }
}
var loadMenuSuccess = function (pResults, pParms) {
    try {
        if (pResults.isSuccess) {
            // BUILD THE MENU
            
            $("#navMenuVertical").kendoPanelBar({
                dataSource: pResults.data,
                expandMode:"single",
                select: function (e) {
                    if ($(e.item).is('.k-state-active')) {
                        var that = this;
                        window.setTimeout(function () { that.collapse(e.item); }, 1);
                    }
                }
            });
            navMenuVertical = $("#navMenuVertical").data("kendoPanelBar");

            // PROCESS THE COUNT
            global_processLoading();
        } else {
            global_hideLoading();
            alert("(806) An error occurred while loading menu data: " + pResults.message);
        }
    } catch (pException) {
        global_hideLoading();
        alert("(811) An error occurred while loading menu data: " + pException.message);
        
    }
    global_processLoading();
}
var loadMenuError = function (pResults, pMessage, pErrorDetail, pParms) {
    global_hideLoading();
    alert("(818) Error while making the load menu data call. " + pMessage + " - " + pResults.responseText);
}