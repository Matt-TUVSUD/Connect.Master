var gSafeGuid = getGSafeGUID();

$(document).ready(function () {
    var viewHeader = {
        myPrefLinkUrl: ko.observable(SITEBASEURL + "Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" + gSafeGuid),
        contactUsLnkUrl: ko.observable(SITEBASEURL + "Home_{{VER}}/Contact/Default.aspx?sid=" + gSafeGuid),
        videosLnkUrl: ko.observable(SITEBASEURL + "Home_{{VER}}/KnowledgeBase/videos.aspx?sid=" + gSafeGuid),
        notificationsWindow: ko.observable(),
        logoURL: ko.observable(SITEBASEURL + "Home_{{VER}}/Controls/50x50_GRCLogo.png"),
        knowledgeBaseURL: ko.observable(SITEBASEURL + "Home_{{VER}}/KnowledgeBase/index.html"),
        logOutURL: ko.observable(SITEBASEURL + "Home_{{VER}}/Logout/Default.aspx?sid=" + gSafeGuid),
        userGUID: ko.observable(),

        init: function () {
            if(getGSafeGUID().length > 0){
                viewHeader.userGUID(getGSafeGUID());
                viewHeader.setupKendo();
                viewHeader.loadUpdates();
            }
        },

        //POPULATE UPDATES WINDOW
        loadUpdates: function () {
            try {
                var zServiceName = "GetAllMenuItems";
                var zParms = ko.toJSON({
                    "pGSafeGuid": viewHeader.userGUID(),
                    "pPageType": "side"
                });
                global.callRestServiceCached(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewHeader.loadUpdatesSuccess, viewHeader.loadUpdatesError, null);
            } catch (pException) {
                global_hideLoading();
                alert("An error occurred while starting the updates window data load call: " + pException.message);
            }
        },
        loadUpdatesSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    // LOOP THROUGH THE MENU ITEMS AND DETERMINE IF WE NEED TO ADD A RED BOLD STYLE
                    var breakCounter = 0;
                    var maxBreakCounter = 3;
                    if (pResults.isRedRecentUpdates || pResults.isRedWhatsNew || pResults.isRedMyBatchReports) {
                        //IF ANY OF THE ABOVE CONDITIONS ARE MET, DISPLAY NOTIFICATION ICON
                        if (!pResults.isRedRecentUpdates) { breakCounter++; }
                        if (!pResults.isRedWhatsNew) { breakCounter++; }
                        if (!pResults.isRedMyBatchReports) { breakCounter++; }
                        //Skip the first 3 menu items
                        for (i = 2; i < pResults.data.length; i++) {
                            var zFound = false;
                            var zCount = "";
                            var zCountText = "";
                            var zText = "";
                            var zStr = "";
                            var zStrMenu = "";
                            var zStrNotice = "";
                            var zStrAnchor = "";

                            if (pResults.data[i].items !== null && pResults.data[i].items != undefined) {
                                for (j = 0; j < pResults.data[i].items.length; j++) {
                                    if (pResults.isRedWhatsNew && pResults.data[i].items[j].NavLinkId == "27") {
                                        //WhatsNew
                                        breakCounter++;
                                        zFound = true;
                                        zStr = pResults.data[i].items[j].text;
                                        zCount = numeral(pResults.WhatsNewCount).format("0,0");
                                        zStrAnchor = "What's New";
                                        zText = pResults.textWhatsNew;
                                    }
                                    if (pResults.isRedMyBatchReports && pResults.data[i].items[j].NavLinkId == "684") {
                                        //myBatchReports
                                        breakCounter++;
                                        zFound = true;
                                        zStr = pResults.data[i].items[j].text;
                                        zCount = numeral(pResults.MyBatchReportNewCount).format("0,0");
                                        zStrAnchor = "Batch Reports";
                                        zText = pResults.textMyBatchReports;
                                    }
                                    if (zFound) {
                                        // IF WE FOUND ONE OF THE ITEMS, CHANGE THE TEXT AND APPEND IT TO THE UPDATES WINDOW  
                                        // BUILD THE UPDATES WINDOW TEXT 
                                        zCountText = zStr.substring(0, zStr.lastIndexOf("class='")) + zStr.substring(zStr.lastIndexOf("class='"), zStr.indexOf("'", zStr.lastIndexOf("class='")) + 7) + " colorBlue " + zStr.substring(zStr.indexOf("'", zStr.lastIndexOf("class='")) + 7);
                                        zCountText = zCountText.replace(zStrAnchor, zCount)
                                        zStrNotice = zStrNotice + "<div class='updateWindowRow'>";
                                        zStrNotice = zStrNotice + "<span class='colorBlack'>" + zText + "</span>";
                                        zStrNotice = zStrNotice + "&nbsp;&nbsp;";
                                        zStrNotice = zStrNotice + "<span class=''>" + zCountText + "</span>";
                                        zStrNotice = zStrNotice + "</div>";
                                        zStrNotice = viewHeader.removeStringElement(zStrNotice, "label");
                                        $("#updatesContent").append(zStrNotice);
                                        $('#notificationBell').removeClass('noShow');
                                        zFound = false;
                                        zStrNotice = "";
                                    }
                                    if (breakCounter >= maxBreakCounter) { /*Break out of the For loop once all three criteria are verified*/ break; }
                                }
                            } else if (pResults.isRedRecentUpdates && pResults.data[i].NavLinkId == "964") {
                                //RecentUpdates
                                breakCounter++;
                                zFound = true;
                                zStr = pResults.data[i].text;
                                zCount = numeral(pResults.RecentUpdateNewCount).format("0,0");
                                zStrAnchor = "Document Library";
                                zText = pResults.textRecentUpdates;

                                if (zFound) {
                                    // IF WE FOUND ONE OF THE ITEMS, CHANGE THE TEXT AND APPEND IT TO THE UPDATES WINDOW  
                                    // BUILD THE UPDATES WINDOW TEXT 
                                    zCountText = zStr.substring(0, zStr.lastIndexOf("class='")) + zStr.substring(zStr.lastIndexOf("class='"), zStr.indexOf("'", zStr.lastIndexOf("class='")) + 7) + " colorBlue " + zStr.substring(zStr.indexOf("'", zStr.lastIndexOf("class='")) + 7);
                                    zCountText = zCountText.replace(zStrAnchor, zCount)
                                    zStrNotice = zStrNotice + "<div class='updateWindowRow'>";
                                    zStrNotice = zStrNotice + "<span class='colorBlack'>" + zText + "</span>";
                                    zStrNotice = zStrNotice + "&nbsp;&nbsp;";
                                    zStrNotice = zStrNotice + "<span class=''>" + zCountText + "</span>";
                                    zStrNotice = zStrNotice + "</div>";
                                    zStrNotice = viewHeader.removeStringElement(zStrNotice, "label");
                                    $("#updatesContent").append(zStrNotice);
                                    $('#notificationBell').removeClass('noShow');
                                }
                            }
                            
                            if (breakCounter >= maxBreakCounter) { /*Break out of the For loop once all three criteria are verified*/ break; }
                        }
                    }

                    // PROCESS THE COUNT
                    global_processLoading();
                } else {
                    global_hideLoading();
                    alert("(806) An error occurred while loading updates window data: " + pResults.message);
                }
            } catch (pException) {
                global_hideLoading();
                alert("(811) An error occurred while loading updates window data: " + pException.message);

            }
            global_processLoading();
        },
        loadUpdatesError: function (pResults, pMessage, pErrorDetail, pParms) {
            global_hideLoading();
            alert("(818) Error while making the load updates window data call. " + pMessage + " - " + pResults.responseText);
        },

        removeStringElement: function (text, tagSelector) {
            var tempTxt = "<div class='updateWindowRow'>";
            var tempString = $(text);
            tempString.find(tagSelector).remove();
            tempTxt = tempTxt + tempString[0].innerHTML + "</div>";
            return tempTxt;
        },

        setupKendo: function () {
            $('#notificationWindow').kendoWindow({
                visible: false,
                title: "Updates",
                actions: ["Close"],
                width: "355px",
                height: "150px",
                modal: true,
                draggable: false,
                resizable: false
            });

            viewHeader.notificationsWindow = $('#notificationWindow').data("kendoWindow");
        },

        notificationClick: function () {
            viewHeader.notificationsWindow.center().open();
        },

        bindForm: function () {
            ko.applyBindings(viewHeader, $("#viewHeader")[0]);
        },
    }

    viewHeader.bindForm();
    viewHeader.init();
});

function homeLinkClick() {
    //document.location.href = SITEBASEURL + "Home_{{VER}}/gauge/default.aspx" + "?sid=" + gSafeGuid;
}