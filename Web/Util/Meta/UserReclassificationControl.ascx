<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="UserReclassificationControl.ascx.vb" Inherits="GRC.Connect.Web.UserReclassificationControl" %>

<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="false" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Height="900px" Width="900px">
    <div style="margin: auto; width: 55%; text-align: center; word-wrap: break-word;">
        <br />
        <br />
        <telerik:RadComboBox ID="uxReclassFilePrefixes" AutoPostBack="true" Width="300" runat="server"></telerik:RadComboBox>
        <br />
        <br />

        <asp:Label ID="uxCurrentLink" runat="server" Text=""></asp:Label><br />
        <br />

        <div style="margin: auto; width: 250px; text-align: left;">
            <asp:RadioButtonList ID="uxOptions" runat="server">
                <asp:ListItem Text="Link Only" Value="1" Selected="True"></asp:ListItem>
                <asp:ListItem Text="1st Request Email" Value="2"></asp:ListItem>
                <asp:ListItem Text="2nd Request Email" Value="3"></asp:ListItem>
                <asp:ListItem Text="Confirmation" Value="4"></asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <br />
        <telerik:RadButton runat="server" ID="uxGenerateReclass" Text="Generate"></telerik:RadButton>
        <br />
        <br />

        <span style="color: red; font-weight: bold; width:100%;">Note: 
            <br />
            This tool will reset the current ReclassificationLinkGUID
            <br />
            of the client, as well as all  reclassification actions, including MarkForDeletions in the ezy_user and ezy_Login tables.
        </span>

        <br />
        <br />
        <asp:Label ID="uxStatus" runat="server" Text=""></asp:Label>
    </div>

    <telerik:RadWindow ID="RadWindow1" Width="330" Height="250" runat="server">
        <ContentTemplate>
            <h3>Enter GRC Connect Credentials</h3>
            <telerik:RadTextBox ID="uxConnectUsername" runat="server" Width="300" EmptyMessage="Username"></telerik:RadTextBox><br />
            <telerik:RadTextBox ID="uxConnectPassword" runat="server" Width="300" autocomplete="off" TextMode="Password" EmptyMessage="Password"></telerik:RadTextBox><br /><br />
            <telerik:RadButton ID="uxOKAuth" runat="server" Width="75" Text="OK"></telerik:RadButton> &nbsp;&nbsp;&nbsp;
            <telerik:RadButton ID="uxCancelAuth" runat="server" Width="75" Text="Cancel"></telerik:RadButton> &nbsp;&nbsp;&nbsp;
        </ContentTemplate>

    </telerik:RadWindow>

</telerik:RadAjaxPanel>

