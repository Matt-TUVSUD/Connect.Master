<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="KendoSample_01.aspx.vb" Inherits="GRC.Connect.Web.KendoSample_01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Kenso Line Chart 01</title>

    <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/windows.css" />
    <%--<link rel="stylesheet" type="text/css" href="../../../css/Charts/all.css" />
    <link rel="stylesheet" type="text/css" href="../../../css/Charts/recommendations.css" />--%>
    <link rel="stylesheet" type="text/css" href="../../../css/pages/print.css" media="print" />

    <script src="../../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <%--<script src="../../../Lib_{{VER}}/KendoUI.v2015.3.1111/kendo.all.min.js"></script>--%>
    <script src="../../Lib_{{VER}}/kendo.all.min.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/pages/global.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/pages/constants.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>

    <script src="KendoSample_Data.js"></script>
    <script src="KendoSample_01.js"></script>

    <style>
        body {
            font-family: Arial !important;
        }
        /*.chartPageTable {
            width: 1250px;
            margin: auto;
            text-align: center;
        }
        .chartContainerOutside {
            min-height: 575px;
            width: 1250px;
            margin: auto;
            text-align: center;
            padding-right: 24px;
            padding-left: 24px;
            padding-top: 6px;
            padding-bottom: 12px;
            border-radius: 6px;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border: 1px solid #C0C0C0;
        }
        .chartContainer {
            min-height: 75px;
            width: 300px;
            margin: auto;
            text-align: center;
            border: 1px solid #000000;
        }
        .chartContainer .k-chart {
            text-align: center;
            margin: auto;
        }
        .chartLabelContainer {
            min-height: 75px;
            width: 325px;
            margin: auto;
            text-align: center;
            white-space: normal;
            border: 1px solid #000000;
            font-family: Arial;
            font-weight: bold;
            font-size: 8pt;
            padding-right: 8px;
            padding-left: 8px;
        }
        .chartHeaderLabelContainer {
            min-height: 30px;
            min-width: 350px;
            width: 350px;
            margin: auto;
            text-align: center;
            white-space: normal;
            border: 1px solid #000000;
            font-family: Arial;
            font-weight: bold;
            font-size: 8pt;
            padding-right: 8px;
            padding-left: 8px;
        }
        .chartHeaderContainer {
            min-height: 30px;
            min-width: 300px;
            width: 300px;
            margin: auto;
            text-align: center;
            border: 1px solid #000000;
            font-weight: bold;
            font-size: 10pt;
        }
        .headerActive {
            background-color: #568ED2;
            color: #FFFFFF;
        }
        .headerPassive {
            background-color: #FC0D1B;
            color: #000000;
        }
        .headerTotal {
            background-color: #19AF54;
            color: #FFFFFF;
        }
        .chartGrid,
        .chartGrid th,
        .chartGrid td {
            border: 1px solid #2C2C2C;
            border-collapse: collapse;
            font-size: 9pt;
            font-family: Arial;
            font-weight: normal;
            text-align: center;
        }
        .chartGridHead,
        .chartGridHead tr {
        }
        .chartGridHead th {
        }
        .chartGridBody,
        .chartGridBody tr {
        }
        .chartGridBody th {
        }*/

        /*Clear Fix*/
