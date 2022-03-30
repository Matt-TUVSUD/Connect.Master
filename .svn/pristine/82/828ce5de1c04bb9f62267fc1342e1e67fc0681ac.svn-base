<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/Grids/GridMasterPagePreferences.master" CodeBehind="FilterPreferences.aspx.vb" Inherits="GRC.Connect.Web.Grids_FilterPreferences" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>
<asp:Content ID="GridHeadContent" ContentPlaceHolderID="GridHeadContent" runat="server">
    <script src="../../../Lib_{{VER}}/Data/LocationListings.js"></script>
    <script src="../../../Lib_{{VER}}/Grids/FilterPreferences.js"></script>
    <script>
        var ServerSide_GridId = "<%=ServerSide_GridId%>";
    </script>
    <style>
        .k-dropdown-wrap {
            height:22px;
        }
       
        #landingPage .k-icon .k-i-arrow-60-down {
            font-size:12px;
        }
    </style>
</asp:Content>
<asp:Content ID="GridBodyContent" ContentPlaceHolderID="GridBodyContent" runat="server">
    <!-- LOADING -->
    <grcRSC:Loader runat="server" id="loader" />

    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>

    <div id="viewPref" class="pgBodyContent" style="align-content:center; justify-content:center;">
        <!-- CONTENT -->
        <div class="" style="max-width: 1550px; width: 100%;">
            <div id="txtMessage" style="text-align: left;">
                <label data-bind="text: txtMessage"></label>
            </div>
            <div id="topSection" style="display: flex; align-items: center; margin-bottom:10px;">
                <div class="" style="display:flex; flex-basis:60%; color:#666; flex-direction:column;">
                    <div style="display:flex;">
                        <label>Sorted:</label>&nbsp;&nbsp;&nbsp;&nbsp;<span data-bind="text: txtSortedBy" id="txtSortedBy"></span>
                    </div>
                    <div style="display:flex;">
                        <label>Filtered:</label>&nbsp;&nbsp;<span data-bind="text: txtFilteredBy" id="txtFilteredBy"></span>
                    </div>
                    <div style="display:flex;">
                        <label>Pinned:</label>&nbsp;&nbsp;&nbsp;<span data-bind="text: txtPinnedBy" id="txtPinnedBy"></span>
                    </div>
                    <div style="display:flex;">
                        <label>Records:</label>&nbsp;&nbsp;<span data-bind="text: txtTotalRecords" id="txtTotalRecords"></span>
                    </div>
                </div>
                <!-- DIVIDER SPACE BETWEEN GRID AND BOXES -->
                <div style="display:flex; flex-basis:40%;">
                    <div class="prefBox">
                        <div style="margin-bottom:5px">
                            <span>
                                <label style="font-weight: bold;">Settings:</label>
                            </span>
                        </div>
                        <div style="margin-bottom:5px; display:flex; justify-content:space-between;">
                            <span style="">
                                <label>Convert Currency</label>
                            </span>
                            <span>
                                <telerik:RadComboBox ID="cboConvertCurrency" runat="server" Width="150px" TabIndex="1" EnableScreenBoundaryDetection="False" Filter="Contains" MaxHeight="200px"></telerik:RadComboBox>
                            </span>
                        </div>
                        <div style="margin-bottom:5px; display:flex; justify-content:space-between;">
                            <span style="">
                                <label>Convert Units</label></span>
                            <span>
                                <telerik:RadComboBox ID="cboConvertUnits" runat="server" Width="150px" TabIndex="1" EnableScreenBoundaryDetection="False" Filter="Contains" MaxHeight="200px"></telerik:RadComboBox>
                            </span>
                        </div>
                         <div style="display:flex; justify-content:space-between;">
                            <span style="">
                                <label>Landing Page</label>
                            </span>
                            <span id="landingPage">
                                <input ID="landingPageDD" style="width:150px; font-size:12px;"/>
                            </span>
                        </div>
                    </div>
                    <div class="prefBox noRightMargin">
                        <div style="display:flex; flex-direction:row; justify-content:space-around; margin-bottom:10px;">
                            <span style="display: none;">
                                <asp:Button ID="btnClosePreferences" ClientIDMode="Static" runat="server" />
                            </span>
                            <span style="margin-right:5px;">
                                <button id="btnClearAll" class="grcNeutralBtn" style="" data-bind="click: clearMyPreference">Reset Grid</button>
                            </span>
                            <span>
                                <button id="btnConnect" class="grcBlueBtn" style="" data-bind="click: applyMyPreference">Save</button>
                            </span>
                        </div>
                        <div class="" style="display:flex; align-items:center;">
                            <span style="font-size: 25px; margin-right:3px;">
                                <i class="far fa-info-circle"></i>
                            </span>
                            <span>Your saved preferences will be applied to all future login sessions.
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <!-- THE GRID -->
            <div id="gridPrefContainer">
                <div id="gridPref"></div>
            </div>
        </div>

        <!-- FOOTER -->
        <div style="padding-right: 25px;">
            <!-- DIVIDER SPACE BETWEEN GRID AND BOXES -->
            <!-- CONFIRMATION WINDOW -->
            <div id="windowPreferenceConfirm" class="windowContent">
                <div>
                    <label id="lblWindowPreferenceMessage" style="text-align:center;">Your preferences have been saved.</label>
                    <div style="display:flex; justify-content:center; margin-top:10px;">
                        <button class="grcNeutralBtn" id="btnPreferenceConfirmHide" data-bind="click: onPreferenceConfirmHide">Close</button>
                    </div>
                </div>
            </div>
        </div>

        

        <!-- HIDDEN DOMS -->
        <div id="windowPicklistPref" class="pickListWindow" style="display: none;">
            <div class="pickListHeader"><label>Check the items to show.</label></div>
            <div class="pickListContent">
                <div id="windowPicklistPref_Loading" class="pickListLoading"> <!-- MUST USE Name_Loading NAMING FORMAT FOR ID -->
                    <img src="../../Images/loading/loading_2x.gif" class="pickListLoadingImage" />
                </div>
                <div id="windowPicklistPref_Table" class="pickListTable"></div> <!-- MUST USE Name_Table NAMING FORMAT FOR ID -->
            </div>
            <div class="pickListFooter">
                <button class="k-button pickListButton" data-bind="click: pickListCheckAll">All</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                <div style="height: 4px;">&nbsp;</div>
                <button class="k-button pickListButton" data-bind="click: pickListApplyFilter">Apply</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCancel">Cancel</button>
            </div>
        </div>

    </div>

    <script>
        var gCboConvertCurrencyId = "<%= cboConvertCurrency.ClientID %>";
        var gCboConvertUnitsId = "<%= cboConvertUnits.ClientID %>";
    </script>
</asp:Content>

