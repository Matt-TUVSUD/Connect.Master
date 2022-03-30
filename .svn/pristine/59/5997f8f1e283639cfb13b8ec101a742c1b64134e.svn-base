<%@ Page Language="vb" MasterPageFile="~/Home_{{VER}}/Charts/ChartMasterPageRecommendations.master" AutoEventWireup="false" CodeBehind="ChartTest01.aspx.vb" Inherits="GRC.Connect.Web.ChartTest01" %>

<asp:Content ID="ChartHeadContent" runat="server" ContentPlaceHolderID="ChartHeadContent">
    <title>Fire Loss Prevention Recommendations</title>
    <script src="../../../Lib_{{VER}}/Data/ChartTestData.js"></script>
    <script src="../../../Lib_{{VER}}/Charts/Test/ChartTest01.js"></script>
    <script>
        var ServerSide_GridId = "<%=ServerSide_ChartId%>";
    </script>
</asp:Content>

<asp:Content ID="ChartContent" runat="server" ContentPlaceHolderID="ChartContent">
    <div id="viewChartTest">
    <table>
        <tr>
            <td>
                <table style="width: 900px; height: 4px">
                    <tr>
                        <td align="center" style="width: 33%" valign="top">
                            <table>
                                <tr>
                                    <td align="center" valign="top">
                                        <input id="cmdGenerateAllRecommendations" type="button" value="All Recommendations" onclick="ShowGenerating(10000); document.getElementById('MainContent_cmdAllRecommendations').click();" />
                                        <asp:Button ID="cmdAllRecommendations" runat="server" Text="All Recommendations" Font-Names="Arial" CssClass="hidden" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="center" style="width: 34%" valign="top">
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
                        <td align="center" style="width: 33%" valign="top">
                            <table>
                                <tr>
                                    <td align="center" valign="top">
                                        <input id="cmdGenerateDrillBack" type="button" value="Drill Back" onclick="ShowGenerating(10000); document.getElementById('MainContent_cmdDrillBack').click();" />
                                        <asp:Button ID="cmdDrillBack" runat="server" Text="Drill Back" Font-Names="Arial" CssClass="hidden" />
                                        <input id="cmdGenerateEmail" type="button" value="Email" onclick="ShowGenerating(10000); document.getElementById('MainContent_cmdEmail').click();" style="display: none" />
                                        <asp:Button ID="cmdEmail" runat="server" Text="Email" Font-Names="Arial" CssClass="hidden" />
                                        <input id="cmdGeneratePDF" type="button" value="Save/Print" onclick="ShowGenerating(10000); document.getElementById('MainContent_cmdPDF').click();" />
                                        <asp:Button ID="cmdPDF" runat="server" Text="Save/Print" Font-Names="Arial" CssClass="hidden" />
                                        <input id="cmdClose" type="button" value="Close" onclick="window.close();" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

    <table style="width: 900px">
        <tr>
            <td align="center" style="height: 0px" valign="top">
                <div id="txtMessage" style="text-align: center;"><%--<span>Message Center:</span>&nbsp;--%><label data-bind="text: txtMessage"></label>&nbsp;</div>
            </td>
        </tr>
        <tr>
            <td align="center" style="height: 0px" valign="top">
                <label id="lblTip" style="font-weight: normal; font-family: Arial; font-size: 8pt; color: red;">(Click on any bar below to drill down to the Secondary Recommendation Detailed Data) (Not functioning)</label>
            </td>
        </tr>
        <tr>
            <td align="left" valign="top">
                <div id="chartTestMultiAxis"></div>
            </td>
        </tr>
        <tr>
            <td align="center" valign="top">
                <table style="width: 900px">
                    <tr>
                        <td>
                        </td>
                        <td align="center" style="width: 100%">
                            <table>
                                <tr>
                                    <td align="center" style="width: 0px" valign="top">
                                        <%-- DELETE ME START TEST BOTTOM GRID --%>
                                        <table border='0' cellpadding='0' cellspacing='0' id='' style="overflow:hidden;position:relative;height:54px;" class="">
                                            <tr id="MainContentxmyTotalsGrid_mr" style="height:100%;">
                                                <td id="MainContentxmyTotalsGrid_mc" align='left' style="height:100%;vertical-align:top;">
                                                    <div id="MainContentxmyTotalsGrid_div" style="position:relative;overflow:hidden;width:100%;height:100%;" tabIndexPage='0' hideFocus='true'>
                                                        <table id='G_MainContentxmyTotalsGrid' bandNo='0'  border='1' cellpadding='3' cellspacing='0' style='table-layout:auto;border-collapse:collapse;position:relative;width:585px;position:relative;'>
                                                            <colgroup><col width='65px' /><col width='65px' /><col width='65px' /><col width='65px' /><col width='65px' /><col width='65px' /><col width='65px' /><col width='65px' /><col width='65px' /></colgroup>
                                                            <thead class="" style="background-color: #C6D1DF;"><tr><th id='MainContentxmyTotalsGrid_c_0_0' columnNo='0' height='20px' class="">BCP</th><th id='MainContentxmyTotalsGrid_c_0_1' columnNo='1' height='20px' class="">Human Element</th><th id='MainContentxmyTotalsGrid_c_0_2' columnNo='2' height='20px' class="">Manual Prot.</th><th id='MainContentxmyTotalsGrid_c_0_3' columnNo='3' height='20px' class="">Nat. Haz/Exp.</th><th id='MainContentxmyTotalsGrid_c_0_4' columnNo='4' height='20px' class="">Spec. Hazards</th><th id='MainContentxmyTotalsGrid_c_0_5' columnNo='5' height='20px' class="">Sprinklers</th><th id='MainContentxmyTotalsGrid_c_0_6' columnNo='6' height='20px' class="">Surveillance</th><th id='MainContentxmyTotalsGrid_c_0_7' columnNo='7' height='20px' class="">Water Supply</th><th id='MainContentxmyTotalsGrid_c_0_8' columnNo='8' height='20px' class="">Total</th></tr></thead>
                                                            <tbody style="height:100%" class=""><tr id='MainContentxmyTotalsGrid_r_0' style='height:20px;'><td><nobr>1</nobr></td><td><nobr>18</nobr></td><td><nobr>3</nobr></td><td><nobr>1</nobr></td><td><nobr>13</nobr></td><td><nobr>13</nobr></td><td><nobr>4</nobr></td><td><nobr>2</nobr></td><td><nobr>55</nobr></td></tr></tbody>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                        <%-- DELETE ME END TEST BOTTOM GRID --%>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="right" valign="top">
                            <table>
                                <tr>
                                    <td align="center" style="width: 0px" valign="top">
                                        <%--LEGEND GOES HERE - NESTED--%>
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
</asp:Content>
<asp:Content ID="HiddenContent" runat="server" ContentPlaceHolderID="HiddenContent">
</asp:Content>
