<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="tab_facilityrating.aspx.vb" Inherits="GRC.Connect.Web.tab_facilityrating_boiler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/facilityrating.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCBMFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingBM.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCBMFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingBM.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria_FacilityRating" data-bind="with: viewFindCriteria_FacilityRating">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
    <div id="view_FacilityRating" data-bind="with: view_FacilityRating" style="width:810px;">
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

        <!-- TABLE FOR PHYSICAL ASSETS INFORMATION -->
        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
        <div>
            <div class="tabBannerHeader" style="height:35px; font-size:12px; margin-bottom:5px;">
                <label style="width:115px;">Physical Assets:</label>
                <label style="width:90px;">Mechanical Systems</label>
                <label style="width:90px;">Electrical Systems</label>
                <label style="width:90px;">Boiler/Preasure Vessels/Tanks</label>
                <label style="width:90px">Prod./Process Equipment</label>
                <label style="width:90px">Occupancy</label>
                <label style="width:90px;">Computer Systems</label>
                <label style="width:165px;">Inspection Date</label>
            </div>
        </div>
        <div class="tableDivAutoBorders">
            <div class="tableDiv">
                
                <div class="tabRow">
                    <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblWeight">Weight</label></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().MechEquipWeight" id="MechEquipWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ElecEquipWeight" id="ElecEquipWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().BoilersWeight" id="BoilersWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ProcEquipWeight" id="ProcEquipWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().OccupancyWeight" id="OccupancyWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().CompSysWeight" id="CompSysWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="passiveTotalInputsBoiler" style="padding-left: 0px; width: 110px;">
                        <input data-bind="" id="InspectionDate" class="k-numerictextbox inputCenter inputNoEdit inspectionDateInput" readonly="readonly" />
                    </span>
                    <span class="bufferRight"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblRating">Rating</label></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().MechEquipC" id="MechEquipC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ElecEquipC" id="ElecEquipC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().BoilersC" id="BoilersC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ProcEquipC" id="ProcEquipC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().OccupancyC" id="OccupancyC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().CompSysC" id="CompSysC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="buttonCell">
                        <div class="buttonContainer" style="display:flex; padding-left:15px;">
                            <span style="margin-right:3px"><button data-bind="click: $parent.onPrevious, enable: $parent.enablePrev" class="pagerBtn grcBlueBtn" id="btnPrevious"><i class="fas fa-caret-left"></i></button></span>
                            <span><button data-bind="click: $parent.onNext, enable: $parent.enableNext" class="pagerBtn grcBlueBtn" id="btnNext"><i class="fas fa-caret-right"></i></button></span>
                            <span class="buttonRecordLabel"><label data-bind="text: $parent.txtRecordNumber"></label></span>
                        </div>
                    </span>
                    <span class="bufferRight"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft passiveDescriptionLabels" style="height: 46px;"><label data-bind="text: $parent.objLanguageLabels().lblDescription">Description</label></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().MechEquipDesc, attr: { title: $parent.objFacilityRating().MechEquipDesc }" id="MechEquipDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().ElecEquipDesc, attr: { title: $parent.objFacilityRating().ElecEquipDesc }" id="ElecEquipDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().BoilersDesc, attr: { title: $parent.objFacilityRating().BoilersDesc }" id="BoilersDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().ProcEquipDesc, attr: { title: $parent.objFacilityRating().ProcEquipDesc }" id="ProcEquipDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().OccupancyDesc, attr: { title: $parent.objFacilityRating().OccupancyDesc }" id="OccupancyDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().CompSysDesc, attr: { title: $parent.objFacilityRating().CompSysDesc }" id="CompSysDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="borderRight" style="height: 46px;"></span>
                    <span class="" style="height: 46px; text-align: center; padding-left: 0px;">
                        <div class="passiveTotalLabels"><label data-bind="text: $parent.objLanguageLabels().lblTotalPassiveScore">Total Score</label></div>
                        <div class="passiveTotalInputsBoiler" style="padding-left: 0px;">
                            <input data-bind="value: $parent.objFacilityRating().PassiveC" id="PassiveC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly"/>
                        </div>
                    </span>
                    <span class="bufferRight" style="height: 46px;"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft passiveLabelsLong" style="line-height: normal !important;"><label data-bind="text: $parent.objLanguageLabels().lblRatingAllRecsCompleted">Rating with All Recs Completed</label></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().MechEquipWR" id="MechEquipWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ElecEquipWR" id="ElecEquipWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Boil70ersWR" id="BoilersWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ProcEquipWR" id="ProcEquipWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().OccupancyWR" id="OccupancyWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().CompSysWR" id="CompSysWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="passiveTotalLabels fix" style="line-height: 9pt; padding-left:0px;"><label data-bind="text: $parent.objLanguageLabels().lblTotalPassiveScoreRecsCompleted">Total Score with Recs Completed</label></span>
                    <span class="bufferRight"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft passiveDescriptionLabels" style="height: 46px;"><label data-bind="text: $parent.objLanguageLabels().lblDescription" style="line-height: 35px;">Description</label></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().MechEquipWRDesc, attr: { title: $parent.objFacilityRating().MechEquipWRDesc }" id="MechEquipWRDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().ElecEquipWRDesc, attr: { title: $parent.objFacilityRating().ElecEquipWRDesc }" id="ElecEquipWRDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().BoilersWRDesc, attr: { title: $parent.objFacilityRating().BoilersWRDesc }" id="BoilersWRDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().ProcEquipWRDesc, attr: { title: $parent.objFacilityRating().ProcEquipWRDesc }" id="ProcEquipWRDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().OccupancyWRDesc, attr: { title: $parent.objFacilityRating().OccupancyWRDesc }" id="OccupancyWRDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().CompSysWRDesc, attr: { title: $parent.objFacilityRating().CompSysWRDesc }" id="CompSysWRDesc" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="borderRight" style="height: 46px;"></span>
                    <span class="passiveTotalInputsBoiler" style="height: 46px; padding-top: 6px; padding-left:14px;">
                        <input data-bind="value: $parent.objFacilityRating().PassiveWC" id="PassiveWC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" style="width: 92px !important;" />
                    </span>
                    <span class="bufferRight" style="height: 46px;"></span>
                </div>
            <!-- END TABLE FOR PHYSICAL ASSETS INFORMATION -->
            </div>
        </div>
      

        <!-- TABLE FOR Management Programs INFORMATION -->
        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
        <div>
            <div class="tabBannerHeader" style="font-size:12px; margin-bottom:5px;">
                <label style="width:120px;">Management Programs:</label>
                <label style="width:110px;">Mech. Prev./Pred. Maintenance</label>
                <label style="width:115px;">Elect. Prev./Pred. Maintenance</label>
                <label style="width:110px;">Critical Spares</label>
                <label style="width:110px;">Human Element</label>
                <label style="width:125px;">Bus. Cont. Planning</label>
                <label style="width:150px">&nbsp;</label>
            </div>
        </div>
        <div class="tableDivAutoBorders">
            <div class="tableDiv">
                <div class="tabRow">
                    <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblWeight">Weight</label></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().MechMaintWeight" id="MechMaintWeight" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().ElecMaintWeight" id="ElecMaintWeight" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().SparesWeight" id="SparesWeight" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().HumanElementWeight" id="HumanElementWeight" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().BCPWeight" id="BCPWeight" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="passiveTotalLabels"><label data-bind="text: $parent.objLanguageLabels().lblTotalActiveScore" style="margin-top: 15px;">Total Score</label></span>
                    <span class="bufferRight"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblRating">Rating</label></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().MechMaintC" id="MechMaintC" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().ElecMaintC" id="ElecMaintC" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().SparesC" id="SparesC" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().HumanElementC" id="HumanElementC" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().BCPC" id="BCPC" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="passiveTotalInputsBoiler"><input data-bind="value: $parent.objFacilityRating().ActiveC" id="ActiveC" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="bufferRight"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft activeDescriptionLabels" style="height: 46px;"><label data-bind="text: $parent.objLanguageLabels().lblDescription">Description</label></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().MechMaintDesc, attr: { title: $parent.objFacilityRating().MechMaintDesc }" id="MechMaintDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().ElecMaintDesc, attr: { title: $parent.objFacilityRating().ElecMaintDesc }" id="ElecMaintDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().SparesDesc, attr: { title: $parent.objFacilityRating().SparesDesc }" id="SparesDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().HumanElementDesc, attr: { title: $parent.objFacilityRating().HumanElementDesc }" id="HumanElementDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().BCPDesc, attr: { title: $parent.objFacilityRating().BCPDesc }" id="BCPDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="borderRight" style="height: 46px;"></span>
                    <span class="passiveTotalLabels fix" style="height: 46px; line-height: 9pt;">
                        <div style="font-size: 6px; height: 20px;">&nbsp;<br />&nbsp;<br />&nbsp;<br /></div>
                        <label data-bind="text: $parent.objLanguageLabels().lblTotalActiveScoreRecsCompleted">Total Score with Recs Completed</label></span>
                    <span class="bufferRight" style="height: 46px;"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft activeLabelsLong"style="line-height: normal !important;"><label data-bind="text: $parent.objLanguageLabels().lblRatingAllRecsCompleted">Rating with All Recs Completed</label></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().MechMaintWR" id="MechMaintWR" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().ElecMaintWR" id="ElecMaintWR" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().SparesWR" id="SparesWR" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().HumanElementWR" id="HumanElementWR" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="activeInputsBoiler"><input data-bind="value: $parent.objFacilityRating().BCPWR" id="BCPWR" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="passiveTotalInputsBoiler"><input data-bind="value: $parent.objFacilityRating().ActiveWC" id="ActiveWC" class="k-numerictextbox inputCenter inputNoEdit activeInputsBoiler" readonly="readonly" /></span>
                    <span class="bufferRight"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft activeLabels" style="height: 46px;"><label data-bind="text: $parent.objLanguageLabels().lblDescription" style="line-height: 35px;">Description</label></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().MechMaintWRDesc, attr: { title: $parent.objFacilityRating().MechMaintWRDesc }" id="MechMaintWRDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().ElecMaintWRDesc, attr: { title: $parent.objFacilityRating().ElecMaintWRDesc }" id="ElecMaintWRDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().SparesWrDesc, attr: { title: $parent.objFacilityRating().SparesWrDesc }" id="SparesWrDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().HumanElementWRDesc, attr: { title: $parent.objFacilityRating().HumanElementWRDesc }" id="HumanElementWRDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputsBoiler" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().BCPWRDesc, attr: { title: $parent.objFacilityRating().BCPWRDesc }" id="BCPWRDesc" class="k-textbox inputNoEdit activeDescriptionInputsTextBoxBoiler" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="borderRight" style="height: 46px;"></span>
                    <span class="passiveTotalLabels" style="height: 46px;"></span>
                    <span class="bufferRight" style="height: 46px;"></span>
                </div>
            </div>
        <!-- END TABLE FOR Management Programs INFORMATION -->
        </div>

        <div style="height: 16px; clear: both;">&nbsp;</div>


        <div class="tabRow">
            <!-- NOTES -->
            <div class="boilerNote">
                <label style="white-space: normal;" data-bind="text: $parent.objLanguageLabels().lblNote">(Physical Assets for B&M considers the equipment is already installed at the facility. However, recommendations may be submitted to improve/maintain, add or replace equipment to reduce the exposure.)</label>

                <br />
                &nbsp;<br />

                <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
                <div style="text-align: center;">
                    <label class="messageError" data-bind="text: $parent.messageError"></label>
                    <label class="messageNotice" data-bind="    text: $parent.messageNotice"></label>
                    <label class="messageWarning" data-bind="    text: $parent.messageWarning"></label>
                    &nbsp;
                </div>

            </div>

            <!-- ***************************** -->
            <!-- TABLE FOR SUMMARY INFORMATION -->
            <div class="tableDiv containerSummary">
                <div>
                    <span class="summaryLabels">
                        <label data-bind="text: $parent.objLanguageLabels().lblTotalFacilityScore">Total Facility Score</label></span>
                    <span class="summaryInputs">
                        <input data-bind="value: $parent.objFacilityRating().TotalScoreCurrent" id="TotalScoreCurrent" class="k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels">
                        <label data-bind="text: $parent.objLanguageLabels().lblOverallRatings">Overall Rating</label></span>
                    <span class="summaryInputsSmallFontsBoiler">
                        <input data-bind="value: $parent.objFacilityRating().OverallPlantRatingRatingDescription" id="OverallPlantRatingRating" class="k-textbox inputCenter inputNoEdit summaryInputsSmallFontsBoiler" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels">
                        <label data-bind="text: $parent.objLanguageLabels().lblOverallScoreRecsComplete">Overall Score with Recs Compl.</label></span>
                    <span class="summaryInputs">
                        <input data-bind="value: $parent.objFacilityRating().TotalWRComplete" id="TotalWRComplete" class="k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
            </div>
            <!-- END TABLE FOR SUMMARY INFORMATION -->

            <!-- ******************** -->
            <!-- TABLE FOR RATING KEY -->
            <div class="tableDiv containerRatingKey">
                <div>
                    <span class="borderTop borderLeft ratingKeyBuffer"></span>
                    <span class="borderTop ratingKeyContent">
                        <label data-bind="text: $parent.objLanguageLabels().lblRatingKey">Rating Key</label></span>
                    <span class="borderTop borderRight ratingKeyBuffer"></span>
                </div>
                <div>
                    <span class="borderLeft ratingKeyBufferContent" style="height: 80px;"></span>
                    <span class="ratingKeyContent">
                        <div class="ratingColorTable">
                            <div class="ratingKeyCell" id="RatingKeyColor1" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription1">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription1"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor2" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription2">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription2"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor3" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription3">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription3"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor4" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription4">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription4"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor5" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription5">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription5"></label>
                            </div>
                        </div>
                    </span>
                    <span class="borderRight ratingKeyBufferContent" style="height: 80px; width: 4px;"></span>
                </div>
                <div>
                    <span class="borderBottom borderLeft ratingKeyBuffer" style="height: 12px;"></span>
                    <span class="borderBottom ratingKeyContent" style="height: 12px;"></span>
                    <span class="borderBottom borderRight ratingKeyBuffer" style="height: 12px;"></span>
                </div>
            </div>
            <!-- END TABLE FOR RATING KEY -->
        </div>
        
        <style>
            #windowNoLocation .k-window-title {
                font-size:16px;
            }
        </style>
        <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
        <div id="windowNoLocation" class="windowContent" style="font-size:13px;">
            <div>
                <img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" />
            </div>
            <div style="margin-bottom:5px;">
                <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There was no Facility Rating record found for this location.</label>
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

                //// PASSIVE
                lblWeight: "Weight",
                lblRating: "Rating",
                lblDescription: "Description",
                lblTotalPassiveScore: "Total Score",
                lblTotalPassiveScoreRecsCompleted: "Total Score with Recs Completed",

                //// ACTIVE
                lblRatingAllRecsCompleted: "Rating with All Recs Completed",
                lblTotalActiveScore: "Total Score",
                lblTotalActiveScoreRecsCompleted: "Total Score with Recs Completed",

                //// APL
                lblAPLPDBI: "APL (PD + BI)",
                lblAplfactor: "APL Factor",
                lblAPLAllRecsComplete: "APL with All Recs Completed",
                lblAplfactorAllRecsComplete: "APL Factor with All Recs Completed",
                lblAplfactorKey: "APL Factor Key",

                //// SUMMARY
                lblTotalFacilityScore: "Total Facility Score",
                lblOverallRatings: "Overall Rating",
                lblOverallScoreRecsComplete: "Overall Score with Recs Compl.",
                lblMaxPossibleScore: "Max Possible Score",
                lblMaxpossiblerating: "Max Possible Rating",
                lblAPLNote: "(The total facility score is the sum of all Physical Assets and Management Programs multiplied by the APL Factor.  The lower the facility's APL the greater the APL Facotr.)",
                lblNote: "(Physical Assets for B&M considers the equipment is already installed at the facility. However, recommendations may be submitted to improve/maintain, add or replace equipment to reduce the exposure.)",

                //// RATING KEY
                lblRatingKey: "Rating Key",

                //// MISC
                lblInspectionDate: "Inspection Date",
                lblRecord: "Record",
                lblFileRecord: "Location",
                lblOf: "of",
                lblNoLocationFoundTitle: "No Facility Rating Found",
                lblNoLocationFoundMessage: "Warning: There was no Facility Rating record found for this location.",
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
            //// VIEWMODEL
            var viewFindCriteria_FacilityRating = {
                findCriteria: ko.observable()
            };
            var view_FacilityRating = {
                //// DECLARATIONS
                index: 0,
                enablePrev: ko.observable(true),
                enableNext: ko.observable(true),
                enableFilePrev: ko.observable(true),
                enableFileNext: ko.observable(true),
                messageError: ko.observable(),
                messageWarning: ko.observable(),
                messageNotice: ko.observable(),
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
                collFacilityRating: new es.objects.ViewCCBMFacilityRatingCollection(),
                collListing: new es.objects.ViewCCLocationListingBMCollection(),
                objFind: ko.observable(),
                objListing: ko.observable(),
                objFacilityRating: ko.observable(),
                objLanguageLabels: ko.observable(dsLanguageLabels),

                //// MISC
                txtRecordNumber: ko.observable(),
                txtFileRecordNumber: ko.observable(),
                txtSchedulingComments: ko.observable(),
                ColorTotalscore: ko.observable(),
                ColorMaxpossible: ko.observable(),
                loading: ko.observable(false),

                //// BUTTONS FOR RECORD NAVIGATION
                onNext: function () {
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded) {
                        view_FacilityRating.loadDetailsOnly();
                    }
                    if (view_FacilityRating.index < view_FacilityRating.collFacilityRating().length - 1) {
                        view_FacilityRating.index++;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                onPrevious: function () {
                    if (view_FacilityRating.index > 0) {
                        view_FacilityRating.index--;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                onFirst: function () {
                    if (view_FacilityRating.index > 0) {
                        view_FacilityRating.index = 0;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                onLast: function () {
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded) {
                        view_FacilityRating.loadDetailsOnly();
                    }
                    if (view_FacilityRating.index < view_FacilityRating.collFacilityRating().length - 1) {
                        view_FacilityRating.index = view_FacilityRating.collFacilityRating().length - 1;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                //// BUTTONS FOR FILE NUMBER / LOCATION WALK
                onFileFirst: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("first");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                onFilePrevious: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("previous");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                onFileNext: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("next");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                onFileLast: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("last");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                //// FIND A RECORD FROM THE LOCATION FIELDS
                onFind: function () {
                    //// SET THE GSAFE
                    setFindLocationFields(view_FacilityRating.gSafeGuid, view_FacilityRating.objFind(), view_FacilityRating.objListing());
                    //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                    view_FacilityRating.onFileFirst();
                    view_FacilityRating.resetPickers();
                },

                onFindClear: function () {
                    //// CLEAR THE OBJECT
                    view_FacilityRating.resetPickers();
                    //// SET THE GSAFE
                    setFindLocationFields(view_FacilityRating.gSafeGuid, view_FacilityRating.objFind(), view_FacilityRating.objListing());
                    //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                    view_FacilityRating.onFileFirst();
                    view_FacilityRating.resetPickers();
                },

                onLocationDetailsRedirect: function () {
                    //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                    document.location.href = "locationdetails.aspx" + "?sid=" + view_FacilityRating.gSafeGuid;
                },

                //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
                setupButtons: function () {
                    if (view_FacilityRating.index == 0) {
                        view_FacilityRating.enablePrev(false);
                        $('#btnPrevious').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enablePrev(true);
                        $('#btnPrevious').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.index == view_FacilityRating.collFacilityRating().length - 1) {
                        view_FacilityRating.enableNext(false);
                        $('#btnNext').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enableNext(true);
                        $('#btnNext').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded == true) {
                        view_FacilityRating.enableNext(true);
                        $('#btnNext').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded) {
                        view_FacilityRating.txtRecordNumber("1...");
                    } else {
                        view_FacilityRating.txtRecordNumber((view_FacilityRating.index + 1) + " of " + view_FacilityRating.collFacilityRating().length);
                    }
                },

                setupFileButtons: function () {
                    if (view_FacilityRating.objListing().RecNum() <= 1) {
                        view_FacilityRating.enableFilePrev(false);
                        $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                        $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enableFilePrev(true);
                        $('#btnFileFirst').removeClass('grcBlueDisabledBtn');
                        $('#btnFilePrevious').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.objListing().RecNum() >= view_FacilityRating.objListing().RecCount()) {
                        view_FacilityRating.enableFileNext(false);
                        $('#btnFileNext').addClass('grcBlueDisabledBtn');
                        $('#btnFileLast').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enableFileNext(true);
                        $('#btnFileNext').removeClass('grcBlueDisabledBtn');
                        $('#btnFileLast').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.objListing().RecCount() <= 1) {
                        view_FacilityRating.enableFilePrev(false);
                        view_FacilityRating.enableFilePrev(false);
                        $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                        $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                    }
                    view_FacilityRating.txtFileRecordNumber(view_FacilityRating.objListing().RecNum() + " of " + view_FacilityRating.objListing().RecCount());
                },

                //// SETUP FIND FIELDS FOR LOCATIONS
                setupFindFields: function () {
                    //// FIND TEXT BOXES
                    view_FacilityRating.objFind().findFileNo = view_FacilityRating.objListing().FileNo();
                    view_FacilityRating.objFind().findClientLocNo = view_FacilityRating.objListing().ClientLocNo();
                    view_FacilityRating.objFind().findAddress1 = view_FacilityRating.objListing().Address1();
                    view_FacilityRating.objFind().findCity = view_FacilityRating.objListing().City();
                    view_FacilityRating.objFind().findStProv = view_FacilityRating.objListing().StProv();
                    view_FacilityRating.objFind().findCountry = view_FacilityRating.objListing().Country();
                    view_FacilityRating.objFind().findZip = view_FacilityRating.objListing().Zip();
                    view_FacilityRating.objFind().findDivision = view_FacilityRating.objListing().Division();
                    view_FacilityRating.objFind().findFacility = view_FacilityRating.objListing().Facility();
                    view_FacilityRating.objFind().findCustomAccess = view_FacilityRating.objListing().CustomAccess();
                    view_FacilityRating.objFind().findLatitude = view_FacilityRating.objListing().Latitude();
                    view_FacilityRating.objFind().findLongitude = view_FacilityRating.objListing().Longitude();
                },

                //// RESET FIELDS ON LOAD RECORD
                resetPickers: function () {
                    //// COPY THE FIND FIELDS
                    view_FacilityRating.setupFindFields();

                    //// COLORS
                    OverallPlantRatingRating.wrapper.find(".k-input").css("background-color", view_FacilityRating.objFacilityRating().OverallPlantRatingRatingColor());
                    OverallPlantRatingRating.wrapper.find(".k-input").parent().css("background-color", view_FacilityRating.objFacilityRating().OverallPlantRatingRatingColor());
                    $("#RatingKeyColor1").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor1());
                    $("#RatingKeyColor2").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor2());
                    $("#RatingKeyColor3").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor3());
                    $("#RatingKeyColor4").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor4());
                    $("#RatingKeyColor5").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor5());

                    //// WEIGHT VALUES PHYSICAL ASSETS AND MANAGEMENT PROGRAMS AND OTHER
                    InspectionDate.value(view_FacilityRating.objFacilityRating().InspectionDate());
                    MechEquipWeight.value(view_FacilityRating.objFacilityRating().MechEquipWeight() / 10);
                    ElecEquipWeight.value(view_FacilityRating.objFacilityRating().ElecEquipWeight() / 10);
                    BoilersWeight.value(view_FacilityRating.objFacilityRating().BoilersWeight() / 10);
                    ProcEquipWeight.value(view_FacilityRating.objFacilityRating().ProcEquipWeight() / 10);
                    OccupancyWeight.value(view_FacilityRating.objFacilityRating().OccupancyWeight() / 10);
                    CompSysWeight.value(view_FacilityRating.objFacilityRating().CompSysWeight() / 10);

                    MechMaintWeight.value(view_FacilityRating.objFacilityRating().MechMaintWeight() / 10);
                    ElecMaintWeight.value(view_FacilityRating.objFacilityRating().ElecMaintWeight() / 10);
                    SparesWeight.value(view_FacilityRating.objFacilityRating().SparesWeight() / 10);
                    HumanElementWeight.value(view_FacilityRating.objFacilityRating().HumanElementWeight() / 10);
                    BCPWeight.value(view_FacilityRating.objFacilityRating().BCPWeight() / 10);

                    //// RATING VALUES AND COLORS PHYSICAL ASSETS AND MANAGEMENT PROGRAMS
                    MechEquipC.value(view_FacilityRating.objFacilityRating().MechEquipC());
                    MechEquipC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechEquipCColor());
                    //MechEquipC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechEquipCColor());
                    ElecEquipC.value(view_FacilityRating.objFacilityRating().ElecEquipC());
                    ElecEquipC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipCColor());
                    //ElecEquipC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipCColor());
                    BoilersC.value(view_FacilityRating.objFacilityRating().BoilersC());
                    BoilersC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BoilersCColor());
                    //BoilersC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BoilersCColor());
                    ProcEquipC.value(view_FacilityRating.objFacilityRating().ProcEquipC());
                    ProcEquipC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipCColor());
                    //ProcEquipC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipCColor());
                    OccupancyC.value(view_FacilityRating.objFacilityRating().OccupancyC());
                    OccupancyC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().OccupancyCColor());
                    //OccupancyC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().OccupancyCColor());
                    CompSysC.value(view_FacilityRating.objFacilityRating().CompSysC());
                    CompSysC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().CompSysCColor());
                    //CompSysC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().CompSysCColor());
                    MechEquipWR.value(view_FacilityRating.objFacilityRating().MechEquipWR());
                    MechEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechEquipWRColor());
                    //MechEquipWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechEquipWRColor());
                    ElecEquipWR.value(view_FacilityRating.objFacilityRating().ElecEquipWR());
                    ElecEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipWRColor());
                    //ElecEquipWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipWRColor());
                    BoilersWR.value(view_FacilityRating.objFacilityRating().BoilersWR());
                    BoilersWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BoilersWRColor());
                    //BoilersWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BoilersWRColor());
                    ProcEquipWR.value(view_FacilityRating.objFacilityRating().ProcEquipWR());
                    ProcEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipWRColor());
                    //ProcEquipWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipWRColor());
                    OccupancyWR.value(view_FacilityRating.objFacilityRating().OccupancyWR());
                    OccupancyWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().OccupancyWRColor());
                    //OccupancyWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().OccupancyWRColor());
                    CompSysWR.value(view_FacilityRating.objFacilityRating().CompSysWR());
                    CompSysWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().CompSysWRColor());
                    //CompSysWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().CompSysWRColor());
                    MechMaintC.value(view_FacilityRating.objFacilityRating().MechMaintC());
                    MechMaintC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechMaintCColor());
                    //MechMaintC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechMaintCColor());
                    ElecMaintC.value(view_FacilityRating.objFacilityRating().ElecMaintC());
                    ElecMaintC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintCColor());
                    //ElecMaintC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintCColor());
                    SparesC.value(view_FacilityRating.objFacilityRating().SparesC());
                    SparesC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().SparesCColor());
                    //SparesC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().SparesCColor());
                    HumanElementC.value(view_FacilityRating.objFacilityRating().HumanElementC());
                    HumanElementC.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().HumanElementCColor());
                    //HumanElementC.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().HumanElementCColor());
                    Bcpc.value(view_FacilityRating.objFacilityRating().Bcpc());
                    Bcpc.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BCPCColor());
                    //Bcpc.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BCPCColor());
                    MechMaintWR.value(view_FacilityRating.objFacilityRating().MechMaintWR());
                    MechMaintWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechMaintWRColor());
                    //MechMaintWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechMaintWRColor());
                    ElecMaintWR.value(view_FacilityRating.objFacilityRating().ElecMaintWR());
                    ElecMaintWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintWRColor());
                    //ElecMaintWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintWRColor());
                    SparesWR.value(view_FacilityRating.objFacilityRating().SparesWR());
                    SparesWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().SparesWRColor());
                    //SparesWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().SparesWRColor());
                    HumanElementWR.value(view_FacilityRating.objFacilityRating().HumanElementWR());
                    HumanElementWR.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().HumanElementWRColor());
                    //HumanElementWR.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().HumanElementWRColor());
                    Bcpwr.value(view_FacilityRating.objFacilityRating().Bcpwr());
                    Bcpwr.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BCPWRColor());
                    //Bcpwr.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BCPWRColor());

                    //// APL VALUES
                    // EXAMPLE PassiveC.value(view_FacilityRating.objFacilityRating().PassiveC());

                    //// SUMMARY AND TOTAL VALUES
                    PassiveC.value(view_FacilityRating.objFacilityRating().PassiveC());
                    PassiveWC.value(view_FacilityRating.objFacilityRating().PassiveWC());
                    ActiveC.value(view_FacilityRating.objFacilityRating().ActiveC());
                    ActiveWC.value(view_FacilityRating.objFacilityRating().ActiveWC());
                    //TotalScoreCurrent.value(view_FacilityRating.objFacilityRating().TotalScoreCurrent());
                    //TotalWRComplete.value(view_FacilityRating.objFacilityRating().TotalWRComplete());
                    OverallPlantRatingRating.value(view_FacilityRating.objFacilityRating().OverallPlantRatingRatingDescription());

                    //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                    windowNoLocation.data("kendoWindow").close();
                    view_FacilityRating.messageError("");
                    if ((view_FacilityRating.objFacilityRating().FileNo() == "Not Found" && view_FacilityRating.pageRequestedFrom == "topnav") || (view_FacilityRating.objListing().FileNo() == "Not Found" && view_FacilityRating.pageRequestedFrom == "topnav")) {
                        view_FacilityRating.messageError(view_FacilityRating.objLanguageLabels().lblNoActiveLocations);
                        view_FacilityRating.clearPickers();
                        view_FacilityRating.clearAddressFields();
                    } else if (view_FacilityRating.objFacilityRating().FileNo() == "Not Found") {
                        windowNoLocation.data("kendoWindow").center().open();
                        $("#windowNoLocation").css("display", "block");
                        view_FacilityRating.clearPickers();
                    } else if (view_FacilityRating.objListing().FileNo() == "Not Found") {
                        view_FacilityRating.messageError(view_FacilityRating.objLanguageLabels().lblSearchNotFound);
                        view_FacilityRating.clearPickers();
                    }

                    //// ALWAYS CLEAR THE REQUESTING VARIABLE FOR USE OF CLIENT SIDE BUTTON NAVIGATION
                    view_FacilityRating.pageRequestedFrom = "";
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

                clearPickers: function () {
                    //// KENDO WIDGETS
                    //// COLORS
                    OverallPlantRatingRating.wrapper.find(".k-input").css("background-color", "transparent");
                    OverallPlantRatingRating.wrapper.find(".k-input").parent().css("background-color", "transparent");
                    //// WEIGHT VALUES PHYSICAL ASSETS AND MANAGEMENT PROGRAMS AND OTHER
                    InspectionDate.value("");
                    MechEquipWeight.value("");
                    ElecEquipWeight.value("");
                    BoilersWeight.value("");
                    ProcEquipWeight.value("");
                    OccupancyWeight.value("");
                    CompSysWeight.value("");
                    MechMaintWeight.value("");
                    ElecMaintWeight.value("");
                    SparesWeight.value("");
                    HumanElementWeight.value("");
                    BCPWeight.value("");
                    //// RATING VALUES AND COLORS PHYSICAL ASSETS AND MANAGEMENT PROGRAMS
                    MechEquipC.value("");
                    MechEquipC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    MechEquipC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    ElecEquipC.value("");
                    ElecEquipC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    ElecEquipC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    BoilersC.value("");
                    BoilersC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    BoilersC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    ProcEquipC.value("");
                    ProcEquipC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    ProcEquipC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    OccupancyC.value("");
                    OccupancyC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    OccupancyC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    CompSysC.value("");
                    CompSysC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    CompSysC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    MechEquipWR.value("");
                    MechEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    MechEquipWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    ElecEquipWR.value("");
                    ElecEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    ElecEquipWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    BoilersWR.value("");
                    BoilersWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    BoilersWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    ProcEquipWR.value("");
                    ProcEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    ProcEquipWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    OccupancyWR.value("");
                    OccupancyWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    OccupancyWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    CompSysWR.value("");
                    CompSysWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    CompSysWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    MechMaintC.value("");
                    MechMaintC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    MechMaintC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    ElecMaintC.value("");
                    ElecMaintC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    ElecMaintC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    SparesC.value("");
                    SparesC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    SparesC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    HumanElementC.value("");
                    HumanElementC.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    HumanElementC.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Bcpc.value("");
                    Bcpc.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Bcpc.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    MechMaintWR.value("");
                    MechMaintWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    MechMaintWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    ElecMaintWR.value("");
                    ElecMaintWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    ElecMaintWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    SparesWR.value("");
                    SparesWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    SparesWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    HumanElementWR.value("");
                    HumanElementWR.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    HumanElementWR.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Bcpwr.value("");
                    Bcpwr.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Bcpwr.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    //// APL VALUES
                    //// SUMMARY AND TOTAL VALUES
                    PassiveC.value("");
                    PassiveWC.value("");
                    ActiveC.value("");
                    ActiveWC.value("");
                    //TotalScoreCurrent.value("");
                    //TotalWRComplete.value("");
                    OverallPlantRatingRating.value("");

                    //// HTML / KNOCKOUT DOMS
                    $("#TotalScoreCurrent").val("");
                    $("#TotalWRComplete").val("");
                },

                //// LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
                loadDetailsOnly: function () {
                    view_FacilityRating.stateLoadError = false;

                    var tempParm = view_FacilityRating.gSafeGuid;
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (view_FacilityRating.stateDetailsLoadOneRecord == true && view_FacilityRating.stateLoadError == false) {
                        if (!view_FacilityRating.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm + "|one|False")) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                        view_FacilityRating.stateDetailsLoadOneRecord = false;
                        view_FacilityRating.stateOnlyOneDetailRecordLoaded = true;
                    } else {
                        if (!view_FacilityRating.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm + "|all|False")) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                        view_FacilityRating.stateDetailsLoadOneRecord = false;
                        view_FacilityRating.stateOnlyOneDetailRecordLoaded = false;
                    }
                    if (!view_FacilityRating.stateLoadError) {
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    } else {
                        //// DISPLAY ERROR MESSAGE
                        view_FacilityRating.messageError("* Error while loading record.");
                    }
                },

                //// LOAD ONE FILE NUMBER AND ONE DETAIL
                loadOneFileNumber: function () {
                    view_FacilityRating.stateLoadError = false;

                    var tempParm = view_FacilityRating.gSafeGuid + "|" + view_FacilityRating.fileDirection() + "|one|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collListing.ViewCCLocationBMCollections(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateListingLoadOneRecord = false;

                    tempParm = view_FacilityRating.gSafeGuid + "|one|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateDetailsLoadOneRecord = false;
                    view_FacilityRating.stateOnlyOneDetailRecordLoaded = true;

                    view_FacilityRating.objListing(view_FacilityRating.collListing()[0]);
                    view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[0]);
                    view_FacilityRating.objFind(getFindLocationFields(view_FacilityRating.gSafeGuid));
                    if (view_FacilityRating.objFind().findCriteria == undefined || view_FacilityRating.objFind().findCriteria == "") {
                        viewFindCriteria_FacilityRating.findCriteria(" ");
                        view_FacilityRating.findEngaged(true);
                    } else {
                        viewFindCriteria_FacilityRating.findCriteria(view_FacilityRating.objFind().findCriteria);
                        view_FacilityRating.findEngaged(false);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.setupFileButtons();
                },

                //// LOAD ALL RECORDS AND ALL DETAILS
                loadFileNumber: function () {
                    view_FacilityRating.stateLoadError = false;

                    //// LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                    var tempParm = view_FacilityRating.gSafeGuid + "|" + view_FacilityRating.fileDirection() + "|one|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collListing.ViewCCLocationBMCollections(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateListingLoadOneRecord = false;

                    //// LOAD ALL DETAILS
                    tempParm = view_FacilityRating.gSafeGuid + "|all|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateDetailsLoadOneRecord = false;
                    view_FacilityRating.stateOnlyOneDetailRecordLoaded = false;

                    //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
                    if (!view_FacilityRating.stateLoadError) {
                        view_FacilityRating.objListing(view_FacilityRating.collListing()[0]);
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                        view_FacilityRating.clientFeatures(getClientFeatures(view_FacilityRating.gSafeGuid));
                        view_FacilityRating.objFind(getFindLocationFields(view_FacilityRating.gSafeGuid));
                        view_FacilityRating.setupButtons();
                        view_FacilityRating.setupFileButtons();
                        if (view_FacilityRating.objFind().findCriteria == undefined || view_FacilityRating.objFind().findCriteria == "") {
                            viewFindCriteria_FacilityRating.findCriteria(" ");
                            view_FacilityRating.findEngaged(true);
                        } else {
                            viewFindCriteria_FacilityRating.findCriteria(view_FacilityRating.objFind().findCriteria);
                            view_FacilityRating.findEngaged(false);
                        }
                    } else {
                        //// DISPLAY ERROR MESSAGE
                        view_FacilityRating.messageError("* Error while loading record.");
                    }
                }
            };


            ///////////////////////////////////////////
            //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view_FacilityRating.loadFileNumber();

            ///////////////////////////////////////////
            //// ACTIVATE BINDINGS LAST
            ko.applyBindings(view_FacilityRating, $("#view_FacilityRating")[0]);
            ko.applyBindings(viewFindCriteria_FacilityRating, $("#viewFindCriteria_FacilityRating")[0]);

            ///////////////////////////////////////////
            //// SETUP KENDOUI

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
            $("#windowNoLocation").prev().find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view_FacilityRating.objLanguageLabels().lblNoLocationFoundTitle);


            //// RATING COLORS
            var OverallPlantRatingRating = $("#OverallPlantRatingRating").kendoAutoComplete().data("kendoAutoComplete");
            //OverallPlantRatingRating.wrapper.find(".k-input").css("background-color", view_FacilityRating.objFacilityRating().OverallPlantRatingRatingColor());
            //OverallPlantRatingRating.wrapper.find(".k-input").parent().css("background-color", view_FacilityRating.objFacilityRating().OverallPlantRatingRatingColor());

            //// KEY COLORS
            $("#RatingKeyColor1").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor1());
            $("#RatingKeyColor2").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor2());
            $("#RatingKeyColor3").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor3());
            $("#RatingKeyColor4").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor4());
            $("#RatingKeyColor5").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor5());

            //// DATES
            var InspectionDate = $("#InspectionDate").kendoDatePicker({
                value: view_FacilityRating.objFacilityRating().InspectionDate(),
                format: "dd-MMM-yy"
            }).data("kendoDatePicker");
            InspectionDate.wrapper
                    .find(".k-picker-wrap").addClass("expand-padding inspectionDateInput").css("height", "13px").find(".k-select").hide();

            //// PHYSICAL ASSETS NUMERIC TEXTBOXES
            //// WEIGHT
            var MechEquipWeight = $("#MechEquipWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().MechEquipWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            MechEquipWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var ElecEquipWeight = $("#ElecEquipWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ElecEquipWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ElecEquipWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var BoilersWeight = $("#BoilersWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().BoilersWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            BoilersWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var ProcEquipWeight = $("#ProcEquipWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ProcEquipWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ProcEquipWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var OccupancyWeight = $("#OccupancyWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().OccupancyWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            OccupancyWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var CompSysWeight = $("#CompSysWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().CompSysWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            CompSysWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();

            //// PHYSICAL ASSETS RATINGS        
            var MechEquipC = $("#MechEquipC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().MechEquipC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            MechEquipC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            MechEquipC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechEquipCColor());
            //MechEquipC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechEquipCColor());
            var ElecEquipC = $("#ElecEquipC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ElecEquipC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ElecEquipC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            ElecEquipC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipCColor());
            //ElecEquipC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipCColor());
            var BoilersC = $("#BoilersC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().BoilersC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            BoilersC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            BoilersC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BoilersCColor());
            //BoilersC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BoilersCColor());
            var ProcEquipC = $("#ProcEquipC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ProcEquipC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ProcEquipC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            ProcEquipC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipCColor());
            //ProcEquipC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipCColor());
            var OccupancyC = $("#OccupancyC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().OccupancyC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            OccupancyC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            OccupancyC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().OccupancyCColor());
            //OccupancyC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().OccupancyCColor());
            var CompSysC = $("#CompSysC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().CompSysC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            CompSysC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            CompSysC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().CompSysCColor());
            //CompSysC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().CompSysCColor());
            var MechEquipWR = $("#MechEquipWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().MechEquipWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            MechEquipWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            MechEquipWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechEquipWRColor());
            //MechEquipWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechEquipWRColor());
            var ElecEquipWR = $("#ElecEquipWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ElecEquipWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ElecEquipWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            ElecEquipWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipWRColor());
            //ElecEquipWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecEquipWRColor());
            var BoilersWR = $("#BoilersWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().BoilersWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            BoilersWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            BoilersWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BoilersWRColor());
            //BoilersWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BoilersWRColor());
            var ProcEquipWR = $("#ProcEquipWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ProcEquipWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ProcEquipWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            ProcEquipWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipWRColor());
            //ProcEquipWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ProcEquipWRColor());
            var OccupancyWR = $("#OccupancyWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().OccupancyWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            OccupancyWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            OccupancyWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().OccupancyWRColor());
            //OccupancyWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().OccupancyWRColor());
            var CompSysWR = $("#CompSysWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().CompSysWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            CompSysWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            CompSysWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().CompSysWRColor());
            //CompSysWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().CompSysWRColor());

            //// ACTIVE NUMERIC BOXES
            var MechMaintWeight = $("#MechMaintWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().MechMaintWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            MechMaintWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            var ElecMaintWeight = $("#ElecMaintWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ElecMaintWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ElecMaintWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            var SparesWeight = $("#SparesWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().SparesWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            SparesWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            var HumanElementWeight = $("#HumanElementWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().HumanElementWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            HumanElementWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            var BCPWeight = $("#BCPWeight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().BCPWeight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            BCPWeight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            var MechMaintC = $("#MechMaintC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().MechMaintC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            MechMaintC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            MechMaintC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechMaintCColor());
            //MechMaintC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechMaintCColor());
            var ElecMaintC = $("#ElecMaintC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ElecMaintC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ElecMaintC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            ElecMaintC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintCColor());
            //ElecMaintC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintCColor());
            var SparesC = $("#SparesC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().SparesC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            SparesC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            SparesC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().SparesCColor());
            //SparesC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().SparesCColor());
            var HumanElementC = $("#HumanElementC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().HumanElementC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            HumanElementC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            HumanElementC.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().HumanElementCColor());
            //HumanElementC.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().HumanElementCColor());
            var Bcpc = $("#BCPC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Bcpc(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Bcpc.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            Bcpc.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BCPCColor());
            //Bcpc.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BCPCColor());
            var MechMaintWR = $("#MechMaintWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().MechMaintWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            MechMaintWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            MechMaintWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().MechMaintWRColor());
            //MechMaintWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().MechMaintWRColor());
            var ElecMaintWR = $("#ElecMaintWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ElecMaintWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ElecMaintWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            ElecMaintWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintWRColor());
            //ElecMaintWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().ElecMaintWRColor());
            var SparesWR = $("#SparesWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().SparesWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            SparesWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            SparesWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().SparesWRColor());
            //SparesWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().SparesWRColor());
            var HumanElementWR = $("#HumanElementWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().HumanElementWR(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            HumanElementWR.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            HumanElementWR.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().HumanElementWRColor());
            //HumanElementWR.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().HumanElementWRColor());
            var Bcpwr = $("#BCPWR").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Bcpwr(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Bcpwr.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
            Bcpwr.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().BCPWRColor());
            //Bcpwr.wrapper
            //        .find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().BCPWRColor());

            //// SUMMARY AND TOTAL NUMERIC TEXT BOXES
            var PassiveC = $("#PassiveC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().PassiveC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            PassiveC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();
            var PassiveWC = $("#PassiveWC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().PassiveWC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            PassiveWC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
            var ActiveC = $("#ActiveC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ActiveC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ActiveC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
            var ActiveWC = $("#ActiveWC").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().ActiveWC(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            ActiveWC.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();

            //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
            view_FacilityRating.setupFindFields();
            view_FacilityRating.resetPickers();
        });
    </script>

    </form>
</body>
</html>
