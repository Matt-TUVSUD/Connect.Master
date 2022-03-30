<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServerNoLinks.Master" CodeBehind="SwitchIntegrated.aspx.vb" Inherits="GRC.Connect.Web.SwitchIntegrated" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/switch.css" />
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
    <div>
        <div id="divMainListContainer" runat="server">
            <div class="switch_TabContainer">
                <div style="float: left;"><img src="../Images/Home_{{VER}}/logo_english_clientconnect.png" alt="Global Risk Consultants" style="width: 450px; border: none;" /></div>
                <div style="float: right;">
                    <div class="switch_Title"><asp:Label ID="lblSwitchTitle" runat="server" Text="Client Database Selection">Client Database Selection</asp:Label></div>
                    <div class="switch_TopBannerTabActive" id="divTabClientByName" onclick="onShowClientsByName()" style="clear: both;">By Name</div>
                    <div class="switch_TopBannerTabInactive" id="divTabClientByFilePrefix" onclick="onShowClientsByFilePrefix()">By FilePrefix</div></div>
            </div>
            <!-- CONTAINER FOR LIST BY NAME -->
            <div class="switch_CellContainerOutside">
                <div id="divClientsHideContainerName">
                    <div class="switch_CellContainer" id="divSwitchCellContainerName" runat="server">
                        <div class="switch_Cell switch_CellLeft" id="divSwitchColumn1" runat="server">
                            <asp:Repeater ID="rptSwitchCol1" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("Clientname") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellMiddle" id="divSwitchColumn2" runat="server">
                            <asp:Repeater ID="rptSwitchCol2" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("Clientname") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellMiddle" id="divSwitchColumn3" runat="server">
                            <asp:Repeater ID="rptSwitchCol3" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("Clientname") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellMiddle" id="divSwitchColumn4" runat="server">
                            <asp:Repeater ID="rptSwitchCol4" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("Clientname") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellRight" id="divSwitchColumn5" runat="server">
                            <asp:Repeater ID="rptSwitchCol5" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("Clientname") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                    </div>
                </div>

                <!-- CONTAINER FOR LIST BY FILE PREFIX -->
                <div id="divClientsHideContainerFilePrefix" style="display: none;">
                    <div class="switch_CellContainer" id="divSwitchCellContainerFilePrefix" runat="server">
                        <div class="switch_Cell switch_CellLeft" id="divSwitchFilePrefixColumn1" runat="server">
                            <asp:Repeater ID="rptSwitchFilePrefixCol1" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("FilePrefixAndName") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellMiddle" id="divSwitchFilePrefixColumn2" runat="server">
                            <asp:Repeater ID="rptSwitchFilePrefixCol2" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("FilePrefixAndName") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellMiddle" id="divSwitchFilePrefixColumn3" runat="server">
                            <asp:Repeater ID="rptSwitchFilePrefixCol3" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("FilePrefixAndName") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellMiddle" id="divSwitchFilePrefixColumn4" runat="server">
                            <asp:Repeater ID="rptSwitchFilePrefixCol4" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("FilePrefixAndName") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                        <div class="switch_Cell switch_CellRight" id="divSwitchFilePrefixColumn5" runat="server">
                            <asp:Repeater ID="rptSwitchFilePrefixCol5" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkClient" runat="server" Text='<%# Eval("FilePrefixAndName") %>'></asp:LinkButton>
                                    <asp:HiddenField ID='hidCLDBName' Value='<%# Eval("Cldbname") %>' runat="server" />
                                </ItemTemplate>
                                <SeparatorTemplate>
                                    <br />
                                </SeparatorTemplate>
                            </asp:Repeater>&nbsp;
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <!-- USERNAME AND EMAIL INFO - NOT DISPLAYED BUT POPULATED SERVER SIDE -->
        <div style="display: none;">
            Welcome: <asp:TextBox ID="txtWelcome" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="275px" Height="24px"></asp:TextBox>
            <br />
            Email Address: <asp:TextBox ID="txtEmail" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="275px" Height="24px"></asp:TextBox>
        </div>

        <!-- LOGO AND SIDE GRAPHIC FOR 04 ADMIN USER ONLY -->
        <div runat="server" id="divSecondaryLogo"><img src="../Images/Home_{{VER}}/logo_english_clientconnect.png" alt="Global Risk Consultants" style="width: 450px; border: none;" /></div>
        <br style="clear: both;" />
        <div runat="server" id="divSideGraphic" style="float: left;"><img src="../Images/fire/navbackground.png" alt="Global Risk Consultants Graphic" style="height: 360px; width: 176px;" /></div>

        <!-- DROPDOWN COMBO BOXES -->
        <div class="divTable" runat="server" id="divComboContainer" style="width:auto; padding-top:8px;">
            <div class="switch_TitleSecondary" id="divSecondaryTitle" runat="server">Please Select A Client</div>
            <!-- EXTRA PADDING FOR 04 USERS FOR COMBO BOX DROPPING UP INSTEAD OF DOWN, NEED MORE ROOM -->
            <div runat="server" id="divSecondaryExtraPadding">
                <br />&nbsp;<br />
                <br />&nbsp;<br />
                <br />&nbsp;<br />
            </div>
            <div class="switch_InstructionsSecondary" id="divSecondaryInstructions" runat="server">
                <br />&nbsp;<br />To access client data, choose from one of the drop-down menus below, by Client Name or File Prefix.<br />&nbsp;<br />&nbsp;<br />
            </div>
            <div style="text-align: center;">
                <span style="width: 155px; line-height: normal; font-weight: bold;">Client Selection By Name: &nbsp;</span>
                <span style="width: 280px;">
                    <telerik:RadComboBox ID="cboClientByName" Runat="server" 
                        Width="275px" TabIndex="2" EnableScreenBoundaryDetection="False" 
                        Filter="Contains" MaxHeight="200px" 
                        onclientselectedindexchanged="onSelectName" ExpandDirection="Up" OnClientKeyPressing="onKeyPress">
                    </telerik:RadComboBox>
                </span>
                <span style="width: 25px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                <span style="width: 155px; line-height: normal; font-weight: bold;">Client Selection By File Prefix: &nbsp;</span>
                <span style="width: 280px;">
                    <telerik:RadComboBox ID="cboClientByFilePrefix" Runat="server" 
                        Width="275px" TabIndex="2" EnableScreenBoundaryDetection="False" 
                        Filter="Contains" MaxHeight="200px" 
                        onclientselectedindexchanged="onSelectFilePrefix" ExpandDirection="Up" OnClientKeyPressing="onKeyPress">
                    </telerik:RadComboBox>
                </span>
                <span id="divSecondaryEnterButton" runat="server" style="padding-left: 50px;">
                    <asp:Button ID="btnSkip" CssClass="k-button k-button-padding" Width="150px" runat="server" Text="Connect Now" />
                </span>
            </div>

            <div class="switch_NoticeSecondary" id="divSecondaryNotice" runat="server">
                <br />
                CONFIDENTIALITY NOTICE: By entering this client database system, you understand and agree that you will not share your access nor any information unless authorized by your management, as this site contains confidential client information.
            </div>

            <div id="divThirdEnterButtons" runat="server" style="text-align: center;">
                <br />
                <asp:Button ID="btnSkip2" CssClass="k-button k-button-padding" Width="150px" runat="server" Text="Connect Now" />
                <span runat="server" id="spnButtonSpace">&nbsp;&nbsp; - or - &nbsp;&nbsp;</span>
                <asp:Button ID="btnNext" CssClass="k-button k-button-padding" Width="150px" runat="server" Text="Edit myPreferences" />
            </div>

            <div class="messageError" style="text-align: center; padding-top: 4px;">
                <asp:Label ID="lblMessage" runat="server"></asp:Label><br />&nbsp;<br />
            </div>
                       
        </div>

        <!-- ADMIN LINKS -->
        <div id="divPreferences" style="float: left; text-align: left; line-height: 18px; position: relative;" runat="server">
            <span style="display: none;"><asp:CheckBox ID="chkEditPreferences" Checked="false" runat="server" /> Check here to edit preferences when logging in by clicking a link in the database list.</span>
            <asp:HyperLink runat="server" ID="hypChangePassword">Click here to change Display Name or Password</asp:HyperLink>
            <br />
        </div>
        
        <div id="divLinks" style="float: right; text-align: right; padding-right: 50px; font-weight: bold;" runat="server">
            <asp:HyperLink runat="server" ID="hypGRCConnectTest">GRCConnect Test</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink runat="server" ID="hypGRCConnectLive">GRCConnect Live</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:HyperLink runat="server" ID="hypSystemTools">System Tools</asp:HyperLink>
        </div>

    </div>

    <script type="text/javascript">
        var killSwitch = false;

        function onSelectName(sender, args) {
            if (!killSwitch) {
                killSwitch = true;
                var cboClientByName = $find("<%= cboClientByName.ClientID %>");
                var cboClientByFilePrefix = $find("<%= cboClientByFilePrefix.ClientID %>");
                cboClientByFilePrefix.trackChanges();
                cboClientByFilePrefix.clearSelection();
                var selectedItem = cboClientByFilePrefix.findItemByValue(cboClientByName.get_value());
                selectedItem.select();
                cboClientByFilePrefix.commitChanges();

            } else {
                killSwitch = false;
            }
        }

        function onSelectFilePrefix(sender, args) {
            if (!killSwitch) {
                killSwitch = true;
                var cboClientByName = $find("<%= cboClientByName.ClientID %>");
                var cboClientByFilePrefix = $find("<%= cboClientByFilePrefix.ClientID %>");
                cboClientByName.trackChanges();
                cboClientByName.clearSelection();
                var selectedItem = cboClientByName.findItemByValue(cboClientByFilePrefix.get_value());
                selectedItem.select();
                cboClientByName.commitChanges();

            } else {
                killSwitch = false;
            }
        }

        function onKeyPress(sender, args) {
            if (args._domEvent.keyCode == 13) {
                var btnSkip = $("#<%= btnSkip.ClientID %>");
                btnSkip.click();
            }
        }

        //// SHOW THE LIST BY FILE PREFIX
        function onShowClientsByFilePrefix() {
            $("#divClientsHideContainerName").fadeOut(function(){
                $("#divClientsHideContainerFilePrefix").fadeIn();
            });
            $("#divTabClientByName").removeClass("switch_TopBannerTabActive");
            $("#divTabClientByName").addClass("switch_TopBannerTabInactive");
            $("#divTabClientByFilePrefix").removeClass("switch_TopBannerTabInactive");
            $("#divTabClientByFilePrefix").addClass("switch_TopBannerTabActive");
        }

        //// SHOW THE LIST BY CLIENT NAME
        function onShowClientsByName() {
            $("#divClientsHideContainerFilePrefix").fadeOut(function() {
                $("#divClientsHideContainerName").fadeIn();
            });
            $("#divTabClientByFilePrefix").removeClass("switch_TopBannerTabActive");
            $("#divTabClientByFilePrefix").addClass("switch_TopBannerTabInactive");
            $("#divTabClientByName").removeClass("switch_TopBannerTabInactive");
            $("#divTabClientByName").addClass("switch_TopBannerTabActive");
        }
    </script>

</asp:Content>
