<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="News.aspx.vb" Inherits="GRC.Connect.Web.News" %>

<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>
<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/global.js"></script>
    <script src="../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/NavLink.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/topbanner.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/nav.js" type="text/javascript"></script>

    <link rel="Stylesheet" type="text/css" href="../../css/pages/LatLongSearch.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/tables.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LOADING -->
    <grcRSC:Loader runat="server" ID="loader" />

    <div id="view">
        <div id="LatLongHolder">
            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="NEWS" />
            <StdHeader:StdHeader runat="server" ID="StdHeader1" SubHeader="Keep up with the latest Connect news" />
            <div id="btnHldr">
                <asp:Button ID="GotoServices" runat="server" Text="Go to Services" CssClass="grcBlueBtn" style="margin-right:10px;"/>
                <asp:Button ID="GotoDashboard" runat="server" Text="Go to Dashboard" CssClass="grcBlueBtn" />
            </div>

            <div style="margin-left: 5px; border:thick solid #0046AD;text-align:center;padding:5px">
                <b>Join our Voice Of Customer Team!!</b><br />
                Do you want your voice heard regarding future Connect enhancements?<br />
                We want your input and ideas<br />
                We want to hear how Connect can be improved to help meet your needs.  We will also discuss new capabilities coming in future releases.<br />
                <br />
                The next meeting is Wednesday, March 16, 2022, at 10:00 AM Eastern time.<br />
		Reserve these dates on your calendar to attend the Voice of Customer meetings for the remainder of 2022: June 8, September 16, December 7
		<br />
                <a href="pdf/GRCinvitation3.ics"><b>Add to Calendar</b></a>
                <br />

                <img src="images/VoC.jpg" style="width:592px;height:302px" />
            </div>
            <br />

            <div style="margin-left: 5px; border: thick solid #0046AD; text-align: left; padding:5px">
	    <b>1st Quarter 2022 Training</b><br />
            Read below about what is new in Connect and the functionality that is coming soon.<br />
		To learn more about these topics and others, attend our 1st Quarter 2022 Training<br />
                <div style="margin-left: 50px;">
                     Thursday, March 3<br />
                     10:00 AM – 11:00 AM Eastern Time<br />
                     <a href="pdf/GRCinvitation1.ics"><b>Add to Calendar</b></a>
                </div>
            </div>
            <br />

            <div style="margin-left: 5px; border: thick solid #0046AD; text-align: left; padding:5px">
            <b>Available Now!!</b><br />

                Connect allows users to upload documents on the Recommendations screen.  Use this to show before and after photos of the work
			you have completed on recommendations or other documentation that you want stored related to improvements you have made.<br />
                Click the Recs link in the Location Listings grid to view Recommendations.<br />
                (Note: Recommendation grids, reports, and exports are still available on the Reports page.<br /><br />

                My Preferences allows you to choose the screen you see when you first log into Connect.  Choose from Dashboards, Services, Reports, and more.<br />

                <asp:HyperLink ID="ContactUsLink" runat="server" Visible="false">Contact your servicing team</>)</asp:HyperLink>
                <br />
            </div>
            <br />

            <div style="margin-left: 5px; border: thick solid #0046AD; text-align: left; padding:5px">
            <b>Coming Soon!!</b><br />
                Maps with Natural Hazard overlays.  See where floods, hurricanes, high winds, and other weather events and natural hazards might 
		threaten your company's locations.<br />
                <div style="text-align:center"><img src="images/news1.jpg" style="width:874px;height:389px;" /></div>
                <br />
            </div>
            <br />


            <br />

        </div>
    </div>

</asp:Content>
