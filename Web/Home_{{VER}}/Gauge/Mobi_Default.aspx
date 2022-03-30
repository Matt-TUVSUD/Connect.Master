<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectWelcomeServer.Master" CodeBehind="Mobi_Default.aspx.vb" Inherits="GRC.Connect.Web.Mobi_DefaultGauge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/Generated/ViewCCGaugeStats.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCGaugeStats.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />

    <div id="view" data-bind="with: view">
        <div class="gaugeCompanyName"><asp:Label ID="lblGaugeCompanyName" runat="server"></asp:Label></div>
        <div class="gaugeWelcome"><h1><label id="lblWelcomToGlobalRiskConnect" data-bind="text: $parent.objLanguageLabels().lblWelcomToGlobalRiskConnect" class="gaugeWelcome"></label></h1></div>
        <div class="gaugeTagLine"><h3><label id="lblStayConnected" data-bind="text: $parent.objLanguageLabels().lblStayConnected" class="gaugeTagLine"></label></h3></div>
        <div class="gaugeContainer">
            <div class="gaugeLeftContainer"><img src="../Images/gauge/GaugeShell/img_gauge_left.png" alt="Global Risk Consultants" /></div>
            <div class="gaugeMiddleContainer">
                <div class="gaugeMiddleTop"><img src="../Images/gauge/GaugeShell/img_gauge_middle_top.png" alt="Global Risk Consultants" /></div>
                <div class="gaugeMiddleMap">
                    <map id="gaugeMap" name="gaugeMap">
                        <area id="service1" alt="" shape="circle" coords="12,69,25" onmouseover="showBanner('1')" onmouseout="resetBanner('1')" onmousedown="clickBanner('1')" />
                        <area id="service2" alt="" shape="circle" coords="29,34,25" onmouseover="showBanner('2')" onmouseout="resetBanner('2')" onmousedown="clickBanner('2')" />
                        <area id="service3" alt="" shape="circle" coords="67,17,25" onmouseover="showBanner('3')" onmouseout="resetBanner('3')" onmousedown="clickBanner('3')" />
                        <area id="service4" alt="" shape="circle" coords="103,34,25" onmouseover="showBanner('4')" onmouseout="resetBanner('4')" onmousedown="clickBanner('4')" />
                        <area id="service5" alt="" shape="circle" coords="119,69,25" onmouseover="showBanner('5')" onmouseout="resetBanner('5')" onmousedown="clickBanner('5')" />
                    </map>
                    <div>
                        <img class="dialImageBackground" id="dialMain" src="../Images/gauge/gauge_English/innerGauge_none/img_gauge_middle_map.png" alt="" usemap="#gaugeMap" />
                        <img class="dialImage" id="dial1" src="../Images/gauge/gauge_English/innerGauge_fire/img_gauge_middle_map.png" alt="" usemap="#gaugeMap" />
                        <img class="dialImage" id="dial2" src="../Images/gauge/gauge_English/innerGauge_boiler/img_gauge_middle_map.png" alt="" usemap="#gaugeMap" />
                        <img class="dialImage" id="dial3" src="../Images/gauge/gauge_English/innerGauge_infrared/img_gauge_middle_map.png" alt="" usemap="#gaugeMap" />
                        <img class="dialImage" id="dial4" src="../Images/gauge/gauge_English/innerGauge_juris/img_gauge_middle_map.png" alt="" usemap="#gaugeMap" />
                        <img class="dialImage" id="dial5" src="../Images/gauge/gauge_English/innerGauge_natural/img_gauge_middle_map.png" alt="" usemap="#gaugeMap" />
                    </div>
                </div>
                <div class="gaugeMiddleBottom"><img src="../Images/gauge/GaugeShell/img_gauge_middle_bottom.png" alt="Global Risk Consultants" /></div>
            </div>
            <div class="gaugeRightContainer">
                <div class="gaugeRightTop"><img src="../Images/gauge/GaugeShell/img_gauge_right_top.png" alt="Global Risk Consultants" /></div>
                <div class="gaugeRightBanner">
                    <img class="bannerImageBackground" id="bannerMain" src="../Images/gauge/gauge_English/innerGauge_none/img_gauge_right_banner.png" alt="" />
                    <img class="bannerImage" id="banner1" src="../Images/gauge/gauge_English/innerGauge_fire/img_gauge_right_banner.png" alt="" />
                    <img class="bannerImage" id="banner2" src="../Images/gauge/gauge_English/innerGauge_boiler/img_gauge_right_banner.png" alt="" />
                    <img class="bannerImage" id="banner3" src="../Images/gauge/gauge_English/innerGauge_infrared/img_gauge_right_banner.png" alt="" />
                    <img class="bannerImage" id="banner4" src="../Images/gauge/gauge_English/innerGauge_juris/img_gauge_right_banner.png" alt="" />
                    <img class="bannerImage" id="banner5" src="../Images/gauge/gauge_English/innerGauge_natural/img_gauge_right_banner.png" alt="" />
                </div>
                <div class="gaugeRightBottomEnglish"><!-- IMAGE IN BACKGROUND --></div>
            </div>
            <div class="gaugeRightBuffer"><img src="../Images/gauge/GaugeShell/img_gauge_right_buffer.png" alt="Global Risk Consultants" /></div>
        </div>
        
        <!-- START QUICK INFORMATION AREA -->
        <div>
            <%--FIRE--%>
            <div class="tableDiv gaugeStatsContainer" id="gaugeStats1">
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsDue"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().FireInspectionsDue"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsCompleted"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().FireInspectionsComplete"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInpsectionsPending"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().FireInspectionsPending"></label></a></span>
                </div>
                <div class="gaugeStatsLine">&nbsp;</div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLink"><asp:HyperLink ID="hypFire" runat="server">Enter Fire Program</asp:HyperLink></span>
                </div>
            </div>

            <%--BOILER AND MACHINERY--%>
            <div class="tableDiv gaugeStatsContainer" id="gaugeStats2">
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsDue"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().BMInspectionsDue"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsCompleted"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().BMInspectionsComplete"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInpsectionsPending"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().BMInspectionsPending"></label></a></span>
                </div>
                <div class="gaugeStatsLine">&nbsp;</div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLink"><asp:HyperLink ID="hypBoiler" runat="server">Enter Boiler &amp; Machinery Program</asp:HyperLink></span>
                </div>
            </div>

            <%--INFRARED--%>
            <div class="tableDiv gaugeStatsContainer" id="gaugeStats3">
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsDue"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().IRInspectionsDue"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsCompleted"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().IRInspectionsComplete"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInpsectionsPending"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().IRInspectionsPending"></label></a></span>
                </div>
                <div class="gaugeStatsLine">&nbsp;</div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLink"><asp:HyperLink ID="hypInfrared" runat="server">Enter Infrared Program</asp:HyperLink></span>
                </div>
            </div>

            <%--JURISDICTIONAL--%>
            <div class="tableDiv gaugeStatsContainer" id="gaugeStats4">
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoObjections"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().JurisNoObjections"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoActiveObjects"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().JurisNoActiveObjections"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoOpenViolations"></label></span>
                    <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().JurisOpenViolations"></label></a></span>
                </div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLabel">&nbsp;</span>
                    <span class="gaugeStatsNumber">&nbsp;</span>
                </div>
                <div class="gaugeStatsLine">&nbsp;</div>
                <div class="gaugeStatsLine">
                    <span class="gaugeStatsLink"><asp:HyperLink ID="hypJuris" runat="server">Enter Jurisdictional Program</asp:HyperLink></span>
                </div>
            </div>

            <%--NAT HAZ--%>
            <div class="tableDiv gaugeStatsContainerNatHaz" id="gaugeStats5">
               <div style="float: left;">
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsDue"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().WindInspectionsDue"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsCompleted"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().WindInspectionsComplete"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInpsectionsPending"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().WindInspectionsPending"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">&nbsp;</div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLink"><asp:HyperLink ID="hypWind" runat="server">Enter Wind Program</asp:HyperLink></span>
                        </div>
                </div>
                <div style="float: left;">
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsDue"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().FloodInspectionsDue"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsCompleted"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().FloodInspectionsComplete"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInpsectionsPending"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().FloodInspectionsPending"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">&nbsp;</div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLink"><asp:HyperLink ID="hypFlood" runat="server">Enter Flood Program</asp:HyperLink></span>
                        </div>
                </div>
                <div style="float: right;">
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsDue"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().SeismicInspectionsDue"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInspectionsCompleted"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().SeismicInspectionsComplete"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLabel"><label data-bind="text: $parent.objLanguageLabels().lblNoInpsectionsPending"></label></span>
                            <span class="gaugeStatsNumber"><a href="#"><label data-bind="text: $parent.objStats().SeismicInspectionsPending"></label></a></span>
                        </div>
                        <div class="gaugeStatsLine">&nbsp;</div>
                        <div class="gaugeStatsLine">
                            <span class="gaugeStatsLink"><asp:HyperLink ID="hypSeismic" runat="server">Enter Seismic Program</asp:HyperLink></span>
                        </div>
                </div>
            </div>

        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            ///////////////////////////////////////////
            //// LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                lblWelcomToGlobalRiskConnect: "Welcome To TUV SUD GRC Connect" + "",
                lblStayConnected: "Stay Connected to your Loss Control Information",
                lblNoInspectionsDue: "No. of Inspections Due",
                lblNoInspectionsCompleted: "No. of Inspections Completed",
                lblNoInpsectionsPending: "No. of Inspections Pending",
                lblNoObjections: "No. of Objections",
                lblNoActiveObjects: "No. of Active Objects",
                lblNoOpenViolations: "No. of Open Recommendations",
                lblEnterFireProgram: "Enter Fire Program",
                lblEnterBoilerProgram: "Enter Boiler and Machinery Program",
                lblEnterInfraredProgram: "Enter Infrared Program",
                lblEnterJurisProgram: "Enter Jurisdictional Program",
                lblEnterFloodProgram: "Enter Flood Program",
                lblEnterWindProgram: "Enter Wind Program",
                lblEnterSeismicProgram: "Enter Seismic Program"
            };


            ///////////////////////////////////////////
            //// VIEWMODEL
            var view = {
                //// DECLARATIONS
                index: 0,
                messageError: ko.observable(),
                messageWarning: ko.observable(),
                messageNotice: ko.observable(),

                //// COLLECTIONS / OBJECTS
                //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
                gSafeGuid: getQueryVariable('sid'),
                clientFeatures: ko.observable(),
                collStats: new es.objects.ViewCCGaugeStatsCollection(),
                objStats: ko.observable(),
                objLanguageLabels: ko.observable()
            };


            ///////////////////////////////////////////
            //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            //// ACTIVATE BINDINGS LAST
            es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
            if (!view.collStats.ViewCCGaugeStatsCollection(view.gSafeGuid)) {
                view.objStats(view.collStats()[0]);
                view.clientFeatures(getClientFeatures(view.gSafeGuid));
                view.objLanguageLabels(dsLanguageLabels);
                ko.applyBindings(view, $("#view")[0]);
            } else {
                view.messageError("* Error while loading Program Statistic Information.");
            }
        });
</script>

</asp:Content>
