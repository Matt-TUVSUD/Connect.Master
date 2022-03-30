<%@ Page Language="vb"  MasterPageFile="~/Home_{{VER}}/Charts/ChartMasterPageRecommendations.master" AutoEventWireup="false" CodeBehind="RatingTrending.aspx.vb" Inherits="GRC.Connect.Web.Charts_RatingTrending" %>

<asp:Content ID="ChartHeadContent" runat="server" ContentPlaceHolderID="ChartHeadContent">
    <title>Facility Rating Trending</title>
    <%--<script src="../../../Lib_{{VER}}/Data/ChartTestData04.js"></script>--%>
    <script src="../../../Lib_{{VER}}/Data/RatingTrending.js"></script>
    <script src="../../../Lib_{{VER}}/Charts/RatingTrending.js"></script>
    <script>
        var ServerSide_ChartId = "<%=ServerSide_ChartId%>";
        var ServerSide_IsDrillDownMode = "<%=ServerSide_IsDrillDownMode%>";
        var ServerSide_IsBatchMode = "<%=ServerSide_IsBatchMode%>";
        var ServerSide_IsDrillDownMode = "<%=ServerSide_IsDrillDownMode%>";
        var ServerSide_PageSize = "<%=ServerSide_PageSize%>";
        var ServerSide_LargeObjectFilter = "<%=ServerSide_LargeObjectFilter%>";
        var ServerSide_LargeObjectCriteria = "<%=ServerSide_LargeObjectCriteria%>";
        var ServerSide_LargeObjectSetting = "<%=ServerSide_LargeObjectSetting%>";
        var ServerSide_ChartData = "<%=ServerSide_ChartData%>";
        var ServerSide_ErrorMessage = "<%=ServerSide_ErrorMessage%>";
    </script>
    <style>
        body {
            font-family: Arial !important;
        }
        .chartPageTable {
            width: 1250px;
            margin: auto;
            text-align: center;
        }
        .chartContainerOutside {
            min-height: 575px;
            margin: auto;
            text-align: center;
        }
        .chartContainer {
            min-height: 75px;
            width: 300px;
            margin: auto;
            text-align: center;
            border: 1px solid #000000;
        }
        .chartContainer .k-chart {
            z-index: 0;
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
            min-height: 36px;
            min-width: 350px;
            width: 350px;
            margin: auto;
            text-align: center;
            white-space: normal;
            border: 1px solid #000000;
            background-color: #C0C0C0;
            color: #000000;
            font-family: Arial;
            font-weight: bold;
            font-size: 8pt;
            padding-right: 8px;
            padding-left: 8px;
            padding-top: 4px;
            padding-bottom: 4px;
        }
        .chartHeaderContainer {
            min-height: 30px;
            min-width: 280px;
            width: 280px;
            margin: auto;
            padding-right: 10px;
            padding-left: 10px;
            text-align: center;
            border: 1px solid #000000;
            font-weight: bold;
            font-size: 10pt;
        }
        .headerActive {
            background-color: #18375B;
            color: #FFFFFF;
        }
        .headerPassive {
            background-color: #953637;
            color: #FFFFFF;
        }
        .headerTotal {
            background-color: #958B58;
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
        }
    </style>
</asp:Content>

