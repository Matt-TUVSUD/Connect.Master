<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="Dashboard-OLD.aspx.vb" Inherits="GRC.Connect.Web.Dashboard" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Charting" TagPrefix="telerik" %>
<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- UPDATED STYLES --%>
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/icons.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeView.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeViewOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorer.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorerOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindow.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindowOffice2010Blue.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/print.css" media="print" />
    <link rel="stylesheet" type="text/css" href="../../css/EDA/eda.css" />


    <link rel="Stylesheet" type="text/css" href="../../css/pages/programstatus.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="view" data-bind="with: view" style="display:flex; align-items:center;">
        <div id="dashboardHldr">
            <grcRSC:Loader runat="server" id="loader" />
            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="Dashboards" SubHeader="Are Coming Soon" />

            <!-- HEADER / TITLE -->
            <div style="width: 815px;">
                <div style="float: left; text-align: left; padding-top: 6px; display: none" class="printNone">
                    <button id="btnPrint" class="k-button k-button-padding k-button-100wide" data-bind="text: 'Print', click: $parent.onClickPrint">Print</button>
                    <button id="btnExit" class="k-button k-button-padding k-button-leftSpacing k-button-100wide" data-bind="text: 'Exit', click: $parent.onClickExit">Exit</button>
                </div>
                <div>
                    <div style="float: left; text-align: left; display: none">
                        <div id="divCustomAccess" data-bind="visible: $parent.visibleCustomAccess"><strong>
                            <label id="lblCustomAccessLabel" data-bind="    text: $parent.lblCustomAccessLabel"></label>
                            :</strong>&nbsp;<label id="lblCustomAccessSetting" data-bind="    text: $parent.lblCustomAccessSetting"></label></div>
                        <div id="divDivision" data-bind="visible: $parent.visibleDivision"><strong>
                            <label data-bind="    text: $parent.objLanguageLabels().lblDivision">Division</label>:</strong>&nbsp;<label id="lblDivisionSetting" data-bind="    text: $parent.lblDivisionSetting"></label></div>
                        <div style="display: none"><strong>
                            <label data-bind="text: $parent.objLanguageLabels().lblCurrency">Currency</label>:</strong>&nbsp;<asp:Label ID="lblCurrencySetting" runat="server"></asp:Label></div>
                    </div>
                </div>
            </div>

            <div style="clear: both; height: 4px;">&nbsp;</div>

            <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
            <div style="padding-top: 0px; padding-bottom: 4px;" class="printNone">
                <label class="messageError" data-bind="text: $parent.messageError">Loading...</label><label class="messageNotice" data-bind="    text: $parent.messageNotice"></label><label class="messageWarning" data-bind="    text: $parent.messageWarning"></label>&nbsp;</div>

            <div style="width: 810px;">
                <!-- TABLE FOR PROGRAM STATUS INFORMATION -->
                <!-- HEADING INSPECCTION REPORT SUMMARY -->
                <div class="programstat_HeadingTall programstat_HeaderBackground programstat_TypeStyle" style="display:flex;">
                    <div style="display:flex; flex-direction:column; flex-basis: 275px; justify-content:center; align-items:center; padding:2px 6px; border-right:1px solid #999;">
                        <label style="display:flex; width:100%; align-items:center; justify-content:center;" class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblInspectionReportSummary">Inspection/Report Summary</label>
                        <label style="display:flex; width:100%; align-items:center; justify-content:center; height:auto;" class="programstat_HeadingLabelSub" data-bind="text: $parent.objLanguageLabels().lblCurrentInspectionProgram">(Current Inspection Program)</label>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFire">Fire</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label>
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="html: $parent.objLanguageLabels().lblBM">B&amp;M</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label>
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblInfrared">Infrared</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label>
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblNatHaz">NatHaz</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label>
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblDivSrvs">DivSrvs</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label>
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblProcSafe">PS</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblRegInsp">Reg. Insp.</label>
                            <label class="programstat_HeadingLabelSub serviceBottomHalf" style="" data-bind="html: $parent.objLanguageLabels().lblSpecInsp">Spec. Insp.</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="border-right:none;">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblTotals">Totals</label>
                        </div>
                        <div class="serviceBottom" style="">
                            &nbsp;
                        </div>
                    </div>
                </div>
                <!-- DETAILS INSPECTION REPORT SUMMARY -->
                <div class="programstat_ContentArea programstat_NoTopBorder" style="">
                    <div class="programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionDue">No. of Inspection Due</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueRegFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Fire', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Fire', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueSpcFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Fire', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Fire', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueRegBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Boiler', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Boiler', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueSpcBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Boiler', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Boiler', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueRegIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Infrared', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Infrared', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueSpcIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Infrared', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Infrared', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueRegNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'NatHaz', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'NatHaz', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueSpcHatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'NatHaz', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'NatHaz', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueRegDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'DivSrvs', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'DivSrvs', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueSpcDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'DivSrvs', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'DivSrvs', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueRegPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Safety', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Safety', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspDueSpcPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Safety', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDue', 'Safety', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="InspDueRegTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDue', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionCompleted">No. of Inspection Completed</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompRegFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Fire', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Fire', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompSpcFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Fire', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Fire', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompRegBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Boiler', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Boiler', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompSpcBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Boiler', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Boiler', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompRegIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Infrared', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Infrared', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompSpcIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Infrared', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Infrared', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompRegNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'NatHaz', 'NatHazSurv'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'NatHaz', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompSpcNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'NatHaz', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'NatHaz', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompRegDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'DivSrvs', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'DivSrvs', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompSpecDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'DivSrvs', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'DivSrvs', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompRegPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Safety', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Safety', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCompSpecPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Safety', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCompleted', 'Safety', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="InspCompRegTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCompleted', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionPending">No. of Inspection Pending</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendRegFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Fire', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Fire', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendSpcFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Fire', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Fire', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendRegBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Boiler', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Boiler', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendSpcBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Boiler', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Boiler', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendRegIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Infrared', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Infrared', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendSpcIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Infrared', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Infrared', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendRegNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'NatHaz', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'NatHaz', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendSpcNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'NatHaz', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'NatHaz', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendRegDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'DivSrvs', 'NatHazSurv'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'DivSrvs', 'NatHazSurv')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendSpcDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'DivSrvs', 'NatHazSurv'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'DivSrvs', 'NatHazSurv')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendRegPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Safety', 'NatHazSurv'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Safety', 'NatHazSurv')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspPendSpcPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Safety', 'NatHazSurv'), click: $parent.buildLink('InspRptSum', 'NoInspPending', 'Safety', 'NatHazSurv')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="InspPendRegTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspPending', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfInspectionCancelled">No. of Inspection Cancelled</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlRegFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Fire', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Fire', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlSpcFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Fire', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Fire', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlRegBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Boiler', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Boiler', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlSpcBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Boiler', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Boiler', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlRegIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Infrared', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Infrared', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlSpcIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Infrared', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Infrared', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlRegNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'NatHaz', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'NatHaz', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlSpcNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'NatHaz', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'NatHaz', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlRegDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'DivSrvs', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'DivSrvs', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlSpcDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'DivSrvs', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'DivSrvs', 'SpcEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlRegPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Safety', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Safety', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspCxlSpcPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Safety', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspCancelled', 'Safety', 'SpcEval')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="InspCxlRegTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspCancelled', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div>
                            <span class="programstat_RowSeparator">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblInspectionsCompletedAndReportsDelivered">Inspections Delivered</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvRegFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Fire', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Fire', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvSpcFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Fire', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Fire', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvRegBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Boiler', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Boiler', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvSpcBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Boiler', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Boiler', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvRegIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Infrared', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Infrared', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvSpcIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Infrared', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Infrared', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvRegNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'NatHaz', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'NatHaz', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvSpcNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'NatHaz', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'NatHaz', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvRegDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'DivSrvs', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'DivSrvs', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvSpcDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'DivSrvs', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'DivSrvs', 'NatHazSurv')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvRegPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Safety', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Safety', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvSpcPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Safety', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspDelivered', 'Safety', 'NatHazSurv')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop"><a id="InspDelvRegTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspDelivered', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblInspectionsScheduled">Inspections Scheduled</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedRegFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Fire', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Fire', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedSpcFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Fire', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Fire', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedRegBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Boiler', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Boiler', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedSpcBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Boiler', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Boiler', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedRegIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Infrared', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Infrared', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedSpcIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Infrared', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Infrared', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedRegNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'NatHaz', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'NatHaz', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedSpcNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'NatHaz', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'NatHaz', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedRegDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'DivSrvs', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'DivSrvs', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedSpcDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'DivSrvs', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'DivSrvs', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedRegPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Safety', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Safety', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspSchedSpcPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Safety', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspSched', 'Safety', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="InspSchedRegTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspSched', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblInspectionsNotYetScheduled">Inspections Not Yet Scheduled</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedRegFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Fire', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Fire', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedSpcFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Fire', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Fire', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedRegBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Boiler', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Boiler', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedSpcBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Boiler', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Boiler', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedRegIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Infrared', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Infrared', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedSpcIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Infrared', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Infrared', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedRegNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'NatHaz', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'NatHaz', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedSpcNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'NatHaz', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'NatHaz', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedRegDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'DivSrvs', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'DivSrvs', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedSpcDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'DivSrvs', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'DivSrvs', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedRegPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Safety', 'RegInsp'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Safety', 'RegInsp')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="InspNotSchedSpcPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Safety', 'SpecEval'), click: $parent.buildLink('InspRptSum', 'NoInspNotSched', 'Safety', 'SpecEval')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="InspNotSchedRegTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'InspRptSum', 'NoInspNotSched', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span style="width:281px;" class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblTotalInspectionsCompletedScheduled">% of Total Inspections Completed and/or Scheduled</label>:</span>
                            <span style="width:37px;" class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedRegFire" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Fire', 'RegInsp')">&nbsp;</label></span>
                            <span  class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedSpcFire" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Fire', 'SpecEval')">&nbsp;</label></span>
                            <span style="width:37px;" class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedRegBM" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Boiler', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedSpcBM" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Boiler', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedRegIR" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Infrared', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedSpcIR" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Infrared', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedRegNatHaz" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'NatHaz', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedSpcNatHaz" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'NatHaz', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedRegDivSrvs" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'DivSrvs', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedSpcDivSrvs" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'DivSrvs', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedRegPS" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Safety', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder">
                                <label id="InspPcntSchedSpcPS" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspSched', 'Safety', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX2ExtraBorder programstat_BorderLeft">
                                <label id="" data-bind="">&nbsp;</label></span>
                        </div>
                        <div class="programstat_ContentRow" style="border-bottom:none;">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblTotalInspectionsCompleted">% of Total Inspections Completed</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompRegFire" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Fire', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompSpcFire" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Fire', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompRegBM" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Boiler', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompSpcBM" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Boiler', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompRegIR" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Infrared', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompSpcIR" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Infrared', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompRegNatHaz" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'NatHaz', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompSpecNatHaz" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'NatHaz', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompRegDivSrvs" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'DivSrvs', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompSpecDivSrvs" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'DivSrvs', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompRegPS" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Safety', 'RegInsp')">&nbsp;</label></span>
                            <span class="programstat_CellX1 programstat_ContentBorder" style="border-bottom:none;">
                                <label id="InspPcntCompSpecPS" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'dataperc', 'InspRptSum', 'TotalInspComp', 'Safety', 'SpecEval')">&nbsp;</label></span>
                            <span class="programstat_CellX2ExtraBorder programstat_NoBottomBorder programstat_BorderLeft">
                                <label id="Label1" data-bind="">&nbsp;</label></span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR INSPECTION REPORT SUMMARY -->

                <div style="clear: both; height: 8px;">&nbsp;</div>

                <!-- HEADING PROJECT MANAGEMENT SUMMARY -->
                <div class="programstat_HeadingProjectManagement programstat_HeaderBackground programstat_TypeStyle" style="display:flex;">
                    <div style="display:flex; flex-direction:column; flex-basis: 275px; justify-content:center; align-items:center; padding:2px 6px; border-right:1px solid #999;">
                        <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblProjectManagementSummary">Inspection/Report Summary</label>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFire">Fire</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblOpen">Open</label>
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" data-bind="html: $parent.objLanguageLabels().lblClosed">Closed</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="html: $parent.objLanguageLabels().lblBM">B&amp;M</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblOpen">Open</label>
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" data-bind="html: $parent.objLanguageLabels().lblClosed">Closed</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblInfrared">Infrared</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblOpen">Open</label>
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" data-bind="html: $parent.objLanguageLabels().lblClosed">Closed</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblNatHaz">NatHaz</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblOpen">Open</label>
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" data-bind="html: $parent.objLanguageLabels().lblClosed">Closed</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblDivSrvs">DivSrvs</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblOpen">Open</label>
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" data-bind="html: $parent.objLanguageLabels().lblClosed">Closed</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblProcSafe">PS</label>
                        </div>
                        <div class="serviceBottom" style="">
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" style="border-right:1px solid #999;" data-bind="html: $parent.objLanguageLabels().lblOpen">Open</label>
                            <label class="programstat_HeadingLabelProjectOpenClose serviceBottomHalf" data-bind="html: $parent.objLanguageLabels().lblClosed">Closed</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblTotals">Totals</label>
                        </div>
                        <div class="serviceBottom" style="">
                            &nbsp;
                        </div>
                    </div>
                </div>
                <!-- DETAILS PROJECT MANAGEMENT SUMMARY -->
                <div class="programstat_ContentArea programstat_NoTopBorder">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfProjects">No. of Porjects</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjOpenFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Fire', 'Open'), click: $parent.buildLink('Project Management', 'Projects', 'Fire', 'Open')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjClosedFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Fire', 'Closed'), click: $parent.buildLink('Project Management', 'Projects', 'Fire', 'Closed')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjOpenBoiler" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Boiler', 'Open'), click: $parent.buildLink('Project Management', 'Projects', 'Boiler', 'Open')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjClosedBoiler" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Boiler', 'Closed'), click: $parent.buildLink('Project Management', 'Projects', 'Boiler', 'Closed')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjOpenInfrared" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Infrared', 'Open'), click: $parent.buildLink('Project Management', 'Projects', 'Infrared', 'Open')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjClosedInfrared" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Infrared', 'Closed'), click: $parent.buildLink('Project Management', 'Projects', 'Infrared', 'Closed')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjOpenNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'NatHaz', 'Open'), click: $parent.buildLink('Project Management', 'Projects', 'NatHaz', 'Open')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjClosedNatHaz" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'NatHaz', 'Closed'), click: $parent.buildLink('Project Management', 'Projects', 'NatHaz', 'Closed')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjOpenDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'DivSrvs', 'Open'), click: $parent.buildLink('Project Management', 'Projects', 'DivSrvs', 'Open')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjClosedDivSrvs" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'DivSrvs', 'Closed'), click: $parent.buildLink('Project Management', 'Projects', 'DivSrvs', 'Closed')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjOpenSafety" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Safety', 'Open'), click: $parent.buildLink('Project Management', 'Projects', 'Safety', 'Open')">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ProjClosedSafety" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Safety', 'Closed'), click: $parent.buildLink('Project Management', 'Projects', 'Safety', 'Closed')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="ProjTotals" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Project Management', 'Projects', 'Totals', 'Total'), click: $parent.buildLink('Project Management', 'Projects', 'Totals', 'Total')">&nbsp;</a></span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR PROJECT MANAGEMENT SUMMARY -->

                <div style="clear: both; height: 8px;">&nbsp;</div>

                <!-- HEADING ACTIVE REC SUMMARY -->
                <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal; display: none">
                    <div class="" style="line-height: normal;">
                        <span class="programstat_CellLabelLeftCenter">
                            <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblActiveRecommendationSummary">Active Recommendation Summary</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFire">Fire</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                            <label class="programstat_HeadingLabelPractice" data-bind="html: $parent.objLanguageLabels().lblBM">B&amp;M</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblInfrared">Infrared</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblNatHaz">NatHaz</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                            <label class="programstat_HeadingLabelPractice">&nbsp;</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblProcSafe">ProcSafe</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder" style="width: 66px; border-bottom: 0px;">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblTotals">Totals</label></span>
                    </div>
                </div>
                <!-- DETAILS ACTIVE REC SUMMARY -->
                <div class="programstat_ContentArea programstat_NoTopBorder" style="display: none">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'ActiveRecSum', 'ActRecSumKey13', 'Fire', null, 'No. of Recs. with LEs > 1bil')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE1BilFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey13', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey13', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE1BilBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey13', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey13', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder">
                                <label class="wide100" data-bind="text: $parent.objLanguageLabels().lblNA">N/A</label></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE1BilSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey13', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey13', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE1BilPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey13', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey13', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE1BilTotal" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey13', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'ActiveRecSum', 'ActRecSumKey12', 'Fire', null, 'No. of Recs. with LEs > 500mil - 1bil')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE500MilTo1BilFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey12', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey12', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE500MilTo1BilBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey12', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey12', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder">
                                <label class="wide100" data-bind="text: $parent.objLanguageLabels().lblNA">N/A</label></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE500MilTo1BilSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey12', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey12', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE500MilTo1BilPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey12', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey12', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE500MilTo1BilTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey12', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'ActiveRecSum', 'ActRecSumKey11', 'Fire', null, 'No. of Recs. with LEs > 250mil - 500mil')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE250MilTo500MilFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey11', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey11', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE250MilTo500MilBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey11', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey11', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder">
                                <label class="wide100" data-bind="text: $parent.objLanguageLabels().lblNA">N/A</label></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE250MilTo500MilSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey11', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey11', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE250MilTo500MilPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey11', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey11', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE250MilTo500MilTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey11', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'ActiveRecSum', 'ActRecSumKey10', 'Fire', null, 'No. of Recs. with LEs > 100mil - 250mil')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE100MilTo250MilFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey10', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey10', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE100MilTo250MilBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey10', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey10', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder">
                                <label class="wide100" data-bind="text: $parent.objLanguageLabels().lblNA">N/A</label></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE100MilTo250MilSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey10', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey10', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE100MilTo250MilPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey10', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey10', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE100MilTo250MilTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey10', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'ActiveRecSum', 'ActRecSumKey9', 'Fire', null, 'No. of Recs. with LEs > 50mil - 100mil')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE50MilTo100MilFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey9', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey9', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE50MilTo100MilBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey9', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey9', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder">
                                <label class="wide100" data-bind="text: $parent.objLanguageLabels().lblNA">N/A</label></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE50MilTo100MilSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey9', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey9', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE50MilTo100MilPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey9', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey9', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE50MilTo100MilTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey9', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'ActiveRecSum', 'ActRecSumKey8', 'Fire', null, 'No. of Recs. with LEs > 25mil - 50mil')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE25MilTo50MilFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey8', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey8', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE25MilTo50MilBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey8', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey8', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder">
                                <label class="wide100" data-bind="text: $parent.objLanguageLabels().lblNA">N/A</label></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE25MilTo50MilSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey8', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey8', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE25MilTo50MilPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey8', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey8', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE25MilTo50MilTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey8', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'ActiveRecSum', 'ActRecSumKey7', 'Fire', null, 'No. of Recs. with LEs > 10mil - 25mil')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE10MilTo25MilFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey7', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey7', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE10MilTo25MilBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey7', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey7', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder">
                                <label class="wide100" data-bind="text: $parent.objLanguageLabels().lblNA">N/A</label></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE10MilTo25MilSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey7', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey7', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE10MilTo25MilPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey7', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'ActRecSumKey7', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder"><a id="RecLE10MilTo25MilTotal" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'ActRecSumKey7', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div>
                            <span class="programstat_RowSeparator">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoActiveRecsWithLowImpact">No. of Active Recs with Low Impact</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><a id="RecLowImpactFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsLowImpact', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsLowImpact', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><a id="RecLowImpactBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsLowImpact', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsLowImpact', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><a id="RecLowImpactIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsLowImpact', 'Infrared', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsLowImpact', 'Infrared', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><a id="RecLowImpactSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsLowImpact', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsLowImpact', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><a id="RecLowImpactPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsLowImpact', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsLowImpact', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop backColorGreen"><a id="RecLowImpactTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsLowImpact', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoActiveRecsWithModerateImpact">No. of Active Recs with Moderate Impact</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="RecModerateImpactFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsModerateImpact', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsModerateImpact', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="RecModerateImpactBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsModerateImpact', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsModerateImpact', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="RecModerateImpactIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsModerateImpact', 'Infrared', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsModerateImpact', 'Infrared', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="RecModerateImpactSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsModerateImpact', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsModerateImpact', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="RecModerateImpactPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsModerateImpact', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsModerateImpact', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="RecModerateImpactTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsModerateImpact', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoActiveRecsWithHighImpact">No. of Active Recs with High Impact</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="RecHighImpactFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsHighImpact', 'Fire', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsHighImpact', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="RecHighImpactBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsHighImpact', 'Boiler', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsHighImpact', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="RecHighImpactIR" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsHighImpact', 'Infrared', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsHighImpact', 'Infrared', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="RecHighImpactSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsHighImpact', 'NatHaz', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsHighImpact', 'NatHaz', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="RecHighImpactPS" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsHighImpact', 'Safety', null), click: $parent.buildLink('ActiveRecSum', 'NoRecsHighImpact', 'Safety', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="RecHighImpactTotal" class="winde100 programstat_NoLink" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoRecsHighImpact', 'Totals', null)">&nbsp;</a></span>
                        </div>
                        <div>
                            <span class="programstat_RowSeparator">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoActiveHumanElementRecs">No. of Active Human Element Recs.</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop programstat_NoBottomBorder"><a id="RecHeFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoActiveHERecs', 'Fire', ''), click: $parent.buildLink('ActiveRecSum', 'NoActiveHERecs', 'Fire', '')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderTop programstat_NoBottomBorder"><a id="RecHeBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'ActiveRecSum', 'NoActiveHERecs', 'Boiler', ''), click: $parent.buildLink('ActiveRecSum', 'NoActiveHERecs', 'Boiler', '')">&nbsp;</a></span>
                            <span class="programstat_CellX9 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR ACTIVE REC SUMMARY -->

                <div style="clear: both; height: 8px;" class="">&nbsp;</div>

                <!-- HEADING INFRARED SECTION -->
                <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal; display: none">
                    <div class="" style="line-height: normal;">
                        <span class="programstat_CellLabelLeftCenterLong">
                            <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblInfraredRecSeverityCounts">Infrared Recommendation Severity Counts</label></span>
                    </div>
                </div>
                <!-- DETAILS INFRARED SECTION -->
                <div class="programstat_ContentArea programstat_NoTopBorder" style="display: none">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeftShort programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfFourStars">No. of ****</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRRed"><a id="IRRecSeverityNoFourStar" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecSeverity', 'NoFourStar', null, null), click: $parent.buildLink('IRRecSeverity', 'NoFourStar', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfThreeStars">No. of ***</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRYellow"><a id="IRRecSeverityNoThreeStar" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecSeverity', 'NoThreeStar', null, null), click: $parent.buildLink('IRRecSeverity', 'NoThreeStar', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfTwoStars">No. of **</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRGreen"><a id="IRRecSeverityNoTwoStar" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecSeverity', 'NoTwoStar', null, null), click: $parent.buildLink('IRRecSeverity', 'NoTwoStar', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfOneStars">No. of *</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRBlue"><a id="IRRecSeverityNoOneStar" class="winde100 programstat_Link" style="color: #FFFFFF !important;" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecSeverity', 'NoOneStar', null, null), click: $parent.buildLink('IRRecSeverity', 'NoOneStar', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfFYI">No. of FYI</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backNoColor"><a id="IRRecSeverityNoFYI" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecSeverity', 'NoFYI', null, null), click: $parent.buildLink('IRRecSeverity', 'NoFYI', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR INFRARED SECTION -->

                <div style="clear: both; height: 8px;" class="">&nbsp;</div>

                <!-- HEADING INFRARED REC. SECTION -->
                <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal; display: none">
                    <div class="" style="line-height: normal;">
                        <span class="programstat_CellLabelLeftCenterLong">
                            <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblInfraredRecLengthBusInt">Infrared Recommendation Length of Business Interruption Counts</label></span>
                    </div>
                </div>
                <!-- DETAILS INFRARED REC. SECTION -->
                <div class="programstat_ContentArea programstat_NoTopBorder" style="display: none">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeftShort programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblOneDay">1 Day</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRGreen"><a id="IRRecLBIOneDay" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'OneDay', null, null), click: $parent.buildLink('IRRecLBI', 'OneDay', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblTwoDay">2 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRGreen"><a id="IRRecLBITwoDays" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'TwoDays', null, null), click: $parent.buildLink('IRRecLBI', 'TwoDays', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblThreeDay">3 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRGreen"><a id="IRRecLBIThreeDays" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'ThreeDays', null, null), click: $parent.buildLink('IRRecLBI', 'ThreeDays', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblFourDay">4 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRYellow"><a id="IRRecLBIFourDays" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'FourDays', null, null), click: $parent.buildLink('IRRecLBI', 'FourDays', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblFiveDay">5 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRYellow"><a id="IRRecLBIFiveDays" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'FiveDays', null, null), click: $parent.buildLink('IRRecLBI', 'FiveDays', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblSixDay">6 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRYellow"><a id="IRRecLBISixDays" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'SixDays', null, null), click: $parent.buildLink('IRRecLBI', 'SixDays', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeftShort programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblOneWeek">1 Week</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRRed"><a id="IRRecLBIOneWeek" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'OneWeek', null, null), click: $parent.buildLink('IRRecLBI', 'OneWeek', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblTwoWeek">2 Weeks</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRRed"><a id="IRRecLBITwoWeeks" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'TwoWeeks', null, null), click: $parent.buildLink('IRRecLBI', 'TwoWeeks', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblThreeWeek">3 Weeks</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRRed"><a id="IRRecLBIThreeWeeks" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'ThreeWeeks', null, null), click: $parent.buildLink('IRRecLBI', 'ThreeWeeks', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblOneMonth">1 Month</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRRed"><a id="IRRecLBIOneMonth" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'OneMonth', null, null), click: $parent.buildLink('IRRecLBI', 'OneMonth', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 75px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblGreaterOneMonth">&gt; 1 Month</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder backColorIRRed"><a id="IRRecLBIMoreThanOneMonth" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'IRRecLBI', 'MoreThanOneMonth', null, null), click: $parent.buildLink('IRRecLBI', 'MoreThanOneMonth', null, null)">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR INFRARED REC. SECTION -->

                <div style="clear: both; height: 8px;" class="">&nbsp;</div>

                <!-- HEADING TOP 10 HIGHEST MFL -->
                <div class="programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="display:flex;">
                    <div style="display:flex; flex-direction:column; flex-basis:275px; justify-content:center; align-items:center; padding:2px 6px; border-right:1px solid #999;">
                        <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblTop10HighestMFL">Top 10 Highest MFL</label>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="height:100%;">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFire">Fire</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="height:100%;">
                            <label class="programstat_HeadingLabelPractice" data-bind="html: $parent.objLanguageLabels().lblBM">B&amp;M</label>
                        </div>
                    </div>
                </div>
                <!-- DETAILS TOP 10 HIGHEST MFL -->
                <div class="programstat_ContentArea programstat_NoTopBorder">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsWithTop10HighestMFL">No. of Locations with Top 10 Highest MFL</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><a id="LEHighestMFLFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Top10MFL', 'NoLocTop10MFL', 'Fire', ''), click: $parent.buildLink('Top10MFL', 'NoLocTop10MFL', 'Fire', '')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder"><a id="LEHighestMFLBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Top10MFL', 'NoLocTop10MFL', 'Boiler', ''), click: $parent.buildLink('Top10MFL', 'NoLocTop10MFL', 'Boiler', '')">&nbsp;</a></span>
                            <span class="programstat_CellX9 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR TOP 10 HIGHEST MFL -->

                <div style="clear: both; height: 8px;">&nbsp;</div>

                <!-- HEADING NATURAL HAZARD EXPOSURES -->
                <div class="programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="display:flex;">
                    <div style="display:flex; flex-direction:column; flex-basis:275px; justify-content:center; align-items:center; padding:2px 5px; border-right:1px solid #999;">
                        <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblNaturalHazardExposures">Natural Hazard Exposures</label>
                    </div>
                    <div class="serviceBox" style="flex-basis:224px;">
                        &nbsp;
                    </div>
                    <div class="serviceBox" style="flex-basis:73px;">
                        <div class="serviceTop" style="height: 100%;">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblSeismic">Seismic</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="flex-basis:74px;">
                        <div class="serviceTop" style="height: 100%;">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblFlood">Flood</label>
                        </div>
                    </div>
                    <div class="serviceBox" style="">
                        <div class="serviceTop" style="height: 100%;">
                            <label class="programstat_HeadingLabelPractice" data-bind="text: $parent.objLanguageLabels().lblWind">Wind</label>
                        </div>
                    </div>
                </div>
                <!-- DETAILS NATURAL HAZARD EXPOSURES -->
                <div class="programstat_ContentArea programstat_NoTopBorder">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="">&nbsp;</label></span>
                            <span class="programstat_CellX6 programstat_ContentBorder programstat_LabelRight programstat_LabelTypeStyle">
                                <label class="" data-bind="text: $parent.objLanguageLabels().lblNoOfLocsWithSevereExposure">No. of Locs. with a Severe Exposure</label>:&nbsp;&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="ExposureSevereSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocSevereExp', 'Seismic', 'Severe'), click: $parent.buildLink('NatHazExp', 'NoLocSevereExp', 'Seismic', 'Severe')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="ExposureSevereFlood" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocSevereExp', 'Flood', 'Severe'), click: $parent.buildLink('NatHazExp', 'NoLocSevereExp', 'Flood', 'Severe')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorRed"><a id="ExposureSevereWind" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocSevereExp', 'Wind', 'Severe'), click: $parent.buildLink('NatHazExp', 'NoLocSevereExp', 'Wind', 'Severe')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                                <label id="Label2" data-bind="">&nbsp;</label></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="">&nbsp;</label></span>
                            <span class="programstat_CellX6 programstat_ContentBorder programstat_LabelRight programstat_LabelTypeStyle">
                                <label class="" data-bind="text: $parent.objLanguageLabels().lblNoOfLocsWithModerateExposure">No. of Locs. with a Moderate Exposure</label>:&nbsp;&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="ExposureModerateSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocModerateExp', 'Seismic', 'Moderate'), click: $parent.buildLink('NatHazExp', 'NoLocModerateExp', 'Seismic', 'Moderate')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="ExposureModerateFlood" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocModerateExp', 'Flood', 'Moderate'), click: $parent.buildLink('NatHazExp', 'NoLocModerateExp', 'Flood', 'Moderate')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorYellow"><a id="ExposureModerateWind" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocModerateExp', 'Wind', 'Moderate'), click: $parent.buildLink('NatHazExp', 'NoLocModerateExp', 'Wind', 'Moderate')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                                <label id="Label3" data-bind="">&nbsp;</label></span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="">&nbsp;</label></span>
                            <span class="programstat_CellX6 programstat_ContentBorder programstat_LabelRight programstat_NoBottomBorder programstat_LabelTypeStyle">
                                <label class="" data-bind="text: $parent.objLanguageLabels().lblNoOfLocsWithLightExposure">No. of Locs. with a Light Exposure</label>:&nbsp;&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorGreen"><a id="ExposureLightSeismic" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocLightExp', 'Seismic', 'Light'), click: $parent.buildLink('NatHazExp', 'NoLocLightExp', 'Seismic', 'Light')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorGreen"><a id="ExposureLightFlood" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocLightExp', 'Flood', 'Light'), click: $parent.buildLink('NatHazExp', 'NoLocLightExp', 'Flood', 'Light')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder backColorGreen"><a id="ExposureLightWind" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'NatHazExp', 'NoLocLightExp', 'Wind', 'Light'), click: $parent.buildLink('NatHazExp', 'NoLocLightExp', 'Wind', 'Light')">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">
                                <label id="Label4" data-bind="">&nbsp;</label></span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR NATURAL HAZARD EXPOSURES -->

                <div style="clear: both; height: 8px;">&nbsp;</div>

                <!-- HEADING FACILITY RATING SUMMARY -->
                <div class="tableDiv programstat_HeadingMedium programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal; display: none">
                    <div class="" style="line-height: normal;">
                        <span class="programstat_CellLabelLeftCenter">
                            <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblFacilityRatingSummary">Facility Rating Summary</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder">&nbsp;</span>
                    </div>
                    <div class="" style="height: 16px; line-height: normal;">
                        <span class="programstat_CellLabelLeftCenter programstat_HeadingLabelSub" style="height: 16px;">
                            <label class="programstat_HeadingLabelSub" data-bind="text: $parent.objLanguageLabels().lblLatestRecordForAllActiveLocations">(Latest Record for all Active Locations)</label></span>
                        <span class="programstat_CellX2 programstat_ContentBorder programstat_NoBottomBorder" style="height: 16px;">&nbsp;</span>
                    </div>
                </div>
                <!-- DETAILS FACILITY RATING SUMMARY -->
                <div class="programstat_ContentArea programstat_NoTopBorder" style="display: none">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow" id="divAverageGRCFacilityScore" runat="server">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblAverageGRCFacilityScore">Average GRC Facility Score</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="RatingAvgGRCScoreFire" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'AveGRCScore', 'Fire', '')">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="RatingAvgGRCScoreBM" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'AveGRCScore', 'Boiler', '')">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblAverageClientFacilityScore">Average Client Facility Score</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="RatingAvgClientScoreFire" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'AveClientScore', 'Fire', '')">&nbsp;</a></span>
                            <span class="programstat_CellX5" style="text-align: left;">
                                <div class="programstat_ChartContainer" style="text-align: center;" id="divChartFireRating" runat="server">

                                    <div style="font-weight: bold; font-size: 12pt; width: 175px; text-align: center;">Fire Ratings</div>
                                    <div id="chartFireRatings"></div>

                                </div>
                            </span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="RatingAvgClientScoreBM" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'AveClientScore', 'Boiler', '')">&nbsp;</a></span>
                            <span class="programstat_CellX5" style="text-align: left;">
                                <div class="programstat_ChartContainer" style="text-align: center;" id="divChartBMRating" runat="server">

                                    <div style="font-weight: bold; font-size: 12pt; width: 175px; text-align: center;">B&amp;M Ratings</div>
                                    <div id="chartBMRatings"></div>
                                </div>
                            </span>
                        </div>
                        <div class="programstat_ContentRow" id="divAverageIndustryGroupFacilityScore" runat="server">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblAverageIndustryGroup">Average Industry Group</label>
                                (<a class="programstat_LabelBlue" data-bind="text: $parent.lblRatingIndustryGroup"></a>)
                                <label data-bind="    text: $parent.objLanguageLabels().lblFacilityScore">Score</label>:
                            </span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="RatingAvgIndustryScoreFire" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'AveIndustryScore', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'AveIndustryScore', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="RatingAvgIndustryScoreBM" class="winde100 programstat_NoLink" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'AveIndustryScore', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'AveIndustryScore', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsWithTop5HighestRatings">No. of Locations With Top 5 Highest Ratings</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="Rating5HighestFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'NoLocTop5Highest', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'NoLocTop5Highest', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="Rating5HighestBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'NoLocTop5Highest', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'NoLocTop5Highest', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow" id="divNoLocationsWithBottom5LowestRatings" runat="server">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfLocationsWithBottom5LowestRatings">No. of Locations With Bottom 5 Lowest Ratings</label>:</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="Rating5LowestFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'NoLocBottom5Lowest', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'NoLocBottom5Lowest', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5" style="text-align: center;">&nbsp;<span id="spnFireNoRatingsChart" runat="server" class="messageRedBold" style="width: 190px;">N/A</span></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight"><a id="Rating5LowestBM" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'NoLocBottom5Lowest', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'NoLocBottom5Lowest', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5" style="text-align: center;">&nbsp;<span id="spnBMNoRatingsChart" runat="server" class="messageRedBold" style="width: 190px;">N/A</span></span>
                        </div>

                        <!-- START FACILITY RATINGS -->
                        <div id="divFacilityRatingsLevel1" class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'FacilityRatingSum', 'RatingKey1', 'Fire', null, 'No. of Locations Rated Better Risk')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskFire1" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey1', 'Fire', null) }"><a id="RatingRiskFire1" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey1', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey1', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskBM1" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey1', 'Boiler', null) }"><a id="RatingRiskBM1" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey1', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey1', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <div id="divFacilityRatingsLevel2" class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'FacilityRatingSum', 'RatingKey2', 'Fire', null, 'No. of Locations Rated Typical Risk')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskFire2" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey2', 'Fire', null) }"><a id="RatingRiskFire2" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey2', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey2', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskBM2" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey2', 'Boiler', null) }"><a id="RatingRiskBM2" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey2', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey2', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <div id="divFacilityRatingsLevel3" class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'FacilityRatingSum', 'RatingKey3', 'Fire', null, 'No. of Locations Rated Poorer Risk')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskFire3" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey3', 'Fire', null) }"><a id="RatingRiskFire3" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey3', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey3', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskBM3" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey3', 'Boiler', null) }"><a id="RatingRiskBM3" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey3', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey3', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <div id="divFacilityRatingsLevel4" class="programstat_ContentRow" data-bind="visible: $parent.buildData($element.id, 'visible', 'FacilityRatingSum', 'RatingKey4', 'Fire', null)">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'FacilityRatingSum', 'RatingKey4', 'Fire', null, 'No. of Locations Rated Other Risk 4')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskFire4" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey4', 'Fire', null) }"><a id="RatingRiskFire4" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey4', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey4', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskBM4" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey4', 'Boiler', null) }"><a id="RatingRiskBM4" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey4', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey4', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <div id="divFacilityRatingsLevel5" class="programstat_ContentRow" data-bind="visible: $parent.buildData($element.id, 'visible', 'FacilityRatingSum', 'RatingKey5', 'Fire', null)">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.buildData($element.id, 'label', 'FacilityRatingSum', 'RatingKey5', 'Fire', null, 'No. of Locations Rated Other Risk 5')"></label>
                                :</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskFire5" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey5', 'Fire', null) }"><a id="RatingRiskFire5" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey5', 'Fire', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey5', 'Fire', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderRight backNoColor" id="spnRatingRiskBM5" data-bind="style: { backgroundColor: $parent.buildData($element.id, 'color', 'FacilityRatingSum', 'RatingKey5', 'Boiler', null) }"><a id="RatingRiskBM5" class="winde100 programstat_Link" href="#" data-bind="    text: $parent.buildData($element.id, 'data', 'FacilityRatingSum', 'RatingKey5', 'Boiler', null), click: $parent.buildLink('FacilityRatingSum', 'RatingKey5', 'Boiler', null)">&nbsp;</a></span>
                            <span class="programstat_CellX5">&nbsp;</span>
                        </div>
                        <!-- END FACILITY RATINGS -->

                        <div class="programstat_ContentRow" id="divCustomFeaturePlaceholder1" runat="server">
                            <span class="programstat_CellLabelLeft">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow" id="divCustomFeaturePlaceholder2" runat="server">
                            <span class="programstat_CellLabelLeft">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow" id="divCustomFeaturePlaceholder3" runat="server">
                            <span class="programstat_CellLabelLeft">&nbsp;</span>
                        </div>
                    </div>
                </div>

                <!-- END DETAILS FOR FACILITY RATING SUMMARY -->

                <div style="clear: both; height: 8px;">&nbsp;</div>

                <!-- HEADING IMPAIRMENTS -->
                <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal; display: none">
                    <div class="" style="line-height: normal;">
                        <span class="programstat_CellLabelLeftCenter">
                            <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblImpairments">Impairmentsprogramstat_NoBottomBorder programstat_BorderLeft" style="">&nbsp;</label></span>
                    </div>
                </div>
                <!-- DETAILS IMPAIRMENTS -->
                <div class="programstat_ContentArea programstat_NoTopBorder" style="display: none">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoPending">No. Pending</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ImpairmentPendingFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Impairments', 'NoPending', '', null), click: $parent.buildLink('Impairments', 'NoPending', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX4 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 100px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoAdvisory">No. Advisory</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ImpairmentAdvisoryFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Impairments', 'NoAdvisory', '', null), click: $parent.buildLink('Impairments', 'NoAdvisory', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX4 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 100px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoRestored">No. Restored</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ImpairmentRestoredFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Impairments', 'NoRestored', '', null), click: $parent.buildLink('Impairments', 'NoRestored', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX4 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 100px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOverdue">No. Overdue</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder"><a id="ImpairmentOverdueFire" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Impairments', 'NoOverdue', '', null), click: $parent.buildLink('Impairments', 'NoOverdue', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow">
                            <!-- programstat_CellLabelLeft -->
                            <span class="programstat_CellLabelLeftLong programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoLocationsUsingImpairmentsSystem">No. of Locations Using Impairment System</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><a id="ImpairmentLocationUsing" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Impairments', 'NoLocImpairments', '', null), click: $parent.buildLink('Impairments', 'NoLocImpairments', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX6 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 244px">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoLocationsNotUsingImpairmentsSystem">No. of Locations Not Using Impairment System</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><a id="ImpairmentLocationNotUsing" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Impairments', 'NoLocNoImpairments', '', null), click: $parent.buildLink('Impairments', 'NoLocNoImpairments', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR IMPAIRMENTS -->

                <div style="clear: both; height: 8px;">&nbsp;</div>

                <!-- HEADING JURISDICTIONAL -->
                <div class="tableDiv programstat_HeadingShort programstat_HeaderBackground programstat_TypeStyle" style="line-height: normal; display: none">
                    <div class="" style="line-height: normal;">
                        <span class="programstat_CellLabelLeftCenter">
                            <label class="programstat_HeadingLabelLeft" data-bind="text: $parent.objLanguageLabels().lblJurisdictional">Jurisdictional</label></span>
                        <span class="programstat_CellX13 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderLeft" style="">&nbsp;</span>
                    </div>
                </div>
                <!-- DETAILS JURISDICTIONAL -->
                <div class="programstat_ContentArea programstat_NoTopBorder" style="display: none">
                    <div class="tableDiv programstat_BottomCorrection programstat_DataTypeStyle">
                        <div class="programstat_ContentRow">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfOpenViolations">No. of Open Recommendations</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><a id="ViolationOpenJuris" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Juris', 'NoOpenViolations', '', null), click: $parent.buildLink('Juris', 'NoOpenViolations', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX9 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 338px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfCertificateBlockingViolations">No. of Certificate Blocking Recommendations</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder"><a id="ViolationCertJuris" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Juris', 'NoCertBlockViolations', '', null), click: $parent.buildLink('Juris', 'NoCertBlockViolations', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                        <div class="programstat_ContentRow" id="divJurisObjectsOverdue" runat="server">
                            <span class="programstat_CellLabelLeft programstat_LabelTypeStyle">
                                <label data-bind="text: $parent.objLanguageLabels().lblNoOfObjectsOverdue">No. of Objects Overdue</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><a id="ObjectsOverdueJuris" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Juris', 'NoObjOverdue', '', null), click: $parent.buildLink('Juris', 'NoObjOverdue', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 72px;">
                                <label data-bind="html: $parent.objLanguageLabels().lbl30To59Days">30-59 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><a id="ObjectsOverdue30To59Juris" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Juris', '3059Days', '', null), click: $parent.buildLink('Juris', '3059Days', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 72px;">
                                <label data-bind="html: $parent.objLanguageLabels().lbl60To89Days">60-89 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><a id="ObjectsOverdue60To89Juris" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Juris', '6089Days', '', null), click: $parent.buildLink('Juris', '6089Days', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX3 programstat_LabelRight programstat_LabelTypeStyle programstat_ContentBorder programstat_NoBottomBorder" style="padding-right: 6px; width: 106px;">
                                <label data-bind="html: $parent.objLanguageLabels().lblGreaterThan90Days">&gt; 90 Days</label>:</span>
                            <span class="programstat_CellX1 programstat_ContentBorder programstat_NoBottomBorder programstat_BorderTop"><a id="ObjectsOverdueOver90Juris" class="winde100 programstat_Link" href="#" data-bind="text: $parent.buildData($element.id, 'data', 'Juris', 'GT90Days', '', null), click: $parent.buildLink('Juris', 'GT90Days', '', null)">&nbsp;</a></span>
                            <span class="programstat_CellX2 programstat_ContentBorder programstat_BorderLeft programstat_NoBottomBorder">&nbsp;</span>
                        </div>
                    </div>
                </div>
                <!-- END DETAILS FOR IMPAIRMENTS -->
                <!-- END TABLES FOR PROGRAM STATUS INFORMATION -->
            </div>
        </div>
    </div>
    <%--<script src="../../Lib_{{VER}}/pages/programStatus.js"></script>--%>
    <script type="text/javascript">
        $(document).ready(function () {
            // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
            kendo.ui.progress($("#divContainerLoading"), false);

            // GLOBAL DATA PLACEHOLDERS
            dsProgramStatus = null;
            dsFireRatings = [];
            dsBMRatings = [];

            // LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                // PAGE TITLE AREA
                lblFiltered: "Filtered",
                lblCurrency: "Currency",
                lblCustomAccess: "<%= lblCustomAccess %>",
            lblDivision: "Division",
            // HEADINGS
            lblFire: "Fire",
            lblBM: "B&amp;M",
            lblInfrared: "Infrared",
            lblSeismic: "Seismic",
            lblFlood: "Flood",
            lblWind: "Wind",
            lblNatHaz: "NatHaz",
            lblDivSrvs: "DivSrvs",
            lblArcFlash: "ArcFlash",
            lblProcSafe: "ProcSafe",
            lblTotals: "Totals",
            lblInspectionReportSummary: "Inspection/Report Summary",
            lblCurrentInspectionProgram: "(Current Inspection Program)",
            lblRegInsp: "Reg.<br />Insp.",
            lblSpecInsp: "Spec.<br />Insp.",
            lblOpen: "Open",
            lblClosed: "Closed",
            lblNatHazSurvey: "Nat/Haz<br />Survey",
            lblNaturalHazardExposures: "Natural Hazard Exposures",
            lblActiveRecommendationSummary: "Active Recommendation Summary",
            lblProjectManagementSummary: "Project Management Summary",
            lblNoOfProjects: "No. of Projects",
            lblTop10HighestMFL: "Top 10 Highest MFL",
            lblFacilityRatingSummary: "Facility Rating Summary",
            lblLatestRecordForAllActiveLocations: "(Latest Record for all Active Locations)",
            lblImpairments: "Impairments",
            lblJurisdictional: "Jurisdictional",
            // LEFT COLUMN LABELS
            // Inspection/Report Summary
            lblNoOfInspectionDue: "No. of Inspection Due (original count)",
            lblNoOfInspectionCompleted: "No. of Inspection Completed",
            lblNoOfInspectionPending: "No. of Inspection Pending",
            lblNoOfInspectionCancelled: "No. of Inspection Cancelled",
            lblInspectionsCompletedAndReportsDelivered: "No. of Inspection Reports Delivered",
            lblInspectionsScheduled: "No. of Inspections Scheduled",
            lblInspectionsNotYetScheduled: "No. of Inspections Not Yet Scheduled",
            lblTotalInspectionsCompletedScheduled: "% of Total Inspections Completed and/or Scheduled",
            lblTotalInspectionsCompleted: "% of Total Inspections Completed",
            // Natural Hazard Exposures
            lblNoOfLocsWithSevereExposure: "No. of Locs. with a Severe Exposure",
            lblNoOfLocsWithModerateExposure: "No. of Locs. with a Moderate Exposure",
            lblNoOfLocsWithLightExposure: "No. of Locs. with a Light Exposure",
            // Active Recommendation Summary
            lblNoRecsWithLE1bil: "<%= RecLE1BilLabel %>",
            lblNoRecsWithLE500mil1bil: "<%= RecLE500milLabel %>",
            lblNoRecsWithLE250mil500mil: "<%= RecLE250milLabel %>",
            lblNoRecsWithLE100mil250mil: "<%= RecLE100milLabel %>",
            lblNoRecsWithLE50mil100mil: "<%= RecLE50milLabel %>",
            lblNoRecsWithLE25mil50mil: "<%= RecLE25milLabel %>",
            lblNoRecsWithLE10mil25mil: "<%= RecLE10milLabel %>",
            lblNoActiveRecsWithLowImpact: "No. of Active Recs with Low Impact",
            lblNoActiveRecsWithModerateImpact: "No. of Active Recs with Moderate Impact",
            lblNoActiveRecsWithHighImpact: "No. of Active Recs with High Impact",
            lblNoActiveHumanElementRecs: "No. of Active Human Element Recs.",
            // Top 10 Highest MFL
            lblNoOfLocationsWithTop10HighestMFL: "No. of Locations with Top 10 Highest MFL",
            // Facility Rating Summary
            lblAverageGRCFacilityScore: "Average GRC Facility Score",
            lblAverageClientFacilityScore: "Average Client Facility Score",
            lblAverageIndustryGroupUtilitiesFacilityScore: "Average Industry Group (Utilities) Facility Score",
            lblAverageIndustryGroup: "Average Industry Group",
            lblFacilityScore: "Facility Score",
            lblNoOfLocationsWithTop5HighestRatings: "No. of Locations With Top 5 Highest Ratings",
            lblNoOfLocationsWithBottom5LowestRatings: "No. of Locations With Bottom 5 Lowest Ratings",
            lblNoOfLocationsRatedBetterRisk: "No. of Locations Rated Better Risk",
            lblNoOfLocationsRatedTypicalRisk: "No. of Locations Rated Typical Risk",
            lblNoOfLocationsRatedPoorerRisk: "No. of Locations Rated Poorer Risk",
            lblFacilityRatingsLevel1: "<%= lblFacilityRatingsLevel1 %>",
            lblFacilityRatingsLevel2: "<%= lblFacilityRatingsLevel2 %>",
            lblFacilityRatingsLevel3: "<%= lblFacilityRatingsLevel3 %>",
            lblFacilityRatingsLevel4: "<%= lblFacilityRatingsLevel4 %>",
            lblFacilityRatingsLevel5: "<%= lblFacilityRatingsLevel5 %>",
            FacilityRatingsColor1: "<%= FacilityRatingsColor1 %>",
            FacilityRatingsColor2: "<%= FacilityRatingsColor2 %>",
            FacilityRatingsColor3: "<%= FacilityRatingsColor3 %>",
            FacilityRatingsColor4: "<%= FacilityRatingsColor4 %>",
            FacilityRatingsColor5: "<%= FacilityRatingsColor5 %>",
            // Impairments
            lblNoPending: "No. Pending",
            lblNoAdvisory: "No. Advisory",
            lblNoRestored: "No. Restored",
            lblNoOverdue: "No. Overdue",
            lblNoLocationsUsingImpairmentsSystem: "No. of Locations With Reported Impairments",
            lblNoLocationsNotUsingImpairmentsSystem: "No. of Locations With No Reported Impairments",
            // Jurisdictional
            lblNoOfOpenViolations: "No. of Open Recommendations",
            lblNoOfObjectsOverdue: "No. of Objects Overdue",
            lblNoOfCertificateBlockingViolations: "No. of Certificate Blocking Recommendations",
            lbl30To59Days: "30-59 Days",
            lbl60To89Days: "60-89 Days",
            lblGreaterThan90Days: "&gt; 90 Days",
            // INFRARED
            lblInfraredRecSeverityCounts: "Infrared Recommendation Severity Counts",
            lblInfraredRecLengthBusInt: "Infrared Recommendation Length of Business Interruption Counts",
            lblNoOfFourStars: "No. of ****",
            lblNoOfThreeStars: "No. of ***",
            lblNoOfTwoStars: "No. of **",
            lblNoOfOneStars: "No. of *",
            lblNoOfFYI: "No. of FYI",
            lblOneDay: "1 Day",
            lblTwoDay: "2 Days",
            lblThreeDay: "3 Days",
            lblFourDay: "4 Days",
            lblFiveDay: "5 Days",
            lblSixDay: "6 Days",
            lblOneWeek: "1 Week",
            lblTwoWeek: "2 Weeks",
            lblThreeWeek: "3 Weeks",
            lblOneMonth: "1 Month",
            lblGreaterOneMonth: "> 1 Month",

            // MISC
            lblNA: "N/A",
            lbl: "",
            lblLastItem: ""
        };


        // VIEWMODELS
        var viewFindCriteria = {
            findCriteria: ko.observable()
        };
        var view = {
            // DECLARATIONS
            index: 0,
            enableButtons: ko.observable(true),
            messageError: ko.observable(),
            messageWarning: ko.observable(),
            messageNotice: ko.observable(),
            stateLoadError: false,
            pageRequestedFrom: getQueryVariable("req"),
            reportFileName: "<%= ReportFileName %>",
            isDataLoaded: false,
            isCancelled: false,

            // COLLECTIONS / OBJECTS
            // CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
            gSafeGuid: getGSafeGUID(),
            clientFeatures: ko.observable(),
            //collProgramStatus: new es.objects.ViewCCLocationListingFireCollection(),
            objProgramStatus: ko.observable(),
            objFind: ko.observable(),
            objLanguageLabels: ko.observable(dsLanguageLabels),
            lblRatingIndustryGroup: ko.observable("Utilities"),
            lblCustomAccessLabel: ko.observable(""),
            lblCustomAccessSetting: ko.observable(""),
            lblDivisionSetting: ko.observable(""),
            visibleCustomAccess: ko.observable(false),
            visibleDivision: ko.observable(false),
            chartFireRatings: null,
            chartBMRatings: null,

            // MISC
            loading: ko.observable(false),
            //windowPleaseWait: null,


            init: function () {
                view.countLoading = 5;
                //view.setupKendoWindow();
                view.setupEvents();
                setTimeout(function () {
                    view.loadDictionary();
                    view.loadData();
                }, 1000);
            },


            loadData: function () {
                view.loadProgramStatusData();
            },


            loadDictionary: function () {
                //view.objLanguageLabels(dsLanguageLabels);
                view.processLoading();
            },


            // LOADING DATA
            loadProgramStatusData: function () {
                try {
                    view.messageError("Loading...");
                    global.messageShow("messageError", "messageNotice");
                    var zServiceName = "GetProgramStatusData";          //mrxxxxxxxxxxxxxxxxxxxxxxxxxx
                    var zParms = ko.toJSON({
                        "gSafeGuid": view.gSafeGuid
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadProgramStatusDataSuccess, view.loadProgramStatusDataError, null);
                } catch (pException) {
                    view.messageError("An error occurred while starting the program status data load call: " + pException.message);
                    global.messageShow("messageError", "messageError");
                }
            },
            loadProgramStatusDataSuccess: function (pResults, pParms) {
                if (view.isCancelled) {
                    view.onClickExit();
                } else {
                    try {
                        view.messageError("");
                        if (pResults.isSuccess) {
                            // STORE THE PROGRAM STATUS DATA
                            view.isDataLoaded = true;
                            view.objProgramStatus(pResults.data);
                            if (pResults.settings.CustomAccess !== undefined && pResults.settings.CustomAccess !== null && pResults.settings.CustomAccess !== "%" && pResults.settings.CustomAccess.length > 1) {
                                view.lblCustomAccessLabel(pResults.settings.CustomAccessLabel);
                                view.lblCustomAccessSetting(pResults.settings.CustomAccess);
                                view.visibleCustomAccess(true)
                            } else {
                                view.visibleCustomAccess(false)
                            }
                            if (pResults.settings.Division !== undefined && pResults.settings.Division !== null && pResults.settings.Division !== "%" && pResults.settings.Division.length > 1) {
                                view.lblDivisionSetting(pResults.settings.Division);
                                view.visibleDivision(true)
                            } else {
                                view.visibleDivision(false)
                            }
                            var zRatingGroup = "utilities";
                            for (var x = 0; x < view.objProgramStatus().length; x++) {
                                if (view.objProgramStatus()[x].SectionName == "FacilityRatingSum") {
                                    if (view.objProgramStatus()[x].MetricName == "AveIndustryScore") {
                                        if (view.objProgramStatus()[x].TopName == "Fire") {
                                            zRatingGroup = view.objProgramStatus()[x].SubMetricName;
                                            break;
                                        }
                                    }
                                }
                            }
                            view.lblRatingIndustryGroup(zRatingGroup);
                            // BUILD RATINGS CHARTS
                            for (var x = 0; x < view.objProgramStatus().length; x++) {
                                if (view.objProgramStatus()[x].MetricName == "Chart") {
                                    if (view.objProgramStatus()[x].TopName == "Fire") {
                                        dsFireRatings.push({
                                            category: view.objProgramStatus()[x].MetricLabel,
                                            value: view.objProgramStatus()[x].MetricValue,
                                            color: view.objProgramStatus()[x].MetricColor,
                                            Id: view.objProgramStatus()[x].Id,
                                            SectionName: view.objProgramStatus()[x].SectionName,
                                            TopName: view.objProgramStatus()[x].TopName,
                                            MetricName: view.objProgramStatus()[x].MetricName,
                                            SubMetricName: view.objProgramStatus()[x].SubMetricName,
                                            MetricValue: view.objProgramStatus()[x].MetricValue,
                                            MetricLabel: view.objProgramStatus()[x].MetricLabel,
                                            MetricVisible: view.objProgramStatus()[x].MetricVisible,
                                            MetricColor: view.objProgramStatus()[x].MetricColor,
                                            DirectId: view.objProgramStatus()[x].DirectId
                                        });
                                    } else if (view.objProgramStatus()[x].TopName == "Boiler") {
                                        dsBMRatings.push({
                                            category: view.objProgramStatus()[x].MetricLabel,
                                            value: view.objProgramStatus()[x].MetricValue,
                                            color: view.objProgramStatus()[x].MetricColor,
                                            Id: view.objProgramStatus()[x].Id,
                                            SectionName: view.objProgramStatus()[x].SectionName,
                                            TopName: view.objProgramStatus()[x].TopName,
                                            MetricName: view.objProgramStatus()[x].MetricName,
                                            SubMetricName: view.objProgramStatus()[x].SubMetricName,
                                            MetricValue: view.objProgramStatus()[x].MetricValue,
                                            MetricLabel: view.objProgramStatus()[x].MetricLabel,
                                            MetricVisible: view.objProgramStatus()[x].MetricVisible,
                                            MetricColor: view.objProgramStatus()[x].MetricColor,
                                            DirectId: view.objProgramStatus()[x].DirectId
                                        });
                                    }
                                }
                            }
                        } else {
                            view.messageError("An error occurred while loading program status data: " + pResults.message);
                            global.messageShow("messageError", "messageError");
                        }
                    } catch (pException) {
                        view.messageError("An error occurred while loading program status data: " + pException.message);
                        global.messageShow("messageError", "messageError");
                    }
                    //                    view.windowPleaseWait.close();
                }
                //view.setupKendoChart();
                view.processLoading();
            },
            loadProgramStatusDataError: function (pResults, pMessage, pErrorDetail, pParms) {
                view.messageError("Error while loading program status data. " + pMessage);
                global.messageShow("messageError", "messageError");
                view.processLoading();
            },


            onClickPrint: function () {
                var zHTML = "";
                var zCSS = "";

                // GET ALL THE CSS FILES
                $.get("../../css/Kendo.v2014.1.318/kendo.common.min.css", function (pResults) {
                    zCSS = zCSS + pResults;
                    $.get("../../css/kendo-lightblue-noedit.css", function (pResults) {
                        zCSS = zCSS + pResults;
                        $.get("../../css/pages/global.css", function (pResults) {
                            zCSS = zCSS + pResults;
                            $.get("../../css/pages/topbanner.css", function (pResults) {
                                zCSS = zCSS + pResults;
                                //$.get("../../css/pages/nav.css", function (pResults) {
                                //    zCSS = zCSS + pResults;
                                    $.get("../../css/pages/windows.css", function (pResults) {
                                        zCSS = zCSS + pResults;
                                        $.get("../../css/pages/programstatus.css", function (pResults) {
                                            zCSS = zCSS + pResults;
                                            $.get("../../css/pages/print.css", function (pResults) {
                                                if (view.printHTML == null) {
                                                    // REMOVE ANY NO PRINT DOMS
                                                    var zDocument = $("html").clone();
                                                    zDocument.find(".printNone").each(function () {
                                                        $(this).remove();
                                                    });
                                                    zHTML = $(zDocument).html();
                                                } else {
                                                    zHTML = view.printHTML;
                                                }

                                                zHTML = zHTML.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
                                                zHTML = zHTML.replace(/(\r\t|\t|\r)/gm, " "); // REMOVE ALL TABS
                                                zHTML = zHTML.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
                                                zHTML = zHTML.replace(/(<)/gm, "||OPEN||"); // REPLACE ALL OPEN BRACKETS
                                                zHTML = zHTML.replace(/(>)/gm, "||CLOSE||"); // REPLACE ALL CLOSING BRACKETS
                                                zCSS = zCSS + pResults;
                                                zCSS = zCSS.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
                                                zCSS = zCSS.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
                                                //zCSS = zCSS.replace(/1px/gm, "2px"); // REPLACE ALL 1PX LINES TO THICKER

                                                // CALL HANDLER PAGE BY CREATING A FORM
                                                // CREATE A FORM DOM ELEMENT
                                                var zForm = document.createElement("form");
                                                zForm.setAttribute("id", "frmPDF");
                                                zForm.setAttribute("method", "post");
                                                //zForm.setAttribute("target", "_blank");
                                                zForm.setAttribute("action", "../FD/ServeHTMLToPDF.ashx?sid=" + getGSafeGUID() + "&reportId=" + getQueryVariable("reportId"));
                                                document.body.appendChild(zForm);

                                                // CREATE HIDDEN INPUT DOM ELEMENTS
                                                var zField1 = document.createElement("input");
                                                zField1.setAttribute("type", "hidden");
                                                zField1.setAttribute("id", "pHTML");
                                                zField1.setAttribute("name", "pHTML");
                                                zField1.setAttribute("value", zHTML);
                                                zForm.appendChild(zField1);
                                                var zField2 = document.createElement("input");
                                                zField2.setAttribute("type", "hidden");
                                                zField2.setAttribute("id", "pCSS");
                                                zField2.setAttribute("name", "pCSS");
                                                zField2.setAttribute("value", zCSS);
                                                zForm.appendChild(zField2);
                                                var zZoomFactor = "1.35";
                                                var zField3 = document.createElement("input");
                                                zField3.setAttribute("type", "hidden");
                                                zField3.setAttribute("id", "pZoomFactor");
                                                zField3.setAttribute("name", "pZoomFactor");
                                                zField3.setAttribute("value", zZoomFactor);
                                                zForm.appendChild(zField3);
                                                var zField4 = document.createElement("input");
                                                zField4.setAttribute("type", "hidden");
                                                zField4.setAttribute("id", "pOrientation");
                                                zField4.setAttribute("name", "pOrientation");
                                                zField4.setAttribute("value", "Portrait");
                                                zForm.appendChild(zField4);

                                                // SUBMIT THE FORM AND DELETE IT SO IT CAN BE RUN AGAIN
                                                zForm.submit();
                                                zForm.removeChild(zField1);
                                                zForm.removeChild(zField2);
                                                zForm.removeChild(zField3);
                                                zForm.removeChild(zField4);
                                                document.body.removeChild(zForm);
                                            });
                                        });
                                    });
                                //});
                            });
                        });
                    });
                });
            },


            buildData: function (pElement, pType, pSectionName, pMetricName, pTopName, pSubMetricName, pDefault) {
                // STORE FOR USE INSIDE COMPUTED FUNCTION
                return ko.computed(function () {
                    var zReturn = "0";
                    var zDefault = "0";
                    var zErrorValue = "Err";
                    var zObjectName = "MetricValue"
                    var zFound = false;

                    // TEST
                    //if (pDefault == "No. of Recs. with LE`s > 1bil") { debugger; }

                    try {
                        // BUILD DEFAULTS //data, dataperc, url, color, label, visible
                        switch (pType.toLowerCase()) {
                            case "data":
                            case "dataperc":
                                zDefault = "0";
                                zReturn = "0";
                                zErrorValue = "Err";
                                zObjectName = "MetricValue";
                                break;
                            case "url":
                                zDefault = "#";
                                zReturn = "#";
                                zErrorValue = "#";
                                zObjectName = "MetricLink";
                                break;
                            case "color":
                                zDefault = "#FFFFFF";
                                zReturn = "#FFFFFF";
                                zErrorValue = "#000000";
                                zObjectName = "MetricColor";
                                break;
                            case "label":
                                zDefault = "";
                                zReturn = "";
                                zErrorValue = "Error";
                                zObjectName = "MetricLabel";
                                break;
                            case "visible":
                                zDefault = false;
                                zReturn = false;
                                zErrorValue = false;
                                zObjectName = "MetricVisible";
                                break;
                        }
                        if (pDefault !== undefined && pDefault !== null) {
                            zReturn = pDefault;
                            zDefault = pDefault;
                        }
                        //if (pMetricName == 'ActRecSumKey9') { debugger;}
                        // LOOP THROUGH DATA TO GET THE VALUE
                        if (view.objProgramStatus()) {
                            for (var x = 0; x < view.objProgramStatus().length; x++) {
                                if (view.objProgramStatus()[x].SectionName == pSectionName) {
                                    if (view.objProgramStatus()[x].MetricName == pMetricName) {
                                        if (view.objProgramStatus()[x].TopName == pTopName) {
                                            if (pSubMetricName) {
                                                if (view.objProgramStatus()[x].SubMetricName == pSubMetricName) {
                                                    zReturn = view.objProgramStatus()[x][zObjectName];
                                                    zFound = true;
                                                    break;
                                                }
                                            } else {
                                                zReturn = view.objProgramStatus()[x][zObjectName];
                                                zFound = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        // REVERT TO DEFAULT IF NULL
                        if ((zReturn === undefined || zReturn === null || zReturn == "") &&
                            (zDefault !== undefined && zDefault !== null)) {
                            zReturn = zDefault;
                        }

                        // IF ZERO COUNT VALUE THEN REMOVE UNDERLINE
                        if (pElement) {
                            if (!$("#" + pElement).hasClass("programstat_NoLink")) {
                                if (zReturn == zDefault) {
                                    $("#" + pElement).removeClass("programstat_Link");
                                    $("#" + pElement).addClass("programstat_NoUnderline");
                                } else {
                                    $("#" + pElement).removeClass("programstat_NoUnderline");
                                    $("#" + pElement).addClass("programstat_Link");
                                }
                            }
                        }

                        // ADD EXTRA INFO WHERE NEEDED BY TYPE
                        switch (pType.toLowerCase()) {
                            case "dataperc":
                                zReturn = zReturn + "%";
                                break;
                            case "data":
                            case "url":
                            case "color":
                            case "label":
                            case "visible":
                                break;
                        }
                    } catch (pException) {
                        view.messageError("An error occurred while building " + pType + " data: " + pException.message);
                        global.messageShow("messageError", "messageError");
                        zReturn = zErrorValue;
                    }
                    return zReturn;
                }, view);
            },


            buildDataLocal: function (pElement, pType, pSectionName, pMetricName, pTopName, pSubMetricName, pDefault) {
                // TYPES
                var zReturn = "0";
                var zDefault = "0";
                var zErrorValue = "Err";
                var zObjectName = "MetricValue"
                var zFound = false;

                try {
                    // BUILD DEFAULTS //data, dataperc, url, color, label, visible
                    switch (pType.toLowerCase()) {
                        case "data":
                        case "dataperc":
                            zDefault = "0";
                            zReturn = "0";
                            zErrorValue = "Err";
                            zObjectName = "MetricValue";
                            break;
                        case "url":
                            zDefault = "#";
                            zReturn = "#";
                            zErrorValue = "#";
                            zObjectName = "MetricLink";
                            break;
                        case "color":
                            zDefault = "#FFFFFF";
                            zReturn = "#FFFFFF";
                            zErrorValue = "#000000";
                            zObjectName = "MetricColor";
                            break;
                        case "label":
                            zDefault = "";
                            zReturn = "";
                            zErrorValue = "Error";
                            zObjectName = "MetricLabel";
                            break;
                        case "visible":
                            zDefault = false;
                            zReturn = false;
                            zErrorValue = false;
                            zObjectName = "MetricVisible";
                            break;
                    }
                    if (pDefault !== undefined && pDefault !== null) {
                        zReturn = pDefault;
                        zDefault = pDefault;
                    }

                    // LOOP THROUGH DATA TO GET THE VALUE
                    if (view.objProgramStatus()) {
                        for (var x = 0; x < view.objProgramStatus().length; x++) {
                            if (view.objProgramStatus()[x].SectionName == pSectionName) {
                                if (view.objProgramStatus()[x].MetricName == pMetricName) {
                                    if (view.objProgramStatus()[x].TopName == pTopName) {
                                        if (pSubMetricName) {
                                            if (view.objProgramStatus()[x].SubMetricName == pSubMetricName) {
                                                zReturn = view.objProgramStatus()[x][zObjectName];
                                                zFound = true;
                                                break;
                                            }
                                        } else {
                                            zReturn = view.objProgramStatus()[x][zObjectName];
                                            zFound = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // REVERT TO DEFAULT IF NULL
                    if ((zReturn === undefined || zReturn === null || zReturn == "") &&
                        (zDefault !== undefined && zDefault !== null)) {
                        zReturn = zDefault;
                    }

                    // IF ZERO COUNT VALUE THEN REMOVE UNDERLINE
                    if (pElement) {
                        if (!$("#" + pElement).hasClass("programstat_NoLink")) {
                            if (zReturn == zDefault) {
                                $("#" + pElement).removeClass("programstat_Link");
                                $("#" + pElement).addClass("programstat_NoUnderline");
                            } else {
                                $("#" + pElement).removeClass("programstat_NoUnderline");
                                $("#" + pElement).addClass("programstat_Link");
                            }
                        }
                    }

                    // ADD EXTRA INFO WHERE NEEDED BY TYPE
                    switch (pType.toLowerCase()) {
                        case "dataperc":
                            zReturn = zReturn + "%";
                            break;
                        case "data":
                        case "url":
                        case "color":
                        case "label":
                        case "visible":
                            break;
                    }
                } catch (pException) {
                    view.messageError("An error occurred while building " + pType + " data: " + pException.message);
                    global.messageShow("messageError", "messageError");
                    zReturn = zErrorValue;
                }
                return zReturn;
            },


            buildLink: function (pSectionName, pMetricName, pTopName, pSubMetricName) {
                var zDirectId = "0";
                var zValue = 0;
                var zObjectName = "DirectId"
                var zURL = "";
                var zFound = false;
                try {
                    // LOOP THROUGH DATA TO GET THE VALUE
                    if (view.objProgramStatus()) {
                        for (var x = 0; x < view.objProgramStatus().length; x++) {
                            if (view.objProgramStatus()[x].SectionName == pSectionName) {
                                if (view.objProgramStatus()[x].MetricName == pMetricName) {
                                    if (view.objProgramStatus()[x].TopName == pTopName) {
                                        if (pSubMetricName) {
                                            if (view.objProgramStatus()[x].SubMetricName == pSubMetricName) {
                                                zDirectId = view.objProgramStatus()[x][zObjectName];
                                                if (view.objProgramStatus()[x].MetricValue) {
                                                    zValue = view.objProgramStatus()[x].MetricValue;
                                                }
                                                zFound = true;
                                                break;
                                            }
                                        } else {
                                            zDirectId = view.objProgramStatus()[x][zObjectName];
                                            if (view.objProgramStatus()[x].MetricValue) {
                                                zValue = view.objProgramStatus()[x].MetricValue;
                                            }
                                            zFound = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    // NAVIGATE TO THE DIRECT PAGE
                    if (zFound && zValue > 0) {
                        view.messageError("");
                        zURL = "PSDirect.ashx?sid=" + view.gSafeGuid + "&directId=" + zDirectId;
                        openRequestedSinglePopup(zURL);
                    } else {
                        view.messageError("Loading....");                   //("No data for this criteria.");
                        global.messageShow("messageError", "messageError");
                    }
                } catch (pException) {
                    view.messageError("An error occurred while navigating to grid/report: " + pException.message);
                    global.messageShow("messageError", "messageError");
                }
            },


            onSeriesClick: function (pEvent) {
                try {
                    var zDirectId = pEvent.dataItem.DirectId;
                    zURL = "PSDirect.ashx?sid=" + view.gSafeGuid + "&directId=" + zDirectId;
                    openRequestedSinglePopup(zURL);
                } catch (pException) {
                    view.messageError("An error occurred while navigating to grid/report: " + pException.message);
                    global.messageShow("messageError", "messageError");
                }
            },


            // SETUP EVENTS AND WIDGETS
            setupKendo: function () {

            },


            setupKendoChart: function () {
                try {
                    if (view.chartFireRatings == null) {
                        $("#chartFireRatings").kendoChart({
                            transitions: false,
                            renderAs: "svg",
                            chartArea: {
                                height: 170,
                                width: 170
                            },
                            legend: {
                                visible: false
                            },
                            seriesDefaults: {
                                labels: {
                                    visible: true,
                                    background: "transparent",
                                    border: {
                                        width: 0,
                                        color: "transparent"
                                    },
                                    template: "#= value#%",
                                    align: "circle",
                                    position: function (e) {
                                        if (e.percentage < 0.15) {
                                            return "center"; //insideEnd, outsideEnd, center
                                        } else {
                                            return "center";
                                        }
                                    },
                                    margin: function (e) {
                                        if (e.percentage < 0.15) {
                                            return 0; //-10
                                        } else {
                                            return 0;
                                        }
                                    }
                                },
                                overlay: {
                                    gradient: "roundedBevel"
                                },
                                border: {
                                    width: 1,
                                    color: "#6C6C6C"
                                }
                            },
                            series: [{
                                type: "pie",
                                startAngle: 150,
                                data: dsFireRatings
                            }],
                            tooltip: {
                                visible: true,
                                template: "#= category# \n#= value#%"
                            },
                            seriesClick: view.onSeriesClick
                        });
                        view.chartFireRatings = $("#chartFireRatings").data("kendoChart");
                    }
                    if (view.chartBMRatings == null) {
                        $("#chartBMRatings").kendoChart({
                            transitions: false,
                            renderAs: "svg",
                            chartArea: {
                                height: 170,
                                width: 170
                            },
                            legend: {
                                visible: false
                            },
                            seriesDefaults: {
                                labels: {
                                    visible: true,
                                    background: "transparent",
                                    border: {
                                        width: 0,
                                        color: "transparent"
                                    },
                                    template: "#= value#%",
                                    align: "circle",
                                    position: function (e) {
                                        if (e.percentage < 0.15) {
                                            return "center"; //insideEnd, outsideEnd, center
                                        } else {
                                            return "center";
                                        }
                                    },
                                    margin: function (e) {
                                        if (e.percentage < 0.15) {
                                            return 0; //-10
                                        } else {
                                            return 0;
                                        }
                                    }
                                },
                                overlay: {
                                    gradient: "roundedBevel"
                                },
                                border: {
                                    width: 1,
                                    color: "#6C6C6C"
                                }
                            },
                            series: [{
                                type: "pie",
                                startAngle: 150,
                                data: dsBMRatings
                            }],
                            tooltip: {
                                visible: true,
                                template: "#= category# \n#= value#%"
                            },
                            seriesClick: view.onSeriesClick
                        });
                        view.chartBMRatings = $("#chartBMRatings").data("kendoChart");
                    }
                } catch (pException) {
                    view.messageError("Error while building charts. " + pException.message);
                    global.messageShow("messageError", "messageError");
                }
                view.processLoading();
            },


            setupEvents: function () {
                view.processLoading();
            },


            // RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
            },


            clearAddressFields: function () {
            },


            // CLEAR ALL FIELDS IF NO RECORDS ARE FOUND
            clearPickers: function () {
            },


            bindForm: function () {
                ko.applyBindings(view, $("#view")[0]);
            },


            showLoading: function () {
                $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
            },


            hideLoading: function () {
                $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
            },


            processLoading: function () {
                view.countLoading--;
                if (view.countLoading < 1) {
                    view.hideLoading();
                } else {
                }
            }

        };


        // SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        //view.loadDetails();

        // ACTIVATE BINDINGS LAST
        // WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
        view.bindForm();
        view.init();
        view.resetPickers();
    });


    function onBuildPopupLink(pURL) {
        if (pURL.length > 0) {
            openRequestedSinglePopup(pURL);
        }
        return false;
    }


    </script>

</asp:Content>
