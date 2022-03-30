<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ChartFetch.aspx.vb" Inherits="GRC.Connect.Web.ChartFetch" %>

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
            <div id="divTextContent1">
                <label id="lblMessage1">Requests are generally completed within one minute.</label>
            </div>
            <br />
            <div id="divTextContent2">
                <img src="../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px; vertical-align: middle;" alt="TUV SUD GRC Client Connect - Please Wait" />
                Thank you for your patience.
            </div>
            <br />&nbsp;<br />&nbsp;<br />
            <%--<div style="text-align: center;">
                <input type="button" class="k-button k-button-padding" onclick="closeWindow()" value="Close Window" id="btnSingleReportClose" disabled="disabled" />
            </div>
            <br />&nbsp;<br />&nbsp;<br />--%>
        </div>
    </div>

    <script type="text/javascript">

        // REDIRECT CLIENT SIDE SO PLEASE WAIT MESSAGE IS DISPLAYED
        $(document).ready(function () {
            var zFormDelay = 1;
            setTimeout(function () {
                try {
                    var tempWindow = GetRadWindow();
                    //var newHeight = $("#divTablePrefilters").height() + 75;
                    //tempWindow.set_height(newHeight + "px");
                    tempWindow.set_title("Your Request Is Being Processed");

                    // BUILD THE URL WITH LIST OF OPTIONS
                    var GSafeGuid = getGSafeGUID();
                    var filters = ""//buildChartURL();
                    var chartUrlBase = "<%= ServerSide_ChartUrlBase %>";
                    if (chartUrlBase === undefined || chartUrlBase === null || chartUrlBase.length < 1) {
                        alert("Sorry for the inconvenience.  This report is temporarily unavailable.  We are working to resolve this.  Please try again later.");
                        closeWindow();
                    } else {
                        if (chartUrlBase.indexOf("ProgramStatus") != -1) {
//                            openProgramStatusPage(chartUrlBase + filters);
                            openRequestedSinglePrefilterPopup(chartUrlBase + filters);
                            closeWindow();
                        } else if (chartUrlBase.indexOf("RecFollowUpStatus") != -1) {
                            openRecFollowUpStatusPage(chartUrlBase + filters);
                        } else if (chartUrlBase.indexOf("AutoRecommendation") != -1) {//"RecFollowUpStatus"
                            openRecFollowUpStatusPage(chartUrlBase + filters);
                        } else {
                            openRequestedSinglePrefilterPopup(chartUrlBase + filters);
                            closeWindow();
                        }
                    }
                } catch (pException) {
                    alert(pException.message);
                }
            }, zFormDelay);
        });

        function closeWindow() {
            var tempWindow = GetRadWindow();
            tempWindow.setUrl("../../Home_{{VER}}/Reports/blank.aspx");
            tempWindow.close();
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
                var zOptions = "" +
                    "Behaviors=Close" +
                    ",resizable=yes" +
                    ",scrollbars=yes" +
                    ",status=yes" +
                    ",left=0" +
                    ",top=0" +
                    ",width=" + screen.width * 0.99 +
                    ",height=" + screen.height * 0.90;
                windowObjectReference = window.open(strUrl, "SingleSecondaryWindowName", zOptions);
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
                var zOptions = "" +
                    "resizable=yes" +
                    ",scrollbars=yes" +
                    ",status=yes" +
                    ",left=0" +
                    ",top=0" +
                    ",width=" + screen.width * 0.99 +
                    ",height=" + screen.height * 0.90;
                windowObjectReference = window.open(strUrl, "SingleSecondaryWindowName", zOptions);
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

    </script>

</body>
</html>