<asp:Content ID="ChartContent" runat="server" ContentPlaceHolderID="ChartContent">
    <div id="viewChart">

    <!-- LOADING -->
    <%--<div id="divContainerLoading" class="containerLoading" style="display: none;"></div>--%>

    <!-- CONTENT -->
    <table runat="server" ID="tableHeaderContainer">
        <tr>
            <td>
                <table class="chartPageTable">
                    <tr>
                        <td align="center" style="width: 412px" valign="top" ID="tdParameters" runat="server">
                            <table cellpadding="0" cellspacing="0" border="0" class="printNone" ID="tableParameters" runat="server" style="margin-left: -130px; margin-top: -11px;">
                                <tr>
                                    <td style="width: 130px; height: 16px; text-align: left !important;">
                                        <asp:Label ID="lblSort" runat="server" Text="Sort Order:" Font-Bold="true" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                    <td style="text-align: left; height: 16px;">
                                        <select id="cboSort">
                                            <option Value="LowHighFileNo">File No.</option>
                                            <option Value="LowHighClientLocNo">Client Loc. No.</option>
                                            <option Value="LowHighCity">City</option>
                                            <option Value="LowHighStProv">St/Prov.</option>
                                            <option Value="LowHighCountry">Country</option>
                                            <option Value="HighLowTIV" selected="selected">Highest to Lowest TIV</option>
                                            <option Value="LowHighTIV">Lowest to Highest TIV</option>
                                            <%--<option Value="HighLowScore" selected="selected">Highest to Lowest Score</option>
                                            <option Value="LowHighScore">Lowest to Highest Score</option>--%>
                                        </select>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="center" style="width: 33%" valign="top">
                            <table class="printNone">
                                <tr>
                                    <td align="center" valign="top">
                                        <div style="display:flex; justify-content:space-between; align-items:center; width:275px;">
                                            <button ID="btnPDF" class="grcGreenBtn" data-bind="click: downloadPDFHandler">Save/Print</button>
                                            <input id="cmdClose" type="button" class="grcNeutralBtn" style="background:#eee;color: #0046ad;font-weight: 700;border: 2px solid #0046ad;border-radius: 0px;padding: 5px;width: 130px;height: 35px;" value="Close" onclick="window.close();" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="right" style="width: 33%" valign="top" ID="tdRatingsTable" runat="server">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

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
                    <button id="btnPagePrevious" class="grcBlueBtn pagerBtn" style="background: #0046ad;color: #fff;font-weight: 700;border: none;width:22px;height:22px;border-radius:4px;padding: 0px;" data-bind="click: pagePreviousGroup"><i class="fas fa-caret-left"></i></button>
                    <span id="spnPageButtons" style="display:flex; justify-content:space-between; width:auto;" data-bind="foreach: { data: chartPageNumbers, includeDestroyed: false }">
                        <button class="grcBlueBtn pagerBtn" style="background: #0046ad;color: #fff;font-weight: 700;border: none;height: 16px; width: 24px; margin-right:3px;" data-bind="text: $data, click: function (data) { $parent.pageLoadByNumber($data, false) }"></button>
                    </span>
                    <button id="btnPageNext" class="grcBlueBtn pagerBtn" style="background: #0046ad;color: #fff;font-weight: 700;border: none;width:22px;height:22px;border-radius:4px;padding: 0px;" data-bind="click: pageNextGroup"><i class="fas fa-caret-right"></i></button>
                </div>
            </td>
        </tr>
        <tr>
            <td align="left" valign="top">
                <!-- TABLE OF MULTIPLE CHARTS NON-MAGNA FEATURE-->
                <div><!-- data-bind="visible: globalClientFeatures.search('A') < 0 "><!--&& globalClientFeatures.search('U') < 0-->
                    <div class="chartContainerOutside">
                        <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse">
                            <tr>
                                <td class="chartHeaderLabelContainer">
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 87px;">File No.</td>
                                            <td style="width: 218px;">Client Loc. No.</td>
                                            <td style="width: 44px; text-align: right;">TIV</td>
                                        </tr>
                                    </table>
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 175px;">Division</td>
                                            <td style="width: 175px;">Facility</td>
                                        </tr>
                                        <tr>
                                            <td colspan="4" style="width: 350px;">Address</td>
                                        </tr>
                                    </table>
                                </td>

                                <td class="chartHeaderContainer headerActive" data-bind="text: activeMGMTLblTxt">Management Programs Chart<%--<a style="color: #FFFFFF;" href="#" data-bind="click: function () { onHeadingClick('active'); }"></a>--%>
                                </td>
                                <td class="chartHeaderContainer headerPassive" data-bind="text: passivePhysicalLblTxt">Physical Assets Chart<%--<a style="color: #FFFFFF;" href="#" data-bind="click: function () { onHeadingClick('passive'); }"></a>--%>
                                </td>
                                <td class="chartHeaderContainer headerTotal">Total Facility Score Chart
                                    <div style="font-size: 7pt; font-weight: normal; line-height: 7pt;">(The Total Score equals the Active plus Passive, multiplied by the APL factor, if applicable.)</div>
                                </td>

                            </tr>
                            <!-- ko foreach: { data: chartTrendingData, includeDestroyed: false } -->
                            <tr>
                                <td class="chartLabelContainer">
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 87px;"><span data-bind="text: $data.FileNo"></span></td>
                                            <td style="width: 218px;"><span data-bind="text: $data.ClientLocNo"></span></td>
                                            <td style="width: 44px; text-align: right;"><span data-bind="text: $data.TIV"></span></td>
                                        </tr>
                                    </table>
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 175px;"><span data-bind="text: $data.Division"></span></td>
                                            <td style="width: 175px;"><span data-bind="text: $data.Facility"></span></td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="width: 350px;"><span data-bind="text: $data.Address"></span></td>
                                        </tr>
                                    </table>
                                </td>
                                <td class="chartContainer">
                                    <div data-bind="attr: { id: 'chartTrendingActive' + $index() }"></div>
                                </td>
                                <td class="chartContainer">
                                    <div data-bind="attr: { id: 'chartTrendingPassive' + $index() }"></div>
                                </td>
                                <td class="chartContainer">
                                    <div data-bind="attr: { id: 'chartTrendingTotal' + $index() }"></div>
                                </td>
                            </tr>
                            <!-- /ko -->
                        </table>
                    </div>
                </div>          
                <!-- TABLE OF MULTIPLE CHARTS MAGNA FEATURE-->
                <%--<div data-bind="visible: globalClientFeatures.search('U') > 0">
                    <div class="chartContainerOutside">
                        <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse">
                            <tr>
                                <td class="chartHeaderLabelContainer">
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 87px;">File No.</td>
                                            <td style="width: 218px;">Client Loc. No.</td>
                                            <td style="width: 44px; text-align: right;">TIV</td>
                                        </tr>
                                    </table>
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 175px;">Division</td>
                                            <td style="width: 175px;">Facility</td>
                                        </tr>
                                        <tr>
                                            <td colspan="4" style="width: 350px;">Address</td>
                                        </tr>
                                    </table>
                                </td>

                                <td class="chartHeaderContainer headerActive">Management Programs<%--<a style="color: #FFFFFF;" href="#" data-bind="click: function () { onHeadingClick('active'); }"></a>--%>
                                <!--</td>
                                <td class="chartHeaderContainer headerPassive">Physical Assets Chart<%--<a style="color: #FFFFFF;" href="#" data-bind="click: function () { onHeadingClick('passive'); }"></a>--%>
                                </td>--%>
                                <td class="chartHeaderContainer headerTotal">Total Facility Score Chart
                                    <div style="font-size: 7pt; font-weight: normal; line-height: 7pt;">(The Total Score equals the Active plus Passive, multiplied by the APL factor, if applicable.)</div>
                                </td>
                                <td class="chartHeaderContainer headerPassive">Rating Potential Chart<%--<a style="color: #FFFFFF;" href="#" data-bind="click: function () { onHeadingClick('passive'); }"></a>--%>
                                </td>
                            </tr>
                            <!-- ko foreach: { data: chartTrendingData, includeDestroyed: false } -->
                            <!--<tr>
                                <td class="chartLabelContainer">
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 87px;"><span data-bind="text: $data.FileNo"></span></td>
                                            <td style="width: 218px;"><span data-bind="text: $data.ClientLocNo"></span></td>
                                            <td style="width: 44px; text-align: right;"><span data-bind="text: $data.TIV"></span></td>
                                        </tr>
                                    </table>
                                    <table cellspacing="0" cellpadding="0" style="padding: 0; border-collapse: collapse; border: none; text-align: left;">
                                        <tr>
                                            <td style="width: 175px;"><span data-bind="text: $data.Division"></span></td>
                                            <td style="width: 175px;"><span data-bind="text: $data.Facility"></span></td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="width: 350px;"><span data-bind="text: $data.Address"></span></td>
                                        </tr>
                                    </table>
                                </td>
                                <td class="chartContainer">
                                    <div data-bind="attr: { id: 'chartTrendingActive' + $index() }"></div>
                                </td>
                                <td class="chartContainer">
                                    <div data-bind="attr: { id: 'chartTrendingPassive' + $index() }"></div>
                                </td>
                                <td class="chartContainer">
                                    <div data-bind="attr: { id: 'chartTrendingTotal' + $index() }"></div>
                                </td>
                                <td class="chartContainer">
                                    <div data-bind="attr: { id: 'chartRatingPotential' + $index() }"></div>
                                </td>
                            </tr>
                            <!-- /ko -->
                        <!--</table>
                    </div>
                </div>  -->        
            </td>
        </tr>
        <tr runat="server" ID="trFooterTableContainer" class="printNone">
        </tr>
    </table>
    <div style="color: #FFFFFF; height: 0px;"><section id="TotalCount"></section></div>
    
    <!-- PLEASE WAIT WINDOW FOR PRINTING MULTIPLE PAGES -->
    <div class="printNone">
    <div id="windowPleaseWait" class="windowContent printNone">
        <img src="../../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="TUV SUD GRC Client Connect - Please Wait" />
        <div id="windowPleaseWaitProcessed" style="display:flex; flex-direction:column; align-items:center; justify-content:center; font-size:13px;">
            <div style="padding-top: 6px; margin-bottom:10px; width:100%;">
                <label data-bind="" >Your request is being processed</label>
            </div>
            <div style="margin-bottom:5px; width:100%;">
                <label>Thank you for your patience while the Facility Score chart PDF is being built.</label>
            </div>
            <div style="margin-bottom:5px; width:100%;">
                <label>As this tool provides a statistical view of your locations, this may take a few minutes.</label>
            </div>
            <div style="display:flex; width:100%; justify-content:center">
                <button class="grcNeutralBtn" data-bind="click: onCancelMultiPring">Cancel</button>
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


    <!-- PLEASE WAIT WINDOW FOR PROGRAM STATUS PAGE -->
    <div class="printNone">
    <div id="windowPleaseWaitLoading" class="windowContent printNone">
        <img src="../../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="TUV SUD GRC Client Connect - Please Wait" />
        <div id="windowPleaseWaitLoadingProcessed" style="display:flex; flex-direction:column; align-items:center; justify-content:center; font-size:13px;">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
            <div style="margin-bottom:5px; width:100%;">
                <label>Thank you for your patience while the Facility Rating Trending chart is being built.</label>
            </div>
            <div style="margin-bottom:5px; width:100%;">
                <label>As this tool provides a statistical view of your entire program, this may take a few minutes.</label>
            </div>
            <div style="display:flex; width:100%; justify-content: center;">
                <button class="grcNeutralBtn" data-bind="click: onCancelLoad">Cancel</button>
            </div>
        </div>
        <div id="windowPleaseWaitLoadingCancelled" style="display: none;">
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
    <script>
        
    </script>
</asp:Content>
