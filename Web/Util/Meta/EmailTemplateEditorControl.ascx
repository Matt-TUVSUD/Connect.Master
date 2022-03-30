<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="EmailTemplateEditorControl.ascx.vb" Inherits="GRC.Connect.Web.EmailTemplateEditorControl" %>

<div style="font-family:Arial; font-size:12px; width:1100px;">
    <div>
        <strong>Subject</strong><br />
        <telerik:RadTextBox ID="uxSubjectEditor" Width="100%" runat="server"></telerik:RadTextBox>
    </div>
    <br />
    <div>
        <strong>Body</strong><br />
         <telerik:RadEditor ID="uxBodyEditor" ToolbarMode="Default" Width="100%" runat="server"></telerik:RadEditor>
    </div>
    <br />
    <asp:Button ID="uxSaveButton" runat="server" Text="Save" Width="100" /> &nbsp;&nbsp;&nbsp;
    <asp:Button ID="uxCancelButton" runat="server" Text="Cancel" Width="100" /> 
    <asp:HiddenField ID="uxID" runat="server" />
</div>