<%@ Page Language="vb" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServerNoLinks.Master" AutoEventWireup="false" CodeBehind="CheckChartBatchPDF.aspx.vb" Inherits="GRC.Connect.Web.CheckChartBatchPDF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="masterLeftNav" id="viewMasterLeftNav" style="float: left;">
        <span>
            <div id="nav_Container" class="nav_ContainerBackgroundFire nav_PlainText" style="padding-top: 260px;">
                &nbsp;
            </div>
        </span>
    </div>

    <div style="float: left;">
    <div class="masterHeader" id="viewMasterTop">
        <span>
            <!-- HEADER -->
            <div class="headerContainer">
                <div class="headerLeft"><img src="../../Home_{{VER}}/Images/Home_{{VER}}/logo_english_clientconnect.png" alt="Global Risk Consultants" style="width: 450px; border: none;" /></div>
                <div class="headerRight">&nbsp;</div>
            </div>
            <!-- END HEADER -->
        </span>
    </div>

    <br />&nbsp;<br />

    <div style="width: 500px;">
        <div style="text-align: center;">
            <h2>Chart Print To PDF Test Page</h2>
        </div>

        <br />
        
        <div class="tableDiv" style="padding-left: 50px; width: 570px;">
            <div style="width: 570px;">
                <span style="width: 570px;"><asp:Label ID="lblURL" runat="server" Text="Fully Qualified URL"></asp:Label>:</span>
                <span style="width: 570px;"><asp:TextBox ID="txtURL" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="550px" Text="http://localhost:60574/Home_{{VER}}/Charts/Recommendations/Recommendations.aspx"></asp:TextBox></span>
            </div>
            <div style="width: 570px;">
                <span style="width: 570px;"><asp:Label ID="lblGSafe" runat="server" Text="GSafe GUID"></asp:Label>:</span>
                <span style="width: 570px;"><asp:TextBox ID="txtGSafe" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="550px" Text="386fb0605ff44b1bbaec75424f779122"></asp:TextBox></span>
            </div>
        </div>

        <br />&nbsp;<br />&nbsp;<br />

        <div class="tableDiv" style="padding-left: 50px; width: 570px;">
            <span>
                <asp:Button ID="btnDownloadPDF" CssClass="k-button k-button-padding" runat="server" Width="115px" Text="Download PDF" />
            </span>
        </div>
                
        <br />&nbsp;<br />

        <div style="text-align: center">
            <asp:Label ID="lblMessage" runat="server" CssClass="messageError"></asp:Label>
        </div> 
    </div>

    </div>
    
    <div style="padding-bottom: 200px;">&nbsp;</div>

</asp:Content>