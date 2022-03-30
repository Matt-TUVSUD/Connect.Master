<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web._Default3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <div style="text-align: center;">
        <h1 class="WelcomeHeader">Welcome to <span class="logoLetters_h1">GRC</span> Connect</h1>
        <h3 class="tagLine">Stay Connected to Your Loss Control Information</h3>
        <br />&nbsp;
        <div class="divTable ui-helper-clearfix">
            <%--ACCESS INFORMATION TABLE--%>
            <div class="divTable ui-helper-clearfix">
                <span class="emailLbl">Login</span>
                <br />&nbsp;
                <div>
                    <span class="emailLbl" style="width: 155px; line-height: 24px; float:left;">Email Address: </span>
                    <span style="width: 280px; float: right;"><asp:TextBox ID="txtEmail" style="background:#fff;" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="275px" Height="24px"></asp:TextBox></span>
                </div>
                <br />&nbsp;
                <div>
                    <span class="emailLbl" style="width: 155px; line-height: 24px; float:left;">Welcome: </span>
                    <span style="width: 280px; float: right;"><asp:TextBox ID="txtWelcome" style="background:#fff;" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="275px" Height="24px"></asp:TextBox></span>
                </div>
                <br />&nbsp;
            </div>

            <div>
                <span style="width: 456px; line-height: 24px; float:left; text-align: center;">
                    <asp:HyperLink runat="server" ID="hypChangePassword">Click here to change Display Name or Password</asp:HyperLink>
                </span>
                <br />&nbsp;
            </div>

            <%--ACCESS INFORMATION TABLE--%>
            <div class="divTable ui-helper-clearfix">
                <span class="emailLbl">Access</span>
                <br />&nbsp;
                <div>
                    <span class="emailLbl" style="width: 155px; line-height: 24px; float:left;">Client Selection: </span>
                    <span style="width: 280px; float: right;">
                        <telerik:RadComboBox ID="cboClient" Runat="server" 
                                Width="275px" TabIndex="2" EnableScreenBoundaryDetection="False" 
                                Filter="Contains" MaxHeight="200px" OnClientKeyPressing="onKeyPress">
                        </telerik:RadComboBox>
                    </span>
                </div>
                <br />&nbsp;
            </div>
            <br style="clear: both;" />&nbsp;
            <div style="text-align: center">
                <div>
                    <asp:Button ID="btnSkip" CssClass="k-button k-button-padding" Width="150px" runat="server" Text="Connect Now" />

                    <%--
                    &nbsp;&nbsp; - or - &nbsp;&nbsp;
                    <asp:Button ID="btnNext" CssClass="k-button k-button-padding" Width="150px" runat="server" Text="Edit myPreferences" />
                    --%>

                </div>
            </div>
        </div>    


        <br />
        <br /><asp:Label ID="lblMessage" runat="server" CssClass="messageError"></asp:Label>
        <br />
<%--
    Please select a client by clicking on one of the below buttons.  Please see alternate methods of selecting a client lower on this page.
    <br />&nbsp;<br />
    <div class="tableDiv">
        <div>
            <asp:Repeater ID="rptClientButtons" runat="server">
                <ItemTemplate>
                    <span style="width: 265px;">
                        <asp:Button ID='btnClient' CssClass="k-button k-button-padding k-button-240wide" runat="server" Text='<%# Eval("Clientname") %>' OnClientClick=""/>
                        <asp:HiddenField ID='hidCldbname' Value='<%# Eval("Cldbname") %>' runat="server" />
                    </span> 
                </ItemTemplate>
                <SeparatorTemplate>
                    </div>
                    <div>
                </SeparatorTemplate>
            </asp:Repeater>
        </div>
    </div>
--%>

    <script type="text/javascript">
        function onKeyPress(sender, args) {
            if (args._domEvent.keyCode == 13) {
                var btnSkip = $("#<%= btnSkip.ClientID %>");
                btnSkip.click();
            }
        }
    </script>

</asp:Content>
