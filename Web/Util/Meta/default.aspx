<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="GRC.Connect.Web.Columns" %>

<%@ Register Src="~/Util/Meta/ColumnMeta.ascx" TagPrefix="meta" TagName="ColumnMeta" %>
<%@ Register Src="~/Util/Meta/GridMeta.ascx" TagPrefix="meta" TagName="GridMeta" %>
<%@ Register Src="~/Util/Meta/Auth.ascx" TagPrefix="meta" TagName="Auth" %>
<%@ Register Src="~/Util/Meta/CurrencyMeta.ascx" TagPrefix="meta" TagName="CurrencyMeta" %>
<%@ Register Src="~/Util/Meta/LossEstBeforeMeta.ascx" TagPrefix="meta" TagName="LossEstBeforeMeta" %>
<%@ Register Src="~/Util/Meta/LossEstAfterMeta.ascx" TagPrefix="meta" TagName="LossEstAfterMeta" %>
<%@ Register Src="~/Util/Meta/LossEstCostMeta.ascx" TagPrefix="meta" TagName="LossEstCostMeta" %>
<%@ Register Src="~/Util/Meta/ColorMeta.ascx" TagPrefix="meta" TagName="ColorMeta" %>
<%@ Register Src="~/Util/Meta/UserReclassificationControl.ascx" TagPrefix="meta" TagName="UserReclassificationControl" %>
<%@ Register Src="~/Util/Meta/EmailTemplateControl.ascx" TagPrefix="meta" TagName="EmailTemplateControl" %>
<%@ Register Src="~/Util/Meta/Misc.ascx" TagPrefix="meta" TagName="Misc" %>
<%@ Register Src="~/Util/Meta/KillExcel.ascx" TagPrefix="meta" TagName="Excel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css/meta.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div>
        <form id="form1" runat="server" style="width: 900px; height: 900px; margin: auto;">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Default" Height="900px" Width="900px">
            </telerik:RadAjaxLoadingPanel>
            <telerik:RadTabStrip ID="RadTabStrip1" runat="server" Font-Bold="true" Orientation="HorizontalTop" Skin="Web20">
                <Tabs>
                    <telerik:RadTab Text="GRC Connect Meta Authentication" Value="1"></telerik:RadTab>
                    <telerik:RadTab Text="Fields" PageViewID="RadPageView2" Value="2"></telerik:RadTab>
                    <telerik:RadTab Text="Grids" PageViewID="RadPageView3" Value="3"></telerik:RadTab>
                    <telerik:RadTab Text="Currency" PageViewID="RadPageView4" Value="4"></telerik:RadTab>
                    <telerik:RadTab Text="Loss Estimates" PageViewID="RadPageView5" Value="6">
                        <Tabs>
                            <telerik:RadTab Text="Before"  PageViewID="RadPageView5" Value="7" ></telerik:RadTab>
                            <telerik:RadTab Text="After" PageViewID="RadPageView6" Value="8"></telerik:RadTab>
                            <telerik:RadTab Text="Cost" PageViewID="RadPageView7" Value="9"></telerik:RadTab>
                        </Tabs>                    
                   </telerik:RadTab>
                   <telerik:RadTab Text="Color" PageViewID="RadPageView8" Value="10"></telerik:RadTab>
                   <telerik:RadTab Text="Reclassification" PageViewID="RadPageView9" Value="11"></telerik:RadTab>
                   <telerik:RadTab Text="Email Templates" PageViewID="RadPageView10"  Value="12"></telerik:RadTab>
                   <telerik:RadTab Text="Misc" PageViewID="RadPageView13"  Value="13"></telerik:RadTab>
                   <telerik:RadTab Text="Excel" PageViewID="RadPageView14"  Value="14"></telerik:RadTab>

                </Tabs>
            </telerik:RadTabStrip>
            <telerik:RadMultiPage ID="RadMultiPage1" Width="100%" Height="100%" runat="server" BorderColor="gray" BorderWidth="1">
                <telerik:RadPageView ID="RadPageView1" runat="server">
                    <meta:Auth runat="server" ID="Auth" />
                </telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView2" runat="server">
                    <meta:ColumnMeta runat="server" ID="BatchColumn" />
                </telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView3" runat="server">
                    <meta:GridMeta runat="server" ID="GridMeta" />
                </telerik:RadPageView>
                 <telerik:RadPageView ID="RadPageView4" runat="server">
                     <meta:CurrencyMeta runat="server" id="CurrencyMeta" />
                </telerik:RadPageView>
                 <telerik:RadPageView ID="RadPageView5" runat="server">
                     <meta:LossEstBeforeMeta runat="server" id="LossEstBeforeMeta" />
                </telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView6" runat="server">
                    <meta:LossEstAfterMeta runat="server" id="LossEstAfterMeta" />
                </telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView7" runat="server">
                    <meta:LossEstCostMeta runat="server" id="LossEstCostMeta" />
                </telerik:RadPageView>
                 <telerik:RadPageView ID="RadPageView8" runat="server">
                     <meta:ColorMeta runat="server" id="ColorMeta" />
                </telerik:RadPageView>
                  <telerik:RadPageView ID="RadPageView9" runat="server">
                      <meta:UserReclassificationControl runat="server" id="UserReclassificationControl" />
                </telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView10" runat="server">
                      <meta:EmailTemplateControl runat="server" id="EmailTemplateControl1" />
                </telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView13" runat="server">
                    <meta:Misc runat="server" id="Misc" />
                </telerik:RadPageView>
                <telerik:RadPageView ID="RadPageView14" runat="server">
                    <meta:Excel runat="server" id="Excel1" />
                </telerik:RadPageView>

            </telerik:RadMultiPage>         
        </form>
    </div>
</body>
</html>
