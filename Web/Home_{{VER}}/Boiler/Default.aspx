<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectServerLocationList.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultBoiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        This is the Boiler and Machinery Locations Listing page
    </div>
    <br />&nbsp;<br />
    <div class="tableDiv">
        <div style="height: 35px;">
            <asp:Repeater ID="rptFileNo" runat="server">
                <ItemTemplate>
                    <span style="width: 120px;">
                        <asp:Button ID='btnFileNo' CssClass="k-button k-button-padding k-button-100wide" runat="server" Text='<%# Eval("FileNo") %>' OnClientClick="" />
                        <asp:HiddenField ID='hidFileNo' Value='<%# Eval("FileNo") %>' runat="server" />
                    </span>
                </ItemTemplate>
                <SeparatorTemplate>
                    </div>
                    <div style="height: 35px;">
                </SeparatorTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
