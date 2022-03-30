var gSafeGuid = getGSafeGUID();

/* API HELP PAGE */
/* http://dev.globalriskconsultants.com/capi/Help/ */

$(document).ready(function () {
    globalKeyBing = gServerSide_BingMapKey;
    apiHostPort = ""
    inDebugMode = (apiHostPort != "");

    var viewRecs = {
        currentFilePrefix: ko.observable(getQueryVariable("p1")),
        currentServiceCode: ko.observable(getQueryVariable("p2")),
        currentRecType: ko.observable(),
        currentUser: ko.observable(),
        clientFeatures: ko.observable(),
        showMGMT: ko.observable(false),
        show3rdLvl: ko.observable(false),
        isAdmin: ko.observable(false),
        isAutoRec: ko.observable(false),
        isIR: ko.observable(false),
        isFire: ko.observable(false),
        isSelfAudit: ko.observable(false),
        isCargill: ko.observable(false),
        locationData: ko.observableArray(),
        currentLocation: ko.observable(),
        totalLocationsCount: ko.observable(),
        locationsCountBoxText: ko.observable(),
        currentLocationIndex: ko.observable(),
        includeAllRecs: ko.observable(false),

        //LOCATION DATA VALUES
        address: ko.observable(),
        city: ko.observable(),
        country: ko.observable(),
        clientLocNo: ko.observable(),
        customAccess: ko.observable(),
        division: ko.observable(),
        facility: ko.observable(),
        fileNo: ko.observable(),
        latitude: ko.observable(),
        longitude: ko.observable(),
        state: ko.observable(),
        zip: ko.observable(),
        tiv: ko.observable(),
        addressCityStateZipCombindedText: ko.observable(),
        enabledCurrentERReport: false,
        enabledCurrentDiagramReport: false,
        erReportLink: ko.observable(),
        currentDiagramLink: ko.observable(),
        printLink: ko.observable(),
        staticImageURL: ko.observable(),

        recGridDataSource: ko.observableArray(),
        currentRec: ko.observable(),
        practiceId: ko.observable(),

        //RECOMMENDATION DATA VALUES
        recGUID: ko.observable(),
        recNumber: ko.observable(),
        recHazard: ko.observable(),
        recImpact: ko.observable(),
        recPrimaryType: ko.observable(),
        recSecondaryType: ko.observable(),
        recKeywords: ko.observable(),
        recCode: ko.observable(),
        recCurrentLossEstActual: ko.observable(),
        recCurrentLossEstRange: ko.observable(),
        recCompletedLossEstActual: ko.observable(),
        recCompletedLossEstRange: ko.observable(),
        recEstCostToCompActual: ko.observable(),
        recEstCostToCompRange: ko.observable(),
        recSavingsRatio: ko.observable(),
        recStatus: ko.observable(),
        recStatusDDData: ko.observableArray(),
        recStatusDropdownList: null,
        statusID: ko.observable(),
        recStatusDate: ko.observable(),
        recImpactDDData: ko.observableArray(),
        recFacilityRespDate: ko.observable(),
        recFacilityRespDateBackColor: ko.observable(),
        recFacilityRespFrom: ko.observable(),
        recFacilityIntendedAction: ko.observable(),
        recFacilityIntendedActionDDData: ko.observableArray(),
        recIntendedActionDropdownList: null,
        recIntendedActionID: ko.observable(),
        recFacilityComment: ko.observable(),
        recFacilityExpectedCompDate: ko.observable(),
        recFacilityExpectedCompletionBackColor: ko.observable(),
        recFacilityActualCostToComp: ko.observable(),
        recMGMTRespDate: ko.observable(),
        recMGMTRespFrom: ko.observable(),
        recMGMTIntendedAction: ko.observable(),
        recMGMTIntendedActionDDData: ko.observableArray(),
        recMGMTIntendedActionDropdownList: null,
        recMGMTRespActionId: ko.observable(),
        recMGMTComment: ko.observable(),
        recMGMTExpectedCompDate: ko.observable(),
        recMGMTActualCostToComp: ko.observable(),
        recThirdLvlRespDate: ko.observable(),
        recThirdLvlRespFrom: ko.observable(),
        recThirdLvlIntendedAction: ko.observable(),
        recThirdLvlIntendedActionId: ko.observable(),
        recThirdLvlIntendedActionDDData: ko.observableArray(),
        recThirdLvlIntendedActionDropdownList: null,
        recThirdLvlComment: ko.observable(),
        recThirdLvlExpectedCompDate: ko.observable(),
        recThirdLvlActualCostToComp: ko.observable(),

        //INFRARED SPECIFIC RECOMMENDATION DATA VALUES
        recHistory: ko.observable(),
        recSeverity: ko.observable(),
        recEquipmentNo: ko.observable(),
        recFindingNo: ko.observable(),
        recPlantArea: ko.observable(),
        recProbableEquipmentDamageCost: ko.observable(),
        recFaultType: ko.observable(),
        recLengthBusInteruption: ko.observable(),
        recDetectedWith: ko.observable(),
        recRedundancySpare: ko.observable(),

        //API VALUES
        AppKey: "2F14E5EF-333D-4A14-AB41-0CCC586F7E48",
        UserSid: ko.observable(getQueryVariable('sid')),
        endPointBase: "",
        endPointFilePrefix: ko.observable(),
        langID: ko.observable(1),

        userDataEndPointUrl: ko.observable(),
        locationDataEndPointUrl: ko.observable(),
        locationPagerEndPointUrl: ko.observable(),
        recommendationsDataEndPointUrl: ko.observable(),
        reportsEndPointUrl: ko.observable(),
        er_ReportEndPointUrl: ko.observable(),
        diagramReportEndPointUrl: ko.observable(),
        recommendationsPagerEndPointUrl: ko.observable(),
        firstLocationBtnUrl: ko.observable(),
        nextLocationBtnUrl: ko.observable(),
        previousLocationBtnUrl: ko.observable(),
        lastLocationBtnUrl: ko.observable(),
        locationCountUrl: ko.observable(),

        firstRecommendationBtnUrl: ko.observable(),
        firstRecommendation: ko.observable(),
        nextRecommendationBtnUrl: ko.observable(),
        nextRecommendation: ko.observable(),
        previousRecommendationBtnUrl: ko.observable(),
        previousRecommendation: ko.observable(),
        lastRecommendationBtnUrl: ko.observable(),
        lastRecommendation: ko.observable(),
        totalRecommendationsCount: ko.observable(),
        recommendationCountBoxText: ko.observable(),
        currentRecommendationIndex: ko.observable(),
        completedRecsNum: 0,
        numOfCompletedRec: ko.observable(),
        responseNeededNum: 0,
        numOfRecsNeedingResponse: ko.observable(),

        //SAVE OBJECT
        saveDataObject: ko.observableArray(),

        //CANCEL OBJECT
        isCancelClicked: false,
        cancelStatus: "",
        cancelStatusID: null,
        cancelFacilityIntendedAction: "",
        cancelFacilityIntendedActionID: null,
        cancelMGMTIntendedAction: "",
        cancelMGMTIntendedActionID: null,
        cancel3rdLvlIntendedAction: "",
        cancel3rdLvlIntendedActionID: null,

        //FILES/UPLOAD VALUES
        fileUploader: null,
        filesListEndpointUrl: ko.observable(),
        filesUploadEndpointUrl: ko.observable(),
        filesDownloadEndpointUrl: ko.observable(),
        filesDeleteEndpointUrl: ko.observable(),
        fileListData: ko.observableArray(),
        fileAllowedExtensionsList: ko.observableArray(),
        filesTotalCount: ko.observable(),

        //'!' - Client Feature: Display 3Lvl fields
        //'+' - Client Feature: Display MGMT fields
        init: function () {
            $.ajaxSetup({
                headers: { "AppKey": viewRecs.AppKey, "UserSid": viewRecs.UserSid() }
            });

            /* DETERMINE URL TO SET ENDPOINT BASE */
            var tempURL = window.location.href;
            /* DEV */
            if (tempURL.indexOf('localhost') > -1 && inDebugMode) {
                viewRecs.endPointBase = "//localhost:" + apiHostPort + "/";
            } else {
                viewRecs.endPointBase = "//dev.globalriskconsultants.com/capi/";
            }
            /* LIVE */
            if (tempURL.indexOf('grcconnect') > -1) {
                viewRecs.endPointBase = "//grcconnect.globalriskconsultants.com/capi/";
            }
            /* TEST/BETA */
            if (tempURL.indexOf('test') > -1) {
                viewRecs.endPointBase = "//grcconnecttest.globalriskconsultants.com/capi/";
            }
            switch (viewRecs.currentServiceCode()) {
                case "51":
                    //B&M
                    viewRecs.currentRecType(2);
                    viewRecs.practiceId(2);
                    break;
                case "52":
                    //FIRE
                    /* IF FIRE IS TRUE, ADD SELF AUDIT RECS TO DATA CALL */
                    viewRecs.isFire(true);
                    viewRecs.currentRecType(1);
                    viewRecs.practiceId(3);
                    break;
                case "53":
                    //IR
                    viewRecs.isIR(true);
                    viewRecs.currentRecType(4);
                    viewRecs.practiceId(4);
                    break;
                case "54":
                    //DIVSERV
                    //viewRecs.currentRecType();
                    break;
                case "55":
                    //NATHAZ
                    viewRecs.currentRecType(5);
                    viewRecs.practiceId(9);
                    break;
                case "57":
                    //PROCESS SAFETY
                    viewRecs.currentRecType(3);
                    viewRecs.practiceId(11);
                    break;
            }
            viewRecs.clientFeatures(getClientFeatures(viewRecs.UserSid()));
            viewRecs.setClientFeatures(viewRecs.clientFeatures());
            var tempPrefix = viewRecs.currentFilePrefix().substr(0, viewRecs.currentFilePrefix().indexOf('.'));
            if (tempPrefix == '495') {
                viewRecs.isCargill(true);
            }
            viewRecs.endPointFilePrefix(tempPrefix);
            viewRecs.getData();
        },

        getData: function () {
            try {
                viewRecs.loadUserData();
                viewRecs.loadLocationsData();
                viewRecs.loadRecommendationsData();
                viewRecs.loadDropDownData();
            } catch (pErrorMessage) {
                alert("There was an error initiating the page data: " + pErrorMessage);
            }
        },

        loadUserData: function () {
            //USER DATA
            var tempEndpoint = viewRecs.endPointBase + "users/current"
            viewRecs.userDataEndPointUrl(tempEndpoint);
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                cache: false,
                async: false,
                url: viewRecs.userDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecs.currentUser(pResults.data);
                        viewRecs.UserSid(viewRecs.currentUser().userSid);
                        viewRecs.isAdmin(viewRecs.currentUser().isAdmin);
                        viewRecs.isAutoRec(viewRecs.currentUser().isAutoRecUser);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading user data: " + pMessage);
                },
            });
        },
        loadLocationsData: function () {
            //LOCATION DATA
            //SET INITIAL LOCATION DATA ENDPOINT; ALL OTHER LOCATION ENDPOINTS WILL BE SET BY API
            if (viewRecs.locationDataEndPointUrl() == undefined) {
                var tempEndpoint = viewRecs.endPointBase + "clients/" + viewRecs.endPointFilePrefix() + "/locations";
                viewRecs.locationDataEndPointUrl(tempEndpoint);
            }
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                cache: true,
                async: false,
                url: viewRecs.locationDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecs.locationData(pResults.data);
                        viewRecs.setLocationData();
                        viewRecs.loadRecCounts(pResults.data);
                        viewRecs.loadReportsData();
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading location data: " + pMessage);
                }
            });
        },
        loadRecCounts: function (pData) {
            if (viewRecs.locationCountUrl() == undefined) {
                for (var i = 0; i < pData.length; i++) {
                    if (viewRecs.currentFilePrefix() == pData[i].fileNo) {
                        for (var j = 0; j < pData[i]._Links.length; j++) {
                            if (pData[i]._Links[j].rel == "recCounts") {
                                viewRecs.locationCountUrl(pData[i]._Links[j].href);
                                break;
                            }
                        }
                    }
                }
            }
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: viewRecs.locationCountUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (viewRecs.currentRecType() == pResults.data[i].recTypeId) {
                                viewRecs.numOfCompletedRec(pResults.data[i].responsesCompleted);
                                viewRecs.numOfRecsNeedingResponse(pResults.data[i].responsesNeeded);
                                break;
                            }
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading recommendations count data: " + pMessage);
                }
            });

        },
        loadRecommendationsData: function () { 
            //REC DATA
            if (viewRecs.recommendationsDataEndPointUrl() == undefined) {
                if (viewRecs.isFire()) {
                    /* ADD SELF AUDIT RECS TO ALL FIRE DATA */
                    var tempEndpoint = viewRecs.endPointBase + "clients/" + viewRecs.endPointFilePrefix() + "/recs?recType=" + viewRecs.currentRecType() + "&recType=6" + "&fileNo=" + viewRecs.currentFilePrefix() + "&langid=" + viewRecs.langID() + "&autoRecs=true";
                    if (viewRecs.includeAllRecs()) {
                        var tempEndpoint = viewRecs.endPointBase + "clients/" + viewRecs.endPointFilePrefix() + "/recs?recType=" + viewRecs.currentRecType() + "&recType=6" + "&fileNo=" + viewRecs.currentFilePrefix() + "&langid=" + viewRecs.langID();
                    }
                } else {
                    if (viewRecs.includeAllRecs()) {
                        var tempEndpoint = viewRecs.endPointBase + "clients/" + viewRecs.endPointFilePrefix() + "/recs?recType=" + viewRecs.currentRecType() + "&recType=6" + "&fileNo=" + viewRecs.currentFilePrefix() + "&langid=" + viewRecs.langID();
                    } else {
                        var tempEndpoint = viewRecs.endPointBase + "clients/" + viewRecs.endPointFilePrefix() + "/recs?recType=" + viewRecs.currentRecType() + "&fileNo=" + viewRecs.currentFilePrefix() + "&langid=" + viewRecs.langID() + "&autoRecs=true";
                    }
                }
                viewRecs.recommendationsDataEndPointUrl(tempEndpoint);
            } else {
                var tempEndpoint = viewRecs.recommendationsDataEndPointUrl();
                if (viewRecs.includeAllRecs()) {
                    if (tempEndpoint.includes("&autoRecs=true")) {
                        let result = tempEndpoint.replace('&autoRecs=true', '');
                        viewRecs.recommendationsDataEndPointUrl(result);
                    }
                } else {
                    if (tempEndpoint.includes("&autoRecs=true")) {
                        viewRecs.recommendationsDataEndPointUrl(tempEndpoint);
                    } else {
                        tempEndpoint = tempEndpoint + "&autoRecs=true";
                        viewRecs.recommendationsDataEndPointUrl(tempEndpoint);
                    }
                }
            }
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: viewRecs.recommendationsDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        if (pResults.data.length > 0) {
                            if (viewRecs.includeAllRecs()) {
                                let recGrid = $('#recGrid').data('kendoGrid');
                                let allRecData = new kendo.data.DataSource({ data: pResults.data });
                                recGrid.dataSource = allRecData;
                                allRecData.read();
                                recGrid.refresh();
                                viewRecs.recGridDataSource(allRecData.options.data);
                            } else {
                                $('#recGridHldr').removeClass('noShow');
                                viewRecs.setGridDataSource(pResults.data);
                            }
                        } else {
                            $('#recResponseBar').addClass('noShow');
                            $('#recGridHldr').addClass('noShow');
                            $('#recGridNoRecs').removeClass('noShow');
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading recommendations grid data: " + pMessage);
                }
            });

        },
        loadSavedRec: function (pGUID) {
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: viewRecs.recommendationsDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (pResults.data[i].rowGuid == pGUID) {
                                viewRecs.pagerBindRecForm(pResults.data[i]);
                                break;
                            }
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading recommendations grid data: " + pMessage);
                }
            });
        },
        loadDropDownData: function () {
            /*
             * LIST TYPES ARE AS FOLLOWS:
             * 1=RecStatuses
             * 2=Impacts
             * 3=IntendedActions
             * 4=PrimaryTypes
             * 5=SecondaryTypes
             * 6=MgmtRecActions
             * 11=UploadConfig
             * */
            var endPointURL = viewRecs.endPointBase + "meta/lists?type=1&type=2&type=3&type=11&langid=" + viewRecs.langID();
            if (viewRecs.showMGMT() && !viewRecs.show3rdLvl()) {
                endPointURL = viewRecs.endPointBase + "meta/lists?type=1&type=2&type=3&type=6&type=11&langid=" + viewRecs.langID();
            }
            if (viewRecs.showMGMT() && viewRecs.show3rdLvl()) {
                endPointURL = viewRecs.endPointBase + "meta/lists?type=1&type=2&type=3&type=6&type=10&type=11&langid=" + viewRecs.langID();
            }
            if (!viewRecs.showMGMT() && viewRecs.show3rdLvl()) {
                endPointURL = viewRecs.endPointBase + "meta/lists?type=1&type=2&type=3&type=10&type=11&langid=" + viewRecs.langID();
            }
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: endPointURL,
                success: function (pResults) {
                    for (var i = 0; i < pResults.data.length; i++) {
                        if (pResults.data[i].id == 1) {
                            //"Rec Statuses"
                            viewRecs.recStatusDDData(pResults.data[i].items);
                        } else if (pResults.data[i].id == 2) {
                            //"Rec Impacts"
                            viewRecs.recImpactDDData(pResults.data[i].items);
                        } else if (pResults.data[i].id == 3) {
                            //"Rec Intended Actions"
                            viewRecs.recFacilityIntendedActionDDData(pResults.data[i].items);
                        } else if (pResults.data[i].id == 11) {
                            //UPLOAD
                            viewRecs.fileAllowedExtensionsList(pResults.data[i].items[0].allowedExtensions);
                        }

                        if (viewRecs.showMGMT()) {
                            if (pResults.data[i].id == 6) {
                                //"Rec Mgmt Actions"
                                viewRecs.recMGMTIntendedActionDDData(pResults.data[i].items);
                            }
                        }
                        if (viewRecs.show3rdLvl()) {
                            if (pResults.data[i].id == 10) {
                                //"Rec 3rd Lvl Actions"
                                viewRecs.recThirdLvlIntendedActionDDData(pResults.data[i].items);
                            }
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading recommendations status dropdown data: " + pMessage);
                }
            });
        },
        loadReportsData: function () {
            var tempEndpoint = viewRecs.endPointBase + "clients/" + viewRecs.endPointFilePrefix() + "/locations/" + viewRecs.fileNo() + "/reports";
            viewRecs.reportsEndPointUrl(tempEndpoint);
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                cache: true,
                async: false,
                url: viewRecs.reportsEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (pResults.data[i].practiceId == viewRecs.practiceId()) {
                                if (pResults.data[i].engineerReport != null) {
                                    viewRecs.er_ReportEndPointUrl(pResults.data[i].engineerReport);
                                }
                                if (pResults.data[i].diagramReport != null) {
                                    viewRecs.diagramReportEndPointUrl(pResults.data[i].diagramReport);
                                }
                            }
                        }
                        if (viewRecs.er_ReportEndPointUrl() == null) {
                            $('#erReportBtn').addClass('grcBlueDisabledBtn');
                            $('#erReportBtn').prop("disabled", true);
                        }

                        if (viewRecs.diagramReportEndPointUrl() == null) {
                            $('#diagramBtn').addClass('grcBlueDisabledBtn');
                            $('#diagramBtn').prop("disabled", true);
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading reports data: " + pMessage);
                }
            });
        },
        setLocationData: function () {
            if (viewRecs.locationData().length > 0) {
                if (viewRecs.locationData().length > 1) {
                    //INITIAL DATA LOAD THAT GETS THE FULL LIST OF LOCATIONS
                    for (var i = 0; i < viewRecs.locationData().length; i++) {
                        if (viewRecs.currentFilePrefix() == viewRecs.locationData()[i].fileNo) {
                            //BIND LOCATION DATA VALUES HERE
                            viewRecs.bindLocationCard(viewRecs.locationData()[i]);
                            //ADJUST CURRENT LOCATION API ENDPOINT URL
                            for (var j = 0; j < viewRecs.locationData()[i]._Links.length; j++) {
                                if (viewRecs.locationData()[i]._Links[j].rel == "self") {
                                    viewRecs.locationDataEndPointUrl(viewRecs.locationData()[i]._Links[j].href);
                                }
                            }
                        }
                    }
                }
            }
        },
        bindLocationCard: function (pData) {
            viewRecs.address(pData.address);
            viewRecs.city(pData.city);
            viewRecs.country(pData.country);
            viewRecs.clientLocNo(pData.clientLocNo);
            viewRecs.customAccess(pData.customAccess);
            viewRecs.division(pData.division);
            viewRecs.facility(pData.facility);
            viewRecs.fileNo(pData.fileNo);
            viewRecs.latitude(pData.longitude);
            viewRecs.longitude(pData.latitude);
            viewRecs.staticImageURL(viewRecs.getStaticMapUrl());
            viewRecs.state(pData.state);
            viewRecs.zip(pData.zip);
            viewRecs.tiv(global.formatMoneyNoSymbol(pData.tiv, 0));
            viewRecs.addressCityStateZipCombindedText(viewRecs.address() + " " + viewRecs.city() + ", " + viewRecs.state() + " " + viewRecs.zip());
        },
        getStaticMapUrl: function () {
            // GET A STATIC IMAGERY URL FROM BING
            var zURL;
            if (!viewRecs.latitude() ||
                !viewRecs.longitude() ||
                !globalKeyBing) {
                zURL = "../../Home_{{VER}}/Images/icons/maps/icon_earth_white_64x64.png";
            } else {
                var zLatitude = viewRecs.latitude();
                var zLongitude = viewRecs.longitude();
                var zMapWidth = "320";
                var zMapHeight = "300";
                zURL = global.getStaticMap(zLongitude, zLatitude, zMapWidth, zMapHeight, globalKeyBing);
            }
            return zURL;
        },
        setClientFeatures: function (pData) {
            if (pData.indexOf('+') > -1 || pData.indexOf('Q') > -1) {
                viewRecs.showMGMT(true);
            }
            if (pData.indexOf('!') > -1 || pData.indexOf('@') > -1) {
                viewRecs.show3rdLvl(true);
            }
        },
        setGridDataSource: function (pData) {
            if (pData.length > 0) {
                viewRecs.recGridDataSource(pData);
                viewRecs.setupKendo();
            }
        },
        loadFileList: function () {
            for (let i = 0; i < viewRecs.currentRec()._Links.length; i++) {
                if (viewRecs.currentRec()._Links[i].rel == "files") {
                    viewRecs.filesListEndpointUrl(viewRecs.currentRec()._Links[i].href);
                }
            }

            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                url: viewRecs.filesListEndpointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecs.filesTotalCount(pResults.data.length);
                        if (viewRecs.filesTotalCount() == 0) {
                            $('#noFilesMsg').show();
                            $('#filesGridHldr').hide();
                            viewRecs.setUpUpload();
                        } else {
                            viewRecs.fileListData(pResults.data);
                            $('#noFilesMsg').hide();
                            $('#filesGridHldr').show();
                            viewRecs.setUpUpload();
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading files: " + pMessage);
                }
            })
        },
        onUpload: function (e) {
            var xhr = e.XMLHttpRequest;
            if (xhr) {
                xhr.addEventListener("readystatechange", function (e) {
                    if (xhr.readyState == 1 /* OPENED */) {
                        xhr.setRequestHeader("AppKey", "2F14E5EF-333D-4A14-AB41-0CCC586F7E48");
                        xhr.setRequestHeader("UserSid", viewRecs.UserSid());
                    }
                });
            }
        },

        setUpUpload: function () {
            if (viewRecs.fileUploader == null) {
                $('#fileUpload').kendoUpload({
                    async: {
                        saveUrl: viewRecs.filesUploadEndpointUrl(),
                        autoUpload: false,
                        withCredentials: false,
                        showFileList: false
                    },
                    upload: viewRecs.onUpload,
                    validation: {
                        allowedExtensions: viewRecs.fileAllowedExtensionsList()
                    },
                    success: function () {
                        $(".k-upload-files.k-reset").find("li").parent().remove();
                        viewRecs.loadFileList();
                    },
                    select: function (e) {
                        viewRecs.fileOnSelect(e);
                    }
                });
            }
            viewRecs.fileUploader = $('#fileUpload').data("kendoUpload");
        },

        fileOnSelect: function (e) {
            var files = e.files;
            var ext = [];
            for (var i = 0; i < files.length; i++) {
                for (var j = 0; j < viewRecs.fileAllowedExtensionsList().length; j++) {
                    ext.push("." + viewRecs.fileAllowedExtensionsList()[j]);
                }

                if (ext.indexOf(files[i].extension.toLowerCase()) == -1) {
                    alert(files[i].name + " is of a file type that is not allowed.");
                    e.preventDefault();
                }
            }
        },

        onFileDownload: function (pData) {
            viewRecs.filesDownloadEndpointUrl(pData._Links[0].href);

            $.ajax({
                type: "GET",
                cache: true,
                url: viewRecs.filesDownloadEndpointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        var arr = pResults.data.content;
                        var byteArray = viewRecs.base64ToArrayBuffer(arr);
                        var a = window.document.createElement('a');
                        var blob = new Blob([byteArray], { type: 'application/octet-stream' })
                        a.href = window.URL.createObjectURL(blob);
                        a.download = pResults.data.fileName;
                        // Append anchor to body.
                        document.body.appendChild(a);
                        a.click();

                        // Remove anchor from body
                        document.body.removeChild(a);

                    } else {
                        alert(pResults.message);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error downloading file: " + pMessage);
                }
            });
        },

        base64ToArrayBuffer: function (base64) {
            var binaryString = window.atob(base64);
            var byteArray = new Uint8Array(binaryString.length);
            return byteArray.map((byteArray, i) => binaryString.charCodeAt(i));
        },

        onFileDelete: function (pData) {
            viewRecs.filesDeleteEndpointUrl(pData._Links[0].href);
            if (confirm("Are you sure you want to delete this file?")) {
                $.ajax({
                    type: "DELETE",
                    dataType: "json",
                    contentType: "application/javascript",
                    async: false,
                    url: viewRecs.filesDeleteEndpointUrl(),
                    success: function (pResults) {
                        if (pResults.isSuccess) {
                            viewRecs.loadFileList();
                        }
                    },
                    error: function (pResults, pMessage, pErrorDetail) {
                        alert("Error deleteing files: " + pMessage);
                    }
                });
            }
        },

        setupKendo: function () {
            if (!viewRecs.isIR()) {
                var gridColumnMap = [
                    { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                    { field: "fileNo", title: "File No.", width: "60px" },
                    { field: "recYear", title: "Rec. Year", width: "50px", },
                    { field: "recMonth", title: "Rec. Month", width: "60px", },
                    { field: "recNumber", title: "Rec. No.", width: "60px" },
                    { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                    { field: "status", title: "Rec. Status", width: "100px", },
                    { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                    { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                    { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                    { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                    { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                    { field: "currentLossEstimate", title: "Current Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(currentLossEstimate, 0 ) #" },
                    { field: "currentLossEstimateRange", title: "Current Loss Est. (range) USD", width: "150px", },
                    { field: "completedLossEstimate", title: "Completed Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(completedLossEstimate, 0 ) #" },
                    { field: "completedLossEstimateRange", title: "Completed Loss Est. (range) USD", width: "150px", },
                    { field: "costToCompleteEstimate", title: "Est'd Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToCompleteEstimate, 0 ) #" },
                    { field: "costToCompleteEstimateRange", title: "Cost To Complete Est'd (range) USD", width: "150px", },
                    { field: "costToComplete", title: "Actual Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToComplete, 0 ) #" },
                    { field: "savingsRatio", title: "Savings Ratio", width: "85px", },
                    { field: "intendedAction", title: "Intended Action", width: "150px", },
                    { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                    { field: "respFrom", title: "Response From", width: "100px" },
                    { field: "facilityComment", title: "Facility Comment", width: "150px" },
                    { field: "expectedCompletionDate", title: "Expected Completion Date", width: "150px", template: "#= expectedCompletionDate != null ? dayjs(expectedCompletionDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= expectedCompletionDateBackColorHex #" } }
                ]
            } else {
                var gridColumnMap = [
                    { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                    { field: "fileNo", title: "File No.", width: "60px" },
                    { field: "recYear", title: "Rec. Year", width: "50px", },
                    { field: "recMonth", title: "Rec. Month", width: "60px", },
                    { field: "recNumber", title: "Rec. No.", width: "60px" },
                    { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                    { field: "status", title: "Rec. Status", width: "100px", },
                    { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                    { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                    { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                    { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                    { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                    { field: "history", title: "History", width: "60px" },
                    { field: "equipmentNo", title: "Equip. No", width: "60px" },
                    { field: "findingNo", title: "Finding No.", width: "60px" },
                    { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                    { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                    { field: "faultType", title: "Fault Type", width: "100px" },
                    { field: "detectedWith", title: "Detected With", width: "80px", },
                    { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                    { field: "intendedAction", title: "Intended Action", width: "150px", },
                    { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                    { field: "respFrom", title: "Response From", width: "100px" },
                    { field: "facilityComment", title: "Facility Comment", width: "150px" }
                ];
            }
            if (!viewRecs.isIR()) {
                if (viewRecs.showMGMT() && viewRecs.show3rdLvl()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "currentLossEstimate", title: "Current Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(currentLossEstimate, 0 ) #" },
                        { field: "currentLossEstimateRange", title: "Current Loss Est. (range) USD", width: "150px", },
                        { field: "completedLossEstimate", title: "Completed Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(completedLossEstimate, 0 ) #" },
                        { field: "completedLossEstimateRange", title: "Completed Loss Est. (range) USD", width: "150px", },
                        { field: "costToCompleteEstimate", title: "Est'd Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToCompleteEstimate, 0 ) #" },
                        { field: "costToCompleteEstimateRange", title: "Cost To Complete Est'd (range) USD", width: "150px", },
                        { field: "costToComplete", title: "Actual Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToComplete, 0 ) #" },
                        { field: "savingsRatio", title: "Savings Ratio", width: "85px", },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "expectedCompletionDate", title: "Expected Completion Date", width: "150px", template: "#= expectedCompletionDate != null ? dayjs(expectedCompletionDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= expectedCompletionDateBackColorHex #" } },
                        { field: "mgmtRespDate", title: "MGMT Response Date", width: "100px", template: "#= mgmtRespDate != null ? dayjs(mgmtRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "mgmtRespFrom", title: "MGMT Response From", width: "100px" },
                        { field: "mgmtRespAction", title: "MGMT Intended Action", width: "150px" },
                        { field: "mgmtRespComment", title: "MGMT Comment", width: "150px" },
                        { field: "thirdLevelRespDate", title: "3rd Lvl Response Date", width: "100px", template: "#= thirdLevelRespDate != null ? dayjs(thirdLevelRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "thirdLevelRespFrom", title: "3rd Lvl Response From", width: "100px" },
                        { field: "thirdLevelRespAction", title: "3rd Lvl Intended Action", width: "150px" },
                        { field: "thirdLevelRespComment", title: "3rd Lvl Comment", width: "150px" },
                    ]
                } else if (viewRecs.showMGMT()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "currentLossEstimate", title: "Current Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(currentLossEstimate, 0 ) #" },
                        { field: "currentLossEstimateRange", title: "Current Loss Est. (range) USD", width: "150px", },
                        { field: "completedLossEstimate", title: "Completed Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(completedLossEstimate, 0 ) #" },
                        { field: "completedLossEstimateRange", title: "Completed Loss Est. (range) USD", width: "150px", },
                        { field: "costToCompleteEstimate", title: "Est'd Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToCompleteEstimate, 0 ) #" },
                        { field: "costToCompleteEstimateRange", title: "Cost To Complete Est'd (range) USD", width: "150px", },
                        { field: "costToComplete", title: "Actual Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToComplete, 0 ) #" },
                        { field: "savingsRatio", title: "Savings Ratio", width: "85px", },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "expectedCompletionDate", title: "Expected Completion Date", width: "150px", template: "#= expectedCompletionDate != null ? dayjs(expectedCompletionDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= expectedCompletionDateBackColorHex #" } },
                        { field: "mgmtRespDate", title: "MGMT Response Date", width: "100px", template: "#= mgmtRespDate != null ? dayjs(mgmtRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "mgmtRespFrom", title: "MGMT Response From", width: "100px" },
                        { field: "mgmtRespAction", title: "MGMT Intended Action", width: "150px" },
                        { field: "mgmtRespComment", title: "MGMT Comment", width: "150px" },
                    ]
                } else if (viewRecs.show3rdLvl()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "currentLossEstimate", title: "Current Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(currentLossEstimate, 0 ) #" },
                        { field: "currentLossEstimateRange", title: "Current Loss Est. (range) USD", width: "150px", },
                        { field: "completedLossEstimate", title: "Completed Loss Est. USD", width: "150px", template: "#= global.formatMoneyNoSymbol(completedLossEstimate, 0 ) #" },
                        { field: "completedLossEstimateRange", title: "Completed Loss Est. (range) USD", width: "150px", },
                        { field: "costToCompleteEstimate", title: "Est'd Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToCompleteEstimate, 0 ) #" },
                        { field: "costToCompleteEstimateRange", title: "Cost To Complete Est'd (range) USD", width: "150px", },
                        { field: "costToComplete", title: "Actual Cost To Complete USD", width: "150px", template: "#= global.formatMoneyNoSymbol(costToComplete, 0 ) #" },
                        { field: "savingsRatio", title: "Savings Ratio", width: "85px", },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "expectedCompletionDate", title: "Expected Completion Date", width: "150px", template: "#= expectedCompletionDate != null ? dayjs(expectedCompletionDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= expectedCompletionDateBackColorHex #" } },
                        { field: "thirdLevelRespDate", title: "3rd Lvl Response Date", width: "100px", template: "#= thirdLevelRespDate != null ? dayjs(thirdLevelRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "thirdLevelRespFrom", title: "3rd Lvl Response From", width: "100px" },
                        { field: "thirdLevelRespAction", title: "3rd Lvl Intended Action", width: "150px" },
                        { field: "thirdLevelRespComment", title: "3rd Lvl Comment", width: "150px" },
                    ]
                }
            } else {
                if (viewRecs.showMGMT() && viewRecs.show3rdLvl()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "80px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "mgmtRespDate", title: "MGMT Response Date", width: "100px", template: "#= mgmtRespDate != null ? dayjs(mgmtRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "mgmtRespFrom", title: "MGMT Response From", width: "100px" },
                        { field: "mgmtRespAction", title: "MGMT Intended Action", width: "150px" },
                        { field: "mgmtRespComment", title: "MGMT Comment", width: "150px" },
                        { field: "thirdLevelRespDate", title: "3rd Lvl Response Date", width: "100px", template: "#= thirdLevelRespDate != null ? dayjs(thirdLevelRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "thirdLevelRespFrom", title: "3rd Lvl Response From", width: "100px" },
                        { field: "thirdLevelRespAction", title: "3rd Lvl Intended Action", width: "150px" },
                        { field: "thirdLevelRespComment", title: "3rd Lvl Comment", width: "150px" },
                    ]
                } else if (viewRecs.showMGMT()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "80px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "mgmtRespDate", title: "MGMT Response Date", width: "100px", template: "#= mgmtRespDate != null ? dayjs(mgmtRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "mgmtRespFrom", title: "MGMT Response From", width: "100px" },
                        { field: "mgmtRespAction", title: "MGMT Intended Action", width: "150px" },
                        { field: "mgmtRespComment", title: "MGMT Comment", width: "150px" },
                    ]
                } else if (viewRecs.show3rdLvl()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "80px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "thirdLevelRespDate", title: "3rd Lvl Response Date", width: "100px", template: "#= thirdLevelRespDate != null ? dayjs(thirdLevelRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "thirdLevelRespFrom", title: "3rd Lvl Response From", width: "100px" },
                        { field: "thirdLevelRespAction", title: "3rd Lvl Intended Action", width: "150px" },
                        { field: "thirdLevelRespComment", title: "3rd Lvl Comment", width: "150px" },
                    ]
                } else {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "80px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" }
                    ]
                }
            }

            if (viewRecs.isCargill()) {
                if (viewRecs.showMGMT() && viewRecs.show3rdLvl()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "recCode", title: "Rec. Code", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "60px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "mgmtRespDate", title: "MGMT Response Date", width: "100px", template: "#= mgmtRespDate != null ? dayjs(mgmtRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "mgmtRespFrom", title: "MGMT Response From", width: "100px" },
                        { field: "mgmtRespAction", title: "MGMT Intended Action", width: "150px" },
                        { field: "mgmtRespComment", title: "MGMT Comment", width: "150px" },
                        { field: "thirdLevelRespDate", title: "3rd Lvl Response Date", width: "100px", template: "#= thirdLevelRespDate != null ? dayjs(thirdLevelRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "thirdLevelRespFrom", title: "3rd Lvl Response From", width: "100px" },
                        { field: "thirdLevelRespAction", title: "3rd Lvl Intended Action", width: "150px" },
                        { field: "thirdLevelRespComment", title: "3rd Lvl Comment", width: "150px" },
                    ]
                } else if (viewRecs.showMGMT()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "recCode", title: "Rec. Code", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "60px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "mgmtRespDate", title: "MGMT Response Date", width: "100px", template: "#= mgmtRespDate != null ? dayjs(mgmtRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "mgmtRespFrom", title: "MGMT Response From", width: "100px" },
                        { field: "mgmtRespAction", title: "MGMT Intended Action", width: "150px" },
                        { field: "mgmtRespComment", title: "MGMT Comment", width: "150px" },
                    ]
                } else if (viewRecs.show3rdLvl()) {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "recCode", title: "Rec. Code", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "60px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" },
                        { field: "thirdLevelRespDate", title: "3rd Lvl Response Date", width: "100px", template: "#= thirdLevelRespDate != null ? dayjs(thirdLevelRespDate).format('DD-MMM-YY') : '' #" },
                        { field: "thirdLevelRespFrom", title: "3rd Lvl Response From", width: "100px" },
                        { field: "thirdLevelRespAction", title: "3rd Lvl Intended Action", width: "150px" },
                        { field: "thirdLevelRespComment", title: "3rd Lvl Comment", width: "150px" },
                    ]
                } else {
                    gridColumnMap = [
                        { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                        { field: "fileNo", title: "File No.", width: "60px" },
                        { field: "recYear", title: "Rec. Year", width: "50px", },
                        { field: "recMonth", title: "Rec. Month", width: "60px", },
                        { field: "recNumber", title: "Rec. No.", width: "60px" },
                        { field: "recSubLetter", title: "Rec. SubLetter", width: "90px" },
                        { field: "recCode", title: "Rec. Code", width: "90px" },
                        { field: "status", title: "Rec. Status", width: "100px", },
                        { field: "statusDate", title: "Status Date", width: "85px", template: "#= statusDate != null ? dayjs(statusDate).format('DD-MMM-YY') : '' #" },
                        { field: "impact", title: "Rec. Impact", width: "100px", attributes: { 'style': "background: #= impactBackColorHex #" } },
                        { field: "primaryRecType", title: "Primary Rec. Type", width: "150px", },
                        { field: "secondaryRecType", title: "Secondary Rec. Type", width: "150px", },
                        { field: "recKeyWords", title: "Rec. Key Words", width: "200px", },
                        { field: "history", title: "History", width: "60px" },
                        { field: "equipmentNo", title: "Equip. No", width: "60px" },
                        { field: "findingNo", title: "Finding No.", width: "60px" },
                        { field: "plantAreaAffected", title: "Plant Area Affected", width: "150px" },
                        { field: "probableEquipmentDamageCost", title: "Probible Equipment Damage", width: "150px" },
                        { field: "faultType", title: "Fault Type", width: "100px" },
                        { field: "detectedWith", title: "Detected With", width: "60px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" }
                    ]
                }
            }

            $('#recGrid').kendoGrid({
                dataSource: viewRecs.recGridDataSource(),
                columns: gridColumnMap
            });

            /* TOGGLE */
            if (viewRecs.recSwitch == null) {
                $("#recSwitch").kendoSwitch({
                    checked: false,
                    change: function (e) {
                        if (e.checked) {
                            viewRecs.includeAllRecs(true);
                            viewRecs.loadRecommendationsData();
                            viewRecs.hideRecForm();
                        } else {
                            viewRecs.includeAllRecs(false);
                            viewRecs.loadRecommendationsData();
                            viewRecs.hideRecForm();
                        }
                    }
                });

            }
            viewRecs.recSwitch = $("#recSwitch").data('kendoSwitch');
            
            /* TOOLTIP */
            $('#switchLbl').kendoTooltip({
                content:"Conf completed, Removed, and Advisory recommendations are excluded by default.  Turn on to include recommendations with these statuses."
            });

            /* DATE PICKERS */
            var statusDate = $('#recStatusDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecs.recStatusDate(),
            });

            var recFacilityRespDatePicker = $('#recFacilityRespDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecs.recFacilityRespDate(),
            });

            var mgmtRespDatePicker = $('#recMGMTRespDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecs.recMGMTRespDate(),
            });

            var thirdLvlRespDatePicker = $('#recThirdLvlRespDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecs.recThirdLvlRespDate(),
            });

            var facilityExpCompDatePicker = $('#recFacilityExpectedCompDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecs.recFacilityExpectedCompDate(),
            });

            $('#recMGMTExpectedCompDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecs.recMGMTExpectedCompDate(),
            });

            $('#recThridLvlExpectedCompDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecs.recThirdLvlExpectedCompDate(),
            });
        },

        firstRec: function () {
            viewRecs.pagerBindRecForm(viewRecs.firstRecommendation());
        },
        lastRec: function () {
            viewRecs.pagerBindRecForm(viewRecs.lastRecommendation());
        },
        nextRec: function () {
            viewRecs.pagerBindRecForm(viewRecs.nextRecommendation());
        },
        previousRec: function () {
            viewRecs.pagerBindRecForm(viewRecs.previousRecommendation());
        },

        displayRecForm: function (pFileNo, pID) {
            viewRecs.bindRecForm(pFileNo, pID);
            $('#recGridHldr').fadeOut("slow");
            $('#recSection').fadeIn("slow");
            var tempRowHeight = $('#recFacilityComment').height();
            $('.facilityRow').each(function () {
                $(this).height(tempRowHeight);
            });
            if (viewRecs.showMGMT()) {
                var tempMGMTRowHeight = $('#mgmtCommentLbl').height();
                $('.mgmtRow').each(function () {
                    $(this).height(tempMGMTRowHeight);
                });
            }
            if (viewRecs.show3rdLvl()) {
                var temp3rdHeight = $('#thirdLvlCommentLbl').height();
                $('.thirLvlRow').each(function () {
                    $(this).height(temp3rdHeight);
                });
            }
        },

        //THIS FUNCTION IS USED TO BIND THE RECOMMENDATIONS FORM BASED ON GRID 'ENTER' BUTTON CLICK
        bindRecForm: function (pFileNo, pID) {
            for (var i = 0; i < viewRecs.recGridDataSource().length; i++) {
                //SET ENDPOINT URL FOR 'FIRST' RECOMMENDATIONS BUTTON
                if (i == 0) {
                    viewRecs.firstRecommendation(viewRecs.recGridDataSource()[i]);
                }
                //SET ENDPOINT URL FOR 'LAST' RECOMMENDATIONS BUTTON
                arrayLength = viewRecs.recGridDataSource().length;
                viewRecs.lastRecommendation(viewRecs.recGridDataSource()[arrayLength - 1]);

                //BIND REC FORM DATA BASED ON CLICK EVENT FROM THE GRID;
                //PASS ID, LOOP RECOMMENDATIONS DATA TO FIND THAT ROW;
                //BIND THE FORM AND DISPLAY
                if (pID == viewRecs.recGridDataSource()[i].rowGuid) {
                    //STORE CURRENT REC GUID
                    viewRecs.recGUID(viewRecs.recGridDataSource()[i].rowGuid);
                    //SET 'NEXT' PAGER BUTTON RECOMMENDATION
                    viewRecs.nextRecommendation(viewRecs.recGridDataSource()[i + 1]);
                    //SET 'PREVIOUS' PAGER BUTTON RECOMMENDATION
                    if (i - 1 >= 0) {
                        viewRecs.previousRecommendation(viewRecs.recGridDataSource()[i - 1]);
                    }
                    //SET UP PAGER COUNT INFORMATION
                    viewRecs.currentRecommendationIndex(i + 1);
                    viewRecs.totalRecommendationsCount(viewRecs.recGridDataSource().length);
                    viewRecs.recommendationCountBoxText(viewRecs.currentRecommendationIndex() + " of " + viewRecs.totalRecommendationsCount());
                    //IF WE ARE ON THE FIRST REC, DISABLE PREVIOUS AND FIRST BUTTONS
                    if (i == 0) {
                        $('#firstRecBtn').addClass('grcBlueDisabledBtn');
                        $('#firstRecBtn').prop('disabled', true);
                        $('#prevRecBtn').addClass('grcBlueDisabledBtn');
                        $('#prevRecBtn').prop('disabled', true);
                    } else {
                        $('#firstRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#firstRecBtn').prop('disabled', false);
                        $('#prevRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#prevRecBtn').prop('disabled', false);
                    }

                    //IF WE ARE ON THE LAST REC, DISABLE NEXT AND LAST BUTTONS
                    if (i + 1 == viewRecs.recGridDataSource().length) {
                        $('#nextRecBtn').addClass('grcBlueDisabledBtn');
                        $('#nextRecBtn').prop('disabled', true);
                        $('#lastRecBtn').addClass('grcBlueDisabledBtn');
                        $('#lastRecBtn').prop('disabled', true);
                    } else {
                        $('#nextRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#nextRecBtn').prop('disabled', false);
                        $('#lastRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#lastRecBtn').prop('disabled', false);
                    }
                    //SET ORIGINAL REC DATA FOR SAVE PROCESS
                    viewRecs.currentRec(viewRecs.recGridDataSource()[i]);

                    //LOAD LIST OF FILES ASSOCIATED WITH REC
                    viewRecs.loadFileList();
                    //SET FILE UPLOAD URL
                    for (let j = 0; j < viewRecs.currentRec()._Links.length; j++) {
                        if (viewRecs.currentRec()._Links[j].rel == "files") {
                            viewRecs.filesUploadEndpointUrl(viewRecs.currentRec()._Links[j].href);
                        }
                    }
                    
                    //ADJUST REC NUM TO BE Rec Year, Rec Month, Rec Number, Rec Subletter
                    //CHECK FOR NULL DATA AND REMOVE THE SPACE OR FORMAT NUMBER
                    var tempRecNo = "";
                    var tempYr = "";
                    var tempMo = "";
                    var tempNum = "";
                    var tempCode = "";
                    if (viewRecs.recGridDataSource()[i].recNumber == null) {
                        tempNum = "";
                    } else {
                        tempNum = "-" + viewRecs.recGridDataSource()[i].recNumber;
                    }
                    if (viewRecs.recGridDataSource()[i].recYear == null) {
                        tempYr = "";
                    } else {
                        tempYr = viewRecs.recGridDataSource()[i].recYear;
                    }
                    if (viewRecs.recGridDataSource()[i].recMonth == null || viewRecs.recGridDataSource()[i].recMonth == "") {
                        tempMo = "";
                    } else {
                        tempMo = "-" + viewRecs.recGridDataSource()[i].recMonth;
                    }

                    if (viewRecs.recGridDataSource()[i].recSubLetter == null || viewRecs.recGridDataSource()[i].recSubLetter == "") {
                        tempCode = "";
                    } else {
                        tempCode = "-" + viewRecs.recGridDataSource()[i].recSubLetter;
                    }

                    tempRecNo = tempYr + tempMo + tempNum + tempCode;
                    viewRecs.recCode(viewRecs.recGridDataSource()[i].recCode);
                    viewRecs.recNumber(tempRecNo);
                    viewRecs.recHazard(viewRecs.recGridDataSource()[i].hazard);
                    viewRecs.recImpact(viewRecs.recGridDataSource()[i].impact);
                    viewRecs.recPrimaryType(viewRecs.recGridDataSource()[i].primaryRecType);
                    viewRecs.recSecondaryType(viewRecs.recGridDataSource()[i].secondaryRecType);
                    viewRecs.recKeywords(viewRecs.recGridDataSource()[i].recKeyWords);
                    viewRecs.recCurrentLossEstActual(global.formatMoneyNoSymbol(viewRecs.recGridDataSource()[i].currentLossEstimate, 0));
                    viewRecs.recCurrentLossEstRange(viewRecs.recGridDataSource()[i].currentLossEstimateRange);
                    viewRecs.recCompletedLossEstActual(global.formatMoneyNoSymbol(viewRecs.recGridDataSource()[i].completedLossEstimate, 0));
                    viewRecs.recCompletedLossEstRange(viewRecs.recGridDataSource()[i].completedLossEstimateRange);
                    viewRecs.recEstCostToCompActual(global.formatMoneyNoSymbol(viewRecs.recGridDataSource()[i].costToCompleteEstimate, 0));
                    viewRecs.recEstCostToCompRange(viewRecs.recGridDataSource()[i].costToCompleteEstimateRange);
                    viewRecs.recSavingsRatio(global.formatMoneyNoSymbol(viewRecs.recGridDataSource()[i].savingsRatio, 0));
                    //CHECK REC STATUS TO SEE IF WE NEED TO DISPLAY SELF AUDIT FLAG ICON
                    viewRecs.isSelfAudit(viewRecs.recGridDataSource()[i].isSelfAuditRec);
                    if (viewRecs.isSelfAudit()) {
                        $('#selfAuditFlag').removeClass('noShow');
                    }

                    //SET CANCEL OBJECTS VALUES FOR DROPDOWNS
                    viewRecs.cancelStatus = viewRecs.recGridDataSource()[i].status;
                    viewRecs.cancelStatusID = viewRecs.recGridDataSource()[i].statusId;

                    viewRecs.recStatus(viewRecs.recGridDataSource()[i].status);
                    viewRecs.statusID(viewRecs.recGridDataSource()[i].statusId);

                    if (viewRecs.isIR()) {
                        viewRecs.recHistory(viewRecs.recGridDataSource()[i].history);
                        viewRecs.recSeverity(viewRecs.recGridDataSource()[i].severityRating);
                        viewRecs.recDetectedWith(viewRecs.recGridDataSource()[i].detectedWith);
                        viewRecs.recEquipmentNo(viewRecs.recGridDataSource()[i].equipmentNo);
                        viewRecs.recFindingNo(viewRecs.recGridDataSource()[i].findingNo);
                        viewRecs.recPlantArea(viewRecs.recGridDataSource()[i].plantAreaAffected);
                        viewRecs.recProbableEquipmentDamageCost(viewRecs.recGridDataSource()[i].probableEquipmentDamageCost);
                        viewRecs.recFaultType(viewRecs.recGridDataSource()[i].faultType);
                        viewRecs.recLengthBusInteruption(viewRecs.recGridDataSource()[i].lengthOfBusInterruption);
                        viewRecs.recRedundancySpare(viewRecs.recGridDataSource()[i].redundancySpare);
                    }

                    //SET UP REC STATUS DROPDOWN
                    if (!viewRecs.recStatusDropdownList) {
                        $('#recStatusDD').kendoDropDownList({
                            dataTextField: "displayText",
                            dataValueField: "id",
                            dataSource: viewRecs.recStatusDDData(),
                            value: viewRecs.statusID(),
                            //change: function (e) {
                            //    viewRecs.recStatusSelect(e);
                            //}
                        });
                    }
                    viewRecs.recStatusDropdownList = $('#recStatusDD').data("kendoDropdownList");
                    if (viewRecs.recGridDataSource()[i].statusDate != null) {
                        viewRecs.recStatusDate(dayjs(viewRecs.recGridDataSource()[i].statusDate).format('DD-MMM-YY'));
                    }
                    if (viewRecs.recGridDataSource()[i].respDate != null) {
                        viewRecs.recFacilityRespDate(dayjs(viewRecs.recGridDataSource()[i].respDate).format('DD-MMM-YY'));
                    }
                    if (dayjs(viewRecs.recGridDataSource()[i].respDate).isAfter(dayjs(viewRecs.recGridDataSource()[i].statusDate))) {
                        viewRecs.recFacilityRespDateBackColor(null);
                    } else {
                        viewRecs.recFacilityRespDateBackColor(viewRecs.recGridDataSource()[i].responseDateBackColor);
                    }
                    viewRecs.recFacilityRespFrom(viewRecs.recGridDataSource()[i].respFrom);

                    viewRecs.cancelFacilityIntendedAction = viewRecs.recGridDataSource()[i].intendedAction;
                    viewRecs.cancelFacilityIntendedActionID = viewRecs.recGridDataSource()[i].intendedActionId;

                    viewRecs.recFacilityIntendedAction(viewRecs.recGridDataSource()[i].intendedAction);
                    viewRecs.recIntendedActionID(viewRecs.recGridDataSource()[i].intendedActionId);

                    if (!viewRecs.recIntendedActionDropdownList) {
                        $('#recFacilityIntendedActionDD').kendoDropDownList({
                            dataSource: viewRecs.recFacilityIntendedActionDDData(),
                            dataTextField: "displayText",
                            dataValueField: "id",
                            value: viewRecs.recIntendedActionID(),
                            //change: function (e) {
                            //    viewRecs.intendedActionSelect(e)
                            //}
                        });
                    }
                    viewRecs.recIntendedActionDropdownList = $('#recFacilityIntendedActionDD').data("kendoDropdownList");
                    viewRecs.recFacilityComment(viewRecs.recGridDataSource()[i].facilityComment);
                    if (viewRecs.recGridDataSource()[i].expectedCompletionDate != null) {
                        viewRecs.recFacilityExpectedCompDate(dayjs(viewRecs.recGridDataSource()[i].expectedCompletionDate).format('DD-MMM-YY'));
                    }
                    viewRecs.recFacilityExpectedCompletionBackColor(viewRecs.recGridDataSource()[i].expectedCompletionDateBackColorHex);
                    viewRecs.recFacilityActualCostToComp(global.formatMoneyNoSymbol(viewRecs.recGridDataSource()[i].costToComplete, 0));
                    if (viewRecs.showMGMT()) {
                        if (viewRecs.recGridDataSource()[i].mgmtRespDate != null) {
                            viewRecs.recMGMTRespDate(dayjs(viewRecs.recGridDataSource()[i].mgmtRespDate).format('DD-MMM-YY'));
                        }
                        viewRecs.recMGMTRespFrom(viewRecs.recGridDataSource()[i].mgmtRespFrom);
                        viewRecs.cancelMGMTIntendedAction = viewRecs.recGridDataSource()[i].mgmtRespAction;
                        viewRecs.cancelMGMTIntendedActionID = viewRecs.recGridDataSource()[i].mgmtRespActionId;
                        viewRecs.recMGMTIntendedAction(viewRecs.recGridDataSource()[i].mgmtRespAction);
                        viewRecs.recMGMTRespActionId(viewRecs.recGridDataSource()[i].mgmtRespActionId);

                        if (!viewRecs.recMGMTIntendedActionDropdownList) {
                            $('#recMGMTIntendedActionDD').kendoDropDownList({
                                dataSource: viewRecs.recMGMTIntendedActionDDData(),
                                dataTextField: "displayText",
                                dataValueField: "id",
                                value: viewRecs.recMGMTRespActionId(),
                                //change: function (e) {
                                //    viewRecs.mgmtIntendeActionChange(e);
                                //}
                            });
                        }
                        viewRecs.recMGMTIntendedActionDropdownList = $('#recMGMTIntendedActionDD').data("kendoDropdownList");
                        viewRecs.recMGMTComment(viewRecs.recGridDataSource()[i].mgmtRespComment);
                    }
                    if (viewRecs.show3rdLvl()) {
                        if (viewRecs.recGridDataSource()[i].thirdLevelRespDate != null) {
                            viewRecs.recThirdLvlRespDate(dayjs(viewRecs.recGridDataSource()[i].thirdLevelRespDate).format('DD-MMM-YY'));
                        }
                        viewRecs.recThirdLvlRespFrom(viewRecs.recGridDataSource()[i].thirdLevelRespFrom);
                        viewRecs.cancel3rdLvlIntendedAction = viewRecs.recGridDataSource()[i].thirdLevelRespAction;
                        viewRecs.cancel3rdLvlIntendedActionID = viewRecs.recGridDataSource()[i].thirdLevelRespActionId;
                        viewRecs.recThirdLvlIntendedActionId(viewRecs.recGridDataSource()[i].thirdLevelRespActionId);
                        viewRecs.recThirdLvlIntendedAction(viewRecs.recGridDataSource()[i].thirdLevelRespAction);
                        if (!viewRecs.recThirdLvlIntendedActionDropdownList) {
                            $('#recThirdLvlIntendedActionDD').kendoDropDownList({
                                dataSource: viewRecs.recThirdLvlIntendedActionDDData(),
                                dataTextField: "displayText",
                                dataValueField: "id",
                                value: viewRecs.recThirdLvlIntendedActionId(),
                                //change: function (e) {
                                //    viewRecs.thirdLvlActionChange(e);
                                //}
                            });
                        }
                        viewRecs.recThirdLvlIntendedActionDropdownList = $('#recThirdLvlIntendedActionDD').data("kendoDropdownList");
                        viewRecs.recThirdLvlComment(viewRecs.recGridDataSource()[i].thirdLevelRespComment);
                    }

                    //CHECK IF EXPECTED COMPLETION DATE NEEDS TO BE REQUIRED
                    if (viewRecs.clientFeatures().indexOf("R") > -1) {
                        $('#recFacilityExpectedCompDatePicker').removeClass('required');
                        if ($('#recFacilityIntendedActionDD').val() != null || $('#recFacilityIntendedActionDD').val() != undefined) {
                            //AS LONG AS INTENDED ACTION IS NOT EQUAL TO: completed OR disagree - will not complete OR no commitment
                            if ($('#recFacilityIntendedActionDD').val().toLowerCase() != "6" &&
                                $('#recFacilityIntendedActionDD').val().toLowerCase() != "8" &&
                                $('#recFacilityIntendedActionDD').val().toLowerCase() != "10") {
                                $('#recFacilityExpectedCompDatePicker').addClass('required');
                            }
                        }
                    }
                    break;
                }
            }
        },

        //THIS FUNCTION IS USED TO BIND RECOMMENDATIONS FORM AFTER ANY PAGER BUTTON CLICK
        pagerBindRecForm: function (pData) {
            viewRecs.clearDropDownValues();
            //BIND REC FORM DATA BASED ON PAGER CLICK;
            viewRecs.currentRec(pData);
            //LOAD LIST OF FILES ASSOCIATED WITH REC
            viewRecs.loadFileList();
            //SET FILE UPLOAD URL
            for (let i = 0; i < viewRecs.currentRec()._Links.length; i++) {
                if (viewRecs.currentRec()._Links[i].rel == "files") {
                    viewRecs.filesUploadEndpointUrl(viewRecs.currentRec()._Links[i].href);
                }
            }
            
            //SET UP FIRST AND LAST RECS INCASE OF DATA CHANGE
            viewRecs.firstRecommendation(viewRecs.recGridDataSource()[0]);
            arrayLength = viewRecs.recGridDataSource().length;
            viewRecs.lastRecommendation(viewRecs.recGridDataSource()[arrayLength - 1]);
            //ADJUST REC NUM TO BE Rec Year, Rec Month, Rec Number, Rec Subletter
            //CHECK FOR NULL DATA AND REMOVE THE SPACE OR FORMAT NUMBER
            var tempRecNo = "";
            var tempYr = "";
            var tempMo = "";
            var tempNum = "";
            var tempCode = "";
            if (pData.recNumber == null) {
                tempNum = "";
            } else {
                tempNum = "-" + pData.recNumber;
            }
            if (pData.recYear == null) {
                tempYr = "";
            } else {
                tempYr = pData.recYear;
            }
            if (pData.recMonth == null || pData.recMonth == "") {
                tempMo = "";
            } else {
                tempMo = "-" + pData.recMonth;
            }

            if (pData.recSubLetter == null || pData.recSubLetter == "") {
                tempCode = "";
            } else {
                tempCode = "-" + pData.recSubLetter;
            }

            tempRecNo = tempYr + tempMo + tempNum + tempCode;
            viewRecs.recNumber(tempRecNo);
            viewRecs.recCode(pData.recCode);
            viewRecs.recHazard(pData.hazard);
            viewRecs.recImpact(pData.impact);
            viewRecs.recPrimaryType(pData.primaryRecType);
            viewRecs.recSecondaryType(pData.secondaryRecType);
            viewRecs.recKeywords(pData.recKeyWords);
            viewRecs.recCurrentLossEstActual(global.formatMoneyNoSymbol(pData.currentLossEstimate, 0));
            viewRecs.recCurrentLossEstRange(pData.currentLossEstimateRange);
            viewRecs.recCompletedLossEstActual(global.formatMoneyNoSymbol(pData.completedLossEstimate, 0));
            viewRecs.recCompletedLossEstRange(pData.completedLossEstimateRange);
            viewRecs.recEstCostToCompActual(global.formatMoneyNoSymbol(pData.costToCompleteEstimate, 0));
            viewRecs.recEstCostToCompRange(pData.costToCompleteEstimateRange);
            viewRecs.recSavingsRatio(global.formatMoneyNoSymbol(pData.savingsRatio, 0));
            //CHECK REC STATUS TO SEE IF WE NEED TO DISPLAY SELF AUDIT FLAG ICON
            viewRecs.isSelfAudit(pData.isSelfAuditRec);
            if (viewRecs.isSelfAudit()) {
                $('#selfAuditFlag').removeClass('noShow');
            }
            
            if (viewRecs.isCancelClicked) {
                viewRecs.recStatus(viewRecs.cancelStatus);
                viewRecs.currentRec().status = viewRecs.cancelStatus;
                viewRecs.statusID(viewRecs.cancelStatusID);
                viewRecs.currentRec().statusId = viewRecs.cancelStatusID;
                viewRecs.recFacilityIntendedAction(viewRecs.cancelFacilityIntendedAction);
                viewRecs.recIntendedActionID(viewRecs.cancelFacilityIntendedActionID);
                if (viewRecs.showMGMT()) {
                    viewRecs.recMGMTIntendedAction(viewRecs.cancelMGMTIntendedAction);
                    viewRecs.recMGMTRespActionId(viewRecs.cancelMGMTIntendedActionID);
                }
                if (viewRecs.show3rdLvl()) {
                    viewRecs.recThirdLvlIntendedAction(viewRecs.cancel3rdLvlIntendedAction);
                    viewRecs.recThirdLvlIntendedActionId(viewRecs.cancel3rdLvlIntendedActionID);
                }
            } else {
                viewRecs.recStatus(pData.status);
                viewRecs.cancelStatus = pData.status;
                viewRecs.statusID(pData.statusId);
                viewRecs.cancelStatusID = pData.statusId;
                viewRecs.recFacilityIntendedAction(pData.intendedAction);
                viewRecs.cancelFacilityIntendedAction = pData.intendedAction;
                viewRecs.cancelFacilityIntendedActionID = pData.intendedActionId;
                viewRecs.recIntendedActionID(pData.intendedActionId);
                //SET THE VALUE OF THE INTENDED ACTION DROPDOWN TO BE CORRECT FOR CURRENT REC
                let intendedDDList = $("#recFacilityIntendedActionDD").data("kendoDropDownList");
                intendedDDList.value(pData.intendedActionId);
                if (viewRecs.showMGMT()) {
                    viewRecs.cancelMGMTIntendedAction = pData.mgmtRespAction;
                    viewRecs.recMGMTIntendedAction(pData.mgmtRespAction);
                    viewRecs.recMGMTRespActionId(pData.mgmtRespActionId);
                    //SET THE VALUE OF THE INTENDED ACTION DROPDOWN TO BE CORRECT FOR CURRENT REC
                    let mgmtDDList = $('#recMGMTIntendedActionDD').data("kendoDropDownList");
                    mgmtDDList.value(pData.mgmtRespActionId);
                    viewRecs.cancelMGMTIntendedActionID = pData.mgmtRespActionId;
                }
                if (viewRecs.show3rdLvl()) {
                    viewRecs.cancel3rdLvlIntendedAction = pData.thirdLevelRespAction;
                    viewRecs.recThirdLvlIntendedAction(pData.thirdLevelRespAction);
                    viewRecs.recThirdLvlIntendedActionId(pData.thirdLevelRespActionId);
                    //SET THE VALUE OF THE INTENDED ACTION DROPDOWN TO BE CORRECT FOR CURRENT REC
                    let thirdLvlDDList = $('#recThirdLvlIntendedActionDD').data("kendoDropDownList");
                    thirdLvlDDList.value(pData.thirdLevelRespActionId);
                    viewRecs.cancel3rdLvlIntendedActionID = pData.thirdLevelRespActionId;
                }
            }
            
            //REBIND STATUS DROPDOWN SO THAT VALUES WILL BE CORRECT AFTER PAGING
            let statusDD = $('#recStatusDD').data("kendoDropDownList");
            statusDD.value(pData.statusId);

            if (pData.statusDate != null) {
                viewRecs.recStatusDate(dayjs(pData.statusDate).format('DD-MMM-YY'));
            }
            if (pData.respDate != null) {
                viewRecs.recFacilityRespDate(dayjs(pData.respDate).format('DD-MMM-YY'));
            } else {
                viewRecs.recFacilityRespDate(null);
            }
            viewRecs.recFacilityRespDateBackColor(pData.responseDateBackColor);
            viewRecs.recFacilityRespFrom(pData.respFrom);
            viewRecs.recFacilityComment(pData.facilityComment);

            if (viewRecs.isIR()) {
                viewRecs.recHistory(pData.history);
                viewRecs.recSeverity(pData.severityRating);
                viewRecs.recDetectedWith(pData.detectedWith);
                viewRecs.recEquipmentNo(pData.equipmentNo);
                viewRecs.recFindingNo(pData.findingNo);
                viewRecs.recPlantArea(pData.plantAreaAffected);
                viewRecs.recProbableEquipmentDamageCost(pData.probableEquipmentDamageCost);
                viewRecs.recFaultType(pData.faultType);
                viewRecs.recLengthBusInteruption(pData.lengthOfBusInterruption);
                viewRecs.recRedundancySpare(pData.redundancySpare);
            }

            if (pData.expectedCompletionDate != null) {
                viewRecs.recFacilityExpectedCompDate(dayjs(pData.expectedCompletionDate).format('DD-MMM-YY'));
            } else {
                viewRecs.recFacilityExpectedCompDate("");
            }
            viewRecs.recFacilityExpectedCompletionBackColor(pData.expectedCompletionDateBackColorHex);
            viewRecs.recFacilityActualCostToComp(global.formatMoneyNoSymbol(pData.costToComplete, 0));
            if (viewRecs.showMGMT()) {
                if (pData.mgmtRespDate != null) {
                    viewRecs.recMGMTRespDate(dayjs(pData.mgmtRespDate).format('DD-MMM-YY'));
                } else {
                    viewRecs.recMGMTRespDate("");
                }
                viewRecs.recMGMTRespFrom(pData.mgmtRespFrom);
                viewRecs.recMGMTComment(pData.mgmtRespComment);
            }
            if (viewRecs.show3rdLvl()) {
                if (pData.thirdLevelRespDate != null) {
                    viewRecs.recThirdLvlRespDate(dayjs(pData.thirdLevelRespDate).format('DD-MMM-YY'));
                } else {
                    viewRecs.recThirdLvlRespDate("");
                }
                viewRecs.recThirdLvlRespFrom(pData.thirdLevelRespFrom);
                viewRecs.recThirdLvlComment(pData.thirdLevelRespComment);
            }

            for (var j = 0; j < viewRecs.recGridDataSource().length; j++) {
                if (viewRecs.currentRec().rowGuid == viewRecs.recGridDataSource()[j].rowGuid) {
                    viewRecs.recGUID(viewRecs.currentRec().rowGuid);
                    //SET UP PAGER COUNT INFORMATION
                    viewRecs.currentRecommendationIndex(j + 1);
                    viewRecs.totalRecommendationsCount(viewRecs.recGridDataSource().length);
                    viewRecs.recommendationCountBoxText(viewRecs.currentRecommendationIndex() + " of " + viewRecs.totalRecommendationsCount());
                    //DETERMIN WHICH PAGER BUTTONS ARE ACTIVE
                    if (viewRecs.currentRecommendationIndex() == viewRecs.recGridDataSource().length) {
                        $('#nextRecBtn').addClass('grcBlueDisabledBtn');
                        $('#nextRecBtn').prop('disabled', true);
                        $('#lastRecBtn').addClass('grcBlueDisabledBtn');
                        $('#lastRecBtn').prop('disabled', true);

                        $('#firstRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#firstRecBtn').prop('disabled', false);
                        $('#prevRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#prevRecBtn').prop('disabled', false);
                    }
                    if (viewRecs.currentRecommendationIndex() - 1 == 0) {
                        $('#firstRecBtn').addClass('grcBlueDisabledBtn');
                        $('#firstRecBtn').prop('disabled', true);
                        $('#prevRecBtn').addClass('grcBlueDisabledBtn');
                        $('#prevRecBtn').prop('disabled', true);

                        $('#nextRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#nextRecBtn').prop('disabled', false);
                        $('#lastRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#lastRecBtn').prop('disabled', false);
                    }
                    if (viewRecs.currentRecommendationIndex() - 1 > 0 && viewRecs.currentRecommendationIndex() < viewRecs.recGridDataSource().length) {

                        $('#firstRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#firstRecBtn').prop('disabled', false);
                        $('#prevRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#prevRecBtn').prop('disabled', false);

                        $('#nextRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#nextRecBtn').prop('disabled', false);
                        $('#lastRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#lastRecBtn').prop('disabled', false);
                    }
                    //SET PREVIOUS AND NEXT RECOMMENDATIONS BUTTON URLS
                    if (j - 1 >= 0) {
                        viewRecs.previousRecommendation(viewRecs.recGridDataSource()[j - 1]);
                    }
                    if (j + 1 < viewRecs.recGridDataSource().length) {
                        viewRecs.nextRecommendation(viewRecs.recGridDataSource()[j + 1]);
                    }
                }
            }

            //CHECK IF EXPECTED COMPLETION DATE NEEDS TO BE REQUIRED
            if (viewRecs.clientFeatures().indexOf("R") > -1) {
                $('#recFacilityExpectedCompDatePicker').removeClass('required');
                if ($('#recFacilityIntendedActionDD').val() != null || $('#recFacilityIntendedActionDD').val() != undefined) {
                    if ($('#recFacilityIntendedActionDD').val().toLowerCase() != "6" &&
                        $('#recFacilityIntendedActionDD').val().toLowerCase() != "8" &&
                        $('#recFacilityIntendedActionDD').val().toLowerCase() != "10") {
                        $('#recFacilityExpectedCompDatePicker').addClass('required');
                    }
                }
            }

            var tempRowHeight = $('#recFacilityComment').height();
            $('.facilityRow').each(function () {
                $(this).height(tempRowHeight);
            });
            if (viewRecs.showMGMT()) {
                var tempMGMTRowHeight = $('#mgmtCommentLbl').height();
                $('.mgmtRow').each(function () {
                    $(this).height(tempMGMTRowHeight);
                });
            }
            if (viewRecs.show3rdLvl()) {
                var temp3rdHeight = $('#thirdLvlCommentLbl').height();
                $('.thirLvlRow').each(function () {
                    $(this).height(temp3rdHeight);
                });
            }
            viewRecs.isCancelClicked = false;
        },

        clearDropDownValues: function () {
            viewRecs.recStatus("");
            viewRecs.recFacilityIntendedAction("");
            viewRecs.recIntendedActionID("");
            viewRecs.recMGMTIntendedAction("");
            viewRecs.recMGMTRespActionId("");
            viewRecs.recThirdLvlIntendedAction("");
        },

        hideRecForm: function () {
            $('#recSection').fadeOut("slow");
            $('#recGridHldr').fadeIn("slow");
        },

        onEditBtnClick: function (pAction) {
            viewRecs.changeButtons(pAction);
            switch (pAction) {
                case 'edit':
                    viewRecs.changeFormLook('edit');
                    break;
                case 'cancel':
                    viewRecs.changeFormLook('display');
                    break;
            }
        },

        onFilesBtnClick: function () {
            $('#recSection').fadeOut("slow");
            $('#filesSection').fadeIn("slow");
        },

        onBackToRecClick: function () {
            $('#filesSection').fadeOut("slow");
            $('#recSection').fadeIn("slow");
        },

        onBackToRecGridClick: function () {
            $('#filesSection').fadeOut("slow");
            $('#recGridHldr').fadeIn("slow");
        },

        onDeleteBtnClick: function () {
            var endPointURL = viewRecs.endPointBase + "recs/" + viewRecs.recGUID();
            if (confirm("Are you sure you want to delete this recommendation?")) {
                $.ajax({
                    type: "DELETE",
                    dataType: "json",
                    contentType: "application/javascript",
                    async: false,
                    url: endPointURL,
                    success: function (pResults) {
                        if (pResults.isSuccess) {
                            alert("Recommendation has been successfully deleted.");
                            location.reload();
                        } else {
                            alert(pResults.message);
                        }
                    },
                    error: function (pMessage) {
                        alert(pMessage)
                    }
                });
            }

        },

        onSaveBtnClick: function () {
            if (viewRecs.clientFeatures().indexOf("R") > -1) {
                if ($('#recFacilityExpectedCompDatePicker').val() == null || $('#recFacilityExpectedCompDatePicker').val() == "") {
                    if ($('#recFacilityIntendedActionDD').val() != null || $('#recFacilityIntendedActionDD').val() != undefined) {
                        //AS LONG AS INTENDED ACTION IS NOT EQUAL TO: completed OR disagree - will not complete OR no commitment
                        if ($('#recFacilityIntendedActionDD').val().toLowerCase() != "6" &&
                            $('#recFacilityIntendedActionDD').val().toLowerCase() != "8" &&
                            $('#recFacilityIntendedActionDD').val().toLowerCase() != "10") {
                            $('#recFacilityExpectedCompDatePicker').addClass('required');
                            alert("Expected Completion Date is required.");
                        } else {
                            //SHOW LOADER HERE
                            $('#tabLocDetailsLoading').removeClass('noShow');
                            viewRecs.populateSaveObject();
                            var dSave = ko.toJSON(viewRecs.currentRec());
                            viewRecs.saveRecForm(dSave);
                        }
                    }
                } else {
                    //SHOW LOADER HERE
                    $('#tabLocDetailsLoading').removeClass('noShow');
                    viewRecs.populateSaveObject();
                    var dSave = ko.toJSON(viewRecs.currentRec());
                    viewRecs.saveRecForm(dSave);
                }
            } else {
                //SHOW LOADER HERE
                $('#tabLocDetailsLoading').removeClass('noShow');
                viewRecs.populateSaveObject();
                var dSave = ko.toJSON(viewRecs.currentRec());
                viewRecs.saveRecForm(dSave);
            }
        },

        populateSaveObject: function () {
            viewRecs.currentRec().statusId = parseInt($('#recStatusDD').val());
            viewRecs.currentRec().statusDate = global.convertGRCStringToDate($('#recStatusDatePicker').val());
            viewRecs.currentRec().respDate = global.convertGRCStringToDate($('#recFacilityRespDatePicker').val());
            viewRecs.currentRec().intendedActionId = parseInt($('#recFacilityIntendedActionDD').val());
            viewRecs.currentRec().respFrom = $('#recFacilityRespFrom').val();
            if (!viewRecs.isIR()) {
                let tempCost = $('#facilityActCostComp').val();
                if (tempCost.indexOf(",") > -1) {
                    let re = /,/gi;
                    let newCost = tempCost.replace(re, "");
                    viewRecs.currentRec().costToComplete = parseInt(newCost);
                } else {
                    viewRecs.currentRec().costToComplete = parseInt(tempCost);
                }
            }
            viewRecs.currentRec().facilityComment = $('#recFacilityComment').val();
            viewRecs.currentRec().expectedCompletionDate = global.convertGRCStringToDate($('#recFacilityExpectedCompDatePicker').val());
            
            if (viewRecs.showMGMT()) {
                viewRecs.currentRec().mgmtRespDate = global.convertGRCStringToDate($('#recMGMTRespDatePicker').val());
                viewRecs.currentRec().mgmtRespFrom = $('#mgmtRecRespFrom').val();
                viewRecs.currentRec().mgmtRespActionId = parseInt($('#recMGMTIntendedActionDD').val());
                viewRecs.currentRec().mgmtRespComment = $('#mgmtComment').val();
            }
            if (viewRecs.show3rdLvl()) {
                viewRecs.currentRec().thirdLevelRespDate = global.convertGRCStringToDate($('#recThirdLvlRespDatePicker').val());
                viewRecs.currentRec().thirdLevelRespFrom = $('#recThirdLvlRespFrom').val();
                viewRecs.currentRec().thirdLevelRespActionId = parseInt($('#recThirdLvlIntendedActionDD').val());
                viewRecs.currentRec().thirdLevelRespComment = $('#thirdLvlComment').val();
            }
        },

        onCancelBtnClick: function (pAction) {
            viewRecs.isCancelClicked = true;
            viewRecs.changeButtons(pAction);
            viewRecs.bindCanceledRecForm();
            viewRecs.changeFormLook('display');
        },

        saveRecForm: function (pData) {
            var saveEndPontURL = viewRecs.currentRec()._Links[0].href;
            $.ajax({
                type: "PUT",
                data: pData,
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: saveEndPontURL,
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecs.saveRecFormSuccess();
                    } else {
                        viewRecs.saveRecFormError(pResults);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error saving recommendation data: " + pMessage);
                }
            });
        },
        saveRecFormSuccess: function () {
            viewRecs.changeFormLook("display");
            viewRecs.changeButtons('cancel');
            //HIDE LOADER HERE
            $('#tabLocDetailsLoading').addClass('noShow');
            viewRecs.loadSavedRec(viewRecs.currentRec().rowGuid);
            viewRecs.loadRecCounts(viewRecs.currentRec());
            viewRecs.loadRecommendationsData();
        },
        saveRecFormError: function (pResults) {
            alert("An error occured during the save process: " + pResults.message + " Your changes were not saved.");
            location.reload();
        },

        changeButtons: function (pAction) {
            if (pAction == 'edit') {
                $('#editDelete').addClass('noShow');
                $('#recPagerBtnHldr').addClass('noShow');
                $('#saveCancel').removeClass('noShow');
            }
            if (pAction == 'cancel') {
                $('#saveCancel').addClass('noShow');
                $('#editDelete').removeClass('noShow');
                $('#recPagerBtnHldr').removeClass('noShow');
            }
        },

        changeFormLook: function (pFormToDisplay) {
            switch (pFormToDisplay) {
                case 'edit':
                    $('.editRowDisplayValue').each(function () {
                        $(this).addClass('noShow');
                    });
                    $('.editRowEditValue').each(function () {
                        $(this).removeClass('noShow');
                    });
                    var tempRowHeight = $('#recFacilityComment').height();
                    $('.facilityRow').each(function () {
                        $(this).height(tempRowHeight);
                    });

                    if (viewRecs.showMGMT()) {
                        var tempMGMTRowHeight = $('#mgmtComment').height();
                        $('.mgmtRow').each(function () {
                            $(this).height(tempMGMTRowHeight);
                        });
                    }

                    if (viewRecs.show3rdLvl()) {
                        var temp3rdHeight = $('#thirdLvlComment').height();
                        $('.thirLvlRow').each(function () {
                            $(this).height(temp3rdHeight);
                        });
                    } 

                    $('.closeRec').addClass('noShow');
                    $('.recEditFields').addClass('editMode');
                    //CHECK FOR ADMIN TO DETERMIN EDITABLITY OF STATUS AND STATUS DATE
                    if (viewRecs.isAdmin()) {
                        $('#recStatusDatePicker').find(".k-icon").removeClass("recEditField");
                        $('#recStatusDateDisplay').addClass('noShow');
                        $('#recStatusDisplay').addClass('noShow');
                        $('#recStatusDDHldr').removeClass('noShow');
                        $('#recStatusDatePickerHldr').removeClass('noShow');
                    }


                    if (!viewRecs.isAutoRec()) {
                        $('#respFromHldr').removeClass('noShow');
                        $('#recFacilityRespDatePickerHldr').removeClass('noShow');
                    } else {
                        //FOR AUTO REC: 
                        //SET RESPONSE FROM VALUE TO CURRENT USER
                        $('#recFacilityRespFrom').val(viewRecs.currentUser().name);
                        //SET RESPONSE DATE TO TODAY'S DATE
                        var today = new Date();
                        $('#recFacilityRespDatePickerHldr').val(today);
                    }
                    $('#recFacilityIntendedActionDDHldr').removeClass('noShow');
                    $('#recFacilityIntendedActionDDHldr').val(viewRecs.currentRec().intendedAction);
                    $('#recFacilityExpectedCompDatePickerHldr').removeClass('noShow');
                    $('#actCostToCompHldr').removeClass('noShow');
                    $('#commentHldr').removeClass('noShow');
                    $('#recFacilityRespDatePicker').find(".k-icon").removeClass("recEditField");
                    $('#recFacilityExpectedCompDatePicker').find(".k-icon").removeClass("recEditField");
                    //FIX FOR CALENDAR ICONS NOT DISPLAYING CORRECTLY
                    $('<i class="far fa-calendar-alt"></i>').insertBefore($('.k-i-calendar'));
                    $("span").remove('.k-i-calendar');

                    if (viewRecs.showMGMT()) {
                        //SHOW EDITS
                        $('#mgmtRecRespDatePickerHldr').removeClass('noShow');
                        $('#mgmtRecRespFromHldr').removeClass('noShow');
                        $('#mgmtRecIntendedActionHldr').removeClass('noShow');
                        $('#mgmtRecExpectedCompDatePickerHldr').removeClass('noShow');
                        $('#mgmtCommentHldr').removeClass('noShow');
                        $('#recMGMTRespDatePicker').find(".k-icon").removeClass("editRequired");
                    }
                    if (viewRecs.show3rdLvl()) {
                        $('#recThirdLvlRespDatePickerHldr').removeClass('noShow');
                        $('#recThirdLvlRespFromHldr').removeClass('noShow');
                        $('#recThirdLvlIntendedActionDDHldr').removeClass('noShow');
                        $('#thirdLvlCommentHldr').removeClass('noShow');
                        $('#recThirdLvlRespDatePicker').find(".k-icon").removeClass("editRequired");
                    }
                    break;
                case 'display':
                    $('.editRowEditValue').each(function () {
                        $(this).addClass('noShow');
                    });
                    $('.editRowDisplayValue').each(function () {
                        $(this).removeClass('noShow');
                    });
                    var tempRowHeight = $('#commentLbl').height();
                    $('.facilityRow').each(function () {
                        $(this).height(tempRowHeight);
                    });

                    if (viewRecs.showMGMT()) {
                        var tempMGMTRowHeight = $('#mgmtCommentLbl').height();
                        $('.mgmtRow').each(function () {
                            $(this).height(tempMGMTRowHeight);
                        });
                    }

                    if (viewRecs.show3rdLvl()) {
                        var temp3rdHeight = $('#thirdLvlCommentLbl').height();
                        $('.thirLvlRow').each(function () {
                            $(this).height(temp3rdHeight);
                        });
                    } 

                    $('.closeRec').removeClass('noShow');
                    $('#recFacilityRespDatePickerHldr').addClass('noShow');
                    $('#respFromHldr').addClass('noShow');
                    $('#recFacilityIntendedActionDDHldr').addClass('noShow');
                    $('#recFacilityExpectedCompDatePickerHldr').addClass('noShow');
                    $('#actCostToCompHldr').addClass('noShow');
                    $('#commentHldr').addClass('noShow');
                    $('#recStatusDatePickerHldr').addClass('noShow');
                    $('#recStatusDDHldr').addClass('noShow');
                    $('#recStatusDateDisplay').removeClass('noShow');
                    $('#recStatusDisplay').removeClass('noShow');
                    $('.recEditFields').removeClass('editMode');

                    if (viewRecs.showMGMT()) {
                        //HIDE EDITS
                        $('#mgmtRecRespDatePickerHldr').addClass('noShow');
                        $('#mgmtRecRespFromHldr').addClass('noShow');
                        $('#mgmtRecIntendedActionHldr').addClass('noShow');
                        $('#mgmtActCostHldr').addClass('noShow');
                        $('#mgmtCommentHldr').addClass('noShow');
                    }

                    if (viewRecs.show3rdLvl()) {
                        //HIDE EDITS
                        $('#recThirdLvlRespDatePickerHldr').addClass('noShow');
                        $('#recThirdLvlRespFromHldr').addClass('noShow');
                        $('#recThirdLvlIntendedActionDDHldr').addClass('noShow');
                        $('#thirdLvlCommentHldr').addClass('noShow');
                    }

                    break;
                case "files":
                    break;
            }

        },

        bindCanceledRecForm: function () {
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: viewRecs.recommendationsDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecs.recGridDataSource(pResults.data);
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (pResults.data[i].rowGuid == viewRecs.currentRec().rowGuid) {
                                viewRecs.pagerBindRecForm(pResults.data[i]);
                                break;
                            }
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error Canceling recommendations data changes: " + pMessage);
                }
            });
        },

        recStatusSelect: function (e) {
            let dataItem = e.sender.dataItem();
            viewRecs.recStatus(dataItem.displayText);
            viewRecs.currentRec().status = dataItem.displayText;
            viewRecs.statusID(dataItem.id);
            viewRecs.currentRec().statusId = dataItem.id;
        },

        intendedActionSelect: function (e) {
            let dataItem = e.sender.dataItem();
            viewRecs.currentRec().intendedAction = dataItem.displayText;
            viewRecs.currentRec().intendedActionId = dataItem.id;
            viewRecs.recFacilityIntendedAction(dataItem.displayText);
            viewRecs.recIntendedActionID(dataItem.id);

            if (viewRecs.recStatus().toLowerCase() != "advisory" &&
                viewRecs.recStatus().toLowerCase() != "conf completed" &&
                viewRecs.recStatus().toLowerCase() != "removed") {
                if (dataItem.id == 6) {
                    //COMPLETED
                    viewRecs.currentRec().intendedAction = "Completed";
                    viewRecs.currentRec().intendedActionId = 6;
                    viewRecs.recStatus("Rptd Completed");
                    viewRecs.currentRec().status = "Rptd Completed";
                    viewRecs.statusID(6);
                    viewRecs.currentRec().statusId = 6;
                    $('#recStatusDD').val(6);
                } else if (dataItem.id == 9) {
                    //IN PROGRESS
                    viewRecs.currentRec().intendedAction = "In Progress";
                    viewRecs.currentRec().intendedActionId = 9;
                    if (viewRecs.recStatus().toLowerCase() != "advisory") {
                        viewRecs.recStatus("In Progress");
                        viewRecs.currentRec().status = "In Progress";
                        viewRecs.statusID(3);
                        viewRecs.currentRec().statusId = 3;
                        $('#recStatusDD').val(3);
                    } else {
                        viewRecs.recStatus("Advisory");
                        viewRecs.currentRec().status = "Advisory";
                        viewRecs.statusID(1);
                        viewRecs.currentRec().statusId = 1;
                        $('#recStatusDD').val(1);
                    }
                } else {
                    viewRecs.recStatus("Outstanding");
                    viewRecs.currentRec().status = "Outstanding";
                    viewRecs.statusID(4);
                    viewRecs.currentRec().statusId = 4;
                    $('#recStatusDD').val(4);
                }
            } else if (viewRecs.recStatus().toLowerCase() == "advisory" || $('#recStatusDD').val() == "advisory") {
                if (dataItem.id == 6) {
                    //COMPLETED
                    viewRecs.recStatus("Rptd Completed");
                    viewRecs.currentRec().status = "Rptd Completed";
                    viewRecs.statusID(6);
                    viewRecs.currentRec().statusId = 6;
                    $('#recStatusDD').val(6);
                }
            }
        },

        mgmtIntendeActionChange: function (e) {
            let dataItem = e.sender.dataItem();
            viewRecs.recMGMTRespActionId(dataItem.id);
            viewRecs.currentRec().mgmtRespActionId = dataItem.id;
            viewRecs.recMGMTIntendedAction(dataItem.displayText);
            viewRecs.currentRec().mgmtRespAction = dataItem.displayText;
        },

        thirdLvlActionChange: function (e) {
            let dataItem = e.sender.dataItem();
            viewRecs.recThirdLvlIntendedActionId(dataItem.id);
            viewRecs.currentRec().thirdLevelRespActionId = dataItem.id;
            viewRecs.recThirdLvlIntendedAction(dataItem.displayText);
            viewRecs.currentRec().thirdLevelRespAction = dataItem.displayText;
        },

        getERReport: function () {
            $.ajax({
                type: "GET",
                cache: true,
                async: false,
                contentType: "text/plain",
                url: viewRecs.er_ReportEndPointUrl(),
                success: function (pResults) {
                    return global.openFile(pResults.data.content, pResults.data.fileName,'application/pdf');
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading er report data: " + pMessage);
                }
            });
        },

        getDiagramReport: function () {
            $.ajax({
                type: "GET",
                cache: true,
                async: false,
                contentType: "text/plain",
                url: viewRecs.diagramReportEndPointUrl(),
                success: function (pResults) {
                    return global.openFile(pResults.data.content, pResults.data.fileName, 'application/pdf');
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading er report data: " + pMessage);
                }
            });
        },

        bindForm: function () {
            ko.applyBindings(viewRecs, $("#viewRecs")[0]);
        },
    }

    viewRecs.bindForm();
    viewRecs.init();

    function onEnter(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        viewRecs.displayRecForm(dataItem.fileNo, dataItem.rowGuid);
    }

});