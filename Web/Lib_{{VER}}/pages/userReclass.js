/* IMPORTANT NOTE: THIS MVVM REQUIRES: */
/* JQUERY */
/* KNOCKOUT */
/* GLOBAL.JS */

/* IMPORTANT NOTE: */
/* TO USE THIS FILE PLEASE HAVE A PARENT DIV ON THE PAGE WITH AN ID OF "view" */
/* TO DISPLAY ERROR MESSAGES, PLEASE USE A LABEL WITH DATA BINDING AND ID OF "txtMessage" */


$(document).ready(function () {

    /* BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM */
    kendo.ui.progress($("#divContainerLoading"), true);

    /* CONSTANTS */
    var gDOMNameRInit = "init";
    var gDOMNameRReport = "rpt";
    var gDOMNameRfu1 = "FirstFU";
    var gDOMNameRfu2 = "SecondFU";
    var gDOMNameRfu3 = "ThirdFU";
    var gDOMNameRExpd = "ExpdFU";
    var gDOMNameROverdue1 = "FirstOD";
    var gDOMNameROverdue2 = "SecondOD";
    var gDOMNameROverdue3 = "ThirdOD";
    var gDOMNameRPastDue = "PastDue";
    var gDOMNameReclassStatus = "noteHldr";
    var gDOMNameExitMessage = "divMessageComplete";
    var gDOMNameRecordHolder = "numRecordHolder";
    var gDOMNameRecordHolderPending = "numPendingRecordHolder";
    var gDOMNameButtonHolder = "btnHldr";
    var gDOMNamePendingOnlyButton = "btnPendingOnly";
    var gClassRInit = "chkRInit";
    var gClassRReport = "chkRReport";
    var gClassRfu1 = "chkRfu1";
    var gClassRfu2 = "chkRfu2";
    var gClassRfu3 = "chkRfu3";
    var gClassRExpd = "chkRExpd";
    var gClassROverdue1 = "chkROverdue1";
    var gClassROverdue2 = "chkROverdue2";
    var gClassROverdue3 = "chkROverdue3";
    var gClassRPastDue = "chkRPastDue";
    var gClassPending = "pending";
    var gClassConfirmed = "confirmed";
    var gClassButtonDisable = "btnDisable";
    var gTitleButtonNext = "Next"; //"Save and Next";
    var gTitleButtonExit = "Next"; //"Save and Exit";
    var gTitleShowPending = "Filter on Pending Records";
    var gTitleShowAll = "Show All Records";
    var gTitleStatusPending = "Pending";
    var gTitleStatusConfirmed = "Completed";
    var gAnimationTimer = 250;

    /* MVVM */
    var view = {
        /* DECLARATIONS */
        firstLoad: true,
        countLoading: 0,
        isActionOnLoad: false,
        isNavNext: false,
        isPendingOnly: false,

        /* DATA */
        txtMessage: ko.observable(),
        largeObjectSort: null,
        largeObjectFilter: null,
        largeObjectCriteria: null,

        /* GENERAL DATA */
        gSafeGuid: getGSafeGUID(),
        colRInit: "",
        colRReport: "",
        colRfu1: "",
        colRfu2: "",
        colRfu3: "",
        colRExpd: "",
        colROverdue1: "",
        colROverdue2: "",
        colROverdue3: "",
        colRPastDue: "",

        /* DATA FOR BINDING */
        arrayPractices: ko.observableArray([]),
        userTotalCountPending: ko.observable(0),
        colEzyGuid: null,
        colUserCertifiedCount: 0,
        colPercentComplete: ko.observable(0),
        colUserIndex: ko.observable(0),
        colUserTotalCount: ko.observable(0),
        colFullName: ko.observable(""),
        colActiveUser: ko.observable(""),
        colAccessLevel: ko.observable(""),
        colAccessLevelDetails: ko.observable(""),
        colEmail: ko.observable(""),
        colCCOnly: ko.observable(""),
        colDateTimeStamp: ko.observable(""),
        colLastLogin: ko.observable(""),
        colComments: ko.observable(""),
        colClientComments: ko.observable(""),
        colActionId: ko.observable(dsUserReclassActions.none),
        radValueConfirm: ko.observable(dsUserReclassActions.userConfirm),
        radValueActivate: ko.observable(dsUserReclassActions.userActivate),
        radValueInactivate: ko.observable(dsUserReclassActions.userInactivate),
        radValueDelete: ko.observable(dsUserReclassActions.userDelete),
        colActionIdPrevious: dsUserReclassActions.none,

        /* BUTTON AND VISIBILITY CONTROLS */
        enableForm: ko.observable(true),
        enableButtonNext: ko.observable(true),
        enableButtonPrevious: ko.observable(true),
        txtButtonNext: ko.observable(gTitleButtonNext),
        txtButtonPendingOnly: ko.observable(gTitleShowPending),
        txtReclassStatus: ko.observable(gTitleStatusPending),
        visibleActionAvtivate: ko.observable(true),
        visibleActionInavtivate: ko.observable(true),

        /* KENDO OBJECTS */
        windowDefinitions: null,
        

        /* FUNCTIONS */
        init: function () {
            view.showLoading();
            view.countLoading = 5;
            view.loadDictionary();
            view.loadData();
            view.setupKendo();
            view.setupEvents();
        },


        loadDictionary: function () {
            view.processLoading();
        },


        loadData: function () {
            view.loadPractices();
        },


        /* LOAD THE PRACTICE DATA */
        loadPractices: function () {
            try {
                view.txtMessage("");
                var zServiceName = "GetUserReclassPractices";
                var zParms = ko.toJSON({
                    "pGSafeGuid": view.gSafeGuid
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadPracticesSuccess, view.loadPracticesError, null);
            } catch (pException) {
                view.txtMessage("An error occurred while starting the practices data call: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },
        loadPracticesSuccess: function (pResults, pParms) {
            try {
                if (pResults) {
                    if (pResults.isSuccess && pResults.data) {
                        /* BUILD PRACTICE CHECKBOX LIST */
                        var zArray = pResults.data;
                        zArray.unshift(dsPracticeAll);
                        view.arrayPractices(pResults.data);
                        /* LOAD FIRST USER */
                        view.loadUser(dsUserNavActions.navFirst);
                    } else {
                        view.txtMessage("An unknown error occurred while building practices data: " + pResults.message);
                        global.messageShow("txtMessage", "messageError");
                        view.hideLoading();
                    }
                }
                view.processLoading();
            } catch (pException) {
                view.txtMessage("An error occurred while starting the practices data call: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },
        loadPracticesError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.txtMessage("Error while accessing load practice data call. " + pMessage + " - " + pErrorDetail);
            global.messageShow("txtMessage", "messageError");
            view.hideLoading();
        },


        /* LOAD THE USER DATA */
        loadUser: function (pNavigateAction) {
            try {
                view.txtMessage("");
                view.enableForm(true);
                //view.disableButtons();
                // CLEAR THE FIELDS
                view.clearCheckboxValues();
                view.onClearSelectionOnLoad(false);
                view.clearSummaryFields();
                // GATHER INFORMATION
                var zEzyUserGuid = "";
                var zU1 = global.getQueryVariable("u1");
                if (zU1 && view.firstLoad) {
                    zEzyUserGuid = zU1;
                    pNavigateAction = dsUserNavActions.none;
                } else {
                    zEzyUserGuid = view.colEzyGuid;
                }
                // LOAD THE SERVICE
                var zServiceName = null;
                var zParms = null;
                if (gPageName == "UserReclassification") {
                    zServiceName = "GetUserReclassForm";
                    zParms = ko.toJSON({
                        "pGSafeGuid": view.gSafeGuid,
                        "pNavigateAction": pNavigateAction,
                        "pEzyGuid": zEzyUserGuid,
                        "pIsPendingOnly": view.isPendingOnly.toString(),
                        "pCurrentIndex": view.colUserIndex(),
                        "pFormType": gPageName
                    });
                } else {
                    zServiceName = "GetUserForm";
                    zParms = ko.toJSON({
                        "pGSafeGuid": view.gSafeGuid,
                        "pNavigateAction": pNavigateAction,
                        "pEzyGuid": zEzyUserGuid
                    });
                }
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadUserSuccess, view.loadUserError, null);
            } catch (pException) {
                view.txtMessage("An error occurred while starting the load user data call: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },
        loadUserSuccess: function (pResults, pParms) {
            try {
                if (pResults) {
                    if (pResults.isSuccess && pResults.data) {
                        // CONVERT THE ACTION ID TO A STRING
                        var zAction = pResults.data[0].colActionId.toString();
                        var zFound = false;
                        for (var zField in dsUserReclassActions) {
                            if (zAction == dsUserReclassActions[zField]) {
                                zFound = true;
                                view.isActionOnLoad = true;
                                break;
                            }
                        }
                        if (!zFound) {
                            zAction = "0";
                            view.isActionOnLoad = false;
                        }
                        if (zAction == "0") {
                            view.isActionOnLoad = false;
                        }
                        // SET DATA BINDING TO FORM
                        view.colEzyGuid = pResults.data[0].colEzyGuid;
                        view.colUserCertifiedCount = pResults.data[0].colUserCertifiedCount;
                        view.colUserIndex(pResults.data[0].colUserIndex);
                        view.colUserTotalCount(pResults.data[0].colUserTotalCount);
                        view.colFullName(pResults.data[0].colFullName);
                        view.colActiveUser(pResults.data[0].colActiveUser);
                        view.colAccessLevel(pResults.data[0].colAccessLevel);
                        view.colAccessLevelDetails(pResults.data[0].colAccessLevelDetails);
                        view.colEmail(pResults.data[0].colEmail);
                        view.colCCOnly(pResults.data[0].colCCOnly);
                        view.colDateTimeStamp(pResults.data[0].colDateTimeStamp);
                        view.colLastLogin(pResults.data[0].colLastLogin);
                        view.colComments(pResults.data[0].colComment);
                        view.colClientComments(pResults.data[0].colClientComment);
                        view.colActionId(zAction);
                        view.colActionIdPrevious = zAction;
                        /* SET REMAINIG OR PENDING COUNT */
                        view.userTotalCountPending(view.colUserTotalCount() - view.colUserCertifiedCount);
                        /* BUILD CHECKBOX VALUES */
                        view.buildCheckboxValues(pResults.data[0]);
                        /* DETERMINE ENABLE FLAGS FOR BUTTONS */
                        //view.enableButtons();
                        view.enableButtonNext(true);
                        view.enableButtonPrevious(true);
                        if (view.colUserIndex() < 2) {
                            view.enableButtonPrevious(true);
                        }
                        // DO WE SHOW THE EXIT BUTTON AND MESSAGE?
                        if (!view.isPendingOnly) {
                            if (((view.colUserCertifiedCount >= view.colUserTotalCount()) && (view.colActionId() != dsUserReclassActions.none)) ||
                                view.userTotalCountPending() < 1) { // && (view.colUserIndex() >= view.colUserTotalCount())
                                //view.enableButtonNext(true);
                                view.userTotalCountPending(0);
                                view.showExitMessage();
                                view.txtButtonNext(gTitleButtonExit);
                            } else {
                                view.hideExitMessage();
                                view.txtButtonNext(gTitleButtonNext);
                            }
                        } else {
                            if (view.colUserTotalCount() < 1) {
                                //view.enableButtonNext(true);
                                view.userTotalCountPending(0);
                                view.showExitMessage();
                                view.txtButtonNext(gTitleButtonExit);
                            } else {
                                view.hideExitMessage();
                                view.txtButtonNext(gTitleButtonNext);
                            }
                        }
                        // SET THE RECLASS STATUS
                        view.setReclassStatus(view.colActionId());
                        view.firstLoad = false;
                    } else {
                        // IF WE ARE IN PENDING MODE, TURN IT OFF AND TRY TO RELOAD IN ALL MODE
                        if (view.isPendingOnly) {
                            view.onPendingMode(true);
                        } else {
                            view.txtMessage("An unknown error occurred while building load user data: " + pResults.message);
                            global.messageShow("txtMessage", "messageError");
                            view.enableForm(false);
                            view.hideLoading();
                        }
                    }
                }
                view.processLoading();
            } catch (pException) {
                view.txtMessage("An error occurred while building the user data: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.enableForm(false);
                view.hideLoading();
            }
        },
        loadUserError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.txtMessage("Error while accessing load user data call. " + pMessage + " - " + pErrorDetail);
            global.messageShow("txtMessage", "messageError");
            view.hideLoading();
        },


        /* SAVE THE USER DATA */
        saveUser: function (pNavigateAction, pIsReloadRequired) {
            try {
                if (view.validateUser()) {
                    view.txtMessage("");
                    var zServiceName = "";
                    var zParms = ko.toJSON({
                        "pGSafeGuid": view.gSafeGuid,
                        "pJSON": view.buildUserData()
                    });
                    if (gPageName == "UserReclassification") {
                        zServiceName = "SaveUserReclassForm";
                    } else {
                        zServiceName = "SaveUserAccountForm";
                    }
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.saveUserSuccess, view.saveUserError, { navigateAction: pNavigateAction, isReloadRequired: pIsReloadRequired });
                }
            } catch (pException) {
                view.txtMessage("An error occurred while starting the save user data call: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },
        saveUserSuccess: function (pResults, pParms) {
            try {
                if (pResults) {
                    if (pResults.isSuccess) {
                        /* NAVIGATE TO THE NEXT OR PREVIOUS RECORD */
                        if (pParms.navigateAction && pParms.isReloadRequired) {
                            view.loadUser(pParms.navigateAction);
                        }
                        ///* NAVIGATE TO THE NEXT OR PREVIOUS RECORD */
                        ///* OR EXIT THE FORM */
                        //if (view.txtButtonNext() == gTitleButtonExit && view.isNavNext) {
                        //    view.onExit();
                        //} else {
                        //    if (pParms.navigateAction) {
                        //        view.loadUser(pParms.navigateAction);
                        //    }
                        //}
                    } else {
                        view.txtMessage("An unknown error occurred while saving user data: " + pResults.message);
                        global.messageShow("txtMessage", "messageError");
                        view.hideLoading();
                    }
                } else {
                    view.txtMessage("An unknown error occurred while saving user data.");
                    global.messageShow("txtMessage", "messageError");
                    view.hideLoading();
                }
                view.processLoading();
            } catch (pException) {
                view.txtMessage("An error occurred while starting the save user data call: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },
        saveUserError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.txtMessage("Error while accessing save user data call. " + pMessage + " - " + pErrorDetail);
            global.messageShow("txtMessage", "messageError");
            view.hideLoading();
        },
        validateUser: function () {
            var zReturn = true;
            try {
                /* DO WORK */
            } catch (pException) {
                view.txtMessage("An error occurred while validating user data: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
                zReturn = false;
            }
            return zReturn;
        },
        buildPracticeData: function () {
            /* BUILD JSON OF STRING/CHARACTER DATA FROM CHECKBOX VALUES */
            var zReturn = null;
            try {
                /* CLEAR THE PREVIOUS VALUES */
                view.colRInit = "";
                view.colRReport = "";
                view.colRfu1 = "";
                view.colRfu2 = "";
                view.colRfu3 = "";
                view.colRExpd = "";
                view.colROverdue1 = "";
                view.colROverdue2 = "";
                view.colROverdue3 = "";
                view.colRPastDue = "";
                /* GO THROUGH EACH CHECKBOX COLUMN AND BUILD STRINGS OF LETTERS */
                $("." + gClassRInit).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameRInit + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colRInit = view.colRInit + zLetter;
                        }
                    }
                });
                $("." + gClassRReport).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameRReport + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colRReport = view.colRReport + zLetter;
                        }
                    }
                });
                $("." + gClassRfu1).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameRfu1 + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colRfu1 = view.colRfu1 + zLetter;
                        }
                    }
                });
                $("." + gClassRfu2).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameRfu2 + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colRfu2 = view.colRfu2 + zLetter;
                        }
                    }
                });
                $("." + gClassRfu3).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameRfu3 + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colRfu3 = view.colRfu3 + zLetter;
                        }
                    }
                });
                $("." + gClassRExpd).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameRExpd + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colRExpd = view.colRExpd + zLetter;
                        }
                    }
                });
                $("." + gClassROverdue1).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameROverdue1 + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colROverdue1 = view.colROverdue1 + zLetter;
                        }
                    }
                });
                $("." + gClassROverdue2).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameROverdue2 + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colROverdue2 = view.colROverdue2 + zLetter;
                        }
                    }
                });
                $("." + gClassROverdue3).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameROverdue3 + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colROverdue3 = view.colROverdue3 + zLetter;
                        }
                    }
                });
                $("." + gClassRPastDue).each(function () {
                    if (this.checked) {
                        var zLetter = this.id.replace(gDOMNameRPastDue + "_", "");
                        if (zLetter.toLowerCase() != "a") {
                            view.colRPastDue = view.colRPastDue + zLetter;
                        }
                    }
                });
            } catch (pException) {
                view.txtMessage("Error while building data from practice checkbox values. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
                zReturn = null;
            }
            return zReturn;
        },
        buildUserData: function () {
            var zData = "";
            try {
                /* BUILD THE DATA */
                view.buildPracticeData();
                var zJSON = {
                    colUserIndex: view.colUserIndex(),
                    colUserTotalCount: view.colUserTotalCount(),
                    colEzyGuid: view.colEzyGuid,
                    colFullName: view.colFullName(),
                    colActiveUser: view.colActiveUser(),
                    colAccessLevel: view.colAccessLevel(),
                    colAccessLevelDetails: view.colAccessLevelDetails(),
                    colEmail: view.colEmail(),
                    colCCOnly: view.colCCOnly(),
                    colDateTimeStamp: view.colDateTimeStamp(),
                    colLastLogin: view.colLastLogin(),
                    colComment: view.colComments(),
                    colClientComment: view.colClientComments(),
                    colRInit: view.colRInit,
                    colRReport: view.colRReport,
                    colRfu1: view.colRfu1,
                    colRfu2: view.colRfu2,
                    colRfu3: view.colRfu3,
                    colROverdue1: view.colROverdue1,
                    colROverdue2: view.colROverdue2,
                    colROverdue3: view.colROverdue3,
                    colExpOverdue: view.colRPastDue,
                    colRExpd: view.colRExpd,
                    colActionId: view.colActionId()
                };
                zData = JSON.stringify(zJSON);
            } catch (pException) {
                view.txtMessage("An error occurred while building user data string: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
                zData = "";
            }
            return zData;
        },


        /* LOAD THE CALL FOR EXITING FORM */
        loadExit: function (pNavigateAction) {
            try {
                view.txtMessage("");
                view.enableForm(true);
                var zServiceName = "MarkClientAsCompleted";
                var zParms = ko.toJSON({
                    "pGSafeGuid": view.gSafeGuid
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadExitSuccess, view.loadExitError, null);
            } catch (pException) {
                view.txtMessage("An error occurred while starting the load exit data call: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },
        loadExitSuccess: function (pResults, pParms) {
            try {
                if (pResults) {
                    if (pResults.isSuccess) {
                        // EXIT THE FORM
                        var zURL = "";
                        if (gPageName == "UserReclassification") {
                            zURL = "notification.aspx" + "?sid=" + view.gSafeGuid + "&p2=2";
                        } else {
                            zURL = "../../Home_{{VER}}/Gauge/Default.aspx" + "?sid=" + view.gSafeGuid;
                        }
                        document.location.href = zURL;
                    } else {
                        view.txtMessage("An unknown error occurred while building load exit data: " + pResults.message);
                        global.messageShow("txtMessage", "messageError");
                        view.enableForm(false);
                        view.hideLoading();
                    }
                }
                view.processLoading();
            } catch (pException) {
                view.txtMessage("An error occurred while starting the load exit data call: " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.enableForm(false);
                view.hideLoading();
            }
        },
        loadExitError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.txtMessage("Error while accessing load exit data call. " + pMessage + " - " + pErrorDetail);
            global.messageShow("txtMessage", "messageError");
            view.hideLoading();
        },


        /* SET THE LARGE OBJECT DATA FOR EXTRACTING */
        setLargeObjectData: function () {
            try {
                var zServiceName = "SaveLargeObjectData";
                var zSort = null;
                var zFilter = null;
                var zCriteria = null;
                var zColumnOrder = dsExtractColumns;
                if (view.largeObjectSort === null) {
                    // NO GRID TO GATHER INFO
                } else {
                    zSort = view.largeObjectSort;
                }
                if (view.largeObjectFilter === null) {
                    // NO GRID TO GATHER INFO
                } else {
                    zFilter = view.largeObjectFilter;
                }
                if (view.largeObjectCriteria === null) {
                    // NO GRID TO GATHER INFO
                } else {
                    zCriteria = view.largeObjectCriteria;
                }
                var zParms = ko.toJSON({
                    "gSafeGuid": view.gSafeGuid,
                    "gridId": 0,
                    "sort": zSort,
                    "filter": zFilter,
                    "criteria": zCriteria,
                    "meta": null,
                    "columnOrder": null
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.setLargeObjectDataSuccess, view.setLargeObjectDataError, null);
            } catch (pException) {
                view.txtMessage("An error occurred while starting the build extract call: " + pException.message);
                global.messageShow("txtMessage", "messageGridError");
                view.hideLoading();
            }
        },
        setLargeObjectDataSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    // CALL HANDLER
                    var zURL = "../FD/" + "ServeExtract.ashx" + "?gSafeGuid=" + getGSafeGUID();
                    window.location.href = zURL;
                } else {
                    view.txtMessage("An error occurred while building extract data: " + pResults.message);
                    global.messageShow("txtMessage", "messageGridError");
                    view.hideLoading();
                }
            } catch (pException) {
                view.txtMessage("An error occurred while building extract data: " + pException.message);
                global.messageShow("txtMessage", "messageGridError");
                view.hideLoading();
            }
            view.processLoading();
        },
        setLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.txtMessage("Error while setting extract data. " + pMessage);
            global.messageShow("txtMessage", "messageGridError");
            view.hideLoading();
        },


        onBack: function () {
            try {
                if (view.enableForm()) {
                    view.txtMessage("");
                    view.isNavNext = false;
                    var zDirection = dsUserNavActions.navPrevious;
                    if (view.colUserIndex() <= 1) {
                        zDirection = dsUserNavActions.navLast;
                    }
                    view.saveUser(zDirection, true);
                    //view.loadUser(dsUserNavActions.navPrevious); /* DELETE ME - FOR TESTING ONLY */
                }
            } catch (pException) {
                view.txtMessage("Error while navigating to previous record. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onNext: function () {
            try {
                if (view.enableForm()) {
                    view.txtMessage("");
                    view.isNavNext = true;
                    var zDirection = dsUserNavActions.navNext;
                    if (view.colUserIndex() >= view.colUserTotalCount()) {
                        zDirection = dsUserNavActions.navFirst;
                    }
                    view.saveUser(zDirection, true);
                    //view.loadUser(dsUserNavActions.navNext); /* DELETE ME - FOR TESTING ONLY */
                }
            } catch (pException) {
                view.txtMessage("Error while navigating to next record. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onExit: function () {
            try {
                view.showLoading();
                view.loadExit();
            } catch (pException) {
                view.txtMessage("Error while exiting / cancelling. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onPendingMode: function (pIsSaveBypass) {
            try {
                if (view.enableForm()) {
                    view.txtMessage("");
                    view.isNavNext = false;
                    var zDirection = dsUserNavActions.navFirst;
                    if (view.isPendingOnly) {
                        view.isPendingOnly = false;
                        view.txtButtonPendingOnly(gTitleShowPending);
                        view.showRecordCountAll();
                        view.showNavButtons();
                    } else {
                        view.isPendingOnly = true;
                        view.txtButtonPendingOnly(gTitleShowAll);
                        view.showRecordCountPending();
                    }
                    if (pIsSaveBypass) {
                        view.loadUser(zDirection);
                    } else {
                        view.saveUser(zDirection, true);
                    }
                }
            } catch (pException) {
                view.txtMessage("Error while turning on / off pending only mode. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onExtract: function () {
            try {
                view.showLoading();
                view.countLoading = 1;
                view.txtMessage("");
                view.setLargeObjectData();
                //view.loadExtract();
            } catch (pException) {
                view.txtMessage("Error while extracting data. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onActionClick: function() {
            try {
                var zDirection = dsUserNavActions.none;
                var zIsReloadRequired = false;
                // IF THE FINAL RECORD IS NOT CERT. AFTER SAVE WILL SET BE 100% COMPLETE
                if (!view.isPendingOnly) {
                    if (view.colActionIdPrevious == dsUserReclassActions.none) {
                        // CORRECT THE COUNTS
                        view.userTotalCountPending(view.userTotalCountPending() - 1);
                    }
                    if (!view.isActionOnLoad && view.colUserCertifiedCount >= view.colUserTotalCount() - 1) {
                        view.showExitMessage();
                        view.txtButtonNext(gTitleButtonExit);
                    } else {
                        if (view.colActionId() != dsUserReclassActions.none) {
                            view.hideExitMessage();
                            view.txtButtonNext(gTitleButtonNext);
                        }
                    }
                } else {
                    if (view.colActionIdPrevious == dsUserReclassActions.none) {
                        // CORRECT THE COUNTS
                        //view.colUserTotalCount(view.colUserTotalCount() - 1);
                    }
                    if (!view.isActionOnLoad && view.colUserTotalCount() <= 1) {
                        view.showExitMessage();
                        view.txtButtonNext(gTitleButtonExit);
                        zIsReloadRequired = true;
                    } else {
                        view.hideExitMessage();
                        view.txtButtonNext(gTitleButtonNext);
                    }
                }
                // SET THE RECLASS STATUS AND OTHER FIELDS
                view.setReclassStatus(view.colActionId());
                view.colActionIdPrevious = view.colActionId();
                // PROCESS A SAVE, BUT DO NOT NAVIGATE
                view.saveUser(zDirection, zIsReloadRequired);
            } catch (pException) {
                view.txtMessage("Error while running related functions to action radio buttons. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return true;
        },


        onClearSelection: function (pIsSaveUser) {
            try {
                view.hideExitMessage();
                view.onClearSelectionOnLoad(pIsSaveUser);
            } catch (pException) {
                view.txtMessage("Error while clearing data. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onClearSelectionOnLoad: function (pIsSaveUser) {
            try {
                //view.txtMessage("");
                if (view.colActionId() != dsUserReclassActions.none) {
                    view.txtButtonNext(gTitleButtonNext);
                    view.colActionId(dsUserReclassActions.none);
                    if (pIsSaveUser) {
                        // CORRECT THE COUNTS
                        if (!view.isPendingOnly) {
                            view.userTotalCountPending(view.userTotalCountPending() + 1);
                        } else {
                            //view.colUserTotalCount(view.colUserTotalCount() + 1);
                        }
                        // SET THE RECLASS STATUS AND OTHER FIELDS
                        view.setReclassStatus(view.colActionId());
                        view.colActionIdPrevious = dsUserReclassActions.none;
                        // PROCESS A SAVE, BUT DO NOT NAVIGATE
                        view.saveUser(dsUserNavActions.none, false);
                    } else {
                        // DO NOTHING
                    }
                }
            } catch (pException) {
                view.txtMessage("Error while clearing data. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onOpenDefinitions: function () {
            try {
                view.txtMessage("");
                view.windowDefinitions.open();
            } catch (pException) {
                view.txtMessage("Error while opening definitions. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            return false;
        },


        onCheckboxClick: function (pData, pElement) {
            /* NOTE: NEED THE FOLLOWING DATA BIND IN THE CHECKBOX INPUT ELEMENT */
            /* click: function () { $parent.onCheckboxClick($data, $element); } */
            try {
                var zLetter = pElement.id.toLowerCase();
                var zChecked = pElement.checked;
                var zClassName = pElement.className;
                zClassName = zClassName.replace("editRequired", "");
                zClassName = zClassName.replace(" ", "");
                /* REMOVE ANY OF THE NAME MODIFIERS FROM THE ID */
                zLetter = zLetter.replace(gDOMNameRInit.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameRReport.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameRfu1.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameRfu2.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameRfu3.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameRExpd.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameROverdue1.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameROverdue2.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameROverdue3.toLowerCase() + "_", "");
                zLetter = zLetter.replace(gDOMNameRPastDue.toLowerCase() + "_", "");
                /* FIND ALL CHECKBOXES IN THIS COLUMN AND CHECK OR UNCHECK */
                if (zLetter == "a") {
                    if (pElement.className) {
                        if (zChecked) {
                            $("." + zClassName).each(function () {
                                $(this).prop("checked", true);
                            });
                        } else {
                            $("." + zClassName).each(function () {
                                $(this).prop("checked", false);
                            });
                        }
                    }
                }
                /* END BY ALWAYS CHECKING OR UNCHECKING */
                setTimeout(function () {
                    if (zChecked) {
                        $("#" + pElement.id).prop("checked", true);
                    } else {
                        $("#" + pElement.id).prop("checked", false);
                    }
                }, 50);
            } catch (pException) {
                view.txtMessage("Error while applying checkbox value(s) to the form. " + pException.message);
                global.messageShow("txtMessage", "messageError");
            }
        },


        setReclassStatus: function (pActionId) {
            // SET THE RECLASS STATUS TEXT TO COMPLETED OR PENDING
            if (pActionId != dsUserReclassActions.none) {
                view.txtReclassStatus(gTitleStatusConfirmed);
                $("#" + gDOMNameReclassStatus).removeClass(gClassPending).addClass(gClassConfirmed);
            } else {
                view.txtReclassStatus(gTitleStatusPending);
                $("#" + gDOMNameReclassStatus).removeClass(gClassConfirmed).addClass(gClassPending);
            }
        },


        enableButtons: function () {
            try {
                view.enableForm(true);
                view.enableButtonNext(true);
                view.enableButtonPrevious(true);
            } catch (pException) {
                view.txtMessage("Error while enabeling form. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },


        disableButtons: function () {
            try {
                view.enableForm(false);
                view.enableButtonNext(false);
                view.enableButtonPrevious(false);
            } catch (pException) {
                view.txtMessage("Error while disabling form. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },


        setupKendo: function () {
            try {
                if (view.windowDefinitions == null) {
                    $("#windowDefinitions").kendoWindow({
                        visible: false,
                        modal: false,
                        draggable: true,
                        height: 379 + "px",
                        width: 613 + "px",
                        title: "Email Distribution Definitions",
                        actions: ['close'],
                        position: { top: 325},
                        animation: { open: { effects: "fade:in" }, close: { effects: "fade:out" } }
                    });
                    view.windowDefinitions = $("#windowDefinitions").data("kendoWindow");
                };

            } catch (pException) {
                view.txtMessage("Error while building form components. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            view.processLoading();
        },


        setupEvents: function () {
            try {
                $(document).keydown(function (e) {
                    var preventKeyPress;
                    /* PREVENT BACKSPACE */
                    if (e.keyCode == 8) {
                        var d = e.srcElement || e.target;
                        switch (d.tagName.toUpperCase()) {
                            case 'TEXTAREA':
                                preventKeyPress = d.readOnly || d.disabled;
                                break;
                            case 'INPUT':
                                preventKeyPress = d.readOnly || d.disabled ||
                                    (d.attributes["type"] && $.inArray(d.attributes["type"].value.toLowerCase(), ["radio", "checkbox", "submit", "button"]) >= 0);
                                break;
                            case 'DIV':
                                preventKeyPress = d.readOnly || d.disabled || !(d.attributes["contentEditable"] && d.attributes["contentEditable"].value == "true");
                                break;
                            default:
                                preventKeyPress = true;
                                break;
                        }
                    } else {
                        preventKeyPress = false;
                    }
                    /* PREVENT ESCAPE */
                    if (e.keyCode == 27) {
                        preventKeyPress = true;
                    }
                    if (preventKeyPress) {
                        e.preventDefault();
                    }
                });
            } catch (pException) {
                view.txtMessage("Error while setting up events. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
            view.processLoading();
        },
        

        clearSummaryFields: function() {
            view.colFullName("");
            view.colActiveUser("");
            view.colAccessLevel("");
            view.colAccessLevelDetails("");
            view.colEmail("");
            view.colCCOnly("");
            view.colDateTimeStamp("");
            view.colLastLogin("");
            view.colComments("");
            view.colClientComments("");
        },


        clearCheckboxValues: function () {
            $('#gridHldr').find('input[type=checkbox]:checked').prop('checked', false);
        },


        buildCheckboxValues: function (pData) {
            /* PARSE THE USER DATA FROM SERVER TO BUILD CHECKBOX VALUES */
            try {
                /* INIT */
                if (pData.colRInit) {
                    for (var x = 0; x < pData.colRInit.length; x++) {
                        $("#" + gDOMNameRInit + "_" + pData.colRInit[x]).prop("checked", true);
                    }
                }
                /* RPT */
                if (pData.colRReport) {
                    for (var x = 0; x < pData.colRReport.length; x++) {
                        $("#" + gDOMNameRReport + "_" + pData.colRReport[x]).prop("checked", true);
                    }
                }
                /* RFU1 */
                if (pData.colRfu1) {
                    for (var x = 0; x < pData.colRfu1.length; x++) {
                        $("#" + gDOMNameRfu1 + "_" + pData.colRfu1[x]).prop("checked", true);
                    }
                }
                /* RFU2 */
                if (pData.colRfu2) {
                    for (var x = 0; x < pData.colRfu2.length; x++) {
                        $("#" + gDOMNameRfu2 + "_" + pData.colRfu2[x]).prop("checked", true);
                    }
                }
                /* RFU3 */
                if (pData.colRfu3) {
                    for (var x = 0; x < pData.colRfu3.length; x++) {
                        $("#" + gDOMNameRfu3 + "_" + pData.colRfu3[x]).prop("checked", true);
                    }
                }
                /* ExpdFU */
                if (pData.colRExpd) {
                    for (var x = 0; x < pData.colRExpd.length; x++) {
                        $("#" + gDOMNameRExpd + "_" + pData.colRExpd[x]).prop("checked", true);
                    }
                }
                /* 1stOD */
                if (pData.colROverdue1) {
                    for (var x = 0; x < pData.colROverdue1.length; x++) {
                        $("#" + gDOMNameROverdue1 + "_" + pData.colROverdue1[x]).prop("checked", true);
                    }
                }
                /* 2ndOD */
                if (pData.colROverdue2) {
                    for (var x = 0; x < pData.colROverdue2.length; x++) {
                        $("#" + gDOMNameROverdue2 + "_" + pData.colROverdue2[x]).prop("checked", true);
                    }
                }
                /* 3rdOD */
                if (pData.colROverdue3) {
                    for (var x = 0; x < pData.colROverdue3.length; x++) {
                        $("#" + gDOMNameROverdue3 + "_" + pData.colROverdue3[x]).prop("checked", true);
                    }
                } 
                /* PastDue */
                if (pData.colExpOverdue) {
                    for (var x = 0; x < pData.colExpOverdue.length; x++) {
                        $("#" + gDOMNameRPastDue + "_" + pData.colExpOverdue[x]).prop("checked", true);
                    }
                }
            } catch (pException) {
                view.txtMessage("Error while building practice checkbox values from user data. " + pException.message);
                global.messageShow("txtMessage", "messageError");
                view.hideLoading();
            }
        },


        bindForm: function () {
            ko.applyBindings(view, $("#view")[0]);
        },


        showRecordCountAll: function () {
            if (!$("#" + gDOMNameRecordHolder).is(":visible")) {
                $("#" + gDOMNameRecordHolderPending).fadeOut(gAnimationTimer, function () {
                    $("#" + gDOMNameRecordHolder).fadeIn(gAnimationTimer);
                });
            }
        },


        showRecordCountPending: function () {
            if (!$("#" + gDOMNameRecordHolderPending).is(":visible")) {
                $("#" + gDOMNameRecordHolder).fadeOut(gAnimationTimer, function () {
                    $("#" + gDOMNameRecordHolderPending).fadeIn(gAnimationTimer);
                });
            }
        },


        showExitMessage: function () {
            if (!$("#" + gDOMNameExitMessage).is(":visible")) {
                $("#" + gDOMNameExitMessage).fadeIn(gAnimationTimer);
            }
            if (view.isPendingOnly) {
                //if (!$("#" + gDOMNamePendingOnlyButton).is(":visible")) {
                //    $("#" + gDOMNamePendingOnlyButton).fadeIn(gAnimationTimer);
                //}
                $("#" + gDOMNamePendingOnlyButton).css("visibility", "visible");
                view.hideNavButtons();
            } else {
                //$("#" + gDOMNamePendingOnlyButton).fadeOut(gAnimationTimer);
                $("#" + gDOMNamePendingOnlyButton).css("visibility", "hidden");
                view.showNavButtons();
            }
        },


        showNavButtons: function () {
            //if (!$("#" + gDOMNameButtonHolder).is(":visible")) {
            //    $("#" + gDOMNameButtonHolder).fadeIn(gAnimationTimer);
            //}
        },


        hideNavButtons: function () {
            //$("#" + gDOMNameButtonHolder).fadeOut(gAnimationTimer);
        },


        hideExitMessage: function () {
            if ($("#" + gDOMNameExitMessage).is(":visible")) {
                $("#" + gDOMNameExitMessage).fadeOut(gAnimationTimer);
            }
            //if (!$("#" + gDOMNamePendingOnlyButton).is(":visible")) {
            //    $("#" + gDOMNamePendingOnlyButton).fadeIn(gAnimationTimer);
            //}
            $("#" + gDOMNamePendingOnlyButton).css("visibility", "visible");
            view.showNavButtons();
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            setTimeout(function () {
                $("#divContainerLoading").fadeOut(gAnimationTimer, function () { kendo.ui.progress($("#divContainerLoading"), false); });
            }, 330);
        },


        processLoading: function () {
            view.countLoading--;
            if (view.countLoading < 1) {
                view.hideLoading();
            } else {
            }
        }
    };


    /* BIND AND INIT FORM */
    view.bindForm();
    view.init();


    /* GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW */
});



