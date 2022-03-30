<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="footer.ascx.vb" Inherits="GRC.Connect.Web.footer" %>
    <!-- ADMIN SECTION AND VARIOUS WINDOW MARKUP -->
    <div id="footerLeft" class="footerItem first" style="" runat="server">
        <span class="bottomBanner_Text">Copyright
        &copy;
            <asp:Label ID="curYear" runat="server"></asp:Label>
            TUV SUD Global Risk Consultants Corp.
        </span>
    </div>
    <div class="footerItem middle">
        &nbsp;
    </div>
    <div id="viewFooter" class="footerItem last printNone">
        <span class="bottomBanner_Link">
            <a data-bind="attr: {href: termsLink}" href="#" target="_blank">Terms of Service</a>
        </span>
    </div>
