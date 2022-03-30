<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultPreferences" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    .k-input-padding
    {
        padding-left: 6px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="imageHldr">
        <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
    </div>
    <div id="loginHldr">
        <div class="maintenanceMsgHldr" style="">
            <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
        </div>
        <div id="logoHldr">
            <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
        </div>
        <div id="tagLine">
            <p>Stay Connected to Your<br />
                Loss Control Information.</p>
        </div>
        <div class="userHldr">
            <%--ACCESS INFORMATION TABLE--%>
            <div class="divTable borderBottom borderLeft borderTop borderRight" style="width: 455px; padding: 10px;">
                <b>Access</b>
                <div style="text-align:center;">
                    <span class="preferenceLbl">Client Selection: </span>
                    <span>
                        <asp:TextBox ID="txtClientSelection" CssClass="textInput" runat="server"></asp:TextBox>
                    </span>
                </div>
            </div>
            <%-- INSTRUCTIONS TO USER --%>
            <div style="text-align: center; padding-top: 20px; padding-bottom: 10px; color:#ff0000;">
                If you would like to change your default settings, click the &quot;Edit myPreferences&quot; button below.
                Be sure to click &quot;Save Preferences&quot; button to save all updates.
                Your preferences will be saved for all future login sessions.
            </div>
             <%--PREFERENCE OPTIONS TABLE--%>
            <div class="divTable">
                <b>Preference Options</b>
                <div style="margin-top:10px; margin-bottom:10px">
                    <span class="preferenceLbl">Currency Default: </span>
                    <span>
                        <asp:TextBox ID="txtCurrencyDefault" CssClass="textInput" runat="server"></asp:TextBox>
                    </span>
                </div>
                <div style="margin-bottom:10px">
                    <span class="preferenceLbl">Units Default: </span>
                    <span style="">
                        <asp:TextBox ID="txtUnitDefault" CssClass="textInput" runat="server"></asp:TextBox>
                    </span>
                </div>
                <div runat="server" id="divDivision" style="margin-bottom:10px">
                    <span class="preferenceLbl">Division(s) Default: </span>
                    <span style="">
                        <asp:TextBox ID="txtDivisionDefault" CssClass="textInput" runat="server"></asp:TextBox>
                    </span>
                </div>
                <div runat="server" id="divCustomAccess" style="margin-bottom:10px">
                    <span class="preferenceLbl"><%=GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(GRC.Connect.Libraries.CoreLib.UtilGSafe.GetGUIDFromQueryString(), GRC.Connect.Libraries.CoreLib.UtilGSafe.KeyName.CustomAccessLabelDefault)%>: </span>
                    <span style="">
                        <asp:TextBox ID="txtCustomerAccessDefault" CssClass="textInput" runat="server"></asp:TextBox>
                    </span>
                </div>
                <div runat="server" id="divLocation" style="margin-bottom:10px">
                    <span class="preferenceLbl">Locations(s) Default: </span>
                    <span style="">
                        <asp:TextBox ID="txtLocationDefault" CssClass="textInput" runat="server"></asp:TextBox>
                    </span>
                </div>
                <div runat="server" id="divTIV" style="margin-bottom:10px">
                    <span class="preferenceLbl">TIV Default: </span>
                    <span style="">
                        <asp:TextBox ID="txtTIVDefault" CssClass="textInput" runat="server"></asp:TextBox>
                    </span>
                </div>
                <div style="text-align: center;  margin-bottom:10px;">
                    <asp:HyperLink ID="hypEditPreferences" runat="server" CssClass="loginPageLnk">Edit myPreferences</asp:HyperLink>
                </div>
            </div>
            <div style="text-align: center;">
                <div>
                    <asp:Button ID="btnConnect" CssClass="loginBtn" runat="server" Text="Connect" />
                </div>
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>