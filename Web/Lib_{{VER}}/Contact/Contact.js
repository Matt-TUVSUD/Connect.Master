$(document).ready(function () {

    $('#divContainerLoading').show();

    viewContacts = {
        accountContacts: ko.observableArray(),
        emailAddress: ko.observable(),
        countLoading: 0,


        init: function () {
            viewContacts.countLoading = 1;
            viewContacts.loadData();
        },

        loadData: function () {
            try {
                var pGSafeGuid = getGSafeGUID();
                var zServiceName = "GetActiveAccountServiceContacts";
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewContacts.loadDataSuccess, viewContacts.loadDataError, null);
            } catch (pException) {
                viewContacts.processMessage("An error occurred while starting the account service contacts data call: " + pException.message);
            }
        },
        loadDataSuccess: function (pResults) {
            try {
                if (pResults.isSuccess) {
                    viewContacts.accountContacts(pResults.data);
                    
                    viewContacts.countLoading--;
                    if (viewContacts.countLoading == 0) {
                        viewContacts.hideLoadingScreen();
                    }
                }
            } catch (pException) {
                viewContacts.processMessage("An error occurred while starting the account service contacts data call: " + pException.message);
            }
        },
        loadDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewContacts.processMessage("Error while loading contact data. " + pMessage);
        },

        bindForm: function () {
            ko.applyBindings(viewContacts, $("#viewContacts")[0]);
        },

        hideLoadingScreen: function () {
            $('#divContainerLoading').hide();
        },

        processMessage: function (pMessage) {
            viewContacts.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageWarning");
        },
    }

    viewContacts.bindForm();
    viewContacts.init();
});