<%@ Page Title="Auto-Recommendation Response & Follow-Up Status" Language="VB" MasterPageFile="~/Home_{{VER}}/Charts/ChartMasterPage.master" AutoEventWireup="true" Inherits="GRC.Connect.Web.Charts_AutoRecommendationResponseFollowUpStatus" Codebehind="AutoRecommendationResponseFollowUpStatus.aspx.vb" %>

<asp:Content ID="ChartHeadContent" runat="server" ContentPlaceHolderID="ChartHeadContent">
    <title>Auto-Recommendation Response & Follow-Up Status</title>
    <link rel="stylesheet" type="text/css" href="../../../css/pages/autorecstatus.css" />
    <script src="../../../Lib_{{VER}}/pages/autorecstatusdata.js"></script>
    <script src="../../../Lib_{{VER}}/pages/autorecstatus.js"></script>
</asp:Content>
<asp:Content ID="TitleRowLeftContent" runat="server" ContentPlaceHolderID="TitleRowLeftContent">
    <table style="width: 100%; height: 4px; display: none;">
        <tr>
            <td class="autoRecParmCell">
                <asp:Label ID="lblDivision" runat="server" Text="Division:"></asp:Label>
                <asp:Label ID="lblDivisionValue" runat="server" Text="Value"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="autoRecParmCell">
                <asp:Label ID="lblCustomAccess" runat="server" Text="Custom Access:"></asp:Label>
                <asp:Label ID="lblCustomAccessValue" runat="server" Text="Value"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="autoRecParmCell">
                <asp:Label ID="lblDateRange" runat="server" Text="Date Range:"></asp:Label>
                <asp:Label ID="lblDateRangeValue" runat="server" Text="Value"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="ChartContent" runat="server" ContentPlaceHolderID="ChartContent">
    <div id="viewAutoRecStatus" data-bind="with: viewAutoRecStatus">

    <!-- HEADER / TITLE -->
    <div class="printNone" style="display:flex; justify-content:space-between; width:50%;">
        <button id="btnPrint" class="grcBlueBtn" data-bind="text: 'Print', click: $parent.onClickPrint">Print</button>
        <button id="btnExit" class="grcNeutralBtn" data-bind="text: 'Exit', click: $parent.onClickExit">Exit</button>
    </div>

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="clear: both; padding-top: 0px; padding-bottom: 4px;" class="printNone"><label class="messageError" data-bind="text: $parent.messageError">Loading...</label><label class="messageNotice" data-bind="text: $parent.messageNotice"></label><label class="messageWarning" data-bind="text: $parent.messageWarning"></label>&nbsp;</div>
    <div id="trTipContainer" style="text-align: center; width: 810px;" class="printNone">
        <label id="lblTip" style="font-weight: normal; font-family: Arial; font-size: 8pt; color: red;">(Click on any value below to drill down to the Recommendation Response Follow-Up Data)</label>
    </div>

    <table>
        <tr>
            <td align="left" style="width: 70%; padding-top: 0px;" valign="top">
                <table>
                    <tr>
                        <td style="text-align: center; font-weight: bold;">
                            <asp:Label ID="lblOverall" runat="server" Text="Overall Summary"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                <div class="autoRectTableContainer">
                                    <table class="LabelTable">
                                        <tr style="font-weight: bold;">
                                            <th style="width: 154px; text-align: right; font-weight: normal;">
                                                <asp:Label ID="lblPractice" runat="server" Text=""></asp:Label>
                                            </th>
                                            <td style="text-align: center; width: 50px">
                                                <asp:Label ID="lblFire" runat="server" Text="Fire"></asp:Label>
                                            </td>
                                            <td style="text-align: center; width: 50px">
                                                <asp:Label ID="lblNatHaz" runat="server" Text="NatHaz"></asp:Label>
                                            </td>
                                            <td style="text-align: center; width: 50px">
                                                <asp:Label ID="lblBM" runat="server" Text="B&M"></asp:Label>
                                            </td>
                                            <td style="text-align: center; width: 50px">
                                                <asp:Label ID="lblInfrared" runat="server" Text="Infrared"></asp:Label>
                                            </td>
                                            <td style="text-align: center; width: 50px">
                                                <asp:Label ID="lblPS" runat="server" Text="Proc Safe"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblNoOfRequestsSent" runat="server" Text="No. of Requests Sent"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblNoOfRequestsSentFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'OverallSummary', 'NoReqSent', 'Fire', null), click: $parent.buildLink('OverallSummary', 'NoReqSent', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblNoOfRequestsSentSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'OverallSummary', 'NoReqSent', 'NatHaz', null), click: $parent.buildLink('OverallSummary', 'NoReqSent', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblNoOfRequestsSentBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'OverallSummary', 'NoReqSent', 'Boiler', null), click: $parent.buildLink('OverallSummary', 'NoReqSent', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblNoOfRequestsSentInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'OverallSummary', 'NoReqSent', 'Infrared', null), click: $parent.buildLink('OverallSummary', 'NoReqSent', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblNoOfRequestsSentPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'OverallSummary', 'NoReqSent', 'Safety', null), click: $parent.buildLink('OverallSummary', 'NoReqSent', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblPercentResponsesCompleted" runat="server" Text="% Responses Completed"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblPercentResponsesCompletedFire" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercRespComp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblPercentResponsesCompletedSeismic" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercRespComp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblPercentResponsesCompletedBM" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercRespComp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblPercentResponsesCompletedInfrared" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercRespComp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblPercentResponsesCompletedPS" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercRespComp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblPercentResponsesOutstanding" runat="server" Text="% Responses Outstanding"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FF0000; width: 50px">
                                                <a id="lblPercentResponsesOutstandingFire" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercPespOut', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FF0000; width: 50px">
                                                <a id="lblPercentResponsesOutstandingSeismic" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercPespOut', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FF0000; width: 50px">
                                                <a id="lblPercentResponsesOutstandingBM" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercPespOut', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FF0000; width: 50px">
                                                <a id="lblPercentResponsesOutstandingInfrared" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercPespOut', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FF0000; width: 50px">
                                                <a id="lblPercentResponsesOutstandingPS" class="autoRecNoLink" href="#" data-bind="text: $parent.buildData($element.id, 'dataperc', 'OverallSummary', 'PercPespOut', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center; font-weight: bold;">
                            <asp:Label ID="lblAllCompleted" runat="server" Text="All Completed"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                <div class="autoRectTableContainer">
                                    <table class="LabelTable">
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblLocsWithAllResponsesCompleted" runat="server" Text="Locs. with All Resp. Comp'd"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblLocsWithAllResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'AllCompleted', 'LocsAllRespComp', 'Fire', null), click: $parent.buildLink('AllCompleted', 'LocsAllRespComp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblLocsWithAllResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'AllCompleted', 'LocsAllRespComp', 'NatHaz', null), click: $parent.buildLink('AllCompleted', 'LocsAllRespComp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblLocsWithAllResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'AllCompleted', 'LocsAllRespComp', 'Boiler', null), click: $parent.buildLink('AllCompleted', 'LocsAllRespComp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblLocsWithAllResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'AllCompleted', 'LocsAllRespComp', 'Infrared', null), click: $parent.buildLink('AllCompleted', 'LocsAllRespComp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#00FF00; width: 50px">
                                                <a id="lblLocsWithAllResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'AllCompleted', 'LocsAllRespComp', 'Safety', null), click: $parent.buildLink('AllCompleted', 'LocsAllRespComp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center; font-weight: bold;">
                            <asp:Label ID="lblPartialCompleted" runat="server" Text="Partial Completed"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                <div class="autoRectTableContainer">
                                    <table class="LabelTable">
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblLocsWithPartialResponsesCompleted" runat="server" Text="Locs. With Partial Comp'd"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FFFF00; width: 50px">
                                                <a id="lblLocsWithPartialResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'LocsPartRespComp', 'Fire', null), click: $parent.buildLink('PartialCompleted', 'LocsPartRespComp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FFFF00; width: 50px">
                                                <a id="lblLocsWithPartialResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'LocsPartRespComp', 'NatHaz', null), click: $parent.buildLink('PartialCompleted', 'LocsPartRespComp', 'Seismic', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FFFF00; width: 50px">
                                                <a id="lblLocsWithPartialResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'LocsPartRespComp', 'Boiler', null), click: $parent.buildLink('PartialCompleted', 'LocsPartRespComp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FFFF00; width: 50px">
                                                <a id="lblLocsWithPartialResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'LocsPartRespComp', 'Infrared', null), click: $parent.buildLink('PartialCompleted', 'LocsPartRespComp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color:#FFFF00; width: 50px">
                                                <a id="lblLocsWithPartialResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'LocsPartRespComp', 'Safety', null), click: $parent.buildLink('PartialCompleted', 'LocsPartRespComp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblFollowUpStagePartialResponsesCompleted" runat="server" Text="Follow-Up Stage:"></asp:Label>
                                            </th>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblInitialRequestPartialResponsesCompleted" runat="server" Text="Initial Request"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestPartialResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'InitialRequest', 'Fire', null), click: $parent.buildLink('PartialCompleted', 'InitialRequest', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestPartialResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'InitialRequest', 'NatHaz', null), click: $parent.buildLink('PartialCompleted', 'InitialRequest', 'Seismic', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestPartialResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'InitialRequest', 'Boiler', null), click: $parent.buildLink('PartialCompleted', 'InitialRequest', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestPartialResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'InitialRequest', 'Infrared', null), click: $parent.buildLink('PartialCompleted', 'InitialRequest', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestPartialResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', 'InitialRequest', 'Safety', null), click: $parent.buildLink('PartialCompleted', 'InitialRequest', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblFirstFollowUpPartialResponsesCompleted" runat="server" Text="1st Follow-Up"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpPartialResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '1stFollowUp', 'Fire', null), click: $parent.buildLink('PartialCompleted', '1stFollowUp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpPartialResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '1stFollowUp', 'Seismic', null), click: $parent.buildLink('PartialCompleted', '1stFollowUp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpPartialResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '1stFollowUp', 'Boiler', null), click: $parent.buildLink('PartialCompleted', '1stFollowUp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpPartialResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '1stFollowUp', 'Infrared', null), click: $parent.buildLink('PartialCompleted', '1stFollowUp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpPartialResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '1stFollowUp', 'Safety', null), click: $parent.buildLink('PartialCompleted', '1stFollowUp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblSecondFollowUpPartialResponsesCompleted" runat="server" Text="2nd Follow-Up"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpPartialResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '2ndFollowUp', 'Fire', null), click: $parent.buildLink('PartialCompleted', '2ndFollowUp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpPartialResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '2ndFollowUp', 'Seismic', null), click: $parent.buildLink('PartialCompleted', '2ndFollowUp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpPartialResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '2ndFollowUp', 'Boiler', null), click: $parent.buildLink('PartialCompleted', '2ndFollowUp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpPartialResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '2ndFollowUp', 'Infrared', null), click: $parent.buildLink('PartialCompleted', '2ndFollowUp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpPartialResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '2ndFollowUp', 'Safety', null), click: $parent.buildLink('PartialCompleted', '2ndFollowUp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblThirdFollowUpPartialResponsesCompleted" runat="server" Text="3rd Follow-Up"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblThirdFollowUpPartialResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '3rdFollowUp', 'Fire', null), click: $parent.buildLink('PartialCompleted', '3rdFollowUp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblThirdFollowUpPartialResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '3rdFollowUp', 'Seismic', null), click: $parent.buildLink('PartialCompleted', '3rdFollowUp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblThirdFollowUpPartialResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '3rdFollowUp', 'Boiler', null), click: $parent.buildLink('PartialCompleted', '3rdFollowUp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblThirdFollowUpPartialResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '3rdFollowUp', 'Infrared', null), click: $parent.buildLink('PartialCompleted', '3rdFollowUp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblThirdFollowUpPartialResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'PartialCompleted', '3rdFollowUp', 'Safety', null), click: $parent.buildLink('PartialCompleted', '3rdFollowUp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center; font-weight: bold;">
                            <asp:Label ID="lblNoneCompleted" runat="server" Text="None Completed"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                <div class="autoRectTableContainer">
                                    <table class="LabelTable">
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblLocsWithNoResponsesCompleted" runat="server" Text="Locs. With No Resp. Comp'd"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblLocsWithNoResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'LocsNoRespComp', 'Fire', null), click: $parent.buildLink('NoneCompleted', 'LocsNoRespComp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblLocsWithNoResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'LocsNoRespComp', 'NatHaz', null), click: $parent.buildLink('NoneCompleted', 'LocsNoRespComp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblLocsWithNoResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'LocsNoRespComp', 'Boiler', null), click: $parent.buildLink('NoneCompleted', 'LocsNoRespComp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblLocsWithNoResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'LocsNoRespComp', 'Infrared', null), click: $parent.buildLink('NoneCompleted', 'LocsNoRespComp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblLocsWithNoResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'LocsNoRespComp', 'Safety', null), click: $parent.buildLink('NoneCompleted', 'LocsNoRespComp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblFollowUpStageNoResponsesCompleted" runat="server" Text="Follow-Up Stage:"></asp:Label>
                                            </th>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblInitialRequestNoResponsesCompleted" runat="server" Text="Initial Request"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestNoResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'InitialRequest', 'Fire', null), click: $parent.buildLink('NoneCompleted', 'InitialRequest', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestNoResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'InitialRequest', 'NatHaz', null), click: $parent.buildLink('NoneCompleted', 'InitialRequest', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestNoResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'InitialRequest', 'Boiler', null), click: $parent.buildLink('NoneCompleted', 'InitialRequest', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestNoResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'InitialRequest', 'Infrared', null), click: $parent.buildLink('NoneCompleted', 'InitialRequest', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblInitialRequestNoResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', 'InitialRequest', 'Safety', null), click: $parent.buildLink('NoneCompleted', 'InitialRequest', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblFirstFollowUpNoResponsesCompleted" runat="server" Text="1st Follow-Up"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpNoResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '1stFollowUp', 'Fire', null), click: $parent.buildLink('NoneCompleted', '1stFollowUp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpNoResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '1stFollowUp', 'NatHaz', null), click: $parent.buildLink('NoneCompleted', '1stFollowUp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpNoResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '1stFollowUp', 'Boiler', null), click: $parent.buildLink('NoneCompleted', '1stFollowUp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpNoResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '1stFollowUp', 'Infrared', null), click: $parent.buildLink('NoneCompleted', '1stFollowUp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblFirstFollowUpNoResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '1stFollowUp', 'Safety', null), click: $parent.buildLink('NoneCompleted', '1stFollowUp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblSecondFollowUpNoResponsesCompleted" runat="server" Text="2nd Follow-Up"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpNoResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '2ndFollowUp', 'Fire', null), click: $parent.buildLink('NoneCompleted', '2ndFollowUp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpNoResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '2ndFollowUp', 'NatHaz', null), click: $parent.buildLink('NoneCompleted', '2ndFollowUp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpNoResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '2ndFollowUp', 'Boiler', null), click: $parent.buildLink('NoneCompleted', '2ndFollowUp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpNoResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '2ndFollowUp', 'Infrared', null), click: $parent.buildLink('NoneCompleted', '2ndFollowUp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; width: 50px">
                                                <a id="lblSecondFollowUpNoResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '2ndFollowUp', 'Safety', null), click: $parent.buildLink('NoneCompleted', '2ndFollowUp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th style="text-align: right; width: 154px; font-weight: normal;">
                                                <asp:Label ID="lblThirdFollowUpNoResponsesCompleted" runat="server" Text="3rd Follow-Up"></asp:Label>
                                            </th>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblThirdFollowUpNoResponsesCompletedFire" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '3rdFollowUp', 'Fire', null), click: $parent.buildLink('NoneCompleted', '3rdFollowUp', 'Fire', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblThirdFollowUpNoResponsesCompletedSeismic" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '3rdFollowUp', 'NatHaz', null), click: $parent.buildLink('NoneCompleted', '3rdFollowUp', 'NatHaz', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblThirdFollowUpNoResponsesCompletedBM" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '3rdFollowUp', 'Boiler', null), click: $parent.buildLink('NoneCompleted', '3rdFollowUp', 'Boiler', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblThirdFollowUpNoResponsesCompletedInfrared" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '3rdFollowUp', 'Infrared', null), click: $parent.buildLink('NoneCompleted', '3rdFollowUp', 'Infrared', null)">&nbsp;</a>
                                            </td>
                                            <td style="border: 1px solid black; text-align: center; background-color: #FF0000; width: 50px">
                                                <a id="lblThirdFollowUpNoResponsesCompletedPS" class="autoRecLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NoneCompleted', '3rdFollowUp', 'Safety', null), click: $parent.buildLink('NoneCompleted', '3rdFollowUp', 'Safety', null)">&nbsp;</a>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                        </td>
                    </tr>
                </table>
            </td>
            <td align="center" style="width: 30%; padding-top: 0px;" valign="top">
                <table>
                    <tr>
                        <td style="text-align: center; font-weight: bold;">
                            <label id="lblFireStatus" style="line-height: 16px;">Fire Status</label>
                            <div class="autoRecChartContainer">
                                <div class="autorecChart" id="chartFireStatus"></div>
                                <div id="divNoRequestsFire" class="autoRecNoRecsSent">No Auto-Requests<br />Were Sent.</div>
                            </div>
                        </td>
                        <td style="text-align: center; font-weight: bold;">
                            <label id="lblInfraredStatus" style="line-height: 16px;">Infrared Status</label>
                            <div class="autoRecChartContainer">
                                <div class="autorecChart" id="chartInfraredStatus"></div>
                                <div id="divNoRequestsInfrared" class="autoRecNoRecsSent">No Auto-Requests<br />Were Sent.</div>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center; font-weight: bold;">
                            <label id="lblBoilerStatus" style="line-height: 16px;">Boiler & Machinery Status</label>
                            <div class="autoRecChartContainer">
                                <div class="autorecChart" id="chartBoilerStatus"></div>
                                <div id="divNoRequestsBoiler" class="autoRecNoRecsSent">No Auto-Requests<br />Were Sent.</div>
                            </div>
                        </td>
                        <td style="text-align: center; font-weight: bold;">
                            <label id="lblNatHazStatus" style="line-height: 16px;">NatHaz Status</label>
                            <div class="autoRecChartContainer">
                                <div class="autorecChart" id="chartNatHazStatus"></div>
                                <div id="divNoRequestsNatHaz" class="autoRecNoRecsSent">No Auto-Requests<br />Were Sent.</div>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center; font-weight: bold;">
                            <label id="lblProcessSafetyStatus" style="line-height: 16px;">Process Safety</label>
                            <div class="autoRecChartContainer">
                                <div class="autorecChart" id="chartPS"></div>
                                <div id="divNoRequestsPS" class="autoRecNoRecsSent">No Auto-Requests<br />Were Sent.</div>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

    <!-- PLEASE WAIT WINDOW FOR PROGRAM STATUS PAGE -->
    <div id="windowPleaseWait" class="windowContent printNone">
        <img src="../../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="TUV SUD GRC Client Connect - Please Wait" />
        <div id="windowPleaseWaitProcessed" style="display:flex; flex-direction:column; align-items:center; justify-content:center; font-size:13px;">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
            <div style="margin-bottom:5px;">
                <label>Thank you for your patience while the Auto-Recommendation Follow Up Status web page is being built.</label>
            </div>
            <div style="margin-bottom:5px;">
                <label>As this tool provides a statistical view of your entire program, this may take a few minutes.</label>
            </div>
            <div style="display:flex; width:100%; justify-content:center">
                <button class="grcNuetralBtn" data-bind="click: $parent.onCancelAutoRecLoad">Cancel</button>
            </div>
        </div>
        <div id="windowPleaseWaitCancelled" style="display: none;">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being cancelled</label></div>
            <div style="text-align: center;">
                <label>Please wait.</label>
                <br />&nbsp;<br />&nbsp;<br />
                <label>&nbsp;</label>
            </div>
        </div>
    </div>

    </div>
</asp:Content>
