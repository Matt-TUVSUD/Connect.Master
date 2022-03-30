<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="PreFilter.aspx.vb" Inherits="GRC.Connect.Web.PreFilter" %>

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
        .columnFull
        {
            width: 325px;
            text-align: center;
            line-height: normal;
        }

        .RadWindow_Flom .rwTable .rwControlButtons li a {
    background-image: url(https://d35islomi5rx1v.cloudfront.net/ajaxz/2018.2.710/Silk/Common/radActionsSprite.png);
    width: 28px;
    height: 28px;
    margin: 0 2px;
}
 
.RadWindow_Flom a.rwCloseButton {
    background-position: -11px -1911px;
}

.RadWindow .rwCloseButton:before {
    content: "\e11b";
}
.RadWindow .rwCommandButton:before {
    content: "";
    margin: auto;
    padding: 0;
    display: inline-block;
    font: 16px/1 "WebComponentsIcons";
    text-align: center;
    vertical-align: top;
}
    </style>
</head>
<body class="windowPleaseWait_Body">

    <form id="form1" runat="server">
        <div id="" class="windowPleaseWait_Content">

            <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
                </Scripts>
            </telerik:RadScriptManager>
    
            <div id="divTablePleaseWait" style="text-align: center; width: auto; display: none;">
                <div id="divTextContent1" class="prefilterRow">
                    <label id="lblMessage1">Requests are generally completed within one minute.</label>
                </div>
                <br />
                <div id="divTextContent2" class="prefilterRow">
                    <img src="../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px; vertical-align: middle;" alt="TUV SUD GRC Client Connect - Please Wait" />
                    Thank you for your patience.
                </div>
                <br />&nbsp;<br />&nbsp;<br />
                <div style="text-align: center;" class="prefilterRow">
                    <input type="button" class="grcNeutralBtn" onclick="closeWindow()" value="Close Window" id="btnSingleReportClose" disabled="disabled" />
                </div>
            </div>

            <div id="divTablePrefilters" style="width: 100%;">
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
                    <span class=""><asp:Label runat="server" id="lblTIV">TIV</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboTIV" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divUnits" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblUnits">Units</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboUnits" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divStatus" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblStatus">Status</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboStatus" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divDateFrom" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblDateFrom">Date From</asp:Label></span>
                    <span class=""><telerik:RadDatePicker ID="dteDateFrom" runat="server"></telerik:RadDatePicker></span>
                </div>
                <div runat="server" id="divDateTo" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblDateTo">Date To</asp:Label></span>
                    <span class=""><telerik:RadDatePicker ID="dteDateTo" runat="server"></telerik:RadDatePicker></span>
                </div>
                <div runat="server" id="divHazard" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblHazard">Hazard</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboHazard" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divCountry" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblCountry">Country</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboCountry" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divTIVValue" class="prefilterRow">
                    <span class=""><asp:Label runat="server" id="lblTIVValue">TIV Value</asp:Label></span>
                    <span class=""><telerik:RadComboBox ID="cboTIVValue" runat="server"></telerik:RadComboBox></span>
                </div>
                <div runat="server" id="divSubmit" class="prefilterBtnHldr" style="">
                    <asp:Button ID="cmdSubmit" runat="server" Text="Submit" CssClass="grcBlueBtn" Width="75px" OnClientClick="hidePreFilters()"></asp:Button>
                    <button style="width: 75px; margin-left: 12px;" class="grcNeutralBtn" onclick="closeWindow(); return false;">Cancel</button>
                </div>
                <div class="messageBlack" style="margin-top:10px;">
                    <strong>Note:</strong> If you are not seeing all available data options above, check your preferences to see if you have a filter or setting applied.
                        <br />
                    <br />
                    If one is applied, you will see the word <span class="messageErrorNoBold">(Applied)</span> in red under the myPreferences icon.
                </div>
            </div>
        </div>
    </form>
</body>

<script type="text/javascript">
    //// REDIRECT CLIENT SIDE SO PLEASE WAIT MESSAGE IS DISPLAYED
    $(document).ready(function () {
        //// SET THE TITLE TO ERROR MESSAGE
        var tempWindow = GetRadWindow();
        var newHeight = $("#divTablePrefilters").height() + 145;
        tempWindow.set_height(newHeight + "px");
        tempWindow.set_title("Select A Prefilter");
        $("#divTablePrefilters").show();
        $("#divTablePleaseWait").hide();
    });

    function closeWindow() {
        var tempWindow = GetRadWindow();
        var levels = "<%= LevelsDeep%>";
        var blankUrl = "../../Reports/blank.aspx"
        if (levels == 1) { blankUrl = "../Reports/blank.aspx"; }
        tempWindow.setUrl(blankUrl);
        tempWindow.close();
    }

    function hidePreFilters() {
        setTimeout(function() {
            var tempWindow = GetRadWindow();
            var newHeight = $("#divTablePrefilters").height() + 75;
            tempWindow.set_height(newHeight + "px");
            tempWindow.set_title("Your Request Is Being Processed");
        }, 250);
    }

    function GetRadWindow() {
        //Reports Root
        var oWindow = null;
        if (window.radWindow) {
            oWindow = window.radWindow;
        } else if (window.frameElement.radWindow) {
            oWindow = window.frameElement.radWindow;
        }
        oWindow.set_modal(true);
        return oWindow;
    }
</script>

</html>
