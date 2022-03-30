<%@ Page Language="vb"  MasterPageFile="~/Home_{{VER}}/Charts/ChartMasterPageRecommendations.master" AutoEventWireup="false" CodeBehind="FacilityScore.aspx.vb" Inherits="GRC.Connect.Web.Charts_FacilityScore" %>

<asp:Content ID="ChartHeadContent" runat="server" ContentPlaceHolderID="ChartHeadContent">
    <title>Facility Ratings</title>
    <link rel="Stylesheet" type="text/css" href="../../../css/Font-Awesome/all.css" />
    <script src="../../../Lib_{{VER}}/Data/ChartTestData03.js"></script>
    <script src="../../../Lib_{{VER}}/Charts/FacilityScore.js"></script>
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
        var ServerSide_ClientFeatures = "<%=ServerSide_ClientFeatures%>";
  </script>
    <style>
        body {
            font-family: Arial !important;
        }
        .chartPageTable {
            /*width: 1250px;*/
            width:1310px;
            margin: auto;
            text-align: center;
        }
        .chartContainer {
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
        .chartContainer .k-chart {
            text-align: center;
            margin: auto;
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
    <div id="divContainerLoading" class="containerLoading" style="display: none;"></div>

    <!-- CONTENT -->
    <table runat="server" ID="tableHeaderContainer">
        <tr>
            <td>
                <table class="chartPageTable">
                    <tr>
                        <td align="center" style="width: 412px" valign="top" ID="tdParameters" runat="server">
                            <table cellpadding="0" cellspacing="0" border="0" class="printNone" ID="tableParameters" runat="server" style="margin-left: -120px; margin-top: -11px;">
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
                                            <option Value="HighLowTIV">Highest to Lowest TIV</option>
                                            <option Value="LowHighTIV">Lowest to Highest TIV</option>
                                            <option Value="HighLowScore" selected="selected">Highest to Lowest Score</option>
                                            <option Value="LowHighScore">Lowest to Highest Score</option>
                                        </select>
                                    </td>
                                </tr>
                            </table>
                            <%--<table cellpadding="0" cellspacing="0" border="0" ID="tableLocation" runat="server" style="margin-left: -50px; margin-top: -10px">
                                <tr>
                                    <td style="width: 130px; height: 16px; text-align: left;">
                                        <asp:Label ID="lblLocation" runat="server" Text="Location:" Font-Bold="true" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                    <td style="text-align: left; height: 16px;">
                                        <asp:Label ID="lblLocationValue" runat="server" Text="" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                </tr>
                            </table>--%>
                        </td>
                        <td align="center" style="width: 33%" valign="top">
                            <table class="printNone">
                                <tr>
                                    <td align="center" valign="top">
                                        <div style="margin-left: 50px;">
                                            <button ID="btnPDF" data-bind="click: downloadPDF" style="background:#00b140;color: #fff;font-weight: 700;border: none;border-radius: 0px;padding: 5px;width: 130px;height: 35px;">Save/Print</button>
                                            <input id="cmdClose" type="button" value="Close" onclick="window.close();" style="background:#eee;color: #0046ad;font-weight: 700;border: 2px solid #0046ad;border-radius: 0px;padding: 5px;width: 130px;height: 35px;" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="right" style="width: 33%" valign="top" ID="tdRatingsTable" runat="server">
                            <!-- RATING KEY TABLE AND LEGEND -->
                            <div data-bind="visible: globalClientFeatures.search('U') == -1">
                                <table style="font-size: 7pt; font-weight: bold; margin-top: -55px;" id="table1" runat="server">
                                    <tr>
                                        <td align="left" valign="top">
                                            <asp:Label ID="Label4" runat="server" Style="margin-left: 5px; font-weight: bold; font-size: 8pt; padding-left: 35px;" Text="Rating Key"></asp:Label>
                                            <table style="border: 1px solid #C6C3C6; margin-top: 3px; margin-right: -30px;">
                                                <tr>
                                                    <td style="border: none;">
                                                        <table id="Table2" class="chartGrid" cellpadding="2" cellspacing="0" data-bind="foreach: { data: chartRatingsData, includeDestroyed: false }">
                                                            <tr>
                                                                <td style="width: 120px;" data-bind="style: { backgroundColor: $data.ratingColor }"><span data-bind="    text: $data.ratingTitle"></span></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td style="border: none;">
                                                        <table>
                                                            <tr>
                                                                <td style="width: 100px; text-align: right;">
                                                                    <label>GRC Avg:</label>
                                                                </td>
                                                                <td id="Td4" style="text-align: center; border: 1px solid #C6C3C6;">
                                                                    <label id="Label5" data-bind="text: averageGRC"></label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 100px; text-align: right;">
                                                                    <label>Client Avg:</label>
                                                                </td>
                                                                <td id="Td5" style="text-align: center; border: 1px solid #C6C3C6;">
                                                                    <label id="Label6" data-bind="text: averageClient"></label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 100px; text-align: right;">
                                                                    <label>Filtered Avg:</label>
                                                                </td>
                                                                <td id="Td6" style="text-align: center; border: 1px solid #C6C3C6;">
                                                                    <label id="Label7" data-bind="text: averageFiltered"></label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div data-bind="visible: globalClientFeatures.search('U') != -1">
                                <div class="containerRatingKey ui-helper-clearfix" style="width:125px; float:left;">
                                    <div>
                                        <div class="ratingColorTable">
                                            <div style="margin-left: 5px; margin-top: 10px; font-weight: bold; font-size: 8pt; width: 120px; text-align: center; float: left;"><span>Rating Key</span></div>
                                        </div>
                                    </div>
                                    <div class="ui-helper-clearfix" style="width:125px; float:left;" data-bind="foreach: { data: chartRatingsData, includeDestroyed: false }">
                                        <div style="width:120px; float:Left; border:1px solid #555555; padding:2px; font-size:12px;" data-bind="style: { backgroundColor: $data.ratingColor }"><span style="display:block; width:100%; text-align: center;" data-bind="    text: $data.ratingTitle"></span></div>
                                    </div>
                                </div>
                                <!-- END RATING LEGEND AND KEY -->
                                <div style="float:left;width:200px;">
                                    <div class="floatLeft centerAlign bold" style="width: 85px; margin-left: 125px; float: left; font-weight: bold; font-size: 8pt; text-align: center;">Rating<br />
                                        <span style="display: block; float: left; width: 30px;" title="average">AVG</span>
                                        <span style="display: block; float: left; width: 10px;">&nbsp;/&nbsp;</span>
                                        <span style="display: block; float: left; width: 30px;" title="weighted average">WAVG</span>
                                    </div>
                                    <div class="ui-helper-clearfix" style="float: left; margin-bottom:3px;">
                                        <label id="" readonly="readonly" style="line-height:16px; text-align: right; display: block; width: 120px; font-size: 8pt; float:left; margin-right:5px;">Client Average</label>
                                        <div data-bind="text: viewChart.magnaClientAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px; margin-right:10px;"></div>
                                        <div data-bind="text: viewChart.magnaClientAveragesWeighted()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px;"></div>
                                    </div>
                                    <div data-bind="visible: !viewChart.fullMag()" class="ui-helper-clearfix" style="float: left; margin-bottom:3px;">
                                        <label id="Label1" readonly="readonly" style="line-height:16px; text-align: right; font-size: 8pt; display: block; width: 120px; float:left; margin-right:5px;">Filtered Average</label>
                                        <div data-bind="text: viewChart.magnaFilteredAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px; margin-right:10px;"></div>
                                        <div data-bind="text: viewChart.magnaFilteredWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px;"></div>
                                    </div>
                                    <div data-bind="visible: viewChart.fullMag()" class="ui-helper-clearfix" style="float: left; margin-bottom:3px;">
                                        <label id="Label11" readonly="readonly" style="line-height:16px; text-align: right; font-size: 8pt; display: block; width: 120px; float:left; margin-right:5px;">Division Average</label>
                                        <div data-bind="text: viewChart.magnaDivisionAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px; margin-right:10px;"></div>
                                        <div data-bind="text: viewChart.magnaDivisionWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px;"></div>
                                    </div>
                                    <div data-bind="visible: viewChart.fullMag()">
                                        <div class="ui-helper-clearfix" style="float: left; margin-bottom: 3px;">
                                            <label data-bind="text: viewChart.magnaCustomAccessLabel()" id="Label2" readonly="readonly" style="line-height: 16px; font-size: 8pt; text-align: right; display: block; width: 120px; float: left; margin-right: 5px;"></label>
                                            <div data-bind="text: viewChart.magnaCustomAccessAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px; margin-right: 10px;"></div>
                                            <div data-bind="text: viewChart.magnaCustomAccessWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px;"></div>
                                        </div>
                                        <%--<div class="ui-helper-clearfix" style="float: left; margin-bottom:3px;">
                                            <label id="Label3" readonly="readonly" style="line-height: 16px; text-align: right; font-size: 8pt; display: block; width: 120px; float: left; margin-right: 5px;">GRC Client Average</label>
                                            <div data-bind="text: viewChart.magnaGRCAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px; margin-right: 10px;"></div>
                                            <div data-bind="text: viewChart.magnaGRCWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px;"></div>
                                        </div>
                                        <div class="ui-helper-clearfix" style="float: left;">
                                            <label data-bind="text: viewChart.magnaIndustryLabel()" id="Label8" readonly="readonly" style="line-height: 16px; font-size: 8pt; text-align: right; display: block; width: 120px; float: left; margin-right: 5px;"></label>
                                            <div data-bind="text: viewChart.magnaIndustryAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px; margin-right: 10px;">71%</div>
                                            <div data-bind="text: viewChart.magnaIndustryWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px;">71%</div>
                                        </div>--%>
                                    </div>
                                </div>
                                <div style="float:left;width:100px;">
                                    <div class="floatLeft centerAlign bold" style="width:85px; margin-left:16px; float:left; font-weight: bold; font-size: 8pt; text-align:center;">Achievable<br />
                                        <span style="display:block; float:left; width:35px;" title="average">AVG</span>
                                        <span style="display:block; float:left; width:10px;">&nbsp;/&nbsp;</span>
                                        <span style="display:block; float:left; width:35px;" title="weighted average">WAVG</span>
                                    </div>
                                    <div class="ui-helper-clearfix" style="float: left; margin-bottom:3px;">
                                        <span style="float:left; width:20px; display:block;">&nbsp;</span>
                                        <div data-bind="text: viewChart.magnaClientAchievableAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px; margin-right:10px;">100%</div>
                                        <div data-bind="text: viewChart.magnaClientAchievableWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px;">71%</div>
                                    </div>
                                    <div data-bind="visible: !viewChart.fullMag()" class="ui-helper-clearfix" style="float: left; margin-bottom:3px;">
                                        <span style="float:left; width:20px; display:block;">&nbsp;</span>
                                        <div data-bind="text: viewChart.magnaFilteredAchievableAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px; margin-right:10px;"></div>
                                        <div data-bind="text: viewChart.magnaFilteredAchievableWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px;"></div>
                                    </div>
                                    <div data-bind="visible: viewChart.fullMag()" class="ui-helper-clearfix" style="float: left; margin-bottom:3px;">
                                        <span style="float:left; width:20px; display:block;">&nbsp;</span>
                                        <div data-bind="text: viewChart.magnaDivisionAchievableAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px; margin-right:10px;"></div>
                                        <div data-bind="text: viewChart.magnaDivisionAchievableWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float:left; width:25px; padding:2px;"></div>
                                    </div>

                                    <div data-bind="visible: viewChart.fullMag()">
                                        <div class="ui-helper-clearfix" style="float: left; margin-bottom: 3px;">
                                            <span style="float: left; width: 20px; display: block;">&nbsp;</span>
                                            <div data-bind="text: viewChart.magnaCustomAccessAchievableAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px; margin-right: 10px;"></div>
                                            <div data-bind="text: viewChart.magnaCustomAccessAchievableWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px;"></div>
                                        </div>
                                        <%--<div class="ui-helper-clearfix" style="float: left; margin-bottom: 3px;">
                                            <span style="float: left; width: 20px; display: block;">&nbsp;</span>
                                            <div data-bind="text: viewChart.magnaGRCAchievableAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px; margin-right: 10px;"></div>
                                            <div data-bind="text: viewChart.magnaGRCAchievableWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px;"></div>
                                        </div>
                                        <div class="ui-helper-clearfix" style="float: left;">
                                            <span style="float: left; width: 20px; display: block;">&nbsp;</span>
                                            <div data-bind="text: viewChart.magnaIndustryAchievableAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px; margin-right: 10px;"></div>
                                            <div data-bind="text: viewChart.magnaIndustryAchievableWeightedAverages()" style="text-align:center; font-size: 9px; font-weight: 700; border: 1px solid #C6C3C6; float: left; width: 25px; padding: 2px;"></div>
                                        </div>--%>
                                    </div>
                                </div>
                            </div>
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
                    <button id="btnPagePrevious" class="k-button buttonShape k-icon k-i-arrow-w" data-bind="click: pagePreviousGroup">&nbsp;</button>
                    <span id="spnPageButtons" data-bind="foreach: { data: chartPageNumbers, includeDestroyed: false }">
                        <button class="k-button buttonShape" style="height: 16px; width: 24px;" data-bind="text: $data, click: function (data) { $parent.pageLoadByNumber($data, false) }"></button>
                    </span>
                    <button id="btnPageNext" class="k-button buttonShape k-icon k-i-arrow-e" data-bind="click: pageNextGroup">&nbsp;</button>
                </div>
            </td>
        </tr>
        <tr>
            <td align="left" valign="top">
                <div class="chartContainer" style="min-height: 250px; padding-right: 24px; padding-left: 24px; padding-top: 6px; padding-bottom: 12px; border-radius: 6px; -moz-border-radius: 6px; -webkit-border-radius: 6px; border: 1px solid #C0C0C0;">
                    <div style="width: 40%; float: left; text-align: center; font-weight: bold; font-size: 8pt" data-bind="html: chartCategoryTitle">TIV (mils) - City - St/Prov - Country -<br />ClientLocID - Division - Facility</div>
                    <div style="clear: both; height: 6px;">&nbsp;</div>
                    <div id="chartRating"></div>
                </div>
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
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
            <div style="margin-bottom:5px; width:100%;">
                <label>Thank you for your patience while the Facility Score chart PDF is being built.</label>
            </div>
            <div style="margin-bottom:5px; width:100%;">
                <label>As this tool provides a statistical view of your locations, this may take a few minutes.</label>
            </div>
            <div style="display:flex; justify-content: center; width:100%;">
                <button class="grcNeutralBtn" style="background:#eee;color: #0046ad;font-weight: 700;border: 2px solid #0046ad;border-radius: 0px;padding: 5px;width: 130px;height: 35px;" data-bind="click: onCancelMultiPring">Cancel</button>
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
    

    <!-- PLEASE WAIT WINDOW FOR CHART LOADING -->
    <div class="printNone">
    <div id="windowPleaseWaitLoading" class="windowContent printNone">
        <img src="../../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="TUV SUD GRC Client Connect - Please Wait" />
        <div id="windowPleaseWaitLoadingProcessed" style="display:flex; flex-direction:column; align-items:center; justify-content:center; font-size:13px;">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
            <div style="margin-bottom:5px; width:100%">
                <label>Thank you for your patience while the Facility Rating Score chart is being built.</label>
            </div>
            <div style="margin-bottom:5px; width:100%;">
                <label>As this tool provides a statistical view of your entire program, this may take a few minutes.</label>
            </div>
            <div style="display:flex; width:100%; justify-content: center;">
                <button class="grcNeutralBtn" style="background:#eee;color: #0046ad;font-weight: 700;border: 2px solid #0046ad;border-radius: 0px;padding: 5px;width: 130px;height: 35px;" data-bind="click: onCancelLoad">Cancel</button>
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
</asp:Content>
