<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PreFilter.aspx.vb" Inherits="GRC.Connect.Web.PreFilter_ProgramStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta charset="utf-8" />
    <meta http-equiv="CACHE-CONTROL" content="NO-STORE" />
    <meta http-equiv="PRAGMA" content="NO-CACHE" />
    <meta name="EXPIRES" content="0" />
    <meta name="VERSION" content="{{VER}}" />

    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeView.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeViewOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorer.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorerOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindow.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindowOffice2010Blue.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Utilities/utilities.css" />

    <%--<script src="../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/JQuery/jQuery.3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <%--<script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.web.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.all.min.js" type="text/javascript"></script>--%>
    <%--<script src="../../Lib_{{VER}}/kendo.web.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/kendo.all.min.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/kendo.all.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/knockoutkendo.v0.9.3/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery.hoverIntent.v1.8.0/jquery.hoverIntent.minified.js"></script>
    <script src="../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>

    <style type="text/css">
        .columnLabel
        {
            width: 125px;
            margin-bottom: 4px;
        }
        .columnInput
        {
            width: 200px;
            margin-bottom: 4px;
        }
        .columnFull
        {
            width: 325px;
            text-align: center;
            line-height: normal;
        }
    </style>
</head>
<body class="windowPleaseWait_Body">

    <form id="form1" runat="server">

        <asp:HiddenField ID="hidReportUrlBase" ClientIDMode="Static" runat="server" Value="" />
        <asp:HiddenField ID="hidFilters" ClientIDMode="Static" runat="server" Value="Wookiees" />

        <div id="" class="windowPleaseWait_Content">

            <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
                </Scripts>
            </telerik:RadScriptManager>

            <div id="divTablePleaseWait" runat="server" style="text-align: center; width: auto;">
                <div id="divTextContent1" class="prefilterRow">
                    <label id="lblMessage1">Requests are generally completed within one minute.</label>
                </div>
                <br />
                <div id="divTextContent2" class="prefilterRow">
                    <img src="../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px; vertical-align: middle;" alt="GRC Client Connect - Please Wait" />
                    Thank you for your patience.
                </div>
                <br />&nbsp;<br />&nbsp;<br />
                <div style="text-align: center;" class="prefilterRow">
                    <input type="button" class="grcNeurtalBtn" onclick="closeWindow()" value="Close Window" id="btnSingleReportClose" disabled="disabled" />
                </div>
            </div>

            <!-- PLEASE WAIT WINDOW FOR PROGRAM STATUS -->
            <div id="divTablePleaseWaitProgramStatus" style="text-align: center; width: auto; display: none;">
                <div id="divTextContent1ProgramStatus" class="prefilterRow">
                    <img src="../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px; vertical-align: middle;" alt="GRC Client Connect - Please Wait" />
                    <label id="lblMessageProgramStatus">Your request is being processed</label>
                </div>
                <br />
                <div id="divTextContent2ProgramStatus" class="prefilterRow">
                    Thank you for your patience while the Program Status
                    <br />web page is being built.
                    <br />&nbsp;<br />
                    As this tool provides a statistical view of your entire program,
                    <br />this may take a few minutes.
                </div>
                <br />&nbsp;<br />&nbsp;<br />
                <div style="text-align: center;">
                    <input type="button" class="grcNeurtalBtn" onclick="cancelProgramStatus(); return false;" value="Cancel" id="btnSingleReportProgramStatusClose" />
                </div>
            </div>


            <div id="divTablePrefilters" runat="server" style="width: 100%;">
                <div class="prefilterHeaderTxt">
                    Click the drop-down menus below if you wish to apply a filter or change a setting.
                </div>
                <div runat="server" id="divCustomAccess" class="prefilterRow">
                    <span class="">
                        <asp:Label runat="server" id="lblCustomAccess">Custom Access</asp:Label>
                    </span>
                    <span class="">
                        <telerik:RadComboBox ID="cboCustomAccess" runat="server"></telerik:RadComboBox>
                    </span>
                </div>
                <div runat="server" id="divDivision" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblDivision">Division</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboDivision" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divInspectionProgramYear" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblInspectionProgramYear">Inspection Program Year</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboInspectionProgramYear" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divCurrency" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblCurrency">Currency</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboCurrency" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divTIV" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblTIV">TIV</asp:Label></span>
                    <span class="columnInput"><telerik:RadComboBox ID="cboTIV" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divUnits" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblUnits">Units</asp:Label></span>
                    <span class="columnInput"><telerik:RadComboBox ID="cboUnits" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divStatus" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblStatus">Status</asp:Label></span>
                    <span class="columnInput"><telerik:RadComboBox ID="cboStatus" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divDateFrom" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblDateFrom">Date From</asp:Label></span>
                    <span class="columnInput"><telerik:RadDatePicker ID="dteDateFrom" runat="server"></telerik:RadDatePicker></span>
                </div>
                <div runat="server" id="divDateTo" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblDateTo">Date To</asp:Label></span>
                    <span class="columnInput"><telerik:RadDatePicker ID="dteDateTo" runat="server"></telerik:RadDatePicker></span>
                </div>
                <div runat="server" id="divHazard" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblHazard">Hazard</asp:Label></span>
                    <span class="columnInput"><telerik:RadComboBox ID="cboHazard" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divCountry" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblCountry">Country</asp:Label></span>
                    <span class="columnInput"><telerik:RadComboBox ID="cboCountry" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divTIVValue" class="prefilterRow">
                    <span class="columnLabel"><asp:Label runat="server" id="lblTIVValue">TIV Value</asp:Label></span>
                    <span class="columnInput"><telerik:RadComboBox ID="cboTIVValue" runat="server"></telerik:RadComboBox></span>
                </div>
                
                <div runat="server" id="divSubmit" class="prefilterBtnHldr">
                    <asp:Button ID="cmdSubmit" runat="server" Text="Submit" CssClass="grcBlueBtn" Width="75px" onclientclick="hidePreFilters()"></asp:Button>
                    <button style="width: 75px; margin-left: 12px;" class="grcNeutralBtn" onclick="closeWindow(); return false;">Cancel</button>
                </div>
                <div>
                    <span class="messageBlack" style="line-height: normal;">
                        <strong>Note:</strong> If you are not seeing all available data options above, check your preferences to see if you have a filter or setting applied.
                        <br /><br />
                        If one is applied, you will see the word <font class="messageErrorNoBold">(Applied)</font> in red under the myPreferences icon.
                    </span>
                </div>
                <div>
                    <span style="height: 20px;">&nbsp;</span>
                </div>
            </div>

        </div>
    </form>
