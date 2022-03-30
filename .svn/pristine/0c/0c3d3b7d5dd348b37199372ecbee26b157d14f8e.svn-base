<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/Charts/BubbleChartMaster.master" CodeBehind="BubbleChart.aspx.vb" Inherits="GRC.Connect.Web.BubbleChart" %>

<asp:Content ID="BubbleChartHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="BubbleChartContent" runat="server" ContentPlaceHolderID="BubbleChartContent">
    <!-- ERROR MESSAGE -->
    <div id="txtMapMessageContainer" style="background-color: #eee; color: red; padding: 6px; padding-top: 12px; padding-bottom: 0px; width: 100%; min-height: 20px; display: none;"><span id="txtMapMessage"></span></div>

    <div id="viewBubbleChart" class="bubbleChartPageBody">
        <!-- MAIN BODY CONTENT -->
        <div class="labelDDHldr">
            <label style="display: block; margin-bottom: 5px;">Bubble Label:</label>
            <input id="labelDD" />
        </div>
        <div id="htmlCanvasHldr" class="chartHldr">
            <div id="bubbleChart"></div>
            <div id="chartTooltip"></div>
        </div>
        <div class="imgMakerHldr">
            <label style="display: block; margin-bottom: 5px;">Chart To Image:</label>
            <button id="makeChartImgBtn" class="grcBlueBtn" data-bind="click: viewBubbleChart.makeChartImage">Make Image</button>
            <br />
            <br />
            <label style="display: block; margin-bottom: 5px;">Chart To PDF:</label>
            <button id="makeChartPDFBtn" class="export-pdf grcBlueBtn" data-bind="click: viewBubbleChart.makeChartPDF">Make PDF</button>
        </div>
        <div id="preview"></div>
    </div>
</asp:Content>
