$(document).ready(function () {
    var viewReports = {
        countLoading: 0,
        userGUID: ko.observable(getGSafeGUID()),
        systemNode: ko.observable("reports"),
        panelData: ko.observableArray(),
        favoritePanelData: ko.observableArray(),
        batchReportsPanelData: ko.observableArray(),
        allServicesPanelData: ko.observableArray(),
        hideAllServicesPanel: ko.observable(false),
        firePanelData: ko.observableArray(),
        hideFirePanel: ko.observable(false),
        bmPanelData: ko.observableArray(),
        hideBmPanel: ko.observable(false),
        irPanelData: ko.observableArray(),
        hideIrPanel: ko.observable(false),
        jurisPanelData: ko.observableArray(),
        hideJurisPanel: ko.observable(false),
        natHazPanelData: ko.observableArray(),
        hideNatHazPanel: ko.observable(false),
        divSrvPanelData: ko.observableArray(),
        hideDivServPanel: ko.observable(false),
        procSafetyPanelData: ko.observableArray(),
        hideProcSafetyPanel: ko.observable(false),
        selectedPanel: ko.observable(),
        FLfirePanelData: ko.observableArray(),
        FLBMPanelData: ko.observableArray(),
        FLIRPanelData: ko.observableArray(),
        FLjurisPanelData: ko.observableArray(),
        FLDSPanelData: ko.observableArray(),
        FLNHPanelData: ko.observableArray(),
        FLPSPanelData: ko.observableArray(),
        hideFLFirePanel: ko.observable(false),
        hideFLBMPanel: ko.observable(false),
        hideFLIRPanel: ko.observable(false),
        hideFLjurisPanel: ko.observable(false),
        hideFLDSPanel: ko.observable(false),
        hideFLNHPanel: ko.observable(false),
        hideFLPSPanel: ko.observable(false),


        init: function () {
            viewReports.countLoading = 1;
            viewReports.loadReports(viewReports.systemNode());
            viewReports.selectedPanel(getQueryVariable('pId'));
        },

        loadReports: function (pNode) {
            try {
                var pGSafeGuid = viewReports.userGUID();
                var zServiceName = "GetMetaMenu";
                if (pNode) {
                    viewReports.systemNode(pNode);
                } else {
                    viewReports.systemNode("");
                }
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID(),
                    "pNode": viewReports.systemNode()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewReports.loadReportsSuccess, viewReports.loadReportsError, null);
            } catch (pException) {
                viewReports.processMessage("An error occurred while starting the reports data call: " + pException.message);
            }
        },

        loadReportsSuccess: function (pResults) {
            try {
                if (pResults.isSuccess) {
                    for (var i = 0; i < pResults.data.length; i++) {
                        if (pResults.data[i].Items.length > 0) {
                            switch (pResults.data[i].Text) {
                                case "Facility Level Fire Reports":
                                    viewReports.FLfirePanelData(pResults.data[i].Items);
                                    break;
                                case "Facility Level Boiler & Machinery Reports":
                                    viewReports.FLBMPanelData(pResults.data[i].Items);
                                    break;
                                case "Facility Level Infrared Thermography Reports":
                                    viewReports.FLIRPanelData(pResults.data[i].Items);
                                    break;
                                case "Facility Level Jurisdictional Reports":
                                    viewReports.FLjurisPanelData(pResults.data[i].Items);
                                    break;
                                case "Facility Level Diversified Services Reports":
                                    viewReports.FLDSPanelData(pResults.data[i].Items);
                                    break;
                                case "Facility Level Natural Hazards Reports":
                                    viewReports.FLNHPanelData(pResults.data[i].Items);
                                    break;
                                case "Facility Level Process Safety Reports":
                                    viewReports.FLPSPanelData(pResults.data[i].Items);
                                    break;
                                case "Favorite Reports":
                                    viewReports.favoritePanelData(pResults.data[i].Items);
                                    break;
                                case "All-Service Reports":
                                    viewReports.allServicesPanelData(pResults.data[i].Items);
                                    break;
                                case "Fire Protection Engineering":
                                    viewReports.firePanelData(pResults.data[i].Items);
                                    break;
                                case "Boiler & Machinery Engineering":
                                    viewReports.bmPanelData(pResults.data[i].Items);
                                    break;
                                case "Infrared Thermography":
                                    viewReports.irPanelData(pResults.data[i].Items);
                                    break;
                                case "Jurisdictional":
                                    viewReports.jurisPanelData(pResults.data[i].Items);
                                    break;
                                case "Natural Hazards":
                                    viewReports.natHazPanelData(pResults.data[i].Items);
                                    break;
                                case "Diversified Services":
                                    viewReports.divSrvPanelData(pResults.data[i].Items);
                                    break;
                                case "Process Safety":
                                    viewReports.procSafetyPanelData(pResults.data[i].Items);
                                    break;
                            }
                        }
                    }

                    if (!viewReports.FLfirePanelData().length > 0) {
                        viewReports.hideFLFirePanel(true);
                    }
                    if (!viewReports.FLBMPanelData().length > 0) {
                        viewReports.hideFLBMPanel(true);
                    }
                    if (!viewReports.FLIRPanelData().length > 0) {
                        viewReports.hideFLIRPanel(true);
                    }
                    if (!viewReports.FLjurisPanelData().length > 0) {
                        viewReports.hideFLjurisPanel(true);
                    }
                    if (!viewReports.FLDSPanelData().length > 0) {
                        viewReports.hideFLDSPanel(true);
                    }
                    if (!viewReports.FLNHPanelData().length > 0) {
                        viewReports.hideFLNHPanel(true);
                    }
                    if (!viewReports.FLPSPanelData().length > 0) {
                        viewReports.hideFLPSPanel(true);
                    }
                    if (!viewReports.allServicesPanelData().length > 0) {
                        viewReports.hideAllServicesPanel(true);
                    }
                    if (!viewReports.firePanelData().length > 0) {
                        viewReports.hideFirePanel(true);
                    }
                    if(!viewReports.bmPanelData().length > 0){
                        viewReports.hideBmPanel(true);
                    }
                    if (!viewReports.irPanelData().length > 0) {
                        viewReports.hideIrPanel(true);
                    }
                    if (!viewReports.jurisPanelData().length > 0) {
                        viewReports.hideJurisPanel(true);
                    }
                    if (!viewReports.natHazPanelData().length > 0) {
                        viewReports.hideNatHazPanel(true);
                    }
                    if (!viewReports.divSrvPanelData().length > 0) {
                        viewReports.hideDivServPanel(true);
                    }
                    if(!viewReports.procSafetyPanelData().length > 0){
                        viewReports.hideProcSafetyPanel(true);
                    }

                    viewReports.setupKendo();
                    if (viewReports.selectedPanel()) {
                        viewReports.selectPanel(viewReports.selectedPanel());
                    }
                }
            } catch (pException) {
                viewReports.processMessage("An error occurred while completinging the reports data call: " + pException.message);
            }
        },

        loadReportsError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewReports.processMessage("Error while loading Reports data. " + pMessage);
        },

        selectPanel: function (panelId) {
            var panelBar = $('#reportsPanel').data("kendoPanelBar");
            if (panelId) {
                switch (panelId) {
                    //FIRE
                    case '52':
                        panelBar.expand($('#firePanel'));
                        break;
                    //BM
                    case "51":
                        panelBar.expand($('#bmPanel'));
                        break;
                    //IR
                    case "53":
                        panelBar.expand($('#irPanel'));
                        break;
                    //JURIS
                    case "56":
                        panelBar.expand($('#jurisPanel'));
                        break;
                    //NatHaz
                    case "55":
                        panelBar.expand($('#natHazPanel'));
                        break;
                    //Div Serv
                    case "54":
                        panelBar.expand($('#divSrvPanel'));
                        break;
                    //Proc Safety
                    case "11":
                        panelBar.expand($('#procPanel'));
                        break;
                }
            }
        },

        setupKendo: function () {
            $('#reportsPanel').kendoPanelBar({
                expandMode: "multiple",
            });
        },

        processMessage: function (pMessage) {
            alert(pMessage);
        },

        bindForm: function () {
            ko.applyBindings(viewReports, $("#viewReports")[0]);
        },

    }

    //INITIALIZE PAGE
    viewReports.bindForm();
    viewReports.init();
});