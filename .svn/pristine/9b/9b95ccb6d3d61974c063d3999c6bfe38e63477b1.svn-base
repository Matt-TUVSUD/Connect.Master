<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReportFetch.aspx.vb" Inherits="GRC.Connect.Web.ReportFetch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
    <script src="../../Lib_{{VER}}/pages/global.js" type="text/javascript"></script>
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
    <div id="" class="windowPleaseWait">
        <div class="windowPleaseWait_Content" id="divTablePleaseWait"style="text-align: center;">
            <div id="divTextContent1" class="prefilterRow">
                <label id="lblMessage1">Requests are generally completed within one minute.</label>
            </div>
            <div id="divTextContent2" class="prefilterRow">
                <img src="../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px; vertical-align: middle;" alt="TUV SUD GRC Client Connect - Please Wait" />
                Thank you for your patience.
            </div>
            <div style="width: auto;" class="prefilterBtnHldr">
                <input type="button" class="grcNeutralBtn" onclick="closeWindow()" value="Close Window" id="btnSingleReportClose" disabled="disabled" />
            </div>
        </div>
    </div>

    <script type="text/javascript">
        // REDIRECT CLIENT SIDE SO PLEASE WAIT MESSAGE IS DISPLAYED
        $(document).ready(function () {
            callReportHandler();
        });


        function callReportHandler () {
            try {
                var zGUID = "<%= ServerSide_GUID %>";
                var zRptCode = "<%= ServerSide_ReportCode %>";
                var zP2 = "<%= ServerSide_P2 %>";
                var zP3 = "<%= ServerSide_P3 %>";
                var zURL = "<%= ServerSide_URL %>";

                // FOR WORKING DIRECTLY WITH HANDLER, WORKS BUT CANNOT DISPLAY WHEN DONE
                //window.location.href = zURL;

                // FOR CALLING THE HANDLER WITH A FORM
                //buildReportDownloadLink(zURL);
                //window.location.href = "ReportComplete.aspx";
                GetRadWindow().BrowserWindow.document.location.href = zURL;
                convertWindow();

            } catch (pException) {
                alert("An error occurred while creating the fetch report call: " + pException.message);
            }
        }


        function convertWindow() {
            // SET THE TITLE TO ERROR MESSAGE AND ENABLE BUTTON AND SET LABELS
            var tempWindow = GetRadWindow();
            var newHeight = $("#divTablePleaseWait").height() + 75;
            tempWindow.set_height(newHeight + "px");
            tempWindow.set_title("Your Request Is Being Processed");
            $("#lblMessage1").text("Your report will be ready and available for download shortly.  Do not navigate away from this page.");
            $("#divTextContent2").hide();
            $("#btnSingleReportClose").removeAttr("disabled");
        }

        function closeWindow() {
            var tempWindow = GetRadWindow();
            var levels = "<%= LevelsDeep%>";
            var blankUrl = "../../Reports/blank.aspx"
            if (levels == 1) { blankUrl = "../Reports/blank.aspx"; }
            tempWindow.setUrl(blankUrl);
            tempWindow.close();
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

    </script>

</body>
</html>
