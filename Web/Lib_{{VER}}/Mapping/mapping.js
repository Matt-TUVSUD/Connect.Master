$(document).ready(function () {

    //globalClientFeatures

    /* View */
    formView = {

        /* Observable */
        objFormData: ko.observable(),
        collFormData: [],
        recordIndex: ko.observable(0),
        recordCount: ko.observable(0),
        currencyText: ko.observable("USD:"),
        isTestMode: false,
        isBound: false,
        isPrefilterRequred: false,
        urlPrefilterWindow: null,
        visibleCurrentERReport: ko.observable(true),
        visibleCurrentDiagramReport: ko.observable(true),
        enabledCurrentERReport: true,
        enabledCurrentDiagramReport: true,
        visiblePrint: ko.observable(true),
        loader: $('#loading'),
        clientFeatures: ko.observable(""),
        staticImageURL: null,
        staticImageBase64: ko.observable(""),

        loadData: function () {
            formView.loadClientFeatures();
            formView.loadFormData();
            formView.loadReportMeta();
        },

        loadClientFeatures: function () {
            var zFeatures = getClientFeatures(getGSafeGUID());
            if (zFeatures) {
                formView.clientFeatures(zFeatures.toLowerCase());
            }
        },

        loadFormData: function () {
            try {
                formView.loader.removeClass('noShow');
                //determining if we should show buttons for record count
                if (!globalIsMapShown) {
                    var btnHldr = $('.recCtHldr');
                    btnHldr.addClass('noShow');
                } else {
                    var btnHldr = $('.recCtHldr');
                    btnHldr.removeClass('noShow');
                }

                // EMPTY DATA OBJECTS AND ARRAYS
                setTimeout(function () {
                    formView.collFormData = [];
                    formView.objFormData({});
                    // GATHER DATA
                    var zUserCurrencyId = null;
                    if (gCurrencyIdFromPrefilter) {
                        zUserCurrencyId = gCurrencyIdFromPrefilter;
                    }
                    var zUniqueId = null;
                    if (globalPopupUniqueId) {
                        zUniqueId = globalPopupUniqueId;
                    }
                    // CALL SERVICE
                    var zServiceName = "GetFormData";
                    var zParms = ko.toJSON({
                        "gSafeGuid": getGSafeGUID(),
                        "pUserCurrencyId": zUserCurrencyId,
                        "pFormFileNo": globalPopupFileNo,
                        "pUniqueId": zUniqueId
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, formView.loadFormDataSuccess, formView.loadFormDataError, null)
                }, 1);
            } catch (pException) {
                formView.processMessage("An error occurred while starting the form view data call: " + pException.message);
            }
        },
        loadFormDataSuccess: function (pResults, pParms) {
            try {
                if (formView.isTestMode) {
                    console.log("{");
                    for (var zField in pResults.data[0]) {
                        console.log("    " + zField);
                    }
                    console.log("}");
                }
                setTimeout(function () {
                    formView.loader.addClass('noShow')
                }, 1000);
                formView.currencyText(pResults.currency);
                formView.recordIndex(1);
                formView.recordCount(pResults.data.length);
                formView.populatObjForm(pResults.data[0]);
                formView.collFormData = pResults.data;
            } catch (pException) {
                formView.processMessage("An error occurred while building form view data: " + pException.message);
            }
        },
        loadFormDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            setTimeout(function () {
                formView.loader.addClass('noShow')
            }, 1000);
            formView.processMessage("Error while loading pin data. " + pMessage);
        },

        loadReportMeta: function () {
            try {
                formView.isPrefilterRequred = false;
                formView.urlPrefilterWindow = null;
                // CALL SERVICE
                var zServiceName = "FormReportHasParameters";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, formView.loadReportMetaSuccess, formView.loadReportMetaError, null);
            } catch (pException) {
                formView.processMessage("An error occurred while starting the form view data call: " + pException.message);
            }
        },
        loadReportMetaSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    if (pResults.data) {
                        // OPEN THE PRE-FILTER POPUP WITH THE URL PASSED IN
                        formView.isPrefilterRequred = true;
                        formView.urlPrefilterWindow = pResults.url;
                    } else {
                        // DO NOTHING
                    }
                } else {
                    formView.processMessage("An error occurred while building meta data: " + pResults.message);
                }
            } catch (pException) {
                formView.processMessage("An error occurred while building meta data: " + pException.message);
            }
        },
        loadReportMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            formView.processMessage("Error while loading meta data. " + pMessage);
        },

        onCurrentERReport: function (serviceId) {
            //DB: The practiceId parameter will be only populated in the inspectionStatus.html mapping page due to having multiple practices in the grid.
            //For other grids, no argument is supplied and dictated by the practiceId in the metagrid table .
            if (serviceId != undefined) { formView.isEngineerReportAvailableByPractice(serviceId) } else { formView.isEngineerReportAvailable(); }
            if (formView.enabledCurrentERReport) {
                var serviceParm = '';
                if (serviceId != undefined) { serviceParm = '&service=' + serviceId; }
                document.location.href = "../../reports/ReportHandler.ashx?action=PrintEngineerReport&sid=" + getGSafeGUID() + serviceParm;
                return false;
            } else {
                formView.processMessage('There is currently no current or past engineer report for this location.');
            }

        },

        onCurrentDiagramReport: function () {
            //DB: The practiceId parameter will be only populated in the inspectionStatus.html mapping page due to having multiple practices in the grid.
            //For other grids, no argument is supplied and dictated by the practiceId in the metagrid table .
        
            formView.isDiagramReportAvailable();
            if (formView.enabledCurrentDiagramReport) {
                var serviceParm = '';
                document.location.href = "../../reports/ReportHandler.ashx?action=PrintDiagramReport&sid=" + getGSafeGUID() + serviceParm;
                return false;
            } else {
                formView.processMessage('There is currently no current or past diagram report for this location.');
            }

        },

        onPrint: function () {

            popup.data("kendoWindow").close();
            var zGSafeGuid = getGSafeGUID();
            if (formView.isPrefilterRequred) {
                openReportPopup(formView.urlPrefilterWindow);
            } else {
                openReportPopup("../../reports/ReportHandler.ashx?action=PrintFormReport&sid=" + zGSafeGuid);
            }
            return false;
        },


        onPrint2: function () {

            popup.data("kendoWindow").close();
            var zGSafeGuid = getGSafeGUID();
            if (formView.isPrefilterRequred) {
                openReportPopup(formView.urlPrefilterWindow);
            } else {
                openReportPopup("../../reports/ReportHandler.ashx?action=PrintLocationReport&sid=" + zGSafeGuid);
            }
            return false;
        },

        onNext: function () {
            if (formView.recordIndex() + 1 <= formView.recordCount()) {
                formView.recordIndex(formView.recordIndex() + 1);
                formView.populatObjForm(formView.collFormData[formView.recordIndex() - 1]);
            } else {
                formView.onFirst();
            }
        },

        onPrev: function () {
            if (formView.recordIndex() - 1 > 0) {
                formView.recordIndex(formView.recordIndex() - 1);
                formView.populatObjForm(formView.collFormData[formView.recordIndex() - 1]);
            } else {
                formView.onLast();
            }
        },

        onFirst: function () {
            formView.recordIndex(1);
            formView.populatObjForm(formView.collFormData[formView.recordIndex() - 1]);
        },

        onLast: function () {
            formView.recordIndex(formView.collFormData.length);
            formView.populatObjForm(formView.collFormData[formView.recordIndex() - 1]);
        },

        getStaticMapUrl: function () {
            // GET A STATIC IMAGERY URL FROM BING
            var zURL;
            if (!formView.objFormData().latitude ||
                !formView.objFormData().longitude ||
                !globalKeyBing) {
                zURL = "../../../Home_{{VER}}/Images/icons/maps/icon_earth_white_64x64.png";
            } else {
                var zLatitude = formView.objFormData().latitude;
                var zLongitude = formView.objFormData().longitude;
                var zMapWidth = "320";
                var zMapHeight = "300";
                zURL = global.getStaticMap(zLatitude, zLongitude, zMapWidth, zMapHeight, globalKeyBing);
            }
            formView.staticImageURL = zURL;
            return zURL;
        },

        printToPDF: function () {
            // BUTTON CLICK EVENT FOR CONVERT TO PDF
            formView.convertImageToDataURL(formView.staticImageURL, "1.5", formView.getFormToPDF);
        },

        printToPDFFacilitySummary: function () {
            // BUTTON CLICK EVENT FOR CONVERT TO PDF
            formView.convertImageToDataURL(formView.staticImageURL, "1.3", formView.getFormToPDF);
        },

        convertImageToDataURL: function (pURL, pZoomFactor, pCallback) {
            // CONVERT THE STATIC MAP IMAGE TO BASE 64 AND EXECUTE A CALLBACK
            var zXHR = new XMLHttpRequest();
            zXHR.onload = function () {
                var zReader = new FileReader();
                zReader.onloadend = function () {
                    pCallback(zReader.result, pZoomFactor);
                }
                zReader.readAsDataURL(zXHR.response);
            };
            zXHR.open('GET', pURL);
            zXHR.responseType = 'blob';
            zXHR.send();
        },

        getFormToPDF: function (pBase64, pZoomFactor) {
            // GET CSS AND HTML INFORMATION, THEN CALL CONVERT PDF HANDLER
            formView.staticImageBase64(pBase64);
            var zHTML = "";
            var zCSS = "";
            $.get("../../../css/pages/rectracking.css", function (pResults) {
                zCSS = zCSS + pResults;
                $.get("../../../css/pages/global.css", function (pResults) {
                    zCSS = zCSS + pResults;
                    $.get("../../../css/pages/mapping.css", function (pResults) {
                        zCSS = zCSS + pResults;
                        $.get("../../../css/pages/print.css", function (pResults) {
                            zCSS = zCSS + pResults;
                            var zFileName = globalPopupFileName.replace(".html", "");
                            zHTML = $('#formView').html();
                            global.getPdfFromHtml(zHTML, zCSS, pZoomFactor, "Landscape", zFileName);
                        });
                    });
                });
            });
        },

        onGoToURL: function (pURL) {
            var zWin = window.open(pURL, '_blank');
            zWin.focus();
        },

        onGoToLocationBingMaps: function () {
            var zLatitude = formView.objFormData().latitude;
            var zLongitude = formView.objFormData().longitude;
            var zClient = formView.objFormData().client;
            var zAddress1 = formView.objFormData().address;
            var zURLParms = encodeURIComponent(zLatitude + "_" + zLongitude + "_" + zClient + "_" + zAddress1);
            formView.onGoToURL("http://www.bing.com/maps/default.aspx?cp=" + zLatitude + "~" + zLongitude + "&sp=point." + zURLParms + "_%20_%20" + "&lvl=14");
        },

        clearAll: function () {
            // EMPTY DATA OBJECTS AND ARRAYS
            formView.collFormData = [];
            formView.objFormData({});
        },

        populatObjForm: function (pData) {
            formView.objFormData(pData);
            //formView.objFormData(dummyJSON[0]);
            formView.bindForm();
        },

        bindForm: function () {
            if (!formView.isBound) {
                ko.applyBindings(formView, $("#formView")[0]);
                formView.isBound = true;
            }
        },

        processMessage: function (pMessage) {
            alert(pMessage);
        },

        isEngineerReportAvailable: function () {
            try {
                return formView.isEngineerReportAvailableByPractice(
                    function getPracticedId() {
                        if (formView.collFormData[0].PracticeId != undefined) { return formView.collFormData[0].PracticeId; } else { return 0; }
                    }()
                );
            } catch (pException) {
                formView.processMessage("An error occurred while starting the report available data call: " + pException.message);
            }
        },

        isEngineerReportAvailableByPractice: function (practiceId) {
            try {
                // CALL SERVICE
                var zServiceName = "IsEngineerReportAvailable";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "pFileNo": function getFileNo() {
                        if (formView.collFormData[0].fileno != undefined) { return formView.collFormData[0].fileno; } else { return formView.collFormData[0].FileNo; }
                    }(),
                    "pPracticeId": practiceId
                });
                global.callRestServiceSyncronous(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, formView.isEngineerReportAvailableSuccess, formView.isEngineerReportAvailableError, null);
            } catch (pException) {
                formView.processMessage("An error occurred while starting the report available by practice data call: " + pException.message);
            }
        },

        isEngineerReportAvailableSuccess: function (pResults, pParms) {
            try {
                if (formView.isTestMode) {
                    console.log("{");
                    for (var zField in pResults.data[0]) {
                        console.log("    " + zField);
                    }
                    console.log("}");
                }
                formView.enabledCurrentERReport = pResults.data;
            } catch (pException) {
                formView.processMessage("An error occurred while checking if engineer report is available: " + pException.message);
            }
        },

        isEngineerReportAvailableError: function (pResults, pMessage, pErrorDetail, pParms) {
            formView.processMessage("Error while loading engineer report data. " + pMessage);
        },

        isDiagramReportAvailable: function () {
            try {
                // CALL SERVICE
                var zServiceName = "IsDiagramReportAvailable";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "pFileNo": function getFileNo() {
                        if (formView.collFormData[0].fileno != undefined) { return formView.collFormData[0].fileno; } else { return formView.collFormData[0].FileNo; }
                    }()
                });
                global.callRestServiceSyncronous(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, formView.isDiagramReportAvailableSuccess, formView.isDiagramReportAvailableError, null);
            } catch (pException) {
                formView.processMessage("An error occurred while starting the report available data call: " + pException.message);
            }
        },

        isDiagramReportAvailableSuccess: function (pResults, pParms) {
            try {
                if (formView.isTestMode) {
                    console.log("{");
                    for (var zField in pResults.data[0]) {
                        console.log("    " + zField);
                    }
                    console.log("}");
                }
                formView.enabledCurrentDiagramReport = pResults.data;
            } catch (pException) {
                formView.processMessage("An error occurred while checking if diagram report is available: " + pException.message);
            }
        },

        isDiagramReportAvailableError: function (pResults, pMessage, pErrorDetail, pParms) {
            formView.processMessage("Error while loading diagram report data. " + pMessage);
        }
    }

    //gCreateWindow();
    formView.loadData();


    // GLOBAL FUNCTIONS
    gLoadFormData = function () {
        formView.loadFormData();
    }
});