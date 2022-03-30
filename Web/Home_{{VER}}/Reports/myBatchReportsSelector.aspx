<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.master" CodeBehind="myBatchReportsSelector.aspx.vb" Inherits="GRC.Connect.Web.myBatchReportsSelector" %>

<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="Stylesheet" type="text/css" href="../../css/pages/mybatch.css" />

    <%-- ORIGINAL STYLES --%>
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/GRCConnect/connect-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/GRCConnect/connect-icons.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/icons.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeView.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeViewOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindow.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindowOffice2010Blue.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/EDA/cssgrid.css" />

    <link rel="Stylesheet" type="text/css" href="../../css/pages/allreports.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorer.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorerOffice2010Silver.css" />

    <script src="../../Lib_{{VER}}/knockoutkendo/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCNavLink.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCNavLink.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/knockoutkendo/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/RERptJobDef.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/RERptJobDef.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/global.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Data/allReports.js"></script>
    <script src="../../Lib_{{VER}}/pages/allreports.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Carousel/jquery.tinycarousel.js"></script>

    <script type="text/javascript" src="../../Lib_{{VER}}/pages/util_{{VER}}.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- LOADING -->
    <grcRSC:Loader runat="server" id="loader" />


    <div id="view" class="pgBodyContent" style="align-items: center;">
        <div id="MyBatchHolder">
            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="BATCH REPORTS" SubHeader="This tool allows the user to select multiple reports across multiple services and then to select a custom filter and apply optional settings (currency/units).  The system combines all selected reports in the order selected into a single PDF file.  Once the report is complete, the user will receive an email notification along with a link to log in and review the final report here." />
    <div class="messageError" style="text-align: left">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <label id="lblClientMessage"></label>
    </div>
            <div id="divReportListContainer" runat="server" class="" style="width: auto; margin: 12px;">
                <label>The results below are sorted with your most recent requests at the top.&nbsp These files will be available for 30 days.</label>
                <div class="tableDiv" style="padding: 10px; width: 920px; max-height:155px; overflow:auto;">
                    <asp:Repeater ID="rptReportList" runat="server">
                        <HeaderTemplate>
                            <div style="height: 22px; padding-right: 0px; padding-left: 0px; border-bottom: 1px solid black; margin-bottom: 5px;">
                                <span class="mybatch_Column1 mybatch_Heading">
                                    <label>Date Last Modified</label></span>
                                <span class="mybatch_Column2 mybatch_Heading">
                                    <label>File Size</label></span>
                                <span class="mybatch_Column3 mybatch_Heading">
                                    <label>Report Name</label></span>
                            </div>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div style="padding-right: 0px; padding-left: 0px;">
                                <span class="mybatch_Column1">
                                    <asp:Label ID="lblReportDate" runat="server" Text='<%# Container.DataItem.colFldCreateDate%>'></asp:Label></span>
                                <span class="mybatch_Column2">
                                    <asp:Label ID="lblReportSize" runat="server" Text='<%# Container.DataItem.colFldFileSize%>'></asp:Label>&nbsp;MB</span>
                                <span class="mybatch_Column3">
                                    <asp:LinkButton href="#" ID="lnkReportLink" runat="server" ToolTip='<%# Container.DataItem.colFldGuid%>' OnClientClick="getMyBatchReport(this); return false;">
                                        <asp:Label ID="Label1" runat="server" Text='<%# Container.DataItem.colFldFileName%>'></asp:Label><asp:Label ID="Label2" runat="server" Text='<%# Container.DataItem.colFldExtension%>'></asp:Label></asp:LinkButton></span>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
                <div id="sitemapContainer">

                    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
                    <div style="padding-top: 0px; padding-bottom: 4px;">
                        <label class="messageError" data-bind="text: messageError"></label>
                        <label class="messageNotice" data-bind="text: messageNotice"></label>
                        <label class="messageWarning" data-bind="text: messageWarning"></label>
                        &nbsp;
                    </div>

                    <div style="background: #fff;">
                        <p style="padding: 5px;">
                            To submit reports to be run as a batch, select reports then click the <strong>Process Reports</strong> 
                            button to proceed to the Filter and Settings page where you can apply custom filters, 
                            adjust your default Currency/Units, and submit your request.
                        </p>
                        <div style="display: flex; justify-content: space-between; width: 300px; padding-left: 5px; margin-bottom: 5px;">
                            <div id="btnNext" class="grcBlueBtn" onclick="gOnProcessReports();">
                                <label>Process Reports</label>
                            </div>
                            <div id="btnClearAll" class="grcNeutralBtn" onclick="gOnClearCheckboxes();">
                                <label>Clear All</label>
                            </div>
                        </div>
                        <div id="batchReports_slider">
                            <input type="hidden" value="false" id="hidEnableCheckboxes" onchange="hidChange()" />
                            <div class="overview" data-bind="foreach: { data: batchData, includeDestroyed: false }">
                                <div class="batchCell">
                                    <span class="practiceIcon" data-bind="html: $data.iconName"></span>
                                    <div data-bind="html: $data.practiceNameText"></div>
                                    <div data-bind="attr: { id: 'cell' + practiceCode + 'TreeView' }"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- POPUP WINDOW FOR MESSAGES -->
                    <div id="windowReportsMessage" class="windowContent">
                        <label data-bind="text: objLanguageLabels().lblWindowReportsMessageDescription">Please check at least one report before proceeding to the Filters and Settings page.</label>
                        <br />
                        <br />
                        <div class="k-button k-button-padding" style="text-align: center;" data-bind="click: onCloseAll">
                            <label data-bind="text: objLanguageLabels().lblClose">Close</label>
                        </div>
                    </div>

                    <!-- POPUP WINDOW FOR STATUS CONFIRMATION -->
                    <div id="windowReportsStatus" class="windowContent">
                        <label data-bind="text: objLanguageLabels().lblWindowReportsStatusDescription1, visible: messageConfirmVisibleState">Your report has been submitted and is now being processed.  You will be notified when the report job complete and ready for viewing.</label>
                        <label data-bind="text: objLanguageLabels().lblWindowReportsStatusDescription2, visible: messageCancelVisibleState">Your report has been submitted and is now being processed.  You will be notified when the report job complete and ready for viewing.</label>
                        <br />
                        <br />
                        <div class="k-button k-button-padding" style="text-align: center;" data-bind="click: onCloseAll">
                            <label data-bind="text: objLanguageLabels().lblClose">Close</label>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <!--/div-->
        <!-- TEMPLATES FOR SITEMAP CELL ITEMS AND CHECKBOXES -->
        <script id="templateUrl" type="text/x-kendo-templates">
        # if (item.target != undefined && item.url != "") { #
            # if (item.target.toLowerCase() == "_blank") { #
                <a title="#= item.comment #" class="k-in" href="\\#" onclick="openRequestedSinglePopup('#= item.url #')" style="margin-left: -7px;" data-bind="enable: enableCheckboxes">#= item.text #</a>
            # } else { #
                <a title="#= item.comment #" class="k-in" href="#= item.url #" target="#= item.target #" style="margin-left: -7px;" data-bind="enable: enableCheckboxes">#= item.text #</a>
            # } #
        # } else if(item.navEnabled == 0 || item.navEnabled == 'False') { #
        # if (item.reportCode != undefined && item.reportCode != "") { #
                <input type="checkbox" title="#= item.comment #" id="#= item.key #" name="#= item.key #" value="#= item.key #" class="sitemapCheckbox" data-bind="checked: checkedValue, enable: enableCheckboxes" onclick="onGlobalCheckBoxClick(#= item.key #, this.checked)" />
        # } else { #
            # if(item.items != undefined) { #
                <span style="padding: 0px;" title="#= item.comment #"></span>
            # } else { #
                <span style="padding-right: 13px;" title="#= item.comment #"></span>
            # } #
        # } #
            <span title="#= item.comment #">#= item.text #</span>
        # } else { #
        # if (item.reportCode != undefined && item.reportCode != "") { #
                <input type="checkbox" title="#= item.comment #" id="#= item.key #" name="#= item.key #" value="#= item.key #" class="sitemapCheckbox" data-bind="checked: checkedValue, enable: enableCheckboxes" onclick="onGlobalCheckBoxClick(#= item.key #, this.checked)" />
        # } else { #
            # if(item.items != undefined) { #
                <span style="padding: 0px;" title="#= item.comment #"></span>
            # } else { #
                <span style="padding-right: 13px;" title="#= item.comment #"></span>
            # } #
        # } #
            <span title="#= item.comment #">#= item.text #</span>
        # } #
        </script>


        <script type="text/javascript">
            $(document).ready(function () {
                // LOAD SESSION VARIABLES
                var dsLanguageLabels = {
                    lblMainMenu: "Main Menu",
                    lblFire: "Fire",
                    lblBoilerAndMachinery: "Boiler & Machinery",
                    lblInfrared: "Infrared",
                    lblJurisdictional: "Jurisdictional",
                    lblNatHazSeismic: "NatHaz - Seismic",
                    lblNatHazFlood: "NatHaz - Flood",
                    lblNatHazWind: "NatHaz - Wind",
                    lblInstructionsLocationListing: "Note: Choose from any area above to access output reporst on the location level.",
                    lblInstructionsOutputReports: "Note: All output reports above are on a multi-location level.",
                    lblInstructionsDataExtracts: "Note: All data extracts above are on a multi-location level.",
                    lblClearAll: "Clear All",

                    // WINDOWS
                    lblWindowTitleFilters: "Filters and Settings",
                    lblWindowTitleAccept: "Report(s) in Process",
                    lblWindowTitleCancel: "Report(s) Cancelled",
                    lblWindowTitleNoSelection: "No Reports Selected",
                    lblWindowTitleStatus: "Report Status",
                    lblWindowReportsStatusDescription1: "Your report has been submitted and is now being processed.  You will be notified when the report job complete and ready for viewing.",
                    lblWindowReportsStatusDescription2: "The report process has been cancelled.  Please review your report selection and click 'Execute Report(s)' to start again.",
                    lblWindowReportsMessageDescription: "Please check at least one report before proceeding to the Filters and Settings page.",
                    lblCancelWindowDescription: "The report process has been cancelled.  Please review your report selection and click 'Execute Report(s)' to start again.",
                    lblAcceptWindowDescription: "Your report has been submitted and is now being processed.  You will be notified when the report job complete and ready for viewing.",
                    lblNext: "Next",
                    lblCancel: "Cancel",
                    lblClose: "Close",
                    lblNameOfReport: "Name of report",
                    lblProcessReports: "Process Report(s)",
                    lblExecuteReports: "Execute Report(s)",
                    lblWhereApplicable: "(Where Applicable)",
                    lblFilters: "FILTERS",
                    lblSettings: "SETTINGS",
                    lblNotification: "NOTIFICATION",
                    lblNotificationMessageOnly: "Notification Message Only",
                    lblEmailWithReportsInAttachment: "Email with Report(s) in Attachment",
                    lblEmailWithLinkToReports: "Email with Link to Report(s)",

                    // FILTERS
                    lblCustomAccess: "Custom Access",
                    lblDivision: "Division",
                    lblTIV: "TIV",
                    lblTIVValue: "TIV Value",
                    lblHazard: "Hazard",
                    lblInspectionProgramYear: "Inspection Program Year",
                    lblStatus: "Status",
                    lblDateFrom: "Date From",
                    lblDateTo: "Date To",
                    lblCountry: "Country",
                    lblConvertCurrency: "Convert Currency",
                    lblConvertUnits: "Convert Units"
                };


                // VIEWMODEL
                var view = {
                    // DECLARATIONS
                    index: 0,
                    reportSetId: 0,
                    gSafeGUID: getGSafeGUID(),
                    collTemp: new es.objects.RERptJobDefCollection(),
                    messageError: ko.observable(),
                    messageWarning: ko.observable(),
                    messageNotice: ko.observable(),
                    checkedValue: ko.observableArray([]),
                    enableCheckboxes: ko.observable(true),
                    messageConfirmVisibleState: ko.observable(true),
                    messageCancelVisibleState: ko.observable(false),
                    objLanguageLabels: ko.observable(dsLanguageLabels),
                    batchData: ko.observableArray([]),
                    activeServices: ko.observableArray([]),


                    loadPickers: function () {
                    },


                    loadData: function () {
                        view.loadPickers();
                        view.loadActiveServices();
                        view.bindForm();
                    },


                    loadActiveServices: function () {
                        try {
                            var zServiceName = "GetActiveAccountServices";
                            var zParms = ko.toJSON({
                                "pGSafeGuid": view.gSafeGUID
                            });
                            global.callRestServiceCached(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadActiveServicesSuccess, view.loadActiveServicesError, null);
                        } catch (pException) {
                            alert("(201) Error while making the load active services data call. " + pMessage + " - " + pException.message);
                        }
                    },
                    loadActiveServicesSuccess: function (pResults, pParms) {
                        try {
                            if (pResults.isSuccess) {
                                for (var i = 0; i < pResults.data.length; i++) {
                                    if (pResults.data[i].colFldStatus == "Active") {
                                        view.activeServices.push(pResults.data[i]);
                                    }
                                }
                                view.loadBatchLinks();
                            } else {
                                alert("(189) An error occurred while loading active services data: " + pResults.message);
                            }
                        } catch (pException) {
                        }
                    },
                    loadActiveServicesError: function (pResults, pMessage, pErrorDetail, pParms) {
                        alert("(201) Error while making the load active services data call. " + pMessage + " - " + pResults.responseText);
                    },

                    loadBatchLinks: function () {
                        try {
                            var zServiceName = "GetBatchNavLinks";
                            var zParms = ko.toJSON({
                                "pGSafeGuid": view.gSafeGUID
                            });
                            global.callRestServiceCached(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadBatchLinksSuccess, view.loadBatchLinksError, null);
                        } catch (pException) {
                            alert("An error occurred while starting the batch report links data load call: " + pException.message);
                        }
                    },
                    loadBatchLinksSuccess: function (pResults, pParms) {
                        try {
                            if (pResults.isSuccess) {
                                // LOOP THROUGH THE DATA AND CONVERT THE DOWNLOADED JSON OBJECT TO KENDO TREEVIEW CONSUMABLE OBJECT
                                for (var x = 0; x < pResults.data.length; x++) {
                                    if (pResults.data[x].navLinks) {
                                        pResults.data[x].navLinks = buildDataSource(pResults.data[x].navLinks);
                                    }
                                    //CHECK FOR ACTIVE SERVICES
                                    var practiceCode = pResults.data[x].practiceCode;
                                    var tempCode = practiceCode.substr(0, 2);
                                    for (var i = 0; i < view.activeServices().length; i++) {
                                        if (tempCode == view.activeServices()[i].colFldPracticeGroupCode) {
                                            // ASSIGN NEW CONVERTED DATA TO A KNOCKOUT ARRAY
                                            view.batchData.push(pResults.data[x]);
                                        }
                                    }
                                }

                                // ALLOW THE KNOCKOUT FOREACH TO BUILD
                                // BUILD THE KENDO OBJECTS IN EACH FOR LOOP
                                setTimeout(function () {
                                    for (var x = 0; x < view.batchData().length; x++) {
                                        var zId = "cell" + view.batchData()[x].practiceCode + "TreeView";
                                        view.setupKendoTreeview(zId, view.batchData()[x].navLinks);
                                        view.bindTreeviewElement(zId);
                                    }
                                }, 333);
                            } else {
                                alert("(189) An error occurred while loading batch report links data: " + pResults.message);
                            }
                        } catch (pException) {
                            alert("(194) An error occurred while loading batch report links data: " + pException.message);
                        }
                    },
                    loadBatchLinksError: function (pResults, pMessage, pErrorDetail, pParms) {
                        alert("(201) Error while making the load batch report links data call. " + pMessage + " - " + pResults.responseText);
                    },


                    onCheckBoxClick: function (reportId) {
                        // DO NOTHING
                        // THIS FUNCTION NOT USED BECAUSE IT CAUSED STRANGE BEHAVIOUR IN CHECKBOXES
                    },


                    onProcessReports: function () {
                        var parms = "";
                        var tempParms = "";

                        if (view.checkedValue().length > 0) {
                            view.saveNavLinks();

                        } else {
                            // NO REPORTS CHECKED, POP UP A WINDOW TO NOTIFY
                            windowReportsMessage.data("kendoWindow").open();
                            $("#windowReportsMessage").css("display", "block");
                            view.enableCheckboxes(false);
                            $("#btnNext").prop('disabled', true);
                            $("#btnClearAll").prop('disabled', true);
                        }
                    },


                    saveNavLinks: function () {
                        try {
                            var zServiceName = "SetBatchReportNavLink";
                            var zParms = ko.toJSON({
                                "gSafeGuid": view.gSafeGUID,
                                "pNavLinkList": view.checkedValue()
                            });
                            global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.saveNavLinksSuccess, view.saveNavLinksError, null);
                        } catch (pException) {
                            view.messageError("An error occurred while starting save selected reports data call: " + pException.message);
                            global.messageShow("messageError", "messageError");
                        }
                    },
                    saveNavLinksSuccess: function (pResults, pParms) {
                        try {
                            view.messageError("");
                            if (pResults.isSuccess) {
                                var zURL = "../Grids/FilterBatchReports/FilterBatchReports.aspx?sid=" + view.gSafeGUID;
                                window.document.location.href = zURL;
                                //window.open(zURL);
                                //window.document.location.href = "../Grids/FilterBatchReports/FilterBatchReports.aspx?sid=" + view.gSafeGUID;
                            } else {
                                view.messageError("An error occurred while saving selected reports data: " + pResults.message);
                                global.messageShow("messageError", "messageError");
                            }
                        } catch (pException) {
                            view.messageError("An error occurred while saving selected reports data: " + pException.message);
                            global.messageShow("messageError", "messageError");
                        }
                    },
                    saveNavLinksError: function (pResults, pMessage, pErrorDetail, pParms) {
                        view.messageError("Error while saving selected reports data. " + pMessage);
                        global.messageShow("messageError", "messageError");
                    },


                    onContinue: function () {
                        // CLEAR THE CHECKBOXES
                        view.checkedValue([]);
                    },


                    onClearCheckboxes: function () {
                        // CLEAR THE CHECKBOXES
                        view.checkedValue([]);
                    },


                    onCancel: function () {
                    },


                    onCloseAll: function () {
                        windowReportsMessage.data("kendoWindow").close();
                        windowReportsStatus.data("kendoWindow").close();
                        view.enableCheckboxes(true);
                        $("#btnNext").prop('disabled', false);
                        $("#btnClearAll").prop('disabled', false);
                    },


                    onCloseFilters: function () {
                        // DO NOTHING
                    },


                    setupEvents: function () {
                    },


                    setupKendoTreeview: function (pId, pData) {
                        var zId = "#" + pId;
                        // BUILD THE TREEVIEW
                        var zTreeview = $(zId).kendoTreeView({
                            dataSource: pData, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
                        }).data("kendoTreeView");
                        if (zTreeview) {
                            // RESET STYLES FOR LINK UNDERLINE
                            $(zId + " a").each(function () {
                                $(this).css("text-decoration", "underline");
                            });
                            // EXPAND ALL BY DEFAILT    
                            zTreeview.expand(".k-item");
                        }
                    },


                    bindForm: function () {
                        ko.applyBindings(view, $("#sitemapContainer")[0]);
                    },


                    bindTreeviewElement: function (pId) {
                        ko.applyBindings(view, $("#" + pId + " .k-group")[0]);
                    }
                };


                // ACTIVATE BINDINGS LAST AND CREATE CUSTOM BINDINGS
                view.loadData();


                // SETUP NON-TREEVIEW KENDOUI
                // MESSAGE WINDOW
                var windowReportsMessage = $("#windowReportsMessage");
                windowReportsMessage.kendoWindow({
                    width: "300px",
                    height: "120px",
                    title: "", // title added below with JQuery
                    actions: false
                });
                $("#windowReportsMessage").closest(".k-window").css({
                    top: 250,
                    left: 300
                });
                $("#windowReportsMessage").prev().find(".k-window-title").append("<img src='../images/icons/reports/chart_column_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowTitleNoSelection);

                // STATUS WINDOW
                var windowReportsStatus = $("#windowReportsStatus");
                windowReportsStatus.kendoWindow({
                    width: "300px",
                    height: "120px",
                    title: "", // title added below with JQuery
                    actions: false
                });
                $("#windowReportsStatus").closest(".k-window").css({
                    top: 250,
                    left: 300
                });
                $("#windowReportsStatus").prev().find(".k-window-title").append("<img src='../images/icons/reports/chart_column_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowTitleStatus);


                // DISPLAY POPUP IF REQUIRED FROM THE FILTER PAGE
                var tempConfirmPopup = getQueryVariable("r1");
                if (tempConfirmPopup == "1") {
                    view.messageConfirmVisibleState(true);
                    view.messageCancelVisibleState(false);
                    windowReportsStatus.data("kendoWindow").open();
                    $("#windowReportsStatus").css("display", "block");
                    view.enableCheckboxes(false);
                    $("#btnNext").prop('disabled', true);
                    $("#btnClearAll").prop('disabled', true);
                } else if (tempConfirmPopup == "2") {
                    view.messageConfirmVisibleState(false);
                    view.messageCancelVisibleState(true);
                    windowReportsStatus.data("kendoWindow").open();
                    $("#windowReportsStatus").css("display", "block");
                    view.enableCheckboxes(false);
                    $("#btnNext").prop('disabled', true);
                    $("#btnClearAll").prop('disabled', true);
                } else if (tempConfirmPopup == "3") {
                    view.enableCheckboxes(false);
                    $("#btnNext").prop('disabled', true);
                    $("#btnClearAll").prop('disabled', true);
                } else {
                    // DO NOTHING
                }


                // LISTENER FUNCTION FOR HIDDEN VALUE CHANGE
                // THIS FUNCTION IS GLOBAL
                hidChange = function () {
                    if ($("#hidEnableCheckboxes").val() == "true") {
                        view.enableCheckboxes(true);
                        $("#btnNext").prop('disabled', false);
                        $("#btnClearAll").prop('disabled', false);
                    }
                }
                onGlobalCheckBoxClick = function (reportId, isChecked) {
                    if (isChecked) {
                        $("#btnNext").addClass("colorRed");
                    } else {
                        if (view.checkedValue().length < 2) {
                            $("#btnNext").removeClass("colorRed");
                        }
                    }
                    return true;
                }


                /////////////////////////////////
                //// FUNCTIONS TO BUILD DATASOURCES FROM PASSED IN JSON DATA
                function buildDataSource(pData) {
                    var parentId = getParentId(pData);
                    var returnCollection = [];
                    for (y = 0; y < pData.length; y++) {
                        if (pData[y].NavParentLinkId != undefined && pData[y].NavParentLinkId == parentId) {
                            var subMenu = buildSubMenu(pData, pData[y].NavLinkId);
                            if (returnCollection.length == 0) {
                                returnCollection = [{
                                    key: pData[y].NavLinkId,
                                    text: pData[y].NavText,
                                    url: "",
                                    NavUrl: getNavUrl(pData[y].NavUrl),
                                    target: pData[y].NavTarget,
                                    navEnabled: pData[y].NavEnabled,
                                    reportCode: pData[y].NavRptCode,
                                    items: subMenu,
                                    comment: "" //"(NavLinkId: " + pData[y].NavLinkId + ", GridId: " + pData[y].NavGridId + ", ChartId: " + pData[y].NavChartId + ", ReportCode: " + pData[y].NavRptCode + ") " + pData[y].NavStatusToolTip
                                }];
                            } else {
                                returnCollection.push({
                                    key: pData[y].NavLinkId,
                                    text: pData[y].NavText,
                                    url: "",
                                    NavUrl: getNavUrl(pData[y].NavUrl),
                                    target: pData[y].NavTarget,
                                    navEnabled: pData[y].NavEnabled,
                                    reportCode: pData[y].NavRptCode,
                                    items: subMenu,
                                    comment: "" //"(NavLinkId: " + pData[y].NavLinkId + ", GridId: " + pData[y].NavGridId + ", ChartId: " + pData[y].NavChartId + ", ReportCode: " + pData[y].NavRptCode + ") " + pData[y].NavStatusToolTip
                                });
                            }
                        }
                    }
                    return returnCollection;
                }

                function buildSubMenu(pData, NavLinkId) {
                    var returnSubMenu = [];
                    for (x = 0; x < pData.length; x++) {
                        if (NavLinkId == pData[x].NavParentLinkId) {
                            if (returnSubMenu.length == 0) {
                                returnSubMenu = [{
                                    key: pData[x].NavLinkId,
                                    text: pData[x].NavText,
                                    url: "",
                                    NavUrl: getNavUrl(pData[x].NavUrl),
                                    navEnabled: pData[x].NavEnabled,
                                    reportCode: pData[x].NavRptCode,
                                    target: pData[x].NavTarget,
                                    comment: "" //"(NavLinkId: " + pData[x].NavLinkId + ", GridId: " + pData[x].NavGridId + ", ChartId: " + pData[x].NavChartId + ", ReportCode: " + pData[x].NavRptCode + ") " + pData[x].NavStatusToolTip
                                }];
                            } else {
                                returnSubMenu.push({
                                    key: pData[x].NavLinkId,
                                    text: pData[x].NavText,
                                    url: "",
                                    NavUrl: getNavUrl(pData[x].NavUrl),
                                    navEnabled: pData[x].NavEnabled,
                                    reportCode: pData[x].NavRptCode,
                                    target: pData[x].NavTarget,
                                    comment: "" //"(NavLinkId: " + pData[x].NavLinkId + ", GridId: " + pData[x].NavGridId + ", ChartId: " + pData[x].NavChartId + ", ReportCode: " + pData[x].NavRptCode + ") " + pData[x].NavStatusToolTip
                                });
                            }
                        }
                    }
                    return returnSubMenu;
                }

                function getParentId(pData) {
                    for (z = 0; z < pData.length; z++) {
                        if (pData[z].NavParentLinkId == undefined) {
                            return pData[z].NavLinkId;
                        }
                    }
                }

                function getNavUrl(navUrl) {
                    if (navUrl != "" && navUrl != undefined) {
                        if (navUrl.indexOf("?") > 0) {
                            return navUrl + "&sid=" + view.gSafeGuid;
                        } else {
                            return navUrl + "?sid=" + view.gSafeGuid;
                        }
                    } else {
                        return "";
                    }
                }


                // GLOBAL FUNCTIONS TO REDIRECT FROM MASTER
                gOnClearCheckboxes = function () {
                    view.onClearCheckboxes();
                }

                gOnProcessReports = function () {
                    view.onProcessReports();
                }
            });


            function getMyBatchReport(pFile) {
                $("#lblClientMessage").html("");
                var zGSafeGUID = getGSafeGUID();
                var zFileGUID = pFile.title;
                var zURL = "../FD/ServeBatchReport.ashx?pGSafeGUID=" + getGSafeGUID() + "&pFileGUID=" + zFileGUID;
                window.location.href = zURL;
                return false;
            }



        </script>
</asp:Content>