.ui-helper-clearfix:after { content: "."; display: block; height: 0; clear: both; visibility: hidden; }
.ui-helper-clearfix { display: inline-block; }
/* required comment for clearfix to work in Opera \*/
* html .ui-helper-clearfix { height: 1%; }
.ui-helper-clearfix { display: block; }
/* end clearfix */



    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="view">
    
    <%--<a href="TestChart.aspx" target="_blank">TestChart.aspx</a>--%>
   
    <%--<div style="text-align: center">
        <table style="width: 100%">
            <tr runat="server" ID="trHeaderContainer">
                <td align="center" valign="top">
                    <table class="chartPageTable">
                        <tr>
                            <td align="left" style="width: 50%" valign="middle">
                                <img src="data:image/png;base64,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"
                                    style="" alt="Global Risk Consultants" />
                            </td>
                            <td align="right" style="width: 50%; font-size: 16pt; font-weight: bold; font-family: Calibri, Candara, Segoe, Optima, Arial, sans-serif; color: #c2d6ed;" valign="middle">
                                <asp:Label ID="lblClient" runat="server" Font-Bold="True" Text="Client" Width="438px">Test Client Name</asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server" ID="trParameterContainer">
                <td align="center" valign="top">
                   <table class="chartPageTable" style="height: 4px">
                        <tr>
                            <td align="center" style="width: 25%; text-align: left" valign="middle" ID="tdButtons" runat="server">
                                <%--<button id="btnPDF">Save/Print</button>
                                <input id="btnPDF" type="button" value="Save/Print" onclick="window.document.location.href = 'TestChart.aspx';" />
                                <input id="cmdClose" type="button" value="Close" onclick="window.close();" />
                            </td>
                            <td align="center" style="width: 50%" valign="middle" ID="tdTitle" runat="server">
                                <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="14pt" Text="Title" Width="522px" Font-Names="Arial">Total Facility Rating Score</asp:Label>
                                <br />
                                <asp:Label ID="lblARINote" runat="server" Font-Size="8pt" ForeColor="Blue">(This is a chart note.  Please replace this text.)</asp:Label>
                            </td>
                            <td align="center" style="width: 20%; text-align: right !important;" valign="middle" ID="tdDate" runat="server">
                                <asp:Label ID="lblDate" runat="server" Font-Bold="True" Font-Size="8pt" Text="Date" Width="100%" Font-Names="Arial"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="center" valign="top">



    <table>
        <tr runat="server" ID="trMessageContainer">
            <td align="center" style="height: 0px">
                <div id="txtMessage" style="text-align: center;"><label data-bind="text: txtMessage"></label>&nbsp;</div>
            </td>
        </tr>
        <tr runat="server" ID="trTipContainer" class="printNone">
            <td align="center">
                <div style="float: left;">
                    <label id="lblTip" style="font-weight: normal; font-family: Arial; font-size: 8pt; color: red;"></label>
                </div>
                <div style="float: right;" id="divPagingContainer">
                    <label data-bind="text: txtMessageCurrentPage"></label>&nbsp;&nbsp;
                    <button id="btnPagePrevious" class="k-button buttonShape k-icon k-i-arrow-w" data-bind="">&nbsp;</button>
                    <span id="spnPageButtons" data-bind="foreach: { data: chartPageNumbers, includeDestroyed: false }">
                        <button class="k-button buttonShape" style="height: 16px; width: 24px;" data-bind="text: $data"></button>
                    </span>
                    <button id="btnPageNext" class="k-button buttonShape k-icon k-i-arrow-e" data-bind="">&nbsp;</button>
                </div>
            </td>
        </tr>
        <tr>
            <td align="left" valign="top">
                <div class="chartContainerOutside">
                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse">
                        <tr>
                            <td class="chartHeaderLabelContainer">
                                Location Details
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">File No.</td>
                                        <td style="width: 87px;">Client Loc. No.</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">TIV</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">Address</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Division</td>
                                        <td colspan="2" style="width: 175px;">Facility</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartHeaderContainer headerActive">Active Score Chart</td>
                            <td class="chartHeaderContainer headerPassive">Passive Score Chart</td>
                            <td class="chartHeaderContainer headerTotal">Total Facility Score Chart</td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0004</td>
                                        <td style="width: 87px;">KS07</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">644.949</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">1 Technology Center, Olathe, KS United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Electronic Operations</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0101"></div></td>
                            <td class="chartContainer"><div id="chartLine0102"></div></td>
                            <td class="chartContainer"><div id="chartLine0103"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0006</td>
                                        <td style="width: 87px;">AL07</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">73.809</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">1 Cliff Garrett Drive, Anniston, AL United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Mechanical Services</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0201"></div></td>
                            <td class="chartContainer"><div id="chartLine0202"></div></td>
                            <td class="chartContainer"><div id="chartLine0203"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0008</td>
                                        <td style="width: 87px;">AZ18</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">285.657</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">1300 Warner Road, Tempe, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Electronic Operations</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0301"></div></td>
                            <td class="chartContainer"><div id="chartLine0302"></div></td>
                            <td class="chartContainer"><div id="chartLine0303"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0009</td>
                                        <td style="width: 87px;">AZ43</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">0.488</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">111 South 34th Street &amp; Jackson, Phoenix, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Mechanical Operations</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0401"></div></td>
                            <td class="chartContainer"><div id="chartLine0402"></div></td>
                            <td class="chartContainer"><div id="chartLine0403"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0011</td>
                                        <td style="width: 87px;">AZ10</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">197.051</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">11100 North Oracle Road, Tucson, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Mechanical Operations</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0501"></div></td>
                            <td class="chartContainer"><div id="chartLine0502"></div></td>
                            <td class="chartContainer"><div id="chartLine0503"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0014</td>
                                        <td style="width: 87px;">AZ43</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">0</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">111 S. 34th Street (Engineering), Phoenix, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Mechanical Operations</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0601"></div></td>
                            <td class="chartContainer"><div id="chartLine0602"></div></td>
                            <td class="chartContainer"><div id="chartLine0603"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0015</td>
                                        <td style="width: 87px;">AZ43</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">0</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">222 South 34th Street, Phoenix, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Mechanical Operations</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0701"></div></td>
                            <td class="chartContainer"><div id="chartLine0702"></div></td>
                            <td class="chartContainer"><div id="chartLine0703"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0017</td>
                                        <td style="width: 87px;">AZ43</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">3.671</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">111 S. 34th Street, Phoenix, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Mechanical Operations</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0801"></div></td>
                            <td class="chartContainer"><div id="chartLine0802"></div></td>
                            <td class="chartContainer"><div id="chartLine0803"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0019</td>
                                        <td style="width: 87px;">AZ09</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">25.108</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">4805 Olympic Drive, Kingman, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Aerospace</td>
                                        <td colspan="2" style="width: 175px;">Wheels &amp; Brakes HQ</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine0901"></div></td>
                            <td class="chartContainer"><div id="chartLine0902"></div></td>
                            <td class="chartContainer"><div id="chartLine0903"></div></td>
                        </tr>
                        <tr>
                            <td class="chartLabelContainer">
                                <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                    <tr>
                                        <td style="width: 87px;">1722.0021</td>
                                        <td style="width: 87px;">AZ02</td>
                                        <td style="width: 87px;">&nbsp;</td>
                                        <td style="width: 87px; text-align: right;">17.365</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="width: 350px;">4790 Olympic Drive, Kingman, AZ United States</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="width: 175px;">Performance Materials &amp; Technologies</td>
                                        <td colspan="2" style="width: 175px;">Flourine Products</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="chartContainer"><div id="chartLine1001"></div></td>
                            <td class="chartContainer"><div id="chartLine1002"></div></td>
                            <td class="chartContainer"><div id="chartLine1003"></div></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr runat="server" ID="trFooterTableContainer" class="printNone">
        </tr>
    </table>
    <div style="color: #FFFFFF; height: 0px;"><section id="TotalCount"></section></div>
    




        </td>
            </tr>
            <tr runat="server" ID="trFooterContainer">
                <td align="center" valign="top">
                    <table>
                        <tr>
                            <td class="chartPageTable" align="left" valign="top">
                                <hr />
                                <asp:Label ID="lblDisclaimer" runat="server" Text="This document is PROPRIETARY and CONFIDENTIAL. If you are not the intended recipient, you are notified that any review, dissemination or distribution is prohibited." Font-Names="Arial" Font-Size="6.75pt"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>--%>

        <!-- TEST DASHBOARD -->
    <div id="ChartDasboardHldr" style="margin:0 auto; padding:0px 50px;">
        <div id="DashobardHeader" class="ui-helper-clearfix" style="width:500px;">
            <div id="rowOne" class="ui-helper-clearfix" style="width:100%">
                <div style="float:left; text-align:left; width:200px;">
                    <label>Division</label>
                </div>
                <div style="float:left; text-align:left">
                    <select id="divisionDD" multiple="multiple" style="width:145px;">
                        <option>AFRICA</option>
                        <option>Asia Pacific</option>
                        <option>Benelux</option>
                        <option>France Btob</option>
                        <option>France</option>
                    </select>
                </div>
            </div>
            <div id="rowTwo" class="ui-helper-clearfix" style="width:100%">
                <div style="float:left; text-align:left; width:200px;">
                    <label>Client Loc. ID</label>
                </div>
                <div style="float:left; text-align:left">
                    <select id="ClientLocDD" multiple="multiple" style="width:145px;">
                        <option>EULB TR</option>
                        <option>EECL STDL</option>
                        <option>MESCAAT TR</option>
                        <option>PRONY ENERCAL STDL</option>
                    </select>
                </div>
            </div>
            <div id="rowThree" class="ui-helper-clearfix" style="width:100%">
                <div style="float:left; text-align:left; width:200px;">
                    <label>Intended Action</label>
                </div>
                <div style="float:left; text-align:left">
                    <select id="IntendedActionDD" multiple="multiple" style="width:145px;" >
                        <option>Completed</option>
                        <option>In Progress</option>
                        <option>Disagree - Will Not Complete</option>
                        <option>Agree - Will Complete</option>
                        <option>Will Study</option>
                    </select>
                </div>
            </div>
        </div>
        <div id="ChartTest"></div>
    </div>

    <!-- PLEASE WAIT WINDOW FOR PRINTING MULTIPLE PAGES -->
    <div class="printNone">
        <div id="windowPleaseWait" class="windowContent printNone">
            <img src="../../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="GRC Client Connect - Please Wait" />
            <div id="windowPleaseWaitProcessed">
                <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
                <br />&nbsp;<br />&nbsp;<br />
                <div>
                    <label>Thank you for your patience while the Facility Score chart PDF is being built.</label>
                    <br />&nbsp;<br />
                    <label>As this tool provides a statistical view of your locations, this may take a few minutes.</label>
                </div>
                <br />&nbsp;<br />
                <div style="text-align: center;">
                    <button class="k-button k-button-padding" data-bind="click: onCancelMultiPrint">Cancel</button>
                </div>
            </div>
            <div id="windowPleaseWaitCancelled" style="display: none;">
                <div style="padding-top: 6px;"><label data-bind="" >Your request is being cancelled</label></div>
                <br />&nbsp;<br />
                <div style="text-align: center;">
                    <label>Please wait.</label>
                    <br />&nbsp;<br />&nbsp;<br />
                    <label>&nbsp;</label>
                </div>
            </div>
        </div>
    </div>

    </div>
    </form>
</body>
</html>