</body>

<script type="text/javascript">
    // REDIRECT CLIENT SIDE SO PLEASE WAIT MESSAGE IS DISPLAYED
    $(document).ready(function () {
        // SET THE TITLE TO ERROR MESSAGE
        var tempWindow = GetRadWindow();
        var noPrefilters = "<%= ServerSide_NoPrefilters %>";
        if (noPrefilters.toLocaleLowerCase() == "true") {
            setTimeout(function () {
                var reportUrl = "<%= ServerSide_ReportUrl%>";
                tempWindow.setUrl("../../Home_{{VER}}/Reports/blank.aspx");
                tempWindow.close();
                openRequestedSinglePrefilterPopup(reportUrl);
            }, 1500);
        } else {
            var newHeight = $("#divTablePrefilters").height() + 145;
            tempWindow.set_height(newHeight + "px");
            tempWindow.set_title("Select A Prefilter");
        }
    });

    function closeWindow() {
        var tempWindow = GetRadWindow();
        tempWindow.setUrl("../../Home_{{VER}}/Reports/blank.aspx");
        tempWindow.close();
    }

    function hidePreFilters() {
        var zFormDelay = 1;
        setTimeout(function () {
            var tempWindow = GetRadWindow();
            var newHeight = $("#divTablePrefilters").height() + 75;
            tempWindow.set_height(newHeight + "px");
            tempWindow.set_title("Your Request Is Being Processed");

            // BUILD THE URL WITH LIST OF OPTIONS
            var GSafeGuid = getGSafeGUID();
            var filters = buildReportURL();
            var reportUrlBase = "<%= ServerSide_ReportUrlBase%>";
            if (reportUrlBase === undefined || reportUrlBase === null || reportUrlBase.length < 1) {
                alert("Sorry for the inconvenience.  This report is temporarily unavailable.  We are working to resolve this.  Please try again later.");
                closeWindow();
            } else {

                // DO NOT FORWARD OR REDIRECT HERE, MUST BE DONE SERVER SIDE

            }

            //if (reportUrlBase.indexOf("ProgramStatus") != -1) {
            //    openProgramStatusPage(reportUrlBase + filters);
            //} else if (reportUrlBase.indexOf("AutoRecommendation") != -1) { // "RecFollowUpStatus"
            //    openRecFollowUpStatusPage(reportUrlBase + filters);
            //} else {
            //    openRequestedSinglePrefilterPopup(reportUrlBase + filters);
            //    closeWindow();
            //}
        }, 1);
    }

    function openProgramStatusPage(strUrl, navLinkId) {
        var tempWindow = GetRadWindow();
        tempWindow.BrowserWindow.openProgramStatusPageParent(strUrl);
        closeWindow();
    }

    function openRecFollowUpStatusPage(strUrl, navLinkId) {
        var tempWindow = GetRadWindow();
        tempWindow.BrowserWindow.openRecFollowUpStatusPageParent(strUrl);
        closeWindow();
    }

    function cancelProgramStatus() {
        var GSafeGuid = getGSafeGUID();
        var zUrl = "../../Home_{{VER}}/Gauge/Default.aspx?sid=" + GSafeGuid;
        window.top.location.href = zUrl;
        closeWindow();
    }

    function GetRadWindow() {
        var oWindow = null;
        if (window.radWindow) {
            oWindow = window.radWindow;
        } else if (window.frameElement.radWindow) {
            oWindow = window.frameElement.radWindow;
        }
        return oWindow;
    }

    function openRequestedSinglePrefilterPopup(strUrl) {
        var windowObjectReference = null;
        var PreviousUrl;
        if (windowObjectReference == null || windowObjectReference == undefined || windowObjectReference.closed) {
            // IF THE WINDOW DOWN NOT EXIST, OPEN A NEW ONE
            windowObjectReference = window.open(strUrl, "SingleSecondaryWindowName", "resizable=yes,scrollbars=yes,status=yes");
            setTimeout(function () {
                windowObjectReference.focus();
            }, 1000);
        }
        else if (PreviousUrl != strUrl) {
            // IF THE WINDOW EXISTS AND THE URL IS NEW, CHANGE THE URL OF THE OPEN WINDOW
            windowObjectReference.location.href = strUrl;
            setTimeout(function () {
                windowObjectReference.focus();
            }, 1000);
        }
        else {
            // IF THE WINDOW EXISTS AND THE URL IS THE SAME, MAKE WINDOW ON TOP
            setTimeout(function () {
                windowObjectReference.focus();
            }, 1000);
        };
        PreviousUrl = strUrl;
    }

    function openPleaseWaitPopup(strUrl) {
        var windowObjectReference = null;
        var PreviousUrl;
        if (windowObjectReference == null || windowObjectReference == undefined || windowObjectReference.closed) {
            // IF THE WINDOW DOWN NOT EXIST, OPEN A NEW ONE
            windowObjectReference = window.open(strUrl, "SingleSecondaryWindowName", "resizable=yes,scrollbars=yes,status=yes");
            setTimeout(function () {
                windowObjectReference.focus();
            }, 1000);
        }
        else if (PreviousUrl != strUrl) {
            // IF THE WINDOW EXISTS AND THE URL IS NEW, CHANGE THE URL OF THE OPEN WINDOW
            windowObjectReference.location.href = strUrl;
            setTimeout(function () {
                windowObjectReference.focus();
            }, 1000);
        }
        else {
            // IF THE WINDOW EXISTS AND THE URL IS THE SAME, MAKE WINDOW ON TOP
            setTimeout(function () {
                windowObjectReference.focus();
            }, 1000);
        };
        PreviousUrl = strUrl;
    }

    function removeInvalidChars(str) {
        var returnStr = str
        returnStr = returnStr.replace("(All)", "All"); // REMOVE PARENS FROM DEFAULT ALL
        returnStr = returnStr.replace("%", "%25"); // % MUST BE DONE FIRST
        returnStr = returnStr.replace(" ", "%20");
        returnStr = returnStr.replace("$", "%24");
        returnStr = returnStr.replace("&", "%26");
        returnStr = returnStr.replace("+", "%2B");
        returnStr = returnStr.replace(",", "%2C");
        returnStr = returnStr.replace("/", "%2F");
        returnStr = returnStr.replace(":", "%3A");
        returnStr = returnStr.replace(";", "%3B");
        returnStr = returnStr.replace("=", "%3D");
        returnStr = returnStr.replace("?", "%3F");
        returnStr = returnStr.replace("@", "%40");
        returnStr = returnStr.replace("\"", "%22");
        returnStr = returnStr.replace("<", "%3C");
        returnStr = returnStr.replace(">", "%3E");
        returnStr = returnStr.replace("#", "%23");
        returnStr = returnStr.replace("\\", "%5C");
        return returnStr;
    }

    function buildReportURL() {
        var returnUrl = "";
        var domObject;
        var msg = ""
        // READ THROUGH EACH DROP DOWN AND SAVE THE OPTION THE USER SELECTED
        if ($("#divCustomAccess").html()) {
            domObject = $find("<%= cboCustomAccess.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&CustomAccess=" + msg;
        } else {
            // CUSTOM ACCESS IS ALWAYS ON
            returnUrl = returnUrl + "&CustomAccess=All";
        }
        if ($("#divDivision").html()) {
            domObject = $find("<%= cboDivision.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&Division=" + msg;
        }
        if ($("#divInspectionProgramYear").html()) {
            domObject = $find("<%= cboInspectionProgramYear.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = ""; }
            returnUrl = returnUrl + "&InspectionProgramYear=" + msg;
        }
        if ($("#divCurrency").html()) {
            domObject = $find("<%= cboCurrency.ClientID %>");
            msg = domObject.get_text();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&Currency=" + msg;
        }
        if ($("#divTIV").html()) {
            domObject = $find("<%= cboTIV.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&TIV=" + msg;
        }
        if ($("#divUnits").html()) {
            domObject = $find("<%= cboUnits.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&Units=" + msg;
        }
        if ($("#divStatus").html()) {
            domObject = $find("<%= cboStatus.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&Status=" + msg;
        }
        if ($("#divDateFrom").html()) {
            domObject = $find("<%= dteDateFrom.ClientID %>");
            if (domObject.get_value) {
                msg = domObject.get_value();
            } else if (domObject.get_focusedDate) {
                msg = domObject.get_focusedDate();
            }
            //msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "1-Jan-1980"; }
            returnUrl = returnUrl + "&DateFrom=" + msg;
        }
        if ($("#divDateTo").html()) {
            domObject = $find("<%= dteDateTo.ClientID %>");
            if (domObject.get_value) {
                msg = domObject.get_value();
            } else if (domObject.get_focusedDate) {
                msg = domObject.get_focusedDate();
            }
            //msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "31-Dec-2999"; }
            returnUrl = returnUrl + "&DateTo=" + msg;
        }
        if ($("#divHazard").html()) {
            domObject = $find("<%= cboHazard.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&Hazard=" + msg;
        }
        if ($("#divCountry").html()) {
            domObject = $find("<%= cboCountry.ClientID %>");
            msg = domObject.get_value();
            msg = removeInvalidChars(msg);
            if (msg == undefined || msg == "") { msg = "All"; }
            returnUrl = returnUrl + "&CustomAccess=" + msg;
        }
        if ($("#divTIVValue").html()) {
            domObject = $find("<%= cboTIVValue.ClientID %>");
            msg = domObject.get_value();
            if (msg == undefined || msg == "") { msg = "All"; }
            msg = removeInvalidChars(msg);
            returnUrl = returnUrl + "&TIVValue=" + msg;
        }
        return returnUrl;
    }

</script>

</html>
