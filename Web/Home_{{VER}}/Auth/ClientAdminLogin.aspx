<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServerNoLinks.Master" CodeBehind="ClientAdminLogin.aspx.vb" Inherits="GRC.Connect.Web.ClientAdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="masterHeader" id="viewMasterTop">
        <span>
            <!-- HEADER -->
            <div class="headerContainer">
                <div class="headerLeft"><img src="../Images/Home_{{VER}}/logo_english_clientconnect.png" alt="Global Risk Consultants" style="width: 450px; border: none;" /></div>
                <div class="headerRight">&nbsp;</div>
            </div>
            <!-- END HEADER -->
        </span>
    </div>

    <br />&nbsp;<br />

    <div style="width: 500px;">
        <div style="text-align: center;">
            <h2>Client Administration Access</h2>
        </div>

        <br />
        
        <div class="tableDiv" style="padding-left: 150px; width: 355px;">
            <%--
            <div>
                <span style="width: 260px;"><label>You are logged in as:</label></span>
                <span style=""><asp:TextBox ID="txtFullName" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="250px" ReadOnly="true"></asp:TextBox></span>
            </div>
            <div>
                <span style="height: 10px;">&nbsp;</span>
            </div>
            --%>
            <div style="width: 355px;">
                <span style="width: 70px;"><asp:Label ID="lblPassword" runat="server" Text="Password">Password</asp:Label>:</span>
                <span style="width: 280px;"><asp:TextBox ID="txtPassword" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="115px" autocomplete="off" TextMode="Password"></asp:TextBox></span>
            </div>
            <%--
            <div>
                <span style="width: 260px;"><label>&nbsp;</label></span>
                <span style="font-size: 10pt;"><sup>*Password is case sensitive.</sup></span>
            </div>
            --%>
        </div>

        <br />&nbsp;<br />&nbsp;<br />

        <div style="text-align: center">
            <span>
                <asp:Button ID="btnAuthenticate" CssClass="k-button k-button-padding" runat="server" Width="115px" Text="Authenticate" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" CssClass="k-button k-button-padding" runat="server" Width="115px" Text="Cancel" />
            </span>
        </div>

        <br />&nbsp;<br />


        <div style="text-align: center">
            <asp:Label ID="lblMessage" runat="server" CssClass="messageError"></asp:Label>
        </div> 
    </div>

    <div style="padding-bottom: 200px;">&nbsp;</div>

</asp:Content>