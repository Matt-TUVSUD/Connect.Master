<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Header.ascx.vb" Inherits="GRC.Connect.Web.Header" %>


<div id="viewHeader" class="headerInfo printNone">
    <div class="logo">
        <img class="logoImg" data-bind="attr: { src: logoURL }" alt="Global Risk Consultants" />
        <label class="grcLbl">GRC CONNECT</label>
    </div>
    <div class="line">&nbsp;</div>
    <div id="headerTxtHldr">
        <div id="clientNameHldr">
            <asp:Label ID="lblGaugeCompanyName" runat="server"></asp:Label>
        </div>
        <div id="headerInfoHldr" class="printNone">  <!--the printnone class is needed due to server side code looking for it to not display-->
            <div class="leftSideTxt">
                <asp:Label ID="adminLink" class="adminLnk headerTxt headerLnk" runat="server">
                <a id="adminLnkX" class="headerTxt headerLnk" onclick="onAdminClick(); return false;" href="#">Admin</a></asp:Label>    
                <a id="videosLink" class="videosLnk contactUsLnk headerTxt headerLnk" href="#" data-bind="attr: { href: videosLnkUrl }">Training Videos</a>
                <a id="contactLink" class="contactUsLnk headerTxt headerLnk" href="#" data-bind="attr: { href: contactUsLnkUrl }">Contact Us</a>
            </div>
            <div class="rightSideTxt">
                <asp:Label ID="hasPrefSet" class="preferenceLbl headerTxt" runat="server">
                    You have <a class="preferenceLnk" href="#" data-bind="attr: { href: myPrefLinkUrl }">MyPreference</a> filter(s) applied.
                </asp:Label>
                <asp:Label ID="noPrefSet" class="preferenceLbl headerTxt" runat="server">
                    No <a class="preferenceLnk" href="#" data-bind="attr: { href: myPrefLinkUrl }">MyPreference</a> filters are applied.
                </asp:Label>
                <a class="logoutLnk headerTxt headerLnk" data-bind="attr:{ href: logOutURL }" href="#">
                    <span id="ClientConnectSiteBody_ClientConnectFormBody_lblLogoutHeader">Logout</span>
                </a>
                <asp:Label runat="server" ID="lblLoginUser" CssClass="userNameLbl headerTxt" Text=""></asp:Label>
                <a id="notificationBell" class="noShow headerIcon" href="#" data-bind="click: notificationClick">
                    <i class="fa fa-bell"></i>
                </a>
            </div>
        </div>
    </div>

    <div id="notificationWindow" style="display:none;">
        <div id="updatesContent"></div>
    </div>
</div>