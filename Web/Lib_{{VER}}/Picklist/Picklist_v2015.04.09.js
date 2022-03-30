/** 
PICKLIST = utilPicklist
VERSION: 2015.04.09.001
A Helper class to assist with creating pick lists.
 
*** REQUIREMENTS: JQuery ***

INSTRUCTIONS: To use this class there must be five steps in place. To make use of the intellisense, please add this file to your _references.js file.

1)  Build an HTML structure to hold the picklist window.
    Example:
    <div id="windowPickList" class="pickListWindow">
        <div class="pickListHeader"><label>Check the items to show.</label></div>
        <div class="pickListContent">
            <div id="windowPickList_Loading" class="pickListLoading"> <!-- MUST USE Name_Loading NAMING FORMAT FOR ID -->
                <img src="../Images/Other/loading_2x.gif" class="pickListLoadingImage" />
            </div>
            <div id="windowPickList_Table" class="pickListTable"></div> <!-- MUST USE Name_Table NAMING FORMAT FOR ID -->
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

2)  Add styles to control the look of the picklist.
    Example:
    .pickListWindow { display: none; }
    .pickListHeader { text-align: center; padding-bottom: 4px; }
    .pickListFooter { padding-top: 8px; text-align: center; }
    .pickListTable { }
    .pickListContent { height: 315px; overflow-y: scroll; border: 1px solid #CCCCCC; padding: 0px; margin: 0px; }
    .pickListLoading { position: fixed; top: inherit; left: inherit; opacity: 0.8; background: #FFFFFF; }
    .pickListLoadingImage { border: none; margin-left: 125px;  margin-top: 110px; height: 32px;  width: 32px; }
    .pickListButton { min-width: 75px; }
    .pickListItem { padding-top: 2px; padding-bottom: 2px; padding-left: 4px; }
    .pickListItemLabel { }
    .pickListItemLabel:hover { text-decoration: underline; }

3)  Bind all events in the picklist structure in step 2 to functions in your MVVM.
    They can be hooked up to functions in the utilPicklist helper class.
**/

