<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="Manage.aspx.vb" Inherits="GRC.Connect.Web.Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/icons.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/print.css" media="print" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/programstatus.css" />
    <link rel="stylesheet" type="text/css" href="../../css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../../css/Dashboards/manage.css" />

    <script src="../../Scripts/bootstrap.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            var defaultUrl = "<%= DefaultURL %>"
            var dashboardPage = 'DashboardRedirect.aspx';
            var gsafeIdErrorMessage = "GSafeId is required.";
            var defaultErrorMessage = "Report Id is missing.";

            //REPORT NEW REQUIRED - RENAME POPUP DEFAULT
            $("#sRequired").hide();
            $("#<%= txtNewReportName.ClientID%>").val('');

            //INITIAL LOAD - DISABLE ALL BUTTONS EXCEPT CREATE NEW
            for (const btn of $("#tblButtons button.selectButton").not('.uCreate')) {
                $(btn).prop("disabled", true);
            }
            $(".uPubPriv").prop("disabled", true);
            $(".uDelete").prop("disabled", true);

            //DISABLE CONNECT DASHBOARDS 'OPEN' BUTTON ON PAGE LOAD
            $('#btnOpenReport').prop("disabled", true);
            $('#btnOpenReport').addClass('grcNeutralDisabledBtn');

            var cn = '<%= URLCreateNew %>';
            if (cn == '#') {
                $(".uCreate").prop("disabled", true);
            }

            $("#grcReportsList").find("button").on("click", function () {
                for (const li of $("div.list-group button.active")) {
                    li.classList.remove("active");
                }
                console.log($(this).attr("reportId"), $(this).attr("IsOwner"));
                $(this).addClass('active');
                $('#btnOpenReport').prop("disabled", false);
                $('#btnOpenReport').removeClass('grcNeutralDisabledBtn');
                $('#btnOpenReport').addClass('grcBlueBtn');
                var rptId = $(this).attr('reportId');
                $('#btnOpenReport').attr("selectedid", rptId);
                $("#<%=txtSelectedReport.ClientID %>").val(rptId);
            });

            //MANAGE AND SET EVENTS ON RENDERED USER REPORTS 
            $("#userReportsList").find("button").on("click", function () {
                for (const li of $("div.list-group button.active")) {
                    li.classList.remove("active");
                }
                $(this).addClass("active");
                $('#btnOpenReport').prop("disabled", true);
                $('#btnOpenReport').addClass('grcNeutralDisabledBtn');
                $('#btnOpenReport').removeClass('grcBlueBtn');

                //Get report information for operation of buttons
                //console.log($(this).attr("reportId"), $(this).attr("IsOwner"));
                $(".uOpen").prop("disabled", false);
                var rptId = $(this).attr("reportId");
                $(".uOpen").attr("selectedid", rptId);

                var isOwner = $(this).attr("IsOwner");
                if (isOwner == 'True') {
                    $(".uEdit").prop("disabled", false);
                    $(".uPubPriv").prop("disabled", false);
                    $(".uRename").prop("disabled", false);
                    $(".uDelete").prop("disabled", false);
                }
                else {
                    $(".uEdit").prop("disabled", true);
                    $(".uPubPriv").prop("disabled", true);
                    $(".uRename").prop("disabled", true);
                    $(".uDelete").prop("disabled", true);
                }

                //COPY OPTION AVAILABLE FOR ALL
                $(".uCopy").prop("disabled", false);

                //SET REPORT ID
                $("#<%=txtSelectedReport.ClientID %>").val(rptId);
            });

            //Open report in View Mode
            $(".uOpen").on("click", function () {
                var gsId = '<%= GSafeID %>';
                var rptId = $(".uOpen").attr("selectedid");
                if (gsId != '' && rptId > 0) {
                    var url = defaultUrl + dashboardPage;
                    var params = "?gsid=<%= GSafeID %>&m=v&rptId=" + rptId;
                    window.open(url + params, "_blank");
                }
                else {
                    alert(defaultErrorMessage);
                }
            });

            //Open report in Edit Mode
            $(".uEdit").on("click", function () {
                var gsId = '<%= GSafeID %>';
                var rptId = $(".uOpen").attr("selectedid");
                if (gsId != '' && rptId > 0) {
                    var url = defaultUrl + dashboardPage;
                    var params = "?gsid=<%= GSafeID %>&m=e&rptId=" + rptId;
                    window.open(url + params, "_blank");
                }
                else {
                    alert(defaultErrorMessage);
                }
            });

            //Open report in Edit Mode with Save As option
            $(".uCopy").on("click", function () {
                var gsId = '<%= GSafeID %>';
                var rptId = $(".uOpen").attr("selectedid");
                if (gsId != '' && rptId > 0) {
                    var url = defaultUrl + dashboardPage;
                    var params = "?gsid=<%= GSafeID %>&m=c&rptId=" + rptId;
                    window.open(url + params, "_blank");
                }
                else {
                    alert(defaultErrorMessage);
                }
            });

            //Create New Report
            $(".uCreate").on("click", function () {
                var gsId = '<%= GSafeID %>';
                if (gsId != '') {
                    var cn = '<%= URLCreateNew %>';
                        if (cn != '#') {
                            var url = defaultUrl + '<%= URLCreateNew %>';
                        window.open(url, "_blank");
                    }
                    else {
                        alert("You do not have access to Create Report!");
                    }
                }
                else {
                    alert(gsafeIdErrorMessage);
                }
            });

            $("#btnOpenReport").on("click", function () {
                var gsId = '<%= GSafeID %>';
                var rptId = $(".uOpenGRC").attr("selectedid");
                if (gsId != '' && rptId > 0) {
                    var url = defaultUrl + dashboardPage;
                    var params = "?gsid=<%= GSafeID %>&rptId=" + rptId;
                    window.open(url + params, "_blank");
                }
                else {
                    alert(defaultErrorMessage);
                }
            });
        });
        pageReload = function () {
            window.location.reload();
        };

        fnRename = function () {
            var nReportName = $("#<%= txtNewReportName.ClientID%>").val().trim();
            if (nReportName.length > 0) {
                $("#sRequired").hide();
                return true;
            }
            else {
                $("#sRequired").show();
                return false;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="unsupported-browser" class="noShow printNone" style="padding: 16px; color: black; border-bottom-color: grey; border-bottom-width: 1px; border-bottom-style: solid; background-color: white;">
        <div style="margin: 0px auto; max-width: 800px;">
            <p style="font-size: 24px;">This feature is not supported by Internet Explorer.</p>
            <p style="font-size: 16px; margin-top: 16px;">Upgrade to Microsoft Edge to take advantage of the latest features, security updates, and technical support.</p>
            <div style="margin-top: 12px;">
                <a style="padding: 6px 12px; border-radius: 2px; border: 1px solid rgb(0, 120, 212); border-image: none; color: white; display: inline-block; background-color: rgb(0, 120, 212);" href="https://go.microsoft.com/fwlink/p/?LinkID=2092881 ">Download Microsoft Edge</a>
                <a style="padding: 6px 12px; border-radius: 2px; border: 1px solid rgb(80, 80, 80); border-image: none; color: rgb(23, 23, 23); display: inline-block; background-color: white;" href="https://docs.microsoft.com/en-US/lifecycle/faq/internet-explorer-microsoft-edge">More info</a>
            </div>
        </div>
    </div>
    <div id="view" data-bind="with: view" style="display: flex; width: 75%; align-items: center;">
        <div id="dashboardHldr">
            <div style="text-align: left;">
                <input type="button" id="pageRefresh" onclick="pageReload()" value="Refresh" style="margin:0 auto 5px;" class="grcBlueBtn" />
                <table class="tableBorder" cellpadding="3" border="0" style="width: 100%">
                    <tbody>
                        <tr>
                            <th>Connect Dashboards</th>
                            <th style="align-content: center; text-align:center">Actions</th>
                        </tr>


                        <tr style="vertical-align:top">
                            <td style="width: 80%">
                                    <asp:Repeater ID="grcReports" runat="server">
                                        <HeaderTemplate>
                                            <div id="grcReportsList" class="list-group" style="overflow: auto; height: 200px">
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <button type='button'
                                                title="<%# DataBinder.Eval(Container.DataItem, "ReportName") %>"
                                                reportid='<%# DataBinder.Eval(Container.DataItem, "ID") %>'
                                                class='list-group-item list-group-item-action'>

                                                <%# DataBinder.Eval(Container.DataItem, "ReportName") %>

                                            </button>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            </div>
                                        </FooterTemplate>
                                    </asp:Repeater>

                            </td>
                            <td>
                                <input type="button" id="btnOpenReport" value="Open" style="margin:0 auto;" class=" grcNeutralDisabledBtn uOpenGRC" />
                                &nbsp;<img id="loading" src="images/ajax-loader.gif" style="display: none" />
                                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                                <input type="hidden" id="exptime" />

                            </td>
                        </tr>

                    </tbody>
                </table>
            </div>
            <br />
            <br />
            <div id="dashboardHldr2">
                <div style="text-align: left;">
                    <table id="tblCustomReports" class="table" border="0">
                        <tbody>
                            <tr>
                                <th>User Dashboards</th>
                                <th style="align-content: center; text-align:center">Actions</th>
                            </tr>
                            <tr>
                                <td style="width: 80%">
                                    <asp:Label ID="lblMessageUserReports" runat="server" ForeColor="Red" Font-Size="Small"></asp:Label>
                                    <asp:Repeater ID="userReports" runat="server">
                                        <HeaderTemplate>
                                            <div id="userReportsList" class="list-group" style="overflow: auto; height: 250px">
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <button type='button'
                                                id='rUr_<%# DataBinder.Eval(Container.DataItem, "ID") %>'
                                                title="<%# DataBinder.Eval(Container.DataItem, "IsPublicText") %>"
                                                ispublic='<%# DataBinder.Eval(Container.DataItem, "IsPublic") %>'
                                                isowner='<%# DataBinder.Eval(Container.DataItem, "IsOwner") %>'
                                                reportid='<%# DataBinder.Eval(Container.DataItem, "ID") %>'
                                                class='list-group-item list-group-item-action'>


                                                <%# DataBinder.Eval(Container.DataItem, "ReportName") %>
                                                <span class="badge badge-primary badge-pill"><%# If(Eval("IsPublic") = True, "Public", "Private") %></span>
                                                <span class="badge badge-primary badge-pill"><%# DataBinder.Eval(Container.DataItem, "FullName") %></span>

                                            </button>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            </div>
                                        </FooterTemplate>
                                    </asp:Repeater>
                                </td>
                                <td rowspan="5">
                                    <table id="tblButtons" class="table" border="0">
                                        <tr>
                                            <td>
                                                <button type="button" class="selectButton btn-block uCreate">Create New</button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <button type="button" class="selectButton btn-block uOpen">Open</button></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <button type="button" id="btnEdit" class="selectButton btn-block uEdit">Open in Edit Mode</button></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <button type="button" class="selectButton btn-block uCopy">Copy</button></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="txtSelectedReport" runat="server" Style="display: none"></asp:TextBox>
                                                <asp:Button ID="btnIsPubPriv" runat="server" CssClass="selectButton btn-block uPubPriv" Text="Make Public/Private" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <button type="button" class="selectButton btn-block uRename" data-toggle="modal" data-target="#renameReportModal">Rename</button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnDelete" runat="server" CssClass="selectButton btn-block uDelete" Text="Delete" OnClientClick="javascript:if(!confirm('Are you sure to delete?')){return false;}" />
                                            </td>
                                        </tr>

                                    </table>

                                </td>
                            </tr>

                        </tbody>
                    </table>
                </div>
            </div>
            <div><a href="../../Home/Help/DashboardHelp.aspx" target="_blank">Dashboard Documentation and Help</a></div>
        </div>
    </div>


    <!-- Modal Popup-->
    <div class="modal fade" id="renameReportModal" tabindex="-1" role="dialog" aria-labelledby="renameReportLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="renameReportLabel">Rename Report</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    </button>
                </div>
                <div class="modal-body">
                    New Report Name : 
                    <asp:TextBox ID="txtNewReportName" runat="server"></asp:TextBox>
                    <span id="sRequired" style="color: red">*</span>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button ID="btnReportRename" runat="server" OnClientClick="return fnRename();" CssClass="btn btn-primary" Text="Save" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
