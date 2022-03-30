$(document).ready(function () {

    ///////////////////////////////////////////
    //// VIEWMODEL
    var viewHome = {
        //// DECLARATIONS
        index: 0,
        txtMessage: ko.observable(),
        countLoading: 0,

        //// COLLECTIONS / OBJECTS
        //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
        gSafeGuid: getQueryVariable('sid'),
        clientFeatures: ko.observable(),
        objStats: ko.observable(),
        objLanguageLabels: ko.observable(),

        activeServices: ko.observableArray(),
        inActiveServices: ko.observableArray(),

        serviceName: ko.observable(),
        serviceIcon: ko.observable(),
        documentLibraryLink: ko.observable(),
        reportsLink: ko.observable(),
        serviceLocationLink: ko.observable(),


        init: function () {
            viewHome.countLoading = 1;
            viewHome.clientFeatures(getClientFeatures(viewHome.gSafeGuid));
            viewHome.getActiveServices();
            viewHome.setupKendo();

            var displayInactiveServices = getCookie("displayInactiveServices");
            if (displayInactiveServices == "No") {
                viewHome.switchChange($('#tileDisplay'));
                var switchInstance = $("#tileDisplay").data("kendoSwitch");
                switchInstance.check(false);
           }
        },
        

        getActiveServices: function () {
            try {
                var pGSafeGuid = getGSafeGUID();
                var zServiceName = "GetActiveAccountServices";
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewHome.getActiveServicesSuccess, viewHome.getActiveServicesError, null);
            } catch (pException) {
                viewHome.processMessage("An error occurred while starting the account active services data call: " + pException.message);
            }
        },
        getActiveServicesSuccess: function (pResults) {
            try {
                if (pResults.isSuccess) {
                    /* BIND ALL DATA TO TILES */
                    for (var i = 0; i < pResults.data.length; i++) {
                        if (pResults.data[i].colFldStatus == "Active") {
                            //ADJUST LOCATION LINK PARAMETER
                            viewHome.reportsLink("");
                            var tempLocLink = "";
                            var tempDocumentLibLink = "";
                            tempLocLink = SITEBASEURL + "Home_{{VER}}" + pResults.data[i].colFldLocationListingUrl + "?sid=" + viewHome.gSafeGuid;
                            pResults.data[i].colFldLocationListingUrl = tempLocLink;
                            //PUSH ITEM TO ACTIVE COLLECTION
                            viewHome.activeServices.push(pResults.data[i]);
                            viewHome.activeServices.sort(function (l, r) { return l.colFldSortOrder === r.colFldSortOrder ? 0 : l.colFldSortOrder < r.colFldSortOrder ? -1 : 1 });
                        } else {
                            //PUSH ITEM TO INACTIVE COLLECTION
                            viewHome.inActiveServices.push(pResults.data[i]);
                        }
                    }
                    
                    if (viewHome.inActiveServices().length == 0) {
                        $('#greyRow').addClass('noShow');
                        $('#tileSwitchHldr').addClass('noShow');
                    }

                    //viewHome.countLoading--;
                    //if (viewHome.countLoading == 0) {
                    //    viewHome.hideLoadingScreen();
                    //}
                }
            } catch (pException) {
                viewHome.processMessage("An error occurred while completinging the account active services data call: " + pException.message);
            }
        },
        getActiveServicesError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewHome.processMessage("Error while loading contact data. " + pMessage);
        },

        setupKendo: function () {
            $('#tileDisplay').kendoSwitch({
                messages: {
                    checked: "Yes",
                    unchecked: "No"
                },
                width: 65,
                change: function (e) {
                    viewHome.switchChange(e);
                }
            });
        },


        switchChange: function (e) {
            if (!e.checked) {
                //HIDE INACTIVE SERVICES IF USER CHOOSES TO
                $('#greyRow').hide('slow');
                setCookie("displayInactiveServices", "No", 180);
            } else {
                $('#greyRow').show('slow');
               setCookie("displayInactiveServices", "Yes", 180);
            }
        },

        processMessage: function (pMessage) {
            viewHome.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageWarning");
        },

        bindForm: function () {
            ko.applyBindings(viewHome, $("#viewHome")[0]);
        },

        //hideLoadingScreen: function () {
        //    $('#divContainerLoading').hide();
        //},
    };

    //INITIALIZE PAGE
    viewHome.bindForm();
    viewHome.init();


    // GLOBAL FUNCTIONS FOR ACCESS OUTSIDE THE MVVM
    gOnStatClick = function (pPracticeId, pFilterId) {
        viewHome.onStatClick(pPracticeId, pFilterId);
    }

});