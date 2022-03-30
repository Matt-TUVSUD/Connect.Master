<%@ Page Language="vb" AutoEventWireup="false"  MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="default.aspx.vb" Inherits="GRC.Connect.Web.ReportsDefaultPage" %>

<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/Reports/Reports.css" rel="stylesheet"  type="text/css"/>
    <script src="../../Lib_{{VER}}/Reports/Reports.js" type="text/javascript"></script>
    <script>if (Function('/*@cc_on return document.documentMode===10@*/')()) { document.documentElement.className += ' ie10'; }</script>
<script>
    onEnterLocation = function (pFileNo, pPracticeFolder) {
        var zGSafeGUID = getGSafeGUID();
        var URL=  "../" + pPracticeFolder + "/locationdetails.aspx?sid=" + zGSafeGUID + "&p1=" + pFileNo;
        window.location.href = URL;
    }
</script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LOADING -->
    <grcRSC:Loader runat="server" id="loader" />

    <div id="viewReports" class="pgBodyContent" style="">

        <asp:Button id="btn" runat="server" CssClass="grcBlueBtn" style="margin-bottom:10px; width:185px; border:1px solid #eee;"></asp:Button>

        <ul id="reportsPanel">
<%--            <li>
                <span>Favorite Reports</span>
                <div class="panelGroup" data-bind="foreach: favoritePanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="click: function () { openChartPrefilter($data.Href, $data.Id); return false; }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target }, click: function () { openRequestedSinglePopup($data.Href, $data.Id); return false; }">
                                <i class="fas fa-running"></i>
                            </a>
                            <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>--%>
            <!-- ko ifnot: hideFLFirePanel -->
            <li>
                <span>Facility Level Fire</span>
                <div class="panelGroup" data-bind="foreach: FLfirePanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideFLBMPanel -->
            <li>
                <span>Facility Level Boiler & Machinery</span>
                <div class="panelGroup" data-bind="foreach: FLBMPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideFLIRPanel -->
            <li>
                <span>Facility Level Infrared Thermography</span>
                <div class="panelGroup" data-bind="foreach: FLIRPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideFLjurisPanel -->
            <li>
                <span>Facility Level Jurisdictional</span>
                <div class="panelGroup" data-bind="foreach: FLjurisPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideFLDSPanel -->
            <li>
                <span>Facility Level Diversified Services</span>
                <div class="panelGroup" data-bind="foreach: FLDSPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideFLNHPanel -->
            <li>
                <span>Facility Level Natural Hazards</span>
                <div class="panelGroup" data-bind="foreach: FLNHPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideFLPSPanel -->
            <li>
                <span>Facility Level Process Safety</span>
                <div class="panelGroup" data-bind="foreach: FLPSPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideAllServicesPanel -->
            <li>
                <span>Cross-Service</span>
                <div class="panelGroup" data-bind="foreach: allServicesPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                          <%--  <a class="grcYellowBtn">
                                <i class="far fa-star"></i>
                            </a>--%>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideFirePanel -->
            <li id="firePanel">
                <span>Fire Protection Engineering</span>
                <div class="panelGroup" data-bind="foreach: firePanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr:{ onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideBmPanel -->
            <li id="bmPanel">
                <span>Boiler & Machinery Engineering</span>
                <div class="panelGroup" data-bind="foreach: bmPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr:{ onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideIrPanel -->
            <li id="irPanel">
                <span>Infrared Thermography</span>
                <div class="panelGroup" data-bind="foreach: irPanelData">
                   <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                       <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideJurisPanel-->
            <li id="jurisPanel">
                <span>Jurisdictional</span>
                <div class="panelGroup" data-bind="foreach: jurisPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideNatHazPanel -->
            <li id="natHazPanel">
                <span>Natural Hazards</span>
                <div class="panelGroup" data-bind="foreach: natHazPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideDivServPanel -->
            <li id="divSrvPanel">
                <span>Diversified Services</span>
                <div class="panelGroup" data-bind="foreach: divSrvPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
            <!-- ko ifnot: hideProcSafetyPanel -->
            <li id="procPanel">
                <span>Process Safety</span>
                <div class="panelGroup" data-bind="foreach: procSafetyPanelData">
                    <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                        <span class="reportTypeIcon" data-bind="html: $data.ImageName"></span>
                        <span class="reportText" data-bind="text: $data.Text"></span>
                        <div class="reportBtns">
                            <!-- ko if: $data.CanFilter -->
                            <a class="grcBlueBtn" data-bind="attr: { onclick: $data.Href }" >
                                <i class="far fa-filter"></i>
                            </a>
                            <!-- /ko -->
                            <!-- ko ifnot: $data.CanFilter-->
                            <span class="reportSpacer">
                                &nbsp;
                            </span>
                            <!-- /ko -->
                            <a class="grcGreenBtn" data-bind="attr: { target: $data.Target, onclick: $data.BypassFilterHref }">
                                <i class="fas fa-running"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </li>
            <!-- /ko -->
        </ul>
        <div class="noteText">
            <div class="noteRow">
                <label class="grcBlueBtn">
                    <i class="far fa-filter"></i>
                </label>
                <span style="margin-left:3px;margin-right:100px;">Run with filtering </span>
                <label class="grcGreenBtn">
                    <i class="fas fa-running"></i>
                </label>
                <span style="margin-left:3px;">Quick run with all default settings</span>
            </div>
        </div>
    </div>

</asp:Content>