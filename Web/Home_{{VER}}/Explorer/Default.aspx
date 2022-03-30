<%@ Page Title="Client Information | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultExplorerPage" %>

<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/genericCSS.css" />
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="view" class="pgBodyContent" style="justify-content:center; align-items:center;">
        <div id="GenericHolder">

            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="CLIENT LIBRARY" />
            <br />
            <asp:Label runat="server" ID="lblInstructions">Double click the document below to open.</asp:Label>

            <div style="width: 100%">
                <telerik:RadFileExplorer runat="server" ID="FileExplorer1" Width="100%" Height="520px" OnClientFileOpen="getFile" OnExplorerPopulated="RadFileExplorer1_ExplorerPopulated">
                </telerik:RadFileExplorer>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function getFile(sender, args) {
            tempPath = args._item._path;
            if (tempPath[tempPath.length - 1] != "\\" && tempPath[tempPath.length - 1] != "/") {
                //// TURN OFF THE OPEN EVENT
                args.set_cancel(true);
                //// GET THE FILE
                buildFileOpenLink(args._item._path, getGSafeGUID(), getQueryVariable("p1"), "", false);
            }
        }
    </script>

</asp:Content>
