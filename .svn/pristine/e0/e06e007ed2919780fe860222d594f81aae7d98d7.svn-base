<%--<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultSitemap_OneCall" %>--%>
<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectSitemapServer.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultSitemap_OneCall" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/sitemap.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />

    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeView.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeViewOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorer.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorerOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindow.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindowOffice2010Blue.css" />

    <%--<link rel="Stylesheet" type="text/css" href="../../css/Telerik/sitemapTreeView.css" />--%>
    <%--<script src="../../Lib_{{VER}}/JQuery/jquery.hoverintent.min.js" type="text/javascript"></script>--%>
    <%--<script src="../../Lib_{{VER}}/Generated/ViewCCNavLink.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCNavLink.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/Generated/ViewCCGSafeSitemapItems.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCGSafeSitemapItems.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/knockoutkendo/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/RERptJobDef.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/RERptJobDef.js" type="text/javascript"></script>
    <%--<script src="../../Lib_{{VER}}/pages/sitemap.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/pages/sitemap_onecall.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
            <StyleSheets>
                <telerik:StyleSheetReference Path="../../css/Telerik/RadTreeView.css" />
                <telerik:StyleSheetReference Path="../../css/Telerik/RadTreeViewOffice2010Silver.css" /> 
                <telerik:StyleSheetReference Path="../../css/Telerik/RadFileExplorer.css" />
                <telerik:StyleSheetReference Path="../../css/Telerik/RadFileExplorerOffice2010Silver.css" />
                <telerik:StyleSheetReference Path="../../css/Telerik/RadWindow.css" />
                <telerik:StyleSheetReference Path="../../css/Telerik/RadWindowOffice2010Blue.css" /> 
            </StyleSheets>
        </telerik:RadStyleSheetManager>
        <telerik:RadWindowManager 
            id="RadWindowManager1" 
            runat="server" 
            Title="Your Request Is Being Processed"
            Behaviors="Close"
            VisibleStatusbar="False"
            Skin="Office2010Blue"
            IconUrl="../../Home_{{VER}}/Images/icons/reports/chart_column_16x16.png"
            ReloadOnShow="True"
            Height="300px"
            Modal="True">
            <windows>
                <telerik:RadWindow 
                    ID="RadWindow1" 
                    runat="server"
                    Left="350px"
                    Top="225px" 
                    Width="395px" 
                    Height="300px"
                    Behaviors="Close"
                    Modal="true">
                </telerik:RadWindow>
            </windows>
        </telerik:RadWindowManager>
    
    <div id="sitemapContainer" class="sitemapContainer">
        
        <!-- HEADINGS -->
        <div class="sitemapRowTop" style="height: 35px;"> 
	        <div id="column1Heading" class="sitemapCellNoBorder" style="left: 0px;"> 
	            <div id="column01Heading" class="sitemapCellHeading"><label data-bind="text: objLanguageLabels().lblMainMenu">&nbsp;</label></div> 
            </div>
	        <div id="column2Heading" class="sitemapCellNoBorder" style="left: 200px;"> 
	            <div id="column02Heading" class="sitemapCellHeading"><label data-bind="text: objLanguageLabels().lblFire">&nbsp;</label></div>
            </div>
	        <div id="column3Heading" class="sitemapCellNoBorder" style="left: 400px;"> 
	            <div id="column03Heading" class="sitemapCellHeading"><label data-bind="text: objLanguageLabels().lblBoilerAndMachinery">&nbsp;</label></div>
            </div>
	        <div id="column4Heading" class="sitemapCellNoBorder" style="left: 600px;"> 
	            <div id="column04Heading" class="sitemapCellHeading"><label data-bind="text: objLanguageLabels().lblInfrared">&nbsp;</label></div>
            </div>
	        <div id="column5Heading" class="sitemapCellNoBorder" style="left: 800px;"> 
	            <div id="column05Heading" class="sitemapCellHeading"><label data-bind="text: objLanguageLabels().lblJurisdictional">&nbsp;</label></div>
            </div>
	        <div id="column6Heading" class="sitemapCellNoBorder" style="left: 1000px;"> 
	            <div id="column06Heading" class="sitemapCellHeading"><label data-bind="text: objLanguageLabels().lblNatHazSeismic">&nbsp;</label></div>
            </div>
	        <div id="column7Heading" class="sitemapCellNoBorder" style="left: 1200px;"> 
	            <div id="column07Heading" class="sitemapCellHeading"><label data-bind="text: objLanguageLabels().lblNatHazFlood">&nbsp;</label></div>
            </div>
	        <div id="column8Heading" class="sitemapCellNoBorder" style="left: 1400px;"> 
	            <div id="column08Heading" class="sitemapCellHeading" style="width: 202px;"><label data-bind="text: objLanguageLabels().lblNatHazWind">&nbsp;</label></div>
            </div>
        </div>

        <!-- ROW 1 -->
	    <!-- TOTAL HEIGHT OF HEADING 32px + SUBHEADING 15px + EMPTY 7px = 54px --> 
	    <!-- TOTAL HEIGHT OF SUBHEADING = 15px --> 
	    <!-- TOTAL HEIGHT OF ROW SHOULD BE ONE OF THE ABOVE PLUS CONTENT HEIGHT --> 
        <div id="row01" class="sitemapRowTop" style="height: 215px; z-index: 101;"> 
	        <div id="cell0101" class="sitemapCell" style="left: 0px;"> 
	            <div id="cell0101SubHeading" class="sitemapCellSubHeading">Navigation</div> 
	            <div id="cell0101Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0101TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0101Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label>&nbsp;</label></div>
	            </div> 
	        </div> 
	        <div id="cell0102" class="sitemapCell" style="left: 200px;"> 
	            <div id="cell0102SubHeading" class="sitemapCellSubHeading">Location Listing</div> 
	            <div id="cell0102Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0102TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0102Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsLocationListing"></label></div>
	            </div> 
	        </div> 
	        <div id="cell0103" class="sitemapCell" style="left: 400px;"> 
	            <div id="cell0103SubHeading" class="sitemapCellSubHeading">Location Listing</div> 
	            <div id="cell0103Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0103TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0103Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsLocationListing"></label></div>
	            </div> 
	        </div>
	        <div id="cell0104" class="sitemapCell" style="left: 600px;"> 
	            <div id="cell0104SubHeading" class="sitemapCellSubHeading">Location Listing</div> 
	            <div id="cell0104Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0104TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0104Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsLocationListing"></label></div>
                </div>
            </div>
	        <div id="cell0105" class="sitemapCell" style="left: 800px;"> 
	            <div id="cell0105SubHeading" class="sitemapCellSubHeading">Location Listing</div> 
	            <div id="cell0105Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0105TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0105Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsLocationListing"></label></div>
                </div>
            </div>
	        <div id="cell0106" class="sitemapCell" style="left: 1000px;"> 
	            <div id="cell0106SubHeading" class="sitemapCellSubHeading">Location Listing</div> 
	            <div id="cell0106Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0106TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0106Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsLocationListing"></label></div>
                </div>
            </div>
	        <div id="cell0107" class="sitemapCell" style="left: 1200px;"> 
	            <div id="cell0107SubHeading" class="sitemapCellSubHeading">Location Listing</div> 
	            <div id="cell0107Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0107TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0107Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsLocationListing"></label></div>
                </div>
            </div>
 	        <div id="cell0108" class="sitemapCell" style="left: 1400px;"> 
	            <div id="cell0108SubHeading" class="sitemapCellSubHeading">Location Listing</div> 
	            <div id="cell0108Content" class="sitemapCellContent" style="height: 200px;"> 
                    <div id="cell0108TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 195px;"></div>
                    <div id="cell0108Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsLocationListing"></label></div>
                </div>
            </div>
	    </div> 

	    <br /> 
        <!-- ROW 2 -->
	    <!-- TOTAL HEIGHT OF HEADING 32px + SUBHEADING 15px + EMPTY 7px = 54px --> 
	    <!-- TOTAL HEIGHT OF SUBHEADING = 15px --> 
	    <!-- TOTAL HEIGHT OF ROW SHOULD BE ONE OF THE ABOVE PLUS CONTENT HEIGHT --> 
	    <div id="row02" class="sitemapRow" style="height: 145px; z-index: 102;"> 
	        <div id="cell0201" class="sitemapCell" style="left: 0px;"> 
	            <div id="cell0201SubHeading" class="sitemapCellSubHeading">Quick Reference</div> 
	            <div id="cell0201Content" class="sitemapCellContent" style="height: 130px;"> 
                    <div id="cell0201TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0201Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label>&nbsp;</label></div>
	            </div> 
	        </div> 
	        <div id="cell0202" class="sitemapCell" style="left: 200px;"> 
	            <div id="cell0202SubHeading" class="sitemapCellSubHeading">Output Reports</div> 
	            <div id="cell0202Content" class="sitemapCellContent" style="height: 130px;"> 
                    <div id="cell0202TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0202Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsOutputReports"></label></div>
	            </div> 
	        </div> 
	        <div id="cell0203" class="sitemapCell" style="left: 400px;">
	            <div id="cell0203SubHeading" class="sitemapCellSubHeading">Output Reports</div>
	            <div id="cell0203Content" class="sitemapCellContent" style="height: 130px;">
                    <div id="cell0203TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0203Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsOutputReports"></label></div>
	            </div> 
	        </div> 
 	        <div id="cell0204" class="sitemapCell" style="left: 600px;"> 
	            <div id="cell0204SubHeading" class="sitemapCellSubHeading">Output Reports</div> 
	            <div id="cell0204Content" class="sitemapCellContent" style="height: 130px;"> 
                    <div id="cell0204TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0204Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsOutputReports"></label></div>
                </div>
            </div>
 	        <div id="cell0205" class="sitemapCell" style="left: 800px;"> 
	            <div id="cell0205SubHeading" class="sitemapCellSubHeading">Output Reports</div> 
	            <div id="cell0205Content" class="sitemapCellContent" style="height: 130px;"> 
                    <div id="cell0205TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0205Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsOutputReports"></label></div>
                </div>
            </div>
 	        <div id="cell0206" class="sitemapCell" style="left: 1000px;"> 
	            <div id="cell0206SubHeading" class="sitemapCellSubHeading">Output Reports</div> 
	            <div id="cell0206Content" class="sitemapCellContent" style="height: 130px;"> 
                    <div id="cell0206TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0206Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsOutputReports"></label></div>
                </div>
            </div>
 	        <div id="cell0207" class="sitemapCell" style="left: 1200px;"> 
	            <div id="cell0207SubHeading" class="sitemapCellSubHeading">Output Reports</div> 
	            <div id="cell0207Content" class="sitemapCellContent" style="height: 130px;"> 
                    <div id="cell0207TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0207Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsOutputReports"></label></div>
                </div>
            </div>
 	        <div id="cell0208" class="sitemapCell" style="left: 1400px;"> 
	            <div id="cell0208SubHeading" class="sitemapCellSubHeading">Output Reports</div> 
	            <div id="cell0208Content" class="sitemapCellContent" style="height: 130px;"> 
                    <div id="cell0208TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 125px;"></div>
                    <div id="cell0208Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsOutputReports"></label></div>
                </div>
            </div>
	    </div> 

	    <br />
        <!-- ROW 3 -->
	    <!-- TOTAL HEIGHT OF HEADING 32px + SUBHEADING 15px + EMPTY 7px = 54px --> 
	    <!-- TOTAL HEIGHT OF SUBHEADING = 15px --> 
	    <!-- TOTAL HEIGHT OF ROW SHOULD BE ONE OF THE ABOVE PLUS CONTENT HEIGHT --> 
	    <div id="row03" class="sitemapRow" style="height: 175px; z-index: 103;"> 
	        <div id="cell0301" class="sitemapCell" style="left: 0px;"> 
	            <div id="cell0301SubHeading" class="sitemapCellSubHeading">Libraries</div> 
	            <div id="cell0301Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0301TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0301Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label>&nbsp;</label></div>
	            </div> 
	        </div> 
	        <div id="cell0302" class="sitemapCell" style="left: 200px;"> 
	            <div id="cell0302SubHeading" class="sitemapCellSubHeading">Data Extracts</div> 
	            <div id="cell0302Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0302TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0302Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsDataExtracts"></label></div>
	            </div> 
	        </div> 
	        <div id="cell0303" class="sitemapCell" style="left: 400px;"> 
	            <div id="cell0303SubHeading" class="sitemapCellSubHeading">Data Extracts</div> 
	            <div id="cell0303Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0303TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0303Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsDataExtracts"></label></div>
	            </div> 
	        </div>
 	        <div id="cell0304" class="sitemapCell" style="left: 600px;"> 
	            <div id="cell0304SubHeading" class="sitemapCellSubHeading">Data Extracts</div> 
	            <div id="cell0304Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0304TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0304Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsDataExtracts"></label></div>
                </div>
            </div>
 	        <div id="cell0305" class="sitemapCell" style="left: 800px;"> 
	            <div id="cell0305SubHeading" class="sitemapCellSubHeading">Data Extracts</div> 
	            <div id="cell0305Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0305TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0305Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsDataExtracts"></label></div>
                </div>
            </div>
 	        <div id="cell0306" class="sitemapCell" style="left: 1000px;"> 
	            <div id="cell0306SubHeading" class="sitemapCellSubHeading">Data Extracts</div> 
	            <div id="cell0306Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0306TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0306Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsDataExtracts"></label></div>
                </div>
            </div>
 	        <div id="cell0307" class="sitemapCell" style="left: 1200px;"> 
	            <div id="cell0307SubHeading" class="sitemapCellSubHeading">Data Extracts</div> 
	            <div id="cell0307Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0307TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0307Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsDataExtracts"></label></div>
                </div>
            </div>
 	        <div id="cell0308" class="sitemapCell" style="left: 1400px;"> 
	            <div id="cell0308SubHeading" class="sitemapCellSubHeading">Data Extracts</div> 
	            <div id="cell0308Content" class="sitemapCellContent" style="height: 160px;"> 
                    <div id="cell0308TreeView" class="sitemapNavContainer" style="white-space: nowrap; overflow: visible; min-height: 155px;"></div>
                    <div id="cell0308Instructions" class="messageInstructions sitemapInstructions" style="min-height: 30px;"><label data-bind="text: objLanguageLabels().lblInstructionsDataExtracts"></label></div>
                </div>
            </div>

            <script id="templateUrl" type="text/x-kendo-templates">       
                <!-- FOR DEVELOPMENT, DISPLAY THE NAVLINK ID BEFORE THE SITEMAP ITEM -->
                <!-- <span style="color: red">(#= item.key #)</span>&nbsp; -->
                # if (item.navEnabled == 0 || item.navEnabled == "False") { #
                    <span title="#= item.comment #">#= item.text #</span>
                # } else { #
                    # if (item.target != undefined && item.url != "") { #
                        # if (item.target.toLowerCase() == "charts") { #
                            <a title="#= item.title #" class="k-in" href="\\#" onclick="openChartPrefilter('#= item.url #', '#= item.key #', '#= item.gridId #', '#= item.chartId #', '#= item.reportId #')" style="margin-left: -7px;">#= item.text #</a>
                        # } else if (item.target.toLowerCase() == "report") { #
                            <a title="#= item.title #" class="k-in" href="\\#" onclick="openReportPopup('#= item.url #', '#= item.gridId #', '#= item.chartId #', '#= item.reportId #')" style="margin-left: -7px;">#= item.text #</a>
                        # } (item.target.toLowerCase() == "practicereport") { #
                            <a title="#= item.title #" class="k-in" href="\\#" onclick="openPracticeReportPopup('#= item.url #', '#= item.gridId #', '#= item.chartId #', '#= item.reportId #')" style="margin-left: -7px;">#= item.text #</a>
                        # } else if (item.target.toLowerCase() == "singlereport") { #
                            <a title="#= item.title #" class="k-in" href="\\#" onclick="openSingleReportPopup('#= item.url #', '#= item.gridId #', '#= item.chartId #', '#= item.reportId #')" style="margin-left: -7px;">#= item.text #</a>
                        # } else if (item.target.toLowerCase() == "programstatus") { #
                            <a title="#= item.title #" class="k-in" href="\\#" onclick="onOpenProgramStatusWindow('#= item.url #', '#= item.key #', '#= item.gridId #', '#= item.chartId #', '#= item.reportId #')" style="margin-left: -7px;">#= item.text #</a>
                        # } else if (item.target.toLowerCase() == "recfollowupstatus") { #
                            <a title="#= item.title #" class="k-in" href="\\#" onclick="onOpenRecFollowUpStatusWindow('#= item.url #', '#= item.key #', '#= item.gridId #', '#= item.chartId #', '#= item.reportId #')" style="margin-left: -7px;">#= item.text #</a>
                        # } else if (item.target.toLowerCase() == "_blank") { #
                            <a title="#= item.title #" class="k-in" href="\\#" onclick="openRequestedSinglePopup('#= item.url #', '#= item.gridId #', '#= item.chartId #', '#= item.reportId #')" style="margin-left: -7px;">#= item.text #</a>                    
                        # } else { #
                            <a title="#= item.title #" class="k-in" href="#= item.url #" target="#= item.target #" style="margin-left: -7px;">#= item.text #</a>
                        # } #
                    # } else { #
                        #= item.text #
                    # } #
                # } #
            </script>
        </div> 


        <!-- PREFILTER POPUP WINDOW -->
        <div id="windowFilters" class="windowContent" style="">
            <br />
            <div style="padding-right: 15px;">
                <div class="windowSubHeading"><label data-bind="text: objLanguageLabels().lblSettings">SETTINGS</label></div>
                <div class="windowSection" style="height: 75px; margin-bottom: 10px;">
                    <div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblConvertCurrency">Convert Currency</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidthSettings" id="filterConvertCurrency">
                            <select class="filterWidthSettings" data-bind="kendoDropDownList: {
    data: DSFilterConvertCurrency,
    value: ValueFilterConvertCurrency,
    widget: widgetFilterConvertCurrency
}"></select>
                        </span>
                    </div>
                    <br style="clear: both;" />
                    <div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblConvertUnits">Convert Units</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidthSettings" id="filterConvertUnits">
                            <select class="filterWidthSettings" data-bind="kendoDropDownList: {
    data: DSFilterConvertUnits,
    value: ValueFilterConvertUnits,
    widget: widgetFilterConvertUnits
}"></select>
                        </span>
                    </div>
                </div>
            </div>

            <br />

            <div style="padding-right: 15px;">
                <div class="windowSubHeading"><label data-bind="text: objLanguageLabels().lblFilters">FILTERS</label></div>
                <div class="windowSection" style="height: 175px; overflow: hidden; overflow-y: scroll;">
                    <div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblCustomAccess">Custom Access</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidth" id="filterCustomAccess">
                            <select class="filterWidth" data-bind="kendoDropDownList: {
    data: DSFilterCustomAccess,
    value: ValueFilterCustomAccess,
    widget: widgetFilterCustomAccess
}"></select>
                        </span>
                    </div>
                    <br style="clear: both;" />
                    <div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblDivision">Division</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidth" id="filterDivision">
                            <select class="filterWidth" data-bind="kendoDropDownList: {
    data: DSFilterDivision,
    value: ValueFilterDivision,
    widget: widgetFilterDivision
}"></select>
                        </span>
                    </div>
                    <br style="clear: both;" />
                    <%--<div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblTIV">TIV</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidth" id="filterTIV">
                            <select class="filterWidth" data-bind="kendoDropDownList: {
                            }"></select>
                        </span>
                    </div>
                    <br style="clear: both;" />--%>
                    <%--<div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblHazard">Hazard</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidth" id="filterHazard">
                            <select class="filterWidth" data-bind="kendoDropDownList: {
                            }"></select>
                        </span>
                    </div>
                    <br style="clear: both;" />--%>
                    <div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblInspectionProgramYear">Inspection Program Year</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidth" id="filterInspectionYearProgram">
                            <select class="filterWidth" data-bind="kendoDropDownList: {
    data: DSFilterInspectionProgramYear,
    value: ValueFilterInspectionProgramYear,
    widget: widgetFilterInspectionProgramYear
}"></select>
                        </span>
                    </div>
                    <br style="clear: both;" />
                    <%--<div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblStatus">Status</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidth" id="filterStatus">
                            <select class="filterWidth" data-bind="kendoDropDownList: {
                            }"></select>
                        </span>
                    </div>
                    <br style="clear: both;" />--%>
                    <%--<div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblDateFrom">Date From</label></div>
                    <div class="windowFilterInput">
                        <span><input data-bind="" id="filterDateFrom" class="k-autocomplete k-input filterWidth" style="height: 24px;" /></span>
                    </div>
                    <br style="clear: both;" />--%>
                    <%--<div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblDateTo">Date To</label></div>
                    <div class="windowFilterInput">
                        <span><input data-bind="" id="filterDateTo" class="k-autocomplete k-input filterWidth" style="height: 24px;" /></span>
                    </div>
                    <br style="clear: both;" />--%>
                    <%--<div class="windowFilterLabel"><label data-bind="text: objLanguageLabels().lblCountry">Country</label></div>
                    <div class="windowFilterInput">
                        <span class="filterWidth" id="filterCountry">
                            <select class="filterWidth" data-bind="kendoDropDownList: {
                            }"></select>
                        </span>
                    </div>--%>
                </div>
            </div>
            <br style="clear: both;" /><br />
            <div style="text-align: right;">
                &nbsp;<div class="k-button k-button-padding" data-bind="click: onContinue"><label data-bind="    text: objLanguageLabels().lblExecuteReports">Execute Report(s)</label></div>
                &nbsp;<div class="k-button k-button-padding" data-bind="click: onCancel"><label data-bind="    text: objLanguageLabels().lblCancel">Cancel</label></div>
            </div>
        </div>


        <!-- PLEASE WAIT WINDOW FOR PROGRAM STATUS PAGE -->
        <div id="windowPleaseWait" class="windowContent">
            <%--<div><img src="../images/icons/wait/icon_hourglass_32x32.png" align="left" alt="Warning" class="windowImageSmallPadding" /></div>--%>
            <img src="../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="TUV SUD GRC Client Connect - Please Wait" />
            <div id="windowPleaseWaitProcessed">
                <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
                <br />&nbsp;<br />&nbsp;<br />
                <%--<div><label data-bind="">Please wait while your Program Status page is being built.  This may take several minutes.  Please be patient.</label></div>--%>
                <div>
                    <label>Thank you for your patience while the Program Status web page is being built.</label>
                    <br />&nbsp;<br />
                    <label>As this tool provides a statistical view of your entire program, this may take a few minutes.</label>
                </div>
                <br />&nbsp;<br />
                <div style="text-align: center;"><button class="k-button k-button-padding" data-bind="" onclick="cancelProgramStatusSiteMap();">Cancel</button></div>
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

    <script type="text/javascript">
        var windowPleaseWait = null;

        $(document).ready(function () {
            ///////////////////////////////////////////
            //// LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                lblMainMenu: "Main Menu",
                lblFire: "Fire",
                lblBoilerAndMachinery: "Boiler & Machinery",
                lblInfrared: "Infrared",
                lblJurisdictional: "Jurisdictional",
                lblNatHazSeismic: "NatHaz - Seismic",
                lblNatHazFlood: "NatHaz - Flood",
                lblNatHazWind: "NatHaz - Wind",
                lblInstructionsLocationListing: "Note: Choose from any area above to access output reports on the location level.",
                lblInstructionsOutputReports: "Note: All output reports above are on a multi-location level.",
                lblInstructionsDataExtracts: "Note: All data extracts above are on a multi-location level.",

                //// WINDOWS
                lblWindowTitleFilters: "Filters and Settings",
                lblWindowTitleAccept: "Report(s) in Process",
                lblWindowTitleCancel: "Report(s) Cancelled",
                lblWindowTitleNoSelection: "No Reports Selected",
                lblWindowTitleStatus: "Report Status",
                lblWindowReportsStatusDescription1: "Your report has been submitted and is now being processed.  You will be notified when the report job complete and ready for viewing.",
                lblWindowReportsStatusDescription2: "The report process has been cancelled.  Please review your report selection and click 'Execute Report(s)' to start again.",
                lblWindowReportsMessageDescription: "Please check at least one report before proceeding to the Filters and Settings page.",
                lblCancelWindowDescription: "The report process has been cancelled.  Please review your report selection and click 'Execute Report(s)' to start again.",
                lblAcceptWindowDescription: "Your report has been submitted and is now being processed.  You will be notified when the report job complete and ready for viewing.",
                lblNext: "Next",
                lblCancel: "Cancel",
                lblClose: "Close",
                lblNameOfReport: "Name of report",
                lblProcessReports: "Process Report(s)",
                lblExecuteReports: "Execute Report",
                lblWhereApplicable: "(Where Applicable)",
                lblFilters: "FILTERS",
                lblSettings: "SETTINGS",
                lblNotification: "NOTIFICATION",
                lblNotificationMessageOnly: "Notification Message Only",
                lblEmailWithReportsInAttachment: "Email with Report(s) in Attachment",
                lblEmailWithLinkToReports: "Email with Link to Report(s)",

                //// FILTERS
                lblCustomAccess: "Custom Access",
                lblDivision: "Division",
                lblTIV: "TIV",
                lblTIVValue: "TIV Value",
                lblHazard: "Hazard",
                lblInspectionProgramYear: "Inspection Program Year",
                lblStatus: "Status",
                lblDateFrom: "Date From",
                lblDateTo: "Date To",
                lblCountry: "Country",
                lblConvertCurrency: "Convert Currency",
                lblConvertUnits: "Convert Units"
            };


            ///////////////////////////////////////////
            //// VIEWMODEL
            var view = {
                //// DECLARATIONS
                index: 0,
                messageError: ko.observable(),
                messageWarning: ko.observable(),
                messageNotice: ko.observable(),
                objLanguageLabels: ko.observable(dsLanguageLabels),
                collTemp: new es.objects.RERptJobDefCollection(),

                //// FILTERS
                DSFilterConvertCurrency: ko.observableArray(),
                widgetFilterConvertCurrency: ko.observable(),
                ValueFilterConvertCurrency: ko.observable(),

                DSFilterConvertUnits: ko.observableArray(),
                widgetFilterConvertUnits: ko.observable(),
                ValueFilterConvertUnits: ko.observable(),

                DSFilterCustomAccess: ko.observableArray(),
                widgetFilterCustomAccess: ko.observable(),
                ValueFilterCustomAccess: ko.observable(),

                DSFilterDivision: ko.observableArray(),
                widgetFilterDivision: ko.observable(),
                ValueFilterDivision: ko.observable(),

                DSFilterInspectionProgramYear: ko.observableArray(),
                widgetFilterInspectionProgramYear: ko.observable(),
                ValueFilterInspectionProgramYear: ko.observable(),

                loadPickers: function () {
                    var tempArray = new Array();

                    //// CURRENCY
                    tempArray = [];
                    tempArray.push("US Dollar");
                    tempArray.push("British Pound");
                    tempArray.push("Canadian Dollar");
                    tempArray.push("Euro");
                    tempArray.push("Japanese Yen");
                    tempArray.push("Mexican Peso");
                    tempArray.push("New Zealand Dollar");
                    view.DSFilterConvertCurrency(tempArray);
                    view.widgetFilterConvertCurrency().value(tempArray[0]);

                    //// UNITS
                    tempArray = [];
                    tempArray.push("English");
                    tempArray.push("Metric");
                    view.DSFilterConvertUnits(tempArray);
                    view.widgetFilterConvertUnits().value(tempArray[0]);

                    //// CUSTOM ACCESS
                    tempArray = [];
                    tempArray.push("(All)");
                    tempArray.push("Demo");
                    view.DSFilterCustomAccess(tempArray);
                    view.widgetFilterCustomAccess().value(tempArray[0]);

                    //// DIVISION
                    tempArray = [];
                    tempArray.push("(All)");
                    tempArray.push("Division A");
                    tempArray.push("Division B");
                    tempArray.push("Division C");
                    tempArray.push("Division D");
                    view.DSFilterDivision(tempArray);
                    view.widgetFilterDivision().value(tempArray[0]);

                    //// CUSTOM ACCESS
                    tempArray = [];
                    tempArray.push("(All)");
                    tempArray.push("Latest Ratings / All Locations");
                    tempArray.push("Current Inspection Period");
                    tempArray.push("Previous Inspection Period");
                    tempArray.push("Previous Two Inspection Period");
                    view.DSFilterInspectionProgramYear(tempArray);
                    view.widgetFilterInspectionProgramYear().value(tempArray[0]);
                },

                onOpenFilterWindow: function (pURL, pFilters) {
                    windowFilters.data("kendoWindow").open();
                    $("#windowFilters").css("display", "block");
                },

                onCancel: function () {
                    windowFilters.data("kendoWindow").close();
                },

                onContinue: function () {
                    windowFilters.data("kendoWindow").close();
                },

                onCloseAll: function () {
                    windowFilters.data("kendoWindow").close();
                }
            };


            ///////////////////////////////////////////
            //// FUNCTION TO OPEN THE WINDOW
            //// BOUND TO WINDOW SO IT IS GLOBAL
            window.openPreFilterPopup = function (pURL, pFilters) {
                //// CALL THE METHOD IN THE VIEW
                view.onOpenFilterWindow(pURL, pFilters);
            }

            ///////////////////////////////////////////
            //// ACTIVATE BINDINGS LAST
            ko.applyBindings(view, $("#sitemapContainer")[0]);


            ///////////////////////////////////////////
            //// SETUP KENDOUI
            //// FILTER WINDOW
            var windowFilters = $("#windowFilters");
            windowFilters.kendoWindow({
                width: "425px",
                height: "465px",
                title: "", // title added below with JQuery
                actions: false
            });
            $("#windowFilters").closest(".k-window").css({
                top: 100,
                left: 325
            });
            $("#windowFilters").prev().find(".k-window-title").append("<img src='../images/icons/reports/chart_column_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowTitleFilters);

            //// DEFINE PLEASE WAIT WINDOW
            windowPleaseWait = $("#windowPleaseWait");
            windowPleaseWait.kendoWindow({
                width: "300px",
                height: "220px",
                title: "", // title added below with JQuery
                actions: {},
                animation: { open: { effects: "default" }, close: { effects: "default" } },
                modal: true
            });
            $("#windowPleaseWait").closest(".k-window").css({
                top: 300,
                left: 375
            });
            $("#windowPleaseWait").prev().find(".k-window-title").append("<img src='../images/icons/wait/icon_hourglass_32x32.png' align='left' alt='Please Wait' class='windowIcon'/>  " + "Please Wait");


            ///////////////////////////////////////////
            //// GET DATA
            view.loadPickers();


            ///////////////////////////////////////////
            //// EXTRA FUNCTIONS
            onOpenProgramStatusWindow = function (pURL, pNavId) {
                openProgramStatusPrefilter(pURL, pNavId);
            }

            onOpenRecFollowUpStatusWindow = function (pURL, pNavId) {
                openRecFollowUpStatusPrefilter(pURL, pNavId);
            }
        });

        function cancelProgramStatusSiteMap() {
            $("#windowPleaseWaitProcessed").hide();
            $("#windowPleaseWaitCancelled").show();
            var gSafeGuid = getGSafeGUID();
            document.location.href = "../Sitemap/Default.aspx?sid=" + gSafeGuid;
        }

    </script>

</asp:Content>