<%@ Page Title="Fire Program Details | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectNoExit.Master" CodeBehind="DefaultClient.aspx.vb" Inherits="GRC.Connect.Web.ProgramStatus_Form_Client" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="Stylesheet" type="text/css" href="../../css/pages/programstatus.css" />
    <%--<script src="../../Lib_{{VER}}/Generated/ViewCCLocationInspectionFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationInspectionFire.js" type="text/javascript"></script>--%>
</asp:Content>

<%--<asp:Content ID="ContentFindCriteria" ContentPlaceHolderID="ContentFindCriteria" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria" data-bind="with: viewFindCriteria">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
</asp:Content>--%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<div id="view" data-bind="with: view" style="padding-left: 80px;">

    &nbsp;<br />

    <!-- HEADER / TITLE -->
    <div style="width: 815px;">
        <div style="float: left; text-align: left; padding-top: 6px;">
            <button id="btnPrint" class="k-button k-button-padding k-button-100wide" data-bind="text: 'Print', click: $parent.onClickPrint">Print</button>
            <button id="btnExit" class="k-button k-button-padding k-button-leftSpacing k-button-100wide" data-bind="text: 'Exit', click: $parent.onClickExit">Exit</button>
        </div>
        <div style="float: right; text-align: right; padding-bottom: 2px;">
            <asp:Label ID="lblCompanyNameForm" runat="server" CssClass="headerCompanyNameLarge"></asp:Label>
        </div>
        <br style="clear:both;" />
        <div>
            <div style="float: left; text-align: left;">
                <div><strong><label data-bind="text: $parent.objLanguageLabels().lblFiltered">Filtered</label>:</strong>&nbsp;&nbsp;&nbsp;<label id="lblFilteredSetting" data-bind=""></label></div>
                <div><strong><label data-bind="text: $parent.objLanguageLabels().lblCurrency">Currency</label>:</strong>&nbsp;<label id="lblCurrencySetting" data-bind=""></label></div>
            </div>
            <div style="float: right; text-align: right; width: 375px; font-size: 14pt; font-weight: bold;"><asp:Label ID="lblPageTitle" runat="server">Interactive Program Status</asp:Label></div>
        </div>
    </div>

    <div style="clear: both; height: 4px;">&nbsp;</div>

    <div style="width: 810px;">
        <!-- TABLE FOR PROGRAM STATUS INFORMATION -->
        <!-- HEADING INSPECCTION REPORT SUMMARY -->
        <div class="tableDiv programstat_HeadingTall programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal;">
            <div class="" style="line-height: normal;">
                <span class="programstat_CellLabelLeftCenter"><label class="programstat_HeadingLabelLeft"  data-bind="text: $parent.objLanguageLabels().lblInspectionReportSummary">Inspection/Report Summary</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFire">Fire</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder"><label class="programstat_HeadingLabelPractice" data-bind="html: $parent.objLanguageLabels().lblBM">B&amp;M</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblInfrared">Infrared</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblSeismic">Seismic</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFlood">Flood</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblWind">Wind</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder" style="width: 66px; border-bottom: 0px;"><label class="programstat_HeadingLabelPractice"  data-bind="text: $parent.objLanguageLabels().lblTotals">Totals</label></span>
            </div>
            <div class="" style="height: 28px;">
                <span class="programstat_CellLabelLeftCenter programstat_HeadingLabelSub"><label class="programstat_HeadingLabelSub" data-bind="text: $parent.objLanguageLabels().lblCurrentInspectionProgram">(Current Inspection Program)</label></span>
                <span class="programstat_CellX1 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label></span>
                <span class="programstat_CellX1 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label></span>
                <span class="programstat_CellX1 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label></span>
                <span class="programstat_CellX1 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label></span>
                <span class="programstat_CellX1 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label></span>
                <span class="programstat_CellX1 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblNatHazSurvey">Nat/Haz<br />Survey</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_HeadingLabelSub programstat_NoBottomBorder"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblNatHazSurvey">Nat/Haz<br />Survey</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_HeadingLabelSub programstat_BorderRight programstat_NoBottomBorder" style="width: 75px;"><label class="programstat_HeadingLabelSub" data-bind="html: $parent.objLanguageLabels().lblNatHazSurvey">Nat/Haz<br />Survey</label></span>
            </div>
        </div>
        <!-- DETAILS INSPECTION REPORT SUMMARY -->
        <div class="programstat_ContentArea programstat_NoTopBorder">
            <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionDue">No. of Inspection Due</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<2 }, click: function(data) { $parent.onBuildLink('www.google.com') }, text: '100'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '10'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '81'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '8'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '75'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '6'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '20'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '24'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '11'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '335'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionCompleted">No. of Inspection Completed</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '50'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '8'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '73'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '6'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '46'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '5'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '9'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '243'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionPending">No. of Inspection Pending</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '41'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '25'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '85'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionCancelled">No. of Inspection Cancelled</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '9'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '25'"></label></span>
                </div>
                <div>
                    <span class="programstat_RowSeparator">&nbsp;</span>
                </div>   
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblInspectionsCompletedAndReportsDelivered">Inspections Completed and Reports Delivered</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '46'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '8'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '70'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '6'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '45'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '6'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '9'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '226'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblInspectionsScheduled">Inspections Scheduled</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '72'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '10'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '8'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '69'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '6'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '20'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '11'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '293'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblInspectionsNotYetScheduled">Inspections Not Yet Scheduled</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '28'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '6'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '36'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblTotalInspectionsCompletedScheduled">% of Total Inspections Completed and/or Scheduled</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '72%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '100%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '98%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '100%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '92%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '100%'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '100%'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '75%'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '100%'"></label></span>
                    <span class="programstat_CellX2ExtraBorder programstat_BorderLeft"><label id="" data-bind="">&nbsp;</label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblTotalInspectionsCompleted">% of Total Inspections Completed</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '50%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '80%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '90%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '75%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '61%'"></label></span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '83%'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '90%'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '75%'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '82%'"></label></span>
                    <span class="programstat_CellX2ExtraBorder programstat_NoBottomBorder programstat_BorderLeft"><label id="" data-bind="">&nbsp;</label></span>
                </div>
            </div>
        </div>
        <!-- END DETAILS FOR INSPECTION REPORT SUMMARY -->

        <div style="clear: both; height: 8px;">&nbsp;</div>

        <!-- HEADING NATURAL HAZARD EXPOSURES -->
        <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal;">
            <div class="" style="line-height: normal;">
                <span class="programstat_CellLabelLeftCenter"><label class="programstat_HeadingLabelLeft"  data-bind="text: $parent.objLanguageLabels().lblNaturalHazardExposures">Natural Hazard Exposures</label></span>
                <span class="programstat_CellX6"><label class="" data-bind="">&nbsp;</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblSeismic">Seismic</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFlood">Flood</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblWind">Wind</label></span>
                <span class="programstat_CellX2 programstat_BorderLeft programstat_NoBottomBorder" style="width: 66px;"><label class="" data-bind="">&nbsp;</label></span>
            </div>
        </div>
        <!-- DETAILS NATURAL HAZARD EXPOSURES -->
        <div class="programstat_ContentArea programstat_NoTopBorder">
            <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="">&nbsp;</label></span>
                    <span class="programstat_CellX6 programstat_ContentBorder programstat_LabelRight programstat_LabelTypeStyle"><label class="" data-bind="text: $parent.objLanguageLabels().lblNoOfLocsWithSevereExposure">No. of Locs. with a Severe Exposure</label>:&nbsp;&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<2 }, click: function(data) { $parent.onBuildLink('www.globalriskconsultants.com') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="">&nbsp;</label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="">&nbsp;</label></span>
                    <span class="programstat_CellX6 programstat_ContentBorder programstat_LabelRight programstat_LabelTypeStyle"><label class="" data-bind="text: $parent.objLanguageLabels().lblNoOfLocsWithModerateExposure">No. of Locs. with a Moderate Exposure</label>:&nbsp;&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<2 }, click: function(data) { $parent.onBuildLink('www.goccomputers.com') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="">&nbsp;</label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="">&nbsp;</label></span>
                    <span class="programstat_CellX6 programstat_ContentBorder programstat_LabelRight programstat_NoBottomBorder programstat_LabelTypeStyle"><label class="" data-bind="text: $parent.objLanguageLabels().lblNoOfLocsWithLightExposure">No. of Locs. with a Light Exposure</label>:&nbsp;&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<2 }, click: function(data) { $parent.onBuildLink('www.google.com') }, text: '18'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="">&nbsp;</label></span>
                </div>
            </div>
        </div>
        <!-- END DETAILS FOR NATURAL HAZARD EXPOSURES -->

        <div style="clear: both; height: 8px;">&nbsp;</div>

        <!-- HEADING ACTIVE REC SUMMARY -->
        <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal;">
            <div class="" style="line-height: normal;">
                <span class="programstat_CellLabelLeftCenter"><label class="programstat_HeadingLabelLeft"  data-bind="text: $parent.objLanguageLabels().lblActiveRecommendationSummary">Active Recommendation Summary</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFire">Fire</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="html: $parent.objLanguageLabels().lblBM">B&amp;M</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblInfrared">Infrared</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblSeismic">Seismic</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFlood">Flood</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblWind">Wind</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder" style="width: 66px; border-bottom: 0px;"><label class="programstat_HeadingLabelPractice"  data-bind="text: $parent.objLanguageLabels().lblTotals">Totals</label></span>
            </div>
        </div>
        <!-- DETAILS ACTIVE REC SUMMARY -->
        <div class="programstat_ContentArea programstat_NoTopBorder">
            <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE1bil">No. of Recs. with LE's > 1bil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: 'N/A'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE500mil1bil">No. of Recs. with LE's > 500mil - 1bil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: 'N/A'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE250mil500mil">No. of Recs. with LE's > 250mil - 500mil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: 'N/A'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE100mil250mil">No. of Recs. with LE's > 100mil - 250mil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: 'N/A'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE50mil100mil">No. of Recs. with LE's > 50mil - 100mil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: 'N/A'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE25mil50mil">No. of Recs. with LE's > 25mil - 50mil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: 'N/A'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE10mil25mil">No. of Recs. with LE's > 10mil - 25mil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: 'N/A'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                </div>
                <div>
                    <span class="programstat_RowSeparator">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoActiveRecsWithLowImpact">No. of Active Recs with Low Impact</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '125'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '98'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '178'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '24'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '42'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '19'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '730'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoActiveRecsWithModerateImpact">No. of Active Recs with Moderate Impact</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '125'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '98'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '178'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '24'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '42'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '19'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '730'"></label></span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoActiveRecsWithHighImpact">No. of Active Recs with High Impact</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '125'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '98'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '178'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '24'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '42'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '19'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '730'"></label></span>
                </div>
                <div>
                    <span class="programstat_RowSeparator">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoActiveHumanElementRecs">No. of Active Human Element Recs.</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '6'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX9 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                </div>
            </div>
        </div>
        <!-- END DETAILS FOR ACTIVE REC SUMMARY -->

        <div style="clear: both; height: 8px;">&nbsp;</div>

        <!-- HEADING TOP 10 HIGHEST MFL -->
        <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal;">
            <div class="" style="line-height: normal;">
                <span class="programstat_CellLabelLeftCenter"><label class="programstat_HeadingLabelLeft"  data-bind="text: $parent.objLanguageLabels().lblTop10HighestMFL">Top 10 Highest MFL</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFire">Fire</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label class="programstat_HeadingLabelPractice" data-bind="html: $parent.objLanguageLabels().lblBM">B&amp;M</label></span>
                <span class="programstat_CellX9 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderLeft" style="">&nbsp;</span>
            </div>
        </div>
        <!-- DETAILS TOP 10 HIGHEST MFL -->
        <div class="programstat_ContentArea programstat_NoTopBorder">
            <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoRecsWithLE1bil">No. of Recs. with LE's > 1bil</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '24'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '17'"></label></span>
                    <span class="programstat_CellX9 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                </div>
            </div>
        </div>
        <!-- END DETAILS FOR TOP 10 HIGHEST MFL -->

        <div style="clear: both; height: 8px;">&nbsp;</div>

        <!-- HEADING FACILITY RATING SUMMARY -->
        <div class="tableDiv programstat_HeadingMedium programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal;">
            <div class="" style="line-height: normal;">
                <span class="programstat_CellLabelLeftCenter"><label class="programstat_HeadingLabelLeft"  data-bind="text: $parent.objLanguageLabels().lblFacilityRatingSummary">Facility Rating Summary</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">&nbsp;</span>
            </div>
            <div class="" style="height: 16px; line-height: normal;">
                <span class="programstat_CellLabelLeftCenter programstat_HeadingLabelSub" style="height: 16px;"><label class="programstat_HeadingLabelSub" data-bind="text: $parent.objLanguageLabels().lblLatestRecordForAllActiveLocations">(Latest Record for all Active Locations)</label></span>
                <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder" style="height: 16px;">&nbsp;</span>
            </div>
        </div>
        <!-- DETAILS FACILITY RATING SUMMARY -->
        <div class="programstat_ContentArea programstat_NoTopBorder">
            <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblAverageGRCFacilityScore">Average GRC Facility Score</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblAverageClientFacilityScore">Average Client Facility Score</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5" style="text-align: left;">
                        <div class="programstat_ChartContainer" id="divChartFireRating">
                            Chart 1 goes here.
                        </div>
                    </span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5" style="text-align: left;">
                        <div class="programstat_ChartContainer" id="divChartBMRating">
                            Chart 2 goes here.
                        </div>
                    </span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblAverageIndustryGroupUtilitiesFacilityScore">Average Industry Group (Utilities) Facility Score</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsWithTop5HighestRatings">No. of Locations With Top 5 Highest Ratings</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsWithBottom5LowestRatings">No. of Locations With Bottom 5 Lowest Ratings</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsRatedBetterRisk">No. of Locations Rated Better Risk</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsRatedTypicalRisk">No. of Locations Rated Typical Risk</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsRatedPoorerRisk">No. of Locations Rated Poorer Risk</label>:</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '74'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '79'"></label></span>
                    <span class="programstat_CellX5">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow" id="divCustomFeaturePlaceholder1" style="display: none;">
                    <span class="programstat_CellLabelLeft">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow" id="divCustomFeaturePlaceholder2" style="display: none;">
                    <span class="programstat_CellLabelLeft">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow" id="divCustomFeaturePlaceholder3" style="display: none;">
                    <span class="programstat_CellLabelLeft">&nbsp;</span>
                </div>
            </div>
        </div>
        <!-- END DETAILS FOR FACILITY RATING SUMMARY -->

        <div style="clear: both; height: 8px;">&nbsp;</div>

        <!-- HEADING IMPAIRMENTS -->
        <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal;">
            <div class="" style="line-height: normal;">
                <span class="programstat_CellLabelLeftCenter"><label class="programstat_HeadingLabelLeft"  data-bind="text: $parent.objLanguageLabels().lblImpairments">Impairments</label></span>
                <span class="programstat_CellX13 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderLeft" style="">&nbsp;</span>
            </div>
        </div>
        <!-- DETAILS IMPAIRMENTS -->
        <div class="programstat_ContentArea programstat_NoTopBorder">
            <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoPending">No. Pending</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '4'"></label></span>
                    <span class="programstat_CellX4 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 147px;"><label data-bind="text: $parent.objLanguageLabels().lblNoAdvisory">No. Advisory</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX4 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 147px;"><label data-bind="text: $parent.objLanguageLabels().lblNoRestored">No. Restored</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '126'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                </div>
            </div>
        </div>
        <!-- END DETAILS FOR IMPAIRMENTS -->

        <div style="clear: both; height: 8px;">&nbsp;</div>

        <!-- HEADING JURISDICTIONAL -->
        <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal;">
            <div class="" style="line-height: normal;">
                <span class="programstat_CellLabelLeftCenter"><label class="programstat_HeadingLabelLeft"  data-bind="text: $parent.objLanguageLabels().lblJurisdictional">Jurisdictional</label></span>
                <span class="programstat_CellX13 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderLeft" style="">&nbsp;</span>
            </div>
        </div>
        <!-- DETAILS JURISDICTIONAL -->
        <div class="programstat_ContentArea programstat_NoTopBorder">
            <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                <div class="programstat_ContentRow">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfOpenViolations">No. of Open Violations</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '3'"></label></span>
                    <span class="programstat_CellX9 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 338px;"><label data-bind="text: $parent.objLanguageLabels().lblNoOfCertificateBlockingViolations">No. of Certificate Blocking Violations</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                </div>
                <div class="programstat_ContentRow" id="divJurisObjectsOverdue">
                    <span class="programstat_CellLabelLeft programstat_LabelTypeStyle"><label data-bind="text: $parent.objLanguageLabels().lblNoOfObjectsOverdue">No. of Objects Overdue</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '3'"></label></span>
                    <span class="programstat_CellX2 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 72px;"><label data-bind="html: $parent.objLanguageLabels().lbl30To59Days">30-59 Days</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '1'"></label></span>
                    <span class="programstat_CellX2 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 72px;"><label data-bind="html: $parent.objLanguageLabels().lbl60To89Days">60-89 Days</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '0'"></label></span>
                    <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 106px;"><label data-bind="html: $parent.objLanguageLabels().lblGreaterThan90Days">&gt; 90 Days</label>:</span>
                    <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><label id="" data-bind="css: { programstat_Link: 1<0 }, click: function(data) { $parent.onBuildLink('') }, text: '2'"></label></span>
                    <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                </div>
            </div>
        </div>
        <!-- END DETAILS FOR IMPAIRMENTS -->
        <!-- END TABLES FOR PROGRAM STATUS INFORMATION -->
    </div>

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="padding-top: 20px;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="text: $parent.messageNotice"></label><label class="messageWarning" data-bind="text: $parent.messageWarning"></label>&nbsp;</div>

    <br />&nbsp;<br />

