<%@ Page Title="Boiler and Machinery Program Facility Rating | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectLocationRatingFromChart.Master" CodeBehind="facilityratingfromchart.aspx.vb" Inherits="GRC.Connect.Web.FacilityRatingFromChart_boiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="Stylesheet" type="text/css" href="../../css/pages/facilityrating.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCBMFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingBM.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCBMFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingBM.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="view" data-bind="with: view">
        <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
        <div id="tabLocDetailsContainer" class="tabLocDetailsContainer" style="padding-top:0px; margin-top:0px;">
            <div id="tabLocDetailsLoading" class="tabLocDetailsLoading">
                Loading ...
            </div>
            <div id="tabLocDetailsContainerInside" class="tabLocDetailsContainerInside">
                <div id="tabStrip" class="k-tabstrip-wrapper">
                    <ul>
                        <li class="k-state-active">Rating From Chart</li>
                    </ul>
                    <div>
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
                                <span class="companyLabels1"><%--<img data-bind="visible: $parent.loading" src="../../Home_{{VER}}/Images/loading/loadingdetails.gif" style="height: 20px; width: 75px; border: 0px;" alt="Loading" />--%></span>
                                <span class="buttonContainerLocationLoading">
                                </span>
                                <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
                                <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
                                <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
                            </div>
                        </div>
                        <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

                        <br />&nbsp;<br />

                        <!-- TABLE FOR PHYSICAL ASSETS INFORMATION -->
                        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
                        <div>
                            <div class="tabBannerHeader" style="height: 35px; font-size: 12px; margin-bottom: 5px;">
                                <label style="width: 115px;">Physical Assets:</label>
                                <label style="width: 90px;">Mechanical Systems</label>
                                <label style="width: 90px;">Electrical Systems</label>
                                <label style="width: 90px;">Boiler/Preasure Vessels/Tanks</label>
                                <label style="width: 90px">Prod./Process Equipment</label>
                                <label style="width: 90px">Occupancy</label>
                                <label style="width: 90px;">Computer Systems</label>
                                <label style="width: 165px;">Inspection Date</label>
                            </div>
                        </div>
                        <div class="tableDivAutoBorders">
                            <div class="tableDiv">
                                <div class="tabRow">
                                    <!-- EMPTY ROW AT TOP MUST HAVE HEIGHT SPECIFIED OR IT WILL BE 23px -->
                                    <span class="bufferLeft passiveLabels" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                    <span class="borderRight" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveTotalLabels" style="height: 4px;">&nbsp;</span>
                                    <span class="bufferRight" style="height: 4px;">&nbsp;</span>
                                </div>
                                <div class="tabRow">
                                    <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblWeight">Weight</label></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().MechEquipWeight" id="MechEquipWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ElecEquipWeight" id="ElecEquipWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().BoilersWeight" id="BoilersWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ProcEquipWeight" id="ProcEquipWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().OccupancyWeight" id="OccupancyWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().CompSysWeight" id="CompSysWeight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="borderRight"></span>
                                    <span class="passiveTotalInputsBoiler" style="padding-right: 2px"><input data-bind="" id="InspectionDate" class="k-numerictextbox inputCenter inputNoEdit inspectionDateInput" readonly="readonly" /></span>
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
                                    <span class="" style="height: 46px; text-align: center; padding-left: 6px;">
                                        <div class="passiveTotalLabels fix"><label data-bind="text: $parent.objLanguageLabels().lblTotalPassiveScore">Total Score</label></div>
                                        <div class="passiveTotalInputsBoiler" style="padding-left: 5px;">
                                            <input data-bind="value: $parent.objFacilityRating().PassiveC" id="PassiveC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" />
                                        </div>
                                    </span>
                                    <span class="bufferRight" style="height: 46px;"></span>
                                </div>
                                <div class="tabRow">
                                    <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblRatingAllRecsCompleted" style="line-height: normal;">Rating with All Recs Completed</label></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().MechEquipWR" id="MechEquipWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ElecEquipWR" id="ElecEquipWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Boil70ersWR" id="BoilersWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().ProcEquipWR" id="ProcEquipWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().OccupancyWR" id="OccupancyWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().CompSysWR" id="CompSysWR" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                    <span class="borderRight"></span>
                                    <span class="passiveTotalLabels fix" style="line-height: 9pt;"><label data-bind="text: $parent.objLanguageLabels().lblTotalPassiveScoreRecsCompleted">Total with Recs Completed</label></span>
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
                                    <span class="passiveTotalInputsBoiler" style="height: 46px; padding-right: 2px;">
                                        <div style="padding-top: 6px;"><input data-bind="value: $parent.objFacilityRating().PassiveWC" id="PassiveWC" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></div>
                                    </span>
                                    <span class="bufferRight" style="height: 46px;"></span>
                                </div>
                                <div style="height: 10px;" class="tabRow">
                                    <span class="bufferLeft passiveLabels" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                    <span class="borderRight" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveTotalLabels" style="height: 7px;">&nbsp;</span>
                                    <span class="bufferRight" style="height: 7px;">&nbsp;</span>
                                </div>
                            <!-- END TABLE FOR PHYSICAL ASSETS INFORMATION -->
                            </div>
                        </div>
           
    
                        <div style="height: 5px;">&nbsp;</div>

                        <!-- TABLE FOR Management Programs INFORMATION -->
                        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
                        <div>
                            <div class="tabBannerHeader" style="font-size: 12px; margin-bottom: 5px;">
                                <label style="width: 120px;">Management Programs:</label>
                                <label style="width: 110px;">Mech. Prev./Pred. Maintenance</label>
                                <label style="width: 115px;">Elect. Prev./Pred. Maintenance</label>
                                <label style="width: 110px;">Critical Spares</label>
                                <label style="width: 110px;">Human Element</label>
                                <label style="width: 125px;">Bus. Cont. Planning</label>
                                <label style="width: 150px">&nbsp;</label>
                            </div>
                        </div>
                        <div class="tableDivAutoBorders">
                            <div class="tableDiv">
                                <div class="tabRow">
                                    <!-- EMPTY ROW AT TOP MUST HAVE HEIGHT SPECIFIED OR IT WILL BE 23px -->
                                    <span class="bufferLeft passiveLabels" style="height: 4px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 4px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 4px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 4px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 4px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 4px;">&nbsp;</span>
                                    <span class="borderRight" style="height: 4px;">&nbsp;</span>
                                    <span class="passiveTotalLabels" style="height: 4px;">&nbsp;</span>
                                    <span class="bufferRight" style="height: 4px;">&nbsp;</span>
                                </div>
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
                                    <span class="bufferLeft activeLabels"><label data-bind="text: $parent.objLanguageLabels().lblRatingAllRecsCompleted" style="line-height: normal;">Rating with All Recs Completed</label></span>
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
                                <div style="height: 10px;" class="tabRow">
                                    <span class="bufferLeft passiveLabels" style="height: 7px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 7px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 7px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 7px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 7px;">&nbsp;</span>
                                    <span class="activeInputsBoiler" style="height: 7px;">&nbsp;</span>
                                    <span class="borderRight" style="height: 7px;">&nbsp;</span>
                                    <span class="passiveTotalLabels" style="height: 7px;">&nbsp;</span>
                                    <span class="bufferRight" style="height: 7px;">&nbsp;</span>
                                </div>
                            </div>
                        <!-- END TABLE FOR Management Programs INFORMATION -->
                        </div>

                        <div style="height: 16px; clear: both;">&nbsp;</div>

                        <!-- NOTES -->
                        <div class="boilerNote">
                            <label data-bind="text: $parent.objLanguageLabels().lblNote">(Physical Assets for B&M considers the equipment is already installed at the facility. However, recommendations may be submitted to improve/maintain, add or replace equipment to reduce the exposure.)</label>
                        </div>

                        <div style="display:flex;">
                            <!-- ***************************** -->
                            <!-- TABLE FOR SUMMARY INFORMATION -->
                            <div class="tableDiv containerSummary">
                                <div>
                                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblTotalFacilityScore">Total Facility Score</label></span>
                                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().TotalScoreCurrent" id="TotalScoreCurrent" class="k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                                </div>
                                <div>
                                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblOverallRatings">Overall Rating</label></span>
                                    <span class="summaryInputsSmallFontsBoiler"><input data-bind="value: $parent.objFacilityRating().OverallPlantRatingRatingDescription" id="OverallPlantRatingRating" class="k-textbox inputCenter inputNoEdit summaryInputsSmallFontsBoiler" readonly="readonly" /></span>
                                </div>
                                <div>
                                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblOverallScoreRecsComplete">Overall Score with Recs Compl.</label></span>
                                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().TotalWRComplete" id="TotalWRComplete" class="k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                                </div>
                            </div>
                            <!-- END TABLE FOR SUMMARY INFORMATION -->

                            <!-- ******************** -->
                            <!-- TABLE FOR RATING KEY -->
                            <div class="tableDiv containerRatingKey">
                                <div>
                                    <span class="borderTop borderLeft ratingKeyBuffer"></span>
                                    <span class="borderTop ratingKeyContent"><label data-bind="text: $parent.objLanguageLabels().lblRatingKey">Rating Key</label></span>
                                    <span class="borderTop borderRight ratingKeyBuffer"></span>
                                </div>
                                <div>
                                    <span class="borderLeft ratingKeyBufferContent" style="height: 80px;"></span>
                                    <span class="ratingKeyContent">
                                           <div class="ratingColorTable">
                                            <div class="ratingKeyCell" id="RatingKeyColor1" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription1"><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription1"></label></div>
                                            <div class="ratingKeyCell" id="RatingKeyColor2" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription2"><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription2"></label></div>
                                            <div class="ratingKeyCell" id="RatingKeyColor3" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription3"><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription3"></label></div>
                                            <div class="ratingKeyCell" id="RatingKeyColor4" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription4"><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription4"></label></div>
                                            <div class="ratingKeyCell" id="RatingKeyColor5" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription5"><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription5"></label></div>
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

                        <br style="clear: both;" />&nbsp;<br />

                        <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
                        <div style=""><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="text: $parent.messageNotice"></label><label class="messageWarning" data-bind="text: $parent.messageWarning"></label>&nbsp;</div>
                    </div>

                    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
                    <div id="windowNoLocation" class="windowContent">
                        <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
                        <div><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There was no Facility Rating record found for this location.</label></div>
                        <br />&nbsp;<br />
                        <div><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label></div>
                        <br />&nbsp;<br />
                        <div style="text-align: center;"><button class="k-button k-button-padding" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button></div>
                    </div>
    
                </div>
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
            lblSearchNotFound: "No location was found. Please click the 'Clear Find' button to try again."
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
        var viewFindCriteria = {
            findCriteria: ko.observable()
        };
        var view = {
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
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collFacilityRating().length - 1) {
                    view.index++;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onPrevious: function () {
                if (view.index > 0) {
                    view.index--;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onFirst: function () {
                if (view.index > 0) {
                    view.index = 0;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onLast: function () {
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collFacilityRating().length - 1) {
                    view.index = view.collFacilityRating().length - 1;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            //// BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                view.index = 0;
                view.fileDirection("first");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFilePrevious: function () {
                view.index = 0;
                view.fileDirection("previous");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFileNext: function () {
                view.index = 0;
                view.fileDirection("next");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFileLast: function () {
                view.index = 0;
                view.fileDirection("last");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            //// FIND A RECORD FROM THE LOCATION FIELDS
            onFind: function () {
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                view.onFileFirst();
                view.resetPickers();
            },

            onFindClear: function () {
                //// CLEAR THE OBJECT
                view.resetPickers();
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                view.onFileFirst();
                view.resetPickers();
            },

            onLocationDetailsRedirect: function () {
                //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                document.location.href = "locationdetails.aspx" + "?sid=" + view.gSafeGuid;
            },

            //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view.index == 0) { view.enablePrev(false); } else { view.enablePrev(true); }
                if (view.index == view.collFacilityRating().length - 1) { view.enableNext(false); } else { view.enableNext(true); }
                if (view.stateOnlyOneDetailRecordLoaded == true) { view.enableNext(true); }
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.txtRecordNumber("1...");
                } else {
                    view.txtRecordNumber((view.index + 1) + " of " + view.collFacilityRating().length);
                }
            },

            setupFileButtons: function () {
                if (view.objListing().RecNum() <= 1) { view.enableFilePrev(false); } else { view.enableFilePrev(true); }
                if (view.objListing().RecNum() >= view.objListing().RecCount()) { view.enableFileNext(false); } else { view.enableFileNext(true); }
                if (view.objListing().RecCount() <= 1) { view.enableFilePrev(false); view.enableFilePrev(false); }
                view.txtFileRecordNumber(view.objListing().RecNum() + " of " + view.objListing().RecCount());
            },

            //// SETUP FIND FIELDS FOR LOCATIONS
            setupFindFields: function () {
                //// FIND TEXT BOXES
                view.objFind().findFileNo = view.objListing().FileNo();
                view.objFind().findClientLocNo = view.objListing().ClientLocNo();
                view.objFind().findAddress1 = view.objListing().Address1();
                view.objFind().findCity = view.objListing().City();
                view.objFind().findStProv = view.objListing().StProv();
                view.objFind().findCountry = view.objListing().Country();
                view.objFind().findZip = view.objListing().Zip();
                view.objFind().findDivision = view.objListing().Division();
                view.objFind().findFacility = view.objListing().Facility();
                view.objFind().findCustomAccess = view.objListing().CustomAccess();
                view.objFind().findLatitude = view.objListing().Latitude();
                view.objFind().findLongitude = view.objListing().Longitude();
            },

            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// COPY THE FIND FIELDS
                view.setupFindFields();

                //// COLORS
                OverallPlantRatingRating.wrapper.find(".k-input").css("background-color", view.objFacilityRating().OverallPlantRatingRatingColor());
                OverallPlantRatingRating.wrapper.find(".k-input").parent().css("background-color", view.objFacilityRating().OverallPlantRatingRatingColor());
                $("#RatingKeyColor1").css("background-color", view.objFacilityRating().RatingKeyColor1());
                $("#RatingKeyColor2").css("background-color", view.objFacilityRating().RatingKeyColor2());
                $("#RatingKeyColor3").css("background-color", view.objFacilityRating().RatingKeyColor3());
                $("#RatingKeyColor4").css("background-color", view.objFacilityRating().RatingKeyColor4());
                $("#RatingKeyColor5").css("background-color", view.objFacilityRating().RatingKeyColor5());

                //// WEIGHT VALUES PHYSICAL ASSETS AND MANAGEMENT PROGRAMS AND OTHER
                InspectionDate.value(view.objFacilityRating().InspectionDate());
                MechEquipWeight.value(view.objFacilityRating().MechEquipWeight() / 10);
                ElecEquipWeight.value(view.objFacilityRating().ElecEquipWeight() / 10);
                BoilersWeight.value(view.objFacilityRating().BoilersWeight() / 10);
                ProcEquipWeight.value(view.objFacilityRating().ProcEquipWeight() / 10);
                OccupancyWeight.value(view.objFacilityRating().OccupancyWeight() / 10);
                CompSysWeight.value(view.objFacilityRating().CompSysWeight() / 10);
                
                MechMaintWeight.value(view.objFacilityRating().MechMaintWeight() / 10);
                ElecMaintWeight.value(view.objFacilityRating().ElecMaintWeight() / 10);
                SparesWeight.value(view.objFacilityRating().SparesWeight() / 10);
                HumanElementWeight.value(view.objFacilityRating().HumanElementWeight() / 10);
                BCPWeight.value(view.objFacilityRating().BCPWeight() / 10);

                //// RATING VALUES AND COLORS PHYSICAL ASSETS AND MANAGEMENT PROGRAMS
                MechEquipC.value(view.objFacilityRating().MechEquipC());
                MechEquipC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechEquipCColor());
                //MechEquipC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().MechEquipCColor());
                ElecEquipC.value(view.objFacilityRating().ElecEquipC());
                ElecEquipC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecEquipCColor());
                //ElecEquipC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecEquipCColor());
                BoilersC.value(view.objFacilityRating().BoilersC());
                BoilersC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BoilersCColor());
                //BoilersC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().BoilersCColor());
                ProcEquipC.value(view.objFacilityRating().ProcEquipC());
                ProcEquipC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ProcEquipCColor());
                //ProcEquipC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().ProcEquipCColor());
                OccupancyC.value(view.objFacilityRating().OccupancyC());
                OccupancyC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().OccupancyCColor());
                //OccupancyC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().OccupancyCColor());
                CompSysC.value(view.objFacilityRating().CompSysC());
                CompSysC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().CompSysCColor());
                //CompSysC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().CompSysCColor());
                MechEquipWR.value(view.objFacilityRating().MechEquipWR());
                MechEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechEquipWRColor());
                //MechEquipWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().MechEquipWRColor());
                ElecEquipWR.value(view.objFacilityRating().ElecEquipWR());
                ElecEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecEquipWRColor());
                //ElecEquipWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecEquipWRColor());
                BoilersWR.value(view.objFacilityRating().BoilersWR());
                BoilersWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BoilersWRColor());
                //BoilersWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().BoilersWRColor());
                ProcEquipWR.value(view.objFacilityRating().ProcEquipWR());
                ProcEquipWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ProcEquipWRColor());
                //ProcEquipWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().ProcEquipWRColor());
                OccupancyWR.value(view.objFacilityRating().OccupancyWR());
                OccupancyWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().OccupancyWRColor());
                //OccupancyWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().OccupancyWRColor());
                CompSysWR.value(view.objFacilityRating().CompSysWR());
                CompSysWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().CompSysWRColor());
                //CompSysWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().CompSysWRColor());
                MechMaintC.value(view.objFacilityRating().MechMaintC());
                MechMaintC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechMaintCColor());
                //MechMaintC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().MechMaintCColor());
                ElecMaintC.value(view.objFacilityRating().ElecMaintC());
                ElecMaintC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecMaintCColor());
                //ElecMaintC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecMaintCColor());
                SparesC.value(view.objFacilityRating().SparesC());
                SparesC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().SparesCColor());
                //SparesC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().SparesCColor());
                HumanElementC.value(view.objFacilityRating().HumanElementC());
                HumanElementC.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().HumanElementCColor());
                //HumanElementC.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().HumanElementCColor());
                Bcpc.value(view.objFacilityRating().Bcpc());
                Bcpc.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BCPCColor());
                //Bcpc.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().BCPCColor());
                MechMaintWR.value(view.objFacilityRating().MechMaintWR());
                MechMaintWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechMaintWRColor());
                //MechMaintWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().MechMaintWRColor());
                ElecMaintWR.value(view.objFacilityRating().ElecMaintWR());
                ElecMaintWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecMaintWRColor());
                //ElecMaintWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecMaintWRColor());
                SparesWR.value(view.objFacilityRating().SparesWR());
                SparesWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().SparesWRColor());
                //SparesWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().SparesWRColor());
                HumanElementWR.value(view.objFacilityRating().HumanElementWR());
                HumanElementWR.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().HumanElementWRColor());
                //HumanElementWR.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().HumanElementWRColor());
                Bcpwr.value(view.objFacilityRating().Bcpwr());
                Bcpwr.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BCPWRColor());
                //Bcpwr.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().BCPWRColor());

                //// APL VALUES
                // EXAMPLE PassiveC.value(view.objFacilityRating().PassiveC());

                //// SUMMARY AND TOTAL VALUES
                PassiveC.value(view.objFacilityRating().PassiveC());
                PassiveWC.value(view.objFacilityRating().PassiveWC());
                ActiveC.value(view.objFacilityRating().ActiveC());
                ActiveWC.value(view.objFacilityRating().ActiveWC());
                //TotalScoreCurrent.value(view.objFacilityRating().TotalScoreCurrent());
                //TotalWRComplete.value(view.objFacilityRating().TotalWRComplete());
                OverallPlantRatingRating.value(view.objFacilityRating().OverallPlantRatingRatingDescription());

                //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                windowNoLocation.data("kendoWindow").close();
                view.messageError("");
                if (view.objFacilityRating().FileNo() == "Not Found") {
                    windowNoLocation.data("kendoWindow").open();
                    $("#windowNoLocation").css("display", "block");
                } else if (view.objListing().FileNo() == "Not Found") {
                    view.messageError(view.objLanguageLabels().lblSearchNotFound);
                }
            },

            //// LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
            loadDetailsOnly: function () {
                view.stateLoadError = false;

                var tempParm = view.gSafeGuid;
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (view.stateDetailsLoadOneRecord == true && view.stateLoadError == false) {
                    if (!view.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm + "|one|True")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = true;
                } else {
                    if (!view.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm + "|all|True")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = false;
                }
                if (!view.stateLoadError) {
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.messageError("* Error while loading record.");
                }
            },

            //// LOAD ONE FILE NUMBER AND ONE DETAIL
            loadOneFileNumber: function () {
                view.stateLoadError = false;

                var tempParm = view.gSafeGuid + "|" + view.fileDirection() + "|one|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.ViewCCLocationBMCollections(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                tempParm = view.gSafeGuid + "|one|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = true;

                view.objListing(view.collListing()[0]);
                view.objFacilityRating(view.collFacilityRating()[0]);
                view.objFind(getFindLocationFields(view.gSafeGuid));
                if (view.objFind().findCriteria == undefined || view.objFind().findCriteria == "") {
                    viewFindCriteria.findCriteria(" ");
                    view.findEngaged(true);
                } else {
                    viewFindCriteria.findCriteria(view.objFind().findCriteria);
                    view.findEngaged(false);
                }
                view.setupButtons();
                view.setupFileButtons();
            },

            //// LOAD ALL RECORDS AND ALL DETAILS
            loadFileNumber: function () {
                view.stateLoadError = false;

                //// LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                var tempParm = view.gSafeGuid + "|" + view.fileDirection() + "|one|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.ViewCCLocationBMCollections(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                //// LOAD ALL DETAILS
                tempParm = view.gSafeGuid + "|all|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collFacilityRating.ViewCCBMFacilityRatingCollection(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = false;

                //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
                if (!view.stateLoadError) {
                    view.objListing(view.collListing()[0]);
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                    view.clientFeatures(getClientFeatures(view.gSafeGuid));
                    view.objFind(getFindLocationFields(view.gSafeGuid));
                    view.setupButtons();
                    view.setupFileButtons();
                    if (view.objFind().findCriteria == undefined || view.objFind().findCriteria == "") {
                        viewFindCriteria.findCriteria(" ");
                        view.findEngaged(true);
                    } else {
                        viewFindCriteria.findCriteria(view.objFind().findCriteria);
                        view.findEngaged(false);
                    }
                    // FIND CORRECT RECORD INSPECTION DATE AND NAV TO IT.
                    var zInspectionDate = global.getQueryVariable("insp");
                    if (zInspectionDate) {
                        var zCount = 0;
                        for (var x = 0; x < view.collFacilityRating().length; x++) {
                            if (view.collFacilityRating()[x].InspectionDate()) {
                                if (zInspectionDate == global.formatShortDate(view.collFacilityRating()[x].InspectionDate())) {
                                    zCount = x;
                                    break;
                                }
                            }
                        }
                        if (zCount > 0) {
                            setTimeout(function () {
                                for (var x = 0; x < zCount; x++) {
                                    view.onNext();
                                }
                            }, 250);
                        }
                    }
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.messageError("* Error while loading record.");
                }
            }
        };


        ///////////////////////////////////////////
        //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        view.loadFileNumber();

        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view, $("#view")[0]);
        //ko.applyBindings(viewFindCriteria, $("#viewFindCriteria")[0]); // NOT USED IN THIS VERSION OF RATINGS FORM

        ///////////////////////////////////////////
        //// SETUP KENDOUI

        //// ERROR WINDOW
        var windowNoLocation = $("#windowNoLocation");
        windowNoLocation.kendoWindow({
            width: "300px",
            height: "200px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            draggable: false,
            resizable: false,
            modal: true,
            animation: { open: { effects: "none" }, close: { effects: "default"} }
        });
        $("#windowNoLocation").closest(".k-window").css({
            top: 300,
            left: 375
        });
        $(document).find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblNoLocationFoundTitle);

        //// TEXTBOXES
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

        //// RATING COLORS
        var OverallPlantRatingRating = $("#OverallPlantRatingRating").kendoAutoComplete().data("kendoAutoComplete");
        //OverallPlantRatingRating.wrapper.find(".k-input").css("background-color", view.objFacilityRating().OverallPlantRatingRatingColor());
        //OverallPlantRatingRating.wrapper.find(".k-input").parent().css("background-color", view.objFacilityRating().OverallPlantRatingRatingColor());

        //// KEY COLORS
        $("#RatingKeyColor1").css("background-color", view.objFacilityRating().RatingKeyColor1());
        $("#RatingKeyColor2").css("background-color", view.objFacilityRating().RatingKeyColor2());
        $("#RatingKeyColor3").css("background-color", view.objFacilityRating().RatingKeyColor3());
        $("#RatingKeyColor4").css("background-color", view.objFacilityRating().RatingKeyColor4());
        $("#RatingKeyColor5").css("background-color", view.objFacilityRating().RatingKeyColor5());

        //// DATES
        var InspectionDate = $("#InspectionDate").kendoDatePicker({
            value: view.objFacilityRating().InspectionDate(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        InspectionDate.wrapper
                .find(".k-picker-wrap").addClass("expand-padding inspectionDateInput").css("height", "13px").find(".k-select").hide();

        //// PHYSICAL ASSETS NUMERIC TEXTBOXES
        //// WEIGHT
        var MechEquipWeight = $("#MechEquipWeight").kendoNumericTextBox({
            value: view.objFacilityRating().MechEquipWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        MechEquipWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var ElecEquipWeight = $("#ElecEquipWeight").kendoNumericTextBox({
            value: view.objFacilityRating().ElecEquipWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ElecEquipWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var BoilersWeight = $("#BoilersWeight").kendoNumericTextBox({
            value: view.objFacilityRating().BoilersWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        BoilersWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var ProcEquipWeight = $("#ProcEquipWeight").kendoNumericTextBox({
            value: view.objFacilityRating().ProcEquipWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ProcEquipWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var OccupancyWeight = $("#OccupancyWeight").kendoNumericTextBox({
            value: view.objFacilityRating().OccupancyWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        OccupancyWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var CompSysWeight = $("#CompSysWeight").kendoNumericTextBox({
            value: view.objFacilityRating().CompSysWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        CompSysWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();

        //// PHYSICAL ASSETS RATINGS        
        var MechEquipC = $("#MechEquipC").kendoNumericTextBox({
            value: view.objFacilityRating().MechEquipC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        MechEquipC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        MechEquipC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechEquipCColor());
        //MechEquipC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().MechEquipCColor());
        var ElecEquipC = $("#ElecEquipC").kendoNumericTextBox({
            value: view.objFacilityRating().ElecEquipC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ElecEquipC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        ElecEquipC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecEquipCColor());
        //ElecEquipC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecEquipCColor());
        var BoilersC = $("#BoilersC").kendoNumericTextBox({
            value: view.objFacilityRating().BoilersC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        BoilersC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        BoilersC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BoilersCColor());
        //BoilersC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().BoilersCColor());
        var ProcEquipC = $("#ProcEquipC").kendoNumericTextBox({
            value: view.objFacilityRating().ProcEquipC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ProcEquipC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        ProcEquipC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ProcEquipCColor());
        //ProcEquipC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().ProcEquipCColor());
        var OccupancyC = $("#OccupancyC").kendoNumericTextBox({
            value: view.objFacilityRating().OccupancyC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        OccupancyC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        OccupancyC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().OccupancyCColor());
        //OccupancyC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().OccupancyCColor());
        var CompSysC = $("#CompSysC").kendoNumericTextBox({
            value: view.objFacilityRating().CompSysC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        CompSysC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        CompSysC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().CompSysCColor());
        //CompSysC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().CompSysCColor());
        var MechEquipWR = $("#MechEquipWR").kendoNumericTextBox({
            value: view.objFacilityRating().MechEquipWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        MechEquipWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        MechEquipWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechEquipWRColor());
        //MechEquipWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().MechEquipWRColor());
        var ElecEquipWR = $("#ElecEquipWR").kendoNumericTextBox({
            value: view.objFacilityRating().ElecEquipWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ElecEquipWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        ElecEquipWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecEquipWRColor());
        //ElecEquipWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecEquipWRColor());
        var BoilersWR = $("#BoilersWR").kendoNumericTextBox({
            value: view.objFacilityRating().BoilersWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        BoilersWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        BoilersWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BoilersWRColor());
        //BoilersWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().BoilersWRColor());
        var ProcEquipWR = $("#ProcEquipWR").kendoNumericTextBox({
            value: view.objFacilityRating().ProcEquipWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ProcEquipWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        ProcEquipWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ProcEquipWRColor());
        //ProcEquipWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().ProcEquipWRColor());
        var OccupancyWR = $("#OccupancyWR").kendoNumericTextBox({
            value: view.objFacilityRating().OccupancyWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        OccupancyWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        OccupancyWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().OccupancyWRColor());
        //OccupancyWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().OccupancyWRColor());
        var CompSysWR = $("#CompSysWR").kendoNumericTextBox({
            value: view.objFacilityRating().CompSysWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        CompSysWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        CompSysWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().CompSysWRColor());
        //CompSysWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().CompSysWRColor());

        //// ACTIVE NUMERIC BOXES
        var MechMaintWeight = $("#MechMaintWeight").kendoNumericTextBox({
            value: view.objFacilityRating().MechMaintWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        MechMaintWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        var ElecMaintWeight = $("#ElecMaintWeight").kendoNumericTextBox({
            value: view.objFacilityRating().ElecMaintWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ElecMaintWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        var SparesWeight = $("#SparesWeight").kendoNumericTextBox({
            value: view.objFacilityRating().SparesWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        SparesWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        var HumanElementWeight = $("#HumanElementWeight").kendoNumericTextBox({
            value: view.objFacilityRating().HumanElementWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        HumanElementWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        var BCPWeight = $("#BCPWeight").kendoNumericTextBox({
            value: view.objFacilityRating().BCPWeight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        BCPWeight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        var MechMaintC = $("#MechMaintC").kendoNumericTextBox({
            value: view.objFacilityRating().MechMaintC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        MechMaintC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        MechMaintC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechMaintCColor());
        //MechMaintC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().MechMaintCColor());
        var ElecMaintC = $("#ElecMaintC").kendoNumericTextBox({
            value: view.objFacilityRating().ElecMaintC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ElecMaintC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        ElecMaintC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecMaintCColor());
        //ElecMaintC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecMaintCColor());
        var SparesC = $("#SparesC").kendoNumericTextBox({
            value: view.objFacilityRating().SparesC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        SparesC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        SparesC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().SparesCColor());
        //SparesC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().SparesCColor());
        var HumanElementC = $("#HumanElementC").kendoNumericTextBox({
            value: view.objFacilityRating().HumanElementC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        HumanElementC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        HumanElementC.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().HumanElementCColor());
        //HumanElementC.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().HumanElementCColor());
        var Bcpc = $("#BCPC").kendoNumericTextBox({
            value: view.objFacilityRating().Bcpc(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Bcpc.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        Bcpc.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BCPCColor());
        //Bcpc.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().BCPCColor());
        var MechMaintWR = $("#MechMaintWR").kendoNumericTextBox({
            value: view.objFacilityRating().MechMaintWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        MechMaintWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        MechMaintWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().MechMaintWRColor());
        //MechMaintWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().MechMaintWRColor());
        var ElecMaintWR = $("#ElecMaintWR").kendoNumericTextBox({
            value: view.objFacilityRating().ElecMaintWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ElecMaintWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        ElecMaintWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().ElecMaintWRColor());
        //ElecMaintWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().ElecMaintWRColor());
        var SparesWR = $("#SparesWR").kendoNumericTextBox({
            value: view.objFacilityRating().SparesWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        SparesWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        SparesWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().SparesWRColor());
        //SparesWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().SparesWRColor());
        var HumanElementWR = $("#HumanElementWR").kendoNumericTextBox({
            value: view.objFacilityRating().HumanElementWR(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        HumanElementWR.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        HumanElementWR.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().HumanElementWRColor());
        //HumanElementWR.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().HumanElementWRColor());
        var Bcpwr = $("#BCPWR").kendoNumericTextBox({
            value: view.objFacilityRating().Bcpwr(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Bcpwr.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPickerBoiler").css("height", "13px").find(".k-select").hide();
        Bcpwr.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().BCPWRColor());
        //Bcpwr.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().BCPWRColor());

        //// SUMMARY AND TOTAL NUMERIC TEXT BOXES
        var PassiveC = $("#PassiveC").kendoNumericTextBox({
            value: view.objFacilityRating().PassiveC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        PassiveC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();
        var PassiveWC = $("#PassiveWC").kendoNumericTextBox({
            value: view.objFacilityRating().PassiveWC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        PassiveWC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
        var ActiveC = $("#ActiveC").kendoNumericTextBox({
            value: view.objFacilityRating().ActiveC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ActiveC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
        var ActiveWC = $("#ActiveWC").kendoNumericTextBox({
            value: view.objFacilityRating().ActiveWC(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        ActiveWC.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();

        $('#tabStrip').kendoTabStrip({
            open: { effects: "expand:vertical fadeIn", duration: 333 }
        });

        $("#tabLocDetailsLoading").hide(function () {
            $("#tabLocDetailsContainerInside").show();
        });
        var tabLocDetails = $("#tabStrip").data('kendoTabStrip');
        tabLocDetails.select(0);
        //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
        view.setupFindFields();
        view.resetPickers();
    });
</script>

</asp:Content>
