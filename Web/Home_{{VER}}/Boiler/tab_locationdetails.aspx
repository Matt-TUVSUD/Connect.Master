<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="tab_locationdetails.aspx.vb" Inherits="GRC.Connect.Web.tab_locationdetails_boiler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/locationdetails.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationInspectionBM.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingBM.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationInspectionBM.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingBM.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria_LocationDetails" data-bind="with: viewFindCriteria_LocationDetails">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
    <div id="view_LocationDetails" data-bind="with: view_LocationDetails">
    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
            <span class="companyLabels2"><label data-bind="text: $parent.objLanguageLabels().lblClientLocNo, css: { findOn: $parent.objFind().findClientLocNo, findOff: !$parent.objFind().findClientLocNo }">Client Loc. No.</label></span>
            <span class="companyInputs2"><input data-bind="value: $parent.objListing().ClientLocNo, css: { findOnInput: $parent.objFind().findClientLocNo, findOffInput: !$parent.objFind().findClientLocNo }" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
            <span class="companyLabels5"><label data-bind="text: $parent.objLanguageLabels().lblLatitude, css: { findOn: $parent.objFind().findLatitude, findOff: !$parent.objFind().findLatitude }">Latitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Latitude, css: { findOnInput: $parent.objFind().findLatitude, findOffInput: !$parent.objFind().findLatitude }" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
            <span class="companyLabels4"><label data-bind="text: $parent.objLanguageLabels().lblLongitude, css: { findOn: $parent.objFind().findLongitude, findOff: !$parent.objFind().findLongitude }">Longitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Longitude, css: { findOnInput: $parent.objFind().findLongitude, findOffInput: !$parent.objFind().findLongitude }" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblAddress1, css: { findOn: $parent.objFind().findAddress1, findOff: !$parent.objFind().findAddress1 }">Address</label></span>
            <span class="companyInputs6"><input data-bind="value: $parent.objListing().Address1, css: { findOnInput: $parent.objFind().findAddress1, findOffInput: !$parent.objFind().findAddress1 }" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblDivisionName, css: { findOn: $parent.objFind().findDivision, findOff: !$parent.objFind().findDivision }">Division Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Division, css: { findOnInput: $parent.objFind().findDivision, findOffInput: !$parent.objFind().findDivision }" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblCity, css: { findOn: $parent.objFind().findCity, findOff: !$parent.objFind().findCity }">City</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().City, css: { findOnInput: $parent.objFind().findCity, findOffInput: !$parent.objFind().findCity }" id="City" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="7"  /></span>
            <span class="stateLabels"><label data-bind="text: $parent.objLanguageLabels().lblState, css: { findOn: $parent.objFind().findStProv, findOff: !$parent.objFind().findStProv }">State</label></span>
            <span class="stateInputs"><input data-bind="value: $parent.objListing().StProv, css: { findOnInput: $parent.objFind().findStProv, findOffInput: !$parent.objFind().findStProv }" id="StProv" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8"  /></span>
            <span class="countryLabels"><label data-bind="text: $parent.objLanguageLabels().lblCountry, css: { findOn: $parent.objFind().findCountry, findOff: !$parent.objFind().findCountry }">Country</label></span>
            <span class="countryInputs"><input data-bind="value: $parent.objListing().Country, css: { findOnInput: $parent.objFind().findCountry, findOffInput: !$parent.objFind().findCountry }" id="Country" class="k-autocomplete k-input inputNoEdit inputLeft countryInputs" tabindex="9"  /></span>
            <span class="postalLabels"><label data-bind="text: $parent.objLanguageLabels().lblPostalCode, css: { findOn: $parent.objFind().findZip, findOff: !$parent.objFind().findZip }">Postal</label></span>
            <span class="postalInputs"><input data-bind="value: $parent.objListing().Zip, css: { findOnInput: $parent.objFind().findZip, findOffInput: !$parent.objFind().findZip }" id="Zip" class="k-autocomplete k-input inputNoEdit inputLeft postalInputs" tabindex="10"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblFacilityName, css: { findOn: $parent.objFind().findFacility, findOff: !$parent.objFind().findFacility }">Facility Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Facility, css: { findOnInput: $parent.objFind().findFacility, findOffInput: !$parent.objFind().findFacility }" id="Facility" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="11"  /></span>
        </div>
        <div class="tabRow">
            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels1"></span>
            <span class="buttonContainerLocationLoading" style="display:flex;">
                <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFileFirst" tabindex="15" style="margin-right:2px;"><i class="fas fa-step-backward"></i></button></span>
                <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFilePrevious" tabindex="16"><i class="fas fa-caret-left"></i></button></span>
                <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="    value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileNext" tabindex="17" style="margin-right:2px;"><i class="fas fa-caret-right"></i></button></span>
                <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileLast" tabindex="18"><i class="fas fa-step-forward"></i></button></span>
                <span>&nbsp;</span>
                <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="grcBlueBtn findBtn hidden" tabindex="13">Clear Find</button></span>
                <span><button data-bind="click: $parent.onFind" class="grcBlueBtn findBtn" type="submit" tabindex="14">Find</button></span>
            </span>
            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
        </div>
    </div>
    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

    <!-- TABLE FOR LOCATIONS LISTING INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->

    <div>
        <div class="tabBannerHeader" style="margin-bottom:5px;">
            <label style="flex-basis:258px; text-align:center;">Document Links</label>
            <label style="flex-basis:223px; text-align:center;">Scheduling</label>
            <label style="flex-basis:331px; text-align:center;">Location Values</label>
        </div>
    </div>
    <div class="tableDivAutoBordersGray">
    <div class="tableDiv">
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblDateCurrentER">Date of Current ER</label></span>
            <span class="documentsInputs"><input data-bind="" id="BMActualDate" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit documentsInputs" readonly="true" /></span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblInspectionType">Inspection Type</label></span>  
            <span class="schedulingInputs"><input data-bind="value: $parent.objInspection().InspectionType" id="PracticeCode" class="k-autocomplete k-input inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblEffectiveDate">Effective Date</label></span>
            <span class="locationsInputs1"><input data-bind="" id="EffectiveDate" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblCurrencyCode">Currency Code</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().CurrencyCode" id="CurrencyCode" class="k-autocomplete k-input inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblDateMailedClient">Date Mailed to Client</label></span>
            <span class="documentsInputs"><input data-bind="" id="BMEmailedDate" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit documentsInputs" readonly="true" /></span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblFrequency">Frequency</label></span>  
            <span class="schedulingInputs"><input data-bind="value: $parent.objInspection().Frequency" id="Frequency" class="k-autocomplete k-input inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1">&nbsp;</span>
            <span class="locationsInputs1">&nbsp;</span>
            <span class="locationsLabels2">&nbsp;</span>  
            <span class="locationsInputs1">&nbsp;</span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblLinkCurrentER">Link to Current ER</label></span>
            <span class="documentsInputs">
                <span class="k-widget k-autocomplete k-header k-input inputCenter inputNoEdit inputLink documentsInputs" style="line-height: normal;" id="lblToReportClickHere">
                    <label class="linkPointer" data-bind="visible: $parent.objListing().ToBMReport, text: $parent.objLanguageLabels().lblClickHere, click: function (data) { $parent.onBuildLink($parent.objListing().ToBMReport()) }"></label>
                </span>
            </span>           
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblNextInspectionYear">Next Insp. Year</label></span>  
            <span class="schedulingInputs"><input data-bind="value: $parent.objInspection().NextInspYr" id="NextInspYr" class="k-autocomplete k-input inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1">&nbsp;</span>
            <span class="locationsInputs1"><label data-bind="text: $parent.objLanguageLabels().lblInMillions">(In Millions)</label></span>
            <span class="locationsLabels2">&nbsp;</span>  
            <span class="locationsInputs1"><label data-bind="text: $parent.objLanguageLabels().lblInMillions">(In Millions)</label></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblLinkLatestURLE">Link to Latest UR or LE</label></span> 
            <span class="documentsInputs">
                <span class="k-widget k-autocomplete k-header k-input inputCenter inputNoEdit inputLink documentsInputs" style="line-height: normal;" id="lblToReport2ClickHere">
                    <label class="linkPointer" data-bind="visible: $parent.objListing().ToBMReport2, text: $parent.objLanguageLabels().lblClickHere, click: function (data) { $parent.onBuildLink($parent.objListing().ToBMReport2()) }"></label>
                </span>
            </span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblInspectionTarget">Inspection Target</label></span>  
            <span class="schedulingInputs"><input data-bind="" id="EngTargetMo" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblBuilding">Building</label></span>
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().PDBuilding" id="PDBuilding" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblGrossProfit">Gross Profit</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().BIGrossProfit" id="BIGrossProfit" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblLinkLatestDiagram">Link to Latest Diagram</label></span>
            <span class="documentsInputs">
                <span class="k-widget k-autocomplete k-header k-input inputCenter inputNoEdit inputLink documentsInputs" style="line-height: normal;" id="lblToDiagramClickHere">
                    <label class="linkPointer" data-bind="visible: $parent.objListing().ToBMDiagram, text: $parent.objLanguageLabels().lblClickHere, click: function (data) { $parent.onBuildLink($parent.objListing().ToBMDiagram()) }"></label>
                </span>
            </span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblStatus">Status</label></span>  
            <span class="schedulingInputs"><input data-bind="value: $parent.objInspection().InspectionStatus" id="InspectionStatus" class="k-autocomplete k-input inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblEquipment">Equipment</label></span>
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().PDEquipment" id="PDEquipment" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblWageEE">Wage / EE</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().BIWageExtraExp" id="BIWageExtraExp" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels">&nbsp;</span>
            <span class="documentsInputs">&nbsp;</span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblDateCancelled">Date Cancelled</label></span>  
            <span class="schedulingInputs"><input data-bind="" id="CancelDate" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblInventory">Inventory</label></span>
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().PDFinished" id="PDFinished" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblMisc1">Misc.</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().BIMisc" id="BIMisc" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblDatePreviousER">Date of Previous ER</label></span>
            <span class="documentsInputs"><input data-bind="" id="BMLastInspectionDate" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit documentsInputs" readonly="true" /></span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblDateCompleted">Date Completed</label></span>  
            <span class="schedulingInputs"><input data-bind="" id="DateCompleted" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblRawStock">Raw Stock</label></span>
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().PDRawStock" id="PDRawStock" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblOther">Other</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().BIOther" id="BIOther" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblLinkPreviousER">Link to Previous ER</label></span>
            <span class="documentsInputs">
                <span class="k-widget k-autocomplete k-header k-input inputCenter inputNoEdit inputLink documentsInputs" style="line-height: normal;" id="lblLastInspectionReportClickHere">
                    <label class="linkPointer" data-bind="visible: $parent.objListing().BMLastInspectionReport, text: $parent.objLanguageLabels().lblClickHere, click: function (data) { $parent.onBuildLink($parent.objListing().BMLastInspectionReport()) }"></label>
                </span>
            </span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblDateMailedClientShort">Date Mailed</label></span>  
            <span class="schedulingInputs"><input data-bind="" id="DateMailedToClient" class="k-autocomplete k-numerictextbox inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblBuildersRisk">Builder's Risk</label></span>
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().PDBuildersRisk" id="PDBuildersRisk" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true"  /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblBITotal">BI Total</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().BITotal" id="BITotal" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels">&nbsp;</span>
            <span class="documentsInputs">&nbsp;</span>
            <span class="borderRightGray"></span>
            <span class="schedulingLabels"><label data-bind="text: $parent.objLanguageLabels().lblEngineer">Engineer</label></span>  
            <span class="schedulingInputs"><input data-bind="value: $parent.objInspection().Engineer" id="Engineer" class="k-autocomplete k-input inputCenter inputNoEdit schedulingInputs" readonly="true" /></span>  
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblMisc2">Misc.</label></span>
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().PDMisc" id="PDMisc" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true"  /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblLocalTIV">Local TIV</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().LocalTIV" id="LocalTIV" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true"  /></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft12"></span>
            <span class="documentsLabels">&nbsp;</span>
            <span class="documentsInputs">&nbsp;</span>
            <span class="borderRightGray"></span>
            <span class="buttonCell">
                <div class="buttonContainer" style="display:flex;">
                    <span><button data-bind="click: $parent.onFirst, enable: $parent.enablePrev" class="grcBlueBtn pagerBtn" id="btnFirst" style="margin-right:2px;"><i class="fas fa-step-backward"></i></button></span>
                    <span><button data-bind="click: $parent.onPrevious, enable: $parent.enablePrev" class="grcBlueBtn pagerBtn" id="btnPrevious"><i class="fas fa-caret-left"></i></button></span>
                    <span class="buttonRecordLabel">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblRecord">Record</label> <input data-bind="    value: $parent.txtRecordNumber" id="txtRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                    <span><button data-bind="click: $parent.onNext, enable: $parent.enableNext" class="grcBlueBtn pagerBtn" id="btnNext" style="margin-right:2px;"><i class="fas fa-caret-right"></i></button></span>
                    <span><button data-bind="click: $parent.onLast, enable: $parent.enableNext" class="grcBlueBtn pagerBtn" id="btnLast"><i class="fas fa-step-forward"></i></button></span>
                </div>
            </span> 
            <span class="borderRightGray"></span>
            <span class="locationsLabels1"><label data-bind="text: $parent.objLanguageLabels().lblPDTotals">PD Totals</label></span>
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().PDTotal" id="PDTotal" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true"  /></span>
            <span class="locationsLabels2"><label data-bind="text: $parent.objLanguageLabels().lblUSTIV">US TIV</label></span>  
            <span class="locationsInputs1"><input data-bind="value: $parent.objInspection().Percentustot100" id="Percentustot100" class="k-numerictextbox inputCenter inputNoEdit locationsInputs1" readonly="true" /></span>
            <span class="bufferRight"></span>
        </div>
    </div>
    </div>
    <!-- END TABLE FOR LOCATIONS LISTING INFORMATION -->

    <!-- AREA FOR NO ACTIVE LOCATION PER PRACTICE MESSAGE -->
    <div style="height: 19px; padding-top: 6px; text-align: center;">
        <label id="lblNoActiveLocation" data-bind="text: $parent.messageNoActiveLocation" class="messageError"></label>&nbsp;
    </div>

    <!-- TABLE FOR SCHEDULING COMMENTS -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div class="ui-helper-clearfix">
            <span class="schedulingCommentsLabels"><label data-bind="text: $parent.objLanguageLabels().lblSchedulingComments">Scheduling Comments</label>:</span>
        </div>
        <div>
            <span class="schedulingCommentsInputs">
                <textarea data-bind="value: $parent.objListing().SchedulingComment" id="txtSchedulingComments" class="k-textbox inputNoEdit schedulingCommentsInputs" rows="3" cols="20" readonly="readonly" ></textarea>
            </span>
        </div>
        <div>
            <span>&nbsp;</span>
        </div>
    </div>
    <!-- END TABLE FOR SCHEDULING COMMENTS -->

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="padding-top: 20px;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="    text: $parent.messageNotice"></label><label class="messageWarning" data-bind="    text: $parent.messageWarning"></label>&nbsp;</div>

    <style>
        .k-window-title {
            font-size:16px;
        }
    </style>

    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
    <div id="windowNoLocation" class="windowContent" style="font-size:13px;">
        <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
        <div style="margin-bottom:5px;">
            <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There is no Location Detail record found for this file number.</label>
        </div>
        <div style="margin-bottom:5px;">
            <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label>
        </div>
        <div style="display:flex; width:100%; justify-content: center;">
            <button class="grcBlueBtn" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button>
        </div>
    </div>