function utilPicklist() {
    this._pickListDOM = "";
    this._messageDOM = "";
    this._messageDOMContainer = null;
    this._data = null; // ANY DATA WITH AN ID FIELD CALLED WHAT IS STORED IN optionsConstant.fieldNameId
    this._collPickList = new Array(); // TEMPLATE = { field: "", countEQ: 0, countNEQ: 0, list: [{  id: 0, checked: bool, operator: "", value: "", field: ""  }] }
    this.pickList = null;
    this.currentFilterObject = { filters: [], logic: "" };
    this.currentFilterField = "";
    this.currentPickListField = "";
    this.currentPickListIndex = null;
    this.currentPickListType = null;

    /// An object for holding constant options that persist across rebuilds
    this.optionsConstant = {
        fieldNameId: "Id",
        ignoreBlanks: false
    };

    /// An object used for testing
    this.test = {
        consoleLogging: true
    };


    /// Initialize the picklist
    /// pPickListDOM (STRING) Id of the DIV where the picklist will be in HTML. Format requires # at beginning. REQUIRED
    this.initPickList = function (pPickListDOM, pMessageDOM, pData, pMessageDOMContainer) {
        //var zParent = this;
        try {
            this._pickListDOM = pPickListDOM;
            this._messageDOM = pMessageDOM;
            if (pMessageDOMContainer) {
                this._messageDOMContainer = pMessageDOMContainer;
            }
            this._data = pData;
            this.pickList = $("#" + pPickListDOM);
            this.pickList.kendoWindow({
                visible: false,
                modal: false,
                draggable: true,
                resizable: false,
                width: "300px",
                height: "425px",
                title: "Map Pin Pick List",
                actions: ["close"],
                animation: { open: { effects: "default" }, close: { effects: "default" } },
                refresh: function () {
                    this.center();
                }
            });
            this._setupEvents();
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Reset and empty the picklists
    this.resetPicklist = function (pData) {
        try {
            this._data = pData;
            this._collPickList = new Array();
            //this.pickList = null;
            this.currentFilterObject = { filters: [], logic: "" };
            this.currentFilterField = "";
            this.currentPickListField = "";
            this.currentPickListIndex = null;
            this.currentPickListType = null;
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Setup the options objects for the picklist
    this.setupOptions = function () {
        try {
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Setup related events to the picklist
    this._setupEvents = function () {
        try {
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Build the picklist window, object, and collections
    /// pField (STRING) The name of the column "field" that the picklist will reference. REQUIRED
    this._setupPickList = function (pField) {
        //var zParent = this;
        try {
            // SETUP PICKLIST
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Items").hide(1);
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Table").html("");
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Loading").show(1);
            this.pickList.data("kendoWindow").close();
            $(".k-animation-container").slideUp(250);
            this.pickList.data("kendoWindow").center().open();
            $("#" + this._pickListDOM).css("display", "block");

            // BUILD UNIQUE LIST OF ITEMS AND APPLY APPROPRIATE TYPE
            var zUniqueList = new Array();
            if (!this.optionsConstant.ignoreBlanks) { zUniqueList.push(""); }
            var zType = null;
            for (i = 0; i < this._data.length; i++) {
                var zValue = this._data[i][pField];
                zType = typeof zValue;
                if (zValue != undefined && zValue != null) {
                    switch (zType) {
                        case "string":
                            if ($.inArray(zValue, zUniqueList) == -1) {
                                zUniqueList.push(zValue);
                                this.currentPickListType = "string";
                            }
                            break;
                        case "number":
                            if ($.inArray(zValue, zUniqueList) == -1) {
                                zUniqueList.push(zValue);
                                this.currentPickListType = "number";
                            }
                            break;
                        case "boolean":
                            if (zValue) {
                                if ($.inArray("Yes", zUniqueList) == -1) {
                                    zUniqueList.push("Yes");
                                    this.currentPickListType = "boolean";
                                }
                            } else {
                                if ($.inArray("No", zUniqueList) == -1) {
                                    zUniqueList.push("No");
                                    this.currentPickListType = "boolean";
                                }
                            }
                            break;
                        case "object":
                            if (typeof zValue.getMonth == "function") {
                                if ($.inArray(this._formatSortableDate(zValue), zUniqueList) == -1) {
                                    zUniqueList.push(this._formatSortableDate(zValue));
                                    this.currentPickListType = "date";
                                }
                            } else {
                                if ($.inArray(zValue, zUniqueList) == -1) {
                                    zUniqueList.push(zValue);
                                    this.currentPickListType = "object";
                                }
                            }
                            break;
                        default:
                            if ($.inArray(zValue, zUniqueList) == -1) {
                                zUniqueList.push(zValue);
                                this.currentPickListType = "unknown";
                            }
                            break;
                    }
                }
            }

            // SORT THE UNIQUE LIST OF ITEMS
            zUniqueList.sort();

            // IF IT IS A DATE FIELD, REFORMAT THE STRINGS SO THEY ARE READABLE
            if (this.currentPickListType == "date") {
                for (i = 0; i < zUniqueList.length; i++) {
                    zUniqueList[i] = this._formatShortDateWithMonth(zUniqueList[i]);
                }
            }

            // LOOK FOR AN EXISTING LIST
            this.currentPickListField = pField;
            var zFound = false;
            var zFoundIndex = 0;
            for (i = 0; i < this._collPickList.length; i++) {
                if (this._collPickList[i].field == this.currentPickListField) {
                    zFound = true;
                    zFoundIndex = i;
                    break;
                }
            }

            // PUSH LIST TO DISPLAY
            if (zFound) {
                for (i = 0; i < this._collPickList[zFoundIndex].list.length; i++) {
                    var zObj = this._collPickList[zFoundIndex].list[i];
                    if (!zObj.checked) {
                        $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Table").append('<div class="pickListItem"><label><input type="checkbox" value="' + zObj.checked + '" id="' + zObj.id + '" name="' + zObj.value + '" onclick="globalPickListStandAloneCheck(\'' + zObj.field + '\',' + zObj.id + ',\'' + this._pickListDOM + '\');" /><span class="pickListItemLabel">' + zObj.value + '</span></label></div>');
                    } else {
                        $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Table").append('<div class="pickListItem"><label><input type="checkbox" value="' + zObj.checked + '" checked="' + zObj.checked + '" id="' + zObj.id + '" name="' + zObj.value + '" onclick="globalPickListStandAloneCheck(\'' + zObj.field + '\',' + zObj.id + ',\'' + this._pickListDOM + '\');" /><span class="pickListItemLabel">' + zObj.value + '</span></label></div>');
                    }
                }
            } else {
                var zArray = new Array();
                for (i = 0; i < zUniqueList.length; i++) {
                    zArray.push({ id: i, checked: true, operator: "eq", value: zUniqueList[i], field: pField });
                    $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Table").append('<div class="pickListItem"><label><input type="checkbox" value="' + true + '" checked="' + true + '" id="' + i + '" name="' + zUniqueList[i] + '" onclick="globalPickListStandAloneCheck(\'' + pField + '\',' + i + ',\'' + this._pickListDOM + '\');" /><span class="pickListItemLabel">' + zUniqueList[i] + '</span></label></div>');
                }
                this._collPickList.push({ field: pField, list: zArray });
                zFoundIndex = this._collPickList.length - 1;
            }
            this.currentPickListIndex = zFoundIndex;
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Items").show(1);
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Loading").fadeOut(250);
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Opens and sets up the picklist
    this.pickListOpen = function (pField) {
        this._setupPickList(pField);
    };


    /// Unchecks all of the checkboxes in the picklist and picklist collection.
    this.pickListCheckNone = function () {
        //var zParent = this;
        try {
            for (x = 0; x < this._collPickList[this.currentPickListIndex].list.length; x++) {
                this._collPickList[this.currentPickListIndex].list[x].checked = false;
                this._collPickList[this.currentPickListIndex].list[x].operator = "neq";
            }
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Table").find(":checkbox").prop("checked", false);
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Checks all of the checkboxes in the picklist and picklist collection.
    this.pickListCheckAll = function () {
        //var zParent = this;
        try {
            for (x = 0; x < this._collPickList[this.currentPickListIndex].list.length; x++) {
                this._collPickList[this.currentPickListIndex].list[x].checked = true;
                this._collPickList[this.currentPickListIndex].list[x].operator = "eq";
            }
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Table").find(":checkbox").prop("checked", true);
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Processes a check or uncheck on a specific field. Advised to use as an event call or data-bind call.
    this.pickListCheck = function (pField, pId) {
        //var zParent = this;
        try {
            for (x = 0; x < this._collPickList[this.currentPickListIndex].list.length; x++) {
                if (this._collPickList[this.currentPickListIndex].list[x].id == pId) {
                    if (this._collPickList[this.currentPickListIndex].list[x].checked) {
                        this._collPickList[this.currentPickListIndex].list[x].checked = false;
                        this._collPickList[this.currentPickListIndex].list[x].operator = "neq";
                    } else {
                        this._collPickList[this.currentPickListIndex].list[x].checked = true;
                        this._collPickList[this.currentPickListIndex].list[x].operator = "eq";
                    }
                    break;
                }
            }
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Reverses all of the current checked and unchecked items in the picklist and picklist collection..
    this.pickListCheckReverse = function () {
        //var zParent = this;
        try {
            for (x = 0; x < this._collPickList[this.currentPickListIndex].list.length; x++) {
                if (this._collPickList[this.currentPickListIndex].list[x].checked) {
                    this._collPickList[this.currentPickListIndex].list[x].checked = false;
                    this._collPickList[this.currentPickListIndex].list[x].operator = "neq";
                } else {
                    this._collPickList[this.currentPickListIndex].list[x].checked = true;
                    this._collPickList[this.currentPickListIndex].list[x].operator = "eq";
                }
            }
            $("#" + this._pickListDOM + " #" + this._pickListDOM + "_Table").find(":checkbox").each(function () {
                if ($(this).is(":checked")) {
                    $(this).removeAttr("checked");
                    $(this).prop("value", "false");
                } else {
                    $(this).prop("checked", true);
                    $(this).prop("value", "true");
                }
            });
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Cancels the picklist actions and closes the picklist window.
    this.pickListCancel = function () {
        //var zParent = this;
        try {
            this.pickList.data("kendoWindow").close();
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Applies all currently checked or unchecked picklist items to the filter JSON object.
    this.pickListApplyFilter = function () {
        //var zParent = this;
        try {
            // BUILD THE FILTER OBJECT
            var zFilter = { logic: "and", filters: [] };
            var zFilterEQ = { logic: "and", filters: [] }; //var zFilterEQ = { logic: "or", filters: [] };
            var zFilterNEQ = { logic: "and", filters: [] };
            this._collPickList[this.currentPickListIndex].countEQ = 0;
            this._collPickList[this.currentPickListIndex].countNEQ = 0;
            for (x = 0; x < this._collPickList[this.currentPickListIndex].list.length; x++) {
                var zField = this._collPickList[this.currentPickListIndex].list[x].field;
                var zOperator = this._collPickList[this.currentPickListIndex].list[x].operator;
                var zValue = null;
                switch (this.currentPickListType) {
                    case "string":
                        zValue = this._collPickList[this.currentPickListIndex].list[x].value;
                        break;
                    case "number":
                        if (this._collPickList[this.currentPickListIndex].list[x].value == undefined || this._collPickList[this.currentPickListIndex].list[x].value == null || this._collPickList[this.currentPickListIndex].list[x].value == 0) {
                            zValue = null
                        } else {
                            zValue = this._collPickList[this.currentPickListIndex].list[x].value;
                        }
                        break;
                    case "boolean":
                        if (this._collPickList[this.currentPickListIndex].list[x].value == undefined || this._collPickList[this.currentPickListIndex].list[x].value == null || this._collPickList[this.currentPickListIndex].list[x].value == 0) {
                            zValue = null;
                        } else {
                            zValue = this._collPickList[this.currentPickListIndex].list[x].value;
                            if (zValue.toLowerCase() == "yes") { zValue = true; } else if (zValue.toLowerCase() == "no") { zValue = false; }
                        }
                        break;
                    case "date":
                        if (this._collPickList[this.currentPickListIndex].list[x].value != undefined && this._collPickList[this.currentPickListIndex].list[x].value != null && this._collPickList[this.currentPickListIndex].list[x].value != "") {
                            zValue = Date.parse(this._collPickList[this.currentPickListIndex].list[x].value);
                            //zValue = Date.parse(this._collPickList[this.currentPickListIndex].list[x].value).toString();
                            //zValue = this._collPickList[this.currentPickListIndex].list[x].value;
                            //zValue = new Date(this._collPickList[this.currentPickListIndex].list[x].value);
                            if (zValue == "Invalid Date") { zValue = null; }
                        } else {
                            zValue = null;
                        }
                        break;
                    case "object":
                        zValue = this._collPickList[this.currentPickListIndex].list[x].value;
                        break;
                    default:
                        zValue = this._collPickList[this.currentPickListIndex].list[x].value;
                        break;
                }

                if (this._collPickList[this.currentPickListIndex].list[x].operator == "eq") {
                    zFilterEQ.filters.push({ field: zField, operator: zOperator, value: zValue });
                    this._collPickList[this.currentPickListIndex].countEQ++;
                } else {
                    zFilterNEQ.filters.push({ field: zField, operator: zOperator, value: zValue });
                    this._collPickList[this.currentPickListIndex].countNEQ++;
                }
            }
            if (this._collPickList[this.currentPickListIndex].countEQ < this._collPickList[this.currentPickListIndex].countNEQ) {
                if (zFilterEQ.filters.length > 0) { zFilter.filters.push(zFilterEQ); }
            } else {
                if (zFilterNEQ.filters.length > 0) { zFilter.filters.push(zFilterNEQ); }
            }
            this.setFilterPicklist(zFilter, this.currentPickListField);

            // SET THE CURRENT FILTER FIELD
            this.currentFilterField = this.currentPickListField;

            //this.pickList.data("kendoWindow").close();
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// Builds and sets a custom filter object to the filter JSON object based on a picklist style filter, one field at a time.
    /// pFilter (JSON OBJECT) A kendo formatted filter object. REQUIRED
    /// pField (STRING) A string representing the field name included in the filter. REQUIRED
    this.setFilterPicklist = function (pFilter, pField) {
        //var zParent = this;

        try {
            // SET THE FILTER OBJECT TO A PUBLIC AREA FOR USE
            //this.currentFilterObject = pFilter;
            // LOOK FOR THE FIELD WE ARE WORKING WITH AND REMOVE THEM
            // AND ADD THE NEW FILTER OBJECT TO THE EXISTING FILTER COLLECTION
            var zFound = false;
            var zFilter = this.currentFilterObject;
            if (zFilter != undefined) {
                if (zFilter.filters != undefined) {
                    for (x = 0; x < zFilter.filters.length; x++) {
                        if (zFilter.filters[x].filters != undefined && zFound == false) {
                            for (y = 0; y < zFilter.filters[x].filters.length; y++) {
                                if (zFilter.filters[x].filters[y].field != undefined && zFound == false) {
                                    if (zFilter.filters[x].filters[y].field == pField && zFound == false) {
                                        zFilter.filters.splice(x, 1);
                                        zFound = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                // IF AN EXSISTING STANDARD FILTER EXISTS AS AN OR, ADD IT AS A SUB FILTER SECONDARY TO THE PICKLIST
                // ELSE ADD THE COMBINED FILTERS TOGETHER AND SUBMIT IT TO THE FILTER JSON OBJECT
                if (zFilter.logic != undefined && zFilter.logic.toLowerCase() == "or") {
                    var zNewFilter = { filters: [], logic: "and" };
                    zNewFilter.filters.push(zFilter);
                    if (pFilter.filters.length > 0) {
                        zNewFilter.filters.push(pFilter.filters[0]);
                    }
                    zFilter = zNewFilter;
                } else {
                    if (pFilter.filters.length > 0) {
                        zFilter.filters.push(pFilter.filters[0]);
                    }
                }
                this.currentFilterObject = zFilter;
            } else {
                this.currentFilterObject = pFilter;
            }
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };


    /// A function to clear the picklist object.
    this.clearPickListFilter = function () {
        this._collPickList = new Array(); // TEMPLATE = { field: "", countEQ: 0, countNEQ: 0, list: [{  id: 0, checked: bool, operator: "", value: "", field: ""  }] }
        this.currentFilterObject = { filters: [], logic: "" };
        this.currentFilterField = "";
        this.currentPickListField = "";
        this.currentPickListIndex = null;
        this.currentPickListType = null;
    };


    /// Returns a readable string of the filtered fields in the picklist.
    this.getFilterString = function () {
        var zReturn = "";
        try {

            if (this.currentFilterObject.filters != undefined && this.currentFilterObject.filters != null) {
                for (x = 0; x < this.currentFilterObject.filters.length; x++) {
                    if (this.currentFilterObject.filters[x].filters != undefined && this.currentFilterObject.filters[x].filters != null) {
                        for (y = 0; y < this.currentFilterObject.filters[x].filters.length; y++) {
                            var zOperator = "";
                            var zLogic = this.currentFilterObject.filters[x].logic;
                            var zField = this.currentFilterObject.filters[x].filters[y].field;
                            switch (this.currentFilterObject.filters[x].filters[y].operator.toLowerCase()) {
                                case "eq": zOperator = " to be equal to "; break;
                                case "neq": zOperator = " to not be equal to "; break;
                                case "lt": zOperator = " to be less than "; break;
                                case "lte": zOperator = " to be less than or equal to "; break;
                                case "gt": zOperator = " to be greater than "; break;
                                case "gte": zOperator = " to be greater than or equal to "; break;
                                case "startswith": zOperator = " to start with "; break;
                                case "endswith": zOperator = " to end with "; break;
                                case "contains": zOperator = " to contain "; break;
                                default: zOperator = " is "; break;
                            }
                            var zValue = this.currentFilterObject.filters[x].filters[y].value;
                            var zType = typeof this.currentFilterObject.filters[x].filters[y].value;
                            if (zType = "function") {
                                if (zValue != null && typeof zValue.getMonth == "function") {
                                    zValue = this._formatShortDateWithMonth(zValue);
                                }
                            }
                            if (y == 0) {
                                if (x == 0) {
                                    zReturn = zReturn + "On " + zField + zOperator + "[" + zValue + "]";
                                } else {
                                    zReturn = zReturn + "; " + zLogic + " on " + zField + zOperator + "[" + zValue + "]";
                                }
                            } else {
                                zReturn = zReturn + ", " + "[" + zValue + "]";
                            }
                        }
                    } else {
                        var zOperator = "";
                        var zLogic = this.currentFilterObject.filters.logic;
                        var zField = this.currentFilterObject.filters[x].field;
                        switch (this.currentFilterObject.filters[x].operator.toLowerCase()) {
                            case "eq": zOperator = " to be equal to "; break;
                            case "neq": zOperator = " to not be equal to "; break;
                            case "lt": zOperator = " to be less than "; break;
                            case "lte": zOperator = " to be less than or equal to "; break;
                            case "gt": zOperator = " to be greater than "; break;
                            case "gte": zOperator = " to be greater than or equal to "; break;
                            case "startswith": zOperator = " to start with "; break;
                            case "endswith": zOperator = " to end with "; break;
                            case "contains": zOperator = " to contain "; break;
                            default: zOperator = " is "; break;
                        }
                        var zValue = this.currentFilterObject.filters[x].value;
                        var zType = typeof this.currentFilterObject.filters[x].value;
                        if (zType = "function") {
                            if (zValue != null && typeof zValue.getMonth == "function") {
                                zValue = this._formatShortDateWithMonth(zValue);
                            }
                        }
                        if (x == 0) {
                            zReturn = zReturn + "On " + zField + zOperator + "[" + zValue + "]";
                        } else {
                            zReturn = zReturn + "; " + zLogic + " on " + zField + zOperator + "[" + zValue + "]";
                        }
                    }
                }
            }


        } catch (pException) {
            this.processMessage(pException.message);
        }
        return zReturn;
    };


    /// A funciton that converts a date into a string with abbreviated months
    /// Example: 31-Jan-2099
    /// pDate (DATE) the date to format
    this._formatShortDateWithMonth = function (pDate) {
        var zReturn = "";
        var zMonthArray = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
        try {
            if (pDate != null && pDate != undefined) {
                if (new Date(pDate) == "Invalid Date") {
                    var zDate = new Date(pDate.replace(/^(....).(..).(.{11}).*$/, "$1/$2/$3"));
                    var zMonth = zMonthArray[zDate.getMonth()];
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zDay.toString() + "-" + zMonth.toString() + "-" + zYear.toString();
                } else {
                    var zDate = new Date(pDate);
                    var zMonth = zMonthArray[zDate.getMonth()];
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zDay.toString() + "-" + zMonth.toString() + "-" + zYear.toString();
                }
            }
        } catch (pError) {
            zReturn = "";
        }
        return zReturn;
    };


    /// A funciton that converts a date into a string that is numerically sortable
    /// Example: 2099/1/31
    /// pDate (DATE) the date to format
    this._formatSortableDate = function (pDate) {
        var zReturn = "";
        try {
            if (pDate != null && pDate != undefined) {
                if (new Date(pDate) == "Invalid Date") {
                    var zDate = new Date(pDate.replace(/^(....).(..).(.{11}).*$/, "$1/$2/$3"));
                    var zMonth = zDate.getMonth() + 1;
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    if (zMonth < 10) { zMonth = "0" + zMonth.toString(); } else { zMonth = zMonth.toString(); }
                    if (zDay < 10) { zDay = "0" + zDay.toString(); } else { zDay = zDay.toString(); }
                    zReturn = "" + zYear.toString() + "/" + zMonth + "/" + zDay;
                } else {
                    var zDate = new Date(pDate);
                    var zMonth = zDate.getMonth() + 1;
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    if (zMonth < 10) { zMonth = "0" + zMonth.toString(); } else { zMonth = zMonth.toString(); }
                    if (zDay < 10) { zDay = "0" + zDay.toString(); } else { zDay = zDay.toString(); }
                    zReturn = "" + zYear.toString() + "/" + zMonth + "/" + zDay;
                }
            }
        } catch (pError) {
            zReturn = "";
        }
        return zReturn;
    };


    /// A function to display a message to the user
    this.processMessage = function (pMessage) {
        //var zParent = this;
        try {
            this.clearMessage();
            if (this._messageDOMContainer !== undefined || this._messageDOMContainer !== null || this._messageDOMContainer.length > 0) {
                $("#" + this._messageDOMContainer).slideDown();
            }
            if (this._messageDOM === undefined || this._messageDOM === null || this._messageDOM.length < 1) {
                alert("Message: " + pMessage);
            } else {
                var zTimeShort = 250;
                var zTimeLong = 1500;
                $("#" + this._messageDOM).html(pMessage);
                $("#" + this._messageDOM).parent().show().effect("highlight", zTimeShort, function () {
                    $("#" + this._messageDOM).parent().show().effect("highlight", zTimeLong);
                });
            }
            if (this.test.consoleLogging) {
                if (typeof console != "undefined") {
                    console.log("****************** Message Processor ****");
                    console.log("Message : " + pMessage);
                }
            }
        } catch (pException) {
            alert("Error when processing message " + pMessage + ": " + pException.message);
        }
    };


    /// A function to display a message to the user
    this.clearMessage = function () {
        //var zParent = this;
        try {
            if (this._messageDOMContainer !== undefined || this._messageDOMContainer !== null || this._messageDOMContainer.length > 0) {
                $("#" + this._messageDOMContainer).slideUp();
            }
            $("#" + this._messageDOM).html("");
        } catch (pException) {
            this.processMessage(pException.message);
        }
    };

};