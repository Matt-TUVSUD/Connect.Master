var gSafeGuid = getGSafeGUID();

/* API HELP PAGE */
/* dev.globalriskconsultants.com/capi/help */

$(document).ready(function () {
    globalKeyBing = gServerSide_BingMapKey;
    globalClientFeatures = gServerSide_ClientFeatures;

    var viewMaster = {
        onCloseLanguageSelector: function (e) {
            //// UPDATE DSLANGUAGELABELS
            switch (e.dataItem.displayText.toLowerCase()) {
                case "deutsch":
                    viewRecResp.langID(3);
                    viewRecResp.updateUserLanguagePreference();
                    break;
                case "english":
                    viewRecResp.langID(1);
                    viewRecResp.updateUserLanguagePreference();
                    break;
                case "español":
                    viewRecResp.langID(6);
                    viewRecResp.updateUserLanguagePreference();
                    break;
                case "français":
                    viewRecResp.langID(2);
                    viewRecResp.updateUserLanguagePreference();
                    break;
                case "italiano":
                    viewRecResp.langID(4);
                    viewRecResp.updateUserLanguagePreference();
                    break;
                case "português":
                    viewRecResp.langID(5);
                    viewRecResp.updateUserLanguagePreference();
                    break;
                default:
                    //// DO NOTHING, THE USER DOES NOT WANT TO MAKE A CHANGE
                    break;
            }
        }
    };

    var viewRecResp = {

        //LABEL VALUES FOR THE MASTER PAGE
        lblInst_Language_Title: ko.observable(),
        lblInst_Language_Text: ko.observable(),
        lblInst_Edit_Title: ko.observable(),
        lblInst_Edit_Text: ko.observable(),
        lblInst_Responses_Title: ko.observable(),
        lblInst_Responses_Text: ko.observable(),
        lblInst_Email_Title: ko.observable(),
        lblInst_Email_Text: ko.observable(),

        //LABEL VALUES FOR TRANSLATIONS
        fileNoLbl: ko.observable(),
        facilityLbl: ko.observable(),
        addressLbl: ko.observable(),
        countryLbl: ko.observable(),
        longitudeLbl: ko.observable(),
        latitudeLbl: ko.observable(),
        clientLocIdLbl: ko.observable(),
        divisionLbl: ko.observable(),
        tivLbl: ko.observable(),
        customAccessLbl: ko.observable(),
        recNumLbl: ko.observable(),
        recStatusLbl: ko.observable(),
        recStatusDateLbl: ko.observable(),
        recHazardLbl: ko.observable(),
        recImpactLbl: ko.observable(),
        recPrimaryTypeLbl: ko.observable(),
        recSecondaryTypeLbl: ko.observable(),
        currentLossEstLbl: ko.observable(),
        completedLossEstLbl: ko.observable(),
        estCostToCompLbl: ko.observable(),
        recSavingsRatioLbl: ko.observable(),
        keyWordsLbl: ko.observable(),
        respDateLbl: ko.observable(),
        respFromLbl: ko.observable(),
        intendedActionLbl: ko.observable(),
        expdCompDateLbl: ko.observable(),
        actCostToCompLbl: ko.observable(),
        commentLbl: ko.observable(),
        mgmtLbl: ko.observable(),
        thirdLvlLbl: ko.observable(),
        actualLbl: ko.observable(),
        rangeLbl: ko.observable(),
        responseCompletedLbl: ko.observable(),
        responseNeededLbl: ko.observable(),
        editLbl: ko.observable(),
        saveLbl: ko.observable(),
        closeLbl: ko.observable(),
        cancelLbl: ko.observable(),
        recommendationsLbl: ko.observable(),

        currentFilePrefix: ko.observable(getQueryVariable("p1")),
        currentServiceCode: ko.observable(getQueryVariable("p2")),
        currentUser: ko.observable(),
        clientFeatures: ko.observable(),
        showMGMT: ko.observable(false),
        show3rdLvl: ko.observable(false),
        isAdmin: ko.observable(false),
        isAutoRec: ko.observable(false),
        isSelfAudit: ko.observable(false),
        isFire: ko.observable(false),
        isIR: ko.observable(false),
        isCargill: ko.observable(false),
        locationData: ko.observableArray(),
        currentLocation: ko.observable(),
        totalLocationsCount: ko.observable(),
        locationsCountBoxText: ko.observable(),
        currentLocationIndex: ko.observable(),
        objRRLog: ko.observable(),
        collRRLog: new es.objects.RRLogCollection(),

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
        practiceId: ko.observable(),
        recGridDataSource: ko.observableArray(),
        currentRec: ko.observable(),

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
        langSelectorDD_Data: ko.observableArray(),
        langSelectorDDList: null,
        langSelectorText: ko.observable(),

        //INFRARED SPECIFIC RECOMMENDATION DATA VALUES
        historyLbl: ko.observable(),
        recHistory: ko.observable(),
        severityLbl: ko.observable(),
        recSeverity: ko.observable(),
        equipNumLbl: ko.observable(),
        recEquipmentNo: ko.observable(),
        findingsNumLbl: ko.observable(),
        recFindingNo: ko.observable(),
        plantAreaLbl: ko.observable(),
        recPlantArea: ko.observable(),
        recProbableEquipmentDamageCost: ko.observable(),
        faultTypeLbl: ko.observable(),
        recFaultType: ko.observable(),
        lengthOfBusInteruptionLbl: ko.observable(),
        recLengthBusInteruption: ko.observable(),
        detectedWithLbl: ko.observable(),
        recDetectedWith: ko.observable(),
        redundancySpareLbl: ko.observable(),
        recRedundancySpare: ko.observable(),
        codeLbl: ko.observable(),

        //API VALUES
        AppKey: "2F14E5EF-333D-4A14-AB41-0CCC586F7E48",
        UserSid: ko.observable(getQueryVariable('sid')),
        endPointBase: "",
        endPointFilePrefix: ko.observable(),
        langID: ko.observable(),

        userDataEndPointUrl: ko.observable(),
        userLangIDEndPointUrl: ko.observable(),
        locationDataEndPointUrl: ko.observable(),
        locationPagerEndPointUrl: ko.observable(),
        locationCountUrl: ko.observable(),
        recommendationsDataEndPointUrl: ko.observable(),
        recommendationsPagerEndPointUrl: ko.observable(),
        firstLocationBtnUrl: ko.observable(),
        nextLocationBtnUrl: ko.observable(),
        previousLocationBtnUrl: ko.observable(),
        lastLocationBtnUrl: ko.observable(),
        reportsEndPointUrl: ko.observable(),
        er_ReportEndPointUrl: ko.observable(),
        diagramReportEndPointUrl: ko.observable(),

        firstRecommendation: ko.observable(),
        nextRecommendation: ko.observable(),
        previousRecommendation: ko.observable(),
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
                headers: { "AppKey": viewRecResp.AppKey, "UserSid": viewRecResp.UserSid() }
            });
            /* DETERMINE URL TO SET ENDPOINT BASE */
            var tempURL = window.location.href;
            /* DEV */
            if (tempURL.indexOf('localhost') > -1) {
                viewRecResp.endPointBase = "//dev.globalriskconsultants.com/capi/";
            }
            /* LIVE */
            if (tempURL.indexOf('grcconnect') > -1) {
                viewRecResp.endPointBase = "//grcconnect.globalriskconsultants.com/capi/";
            }
            /* TEST/BETA */
            if (tempURL.indexOf('test') > -1) {
                viewRecResp.endPointBase = "//grcconnecttest.globalriskconsultants.com/capi/";
            }

            var tempServiceCode = null;
            switch (viewRecResp.currentServiceCode()) {
                case "fire":
                    tempServiceCode = 1;
                    viewRecResp.isFire(true);
                    viewRecResp.isIR(false);
                    viewRecResp.practiceId(3);
                    break;
                case "boiler":
                    tempServiceCode = 2;
                    viewRecResp.isIR(false);
                    viewRecResp.practiceId(2);
                    break;
                case "processsafety":
                    tempServiceCode = 3;
                    viewRecResp.isIR(false);
                    viewRecResp.practiceId(11);
                    break;
                case "infrared":
                    tempServiceCode = 4;
                    viewRecResp.isIR(true);
                    viewRecResp.practiceId(4);
                    $('#nonIR').addClass('noShow');
                    break;
                case "naturalhazards":
                    tempServiceCode = 5;
                    viewRecResp.isIR(false);
                    viewRecResp.practiceId(9);
                    break;
                case "selfaudit":
                    tempServiceCode = 6;
                    viewRecResp.isIR(false);
                    break;
            }
            if (tempServiceCode != null) {
                viewRecResp.currentServiceCode(tempServiceCode);
            }
            viewRecResp.clientFeatures(globalClientFeatures);
            viewRecResp.setClientFeatures(globalClientFeatures);
            var tempPrefix = viewRecResp.currentFilePrefix().substr(0, viewRecResp.currentFilePrefix().indexOf('.'));
            if (tempPrefix == '495') {
                viewRecResp.isCargill(true);
            }
            viewRecResp.endPointFilePrefix(tempPrefix);
            viewRecResp.getData();
        },

        getData: function () {
            try {
                viewRecResp.loadUserData();
                viewRecResp.loadLocationsData();
                viewRecResp.loadRecommendationsData();
                viewRecResp.loadDropDownData();
                viewRecResp.setUpLangSelectionDD();
                $('#divContainerLoading').addClass('noShow');
            } catch (pErrorMessage) {
                alert("There was an error initiating the page data: " + pErrorMessage);
            }
        },

        loadUserData: function () {
            //USER DATA

            var tempEndpoint = viewRecResp.endPointBase + "users/current"
            viewRecResp.userDataEndPointUrl(tempEndpoint);
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                cache: false,
                async: false,
                url: viewRecResp.userDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecResp.currentUser(pResults.data);
                        viewRecResp.UserSid(viewRecResp.currentUser().userSid);
                        viewRecResp.isAdmin(viewRecResp.currentUser().isAdmin);
                        viewRecResp.isAutoRec(viewRecResp.currentUser().isAutoRecUser);
                        viewRecResp.langID(viewRecResp.currentUser().preferredLanguageId);
                        for (var i = 0; i < viewRecResp.currentUser()._Links.length; i++) {
                            if (viewRecResp.currentUser()._Links[i].rel == "self") {
                                viewRecResp.userLangIDEndPointUrl(viewRecResp.currentUser()._Links[i].href);
                            }
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading user data: " + pMessage);
                },
            });
        },

        updateUserLanguagePreference: function () {

            var pData = JSON.stringify({
                "_Links": viewRecResp.currentUser()._Links,
                "email": viewRecResp.currentUser().email,
                "isAdmin": viewRecResp.currentUser().isAdmin,
                "isAutoRecUser": viewRecResp.currentUser().isAutoRecUser,
                "name": viewRecResp.currentUser().name,
                "preferredLanguageId": viewRecResp.langID(),
                "typeId": viewRecResp.currentUser().typeId,
                "userSid": viewRecResp.currentUser().userSid
            });
            $.ajax({
                type: "PUT",
                dataType: "json",
                contentType: "application/javascript",
                data: pData,
                async: false,
                url: viewRecResp.userLangIDEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecResp.recGridDataSource([]);
                        location.reload();
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error setting new language preference: " + pMessage);
                },
            });
        },

        loadLocationsData: function () {
            //LOCATION DATA
            //SET INITIAL LOCATION DATA ENDPOINT; ALL OTHER LOCATION ENDPOINTS WILL BE SET BY API
            var tempEndpoint = viewRecResp.endPointBase + "clients/" + viewRecResp.endPointFilePrefix() + "/locations";
            viewRecResp.locationDataEndPointUrl(tempEndpoint);

            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                cache: true,
                async: false,
                url: viewRecResp.locationDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecResp.locationData(pResults.data);
                        viewRecResp.setLocationData();
                        viewRecResp.loadRecCounts(pResults.data);
                        viewRecResp.loadReportsData();
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading location data: " + pMessage);
                }
            });
        },

        loadReportsData: function () {
            var tempEndpoint = viewRecResp.endPointBase + "clients/" + viewRecResp.endPointFilePrefix() + "/locations/" + viewRecResp.fileNo() + "/reports";
            viewRecResp.reportsEndPointUrl(tempEndpoint);
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                cache: true,
                async: false,
                url: viewRecResp.reportsEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (pResults.data[i].practiceId == viewRecResp.practiceId()) {
                                if (pResults.data[i].engineerReport != null) {
                                    viewRecResp.er_ReportEndPointUrl(pResults.data[i].engineerReport);
                                }
                                if (pResults.data[i].diagramReport != null) {
                                    viewRecResp.diagramReportEndPointUrl(pResults.data[i].diagramReport);
                                }
                            }
                        }
                        if (viewRecResp.er_ReportEndPointUrl() == null) {
                            $('#erReportBtn').addClass('grcBlueDisabledBtn');
                            $('#erReportBtn').prop("disabled", true);
                        }

                        if (viewRecResp.diagramReportEndPointUrl() == null) {
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

        loadRecCounts: function (pData) {
            if (viewRecResp.locationCountUrl() == undefined) {
                for (var i = 0; i < pData.length; i++) {
                    if (viewRecResp.currentFilePrefix() == pData[i].fileNo) {
                        for (var j = 0; j < pData[i]._Links.length; j++) {
                            if (pData[i]._Links[j].rel == "recCounts") {
                                viewRecResp.locationCountUrl(pData[i]._Links[j].href);
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
                url: viewRecResp.locationCountUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (viewRecResp.currentServiceCode() == pResults.data[i].recTypeId) {
                                viewRecResp.numOfCompletedRec(pResults.data[i].responsesCompleted);
                                viewRecResp.numOfRecsNeedingResponse(pResults.data[i].responsesNeeded);
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
            if (viewRecResp.recommendationsDataEndPointUrl() == undefined) {
                var tempEndpoint = viewRecResp.endPointBase + "clients/" + viewRecResp.endPointFilePrefix() + "/recs?recType=" + viewRecResp.currentServiceCode() + "&fileNo=" + viewRecResp.currentFilePrefix() + "&langid=" + viewRecResp.langID() + "&autoRecs=True";
                viewRecResp.recommendationsDataEndPointUrl(tempEndpoint);
            }
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: viewRecResp.recommendationsDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        if (pResults.data.length > 0) {
                            $('#recGridHldr').removeClass('noShow');
                            viewRecResp.setGridDataSource(pResults.data);
                        } else {
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
                url: viewRecResp.recommendationsDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (pResults.data[i].rowGuid == pGUID) {
                                viewRecResp.pagerBindRecForm(pResults.data[i]);
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
             * 7=languages
             * 8=rec labels
             * 9=practices
             * */
            var endPointURL = viewRecResp.endPointBase + "meta/lists?type=1&type=2&type=3&type=7&type=8&type=11&langid=" + viewRecResp.langID();
            if (viewRecResp.showMGMT() && !viewRecResp.show3rdLvl()) {
                endPointURL = viewRecResp.endPointBase + "meta/lists?type=1&type=2&type=3&type=6&type=7&type=8&type=11&langid=" + viewRecResp.langID();
            } else if (viewRecResp.showMGMT() && viewRecResp.show3rdLvl()) {
                endPointURL = viewRecResp.endPointBase + "meta/lists?type=1&type=2&type=3&type=6&type=7&type=8&type=10&type=11&langid=" + viewRecResp.langID();
            } else if (!viewRecResp.showMGMT() && viewRecResp.show3rdLvl()) {
                endPointURL = viewRecResp.endPointBase + "meta/lists?type=1&type=2&type=3&type=7&type=8&type=10&type=11&langid=" + viewRecResp.langID();
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
                            viewRecResp.recStatusDDData(pResults.data[i].items);
                        } else if (pResults.data[i].id == 2) {
                            //"Rec Impacts"
                            viewRecResp.recImpactDDData(pResults.data[i].items);
                        } else if (pResults.data[i].id == 3) {
                            //"Rec Intended Actions"
                            viewRecResp.recFacilityIntendedActionDDData(pResults.data[i].items);
                        } else if (pResults.data[i].id == 7) {
                            //"Meta Languages"
                            viewRecResp.langSelectorDD_Data(pResults.data[i].items);
                            for (var j = 0; j < viewRecResp.langSelectorDD_Data().length; j++) {
                                if (viewRecResp.langID() == viewRecResp.langSelectorDD_Data()[j].fldId) {
                                    viewRecResp.langSelectorText(viewRecResp.langSelectorDD_Data()[j].displayText);
                                }
                            }
                        } else if (pResults.data[i].id == 8) {
                            //"Rec Labels"
                            viewRecResp.bindLblTranslations(pResults.data[i]);
                        } else if (pResults.data[i].id == 11) {
                            //UPLOAD FILE TYPES
                            viewRecResp.fileAllowedExtensionsList(pResults.data[i].items[0].allowedExtensions);
                        }
                        if (viewRecResp.showMGMT()) {
                            if (pResults.data[i].id == 6) {
                                viewRecResp.recMGMTIntendedActionDDData(pResults.data[i].items);
                            }
                        }
                        if (viewRecResp.show3rdLvl()) {
                            if (pResults.data[i].id == 10) {
                                viewRecResp.recThirdLvlIntendedActionDDData(pResults.data[i].items);
                            }
                        }
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading recommendations status dropdown data: " + pMessage);
                }
            });
        },

        setLocationData: function () {
            if (viewRecResp.locationData().length > 0) {
                viewRecResp.bindLocationCard(viewRecResp.locationData()[0]);
            }
        },

        bindLblTranslations: function (pData) {
            for (var i = 0; i < pData.items.length; i++) {
                var labelID = pData.items[i].labelId;
                switch (labelID) {
                    case 1:
                        //Location
                        break;
                    case 2:
                        //grc loc. no
                        viewRecResp.recNumLbl(pData.items[i].displayText);
                        break;
                    case 3:
                        //client loc. id.
                        viewRecResp.clientLocIdLbl(pData.items[i].displayText);
                        break;
                    case 4:
                        //address
                        viewRecResp.addressLbl(pData.items[i].displayText);
                        break;
                    case 7:
                        //country
                        viewRecResp.countryLbl(pData.items[i].displayText);
                        break;
                    case 9:
                        //custom access
                        viewRecResp.customAccessLbl(pData.items[i].displayText);
                        break;
                    case 15:
                        //responses completed
                        viewRecResp.responseCompletedLbl(pData.items[i].displayText);
                        break;
                    case 16:
                        //responses needed
                        viewRecResp.responseNeededLbl(pData.items[i].displayText);
                        break;
                    case 17:
                        //rec. no.
                        viewRecResp.recNumLbl(pData.items[i].displayText);
                        break;
                    case 18:
                        //"rec. impact"
                        viewRecResp.recImpactLbl(pData.items[i].displayText);
                        break;
                    case 19:
                        //Severity
                        viewRecResp.severityLbl(pData.items[i].displayText);
                        break;
                    case 20:
                        //history
                        viewRecResp.historyLbl(pData.items[i].displayText);
                        break;
                    case 22:
                        //plant area
                        viewRecResp.plantAreaLbl(pData.items[i].displayText);
                        break;
                    case 23:
                        //"rec. status"
                        viewRecResp.recStatusLbl(pData.items[i].displayText);
                        break;
                    case 24:
                        //fault type
                        viewRecResp.faultTypeLbl(pData.items[i].displayText);
                        break;
                    case 25:
                        //detected with
                        viewRecResp.detectedWithLbl(pData.items[i].displayText);
                        break;
                    case 26:
                        //redundancy spare
                        viewRecResp.redundancySpareLbl(pData.items[i].displayText);
                        break;
                    case 27:
                        //code
                        viewRecResp.codeLbl(pData.items[i].displayText);
                        break;
                    case 28:
                        //"status date"
                        viewRecResp.recStatusDateLbl(pData.items[i].displayText);
                        break;
                    case 29:
                        //"hazard"
                        viewRecResp.recHazardLbl(pData.items[i].displayText);
                        break;
                    case 30:
                        //"primary rec. type"
                        viewRecResp.recPrimaryTypeLbl(pData.items[i].displayText);
                        break;
                    case 31:
                        //"secondary rec. type"
                        viewRecResp.recSecondaryTypeLbl(pData.items[i].displayText);
                        break;
                    case 32:
                        //"rec keywords"
                        viewRecResp.keyWordsLbl(pData.items[i].displayText);
                        break;
                    case 33:
                        //"current loss est."
                        viewRecResp.currentLossEstLbl(pData.items[i].displayText);
                        break;
                    case 34:
                        //"completed loss est."
                        viewRecResp.completedLossEstLbl(pData.items[i].displayText);
                        break;
                    case 35:
                        //"est.cost to complete"
                        viewRecResp.estCostToCompLbl(pData.items[i].displayText);
                        break;
                    case 36:
                        //"savings ratio"
                        viewRecResp.recSavingsRatioLbl(pData.items[i].displayText);
                        break;
                    case 37:
                        //(actual)
                        viewRecResp.actualLbl(pData.items[i].displayText);
                        break;
                    case 38:
                        //(range)
                        viewRecResp.rangeLbl(pData.items[i].displayText);
                        break;
                    case 39:
                        //"exp. compl. date"
                        viewRecResp.expdCompDateLbl(pData.items[i].displayText);
                        break;
                    case 40:
                        //"rec. intended action"
                        viewRecResp.intendedActionLbl(pData.items[i].displayText);
                        break;
                    case 41:
                        //"act. cost to complete"
                        viewRecResp.actCostToCompLbl(pData.items[i].displayText);
                        break;
                    case 42:
                        //"facility comment"
                        viewRecResp.commentLbl(pData.items[i].displayText);
                        break;
                    case 43:
                        //"latitude"
                        viewRecResp.latitudeLbl(pData.items[i].displayText);
                        break;
                    case 44:
                        //"longitude"
                        viewRecResp.longitudeLbl(pData.items[i].displayText);
                        break;
                    case 45:
                        //"resp. date"
                        viewRecResp.respDateLbl(pData.items[i].displayText);
                        break;
                    case 46:
                        //"resp. from"
                        viewRecResp.respFromLbl(pData.items[i].displayText);
                        break;
                    case 49:
                        //"Edit"
                        viewRecResp.editLbl(pData.items[i].displayText);
                        viewRecResp.lblInst_Edit_Title(pData.items[i].displayText);
                        viewRecResp.lblInst_Responses_Title(pData.items[i].displayText);
                        $('#instEditTitle').text(viewRecResp.lblInst_Edit_Title());
                        $('#instResponseTitle').text(viewRecResp.lblInst_Responses_Title());
                        break;
                    case 50:
                        //save
                        viewRecResp.saveLbl(pData.items[i].displayText);
                        break;
                    case 55:
                        //"language"
                        viewRecResp.lblInst_Language_Title(pData.items[i].displayText);
                        $('#langLbl').text(viewRecResp.lblInst_Language_Title());
                        break;
                    case 56:
                        //"This page can be converted with a choice of six languages. Use the drop-down menu above  on the upper toolbar."
                        viewRecResp.lblInst_Language_Text(pData.items[i].displayText);
                        $('#langText').text(viewRecResp.lblInst_Language_Text());
                        break;
                    case 57:
                        //"Click the Edit button to enter your response."
                        viewRecResp.lblInst_Edit_Text(pData.items[i].displayText);
                        $('#instEditText').text(viewRecResp.lblInst_Edit_Text());
                        break;
                    case 59:
                        //Once you have entered each of your responses, please end your session using the Logout button on the right of the upper top right toolbar.
                        viewRecResp.lblInst_Responses_Text(pData.items[i].displayText);
                        $('#instResposeText').text(viewRecResp.lblInst_Responses_Text());
                        break;
                    case 60:
                        //EMAIL
                        viewRecResp.lblInst_Email_Title(pData.items[i].displayText);
                        $('#emailTitle').text(viewRecResp.lblInst_Email_Title());
                        break;
                    case 61:
                        //After your session ends, an auto-generated email will be sent to your email containing the Rec Response Report with your changes.
                        viewRecResp.lblInst_Responses_Text(pData.items[i].displayText);
                        $('#emailResposeText').text(viewRecResp.lblInst_Responses_Text());
                        break;
                    case 74:
                        //cancel
                        viewRecResp.cancelLbl(pData.items[i].displayText);
                        break;
                    case 100:
                        //"file no."
                        viewRecResp.fileNoLbl(pData.items[i].displayText);
                        break;
                    case 101:
                        //"division"
                        viewRecResp.divisionLbl(pData.items[i].displayText);
                        break;
                    case 102:
                        //"facility"
                        viewRecResp.facilityLbl(pData.items[i].displayText);
                        break;
                    case 128:
                        //recommendations
                        viewRecResp.recommendationsLbl(pData.items[i].displayText);
                        break;
                    case 137:
                        //Managment Lable
                        viewRecResp.mgmtLbl(pData.items[i].displayText);
                        break;
                    case 138:
                        //3rd Level Label
                        viewRecResp.thirdLvlLbl(pData.items[i].displayText);
                        break;
                    case 139:
                        viewRecResp.closeLbl(pData.items[i].displayText);
                        break;
                }
            }
        },

        bindLocationCard: function (pData) {
            viewRecResp.address(pData.address);
            viewRecResp.city(pData.city);
            viewRecResp.country(pData.country);
            viewRecResp.clientLocNo(pData.clientLocNo);
            viewRecResp.customAccess(pData.customAccess);
            viewRecResp.division(pData.division);
            viewRecResp.facility(pData.facility);
            viewRecResp.fileNo(pData.fileNo);
            viewRecResp.latitude(pData.longitude);
            viewRecResp.longitude(pData.latitude);
            viewRecResp.staticImageURL(viewRecResp.getStaticMapUrl());
            viewRecResp.state(pData.state);
            viewRecResp.zip(pData.zip);
            viewRecResp.tiv(global.formatMoneyNoSymbol(pData.tiv, 0));
            viewRecResp.addressCityStateZipCombindedText(viewRecResp.address() + " " + viewRecResp.city() + ", " + viewRecResp.state() + " " + viewRecResp.zip());
        },
        getStaticMapUrl: function () {
            // GET A STATIC IMAGERY URL FROM BING
            var zURL;
            if (!viewRecResp.latitude() ||
                !viewRecResp.longitude() ||
                !globalKeyBing) {
                zURL = "../../Home_{{VER}}/Images/icons/maps/icon_earth_white_64x64.png";
            } else {
                var zLatitude = viewRecResp.latitude();
                var zLongitude = viewRecResp.longitude();
                var zMapWidth = "320";
                var zMapHeight = "300";
                zURL = global.getStaticMap(zLongitude, zLatitude, zMapWidth, zMapHeight, globalKeyBing);
            }
            return zURL;
        },
        setClientFeatures: function (pData) {
            if (pData.indexOf('+') > -1 || pData.indexOf('Q') > -1) {
                viewRecResp.showMGMT(true);
            }
            if (pData.indexOf('!') > -1 || pData.indexOf('@') > -1) {
                viewRecResp.show3rdLvl(true);
            }
        },
        setGridDataSource: function (pData) {
            if (pData.length > 0) {
                viewRecResp.recGridDataSource(pData);
                viewRecResp.setupKendo();
            }
        },
        loadFileList: function () {
            for (let i = 0; i < viewRecResp.currentRec()._Links.length; i++) {
                if (viewRecResp.currentRec()._Links[i].rel == "files") {
                    viewRecResp.filesListEndpointUrl(viewRecResp.currentRec()._Links[i].href);
                }
            }

            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                url: viewRecResp.filesListEndpointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecResp.filesTotalCount(pResults.data.length);
                        if (viewRecResp.filesTotalCount() == 0) {
                            $('#noFilesMsg').show();
                            $('#filesGridHldr').hide();
                            viewRecResp.setUpUpload();
                        } else {
                            viewRecResp.fileListData(pResults.data);
                            $('#noFilesMsg').hide();
                            $('#filesGridHldr').show();
                            viewRecResp.setUpUpload();
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
                        xhr.setRequestHeader("UserSid", viewRecResp.UserSid());
                    }
                });
            }
        },

        setUpUpload: function () {
            if (viewRecResp.fileUploader == null) {
                $('#fileUpload').kendoUpload({
                    async: {
                        saveUrl: viewRecResp.filesUploadEndpointUrl(),
                        autoUpload: false,
                        withCredentials: false,
                        showFileList: false
                    },
                    validation: {
                        allowedExtensions: viewRecResp.fileAllowedExtensionsList()
                    },
                    upload: viewRecResp.onUpload,
                    select: function (e) {
                        viewRecResp.fileOnSelect(e);
                    },
                    success: function () {
                        $(".k-upload-files.k-reset").find("li").parent().remove();
                        viewRecResp.loadFileList();
                    }
                });
            }

            viewRecResp.fileUploader = $('#fileUpload').data("kendoUpload");
        },

        fileOnSelect: function (e) {
            var files = e.files;
            var ext = [];
            for (var i = 0; i < files.length; i++) {
                for (var j = 0; j < viewRecResp.fileAllowedExtensionsList().length; j++) {
                    ext.push("." + viewRecResp.fileAllowedExtensionsList()[j]);
                }

                if (ext.indexOf(files[i].extension) == -1) {
                    alert(files[i].name + " is of a file type that is not allowed.");
                    e.preventDefault();
                }
            }
        },

        onFileDownload: function (pData) {
            viewRecResp.filesDownloadEndpointUrl(pData._Links[0].href);

            $.ajax({
                type: "GET",
                cache: true,
                url: viewRecResp.filesDownloadEndpointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        var arr = pResults.data.content;
                        var byteArray = viewRecResp.base64ToArrayBuffer(arr);
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
            viewRecResp.filesDeleteEndpointUrl(pData._Links[0].href);
            if (confirm("Are you sure you want to delete this file?")) {
                $.ajax({
                    type: "DELETE",
                    dataType: "json",
                    contentType: "application/javascript",
                    async: false,
                    url: viewRecResp.filesDeleteEndpointUrl(),
                    success: function (pResults) {
                        if (pResults.isSuccess) {
                            viewRecResp.loadFileList();
                        }
                    },
                    error: function (pResults, pMessage, pErrorDetail) {
                        alert("Error deleteing files: " + pMessage);
                    }
                });
            }
        },
        setupKendo: function () {
            if (!viewRecResp.isIR()) {
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
            if (!viewRecResp.isIR()) {
                if (viewRecResp.showMGMT() && viewRecResp.show3rdLvl()) {
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
                } else if (viewRecResp.showMGMT()) {
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
                } else if (viewRecResp.show3rdLvl()) {
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
                if (viewRecResp.showMGMT() && viewRecResp.show3rdLvl()) {
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
                } else if (viewRecResp.showMGMT()) {
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
                } else if (viewRecResp.show3rdLvl()) {
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


            if (viewRecResp.isCargill()) {
                if (viewRecResp.showMGMT() && viewRecResp.show3rdLvl()) {
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
                } else if (viewRecResp.showMGMT()) {
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
                } else if (viewRecResp.show3rdLvl()) {
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
                        { field: "detectedWith", title: "Detected With", width: "80px", },
                        { field: "redundancySpare", title: "Redundancy Spare", width: "100px" },
                        { field: "intendedAction", title: "Intended Action", width: "150px", },
                        { field: "respDate", title: "Response Date", width: "100px", template: "#= respDate != null ? dayjs(respDate).format('DD-MMM-YY') : '' #", attributes: { 'style': "background: #= responseDateBackColor #" } },
                        { field: "respFrom", title: "Response From", width: "100px" },
                        { field: "facilityComment", title: "Facility Comment", width: "150px" }
                    ]
                }
            }

            $('#recGrid').kendoGrid({
                dataSource: viewRecResp.recGridDataSource(),
                columns: gridColumnMap
            });

            /* DATE PICKERS */
            var facilityExpCompDatePicker = $('#recFacilityExpectedCompDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecResp.recFacilityExpectedCompDate(),
            });

            $('#recMGMTExpectedCompDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecResp.recMGMTExpectedCompDate(),
            });

            $('#recThridLvlExpectedCompDatePicker').kendoDatePicker({
                format: "dd-MMM-yy",
                value: viewRecResp.recThirdLvlExpectedCompDate(),
            });
        },

        setUpLangSelectionDD: function () {
            if (!viewRecResp.langSelectorDDList) {
                $('#langSelector').kendoDropDownList({
                    dataSource: viewRecResp.langSelectorDD_Data(),
                    dataTextField: "displayText",
                    dataValueField: "fldId",
                    value: viewRecResp.langID(),
                    select: function (e) {
                        viewMaster.onCloseLanguageSelector(e);
                    },
                });
                viewRecResp.langSelectorDDList = $('#langSelector').data('kendoDropdownList');
            }
        },

        firstRec: function () {
            viewRecResp.pagerBindRecForm(viewRecResp.firstRecommendation());
        },
        lastRec: function () {
            viewRecResp.pagerBindRecForm(viewRecResp.lastRecommendation());
        },
        nextRec: function () {
            viewRecResp.pagerBindRecForm(viewRecResp.nextRecommendation());
        },
        previousRec: function () {
            viewRecResp.pagerBindRecForm(viewRecResp.previousRecommendation());
        },

        displayRecForm: function (pFileNo, pID) {
            viewRecResp.bindRecForm(pFileNo, pID);
            $('#recGridHldr').fadeOut("slow");
            $('#recSection').fadeIn("slow");
            var tempRowHeight = $('#recFacilityComment').height();
            $('.facilityRow').each(function () {
                $(this).height(tempRowHeight);
            });
            if (viewRecResp.showMGMT()) {
                var tempMGMTRowHeight = $('#mgmtCommentLbl').height();
                $('.mgmtRow').each(function () {
                    $(this).height(tempMGMTRowHeight);
                });
            }
            if (viewRecResp.show3rdLvl()) {
                var temp3rdHeight = $('#thirdLvlCommentLbl').height();
                $('.thirLvlRow').each(function () {
                    $(this).height(temp3rdHeight);
                });
            }
        },

        //THIS FUNCTION IS USED TO BIND THE RECOMMENDATIONS FORM BASED ON GRID 'ENTER' BUTTON CLICK
        bindRecForm: function (pFileNo, pID) {
            $('#confirmBtn').addClass('noShow');
            for (var i = 0; i < viewRecResp.recGridDataSource().length; i++) {
                //ONLY RUN THIS BLOCK IF THERE ARE MORE THAN ONE RECOMMENDATIONS
                if (viewRecResp.recGridDataSource().length > 1) {
                    $('#recPagerBtnHldr').removeClass('noShow');
                    //SET ENDPOINT URL FOR 'FIRST' RECOMMENDATIONS BUTTON
                    if (i == 0) {
                        viewRecResp.firstRecommendation(viewRecResp.recGridDataSource()[i]);
                    }
                    //SET ENDPOINT URL FOR 'LAST' RECOMMENDATIONS BUTTON
                    arrayLength = viewRecResp.recGridDataSource().length;
                    viewRecResp.lastRecommendation(viewRecResp.recGridDataSource()[arrayLength - 1]);
                } else {
                    $('#recPagerBtnHldr').addClass('noShow');
                }
                //BIND REC FORM DATA BASED ON CLICK EVENT FROM THE GRID;
                //PASS ID, LOOP RECOMMENDATIONS DATA TO FIND THAT ROW;
                //BIND THE FORM AND DISPLAY
                if (pID == viewRecResp.recGridDataSource()[i].rowGuid) {
                    //STORE CURRENT REC GUID
                    viewRecResp.recGUID(viewRecResp.recGridDataSource()[i].rowGuid);
                    //SET 'NEXT' PAGER BUTTON ENDPOINT URL
                    if (viewRecResp.recGridDataSource().length > 1) {
                        viewRecResp.nextRecommendation(viewRecResp.recGridDataSource()[i + 1]);
                    }

                    //SET 'PREVIOUS' PAGER BUTTON ENDPOINT URL
                    if (i - 1 >= 0) {
                        viewRecResp.previousRecommendation(viewRecResp.recGridDataSource()[i - 1]);
                    }
                    //SET UP PAGER COUNT INFORMATION
                    viewRecResp.currentRecommendationIndex(i + 1);
                    viewRecResp.totalRecommendationsCount(viewRecResp.recGridDataSource().length);
                    viewRecResp.recommendationCountBoxText(viewRecResp.currentRecommendationIndex() + " of " + viewRecResp.totalRecommendationsCount());
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
                    if (i + 1 == viewRecResp.recGridDataSource().length) {
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
                    viewRecResp.currentRec(viewRecResp.recGridDataSource()[i]);

                    //LOAD LIST OF FILES ASSOCIATED WITH REC
                    viewRecResp.loadFileList();
                    //SET FILE UPLOAD URL
                    for (let j = 0; j < viewRecResp.currentRec()._Links.length; j++) {
                        if (viewRecResp.currentRec()._Links[j].rel == "files") {
                            viewRecResp.filesUploadEndpointUrl(viewRecResp.currentRec()._Links[j].href);
                        }
                    }

                    //ADJUST REC NUM TO BE Rec Year, Rec Month, Rec Number, Rec Subletter
                    //CHECK FOR NULL DATA AND REMOVE THE SPACE OR FORMAT NUMBER
                    var tempRecNo = "";
                    var tempYr = "";
                    var tempMo = "";
                    var tempNum = "";
                    var tempCode = "";
                    if (viewRecResp.recGridDataSource()[i].recNumber == null) {
                        tempNum = "";
                    } else {
                        tempNum = "-" + viewRecResp.recGridDataSource()[i].recNumber;
                    }
                    if (viewRecResp.recGridDataSource()[i].recYear == null) {
                        tempYr = "";
                    } else {
                        tempYr = viewRecResp.recGridDataSource()[i].recYear;
                    }
                    if (viewRecResp.recGridDataSource()[i].recMonth == null || viewRecResp.recGridDataSource()[i].recMonth == "") {
                        tempMo = "";
                    } else {
                        tempMo = "-" + viewRecResp.recGridDataSource()[i].recMonth;
                    }

                    if (viewRecResp.recGridDataSource()[i].recSubLetter == null || viewRecResp.recGridDataSource()[i].recSubLetter == "") {
                        tempCode = "";
                    } else {
                        tempCode = "-" + viewRecResp.recGridDataSource()[i].recSubLetter;
                    }

                    tempRecNo = tempYr + tempMo + tempNum + tempCode;

                    viewRecResp.recNumber(tempRecNo);
                    if (viewRecResp.currentServiceCode() == 51) {
                        viewRecResp.recHazard("N/A");
                    } else {
                        viewRecResp.recHazard(viewRecResp.recGridDataSource()[i].hazard);
                    }
                    viewRecResp.recCode(viewRecResp.recGridDataSource()[i].recCode);
                    viewRecResp.recImpact(viewRecResp.recGridDataSource()[i].impact);
                    viewRecResp.recPrimaryType(viewRecResp.recGridDataSource()[i].primaryRecType);
                    viewRecResp.recSecondaryType(viewRecResp.recGridDataSource()[i].secondaryRecType);
                    viewRecResp.recKeywords(viewRecResp.recGridDataSource()[i].recKeyWords);
                    viewRecResp.recCurrentLossEstActual(global.formatMoneyNoSymbol(viewRecResp.recGridDataSource()[i].currentLossEstimate, 0));
                    viewRecResp.recCurrentLossEstRange(viewRecResp.recGridDataSource()[i].currentLossEstimateRange);
                    viewRecResp.recCompletedLossEstActual(global.formatMoneyNoSymbol(viewRecResp.recGridDataSource()[i].completedLossEstimate, 0));
                    viewRecResp.recCompletedLossEstRange(viewRecResp.recGridDataSource()[i].completedLossEstimateRange);
                    viewRecResp.recEstCostToCompActual(global.formatMoneyNoSymbol(viewRecResp.recGridDataSource()[i].costToCompleteEstimate, 0));
                    viewRecResp.recEstCostToCompRange(viewRecResp.recGridDataSource()[i].costToCompleteEstimateRange);
                    viewRecResp.recSavingsRatio(global.formatMoneyNoSymbol(viewRecResp.recGridDataSource()[i].savingsRatio, 0));
                    //CHECK REC STATUS TO SEE IF WE NEED TO DISPLAY SELF AUDIT FLAG ICON
                    viewRecResp.isSelfAudit(viewRecResp.recGridDataSource()[i].isSelfAuditRec);
                    if (viewRecResp.isSelfAudit()) {
                        $('#selfAuditFlag').removeClass('noShow');
                    }
                    viewRecResp.cancelStatus = viewRecResp.recGridDataSource()[i].status;
                    viewRecResp.cancelStatusID = viewRecResp.recGridDataSource()[i].statusId;
                    viewRecResp.recStatus(viewRecResp.recGridDataSource()[i].status);
                    viewRecResp.statusID(viewRecResp.recGridDataSource()[i].statusId);

                    if (viewRecResp.isIR()) {
                        viewRecResp.recHistory(viewRecResp.recGridDataSource()[i].history);
                        viewRecResp.recSeverity(viewRecResp.recGridDataSource()[i].severityRating);
                        viewRecResp.recDetectedWith(viewRecResp.recGridDataSource()[i].detectedWith);
                        viewRecResp.recEquipmentNo(viewRecResp.recGridDataSource()[i].equipmentNo);
                        viewRecResp.recFindingNo(viewRecResp.recGridDataSource()[i].findingNo);
                        viewRecResp.recPlantArea(viewRecResp.recGridDataSource()[i].plantAreaAffected);
                        viewRecResp.recProbableEquipmentDamageCost(viewRecResp.recGridDataSource()[i].probableEquipmentDamageCost);
                        viewRecResp.recFaultType(viewRecResp.recGridDataSource()[i].faultType);
                        viewRecResp.recLengthBusInteruption(viewRecResp.recGridDataSource()[i].lengthOfBusInterruption);
                        viewRecResp.recRedundancySpare(viewRecResp.recGridDataSource()[i].redundancySpare);
                    }

                    if (viewRecResp.recGridDataSource()[i].statusDate != null) {
                        viewRecResp.recStatusDate(dayjs(viewRecResp.recGridDataSource()[i].statusDate).format('DD-MMM-YY'));
                    }
                    if (viewRecResp.recGridDataSource()[i].respDate != null) {
                        viewRecResp.recFacilityRespDate(dayjs(viewRecResp.recGridDataSource()[i].respDate).format('DD-MMM-YY'));
                    } else {
                        viewRecResp.recFacilityRespDate(null);
                    }
                    if (viewRecResp.recGridDataSource()[i].responseDateBackColor != null) {
                        viewRecResp.recFacilityRespDateBackColor(viewRecResp.recGridDataSource()[i].responseDateBackColor);
                    } else {
                        viewRecResp.recFacilityRespDateBackColor(null);
                    }
                    viewRecResp.recFacilityRespFrom(viewRecResp.recGridDataSource()[i].respFrom);
                    viewRecResp.cancelFacilityIntendedAction = viewRecResp.recGridDataSource()[i].intendedAction;
                    viewRecResp.cancelFacilityIntendedActionID = viewRecResp.recGridDataSource()[i].intendedActionId;
                    viewRecResp.recFacilityIntendedAction(viewRecResp.recGridDataSource()[i].intendedAction);
                    viewRecResp.recIntendedActionID(viewRecResp.recGridDataSource()[i].intendedActionId);
                    if (!viewRecResp.recIntendedActionDropdownList) {
                        $('#recFacilityIntendedActionDD').kendoDropDownList({
                            dataSource: viewRecResp.recFacilityIntendedActionDDData(),
                            dataTextField: "displayText",
                            dataValueField: "id",
                            value: viewRecResp.recIntendedActionID(),
                            //change: function (e) {
                            //    viewRecResp.intendedActionSelect(e);
                            //}
                        });
                    }
                    viewRecResp.recIntendedActionDropdownList = $('#recFacilityIntendedActionDD').data("kendoDropdownList");
                    viewRecResp.recFacilityComment(viewRecResp.recGridDataSource()[i].facilityComment);
                    if (viewRecResp.recGridDataSource()[i].expectedCompletionDate != null) {
                        viewRecResp.recFacilityExpectedCompDate(dayjs(viewRecResp.recGridDataSource()[i].expectedCompletionDate).format('DD-MMM-YY'));
                    }
                    viewRecResp.recFacilityExpectedCompletionBackColor(viewRecResp.recGridDataSource()[i].expectedCompletionDateBackColorHex)
                    viewRecResp.recFacilityActualCostToComp(global.formatMoneyNoSymbol(viewRecResp.recGridDataSource()[i].costToComplete, 0));
                    if (viewRecResp.showMGMT()) {
                        if (viewRecResp.recGridDataSource()[i].mgmtRespDate != null) {
                            viewRecResp.recMGMTRespDate(dayjs(viewRecResp.recGridDataSource()[i].mgmtRespDate).format('DD-MMM-YY'));
                        }
                        viewRecResp.recMGMTRespFrom(viewRecResp.recGridDataSource()[i].mgmtRespFrom);
                        viewRecResp.cancelMGMTIntendedAction = viewRecResp.recGridDataSource()[i].mgmtRespAction;
                        viewRecResp.cancelMGMTIntendedActionID = viewRecResp.recGridDataSource()[i].mgmtRespActionId;
                        viewRecResp.recMGMTIntendedAction(viewRecResp.recGridDataSource()[i].mgmtRespAction);
                        viewRecResp.recMGMTRespActionId(viewRecResp.recGridDataSource()[i].mgmtRespActionId);
                        if (!viewRecResp.recMGMTIntendedActionDropdownList) {
                            $('#recMGMTIntendedActionDD').kendoDropDownList({
                                dataSource: viewRecResp.recMGMTIntendedActionDDData(),
                                dataTextField: "displayText",
                                dataValueField: "id",
                                value: viewRecResp.recMGMTRespActionId(),
                                change: function (e) {
                                    viewRecResp.mgmtActionSelect(e);
                                }
                            });
                        }
                        viewRecResp.recMGMTIntendedActionDropdownList = $('#recMGMTIntendedActionDD').data("kendoDropdownList");
                        viewRecResp.recMGMTComment(viewRecResp.recGridDataSource()[i].mgmtRespComment);
                    }
                    if (viewRecResp.show3rdLvl()) {
                        if (viewRecResp.recGridDataSource()[i].thirdLevelRespDate != null) {
                            viewRecResp.recThirdLvlRespDate(dayjs(viewRecResp.recGridDataSource()[i].thirdLevelRespDate).format('DD-MMM-YY'));
                        }
                        viewRecResp.recThirdLvlRespFrom(viewRecResp.recGridDataSource()[i].thirdLevelRespFrom);
                        viewRecResp.cancel3rdLvlIntendedAction = viewRecResp.recGridDataSource()[i].thirdLevelRespAction;
                        viewRecResp.cancel3rdLvlIntendedActionID = viewRecResp.recGridDataSource()[i].thirdLevelRespActionId;
                        viewRecResp.recThirdLvlIntendedAction(viewRecResp.recGridDataSource()[i].thirdLevelRespAction);
                        viewRecResp.recThirdLvlIntendedActionId(viewRecResp.recGridDataSource()[i].thirdLevelRespActionId);
                        if (!viewRecResp.recThirdLvlIntendedActionDropdownList) {
                            $('#recThirdLvlIntendedActionDD').kendoDropDownList({
                                dataSource: viewRecResp.recThirdLvlIntendedActionDDData(),
                                dataTextField: "displayText",
                                dataValueField: "id",
                                value: viewRecResp.recThirdLvlIntendedActionId(),
                                change: function (e) {
                                    viewRecResp.thirdLvlActionSelect(e);
                                }
                            });
                        }
                        viewRecResp.recThirdLvlIntendedActionDropdownList = $('#recThirdLvlIntendedActionDD').data("kendoDropdownList");

                        viewRecResp.recThirdLvlComment(viewRecResp.recGridDataSource()[i].thirdLevelRespComment);
                    }

                    //CHECK IF EXPECTED COMPLETION DATE NEEDS TO BE REQUIRED
                    if (viewRecResp.clientFeatures().indexOf("R") > -1) {
                        $('#recFacilityExpectedCompDatePicker').removeClass('required');
                        if ($('#recFacilityIntendedActionDD').val().toLowerCase() != "5" &&
                            $('#recFacilityIntendedActionDD').val().toLowerCase() != "7" &&
                            $('#recFacilityIntendedActionDD').val().toLowerCase() != "9") {
                            $('#recFacilityExpectedCompDatePicker').addClass('required');
                        }
                    }

                    var today = new Date();
                    //CHECK IF WE SHOULD DISPLAY 'CONFIRM' BUTTON
                    if (viewRecResp.recFacilityRespDate() != null) {
                        //resp date before status date
                        if (dayjs(global.convertGRCStringToDate(viewRecResp.recFacilityRespDate())).isBefore(dayjs(global.convertGRCStringToDate(viewRecResp.recStatusDate())))) {
                            //expected completion date is empty, or expected completion date is today, or expected completion date is after today
                            if (viewRecResp.recFacilityExpectedCompDate() == null || new Date(global.convertGRCStringToDate(viewRecResp.recFacilityExpectedCompDate())).toDateString() === today.toDateString() || dayjs(global.convertGRCStringToDate(viewRecResp.recFacilityExpectedCompDate())).isAfter(today)) {
                                //intended action is not completed
                                if (viewRecResp.recFacilityIntendedAction().toLowerCase() != "completed") {
                                    $('#confirmBtn').removeClass('noShow');
                                }
                            }
                        }
                    }

                    break;
                }
            }
        },

        //THIS FUNCTION IS USED TO BIND RECOMMENDATIONS FORM AFTER ANY PAGER BUTTON CLICK
        pagerBindRecForm: function (pData) {
            $('#confirmBtn').addClass('noShow');
            viewRecResp.clearDropDownValues();
            //BIND REC FORM DATA BASED ON PAGER CLICK;
            viewRecResp.currentRec(pData);
            //LOAD LIST OF FILES ASSOCIATED WITH REC
            viewRecResp.loadFileList();
            //SET FILE UPLOAD URL
            for (let i = 0; i < viewRecResp.currentRec()._Links.length; i++) {
                if (viewRecResp.currentRec()._Links[i].rel == "files") {
                    viewRecResp.filesUploadEndpointUrl(viewRecResp.currentRec()._Links[i].href);
                }
            }
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
            viewRecResp.recNumber(tempRecNo);
            if (viewRecResp.currentServiceCode() == 51) {
                viewRecResp.recHazard("N/A");
            } else {
                viewRecResp.recHazard(pData.hazard);
            }
            viewRecResp.recCode(pData.recCode);
            viewRecResp.recImpact(pData.impact);
            viewRecResp.recPrimaryType(pData.primaryRecType);
            viewRecResp.recSecondaryType(pData.secondaryRecType);
            viewRecResp.recKeywords(pData.recKeyWords);
            viewRecResp.recCurrentLossEstActual(global.formatMoneyNoSymbol(pData.currentLossEstimate, 0));
            viewRecResp.recCurrentLossEstRange(pData.currentLossEstimateRange);
            viewRecResp.recCompletedLossEstActual(global.formatMoneyNoSymbol(pData.completedLossEstimate, 0));
            viewRecResp.recCompletedLossEstRange(pData.completedLossEstimateRange);
            viewRecResp.recEstCostToCompActual(global.formatMoneyNoSymbol(pData.costToCompleteEstimate, 0));
            viewRecResp.recEstCostToCompRange(pData.costToCompleteEstimateRange);
            viewRecResp.recSavingsRatio(global.formatMoneyNoSymbol(pData.savingsRatio, 0));
            //CHECK REC STATUS TO SEE IF WE NEED TO DISPLAY SELF AUDIT FLAG ICON
            viewRecResp.isSelfAudit(pData.isSelfAuditRec);
            if (viewRecResp.isSelfAudit()) {
                $('#selfAuditFlag').removeClass('noShow');
            }

            if (viewRecResp.isCancelClicked) {
                viewRecResp.recStatus(viewRecResp.cancelStatus);
                viewRecResp.statusID(viewRecResp.cancelStatusID);
                viewRecResp.recFacilityIntendedAction(viewRecResp.cancelFacilityIntendedAction);
                viewRecResp.recIntendedActionID(viewRecResp.cancelFacilityIntendedActionID);
                if (viewRecResp.showMGMT()) {
                    viewRecResp.recMGMTIntendedAction(viewRecResp.cancelMGMTIntendedAction);
                    viewRecResp.recMGMTRespActionId(viewRecResp.cancelMGMTIntendedActionID);
                }
                if (viewRecResp.show3rdLvl()) {
                    viewRecResp.recThirdLvlIntendedAction(viewRecResp.cancel3rdLvlIntendedAction);
                    viewRecResp.recThirdLvlIntendedActionId(viewRecResp.cancel3rdLvlIntendedActionID);
                }
            } else {
                viewRecResp.recStatus(pData.status);
                viewRecResp.cancelStatus = pData.status;
                viewRecResp.statusID(pData.statusId);
                viewRecResp.cancelStatusID = pData.statusId;
                viewRecResp.recFacilityIntendedAction(pData.intendedAction);
                viewRecResp.cancelFacilityIntendedAction = pData.intendedAction;
                viewRecResp.recIntendedActionID(pData.intendedActionId);
                viewRecResp.recFacilityIntendedAction(pData.intendedAction);
                viewRecResp.cancelFacilityIntendedActionID = pData.intendedActionId;
                if (viewRecResp.showMGMT()) {
                    viewRecResp.recMGMTIntendedAction(pData.mgmtRespAction);
                    viewRecResp.cancelMGMTIntendedActio = pData.mgmtRespAction;
                    viewRecResp.recMGMTRespActionId(pData.mgmtRespActionId);
                    viewRecResp.cancelMGMTIntendedActionID = pData.mgmtRespActionId;
                }
                if (viewRecResp.show3rdLvl()) {
                    viewRecResp.recThirdLvlIntendedAction(pData.thirdLevelRespAction);
                    viewRecResp.cancel3rdLvlIntendedAction = pData.thirdLevelRespAction;
                    viewRecResp.recThirdLvlIntendedActionId(pData.thirdLevelRespActionId);
                    viewRecResp.cancel3rdLvlIntendedActionID = pData.thirdLevelRespActionId;
                }
            }


            //REBIND STATUS DROPDOWN SO THAT VALUES WILL BE CORRECT AFTER PAGING
            if (!viewRecResp.recStatusDropdownList) {
                $('#recStatusDD').kendoDropDownList({
                    dataTextField: "displayText",
                    dataValueField: "id",
                    dataSource: viewRecResp.recStatusDDData(),
                    value: viewRecResp.statusID(),
                });
            }

            if (viewRecResp.isIR()) {
                viewRecResp.recHistory(pData.history);
                viewRecResp.recSeverity(pData.severityRating);
                viewRecResp.recDetectedWith(pData.detectedWith);
                viewRecResp.recEquipmentNo(pData.equipmentNo);
                viewRecResp.recFindingNo(pData.findingNo);
                viewRecResp.recPlantArea(pData.plantAreaAffected);
                viewRecResp.recProbableEquipmentDamageCost(pData.probableEquipmentDamageCost);
                viewRecResp.recFaultType(pData.faultType);
                viewRecResp.recLengthBusInteruption(pData.lengthOfBusInterruption);
                viewRecResp.recRedundancySpare(pData.redundancySpare);
            }

            if (pData.statusDate != null) {
                viewRecResp.recStatusDate(dayjs(pData.statusDate).format('DD-MMM-YY'));
            } else {
                viewRecResp.recStatusDate(null);
            }
            if (pData.respDate != null) {
                viewRecResp.recFacilityRespDate(dayjs(pData.respDate).format('DD-MMM-YY'));
            } else {
                viewRecResp.recFacilityRespDate(null);
            }
            if (pData.responseDateBackColor != null) {
                viewRecResp.recFacilityRespDateBackColor(pData.responseDateBackColor);
            } else {
                viewRecResp.recFacilityRespDateBackColor(null);
            }
            viewRecResp.recFacilityRespFrom(pData.respFrom);


            //REBIND FACILITY INTENDED ACTION DROPDOWN SO THAT VALUES WILL BE CORRECT AFTER PAGING
            let recActionDD = $('#recFacilityIntendedActionDD').data("kendoDropDownList");
            recActionDD.value(viewRecResp.recIntendedActionID());


            viewRecResp.recFacilityComment(pData.facilityComment);
            if (pData.expectedCompletionDate != null) {
                viewRecResp.recFacilityExpectedCompDate(dayjs(pData.expectedCompletionDate).format('DD-MMM-YY'));
            } else {
                viewRecResp.recFacilityExpectedCompDate("");
            }
            viewRecResp.recFacilityExpectedCompletionBackColor(pData.expectedCompletionDateBackColorHex);
            viewRecResp.recFacilityActualCostToComp(global.formatMoneyNoSymbol(pData.costToComplete, 0));
            if (viewRecResp.showMGMT()) {
                if (pData.mgmtRespDate != null) {
                    viewRecResp.recMGMTRespDate(dayjs(pData.mgmtRespDate).format('DD-MMM-YY'));
                } else {
                    viewRecResp.recMGMTRespDate("");
                }
                viewRecResp.recMGMTRespFrom(pData.mgmtRespFrom);

                //REBIND MGMT INTENDED ACTION DROPDOWN SO THAT VALUES WILL BE CORRECT AFTER PAGING
                //let mgmtActionDD = $('#recMGMTIntendedActionDD').data("kendoDropDownList");
                //mgmtActionDD.value(viewRecResp.recMGMTRespActionId());
                viewRecResp.recMGMTComment(pData.mgmtRespComment);
            }
            if (viewRecResp.show3rdLvl()) {
                if (pData.thirdLevelRespDate != null) {
                    viewRecResp.recThirdLvlRespDate(dayjs(pData.thirdLevelRespDate).format('DD-MMM-YY'));
                } else {
                    viewRecResp.recThirdLvlRespDate("");
                }
                viewRecResp.recThirdLvlRespFrom(pData.thirdLevelRespFrom);


                //REBIND 3RD LVL INTENDED ACTION DROPDOWN SO THAT VALUES WILL BE CORRECT AFTER PAGING
                //let thirdLvlActionDD = $('#recThirdLvlIntendedActionDD').data("kendoDropDownList");
                //thirdLvlActionDD.value(viewRecResp.recThirdLvlIntendedActionId());
                viewRecResp.recThirdLvlComment(pData.thirdLevelRespComment);
            }

            for (var j = 0; j < viewRecResp.recGridDataSource().length; j++) {
                if (viewRecResp.currentRec().rowGuid == viewRecResp.recGridDataSource()[j].rowGuid) {
                    viewRecResp.recGUID(viewRecResp.currentRec().rowGuid);
                    //SET UP PAGER COUNT INFORMATION
                    viewRecResp.currentRecommendationIndex(j + 1);
                    viewRecResp.totalRecommendationsCount(viewRecResp.recGridDataSource().length);
                    viewRecResp.recommendationCountBoxText(viewRecResp.currentRecommendationIndex() + " of " + viewRecResp.totalRecommendationsCount());
                    //DETERMIN WHICH PAGER BUTTONS ARE ACTIVE
                    if (viewRecResp.currentRecommendationIndex() == viewRecResp.recGridDataSource().length) {
                        $('#nextRecBtn').addClass('grcBlueDisabledBtn');
                        $('#nextRecBtn').prop('disabled', true);
                        $('#lastRecBtn').addClass('grcBlueDisabledBtn');
                        $('#lastRecBtn').prop('disabled', true);

                        $('#firstRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#firstRecBtn').prop('disabled', false);
                        $('#prevRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#prevRecBtn').prop('disabled', false);
                    }
                    if (viewRecResp.currentRecommendationIndex() - 1 == 0) {
                        $('#firstRecBtn').addClass('grcBlueDisabledBtn');
                        $('#firstRecBtn').prop('disabled', true);
                        $('#prevRecBtn').addClass('grcBlueDisabledBtn');
                        $('#prevRecBtn').prop('disabled', true);

                        $('#nextRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#nextRecBtn').prop('disabled', false);
                        $('#lastRecBtn').removeClass('grcBlueDisabledBtn');
                        $('#lastRecBtn').prop('disabled', false);
                    }
                    if (viewRecResp.currentRecommendationIndex() - 1 > 0 && viewRecResp.currentRecommendationIndex() < viewRecResp.recGridDataSource().length) {

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
                        viewRecResp.previousRecommendation(viewRecResp.recGridDataSource()[j - 1]);
                    }
                    if (j + 1 < viewRecResp.recGridDataSource().length) {
                        viewRecResp.nextRecommendation(viewRecResp.recGridDataSource()[j + 1]);
                    }
                }
                viewRecResp.isCancelClicked = false;
            }
            //CHECK IF EXPECTED COMPLETION DATE NEEDS TO BE REQUIRED

            if (viewRecResp.clientFeatures().indexOf("R") > -1) {
                $('#recFacilityExpectedCompDatePicker').removeClass('required');
                if ($('#recFacilityIntendedActionDD').val().toLowerCase() != "5" &&
                    $('#recFacilityIntendedActionDD').val().toLowerCase() != "7" &&
                    $('#recFacilityIntendedActionDD').val().toLowerCase() != "9") {
                    $('#recFacilityExpectedCompDatePicker').addClass('required');
                }
            }

            var today = new Date();
            //CHECK IF WE SHOULD DISPLAY 'CONFIRM' BUTTON
            if (viewRecResp.recFacilityRespDate() != null) {
                //resp date before status date
                if (dayjs(global.convertGRCStringToDate(viewRecResp.recFacilityRespDate())).isBefore(dayjs(global.convertGRCStringToDate(viewRecResp.recStatusDate())))) {
                    //expected completion date is empty, or expected completion date is today, or expected completion date is after today
                    if (viewRecResp.recFacilityExpectedCompDate() == null || new Date(global.convertGRCStringToDate(viewRecResp.recFacilityExpectedCompDate())).toDateString() === today.toDateString() || dayjs(global.convertGRCStringToDate(viewRecResp.recFacilityExpectedCompDate())).isAfter(today)) {
                        //intended action is not completed
                        if (viewRecResp.recFacilityIntendedAction().toLowerCase() != "completed") {
                            $('#confirmBtn').removeClass('noShow');
                        }
                    }
                }
            }
        },

        clearDropDownValues: function () {
            viewRecResp.recStatus("");
            viewRecResp.recFacilityIntendedAction("");
            viewRecResp.recIntendedActionID("");
            viewRecResp.recMGMTIntendedAction("");
            viewRecResp.recMGMTRespActionId("");
            viewRecResp.recThirdLvlIntendedAction("");
        },

        hideRecForm: function () {
            $('#recSection').fadeOut("slow");
            $('#recGridHldr').fadeIn("slow");
        },

        onEditBtnClick: function (pAction) {
            viewRecResp.changeButtons(pAction);
            switch (pAction) {
                case 'edit':
                    viewRecResp.changeFormLook('edit');
                    break;
                case 'cancel':
                    viewRecResp.changeFormLook('display');
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
            var endPointURL = viewRecResp.endPointBase + "recs/" + viewRecResp.recGUID();
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

        onConfirmBtnClick: function () {
            viewRecResp.currentRec().respDate = dayjs();
            viewRecResp.currentRec().respFrom = viewRecResp.currentUser().name;
            var dSave = ko.toJSON(viewRecResp.currentRec());
            //SHOW LOADER HERE
            $('#tabLocDetailsLoading').removeClass('noShow');
            viewRecResp.saveRecForm(dSave);
        },

        onSaveBtnClick: function () {
            viewRecResp.currentRec().respDate = dayjs();
            viewRecResp.currentRec().respFrom = viewRecResp.currentUser().name;

            if (viewRecResp.clientFeatures().indexOf("R") > -1) {
                if ($('#recFacilityExpectedCompDatePicker').val() == null || $('#recFacilityExpectedCompDatePicker').val() == "") {
                    if ($('#recFacilityIntendedActionDD').val() != null || $('#recFacilityIntendedActionDD').val() != undefined) {
                        if ($('#recFacilityIntendedActionDD').val().toLowerCase() != "6" &&
                            $('#recFacilityIntendedActionDD').val().toLowerCase() != "8" &&
                            $('#recFacilityIntendedActionDD').val().toLowerCase() != "10") {
                            $('#recFacilityExpectedCompDatePicker').addClass('required');
                            alert("Expected Completion Date is required.");
                        } else {
                            //SHOW LOADER HERE
                            $('#tabLocDetailsLoading').removeClass('noShow');
                            viewRecResp.populateSaveObject();
                            var dSave = ko.toJSON(viewRecResp.currentRec());
                            viewRecResp.saveRecForm(dSave);
                        }
                    }
                } else {
                    //SHOW LOADER HERE
                    $('#tabLocDetailsLoading').removeClass('noShow');
                    viewRecResp.populateSaveObject();
                    var dSave = ko.toJSON(viewRecResp.currentRec());
                    viewRecResp.saveRecForm(dSave);
                }
            } else {
                //SHOW LOADER HERE
                $('#tabLocDetailsLoading').removeClass('noShow');
                viewRecResp.populateSaveObject();
                var dSave = ko.toJSON(viewRecResp.currentRec());
                viewRecResp.saveRecForm(dSave);
            }
        },

        onCancelBtnClick: function (pAction) {
            viewRecResp.isCancelClicked = true;
            viewRecResp.changeButtons(pAction);
            viewRecResp.bindCanceledRecForm();
            viewRecResp.changeFormLook('display');
        },

        saveRecForm: function (pData) {
            var saveEndPontURL = viewRecResp.currentRec()._Links[0].href;
            $.ajax({
                type: "PUT",
                data: pData,
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: saveEndPontURL,
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecResp.saveRecFormSuccess();
                    } else {
                        viewRecResp.saveRecFormError(pResults);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error saving recommendation data: " + pMessage);
                }
            });
        },
        saveRecFormSuccess: function () {
            viewRecResp.changeFormLook("display");
            viewRecResp.changeButtons('cancel');
            //HIDE LOADER HERE
            $('#tabLocDetailsLoading').addClass('noShow');
            viewRecResp.loadSavedRec(viewRecResp.currentRec().rowGuid);
            viewRecResp.loadRecCounts(viewRecResp.currentRec());
            viewRecResp.loadRecommendationsData();
        },
        saveRecFormError: function (pResults) {
            alert("An error occured during the save process: " + pResults.message + ". Your changes were not saved.");
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
                if (viewRecResp.recGridDataSource().length > 1) {
                    $('#recPagerBtnHldr').removeClass('noShow');
                }
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

                    $('.facilityRow').each(function () {
                        $(this).height('55px');
                    });

                    $('.closeRec').addClass('noShow');
                    $('.recEditFields').addClass('editMode');
                    //CHECK FOR ADMIN TO DETERMIN EDITABLITY OF STATUS AND STATUS DATE
                    if (viewRecResp.isAdmin()) {
                        $('#recStatusDatePicker').find(".k-icon").removeClass("recEditField");
                        $('#recStatusDateDisplay').addClass('noShow');
                        $('#recStatusDisplay').addClass('noShow');
                        $('#recStatusDDHldr').removeClass('noShow');
                        $('#recStatusDatePickerHldr').removeClass('noShow');
                    }


                    if (!viewRecResp.isAutoRec()) {
                        $('#respFromHldr').removeClass('noShow');
                        $('#recFacilityRespDatePickerHldr').removeClass('noShow');
                    } else {
                        //FOR AUTO REC: 
                        //SET RESPONSE FROM VALUE TO CURRENT USER
                        $('#recFacilityRespFrom').val(viewRecResp.currentUser().name);
                        //SET RESPONSE DATE TO TODAY'S DATE
                        var today = new Date();
                        $('#recFacilityRespDatePickerHldr').val(today);
                        viewRecResp.recFacilityRespDateBackColor(null);
                    }
                    $('#recFacilityIntendedActionDDHldr').removeClass('noShow');
                    $('#recFacilityExpectedCompDatePickerHldr').removeClass('noShow');
                    $('#actCostToCompHldr').removeClass('noShow');
                    $('#commentHldr').removeClass('noShow');
                    $('#recFacilityRespDatePicker').find(".k-icon").removeClass("recEditField");
                    $('#recFacilityExpectedCompDatePicker').find(".k-icon").removeClass("recEditField");
                    //FIX FOR CALENDAR ICONS NOT DISPLAYING CORRECTLY
                    $('<i class="far fa-calendar-alt"></i>').insertBefore($('.k-i-calendar'));
                    $("span").remove('.k-i-calendar');

                    if (viewRecResp.showMGMT()) {
                        //SHOW EDITS
                        $('#mgmtRecRespDatePickerHldr').removeClass('noShow');
                        $('#mgmtRecRespFromHldr').removeClass('noShow');
                        $('#mgmtRecIntendedActionHldr').removeClass('noShow');
                        $('#mgmtRecExpectedCompDatePickerHldr').removeClass('noShow');
                        $('#mgmtCommentHldr').removeClass('noShow');
                        $('#recMGMTRespDatePicker').find(".k-icon").removeClass("editRequired");
                    }
                    if (viewRecResp.show3rdLvl()) {
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

                    if (viewRecResp.showMGMT()) {
                        var tempMGMTRowHeight = $('#mgmtCommentLbl').height();
                        $('.mgmtRow').each(function () {
                            $(this).height(tempMGMTRowHeight);
                        });
                    }

                    if (viewRecResp.show3rdLvl()) {
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

                    if (viewRecResp.showMGMT()) {
                        //HIDE EDITS
                        $('#mgmtRecRespDatePickerHldr').addClass('noShow');
                        $('#mgmtRecRespFromHldr').addClass('noShow');
                        $('#mgmtRecIntendedActionHldr').addClass('noShow');
                        $('#mgmtActCostHldr').addClass('noShow');
                        $('#mgmtCommentHldr').addClass('noShow');
                    }

                    if (viewRecResp.show3rdLvl()) {
                        //HIDE EDITS
                        $('#recThirdLvlRespDatePickerHldr').addClass('noShow');
                        $('#recThirdLvlRespFromHldr').addClass('noShow');
                        $('#recThirdLvlIntendedActionDDHldr').addClass('noShow');
                        $('#thirdLvlCommentHldr').addClass('noShow');
                    }

                    break;
            }

        },


        getERReport: function () {
            $.ajax({
                type: "GET",
                cache: true,
                async: false,
                contentType: "text/plain",
                url: viewRecResp.er_ReportEndPointUrl(),
                success: function (pResults) {
                    return global.openFile(pResults.data.content, pResults.data.fileName, 'application/pdf');
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
                url: viewRecResp.diagramReportEndPointUrl(),
                success: function (pResults) {
                    return global.openFile(pResults.data.content, pResults.data.fileName, 'application/pdf');
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading er report data: " + pMessage);
                }
            });
        },

        bindCanceledRecForm: function () {

            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: viewRecResp.recommendationsDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewRecResp.recGridDataSource(pResults.data);
                        for (var i = 0; i < pResults.data.length; i++) {
                            if (pResults.data[i].rowGuid == viewRecResp.currentRec().rowGuid) {
                                viewRecResp.pagerBindRecForm(pResults.data[i]);
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

        mgmtActionSelect: function (e) {
            let dataItem = e.sender.dataItem();
            viewRecResp.recMGMTRespActionId(dataItem.id);
            viewRecResp.currentRec().mgmtRespActionId = dataItem.id;
            viewRecResp.recMGMTIntendedAction(dataItem.displayText);
            viewRecResp.currentRec().mgmtRespAction = dataItem.displayText;
        },

        thirdLvlActionSelect: function (e) {
            let dataItem = e.sender.dataItem();
            viewRecResp.recThirdLvlIntendedActionId(dataItem.id);
            viewRecResp.currentRec().thirdLevelRespActionId = dataItem.id;
            viewRecResp.recThirdLvlIntendedAction(dataItem.displayText);
            viewRecResp.currentRec().thirdLevelRespAction = dataItem.displayText;
        },

        intendedActionSelect: function (e) {
            let dataItem = e.sender.dataItem();
            viewRecResp.currentRec().intendedAction = dataItem.displayText;
            viewRecResp.currentRec().intendedActionId = dataItem.id;

            if (viewRecResp.recStatus().toLowerCase() != "advisory" &&
                viewRecResp.recStatus().toLowerCase() != "conf completed" &&
                viewRecResp.recStatus().toLowerCase() != "removed") {
                if (dataItem.id == 6) {
                    //COMPLETED
                    viewRecResp.currentRec().intendedAction = "Completed";
                    viewRecResp.currentRec().intendedActionId = 6;
                    viewRecResp.recStatus("Rptd Completed");
                    viewRecResp.currentRec().status = "Rptd Completed";
                    viewRecResp.statusID(6);
                    viewRecResp.currentRec().statusId = 6;
                    $('#recStatusDD').val(6);
                } else if (dataItem.id == 9) {
                    //IN PROGRESS
                    viewRecResp.currentRec().intendedAction = "In Progress";
                    viewRecResp.currentRec().intendedActionId = 9;
                    if (viewRecResp.recStatus().toLowerCase() != "advisory") {
                        viewRecResp.recStatus("In Progress");
                        viewRecResp.currentRec().status = "In Progress";
                        viewRecResp.statusID(3);
                        viewRecResp.currentRec().statusId = 3;
                        $('#recStatusDD').val(3);
                    } else {
                        viewRecResp.recStatus("Advisory");
                        viewRecResp.currentRec().status = "Advisory";
                        viewRecResp.statusID(1);
                        viewRecResp.currentRec().statusId = 1;
                        $('#recStatusDD').val(1);
                    }
                } else {
                    viewRecResp.recStatus("Outstanding");
                    viewRecResp.currentRec().status = "Outstanding";
                    viewRecResp.statusID(4);
                    viewRecResp.currentRec().statusId = 4;
                    $('#recStatusDD').val(4);
                }
            } else if (viewRecResp.recStatus().toLowerCase() == "advisory" || $('#recStatusDD').val() == "advisory") {
                if (dataItem.id == 6) {
                    //COMPLETED
                    viewRecResp.recStatus("Rptd Completed");
                    viewRecResp.currentRec().status = "Rptd Completed";
                    viewRecResp.statusID(6);
                    viewRecResp.currentRec().statusId = 6;
                    $('#recStatusDD').val(6);
                }
            }
        },

        populateSaveObject: function () {
            if (!viewRecResp.isIR()) {
                let tempCost = $('#facilityActCostComp').val();
                if (tempCost.indexOf(",") > -1) {
                    let re = /,/gi;
                    let newCost = tempCost.replace(re, "");
                    viewRecResp.currentRec().costToComplete = parseInt(newCost);
                } else {
                    viewRecResp.currentRec().costToComplete = parseInt(tempCost);
                }
            }
            viewRecResp.currentRec().intendedActionId = parseInt($('#recFacilityIntendedActionDD').val());
            viewRecResp.currentRec().facilityComment = $('#recFacilityComment').val();
            viewRecResp.currentRec().expectedCompletionDate = global.convertGRCStringToDate($('#recFacilityExpectedCompDatePicker').val());
        },

        bindForm: function () {
            ko.applyBindings(viewRecResp, $("#viewRecResp")[0]);
        },
    }

    viewRecResp.bindForm();
    viewRecResp.init();

    function onEnter(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        viewRecResp.displayRecForm(dataItem.fileNo, dataItem.rowGuid);
    }

});