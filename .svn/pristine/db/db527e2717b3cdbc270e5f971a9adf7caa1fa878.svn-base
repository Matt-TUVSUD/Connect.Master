<%@ Page Language="vb"  MasterPageFile="~/Home_{{VER}}/Charts/ChartMasterPageRecommendations.master" AutoEventWireup="false" CodeBehind="Recommendations.aspx.vb" Inherits="GRC.Connect.Web.Charts_Recommendations" %>

<asp:Content ID="ChartHeadContent" runat="server" ContentPlaceHolderID="ChartHeadContent">
    <title>Recommendations</title>
    <script src="../../../Lib_{{VER}}/Data/ChartTestData02.js"></script>
    <script src="../../../Lib_{{VER}}/Charts/Recommendations.js"></script>
    <script>
        var ServerSide_ChartId = "<%=ServerSide_ChartId%>";
        var ServerSide_IsBatchMode = "<%=ServerSide_IsBatchMode%>";
        var ServerSide_IsDrillDownMode = "<%=ServerSide_IsDrillDownMode%>";
        var ServerSide_LargeObjectFilter = "<%=ServerSide_LargeObjectFilter%>";
        var ServerSide_LargeObjectCriteria = "<%=ServerSide_LargeObjectCriteria%>";
        var ServerSide_LargeObjectSetting = "<%=ServerSide_LargeObjectSetting%>";
        var ServerSide_ChartData = "<%=ServerSide_ChartData%>";
        var ServerSide_ErrorMessage = "<%=ServerSide_ErrorMessage%>";

        setTimeout(function () {
            window.focus();
        }, 1000);
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
        .chartContainer {
            min-height: 560px;
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
            color: #FFFFFF;
            background-color: #0046ad; 
            min-height: 20px;
        }
        .chartGridHead th {
            font-size: 8pt; 
            min-width: 50px;
        }
        .chartGridBody,
        .chartGridBody tr {
            background-color: #FFFFFF;
            min-height: 20px;
        }
        .chartGridBody th {
            min-width: 50px;
        }
    </style>
</asp:Content>

<asp:Content ID="ChartContent" runat="server" ContentPlaceHolderID="ChartContent">
    <div id="viewChart">

    <!-- LOADING -->
    <div id="divContainerLoading" class="containerLoading" style="display: none;"></div>

    <!-- DRILLDOWN CONTAINER -->
    <div ID="divDrillDownContainer" runat="server" ClientIDMode="Static" class="chartDrillDownContainer printNone">
        <br />
        <iframe data-bind="attr: { src: txtIFrameSource }" id="frameChartDrillDown" class="chartIFrameContainer" seamless="seamless"></iframe>
    </div>

    <!-- CONTENT -->
    <table runat="server" ID="tableHeaderContainer">
        <tr>
            <td>
                <table class="chartPageTable" style="height: 4px">
                    <tr>
                        <td align="center" style="width: 33%" valign="top" ID="tdAllRecommendations" runat="server" class="printNone">
                            <table>
                                <tr>
                                    <td align="center" valign="top">
                                        <asp:Button ID="cmdAllRecommendations" runat="server" Text="All Recommendations" Font-Names="Arial" OnClientClick="ShowGenerating(10000);" style="background: #0046ad;color: #fff;font-weight: 700;border: none;border-radius: 0px;padding: 5px;width: 150px;height: 35px;" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="center" style="width: 34%" valign="top" ID="tdParameters" runat="server" class="printNone">
                            <table style="width: 100%; height: 4px">
                                <tr>
                                    <td align="center" style="width: 100%; height: 0px" valign="top">
                                        <asp:Label ID="lblDivision" runat="server" Text="Division:" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                        <asp:Label ID="lblDivisionValue" runat="server" Text="Value" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="width: 100%; height: 0px" valign="top">
                                        <asp:Label ID="lblCustomAccess" runat="server" Text="Custom Access:" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                        <asp:Label ID="lblCustomAccessValue" runat="server" Text="Value" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="width: 100%; height: 0px" valign="top">
                                        <asp:Label ID="lblTIV" runat="server" Text="TIV:" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                        <asp:Label ID="lblTIVValue" runat="server" Text="Value" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="center" style="width: 33%" valign="top" class="printNone">
                            <table>
                                <tr>
                                    <td align="center" valign="top">
                                        <asp:Button ID="cmdDrillBacks" runat="server" Text="Drill Back" Font-Names="Arial" OnClientClick="ShowGenerating(10000);" style="background: #0046ad;color: #fff;font-weight: 700;border: none;border-radius: 0px;padding: 5px;width: 130px;height: 35px;"/>
                                        <asp:Button ID="cmdEmail" runat="server" Text="Email" Font-Names="Arial" OnClientClick="ShowGenerating(10000);" CssClass="hidden" />
                                        <button id="btnPDF" data-bind="click: downloadPDF" style="background:#00b140;color: #fff;font-weight: 700;border: none;border-radius: 0px;padding: 5px;width: 130px;height: 35px;">Save/Print</button>
                                        <input id="cmdClose" type="button" value="Close" onclick="window.close();" style="background:#eee;color: #0046ad;font-weight: 700;border: 2px solid #0046ad;border-radius: 0px;padding: 5px;width: 130px;height: 35px;" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

    <table>
        <tr runat="server" ID="trMessageContainer">
            <td align="center" style="height: 0px" valign="top">
                <div id="txtMessage" style="text-align: center;"><label data-bind="text: txtMessage"></label>&nbsp;</div>
            </td>
        </tr>
        <tr runat="server" ID="trTipContainer" class="printNone">
            <td align="center" style="height: 0px" valign="top">
                <label id="lblTip" style="font-weight: normal; font-family: Arial; font-size: 8pt; color: red;">(Click on any bar below to drill down to the Secondary Recommendation Detailed Data)</label>
            </td>
        </tr>
        <tr>
            <td align="left" valign="top">
                <div class="chartContainer" style="">
                    <div id="chartRec"></div>
                </div>
            </td>
        </tr>
        <tr runat="server" ID="trFooterTableContainer">
            <td align="center" valign="top">
                <table class="chartPageTable" style="margin-top: 8px;">
                    <tr>
                        <td align="center" style="width: 100%;">
                            <div>
                                <table cellspacing="0" cellpadding="3" class="chartGrid" style="margin-left: 35px;">
                                    <thead class="chartGridHead" style="">
                                        <tr data-bind="foreach: { data: chartGridData, includeDestroyed: false }">
                                            <th class="" style=""><label data-bind="text: $data.title"></label></th>
                                        </tr>
                                    </thead>
                                    <tbody class="chartGridBody">
                                        <tr style="" data-bind="foreach: { data: chartGridData, includeDestroyed: false }">
                                            <td style=""><label data-bind="text: $data.value"></label></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </td>
                        <td runat="server" ID="tdImpactLegend">
                            <div>
                                <table style="width: 450px; font-size: 7pt; font-family: Arial;">
                                    <tr>
                                        <td>High</td>
                                        <td>Significant impact on overall site rating due to Loss Expectancy and/or Frequency</td>
                                    </tr>
                                    <tr>
                                        <td>Moderate</td>
                                        <td>Moderate impact on overall site rating due to Loss Expectancy and/or Frequency.</td>
                                    </tr>
                                    <tr>
                                        <td>Low</td>
                                        <td>Small impact on overall site rating due to Loss Expectancy and/or Frequency.</td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </div>
    <script>
        var gDivDrillDownContainerId = "<%= divDrillDownContainer.ClientID%>";
    </script>

</asp:Content>