</div>
<script type="text/javascript">
    $(document).ready(function () {
        ///////////////////////////////////////////
        //// LOAD SESSION VARIABLES
        var dsLanguageLabels = {
            //// COMPANY INFORMATION
            lblGRCLocNo: "GRC Loc. No.",
            lblClientLocNo: "Client Loc. No.",
            lblAddress1: "Address",
            lblCity: "City",
            lblState: "State",
            lblPostalCode: "Postal",
            lblCountry: "Country",
            lblLatitude: "Latitude",
            lblLongitude: "Longitude",
            lblDivisionName: "Division Name",
            lblFacilityName: "Facility Name",
            lblCustomerAccess: "Custom Access",

            //// DOCUMENTS
            lblDateCurrentER: "Date of Current ER",
            lblDateMailedClient: "Date Mailed to Client",
            lblDateMailedClientShort: "Date Mailed",
            lblLinkCurrentER: "Link to Current ER",
            lblLinkLatestURLE: "Link to Latest UR or LE",
            lblLinkLatestDiagram: "Link to Latest Diagram",
            lblDatePreviousER: "Date of Previous ER",
            lblLinkPreviousER: "Link to Previous ER",

            //// INSPECTION
            lblInspectionType: "Inspection Type",
            lblFrequency: "Frequency",
            lblInspectionTarget: "Inspection Target",
            lblStatus: "Status",
            lblDateCancelled: "Date Cancelled",
            lblDateCompleted: "Date Completed",
            lblEngineer: "Engineer",
            lblNextInspectionYear: "Next Insp. Year",

            //// LOCATION COLUMN 1
            lblEffectiveDate: "Effective Date",
            lblBuilding: "Building",
            lblEquipment: "Equipment",
            lblInventory: "Inventory",
            lblRawStock: "Raw Stock",
            lblBuildersRisk: "Builder's Risk",
            lblMisc1: "Misc.",
            lblPDTotals: "PD Totals",

            //// LOCATION COLUMN 2
            lblCurrencyCode: "Currency Code",
            lblGrossProfit: "Gross Profit",
            lblWageEE: "Wage / EE",
            lblMisc2: "Misc.",
            lblOther: "Other",
            lblBITotal: "BI Total",
            lblLocalTIV: "Local TIV",
            lblUSTIV: "US TIV",

            //// ADMINISTRATION WINDOW
            //            lblWindowAdminTitle: "Administration Window",
            //            lblWindowLoadCOPEInfo: "Load C.O.P.E. Info",
            //            lblWindowLoadNatHazDataInfo: "Load NatHaz Data Info",
            //            lblWindowLoadNatHazModelData: "Load NatHaz Model Data",
            //            lblWindowLoadRecInfo: "Load Rec. Info",
            //            lblWindowLoadRatingInfo: "Load Rating Info",
            //            lblWindowLoadRetailInfo: "Load Retail Info",
            //            lblImport: "Import",
            //            lblSelectAll: "Select All ",
            //            lblSelectNone: "Select None",
            //            lblNoCheckboxesSelected: "Please select at least one import type in the checkboxes above to enable the import button.",
            //            lblIncorrectFileFormat: "The file you are uploading is an invalid file type.  Please try again.",
            //            lblUploadProgress: "Upload Progress",
            //            lblDefaultImportSuccess: "",
            //            lblDefaultImportError: "",
            //            lblContinue: "Continue",
            //            lblCancel: "Cancel",
            //            lblClose: "Close",
            //            lblLoading: "Loading, please wait...",

            //// MISC
            lblInMillions: "(In Millions)",
            lblSchedulingComments: "Scheduling Comments",
            lblRecord: "Record",
            lblFileRecord: "Location",
            lblClickHere: "Click Here",
            lblNoLocationFoundTitle: "No Location Details Found",
            lblNoLocationFoundMessage: "Warning: There is no Location Detail record found for this file number.",
            lblNoLocationFoundDescription: "Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.",
            lblGoBackToDetails: "Go Back To Location Details",
            lblNoActiveLocations: "This location is not active for this Practice.",
            lblSearchNotFound: "This location is not active for B&M.  Choose a different service."
        };

        ///////////////////////////////////////////
        //// KEYBOARD EVENT HANDLES
        ko.bindingHandlers.enterKey = {
            init: function (element, valueAccessor, allBindings, vm) {
                ko.utils.registerEventHandler(element, "keyup", function (event) {
                    if (event.keyCode === 13) {
                        ko.utils.triggerEvent(element, "change");
                        valueAccessor().call(vm, vm);
                    }
                    return true;
                });
            }
        };


        ///////////////////////////////////////////
        //// VIEWMODELS
        var viewFindCriteria_LocationDetails = {
            findCriteria: ko.observable()
        };
        var view_LocationDetails = {
            //// DECLARATIONS
            index: 0,
            enablePrev: ko.observable(true),
            enableNext: ko.observable(true),
            enableFilePrev: ko.observable(true),
            enableFileNext: ko.observable(true),
            enableButtons: ko.observable(true),
            //enableImport: ko.observable(false),
            //enableCloseCancelContinue: ko.observable(true),
            messageError: ko.observable(),
            messageWarning: ko.observable(),
            messageNotice: ko.observable(),
            //messageImport: ko.observable("Results..."),
            messageNoActiveLocation: ko.observable(""),
            fileDirection: ko.observable(""),
            findEngaged: ko.observable(true),
            stateListingLoadOneRecord: true,   // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateDetailsLoadOneRecord: true,  // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateOnlyOneDetailRecordLoaded: true,
            stateLoadError: false,
            stateOnlyLoadDetails: false,
            pageRequestedFrom: getQueryVariable("req"),

            //// COLLECTIONS / OBJECTS
            //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
            gSafeGuid: getGSafeGUID(), //getQueryVariable('sid'),
            clientFeatures: ko.observable(),
            collInspection: new es.objects.ViewCCLocationInspectionBMCollection(),
            collListing: new es.objects.ViewCCLocationListingBMCollection(),
            objFind: ko.observable(),
            objListing: ko.observable(),
            objInspection: ko.observable(),
            objLanguageLabels: ko.observable(dsLanguageLabels),

            //// CHECKBOXES
            chkLoadCOPE: ko.observable(true),
            chkLoadNatHazDataInfo: ko.observable(true),
            chkLoadNatHazModelData: ko.observable(true),
            chkLoadRecInfo: ko.observable(true),
            chkLoadRatingInfo: ko.observable(true),
            chkLoadRetailInfo: ko.observable(true),

            //// MISC
            txtRecordNumber: ko.observable(),
            txtFileRecordNumber: ko.observable(),
            txtSchedulingComments: ko.observable(),
            //            txtCloseCancelContinue: ko.observable("Cancel"),
            //            uploadProgress: ko.observable(),
            loading: ko.observable(false),

            //// BUTTONS FOR RECORD NAVIGATION
            onNext: function () {
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded) {
                    view_LocationDetails.loadDetailsOnly();
                }
                if (view_LocationDetails.index < view_LocationDetails.collInspection().length - 1) {
                    view_LocationDetails.index++;
                    view_LocationDetails.objInspection(view_LocationDetails.collInspection()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            onPrevious: function () {
                if (view_LocationDetails.index > 0) {
                    view_LocationDetails.index--;
                    view_LocationDetails.objInspection(view_LocationDetails.collInspection()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            onFirst: function () {
                if (view_LocationDetails.index > 0) {
                    view_LocationDetails.index = 0;
                    view_LocationDetails.objInspection(view_LocationDetails.collInspection()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            onLast: function () {
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded) {
                    view_LocationDetails.loadDetailsOnly();
                }
                if (view_LocationDetails.index < view_LocationDetails.collInspection().length - 1) {
                    view_LocationDetails.index = view_LocationDetails.collInspection().length - 1;
                    view_LocationDetails.objInspection(view_LocationDetails.collInspection()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            //// BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                view_LocationDetails.fileDirection("first");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            onFilePrevious: function () {
                view_LocationDetails.fileDirection("previous");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            onFileNext: function () {
                view_LocationDetails.fileDirection("next");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            onFileLast: function () {
                view_LocationDetails.fileDirection("last");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            //// FIND A RECORD FROM THE LOCATION FIELDS
            onFind: function () {
                //// SET THE GSAFE
                setFindLocationFields(view_LocationDetails.gSafeGuid, view_LocationDetails.objFind(), view_LocationDetails.objListing());
                //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                view_LocationDetails.onFileFirst();
                view_LocationDetails.resetPickers();
            },

            onFindClear: function () {
                //// CLEAR THE OBJECT
                view_LocationDetails.resetPickers();
                //// SET THE GSAFE
                setFindLocationFields(view_LocationDetails.gSafeGuid, view_LocationDetails.objFind(), view_LocationDetails.objListing());
                //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                view_LocationDetails.onFileFirst();
                view_LocationDetails.resetPickers();
            },

            onLocationDetailsRedirect: function () {
                //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                document.location.href = "locationdetails.aspx" + "?sid=" + view_LocationDetails.gSafeGuid;
            },

            onBuildLink: function (fileName) {
                buildFileOpenLink(fileName, view_LocationDetails.gSafeGuid, "", "", false);
            },

            //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view_LocationDetails.index == 0) {
                    view_LocationDetails.enablePrev(false);
                    $('#btnFirst').addClass('grcBlueDisabledBtn');
                    $('#btnPrevious').addClass('grcBlueDisabledBtn');
                } else {
                    view_LocationDetails.enablePrev(true);
                    $('#btnFirst').removeClass('grcBlueDisabledBtn');
                    $('#btnPrevious').removeClass('grcBlueDisabledBtn');
                }
                if (view_LocationDetails.index == view_LocationDetails.collInspection().length - 1) {
                    view_LocationDetails.enableNext(false);
                    $('#btnNext').addClass('grcBlueDisabledBtn');
                    $('#btnLast').addClass('grcBlueDisabledBtn');
                } else {
                    view_LocationDetails.enableNext(true);
                    $('#btnNext').removeClass('grcBlueDisabledBtn');
                    $('#btnLast').removeClass('grcBlueDisabledBtn');
                }
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded == true) {
                    view_LocationDetails.enableNext(true);
                    $('#btnNext').removeClass('grcBlueDisabledBtn');
                    $('#btnLast').removeClass('grcBlueDisabledBtn');
                }
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded) {
                    view_LocationDetails.txtRecordNumber("1...");
                } else {
                    view_LocationDetails.txtRecordNumber((view_LocationDetails.index + 1) + " of " + view_LocationDetails.collInspection().length);
                }
            },

            setupFileButtons: function () {
                if (view_LocationDetails.objListing().RecNum() <= 1) {
                    view_LocationDetails.enableFilePrev(false);
                    $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                } else {
                    view_LocationDetails.enableFilePrev(true);
                    $('#btnFileFirst').removeClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').removeClass('grcBlueDisabledBtn');
                }
                if (view_LocationDetails.objListing().RecNum() >= view_LocationDetails.objListing().RecCount()) {
                    view_LocationDetails.enableFileNext(false);
                    $('#btnFileNext').addClass('grcBlueDisabledBtn');
                    $('#btnFileLast').addClass('grcBlueDisabledBtn');
                } else {
                    view_LocationDetails.enableFileNext(true);
                    $('#btnFileNext').removeClass('grcBlueDisabledBtn');
                    $('#btnFileLast').removeClass('grcBlueDisabledBtn');
                }
                if (view_LocationDetails.objListing().RecCount() <= 1) {
                    view_LocationDetails.enableFilePrev(false);
                    view_LocationDetails.enableFilePrev(false);
                    $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                }
                view_LocationDetails.txtFileRecordNumber(view_LocationDetails.objListing().RecNum() + " of " + view_LocationDetails.objListing().RecCount());
            },

            //// SETUP FIND FIELDS FOR LOCATIONS
            setupFindFields: function () {
                //// FIND TEXT BOXES
                view_LocationDetails.objFind().findFileNo = view_LocationDetails.objListing().FileNo();
                view_LocationDetails.objFind().findClientLocNo = view_LocationDetails.objListing().ClientLocNo();
                view_LocationDetails.objFind().findAddress1 = view_LocationDetails.objListing().Address1();
                view_LocationDetails.objFind().findCity = view_LocationDetails.objListing().City();
                view_LocationDetails.objFind().findStProv = view_LocationDetails.objListing().StProv();
                view_LocationDetails.objFind().findCountry = view_LocationDetails.objListing().Country();
                view_LocationDetails.objFind().findZip = view_LocationDetails.objListing().Zip();
                view_LocationDetails.objFind().findDivision = view_LocationDetails.objListing().Division();
                view_LocationDetails.objFind().findFacility = view_LocationDetails.objListing().Facility();
                view_LocationDetails.objFind().findCustomAccess = view_LocationDetails.objListing().CustomAccess();
                view_LocationDetails.objFind().findLatitude = view_LocationDetails.objListing().Latitude();
                view_LocationDetails.objFind().findLongitude = view_LocationDetails.objListing().Longitude();
            },

            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// CLEAR THE FIELDS OF ALL DATA
                //view_LocationDetails.clearAddressFields();
                view_LocationDetails.clearPickers(true);

                //// SET GLOBAL VARS
                global_PracticeCode = view_LocationDetails.objInspection().PracticeCode();
                global_EnableAdminWindow = true;

                //// COPY THE FIND FIELDS
                view_LocationDetails.setupFindFields();

                //// DATE AND NUMBER PICKERS
                PDBuilding.value(view_LocationDetails.objInspection().PDBuilding());
                BIGrossProfit.value(view_LocationDetails.objInspection().BIGrossProfit());
                PDEquipment.value(view_LocationDetails.objInspection().PDEquipment());
                BIWageExtraExp.value(view_LocationDetails.objInspection().BIWageExtraExp());
                PDFinished.value(view_LocationDetails.objInspection().PDFinished());
                BIMisc.value(view_LocationDetails.objInspection().BIMisc());
                PDRawStock.value(view_LocationDetails.objInspection().PDRawStock());
                BIOther.value(view_LocationDetails.objInspection().BIOther());
                PDBuildersRisk.value(view_LocationDetails.objInspection().PDBuildersRisk());
                BITotal.value(view_LocationDetails.objInspection().BITotal());
                PDMisc.value(view_LocationDetails.objInspection().PDMisc());
                PDTotal.value(view_LocationDetails.objInspection().PDTotal());
                LocalTIV.value(view_LocationDetails.objInspection().LocalTIV());
                Percentustot100.value(view_LocationDetails.objInspection().Percentustot100());
                if (view_LocationDetails.objInspection().EngTargetMo() == null || view_LocationDetails.objInspection().EngTargetMo() == undefined || view_LocationDetails.objInspection().EngTargetMo() == "" || view_LocationDetails.objInspection().EngTargetMo() == "Mon Jan 1 00:00:00 EST 1900")
                { EngTargetMo.value(""); } else { EngTargetMo.value(view_LocationDetails.objInspection().EngTargetMo()); }
                if (view_LocationDetails.objInspection().DateCompleted() == null || view_LocationDetails.objInspection().DateCompleted() == undefined || view_LocationDetails.objInspection().DateCompleted() == "" || view_LocationDetails.objInspection().DateCompleted() == "Mon Jan 1 00:00:00 EST 1900")
                { DateCompleted.value(""); } else { DateCompleted.value(view_LocationDetails.objInspection().DateCompleted()); }
                if (view_LocationDetails.objInspection().DateMailedToClient() == null || view_LocationDetails.objInspection().DateMailedToClient() == undefined || view_LocationDetails.objInspection().DateMailedToClient() == "" || view_LocationDetails.objInspection().DateMailedToClient() == "Mon Jan 1 00:00:00 EST 1900")
                { DateMailedToClient.value(""); } else { DateMailedToClient.value(view_LocationDetails.objInspection().DateMailedToClient()); }
                if (view_LocationDetails.objListing().BMEmailedDate() == null || view_LocationDetails.objListing().BMEmailedDate() == undefined || view_LocationDetails.objListing().BMEmailedDate() == "" || view_LocationDetails.objListing().BMEmailedDate() == "Mon Jan 1 00:00:00 EST 1900")
                { BMEmailedDate.value(""); } else { BMEmailedDate.value(view_LocationDetails.objListing().BMEmailedDate()); }
                if (view_LocationDetails.objListing().BMActualDate() == null || view_LocationDetails.objListing().BMActualDate() == undefined || view_LocationDetails.objListing().BMActualDate() == "" || view_LocationDetails.objListing().BMActualDate() == "Mon Jan 1 00:00:00 EST 1900")
                { BMActualDate.value(""); } else { BMActualDate.value(view_LocationDetails.objListing().BMActualDate()); }
                if (view_LocationDetails.objInspection().EffectiveDate() == null || view_LocationDetails.objInspection().EffectiveDate() == undefined || view_LocationDetails.objInspection().EffectiveDate() == "" || view_LocationDetails.objInspection().EffectiveDate() == "Mon Jan 1 00:00:00 EST 1900")
                { EffectiveDate.value(""); } else { EffectiveDate.value(view_LocationDetails.objInspection().EffectiveDate()); }
                if (view_LocationDetails.objInspection().CancelDate() == null || view_LocationDetails.objInspection().CancelDate() == undefined || view_LocationDetails.objInspection().CancelDate() == "" || view_LocationDetails.objInspection().CancelDate() == "Mon Jan 1 00:00:00 EST 1900")
                { CancelDate.value(""); } else { CancelDate.value(view_LocationDetails.objInspection().CancelDate()); }
                if (view_LocationDetails.objListing().BMLastInspectionDate() == null || view_LocationDetails.objListing().BMLastInspectionDate() == undefined || view_LocationDetails.objListing().BMLastInspectionDate() == "" || view_LocationDetails.objListing().BMLastInspectionDate() == "Mon Jan 1 00:00:00 EST 1900")
                { BMLastInspectionDate.value(""); } else { BMLastInspectionDate.value(view_LocationDetails.objListing().BMLastInspectionDate()); }

                //// RESET CLICK HERE FILE LINKS
                $("#lblToReportClickHere").removeClass("editRequired").addClass("noedit");
                $("#lblToReport2ClickHere").removeClass("editRequired").addClass("noedit");
                $("#lblToDiagramClickHere").removeClass("editRequired").addClass("noedit");
                $("#lblLastInspectionReportClickHere").removeClass("editRequired").addClass("noedit");

                //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                windowNoLocation.data("kendoWindow").close();
                view_LocationDetails.messageError("");
                view_LocationDetails.messageNoActiveLocation("");
                if ((view_LocationDetails.objInspection().FileNo() == "Not Found" && view_LocationDetails.pageRequestedFrom == "topnav") || (view_LocationDetails.objListing().FileNo() == "Not Found" && view_LocationDetails.pageRequestedFrom == "topnav")) {
                    view_LocationDetails.messageNoActiveLocation(view_LocationDetails.objLanguageLabels().lblNoActiveLocations);
                    view_LocationDetails.clearPickers();
                    view_LocationDetails.clearAddressFields();
                    global_EnableAdminWindow = false;
                } else if (view_LocationDetails.objInspection().FileNo() == "Not Found") {
                    windowNoLocation.data("kendoWindow").center().open();
                    $("#windowNoLocation").css("display", "block");
                    view_LocationDetails.clearPickers();
                    global_EnableAdminWindow = false;
                } else if (view_LocationDetails.objListing().FileNo() == "Not Found") {
                    view_LocationDetails.messageError(view_LocationDetails.objLanguageLabels().lblSearchNotFound);
                    view_LocationDetails.clearPickers();
                    global_EnableAdminWindow = false;
                }

                //// ALWAYS CLEAR THE REQUESTING VARIABLE FOR USE OF CLIENT SIDE BUTTON NAVIGATION
                view_LocationDetails.pageRequestedFrom = "";
            },

            clearAddressFields: function () {
                $("#FileNo").val("");
                $("#ClientLocNo").val("");
                $("#Latitude").val("");
                $("#Longitude").val("");
                $("#Address1").val("");
                $("#Division").val("");
                $("#City").val("");
                $("#StProv").val("");
                $("#Country").val("");
                $("#Zip").val("");
                $("#Facility").val("");
                $("#CustomAccess").val("");
                $("#txtFileRecordNumber").val("");
            },

            //// CLEAR ALL FIELDS IF NO RECORDS ARE FOUND
            clearPickers: function (pIsIgnoreTextFields) {
                //// KENDO WIDGETS
                EngTargetMo.value("");
                BMEmailedDate.value("");
                BMActualDate.value("");
                EffectiveDate.value("");
                CancelDate.value("");
                BMLastInspectionDate.value("");
                DateCompleted.value("");
                DateMailedToClient.value("");
                PDBuilding.value("");
                BIGrossProfit.value("");
                PDEquipment.value("");
                BIWageExtraExp.value("");
                PDFinished.value("");
                BIMisc.value("");
                PDRawStock.value("");
                BIOther.value("");
                PDBuildersRisk.value("");
                BITotal.value("");
                PDMisc.value("");
                PDTotal.value("");
                LocalTIV.value("");
                Percentustot100.value("");

                //// HTML / KNOCKOUT DOMS
                $("#ToBMReport").hide();
                $("#ToBMReport2").hide();
                $("#ToBMDiagram").hide();
                $("#BMLastInspectionReport").hide();
                if (pIsIgnoreTextFields) {
                    // DO NOTHING
                } else {
                    $("#Frequency").val("");
                    $("#NextInspYr").val("");
                }
            },

            //// LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
            loadDetailsOnly: function () {
                view_LocationDetails.stateLoadError = false;

                var tempParm = view_LocationDetails.gSafeGuid;
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (view_LocationDetails.stateDetailsLoadOneRecord == true && view_LocationDetails.stateLoadError == false) {
                    if (!view_LocationDetails.collInspection.ViewCCLocationInspectionBMCollections(tempParm + "|one|False")) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                    view_LocationDetails.stateDetailsLoadOneRecord = false;
                    view_LocationDetails.stateOnlyOneDetailRecordLoaded = true;
                } else {
                    if (!view_LocationDetails.collInspection.ViewCCLocationInspectionBMCollections(tempParm + "|all")) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                    view_LocationDetails.stateDetailsLoadOneRecord = false;
                    view_LocationDetails.stateOnlyOneDetailRecordLoaded = false;
                }
                if (!view_LocationDetails.stateLoadError) {
                    view_LocationDetails.objInspection(view_LocationDetails.collInspection()[view_LocationDetails.index]);
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view_LocationDetails.messageError("* Error while loading record.");
                }
            },

            //// LOAD ONE FILE NUMBER AND ONE DETAIL
            loadOneFileNumber: function () {
                view_LocationDetails.stateLoadError = false;

                var tempParm = view_LocationDetails.gSafeGuid + "|" + view_LocationDetails.fileDirection() + "|one|False";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collListing.ViewCCLocationBMCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateListingLoadOneRecord = false;

                tempParm = view_LocationDetails.gSafeGuid + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collInspection.ViewCCLocationInspectionBMCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateDetailsLoadOneRecord = false;
                view_LocationDetails.stateOnlyOneDetailRecordLoaded = true;

                view_LocationDetails.objListing(view_LocationDetails.collListing()[0]);
                view_LocationDetails.objInspection(view_LocationDetails.collInspection()[0]);
                view_LocationDetails.objFind(getFindLocationFields(view_LocationDetails.gSafeGuid));
                if (view_LocationDetails.objFind().findCriteria == undefined || view_LocationDetails.objFind().findCriteria == "") {
                    viewFindCriteria_LocationDetails.findCriteria(" ");
                    view_LocationDetails.findEngaged(true);
                } else {
                    viewFindCriteria_LocationDetails.findCriteria(view_LocationDetails.objFind().findCriteria);
                    view_LocationDetails.findEngaged(false);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.setupFileButtons();
            },

            //// LOAD RECORDS
            loadFileNumber: function () {
                view_LocationDetails.stateLoadError = false;

                //// LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                var tempParm = view_LocationDetails.gSafeGuid + "|" + view_LocationDetails.fileDirection() + "|one|False";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collListing.ViewCCLocationBMCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateListingLoadOneRecord = false;

                //// LOAD ALL DETAILS
                tempParm = view_LocationDetails.gSafeGuid + "|all";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collInspection.ViewCCLocationInspectionBMCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateDetailsLoadOneRecord = false;
                view_LocationDetails.stateOnlyOneDetailRecordLoaded = false;

                //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
                if (!view_LocationDetails.stateLoadError) {
                    view_LocationDetails.objListing(view_LocationDetails.collListing()[0]);
                    view_LocationDetails.objInspection(view_LocationDetails.collInspection()[view_LocationDetails.index]);
                    view_LocationDetails.clientFeatures(getClientFeatures(view_LocationDetails.gSafeGuid));
                    view_LocationDetails.objFind(getFindLocationFields(view_LocationDetails.gSafeGuid));
                    view_LocationDetails.setupButtons();
                    view_LocationDetails.setupFileButtons();
                    if (view_LocationDetails.objFind().findCriteria == undefined || view_LocationDetails.objFind().findCriteria == "") {
                        viewFindCriteria_LocationDetails.findCriteria(" ");
                        view_LocationDetails.findEngaged(true);
                    } else {
                        viewFindCriteria_LocationDetails.findCriteria(view_LocationDetails.objFind().findCriteria);
                        view_LocationDetails.findEngaged(false);
                    }
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view_LocationDetails.messageError("* Error while loading record.");
                }

                //                var tempParm = view_LocationDetails.gSafeGuid + "|" + view_LocationDetails.fileDirection();
                //                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                //                if (!view_LocationDetails.collListing.ViewCCLocationBMCollections(tempParm)) {
                //                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                //                    if (!view_LocationDetails.collInspection.ViewCCLocationInspectionBMCollections(view_LocationDetails.gSafeGuid)) {
                //                        view_LocationDetails.objListing(view_LocationDetails.collListing()[0]);
                //                        view_LocationDetails.objInspection(view_LocationDetails.collInspection()[0]);
                //                        view_LocationDetails.clientFeatures(getClientFeatures(view_LocationDetails.gSafeGuid));
                //                        view_LocationDetails.objFind(getFindLocationFields(view_LocationDetails.gSafeGuid));
                //                        view_LocationDetails.setupButtons();
                //                        view_LocationDetails.setupFileButtons();
                //                        if (view_LocationDetails.objFind().findCriteria == undefined || view_LocationDetails.objFind().findCriteria == "") {
                //                            viewFindCriteria_LocationDetails.findCriteria(" ");
                //                            view_LocationDetails.findEngaged(true);
                //                        } else {
                //                            viewFindCriteria_LocationDetails.findCriteria(view_LocationDetails.objFind().findCriteria);
                //                            view_LocationDetails.findEngaged(false);
                //                        }
                //                    } else {
                //                        view_LocationDetails.messageError("* Error while loading Inspection Details.");
                //                    }
                //                } else {
                //                    view_LocationDetails.messageError("* Error while loading Location Listing.");
                //                }

            }
        };


        ///////////////////////////////////////////
        //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        view_LocationDetails.loadFileNumber();


        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view_LocationDetails, $("#view_LocationDetails")[0]);
        ko.applyBindings(viewFindCriteria_LocationDetails, $("#viewFindCriteria_LocationDetails")[0]);


        ///////////////////////////////////////////
        //// SETUP KENDOUI
        //// TEXTBOXES

        //// ERROR WINDOW
        var windowNoLocation = $("#windowNoLocation");
        windowNoLocation.kendoWindow({
            width: "300px",
            height: "200px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            modal: true,
            draggable: false,
            resizable: false,
            animation: { open: { effects: "none" }, close: { effects: "default" } }
        });
       
        $("#windowNoLocation").prev().find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view_LocationDetails.objLanguageLabels().lblNoLocationFoundTitle);

        //        //// ADMIN WINDOW
        //        var windowAdmin = $("#windowAdmin");
        //        windowAdmin.kendoWindow({
        //            width: "725px",
        //            height: "460px",
        //            title: "", // title added below with JQuery
        //            actions: false
        //        });
        //        $("#windowAdmin").closest(".k-window").css({
        //            top: 145,
        //            left: 215
        //        });
        //        $(document).find(".k-window-title").append("<img src='../images/icons/admin/businesswoman_24x24.png' align='left' alt='Administration Window' class='windowIcon'/>  " + view_LocationDetails.objLanguageLabels().lblWindowAdminTitle);

        //        //// ADMIN TABSTRIP
        //        var windowAdminTabStrip = $("#windowAdminTabStrip").kendoTabStrip({
        //            //select: onSelect,
        //            //activate: onActivate,
        //            animation: { open: { effects: "fadeIn"} }
        //        }).data("kendoTabStrip");
        //        windowAdminTabStrip.select(0);

        //        //// IMPORT UPLOADER
        //        var windowAdminUpload = $("#windowAdminUpload").kendoUpload({
        //            async: {
        //                saveUrl: "../Imports/ImportTest.aspx",
        //                autoUpload: false
        //            },
        //            localization: {
        //                select: "Select Files...",
        //                uploadSelectedFiles: "Start Import"
        //            },
        //            //complete: view_LocationDetails.onComplete,
        //            remove: view_LocationDetails.onCancel,
        //            cancel: view_LocationDetails.onCancel,
        //            select: view_LocationDetails.onSelect,
        //            progress: view_LocationDetails.onProgress,
        //            success: view_LocationDetails.onSuccess,
        //            error: view_LocationDetails.onError,
        //            upload: view_LocationDetails.onUpload
        //        }).data("kendoUpload");

        //// most plain text inputs do not need bound in JS but need kendo widgets for styles
        //        $("#FileNo").kendoAutoComplete();
        //        $("#ClientLocNo").kendoAutoComplete();
        //        $("#Latitude").kendoAutoComplete();
        //        $("#Longitude").kendoAutoComplete();
        //        $("#Address1").kendoAutoComplete();
        //        $("#Division").kendoAutoComplete();
        //        $("#City").kendoAutoComplete();
        //        $("#StProv").kendoAutoComplete();
        //        $("#Facility").kendoAutoComplete();
        //        $("#Country").kendoAutoComplete();
        //        $("#Zip").kendoAutoComplete();
        //        $("#CustomAccess").kendoAutoComplete();
        //$("#Engineer").kendoAutoComplete();
        //$("#PracticeCode").kendoAutoComplete();
        //$("#CurrencyCode").kendoAutoComplete();
        //$("#Frequency").kendoAutoComplete();
        //$("#InspectionStatus").kendoAutoComplete();
        //$("#NextInspYr").kendoAutoComplete();
        //$("#txtSchedulingComments").kendoAutoComplete();
        //$("#txtRecordNumber").kendoAutoComplete();

        //// LINKS
        //// bound in html, no kendoui


        //// DATES
        var EngTargetMo = $("#EngTargetMo").kendoDatePicker({
            value: view_LocationDetails.objInspection().EngTargetMo(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        EngTargetMo.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "113px").find(".k-select").hide();

        var BMEmailedDate = $("#BMEmailedDate").kendoDatePicker({
            value: view_LocationDetails.objListing().BMEmailedDate(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        BMEmailedDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "113px").find(".k-select").hide();

        var BMActualDate = $("#BMActualDate").kendoDatePicker({
            value: view_LocationDetails.objListing().BMActualDate(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        BMActualDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "113px").find(".k-select").hide();

        var EffectiveDate = $("#EffectiveDate").kendoDatePicker({
            value: view_LocationDetails.objInspection().EffectiveDate(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        EffectiveDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "75px").find(".k-select").hide();

        var CancelDate = $("#CancelDate").kendoDatePicker({
            value: view_LocationDetails.objInspection().CancelDate(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        CancelDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "113px").find(".k-select").hide();

        var BMLastInspectionDate = $("#BMLastInspectionDate").kendoDatePicker({
            value: view_LocationDetails.objListing().BMLastInspectionDate(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        BMLastInspectionDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "113px").find(".k-select").hide();

        var DateCompleted = $("#DateCompleted").kendoDatePicker({
            value: view_LocationDetails.objInspection().DateCompleted(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        DateCompleted.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "113px").find(".k-select").hide();

        var DateMailedToClient = $("#DateMailedToClient").kendoDatePicker({
            value: view_LocationDetails.objInspection().DateMailedToClient(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        DateMailedToClient.wrapper
            .find(".k-picker-wrap").addClass("expand-padding").css("height", "13px").css("width", "113px").find(".k-select").hide();

        //// NUMERIC TEXTBOXES
        var PDBuilding = $("#PDBuilding").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().PDBuilding(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        PDBuilding.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var BIGrossProfit = $("#BIGrossProfit").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().BIGrossProfit(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        BIGrossProfit.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var PDEquipment = $("#PDEquipment").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().PDEquipment(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        PDEquipment.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var BIWageExtraExp = $("#BIWageExtraExp").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().BIWageExtraExp(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        BIWageExtraExp.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var PDFinished = $("#PDFinished").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().PDFinished(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        PDFinished.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var BIMisc = $("#BIMisc").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().BIMisc(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        BIMisc.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var PDRawStock = $("#PDRawStock").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().PDRawStock(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        PDRawStock.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var BIOther = $("#BIOther").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().BIOther(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        BIOther.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var PDBuildersRisk = $("#PDBuildersRisk").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().PDBuildersRisk(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        PDBuildersRisk.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var BITotal = $("#BITotal").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().BITotal(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        BITotal.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var PDMisc = $("#PDMisc").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().PDMisc(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        PDMisc.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var PDTotal = $("#PDTotal").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().PDTotal(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        PDTotal.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var LocalTIV = $("#LocalTIV").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().LocalTIV(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        LocalTIV.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        var Percentustot100 = $("#Percentustot100").kendoNumericTextBox({
            value: view_LocationDetails.objInspection().Percentustot100(),
            format: "n3",
            decimals: 3
        }).data("kendoNumericTextBox");
        Percentustot100.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();


        //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
        view_LocationDetails.setupFindFields();
        view_LocationDetails.resetPickers();


        //// A GLOBAL REFRESH FOR THE ADMIN WINDOW
        window.refreshPage = function () {
            view_LocationDetails.fileDirection("");
            view_LocationDetails.loadOneFileNumber();
            view_LocationDetails.resetPickers();
        }

    });
</script>

    </form>
</body>
</html>
