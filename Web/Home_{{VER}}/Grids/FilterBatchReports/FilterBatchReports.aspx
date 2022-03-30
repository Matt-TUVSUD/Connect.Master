<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/Grids/GridMasterPagePreferences.master" CodeBehind="FilterBatchReports.aspx.vb" Inherits="GRC.Connect.Web.Grids_FilterBatchReports" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="GridHeadContent" ContentPlaceHolderID="GridHeadContent" runat="server">
    <script src="../../../Lib_{{VER}}/Data/LocationListings.js"></script>
    <script src="../../../Lib_{{VER}}/Grids/FilterBatchReports.js"></script>
    <script>
        var ServerSide_GridId = "<%=ServerSide_GridId%>";
    </script>
</asp:Content>
<asp:Content ID="GridBodyContent" ContentPlaceHolderID="GridBodyContent" runat="server">

    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>

     <!-- LOADING -->
    <grcRSC:Loader runat="server" id="loader" />

    <div id="viewBatch" class="pgBodyContent" style="justify-content:center; align-items:center;">
        <!-- CONTENT -->
        <div class="" style="max-width: 1550px; width: 100%;">
            <div id="txtMessage" style="text-align: left;">
                <label data-bind="text: txtMessage"></label>
            </div>
            <div style="display: flex; align-items: center; margin-bottom:10px;">
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
                        <div style="display:flex; justify-content:space-between;">
                            <span style="">
                                <label>Convert Units</label></span>
                            <span>
                                <telerik:RadComboBox ID="cboConvertUnits" runat="server" Width="150px" TabIndex="1" EnableScreenBoundaryDetection="False" Filter="Contains" MaxHeight="200px"></telerik:RadComboBox>
                            </span>
                        </div>
                    </div>
                    <div class="prefBox noRightMargin">
                        <div class="" style="display: flex; flex-direction: column; justify-content: space-around;">
                            <span style="display: flex; flex-direction: row; font-size:14px; align-items:center; margin-bottom:17px;">
                                <asp:Label ID="lblNameOfReport" runat="server" Width="90px" Text="Report name:"></asp:Label>
                                <asp:TextBox ID="txtNameOfReport" ClientIDMode="Static" runat="server" Width="195px" style="background:#fff; font-size:12px; overflow:hidden;" CssClass="k-autocomplete k-input noEditPadding"></asp:TextBox>
                            </span>
                            <span style="display: none;">
                                <asp:Button ID="btnCloseBatchReport" ClientIDMode="Static" runat="server" />&nbsp;&nbsp;&nbsp;</span>
                            <span style="display: none;">
                                <asp:Button ID="btnCancelBatchReport" ClientIDMode="Static" runat="server" />&nbsp;&nbsp;&nbsp;</span>
                            <div style="display: flex; flex-direction: row; align-items:center; justify-content:space-between;">
                                <button id="btnCreateReport" class="grcBlueBtn" style="margin-right:5px;" data-bind="click: createBatchReport">Create Report</button>
                                <button id="btnCancel" class="grcNeutralBtn" style="width: 75px;" data-bind="click: cancelBatchReport">Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- THE GRID -->
            <div id="gridBatchContainer">
                <div id="gridBatch"></div>
            </div>
        </div>
        
        <!-- FOOTER -->
        <div style="padding-right: 25px;">
            <!-- DIVIDER SPACE BETWEEN GRID AND BOXES -->

            <!-- CONFIRMATION WINDOW -->
            <div id="windowBatchConfirm" class="windowContent">
                <div><img src="../../Images/icons/reports/mail_attachment_32x32.png" align="left" style="width: 32px; height: 32px; padding-right: 12px; padding-bottom: 110px; vertical-align: text-top;" alt="TUV SUD GRC Client Connect - Batch Reports Email" /></div>
                <div style="width:100%; margin-bottom:5px;">
                    Your report is being processed and you will receive email confirmation with a link to the reports when the report is available.
                </div>
                <div style="width:100%; margin-bottom:5px;">
                    Once the report has been processed, it will also be available by returning to the Batch Reports page.
                </div>
                <div style="justify-content: center; width: 100%; display: flex;">
                    <button class="grcBlueBtn" id="btnPreferenceConfirmHide" data-bind="click: onBatchReportConfirmHide">Continue</button>
                </div>
            </div>
        </div>

        

        <!-- HIDDEN DOMS -->
        <div id="windowPicklistBatch" class="pickListWindow" style="display: none;">
            <div class="pickListHeader"><label>Check the items to show.</label></div>
            <div class="pickListContent">
                <div id="windowPicklistBatch_Loading" class="pickListLoading"> <!-- MUST USE Name_Loading NAMING FORMAT FOR ID -->
                    <img src="../../Images/loading/loading_2x.gif" class="pickListLoadingImage" />
                </div>
                <div id="windowPicklistBatch_Table" class="pickListTable"></div> <!-- MUST USE Name_Table NAMING FORMAT FOR ID -->
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
        var gTxtNameOfReport = "<%= txtNameOfReport.ClientID%>";
    </script>
</asp:Content>