</div>--%>
<script type="text/javascript">
    //$(document).ready(function () {
    //    ///////////////////////////////////////////
    //    //// LOAD SESSION VARIABLES
    //    var dsLanguageLabels = {
    //        //// PAGE TITLE AREA
    //        lblFiltered: "Filtered",
    //        lblCurrency: "Currency",

    //        //// HEADINGS
    //        lblFire: "Fire",
    //        lblBM: "B&amp;M",
    //        lblInfrared: "Infrared",
    //        lblSeismic: "Seismic",
    //        lblFlood: "Flood",
    //        lblWind: "Wind",
    //        lblTotals: "Totals",
    //        lblInspectionReportSummary: "Inspection/Report Summary",
    //        lblCurrentInspectionProgram: "(Current Inspection Program)",
    //        lblRegInsp: "Reg.<br />Insp.",
    //        lblSpecInsp: "Spec.<br />Insp.",
    //        lblNatHazSurvey: "Nat/Haz<br />Survey",
    //        lblNaturalHazardExposures: "Natural Hazard Exposures",
    //        lblActiveRecommendationSummary: "Active Recommendation Summary",
    //        lblTop10HighestMFL: "Top 10 Highest MFL",
    //        lblFacilityRatingSummary: "Facility Rating Summary",
    //        lblLatestRecordForAllActiveLocations: "(Latest Record for all Active Locations)",
    //        lblImpairments: "Impairments",
    //        lblJurisdictional: "Jurisdictional",

    //        //// LEFT COLUMN LABELS
    //        //// Inspection/Report Summary
    //        lblNoOfInspectionDue: "No. of Inspection Due",
    //        lblNoOfInspectionCompleted: "No. of Inspection Completed",
    //        lblNoOfInspectionPending: "No. of Inspection Pending",
    //        lblNoOfInspectionCancelled: "No. of Inspection Cancelled",
    //        lblInspectionsCompletedAndReportsDelivered: "Inspections Completed and Reports Delivered",
    //        lblInspectionsScheduled: "Inspections Scheduled",
    //        lblInspectionsNotYetScheduled: "Inspections Not Yet Scheduled",
    //        lblTotalInspectionsCompletedScheduled: "% of Total Inspections Completed and/or Scheduled",
    //        lblTotalInspectionsCompleted: "% of Total Inspections Completed",
    //        //// Natural Hazard Exposures
    //        lblNoOfLocsWithSevereExposure: "No. of Locs. with a Severe Exposure",
    //        lblNoOfLocsWithModerateExposure: "No. of Locs. with a Moderate Exposure",
    //        lblNoOfLocsWithLightExposure: "No. of Locs. with a Light Exposure",
    //        //// Active Recommendation Summary
    //        lblNoRecsWithLE1bil: "No. of Recs. with LE's > 1bil",
    //        lblNoRecsWithLE500mil1bil: "No. of Recs. with LE's > 500mil - 1bil",
    //        lblNoRecsWithLE250mil500mil: "No. of Recs. with LE's > 250mil - 500mil",
    //        lblNoRecsWithLE100mil250mil: "No. of Recs. with LE's > 100mil - 250mil",
    //        lblNoRecsWithLE50mil100mil: "No. of Recs. with LE's > 50mil - 100mil",
    //        lblNoRecsWithLE25mil50mil: "No. of Recs. with LE's > 25mil - 50mil",
    //        lblNoRecsWithLE10mil25mil: "No. of Recs. with LE's > 10mil - 25mil",
    //        lblNoActiveRecsWithLowImpact: "No. of Active Recs with Low Impact",
    //        lblNoActiveRecsWithModerateImpact: "No. of Active Recs with Moderate Impact",
    //        lblNoActiveRecsWithHighImpact: "No. of Active Recs with High Impact",
    //        lblNoActiveHumanElementRecs: "No. of Active Human Element Recs.",
    //        //// Top 10 Highest MFL
    //        lblNoOfLocationsWithTop10HighestMFL: "No. of Locations with Top 10 Highest MFL",
    //        //// Facility Rating Summary
    //        lblAverageGRCFacilityScore: "Average GRC Facility Score",
    //        lblAverageClientFacilityScore: "Average Client Facility Score",
    //        lblAverageIndustryGroupUtilitiesFacilityScore: "Average Industry Group (Utilities) Facility Score",
    //        lblNoOfLocationsWithTop5HighestRatings: "No. of Locations With Top 5 Highest Ratings",
    //        lblNoOfLocationsWithBottom5LowestRatings: "No. of Locations With Bottom 5 Lowest Ratings",
    //        lblNoOfLocationsRatedBetterRisk: "No. of Locations Rated Better Risk",
    //        lblNoOfLocationsRatedTypicalRisk: "No. of Locations Rated Typical Risk",
    //        lblNoOfLocationsRatedPoorerRisk: "No. of Locations Rated Poorer Risk",
    //        //// Impairments
    //        lblNoPending: "No. Pending",
    //        lblNoAdvisory: "No. Advisory",
    //        lblNoRestored: "No. Restored",
    //        //// Jurisdictional
    //        lblNoOfOpenViolations: "No. of Open Violations",
    //        lblNoOfObjectsOverdue: "No. of Objects Overdue",
    //        lblNoOfCertificateBlockingViolations: "No. of Certificate Blocking Violations",
    //        lbl30To59Days: "30-59 Days",
    //        lbl60To89Days: "60-89 Days",
    //        lblGreaterThan90Days: "&gt; 90 Days",

    //        //// MISC
    //        lbl: "",
    //        lblLastItem: ""
    //    };


    //    ///////////////////////////////////////////
    //    //// VIEWMODELS
    //    var viewFindCriteria = {
    //        findCriteria: ko.observable()
    //    };
    //    var view = {
    //        //// DECLARATIONS
    //        index: 0,
    //        enableButtons: ko.observable(true),
    //        messageError: ko.observable(),
    //        messageWarning: ko.observable(),
    //        messageNotice: ko.observable(),
    //        stateLoadError: false,
    //        pageRequestedFrom: getQueryVariable("req"),

    //        //// COLLECTIONS / OBJECTS
    //        //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
    //        gSafeGuid: getGSafeGUID(),
    //        clientFeatures: ko.observable(),
    //        //collProgramStatus: new es.objects.ViewCCLocationListingFireCollection(),
    //        objProgramStatus: ko.observable(),
    //        objFind: ko.observable(),
    //        objLanguageLabels: ko.observable(dsLanguageLabels),

    //        //// MISC
    //        loading: ko.observable(false),

    //        //// BUTTONS FOR RECORD NAVIGATION
    //        onNext: function () {
    //        },

    //        onPrevious: function () {
    //        },

    //        onFirst: function () {
    //        },

    //        onLast: function () {
    //        },

    //        onClickPrint: function () {
    //            view.onBuildLink("../ProgramStatus/ProgramStatusReport.aspx?sid=" + view.gSafeGuid);
    //        },

    //        onClickExit: function () {
    //            document.location.href = "../Gauge/Default.aspx?sid=" + view.gSafeGuid;
    //            return false;
    //        },

    //        onBuildLink: function (pURL) {
    //            if (pURL.length > 0) {
    //                alert("Link to additional information coming soon.  Sample destination URL for popup is: " + pURL);
    //            }
    //        },

    //        //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
    //        setupButtons: function () {
    //        },

    //        //// RESET FIELDS ON LOAD RECORD
    //        resetPickers: function () {
    //        },

    //        clearAddressFields: function () {
    //        },

    //        //// CLEAR ALL FIELDS IF NO RECORDS ARE FOUND
    //        clearPickers: function () {
    //        },

    //        //// LOAD RECORDS
    //        loadDetails: function () {
    //            view.stateLoadError = false;

    //            //// LOAD THE DETAILS
    //            var tempParm = view.gSafeGuid;
    //            es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //            //if (!view.collProgramStatus.ViewCCLocationFireCollections(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }

    //            //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
    //            if (!view.stateLoadError) {
    //                //view.objProgramStatus(view.collProgramStatus()[0]);
    //                view.clientFeatures(getClientFeatures(view.gSafeGuid));
    //                view.setupButtons();
    //            } else {
    //                //// DISPLAY ERROR MESSAGE
    //                view.messageError("* Error while loading record.");
    //            }
    //        }
    //    };


    //    ///////////////////////////////////////////
    //    //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
    //    view.loadDetails();


    //    ///////////////////////////////////////////
    //    //// ACTIVATE BINDINGS LAST
    //    ko.applyBindings(view, $("#view")[0]);
    //    //ko.applyBindings(viewFindCriteria, $("#viewFindCriteria")[0]);


    //    ///////////////////////////////////////////
    //    //// SETUP KENDOUI
    //    //// TEXTBOXES


    //    //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
    //    view.resetPickers();
    //});
</script>

</asp:Content>
