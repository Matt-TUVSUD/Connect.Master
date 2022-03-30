<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultGauge" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/Home/homePage.css" rel="stylesheet" />
    <script src="../../Lib_{{VER}}/Home/homePage.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Data/cookies.js" type="text/javascript"></script>
    <script>if (Function('/*@cc_on return document.documentMode===10@*/')()) { document.documentElement.className += ' ie10'; }</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- SERVICES TILE PAGE BODY CONTENT -->

    <div id="viewHome" class="pgBodyContent">
        <div id="msgCenter">
            <span data-bind="text: viewHome.txtMessage"></span>
        </div>
        <grcRSC:Loader runat="server" id="loader" />
        <!-- CREATE MARKUP STRUCTURE FOR SERVICE TILES -->
        <div class="tileHldr">
            <div id="blueRow" class="activeServiceRow" data-bind="foreach: activeServices">
                <div class="tileBody">
                    <div class="activeTileHeader">
                        <h2 class="serviceIcon" data-bind="html: $data.colFldImageHtml"></h2>
                        <span class="serviceName" data-bind="text: $data.colFldReportDisplayTitle"></span>
                    </div>
                    <span class="divider">&nbsp;</span>
                    <div class="tileBodyContent">
                        <label class="tileLbl">
                            <a href="#" data-bind="attr: { href: '../Reports/default.aspx?sid=' + gSafeGuid + '&pId=' + $data.colFldPracticeGroupCode }" >Reports</a>
                            |
                            <a href="#" data-bind="attr: { href: '../Grids/LibrariesDocumentLibrary/?sid=' + gSafeGuid + '&navLinkId=964&gridId=60' }">Document Library</a>
                        </label>
                        <a class="activeTileLocationBtn" href="#" data-bind="attr: { href: $data.colFldLocationListingUrl }">
                            Location Listing
                        </a>
                    </div>
                </div>
            </div>
            <div id="greyRow" class="inActiveServiceRow" data-bind="foreach: inActiveServices">
                <div class="tileBody">
                    <div class="inActiveTileHeader">
                        <h2 class="serviceIcon inactiveOverlay" data-bind="html: $data.colFldImageHtml"></h2>
                        <span class="serviceName inactiveServiceName" data-bind="text: $data.colFldReportDisplayTitle"></span>
                    </div>
                    <span class="divider">&nbsp;</span>
                    <div class="tileBodyContent">
                        <label class="tileLbl">
                            <a href="#" target="_blank" style="width:100%;" data-bind="attr: { href: $data.colFldLearnMoreUrl }">Learn More...</a>
                        </label>
                    </div>
                </div>
            </div>
        </div>
        <div id="tileSwitchHldr">
            <label class="switchLbl">Display Inactive Services?</label>
            <input id="tileDisplay" type="checkbox" checked="checked" />
        </div>
    </div>

</asp:Content>
