<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectServerMyBatch.Master" CodeBehind="myBatchReports.aspx.vb" Inherits="GRC.Connect.Web.myBatchReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Client Connect - myBatch Reports</title>
    <link rel="Stylesheet" type="text/css" href="../../css/pages/mybatch.css" />
    <script type="text/javascript" src="../../Lib_{{VER}}/Generated/REDocHeader.js"></script>
    <script type="text/javascript" src="../../Lib_{{VER}}/Custom/REDocHeader.js"></script>
    <script type="text/javascript" src="../../Lib_{{VER}}/pages/util_{{VER}}.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INSTRUCTIONS AND ICON -->
    <div>
        <div style="float: left;">
            <div id="topInstructions" class="messageNoticeNoBold" style="float: left; margin-left: 15px; width: 800px; font-style: normal;">
                <img src="../images/icons/reports/document_information_32x32.png" alt="TUV SUD GRC Client Connect | Batch Reports Tool Information" style="height: 32px; width: 32px; padding-right: 6px; padding-bottom: 6px;" align="left" /><label>The below listing is sorted by your most recent Batch Report request.<br />These files will be available for 30 days.</label>
            </div>
        </div>
        <div style="float: right;">
            <div class="icon_container">
                <%--<div class="icon_cell" style="padding-left: 20px;">
                    <div class="icon_exit icon_center" id="icoClose" style="background-position: 0px 0px;" runat="server" ></div>
                    &nbsp;&nbsp;<span class="icon_label"><asp:HyperLink CssClass="hiddenLink" runat="server" ID="hypClose">Close</asp:HyperLink></span>
                </div>--%>
            </div>
        </div>
    </div>
    <!-- END INSTRUCTIONS AND ICON -->

    <br style="clear: both;" />

    <!-- REPORT CONTENT -->
    <div id="divReportListContainer" runat="server" class="" style="width: auto; margin: 12px;">
        <div class="tableDiv" style="padding: 10px; width: 920px;">
            <asp:Repeater ID="rptReportList" runat="server">
                <HeaderTemplate>
                    <div style="height: 22px; padding-right: 0px; padding-left: 0px; border-bottom: 1px solid black; margin-bottom: 5px;">
                        <span class="mybatch_Column1 mybatch_Heading"><label>Date Last Modified</label></span>
                        <span class="mybatch_Column2 mybatch_Heading"><label>File Size</label></span>
                        <span class="mybatch_Column3 mybatch_Heading"><label>Report Name</label></span>
                    </div>
                </HeaderTemplate>
                <ItemTemplate>
                    <div style="padding-right: 0px; padding-left: 0px;">
                        <span class="mybatch_Column1"><asp:Label ID="lblReportDate" runat="server" Text='<%# Container.DataItem.colFldCreateDate%>'></asp:Label></span>
                        <span class="mybatch_Column2"><asp:Label ID="lblReportSize" runat="server" Text='<%# Container.DataItem.colFldFileSize%>'></asp:Label>&nbsp;MB</span>
                        <span class="mybatch_Column3"><asp:LinkButton href="#" ID="lnkReportLink" runat="server" ToolTip='<%# Container.DataItem.colFldGuid%>' OnClientClick="getMyBatchReport(this); return false;"><asp:Label runat="server" Text='<%# Container.DataItem.colFldFileName%>'></asp:Label><asp:Label runat="server" Text='<%# Container.DataItem.colFldExtension%>'></asp:Label></asp:LinkButton></span>
                    </div>
                </ItemTemplate>
                <SeparatorTemplate>
                </SeparatorTemplate>
                <FooterTemplate>
                    <div style="height: 5px; padding-right: 0px; padding-left: 0px;">
                        <span class="mybatch_Column1 mybatch_Heading">&nbsp;</span>
                        <span class="mybatch_Column2 mybatch_Heading">&nbsp;</span>
                        <span class="mybatch_Column3 mybatch_Heading">&nbsp;</span>
                    </div>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
    <!-- END REPORT CONTENT -->

    <br style="clear: both;" />&nbsp;<br />

    <div class="messageError" style="text-align: center">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <label id="lblClientMessage"></label>
    </div>

    <br style="clear: both;" />&nbsp;<br />

    <script type="text/javascript">
        function getMyBatchReport(pFile) {
            $("#lblClientMessage").html("");
            var zGSafeGUID = getGSafeGUID();
            var zFileGUID = pFile.title;
            var zURL = "../FD/ServeBatchReport.ashx?pGSafeGUID=" + getGSafeGUID() + "&pFileGUID=" + zFileGUID;
            window.location.href = zURL;
            return false;
        }
    </script>

</asp:Content>
