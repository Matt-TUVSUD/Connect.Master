<%@ Page Title="Client Information | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectWelcomeServer.Master" CodeBehind="WhatsNew.aspx.vb" Inherits="GRC.Connect.Web.WhatsNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div class="messageInstructionsLeft"><asp:Label runat="server" ID="lblInstructions">Double click the document below to open.</asp:Label></div>
        <div class="contentSubHeading"><asp:Label runat="server" ID="lblContentTitle">What's New!</asp:Label></div>
    </div>

    <br style="clear: both;">&nbsp;<br />

    <div>
        <telerik:RadFileExplorer
            runat="server"
            ID="FileExplorer1"
            Width="100%" 
            Height="300px"
            OnClientFileOpen="getFile"
            onclientload="sortByName"
            onclientfolderloaded="openFirstFile">
        </telerik:RadFileExplorer>
    </div>

    <asp:HiddenField ID="IsPagePostBack" runat="server" value="False" />

    <script type="text/javascript">
        //// TURN FIRSTLOAD TO TRUE TO LOAD THE FIRST FILE AT FIRST PAGE LOAD
        //// TURN TO FALSE TO NOT LOAD THE FIRST FILE AT ANY TIME.
        //var firstLoad = true;
        var firstLoad = false;
        
        function getFile(sender, args) {
            tempPath = args._item._path;
            if (tempPath[tempPath.length - 1] != "\\" && tempPath[tempPath.length - 1] != "/") {
                //// TURN OFF THE OPEN EVENT
                args.set_cancel(true);
                //// GET THE FILE
                buildFileOpenLink(args._item._path, getGSafeGUID(), "4", "", false);
            }
        }

        function sortByName(sender, args) {
            var tempExplorer = sender.get_grid().get_masterTableView();
            tempExplorer.sort("Name DESC");
        }

        function openFirstFile(sender, args) {
            var hiddenControl = "<%= IsPagePostBack.ClientID %>";
            var isPostBack = document.getElementById(hiddenControl).value;
            if (firstLoad && isPostBack == "false") {
                var tempExplorer = sender.get_grid().get_masterTableView();
                var fileName = tempExplorer._dataSource[1].Name;
                var filePath = args._item._path;
                buildFileOpenLink(filePath + fileName, getGSafeGUID(), "4", "", false);
                firstLoad = false;
            }
        }
    </script>

</asp:Content>
