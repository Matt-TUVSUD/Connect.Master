/** 
GRC KENDO GRID = utilKendoGrid
VERSION: 2017.05.22 001
A Helper class to assist with Kendo grids.  Including picklists and an edit mode.
 
*** REQUIREMENTS: Kendo v2014 or above and all of it's required scripts and styles, JQuery v1.11, JQueryUI v1.11, knockout.js, date.js, font-awesome.min.css ***

INSTRUCTIONS: To use this class there must be five steps in place. To make use of the intellisense, please add this file to your _references.js file.

1)  Build an HTML structure to hold the grid including a wrapping container.
    Example:
    <div id="gridNameContainer">
        <div id="gridName"></div>
    </div>

2)  Build an HTML structure to hold the picklist window.
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

3)  Add styles to control the look of the picklist.
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

4)  Bind all events in the picklist structure in step 2 to functions in your MVVM.
    They can be hooked up to functions in the utilKendoGrid helper class.

5)  Initialize the Kendo grid using the initGrid function to a local object in your MVVM.
    Example:
    view.myGrid = new utilKendoGrid();
    view.myGrid.setupOptions();
    view.myGrid.pickListIgnoreColumns = ["myColumn1", "myColumn2"];
    view.myGrid.initGrid("#gridName", "#gridNameContainer", "#pickListName", myData, mySchema, myColumns, false);

6)  Create a SQL view for the data that will be used in the grid.  
    The order of the items in your view will be the order of the items in the grid.

7)  Use entity spaces to generate Kendo Grid JS classes from the 
    SQL view created in step 6 and link them to the HTML.

8)  Create custom code for the generated Kendo Grid JS classes to supply custom information
    such as key field and field names.
**/

function utilKendoGrid() {
    this._gridDOM = "";
    this._gridContainerDOM = null;
    this._pickListDOM = "";
    this.grid = null;
    this.gSafeGuid = null;
    this.columnIndices = null;
    this.pickList = null;
    this.pickListIgnoreColumns = [];
    this._toolTipCellDetails = null;
    this.collPickList = new Array(); // TEMPLATE = { field: "", countEQ: 0, countNEQ: 0, list: [{  id: 0, checked: bool, operator: "", value: "", field: ""  }] }
    this.currentFilterField = "";
    this.currentPickListField = "";
    this.currentPickListIndex = null;
    this.currentPickListType = null;
    this.optionsTemplate_Editable = null;
    this.optionsTemplate_Picklist = null;
    this._isRebuildRequired = false;
    this._isAdjustScrollbarPositionRequired = false;
    this._isFirstLoad = true;
    this.rowHeight = 22;
    this.total = 0;
    this.filterString = "";
    this.sortString = "";
    this.lockedString = "";
    this.mapDepictedNameDefault = null;
    this.mapDepictedNameCurrent = null;

    // NAMED FIELDS
    this.fieldIsMappable = "fldMapIsDepictable";

    /// An object for holding constant options that persist across rebuilds
    this.optionsConstant = {
        changeFunction: null,
        height: null,
        heightOffset: null,
        heightMinimum: 485,
        isServerLoading: false,
        transportPickListAddress: "",
        transportReadAddress: "",
        transportStartFunction: null,
        transportCompleteFunction: null,
        setMapDepictableComplete: null,
        serverLoadingNodeNameData: "data",
        serverLoadingNodeNameTotal: "total",
        enableMenuRemove: false,
        enableMenuMap: true,
        enableMenuPickList: true,
        enableMenuMoveToFirst: true,
        enableMenuMoveToLast: true,
        enableMenuLocking: true,
        detailTemplate: null,
        criteriaFilter: null,
        serviceMethod: "POST", //CAN ONLY USE 'POST' or 'GET' as value
    };

    /// A template for the options object of the Kendo grid in edit mode.
    this.setOptionsTemplate_Editable = function () {
        var zParent = this;
        var zHeight = zParent._getAvailableHeight();
        var zReturn = {
            dataSource: {
                serverOperation: false,
                type: "odata",
                data: null,
                schema: null,
                pageSize: 100,
                change: zParent.optionsConstant.changeFunction
            },
            autoBind: false,
            dataBound: null,
            change: zParent.optionsConstant.changeFunction,
            height: zHeight,
            scrollable: true,
            reorderable: false,
            resizable: false,
            groupable: false,
            sortable: false,
            filterable: false,
            editable: true,
            selectable: true,
            navigatable: true,
            pageable: false,
            columns: null,
            columnMenu: false,
            altRowTemplate: null,
            detailTemplate: this.optionsConstant.detailTemplate
        }
        zParent.optionsTemplate_Editable = zReturn;
        return zReturn;
    };


    /// A template for the options object of the Kendo grid specialized for picklists.
    this.setOptionsTemplate_Picklist = function () {
        var zParent = this;
        var zHeight = zParent._getAvailableHeight();
        var zReturn = {
            dataSource: {
                serverOperation: false,
                type: "odata",
                data: null,
                schema: null,
                pageSize: 100,
                change: zParent.optionsConstant.changeFunction
            },
            autoBind: false,
            dataBound: null,
            change: zParent.optionsConstant.changeFunction,
            height: zHeight,
            scrollable: true,
            reorderable: true,
            resizable: true,
            groupable: false,
            sortable: {
                mode: "multiple",
                allowUnsort: true
            },
            filterable: true,
            editable: false,
            selectable: true,
            navigatable: true,
            pageable: {
                refresh: false,
                pageSizes: false,
                buttonCount: 10
            },
            columns: null,
            columnMenu: true,
            columnMenuInit: null,
            altRowTemplate: null,
            detailTemplate: this.optionsConstant.detailTemplate
        }
        zParent.optionsTemplate_Picklist = zReturn;
        return zReturn;
    };


    /// A template for the options object for server side loading
    this.setOptionsTemplate_ServerLoading = function () {
        var zParent = this;
        var zHeight = zParent._getAvailableHeight();
        var zReturn = {
            dataSource: {
                //serverOperation: true,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true,
                type: "json",
                schema: null,
                pageSize: 100,
                transport: {
                    read: {
                        //data: null,
                        url: this.optionsConstant.transportReadAddress,
                        dataType: "json",
                        type: "POST",
                        cache: false,
                        contentType: "application/json; charset=utf-8",
                        complete: function (pEvent, pStatus) {
                            kendo.ui.progress($(zParent._gridDOM), true);
                            // STORE ANY FILTER AND SORT STRINGS IF AVAILABLE
                            zParent.filterString = "";
                            zParent.sortString = "";
                            zParent.lockedString = "";
                            if (pEvent.responseJSON.filter) { zParent.filterString = pEvent.responseJSON.filter; }
                            if (pEvent.responseJSON.sort) { zParent.sortString = pEvent.responseJSON.sort; }
                            if (pEvent.responseJSON.pin) { zParent.lockedString = pEvent.responseJSON.pin; }
                            // SET GRID
                            if (Math.ceil(pEvent.responseJSON.total / zParent.grid.dataSource.pageSize()) < zParent.grid.dataSource.page()) {
                                if (zParent.grid.dataSource.page() > 1) {
                                    // PROTECT IF TOTAL ROWS FILLS LESS THAN PAGE NUMBER BEFORE DATA PULL, GO TO LAST PAGE
                                    setTimeout(function () {
                                        //zParent.grid.dataSource.page(Math.ceil(pEvent.responseJSON.total / zParent.grid.dataSource.pageSize())); // GO TO LAST PAGE
                                        zParent.grid.dataSource.page(1); // GO TO FIRST PAGE PER ALINA
                                    }, 100);
                                }
                            }
                            // FIX AUTO SCROLL POSITIONING
                            if (zParent._isAdjustScrollbarPositionRequired) {
                                zParent._isAdjustScrollbarPositionRequired = false;
                                // GET THE HEIGHT OF A ROW
                                zParent.rowHeight = $(zParent._gridDOM + " .k-grid-content").find("tr").height() + 1; // ADD EXTRA FOR BORDERS
                                // CORRECT THE VIRTUAL SCROLLBAR AFTER NAVIGATION BY PAGE BUTTON
                                var zScrollTop = 0;
                                var zScrollHeight = zParent.grid.virtualScrollable.verticalScrollbar[0].scrollHeight;
                                var zTotalPages = Math.ceil(zParent.grid.dataSource._total / zParent.grid.dataSource._pageSize);
                                var zScrollPageHeight = zScrollHeight / zTotalPages + 1;
                                var zOffset = zParent.grid.virtualScrollable.verticalScrollbar[0].offsetHeight;
                                var zPage = zParent.grid.dataSource.page();
                                if (zPage > 1) {
                                    var zPageScrollAmount = zParent.rowHeight * zParent.grid.dataSource.pageSize();
                                    zScrollTop = ((zPage - 1) * zPageScrollAmount) + zParent.rowHeight;
                                    zParent.grid.virtualScrollable.verticalScrollbar[0].scrollTop = zScrollTop;
                                } else {
                                    zScrollTop = 0;
                                    zParent.grid.virtualScrollable.verticalScrollbar[0].scrollTop = zScrollTop;
                                }
                            }
                            zParent.optionsConstant.transportCompleteFunction(pEvent, pStatus);
                            zParent._isFirstLoad = false;
                            kendo.ui.progress($(zParent._gridDOM), false);
                        },
                        beforeSend: function (pEvent) {
                            zParent.optionsConstant.transportStartFunction(pEvent);
                        }
                    },
                    create: null,
                    update: null,
                    destroy: null,
                    parameterMap: function (pData, pType) {
                        if (pType === "read") {
                            // ADD THE USER CURRENCY OVERRIDE TO THE SERVICE CALL
                            if (gCurrencyIdFromPrefilter) {
                                pData["pUserCurrencyId"] = gCurrencyIdFromPrefilter;
                            }
                            // ADD THE GSafeGUID TO THE SERVICE CALL
                            if (zParent.gSafeGuid) {
                                pData["gSafeGuid"] = zParent.gSafeGuid;
                            }
                            // STRINGIFY THE FILTER OBJECT
                            if (pData["filter"]) {
                                pData["filter"] = JSON.stringify(pData["filter"]);
                            }
                            // STRINGIFY THE SORT OBJECT
                            if (pData["sort"]) {
                                pData["sort"] = JSON.stringify(pData["sort"]);
                            }
                            // ADD CRITERIA IF PRESENT
                            if (zParent.optionsConstant.criteriaFilter) {
                                pData["criteria"] = JSON.stringify(zParent.optionsConstant.criteriaFilter);
                            }
                            // RESET THE PAGE COUNT TO CORRECT THE SIDE SCROLLBAR
                            if (zParent.grid !== null && zParent.grid.dataSource !== undefined && pData["page"] !== undefined) {
                                if (pData["page"] != zParent.grid.dataSource.page() && pData["page"] == 1) {
                                    pData["page"] = zParent.grid.dataSource.page();
                                }
                            }
                            return kendo.stringify(pData);
                        }
                    }
                },
                error: function (pEvent) {
                },
                change: function (pEvent) {
                    zParent.optionsConstant.changeFunction(pEvent);
                }
            },
            autoBind: true,
            dataBound: null,
            change: function (pEvent) {
                zParent.optionsConstant.changeFunction(pEvent);
            },
            height: zHeight,
            reorderable: true,
            resizable: true,
            groupable: false,
            sortable: {
                mode: "multiple",
                allowUnsort: true
            },
            scrollable: {
                virtual: true
            },
            selectable: true,
            navigatable: true,
            filterable: true,
            editable: false,
            pageable: {
                info: true,
                previousNext: true,
                input: false,
                refresh: true,
                pageSizes: false,
                buttonCount: 5
            },
            columns: null,
            columnMenu: true,
            columnMenuInit: null,
            altRowTemplate: null,
            detailTemplate: this.optionsConstant.detailTemplate
        }
        zParent.optionsTemplate_Picklist = zReturn;
        return zReturn;
    },


    /// A template for the options object for server side loading with a GET action
    this.setOptionsTemplate_ServerLoadingGET = function () {
        var zParent = this;
        var zHeight = zParent._getAvailableHeight();
        var zReturn = {
            dataSource: {
                //serverOperation: true,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true,
                type: "json",
                schema: {
                    data: "Data",
                    total: "Total"
                },
                pageSize: 100,
                transport: {
                    read: {
                        //data: null,
                        url: this.optionsConstant.transportReadAddress,
                        dataType: "json",
                        type: "GET",
                        cache: false,
                        contentType: "application/json; charset=utf-8",
                        complete: function (pEvent, pStatus) {
                            kendo.ui.progress($(zParent._gridDOM), true);
                            // STORE ANY FILTER AND SORT STRINGS IF AVAILABLE
                            zParent.filterString = "";
                            zParent.sortString = "";
                            zParent.lockedString = "";
                            if (pEvent.responseJSON.filter) { zParent.filterString = pEvent.responseJSON.filter; }
                            if (pEvent.responseJSON.sort) { zParent.sortString = pEvent.responseJSON.sort; }
                            if (pEvent.responseJSON.pin) { zParent.lockedString = pEvent.responseJSON.pin; }
                            // SET GRID
                            if (Math.ceil(pEvent.responseJSON.total / zParent.grid.dataSource.pageSize()) < zParent.grid.dataSource.page()) {
                                if (zParent.grid.dataSource.page() > 1) {
                                    // PROTECT IF TOTAL ROWS FILLS LESS THAN PAGE NUMBER BEFORE DATA PULL, GO TO LAST PAGE
                                    setTimeout(function () {
                                        //zParent.grid.dataSource.page(Math.ceil(pEvent.responseJSON.total / zParent.grid.dataSource.pageSize())); // GO TO LAST PAGE
                                        zParent.grid.dataSource.page(1); // GO TO FIRST PAGE PER ALINA
                                    }, 100);
                                }
                            }
                            // FIX AUTO SCROLL POSITIONING
                            if (zParent._isAdjustScrollbarPositionRequired) {
                                zParent._isAdjustScrollbarPositionRequired = false;
                                // GET THE HEIGHT OF A ROW
                                zParent.rowHeight = $(zParent._gridDOM + " .k-grid-content").find("tr").height() + 1; // ADD EXTRA FOR BORDERS
                                // CORRECT THE VIRTUAL SCROLLBAR AFTER NAVIGATION BY PAGE BUTTON
                                var zScrollTop = 0;
                                var zScrollHeight = zParent.grid.virtualScrollable.verticalScrollbar[0].scrollHeight;
                                var zTotalPages = Math.ceil(zParent.grid.dataSource._total / zParent.grid.dataSource._pageSize);
                                var zScrollPageHeight = zScrollHeight / zTotalPages + 1;
                                var zOffset = zParent.grid.virtualScrollable.verticalScrollbar[0].offsetHeight;
                                var zPage = zParent.grid.dataSource.page();
                                if (zPage > 1) {
                                    var zPageScrollAmount = zParent.rowHeight * zParent.grid.dataSource.pageSize();
                                    zScrollTop = ((zPage - 1) * zPageScrollAmount) + zParent.rowHeight;
                                    zParent.grid.virtualScrollable.verticalScrollbar[0].scrollTop = zScrollTop;
                                } else {
                                    zScrollTop = 0;
                                    zParent.grid.virtualScrollable.verticalScrollbar[0].scrollTop = zScrollTop;
                                }
                            }
                            zParent.optionsConstant.transportCompleteFunction(pEvent, pStatus);
                            zParent._isFirstLoad = false;
                            kendo.ui.progress($(zParent._gridDOM), false);
                        },
                        beforeSend: function (pEvent) {
                            zParent.optionsConstant.transportStartFunction(pEvent);
                        }
                    },
                    create: null,
                    update: null,
                    destroy: null,
                    parameterMap: function (pData, pType) {
                        if (pType === "read") {
                            // ADD THE USER CURRENCY OVERRIDE TO THE SERVICE CALL
                            // CHANGES HERE WILL BE DETERMINED BY HOW THE ENDPOINT IS STRUCTURED
                            if (gCurrencyIdFromPrefilter) {
                                pData["pUserCurrencyId"] = gCurrencyIdFromPrefilter;
                            }
                            // ADD THE GSafeGUID TO THE SERVICE CALL
                            // CHANGES HERE WILL BE DETERMINED BY HOW THE ENDPOINT IS STRUCTURED
                            if (zParent.gSafeGuid) {
                                pData["gSafeGuid"] = zParent.gSafeGuid;
                            }
                            // STRINGIFY THE FILTER OBJECT
                            if (pData["filter"]) {
                                pData["filter"] = JSON.stringify(pData["filter"]);
                            }
                            // STRINGIFY THE SORT OBJECT
                            if (pData["sort"]) {
                                pData["sort"] = JSON.stringify(pData["sort"]);
                            }
                            // ADD CRITERIA IF PRESENT
                            if (zParent.optionsConstant.criteriaFilter) {
                                pData["criteria"] = JSON.stringify(zParent.optionsConstant.criteriaFilter);
                            }
                            // RESET THE PAGE COUNT TO CORRECT THE SIDE SCROLLBAR
                            if (zParent.grid !== null && zParent.grid.dataSource !== undefined && pData["page"] !== undefined) {
                                if (pData["page"] != zParent.grid.dataSource.page() && pData["page"] == 1) {
                                    pData["page"] = zParent.grid.dataSource.page();
                                }
                            }
                            return kendo.stringify(pData);
                        }
                    }
                },
                error: function (pEvent) {
                },
                change: function (pEvent) {
                    zParent.optionsConstant.changeFunction(pEvent);
                }
            },
            autoBind: true,
            dataBound: null,
            change: function (pEvent) {
                zParent.optionsConstant.changeFunction(pEvent);
            },
            height: zHeight,
            reorderable: true,
            resizable: true,
            groupable: false,
            sortable: {
                mode: "multiple",
                allowUnsort: true
            },
            scrollable: {
                virtual: true
            },
            selectable: true,
            navigatable: true,
            filterable: true,
            editable: false,
            pageable: {
                info: true,
                previousNext: true,
                input: false,
                refresh: true,
                pageSizes: false,
                buttonCount: 5
            },
            columns: null,
            columnMenu: true,
            columnMenuInit: null,
            altRowTemplate: null,
            detailTemplate: this.optionsConstant.detailTemplate
        }
        zParent.optionsTemplate_Picklist = zReturn;
        return zReturn;
    },

    /// Initialize the Kendo grid helper class.
    /// pGridDOM (STRING) Id of the DIV where the grid will be in HTML. Format requires # at beginning. REQUIRED
    /// pGridContainerDOM (STRING) Id of the DIV surrounding the grid in HTML. Format requires # at beginning. REQUIRED
    /// pPickListDOM (STRING) Id of the DIV where the picklist will be in HTML. Format requires # at beginning. REQUIRED
    /// pData (JSON OBJECT) the data for the grid. REQUIRED
    /// pSchema (JSON OBJECT) The column schema for the grid. OPTIONAL
    /// pColumns (JSON OBJECT) The column list for the grid. OPTIONAL
    /// pIsEditMode (BOOLEAN) Indicating if the grid is in edit mode. OPTIONAL
    /// pSort (JSON OBJECT) object indicating pre-sort. OPTIONAL
    /// pFilter (JSON OBJECT) object indicating pre-filter. OPTIONAL
    /// pPage (JSON OBJECT) object indicating the page to be set. OPTIONAL
    /// pColumnIndices
    /// pColumnSources
    this.initGrid = function (pGridDOM, pGridContainerDOM, pPickListDOM, pData, pSchema, pColumns, pIsEditMode, pSort, pFilter, pPage, pColumnIndices, pColumnSources) {
        this._gridDOM = pGridDOM;
        this._gridContainerDOM = pGridContainerDOM;
        this._pickListDOM = pPickListDOM;
        this.columnIndices = pColumnIndices;
        this.columnSources = pColumnSources;
        this._setupGrid(this._gridDOM, pData, pSchema, pColumns, pIsEditMode, pSort, pFilter, pPage);
        this._initPickList(pPickListDOM);
        this._setupEvents();
    };


    /// Initialize the picklist for the Kendo grid.
    /// pPickListDOM (STRING) Id of the DIV where the picklist will be in HTML. Format requires # at beginning. REQUIRED
    this._initPickList = function (pPickListDOM) {
        var zParent = this;
        zParent.pickList = $(pPickListDOM);
        zParent.pickList.kendoWindow({
            visible: false,
            modal: false,
            draggable: true,
            resizable: false,
            width: "300px",
            height: "435px",
            modal: true,
            title: "Pick List",
            actions: ["close"],
            animation: { open: { effects: "default" }, close: { effects: "default" } },
            refresh: function () {
                this.center();
            }
        });
        //});
    };


    /// Setup the options objects for the grid
    this.setupOptions = function () {
        if (this.optionsConstant.isServerLoading) {
            //this.setOptionsTemplate_Editable();
            if (this.optionsConstant.serviceMethod == "POST") {
                this.setOptionsTemplate_ServerLoading();
            } else {
                this.setOptionsTemplate_ServerLoadingGET();
            }
        } else {
            this.setOptionsTemplate_Editable();
            this.setOptionsTemplate_Picklist();
        }
    };


    /// Build the Kendo grid and pass information to the grid settings.
    /// pGridDOM (STRING) Id of the DIV where the grid will be in HTML. Format requires # at beginning. REQUIRED
    /// pData (JSON OBJECT) the data for the grid. REQUIRED
    /// pSchema (JSON OBJECT) The column schema for the grid. OPTIONAL
    /// pColumns (JSON OBJECT) The column list for the grid. OPTIONAL
    /// pIsEditMode (BOOLEAN) Indicating if the grid is in edit mode. OPTIONAL
    /// pSort (JSON OBJECT) object indicating pre-sort. OPTIONAL
    /// pFilter (JSON OBJECT) object indicating pre-filter. OPTIONAL
    /// pPage (JSON OBJECT) object indicating the page to be set. OPTIONAL
    this._setupGrid = function (pGridDOM, pData, pSchema, pColumns, pIsEditMode, pSort, pFilter, pPage) {
        var zParent = this;
        var zOptions = null;
        if (pIsEditMode) {
            if (zParent.optionsConstant.isServerLoading) {
                if (zParent.optionsConstant.serviceMethod == "POST") {
                    zOptions = zParent.setOptionsTemplate_ServerLoading();
                } else {
                    zOptions = zParent.setOptionsTemplate_ServerLoadingGET();
                }
            } else {
                zOptions = zParent.setOptionsTemplate_Editable();
            }

            // HIGHLIGHT EDITABLE COLUMNS

            // BY COLUMN OBJECTS
            var zAllColumnNames = new Array();
            var zEditableColumnNames = new Array();
            for (var zProp in pSchema.model.fields) {
                if (pSchema.model.fields.hasOwnProperty(zProp)) {
                    zAllColumnNames.push(zProp);
                }
            }
            for (x = 0; x < zAllColumnNames.length; x++) {
                if (pSchema.model.fields[zAllColumnNames[x]].editable == true) {
                    zEditableColumnNames.push(zAllColumnNames[x]);
                }
            }
            for (x = 0; x < pColumns.length; x++) {
                for (y = 0; y < zEditableColumnNames.length; y++) {
                    if (pColumns[x].field == zEditableColumnNames[y]) {
                        // SET AN ATTRIBUTE AS A FLAG AND SET THE HEADER COLOR
                        pColumns[x].attributes = { "data-editable": "true" }; // THIS IS A FLAG TO CONTROL STYLES IN CELL WHEN IN EDIT MODE
                        //pColumns[x].headerAttributes = { style: "background-color: \\#FFF8A5;" }; // UNCOMMENT THIS LINE TO CHANGE THE HEADER ATTRIBUTES IN EDIT MODE
                        break;
                    }
                }
            }

        } else {
            // CORRECTION: PREVENT FILTER MENU MOUSE LEAVE AUTO CLOSE
            var zTimeToCloseFilterPopup = 3000;
            var zOriginalMouseLeave = kendo.ui.Menu.fn._mouseleave;
            var zMouseLeave = function (pEvent) {
                var that = this;
                clearTimeout(this._timeoutHandle);
                this._timeoutHandle = setTimeout(function () {
                    zOriginalMouseLeave.call(that, pEvent);
                }, zTimeToCloseFilterPopup);
            }
            kendo.ui.Menu.fn._mouseleave = zMouseLeave;
            // SET ATTRIBUTES
            for (x = 0; x < pColumns.length; x++) {
                pColumns[x].attributes = null;
                //pColumns[x].headerAttributes = null;
            }
            // SET LOADING TYPE OR PICKLIST
            if (zParent.optionsConstant.isServerLoading) {
                if (zParent.optionsConstant.serviceMethod == "POST") {
                    zOptions = zParent.setOptionsTemplate_ServerLoading();
                } else {
                    zOptions = zParent.setOptionsTemplate_ServerLoadingGET();
                }
            } else {
                zOptions = zParent.setOptionsTemplate_Picklist();
            }
            // SET COLUMN MENU INIT
            zOptions.columnMenuInit = function (pEvent) { zParent._setColumnMenus(pEvent, zParent); };
        }
        zOptions.dataSource.data = pData;
        zOptions.dataSource.schema = pSchema;
        if (zParent.optionsConstant.isServerLoading) {
            zOptions.dataSource.schema.data = zParent.optionsConstant.serverLoadingNodeNameData;
            zOptions.dataSource.schema.total = zParent.optionsConstant.serverLoadingNodeNameTotal;
        }
        zOptions.columns = pColumns;
        zOptions.dataBound = function (pEvent) {
            var zFilter = this.dataSource.filter();
            this.thead.find(".k-header-column-menu.k-state-active").removeClass("k-state-active");
            this.wrapper.find(".k-grid-header-locked .k-header-column-menu.k-state-active").removeClass("k-state-active");
            if (zFilter) {
                var zFilteredMembers = {};
                zParent._setFilterMembers(zFilter, zFilteredMembers);
                var zHeads = this.thead.find("th[data-field]");
                var zFrozenHeads = this.wrapper.find(".k-grid-header-locked th[data-field]");
                zHeads.add(zFrozenHeads).each(function () {
                    var zCell = $(this);
                    var zFiltered = zFilteredMembers[zCell.data("field")];
                    zCell.find(".k-i-funnel").remove();
                    if (zFiltered) {
                        zCell.find(".k-link").append("<span class='k-icon k-icon-white k-i-funnel'>&nbsp;</span>");
                    } else {
                        zCell.find(".k-i-funnel").remove();
                    }
                });
            } else {
                var zHeads = this.thead.find("th[data-field]");
                var zFrozenHeads = this.wrapper.find(".k-grid-header-locked th[data-field]");
                zHeads.add(zFrozenHeads).each(function () {
                    var zCell = $(this);
                    zCell.find(".k-i-funnel").remove();
                });
            }
        };
        $(pGridDOM).kendoGrid(zOptions);
        zParent.grid = $(pGridDOM).data("kendoGrid");
        zParent._setupColumnMenuHides();
        zParent.grid.dataSource.filter(pFilter);
        zParent.grid.dataSource.page(pPage);
        zParent.grid.dataSource.sort(pSort);

        // UPDATE THE COLOR OF EDITABLE CELLS. *** NOTE *** SELECTING DOES NOT WORK WITH THIS SET
        setTimeout(function () {
            $(zParent._gridDOM + " tr:odd").each(function () {
                $(this).find("[data-editable]").each(function () {
                    $(this).css("background-color", "#FFFCD8");
                });
            });
            $(zParent._gridDOM + " tr:even").each(function () {
                $(this).find("[data-editable]").each(function () {
                    $(this).css("background-color", "#FFFCD8");
                });
            });
        }, 750);
    };


    /// Function to assist in using filter memebers in data bound event
    this._setFilterMembers = function (pFilter, pMembers) {
        var zParent = this;
        if (pFilter.filters) {
            for (var i = 0; i < pFilter.filters.length; i++) {
                zParent._setFilterMembers(pFilter.filters[i], pMembers);
            }
        }
        else {
            pMembers[pFilter.field] = true;
        }
    };


    /// Build the column customization including new menu items. Be sure to add ignorable columns in the pickListIgnoreColumns array.
    /// pEvent (OBJECT) Event driving the function. REQUIRED
    /// pParent (OBJECT) Reference to the Kendo grid helper class. REQUIRED
    /// THIS IS WHERE YOU TURN HELPER MENU ITEMS ON/OFF
    this._setColumnMenus = function (pEvent, pParent) {
        // NOTE: THE ORDER OF THE SETUP FUNCTIONS IS THE ORDER IN WHICH THEY APPEAR IN THE MENU
        //if (this.optionsConstant.enableMenuRemove) { this._setupColumnMenuRemove(pEvent, pParent); }
        this._setupColumnMenuFilterFocus(pEvent, pParent);
        this._setupColumnMenuLocking(pEvent, pParent);
        if (this.optionsConstant.enableMenuPickList) { this._setupColumnMenuPicklist(pEvent, pParent); }
        if (this.optionsConstant.enableMenuMoveToFirst) { this._setupColumnMenuMoveFirst(pEvent, pParent); }
        if (this.optionsConstant.enableMenuMoveToLast) { this._setupColumnMenuMoveLast(pEvent, pParent); }
        if (this.optionsConstant.enableMenuMap) { this._setupColumnMenuMap(pEvent, pParent); }
        this._setupColumnMenuSetOptions(pEvent, pParent);
    };


    /// A function to set additional options on the column menu
    this._setupColumnMenuSetOptions = function (pEvent, pParent) {
    };


    /// A function to correct issues when hovering over filter window textboxes
    this._setupColumnMenuFilterFocus = function (pEvent, pParent) {
        // SET THE FOCUS
        var zMenu = pEvent.container.find(".k-menu").data("kendoMenu");
        zMenu.bind('activate', function (pEvent) {
            if (pEvent.item.is(".k-filter-item")) {
                // IF AN ELEMENT IN THE SUBMENU IS FOCUSED FIRST, THE ISSUE IS NOT OBSERVED
                setTimeout(function () {
                    pEvent.item.find('input').first().focus();
                }, 100);
            }
        });
    };


    /// Removes any unwanted column menu items from the column menu
    this._setupColumnMenuLocking = function (pEvent, pParent) {
        // REMOVE ANY EXISTING LOCKING MENU ITEMS
        var zItem = pEvent.container.find(".k-columns-item");
        zItem.prev(".k-separator").remove();
        zItem.remove();
        var zItem = pEvent.container.find(".k-lock");
        zItem.remove();
        var zItem = pEvent.container.find(".k-unlock");
        zItem.prev(".k-separator").remove();
        zItem.remove();
        // ADD LOCKING ABILITY
        if (pParent.optionsConstant.enableMenuLocking) {
            //pParent.grid.options.columnMenu = { messages: { lock: "Pin" } }; // DOES NOT WORK
            var zParent = pParent;
            var zMenu = pEvent.container.find(".k-menu").data("kendoMenu");
            var zPopup = pEvent.container.data('kendoPopup');
            var zField = pEvent.field;
            var zEnabled = true;
            var zMenuNamePin = "Pin";
            var zMenuNameUnPin = "Unpin"
            var zMenuName = zMenuNamePin;
            var zIconClass = "iconPin";
            for (var x = 0; x < pParent.grid.columns.length; x++) {
                if (pParent.grid.columns[x].field == zField) {
                    if (pParent.grid.columns[x].locked == true) {
                        zMenuName = zMenuNameUnPin;
                        zIconClass = "iconUnPin";
                    }
                    if (pParent.grid.columns[x].lockable == true) {
                        var zItemHtml = '<li class="k-separator k-item k-state-default" role="menuitem"></li>' +
                            '<li id="menuPickList" class="k-item k-state-default" role="menuitem">' +
                            '<span class="k-link">' +
                            '<span class="k-sprite" style="font-size:11px;"><i class="fas fa-thumbtack"></i></span>' +
                            '<span>' + zMenuName + '</span>' +
                            '</span>' +
                            '</li>';
                        $(pEvent.container).find(".k-menu").append(zItemHtml);
                    }
                    // ADD AN EVENT TO LISTEN FOR CLICK
                    zMenu.bind("select", function (pEvent) {
                        // CHECK TYPE OF MENU BUTTON / EVENT
                        var zMenuText = $(pEvent.item).text();
                        switch (zMenuText.replace(/\s/g, "").toLowerCase()) {
                            case zMenuNamePin.replace(/\s/g, "").toLowerCase():
                                zMenu.close();
                                zPopup.close();
                                zParent.pinColumn(zField);
                                break;
                            case zMenuNameUnPin.replace(/\s/g, "").toLowerCase():
                                zMenu.close();
                                zPopup.close();
                                zParent.unPinColumn(zField);
                                break;
                            default:
                                break;
                        }
                    });
                    break;
                }
            }
        }
    };


    /// Build the column customization menu item for pick lists.
    /// pEvent (OBJECT) Event driving the function. REQUIRED
    /// pParent (OBJECT) Reference to the Kendo grid helper class. REQUIRED
    this._setupColumnMenuPicklist = function (pEvent, pParent) {
        var zParent = pParent;
        var zMenu = pEvent.container.find(".k-menu").data("kendoMenu");
        var zField = pEvent.field;
        var zEnabled = true;
        var zMenuName = "Pick List";

        // ADD A TEMPLATE FOR THE NEW MENU ITEM
        for (x = 0; x < this.pickListIgnoreColumns.length; x++) {
            if (zField.replace(/\s/g, "").toLowerCase() == this.pickListIgnoreColumns[x].replace(/\s/g, "").toLowerCase()) {
                zEnabled = false;
                break;
            }
        }

        if (zEnabled) {
            var zItemHtml = '<li class="k-separator k-item k-state-default" role="menuitem"></li>' +
                '<li id="menuPickList" class="k-item k-state-default" role="menuitem">' +
                '<span class="k-link">' +
                '<span class="k-sprite" style="font-size:11px;"><i class="fas fa-check"></i></span>' +
                '<span>' + zMenuName + '</span>' +
                '</span>' +
                '</li>';
            $(pEvent.container).find(".k-menu").append(zItemHtml);
        }

        // ADD AN EVENT TO LISTEN FOR CLICK
        zMenu.bind("select", function (pEvent) {
            // CHECK TYPE OF MENU BUTTON / EVENT
            var zMenuText = $(pEvent.item).text();
            switch (zMenuText.replace(/\s/g, "").toLowerCase()) {
                case zMenuName.replace(/\s/g, "").toLowerCase(): zParent._setupPickList(zField); break;
                default: break;
            }
        });
    };


    /// Build the column customization menu item for pick lists.
    /// pEvent (OBJECT) Event driving the function. REQUIRED
    /// pParent (OBJECT) Reference to the Kendo grid helper class. REQUIRED
    this._setupColumnMenuMap = function (pEvent, pParent) {
        var zParent = pParent;
        var zMenu = pEvent.container.find(".k-menu").data("kendoMenu");
        var zField = pEvent.field;
        var zTitle = "";
        var zEnabled = true;
        var zMenuNameMap = "Depict Map By";
        var isDepicted = false;
        var zIcon = null;
        var zIconId = zMenuNameMap.replace(/\s/g, "") + "_" + zField;
        var zIconMap = "fa-map-o";
        var zIconClassSquare = "fa-map-pin";
        var zIconClassChecked = "fa-map-pin"; //"fa-check"; //"fa-check-square-o";
        var zIconOff = '<i style="font-size: 9pt; margin-right: 14px; margin-left:5px;" class="fal ' + zIconClassSquare + '"></i>';
        var zIconOn = '<i style="font-size: 9pt; margin-right: 12px; margin-left:5px;" class="fas ' + zIconClassChecked + '"></i>';
        
        // IS THIS MAP DEPICTABLE?
        for (var x = 0; x < zParent.grid.columns.length; x++) {
            if (zParent.grid.columns[x].field == zField) {
                zTitle = zParent.grid.columns[x].title;
                if (zParent.grid.columns[x].isDepictable) {
                    // SET TO ICON WITH CHECK IF THIS CURRENTLY THE DEPICTABLE ITEM (OR DEFAULT)?
                    if (zParent.grid.columns[x].field == zParent.mapDepictedNameCurrent) {
                        isDepicted = true;
                        zIcon = zIconOn;
                    } else {
                        isDepicted = false;
                        zIcon = zIconOff;
                    }
                    // BUILD THE MENU HTML
                    var zItemHtml = '<li class="k-separator k-item k-state-default" role="menuitem"></li>' +
                            '<li id="menuPickList" class="k-item k-state-default" role="menuitem">' +
                            '<span class="k-link">' +
                            '<span id="' + zIconId + '" class="" style="height: 16px; width: 16px; position: relative;" >' +
                            zIcon +
                            '</span>' +
                            '<span>' + zMenuNameMap + '</span>' +
                            '</span>' +
                            '</li>';
                    $(pEvent.container).find(".k-menu").append(zItemHtml);
                    // ADD AN EVENT TO LISTEN FOR CLICK
                    zMenu.bind("select", function (pEvent) {
                        // CHECK TYPE OF MENU BUTTON / EVENT
                        var zMenuText = $(pEvent.item).text();
                        switch (zMenuText.replace(/\s/g, "").toLowerCase()) {
                            case zMenuNameMap.replace(/\s/g, "").toLowerCase():
                                // TURN OFF ALL DEPICTABLE FIELDS
                                for (var y = 0; y < zParent.grid.columns.length; y++) {
                                    if (zParent.grid.columns[y].isDepictable) {
                                        var zTempIconId = zMenuNameMap.replace(/\s/g, "") + "_" + zParent.grid.columns[y].field;
                                        $("#" + zTempIconId).html(zIconOff);
                                    }
                                }
                                // IS THIS FIELD ALREADY DEPICTED?
                                var isDepictedOnClick = false;
                                if (zParent.mapDepictedNameCurrent == zField) {
                                    isDepictedOnClick = true;
                                }
                                // TURN ON OR OFF THIS DEPICTABLE FIELDS
                                if (isDepictedOnClick) {
                                    // TURN ON DEFAULT, ALSO SET ZFIELD AND ZTITLE
                                    zField = zParent.mapDepictedNameDefault;
                                    for (var x = 0; x < zParent.grid.columns.length; x++) {
                                        if (zParent.grid.columns[x].field == zField) {
                                            zTitle = zParent.grid.columns[x].title;
                                        }
                                    }
                                    zParent.mapDepictedNameCurrent = zParent.mapDepictedNameDefault;
                                    var zTempIconId = zMenuNameMap.replace(/\s/g, "") + "_" + zParent.mapDepictedNameDefault;
                                    $("#" + zIconId).html(zIconOff);
                                    $("#" + zTempIconId).html(zIconOn);
                                } else {
                                    zParent.mapDepictedNameCurrent = zField;
                                    $("#" + zIconId).html(zIconOn);
                                }
                                // SET THE DEPICTED FIELD TO THE OUTSIDE MVVM
                                zParent.optionsConstant.setMapDepictableComplete(pEvent, zField, zTitle);
                                break;                       
                            default:
                                break;
                        }
                    });
                }
                
                break;
            }
        }
    };


    /// Build the column customization menu item for moving a column to the first position.
    /// pEvent (OBJECT) Event driving the function. REQUIRED
    /// pParent (OBJECT) Reference to the Kendo grid helper class. REQUIRED
    this._setupColumnMenuMoveFirst = function (pEvent, pParent) {
        var zParent = pParent;
        var zMenu = pEvent.container.find(".k-menu").data("kendoMenu");
        var zField = pEvent.field;
        var zEnabled = true;
        var zMenuName = "Move To First";

        // ADD A TEMPLATE FOR THE NEW MENU ITEM
        if (zEnabled) {
            var zItemHtml = '<li class="k-separator k-item k-state-default" role="menuitem"></li>' +
                '<li id="menuPickList" class="k-item k-state-default" role="menuitem">' +
                '<span class="k-link">' +
                '<span class="k-sprite k-i-seek-w">&nbsp;</span>' +
                '<span>' + zMenuName + '</span>' +
                '</span>' +
                '</li>';
            $(pEvent.container).find(".k-menu").append(zItemHtml);
        }

        // ADD AN EVENT TO LISTEN FOR CLICK
        zMenu.bind("select", function (pEvent) {
            // CHECK TYPE OF MENU BUTTON / EVENT
            var zMenuText = $(pEvent.item).text();
            switch (zMenuText.replace(/\s/g, "").toLowerCase()) {
                case zMenuName.replace(/\s/g, "").toLowerCase():
                    zParent.moveColumnToFirst(zField);
                    zMenu.close();
                    break;
                default: break;
            }
        });
    };


    /// Build the column customization menu item for moving a column to the last position.
    /// pEvent (OBJECT) Event driving the function. REQUIRED
    /// pParent (OBJECT) Reference to the Kendo grid helper class. REQUIRED
    this._setupColumnMenuMoveLast = function (pEvent, pParent) {
        var zParent = pParent;
        var zMenu = pEvent.container.find(".k-menu").data("kendoMenu");
        var zField = pEvent.field;
        var zEnabled = true;
        var zMenuName = "Move To Last";

        // ADD A TEMPLATE FOR THE NEW MENU ITEM
        if (zEnabled) {
            var zItemHtml = '<li class="k-separator k-item k-state-default" role="menuitem"></li>' +
                '<li id="menuPickList" class="k-item k-state-default" role="menuitem">' +
                '<span class="k-link">' +
                '<span class="k-sprite k-i-seek-e">&nbsp;</span>' +
                '<span>' + zMenuName + '</span>' +
                '</span>' +
                '</li>';
            $(pEvent.container).find(".k-menu").append(zItemHtml);
        }

        // ADD AN EVENT TO LISTEN FOR CLICK
        zMenu.bind("select", function (pEvent) {
            // CHECK TYPE OF MENU BUTTON / EVENT
            var zMenuText = $(pEvent.item).text();
            switch (zMenuText.replace(/\s/g, "").toLowerCase()) {
                case zMenuName.replace(/\s/g, "").toLowerCase():
                    zParent.moveColumnToLast(zField);
                    zMenu.close();
                    break;
                default: break;
            }
        });
    };

    
    // A function to hide the dropdown menu icon from displaying for specific columns
    this._setupColumnMenuHides = function () {
        if (this.grid.columns !== undefined) {
            for (var x = 0; x < this.grid.columns.length; x++) {
                if (this.grid.columns[x].menu !== undefined && this.grid.columns[x].menu == false) {
                    $(this.grid.thead).find("[data-field=" + this.grid.columns[x].field + "]>.k-header-column-menu").remove();
                }
            }
        }
    };


    /// Build the picklist window, object, and collections
    /// pField (STRING) The name of the column "field" that the picklist will reference. REQUIRED
    this._setupPickList = function (pField) {
        //var zParent = this;
        // SETUP PICKLIST
        $(this._pickListDOM + " " + this._pickListDOM + "_Items").hide(1);
        $(this._pickListDOM + " " + this._pickListDOM + "_Table").html("");
        $(this._pickListDOM + " " + this._pickListDOM + "_Loading").show(1);
        this.pickList.data("kendoWindow").close();
        $(".k-animation-container").slideUp(250);
        this.pickList.data("kendoWindow").center().open();
        $(this._pickListDOM).css("display", "block");
        this.currentPickListField = pField;
        if (this.optionsConstant.isServerLoading) {
            // CALL A REST SERVICE TO GET AND BUILD PICK LIST DATA
            var zFilter = null;
            if (this.grid.dataSource.filter()) {
                zFilter = JSON.stringify(this.grid.dataSource.filter());
            }
            var zCriteria = null;
            if (this.optionsConstant.criteriaFilter) {
                zCriteria = JSON.stringify(this.optionsConstant.criteriaFilter);
            }
            var zUserCurrencyId = null;
            if (gCurrencyIdFromPrefilter) {
                zUserCurrencyId = gCurrencyIdFromPrefilter;
            }
            var zParms = ko.toJSON({
                "gSafeGuid": getGSafeGUID(),
                "columnName": pField,
                "filter": zFilter,
                "criteria": zCriteria,
                "pUserCurrencyId": zUserCurrencyId
            });
            this._callRestService(this.optionsConstant.transportPickListAddress, zParms, this._setupPickListServerLoadingSuccess, this._setupPickListServerLoadingError, this);
        } else {
            // USE THE LOCAL DATA TO BUILD PICK LIST DATA
            this._setupPickListServerLoadingSuccess(this.grid.dataSource.data(), this);
        }
    };


    /// A success function for server side loading pick lists
    this._setupPickListServerLoadingSuccess = function (pResults, pParent) {
        // BUILD UNIQUE LIST OF ITEMS AND APPLY APPROPRIATE TYPE
        var zUniqueList = new Array();
        zUniqueList.push("");
        var zType = null;
        if (pParent.optionsConstant.isServerLoading) {
            // USE DATA RETURNED FROM THE SERVICE TO BUILD THE PICK LIST DATA
            zUniqueList = pResults.data;
            if (pResults.dataType.toLowerCase() == "date") {
                pParent.currentPickListType = "object";
            } else {
                pParent.currentPickListType = pResults.dataType;
            }
        } else {
            // USE THE LOCAL DATA TO BUILD PICK LIST DATA
            for (i = 0; i < pParent.grid.dataSource.data().length; i++) {
                var zValue = pParent.grid.dataSource.data()[i][pParent.currentPickListField];
                zType = typeof zValue;
                if (zValue != undefined && zValue != null) {
                    switch (zType) {
                        case "string":
                            if ($.inArray(zValue, zUniqueList) == -1) {
                                zUniqueList.push(zValue);
                                pParent.currentPickListType = "string";
                            }
                            break;
                        case "number":
                            if ($.inArray(zValue, zUniqueList) == -1) {
                                zUniqueList.push(zValue);
                                pParent.currentPickListType = "number";
                            }
                            break;
                        case "boolean":
                            if (zValue) {
                                if ($.inArray("Yes", zUniqueList) == -1) {
                                    zUniqueList.push("Yes");
                                    pParent.currentPickListType = "boolean";
                                }
                            } else {
                                if ($.inArray("No", zUniqueList) == -1) {
                                    zUniqueList.push("No");
                                    pParent.currentPickListType = "boolean";
                                }
                            }
                            break;
                        case "object":
                            if (typeof zValue.getMonth == "function") {
                                if ($.inArray(pParent._formatSortableDate(zValue), zUniqueList) == -1) {
                                    zUniqueList.push(pParent._formatSortableDate(zValue));
                                    pParent.currentPickListType = "date";
                                }
                            } else {
                                if ($.inArray(zValue, zUniqueList) == -1) {
                                    zUniqueList.push(zValue);
                                    pParent.currentPickListType = "object";
                                }
                            }
                            break;
                        default:
                            if ($.inArray(zValue, zUniqueList) == -1) {
                                zUniqueList.push(zValue);
                                pParent.currentPickListType = "unknown";
                            }
                            break;
                    }
                }
            }
            // SORT THE UNIQUE LIST OF ITEMS
            zUniqueList.sort();
            // IF IT IS A DATE FIELD, REFORMAT THE STRINGS SO THEY ARE READABLE
            if (pParent.currentPickListType == "date") {
                for (i = 0; i < zUniqueList.length; i++) {
                    zUniqueList[i] = pParent._formatShortDateWithMonth(zUniqueList[i]);
                }
            }
        }

        // LOOK FOR AN EXISTING LIST
        var zFound = false;
        var zFoundIndex = 0;
        for (i = 0; i < pParent.collPickList.length; i++) {
            if (pParent.collPickList[i].field == pParent.currentPickListField) {
                zFound = true;
                zFoundIndex = i;
                break;
            }
        }

        // PUSH LIST TO DISPLAY
        if (zFound) {
            for (i = 0; i < pParent.collPickList[zFoundIndex].list.length; i++) {
                var zObj = pParent.collPickList[zFoundIndex].list[i];
                if (!zObj.checked) {
                    $(pParent._pickListDOM + " " + pParent._pickListDOM + "_Table").append('<div class="pickListItem"><label><input type="checkbox" value="' + zObj.checked + '" id="' + zObj.id + '" name="' + zObj.value + '" onclick="globalPickListCheck(\'' + zObj.field + '\',' + zObj.id + ',\'' + pParent._pickListDOM + '\');" /><span class="pickListItemLabel">' + zObj.value + '</span></label></div>');
                } else {
                    $(pParent._pickListDOM + " " + pParent._pickListDOM + "_Table").append('<div class="pickListItem"><label><input type="checkbox" value="' + zObj.checked + '" checked="' + zObj.checked + '" id="' + zObj.id + '" name="' + zObj.value + '" onclick="globalPickListCheck(\'' + zObj.field + '\',' + zObj.id + ',\'' + pParent._pickListDOM + '\');" /><span class="pickListItemLabel">' + zObj.value + '</span></label></div>');
                }
            }
        } else {
            var zArray = new Array();
            for (i = 0; i < zUniqueList.length; i++) {
                zArray.push({ id: i, checked: true, operator: "eq", value: zUniqueList[i], field: pParent.currentPickListField });
                $(pParent._pickListDOM + " " + pParent._pickListDOM + "_Table").append('<div class="pickListItem"><label><input type="checkbox" value="' + true + '" checked="' + true + '" id="' + i + '" name="' + zUniqueList[i] + '" onclick="globalPickListCheck(\'' + pParent.currentPickListField + '\',' + i + ',\'' + pParent._pickListDOM + '\');" /><span class="pickListItemLabel">' + zUniqueList[i] + '</span></label></div>');
            }
            pParent.collPickList.push({ field: pParent.currentPickListField, list: zArray });
            zFoundIndex = pParent.collPickList.length - 1;
        }
        pParent.currentPickListIndex = zFoundIndex;
        $(pParent._pickListDOM + " " + pParent._pickListDOM + "_Items").show(1);
        $(pParent._pickListDOM + " " + pParent._pickListDOM + "_Loading").fadeOut(250);
    },


    /// An error function for server side loading pick lists
    this._setupPickListServerLoadingError = function (pResults, pMessage, pErrorDetail, pParent) {
        alert("An error occurred when loading pick list information. " + pMessage);
    },


    /// Setup all events on the grid
    this._setupEvents = function () {
        this._setupEventsToolTips();
        this._setupEventsPageButtons();
    };


    /// Setup the mouse events for displaying tool tips for long cell information
    this._setupEventsToolTips = function () {
        var zParent = this;
        // CREATE EVENTS FOR HOVERING OVER A CELL IN THE GRID
        $(this._gridDOM).on("mouseenter", "td", function (pEvent) {
            var zChild = this;
            if (zChild.className.indexOf("k-detail-cell") < 0) {
                var zContent = $(zChild).text();
                var zContentWidth = zContent.length * 8;
                var zCellWidth = parseInt($(zChild).css("width").replace("px"));
                var zWidth = 0;
                if (zContentWidth > 400) { zWidth = 400 } else { zWidth = zContentWidth };
                if (zContent != "Enter" && zContent != "Recs") {
                    if (zContentWidth > zCellWidth && zParent._toolTipCellDetails == null) {
                        zParent._toolTipCellDetails = $(zChild).kendoTooltip({
                            autoHide: false,
                            showOn: "mouseenter",
                            width: zWidth,
                            position: "bottom",
                            beforeShow: function () {

                            },
                            content: zContent
                        }).data("kendoTooltip");
                        setTimeout(function () {
                            if (zParent._toolTipCellDetails != null) {
                                zParent._toolTipCellDetails.show($(zChild));
                            }
                        }, 200);
                    }
                }
            }
        });

        // CREATE EVENTS FOR MOUSE LEAVING A CELL IN THE GRID
        $(this._gridDOM).on("mouseout", "td", function (pEvent) {
            if (zParent._toolTipCellDetails != null) {
                zParent._toolTipCellDetails.hide();
                zParent._toolTipCellDetails = null;
            }
            $(".k-tooltip").css("display", "none");
        });

        // CREATE EVENTS FOR HOVERING OVER A COLUMN HEADER TITLE
        $(this._gridDOM).on("mouseenter", ".k-header.k-with-icon .k-link", function (pEvent) {
            var zChild = this;
            if (zChild.className.indexOf(".k-link") < 0) {
                var zContent = $(zChild).text();
                if (zContent != "Link to Location " || zContent != "Link to Recs") {
                    var zContentWidth = zContent.length * 8;
                    var zCellWidth = parseInt($(zChild).css("width").replace("px"));
                    var zWidth = 0;
                    if (zContentWidth > 400) { zWidth = 400 } else { zWidth = zContentWidth };
                    if (zContentWidth > zCellWidth && zParent._toolTipCellDetails == null) {
                        zParent._toolTipCellDetails = $(zChild).kendoTooltip({
                            autoHide: false,
                            showOn: "mouseenter",
                            width: zWidth,
                            position: "bottom",
                            content: zContent
                        }).data("kendoTooltip");
                        setTimeout(function () {
                            if (zParent._toolTipCellDetails != null) {
                                zParent._toolTipCellDetails.show($(zChild));
                            }
                        }, 200);
                    }
                }
            }
        });

        // CREATE EVENTS FOR MOUSE LEAVING A COLUMN HEADER TITLE AREA
        $(this._gridDOM).on("mouseout", ".k-header.k-with-icon .k-link", function (pEvent) {
            if (zParent._toolTipCellDetails != null) {
                zParent._toolTipCellDetails.hide();
                zParent._toolTipCellDetails = null;
            }
            $(".k-tooltip").each(function () {
                //$(this).css("display", "none");
                $(this).remove();
            });
        });
    };


    /// Add events to the page buttons
    this._setupEventsPageButtons = function () {
        var zParent = this;
        // CREATE EVENT TO HELP CONTROL THE SIDE SCROLL BAR VIRTUAL SCROLLING
        $(this._gridDOM + " .k-pager-wrap").delegate("a", "click", function () {
            if (zParent.grid.virtualScrollable) {
                zParent._isAdjustScrollbarPositionRequired = true;
            }
        });
    };


    /// Function to return the available height of the window, modified for any other components on the screen
    this._getAvailableHeight = function () {
        var zReturn = 0;
        var zParent = this;
        if (zParent.optionsConstant.height !== null) {
            zReturn = zParent.optionsConstant.height;
        } else {
            if (zParent.optionsConstant.heightOffset != null) {
                zReturn = window.innerHeight + zParent.optionsConstant.heightOffset;
            } else {
                zReturn = window.innerHeight - 410;
            }
            // SET MINIMUM SIZE
            if (zReturn < zParent.optionsConstant.heightMinimum) {
                zReturn = zParent.optionsConstant.heightMinimum;
            }
        }
        return zReturn;
    };


    /// Pin a column to the left
    this.pinColumn = function (pField) {
        var zParent = this;
        kendo.ui.progress($("body"), true);
        setTimeout(function () {
            var zIsRebuild = false;
            // RESORT TO ALWAYS PUT LINK TO POPUP FIRST
            for (var x = 0; x < zParent.grid.columns.length; x++) {
                if (zParent.grid.columns[x].lockable) {
                    if (zParent.grid.columns[x].field == "Link_to_Popup") {
                        zParent.grid.columns[x].locked = true;
                        zParent.grid.lockColumn(zParent.grid.columns[x].field);
                        zIsRebuild = true;
                        break;
                    }
                }
            }
            // PIN OR MOVE THE DESIRED FIELD
            for (var x = 0; x < zParent.grid.columns.length; x++) {
                if (zParent.grid.columns[x].field == pField) {
                    if (!zParent.grid.columns[x].lockable || zParent.grid.detailTemplate) {
                        zParent.moveColumnToFirst(pField);
                    } else {
                        zParent.grid.columns[x].locked = true;
                        zParent.grid.lockColumn(pField);
                        zIsRebuild = true;
                        try {
                            if (globalCheckGridHeaderColor !== undefined) {
                                globalCheckGridHeaderColor();
                            }
                        } catch (pException) {
                        }
                    }
                    break;
                }
            }
            // REBUILD THE GRID IF NEEDED
            if (zIsRebuild) {
                zParent.rebuildGrid();
            }
            kendo.ui.progress($("body"), false);
        }, 500);
    };


    /// Unpin a column
    this.unPinColumn = function (pField) {
        var zParent = this;
        kendo.ui.progress($("body"), true);
        setTimeout(function () {
            for (var x = 0; x < zParent.grid.columns.length; x++) {
                if (zParent.grid.columns[x].field == pField) {
                    zParent.grid.columns[x].locked = false;
                    zParent.grid.unlockColumn(pField);
                    zParent.rebuildGrid();
                    try {
                        if (globalCheckGridHeaderColor !== undefined) {
                            globalCheckGridHeaderColor();
                        }
                    } catch (pException) {
                    }
                    break;
                }
            }
            kendo.ui.progress($("body"), false);
        }, 500);
    };


    /// Move a column to the first position
    this.moveColumnToFirst = function (pField, pTerminate) {
        var zParent = this;
        kendo.ui.progress($("body"), true);
        setTimeout(function () {
            // FIND THE ELEMENT BY THE FIELD NAME
            var zColumn = null;
            var zPosition = null;
            for (var x = 0; x < zParent.grid.columns.length; x++) {
                if (zParent.grid.columns[x].field == pField) {
                    zColumn = zParent.grid.columns[x];
                    zPosition = x;
                    break;
                }
            }
            // MOVE THE COLUMN
            if (zColumn !== undefined && zColumn !== null) {
                zParent.grid.columns.splice(zPosition, 1);
                zParent.grid.columns.splice(0, 0, zColumn);
                zParent.rebuildGrid();
                try {
                    if (globalCheckGridHeaderColor !== undefined) {
                        globalCheckGridHeaderColor();
                    }
                } catch (pException) {
                }
            } else {
                alert("The column selected cannot be moved.");
            }
            // RESORT FOR LINK TO POPUP FIELD
            if (!pTerminate) {
                setTimeout(function () {
                    for (var x = 0; x < zParent.grid.columns.length; x++) {
                        if (zParent.grid.columns[x].field == "Link_to_Popup") {
                            zParent.moveColumnToFirst(zParent.grid.columns[x].field, true);
                            break;
                        }
                    }
                }, 100);
            }
            kendo.ui.progress($("body"), false);
        }, 500);
    };


    /// Move a column to the first position
    this.moveColumnToLast = function (pField) {
        var zParent = this;
        kendo.ui.progress($("body"), true);
        setTimeout(function () {
            // FIND THE ELEMENT BY THE FIELD NAME
            var zColumn = null;
            var zPosition = null;
            for (var x = 0; x < zParent.grid.columns.length; x++) {
                if (zParent.grid.columns[x].field == pField) {
                    zColumn = zParent.grid.columns[x];
                    zPosition = x;
                    break;
                }
            }
            // MOVE THE COLUMN
            if (zColumn !== undefined && zColumn !== null) {
                zParent.grid.columns.splice(zPosition, 1);
                zParent.grid.columns.splice(zParent.grid.columns.length, 0, zColumn);
                zParent.rebuildGrid();
                try {
                    if (globalCheckGridHeaderColor !== undefined) {
                        globalCheckGridHeaderColor();
                    }
                } catch (pException) {
                }
            } else {
                alert("The column selected cannot be moved.");
            }
            kendo.ui.progress($("body"), false);
        }, 500);
    };


    /// Unchecks all of the checkboxes in the picklist and picklist collection.
    this.pickListCheckNone = function () {
        //var zParent = this;
        for (x = 0; x < this.collPickList[this.currentPickListIndex].list.length; x++) {
            this.collPickList[this.currentPickListIndex].list[x].checked = false;
            this.collPickList[this.currentPickListIndex].list[x].operator = "neq";
        }
        $(this._pickListDOM + " " + this._pickListDOM + "_Table").find(":checkbox").prop("checked", false);
    };


    /// Checks all of the checkboxes in the picklist and picklist collection.
    this.pickListCheckAll = function () {
        //var zParent = this;
        for (x = 0; x < this.collPickList[this.currentPickListIndex].list.length; x++) {
            this.collPickList[this.currentPickListIndex].list[x].checked = true;
            this.collPickList[this.currentPickListIndex].list[x].operator = "eq";
        }
        $(this._pickListDOM + " " + this._pickListDOM + "_Table").find(":checkbox").prop("checked", true);
    };


    /// Processes a check or uncheck on a specific field. Advised to use as an event call or data-bind call.
    this.pickListCheck = function (pField, pId) {
        //var zParent = this;
        for (x = 0; x < this.collPickList[this.currentPickListIndex].list.length; x++) {
            if (this.collPickList[this.currentPickListIndex].list[x].id == pId) {
                if (this.collPickList[this.currentPickListIndex].list[x].checked) {
                    this.collPickList[this.currentPickListIndex].list[x].checked = false;
                    this.collPickList[this.currentPickListIndex].list[x].operator = "neq";
                } else {
                    this.collPickList[this.currentPickListIndex].list[x].checked = true;
                    this.collPickList[this.currentPickListIndex].list[x].operator = "eq";
                }
                break;
            }
        }
    };


    /// Reverses all of the current checked and unchecked items in the picklist and picklist collection..
    this.pickListCheckReverse = function () {
        //var zParent = this;
        for (x = 0; x < this.collPickList[this.currentPickListIndex].list.length; x++) {
            if (this.collPickList[this.currentPickListIndex].list[x].checked) {
                this.collPickList[this.currentPickListIndex].list[x].checked = false;
                this.collPickList[this.currentPickListIndex].list[x].operator = "neq";
            } else {
                this.collPickList[this.currentPickListIndex].list[x].checked = true;
                this.collPickList[this.currentPickListIndex].list[x].operator = "eq";
            }
        }
        $(this._pickListDOM + " " + this._pickListDOM + "_Table").find(":checkbox").each(function () {
            if ($(this).is(":checked")) {
                $(this).removeAttr("checked");
                $(this).prop("value", "false");
            } else {
                $(this).prop("checked", true);
                $(this).prop("value", "true");
            }
        });
    };


    /// Cancels the picklist actions and closes the picklist window.
    this.pickListCancel = function () {
        //var zParent = this;
        this.pickList.data("kendoWindow").close();
    };


    /// Applies all currently checked or unchecked picklist items to the Kendo grid filter.
    this.pickListApplyFilter = function () {
        //var zParent = this;
        // BUILD THE FILTER OBJECT
        var zFilter = { logic: "and", filters: [] };
        var zFilterEQ = { logic: "or", filters: [] };
        var zFilterNEQ = { logic: "and", filters: [] };
        this.collPickList[this.currentPickListIndex].countEQ = 0;
        this.collPickList[this.currentPickListIndex].countNEQ = 0;
        for (x = 0; x < this.collPickList[this.currentPickListIndex].list.length; x++) {
            var zField = this.collPickList[this.currentPickListIndex].list[x].field;
            var zOperator = this.collPickList[this.currentPickListIndex].list[x].operator;
            var zValue = null;
            switch (this.currentPickListType) {
                case "string":
                    zValue = this.collPickList[this.currentPickListIndex].list[x].value;
                    break;
                case "number":
                    if (this.collPickList[this.currentPickListIndex].list[x].value == undefined || this.collPickList[this.currentPickListIndex].list[x].value == null || this.collPickList[this.currentPickListIndex].list[x].value == 0) {
                        zValue = null
                    } else {
                        zValue = this.collPickList[this.currentPickListIndex].list[x].value;
                    }
                    break;
                case "boolean":
                    if (this.collPickList[this.currentPickListIndex].list[x].value == undefined || this.collPickList[this.currentPickListIndex].list[x].value == null || this.collPickList[this.currentPickListIndex].list[x].value == 0) {
                        zValue = null;
                    } else {
                        zValue = this.collPickList[this.currentPickListIndex].list[x].value;
                        if (zValue.toLowerCase() == "yes") { zValue = true; } else if (zValue.toLowerCase() == "no") { zValue = false; }
                    }
                    break;
                case "date":
                    if (this.collPickList[this.currentPickListIndex].list[x].value != undefined && this.collPickList[this.currentPickListIndex].list[x].value != null && this.collPickList[this.currentPickListIndex].list[x].value != "") {
                        zValue = Date.parse(this.collPickList[this.currentPickListIndex].list[x].value);
                        //zValue = Date.parse(this.collPickList[this.currentPickListIndex].list[x].value).toString();
                        //zValue = this.collPickList[this.currentPickListIndex].list[x].value;
                        //zValue = new Date(this.collPickList[this.currentPickListIndex].list[x].value);
                        if (zValue == "Invalid Date") { zValue = null; }
                    } else {
                        zValue = null;
                    }
                    break;
                case "object":
                    zValue = this.collPickList[this.currentPickListIndex].list[x].value;
                    break;
                default:
                    zValue = this.collPickList[this.currentPickListIndex].list[x].value;
                    break;
            }

            if (this.collPickList[this.currentPickListIndex].list[x].operator == "eq") {
                zFilterEQ.filters.push({ field: zField, operator: zOperator, value: zValue });
                this.collPickList[this.currentPickListIndex].countEQ++;
            } else {
                zFilterNEQ.filters.push({ field: zField, operator: zOperator, value: zValue });
                this.collPickList[this.currentPickListIndex].countNEQ++;
            }
        }
        if (this.collPickList[this.currentPickListIndex].countEQ < this.collPickList[this.currentPickListIndex].countNEQ) {
            if (zFilterEQ.filters.length > 0) { zFilter.filters.push(zFilterEQ); }
        } else {
            if (zFilterNEQ.filters.length > 0) { zFilter.filters.push(zFilterNEQ); }
        }
        this.setFilterPicklist(zFilter, this.currentPickListField);

        // SET THE CURRENT FILTER FIELD
        this.currentFilterField = this.currentPickListField;

        this.pickList.data("kendoWindow").close();
    };


    /// Builds and sets a custom filter object to the Kendo grid filter based on a picklist style filter, one field at a time.
    /// pFilter (JSON OBJECT) A kendo formatted filter object. REQUIRED
    /// pField (STRING) A string representing the field name included in the filter. REQUIRED
    this.setFilterPicklist = function (pFilter, pField) {
        //var zParent = this;
        // LOOK FOR THE FIELD WE ARE WORKING WITH AND REMOVE THEM
        // AND ADD THE NEW FILTER OBJECT TO THE EXISTING FILTER COLLECTION
        // THEN SET THE FILTER TO THE GRID
        var zFound = false;
        var zPage = this.grid.dataSource.page();
        var zFilter = this.grid.dataSource.filter();
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
            // ELSE ADD THE COMBINED FILTERS TOGETHER AND SUBMIT IT TO THE GRID
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
            this.grid.dataSource.filter(zFilter);
            this.grid.dataSource.page(zPage);
        } else {
            this.grid.dataSource.filter(pFilter);
            this.grid.dataSource.page(zPage);
        }
    };


    /// Builds and sets a custom filter object to the Kendo grid filter by field name and overrides the filter for that field.
    /// pFilter (JSON OBJECT) A kendo formatted filter object. REQUIRED
    /// pField (STRING) A string representing the field name included in the filter. REQUIRED
    this.setFilterOverride = function (pFilter, pField) {
        var zFound = false;
        var zPage = this.grid.dataSource.page();
        var zFilter = this.grid.dataSource.filter();
        if (zFilter != undefined) {
            // LOOK FOR AND REMOVE ANY EXSITING FILTERS FOR THIS FIELD
            if (zFilter.filters != undefined) {
                for (var x = zFilter.filters.length - 1; x > -1; x--) {
                    if (zFilter.filters[x].field == pField) { // && zFound == false) {
                        zFilter.filters.splice(x, 1);
                        zFound = true;
                    }
                }
            }
            // ADD IT TO THE FILTER
            for (var x = 0; x < pFilter.filters.length; x++) {
                zFilter.filters.push(pFilter.filters[x]);
            }
            this.grid.dataSource.filter(zFilter);
            this.grid.dataSource.page(zPage);
        } else {
            this.grid.dataSource.filter(pFilter);
            this.grid.dataSource.page(zPage);
        }
    };


    /// Remove a filter by the field name, does not include pick lists sub filters.
    /// pField (STRING) The field name to be cleared. REQUIRED
    this.removeFilterByField = function (pField) {
        var zFound = false;
        var zPage = this.grid.dataSource.page();
        var zFilter = this.grid.dataSource.filter();
        if (zFilter != undefined) {
            if (zFilter.filters != undefined) {
                for (x = 0; x < zFilter.filters.length; x++) {
                    if (zFilter.filters[x].field == pField && zFound == false) {
                        zFilter.filters.splice(x, 1);
                        zFound = true;
                        break;
                    }
                }
            }
            if (zFound) {
                this.grid.dataSource.filter(zFilter);
                this.grid.dataSource.page(zPage);
            }
        }
    };


    /// Clears all filters of the Kendo grid.
    this.clearFilter = function () {
        this.collPickList = new Array();
        this.currentPickListField = "";
        this.currentPickListIndex = null;
        this.grid.dataSource.filter({});
        this.grid.dataSource.sort({});
    };


    /// Returns a readable string of the sorted fields in the grid.
    this.getSortString = function () {
        var zReturn = "";
        if (this.optionsConstant.isServerLoading && this.sortString) {
            if (this.sortString.toLowerCase() != zReturn.toLowerCase()) {
                zReturn = this.sortString + " " + zReturn;
            }
        } else {
            if (this.grid != null && this.grid != undefined) {
                if (this.grid.dataSource.sort() != undefined && this.grid.dataSource.sort() != null) {
                    for (x = 0; x < this.grid.dataSource.sort().length; x++) {
                        var zDirection = "";
                        var zField = this.grid.dataSource.sort()[x].field;
                        if (this.grid.dataSource.sort()[x].dir == "asc") {
                            zDirection = "Ascending";
                        } else {
                            zDirection = "Descending";
                        }
                        if (x == 0) {
                            zReturn = zReturn + zField + " " + zDirection;
                        } else {
                            zReturn = zReturn + ", " + zField + " " + zDirection;
                        }
                    }
                }
            }
        }
        return zReturn;
    };


    /// Returns a readable string of the filtered fields and operators in the grid.
    this.getFilterString = function () {
        var zReturn = "";
        if (this.optionsConstant.isServerLoading && this.filterString) {
            if (this.filterString.toLowerCase() != zReturn.toLowerCase() + ";") {
                zReturn = this.filterString + " " + zReturn;
            }
        } else {
            if (this.grid != null && this.grid != undefined) {
                if (this.grid.dataSource.filter() != undefined && this.grid.dataSource.filter() != null) {
                    for (x = 0; x < this.grid.dataSource.filter().filters.length; x++) {
                        if (this.grid.dataSource.filter().filters[x].filters != undefined && this.grid.dataSource.filter().filters[x].filters != null) {
                            for (y = 0; y < this.grid.dataSource.filter().filters[x].filters.length; y++) {
                                var zOperator = "";
                                var zLogic = this.grid.dataSource.filter().filters[x].logic;
                                var zField = this.grid.dataSource.filter().filters[x].filters[y].field;
                                switch (this.grid.dataSource.filter().filters[x].filters[y].operator.toLowerCase()) {
                                    case "eq": zOperator = " to be equal to "; break;
                                    case "neq": zOperator = " to be not equal to "; break;
                                    case "lt": zOperator = " to be less than "; break;
                                    case "lte": zOperator = " to be less than or equal to "; break;
                                    case "gt": zOperator = " to be greater than "; break;
                                    case "gte": zOperator = " to be greater than or equal to "; break;
                                    case "startswith": zOperator = " to start with "; break;
                                    case "endswith": zOperator = " to end with "; break;
                                    case "contains": zOperator = " to contain "; break;
                                    case "doesnotcontain": zOperator = " does not contain "; break;
                                    default: zOperator = " is "; break;
                                }
                                var zValue = this.grid.dataSource.filter().filters[x].filters[y].value;
                                var zType = typeof this.grid.dataSource.filter().filters[x].filters[y].value;
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
                            var zLogic = this.grid.dataSource.filter().logic;
                            var zField = this.grid.dataSource.filter().filters[x].field;
                            switch (this.grid.dataSource.filter().filters[x].operator.toLowerCase()) {
                                case "eq": zOperator = " to be equal to "; break;
                                case "neq": zOperator = " to not be equal to "; break;
                                case "lt": zOperator = " to be less than "; break;
                                case "lte": zOperator = " to be less than or equal to "; break;
                                case "gt": zOperator = " to be greater than "; break;
                                case "gte": zOperator = " to be greater than or equal to "; break;
                                case "startswith": zOperator = " to start with "; break;
                                case "endswith": zOperator = " to end with "; break;
                                case "contains": zOperator = " to contain "; break;
                                case "doesnotcontain": zOperator = " does not contain "; break;
                                default: zOperator = " is "; break;
                            }
                            var zValue = this.grid.dataSource.filter().filters[x].value;
                            var zType = typeof this.grid.dataSource.filter().filters[x].value;
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
            }
        }
        return zReturn;
    };


    /// Returns a readable string of the filtered fields and operators in the grid.
    this.getPinnedString = function () {
        var zReturn = "";
        var zCount = 0;
        if (this.optionsConstant.isServerLoading && this.lockedString) {
            if (this.lockedString.toLowerCase() != zReturn.toLowerCase()) {
                zReturn = this.lockedString + " " + zReturn;
            }
        } else {
            if (this.grid != null && this.grid != undefined && this.grid.columns != undefined && this.grid.columns != null) {
                for (x = 0; x < this.grid.columns.length; x++) {
                    if (this.grid.columns[x].locked) {
                        if (zCount > 0) {
                            zReturn = zReturn + "; " + this.grid.columns[x].title;
                        } else {
                            zReturn = zReturn + this.grid.columns[x].title;
                        }
                        zCount++;
                    }
                }
            }
        }
        return zReturn;
    };


    /// Returns an array of records that are filtered, but ignore page breaks
    this.getViewDataAll = function () {
        var zReturn = [];
        var zDataAll = this.grid.dataSource.data();
        zReturn = zDataAll;
        // FILTER THE DATA
        try {
            var zFilters = this.grid.dataSource.filter();
            var zQueryFiltered = new kendo.data.Query(zDataAll);
            var zDataFiltered = zQueryFiltered.filter(zFilters).data;
            zReturn = zDataFiltered;
        } catch (pError) {
            alert("An error occurred while building the filter data for the getViewDataAll function.");
        }
        // SORT THE DATA
        try {
            var zSort = this.grid.dataSource.sort();
            var zQuerySorted = new kendo.data.Query(zDataFiltered);
            var zDataSorted = zQuerySorted.sort(zSort).data;
            zReturn = zDataSorted;
        } catch (pError) { }
        return zReturn;
    },


    /// Returns a SQL where string based on the filter.
    this.getSqlWhereString = function () {
        var zReturn = "";
        var zNewLine = " "
        if (this.grid != null && this.grid != undefined) {
            if (this.grid.dataSource.filter() != undefined && this.grid.dataSource.filter() != null) {
                for (x = 0; x < this.grid.dataSource.filter().filters.length; x++) {
                    if (this.grid.dataSource.filter().filters[x].filters != undefined && this.grid.dataSource.filter().filters[x].filters != null) {
                        for (y = 0; y < this.grid.dataSource.filter().filters[x].filters.length; y++) {
                            var zOperator = "";
                            var zLogic = this.grid.dataSource.filter().filters[x].logic.toUpperCase();
                            var zField = "[" + this.grid.dataSource.filter().filters[x].filters[y].field + "]";
                            var zValue = this.grid.dataSource.filter().filters[x].filters[y].value;
                            // GET THE OPERATOR
                            switch (this.grid.dataSource.filter().filters[x].filters[y].operator.toLowerCase()) {
                                case "eq": zOperator = " = "; break;
                                case "neq": zOperator = " <> "; break;
                                case "lt": zOperator = " < "; break;
                                case "lte": zOperator = " <= "; break;
                                case "gt": zOperator = " > "; break;
                                case "gte": zOperator = " >= "; break;
                                case "startswith": zOperator = " LIKE "; break;
                                case "endswith": zOperator = " LIKE "; break;
                                case "contains": zOperator = " LIKE "; break;
                                case "doesnotcontain": zOperator = " NOT LIKE "; break;
                                default: zOperator = " = "; break;
                            }
                            // UPDATE BASED ON TYPE
                            var zType = typeof this.grid.dataSource.filter().filters[x].filters[y].value;
                            if (zValue !== undefined && zValue !== null && zValue !== NaN) {
                                switch (zType) {
                                    case "string":
                                        zValue = zValue.replace(/'/g, "''");
                                        if (this.grid.dataSource.filter().filters[x].filters[y].operator.toLowerCase() == "startswith") {
                                            zValue = zValue + "%";
                                        } else if (this.grid.dataSource.filter().filters[x].filters[y].operator.toLowerCase() == "endswith") {
                                            zValue = "%" + zValue;
                                        } else if (this.grid.dataSource.filter().filters[x].filters[y].operator.toLowerCase() == "contains" || this.grid.dataSource.filter().filters[x].filters[y].operator.toLowerCase() == "doesnotcontain") {
                                            zValue = "%" + zValue + "%";
                                        }
                                        zValue = "'" + zValue + "'";
                                        break;
                                    case "number":
                                        // DO NOTHING
                                        break;
                                    case "boolean":
                                        break;
                                    case "object":
                                        if (zValue != null && typeof zValue.getMonth == "function") {
                                            // DATE TYPE
                                            zValue = "'" + this._formatShortDateWithMonth(zValue) + "'";
                                            //zValue = "'" + zValue + "'";
                                        } else {
                                            // OBJECT TYPE
                                            zValue = "'" + zValue + "'";
                                        }
                                        break;
                                    default:
                                        zValue = "'" + zValue + "'";
                                        break;
                                }
                            } else {
                                zValue = "NULL";
                            }
                            // BUILD STRING
                            if (y == 0 && x == 0) {
                                zReturn = zReturn + "WHERE 1 = 1" + zNewLine;
                            }
                            //if (zLogic == "OR") {
                            if (y == 0) {
                                //zReturn = zReturn + zLogic + " (" + zNewLine;
                                zReturn = zReturn + "AND (" + zNewLine;
                                zReturn = zReturn + zField + zOperator + zValue + zNewLine;
                            } else {
                                if (x == 0) {
                                    zReturn = zReturn + zLogic + " " + zField + zOperator + zValue + zNewLine;
                                } else {
                                    zReturn = zReturn + zLogic + " " + zField + zOperator + zValue + zNewLine;
                                }
                            }
                            if (y == this.grid.dataSource.filter().filters[x].filters.length - 1) {
                                zReturn = zReturn + ")" + zNewLine;
                            }
                            //} else {
                            //}
                        }
                    } else {
                        var zOperator = "";
                        var zLogic = this.grid.dataSource.filter().logic.toUpperCase();
                        var zField = "[" + this.grid.dataSource.filter().filters[x].field + "]";
                        var zValue = this.grid.dataSource.filter().filters[x].value;
                        // GET THE OPERATOR
                        switch (this.grid.dataSource.filter().filters[x].operator.toLowerCase()) {
                            case "eq": zOperator = " = "; break;
                            case "neq": zOperator = " <> "; break;
                            case "lt": zOperator = " < "; break;
                            case "lte": zOperator = " <= "; break;
                            case "gt": zOperator = " > "; break;
                            case "gte": zOperator = " >= "; break;
                            case "startswith": zOperator = " LIKE "; break;
                            case "endswith": zOperator = " LIKE "; break;
                            case "contains": zOperator = " LIKE "; break;
                            case "doesnotcontain": zOperator = " NOT LIKE "; break;
                            default: zOperator = " = "; break;
                        }
                        // UPDATE BASED ON TYPE
                        var zType = typeof this.grid.dataSource.filter().filters[x].value;
                        if (zValue !== undefined && zValue !== null && zValue !== NaN) {
                            switch (zType) {
                                case "string":
                                    zValue = zValue.replace(/'/g, "''");
                                    if (this.grid.dataSource.filter().filters[x].operator.toLowerCase() == "startswith") {
                                        zValue = zValue + "%";
                                    } else if (this.grid.dataSource.filter().filters[x].operator.toLowerCase() == "endswith") {
                                        zValue = "%" + zValue;
                                    } else if (this.grid.dataSource.filter().filters[x].operator.toLowerCase() == "contains" || this.grid.dataSource.filter().filters[x].operator.toLowerCase() == "doesnotcontain") {
                                        zValue = "%" + zValue + "%";
                                    }
                                    zValue = "'" + zValue + "'";
                                    break;
                                case "number":
                                    // DO NOTHING
                                    break;
                                case "boolean":
                                    break;
                                case "object":
                                    if (zValue != null && typeof zValue.getMonth == "function") {
                                        // DATE TYPE
                                        zValue = "'" + this._formatShortDateWithMonth(zValue) + "'";
                                        //zValue = "'" + zValue + "'";
                                    } else {
                                        // OBJECT TYPE
                                        zValue = "'" + zValue + "'";
                                    }
                                    break;
                                default:
                                    zValue = "'" + zValue + "'";
                                    break;
                            }
                        } else {
                            zValue = "NULL";
                        }
                        // BUILD STRING
                        if (x == 0) {
                            zReturn = zReturn + "WHERE 1 = 1" + zNewLine;
                            //zReturn = zReturn + zLogic + "( " + zField + zOperator + zValue + zNewLine;
                            zReturn = zReturn + zLogic + " " + zField + zOperator + zValue + zNewLine;
                        } else {
                            zReturn = zReturn + zLogic + " " + zField + zOperator + zValue + zNewLine;
                        }
                        //if (x == this.grid.dataSource.filter().filters.length - 1) {
                        //    zReturn = zReturn + ")" + zNewLine;
                        //}
                    }
                }
            }
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
    },


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
    },


    /// A function to call a REST service
    /// pURL (STRING)
    /// pService (STRING)
    /// pData (JSON STRING)
    /// pSuccess (optional FUNCTION)
    /// pError (optional FUNCTION)
    this._callRestService = function (pURL, pData, pSuccess, pError, pParms) {
        try {
            $.ajax({
                type: this.optionsConstant.serviceMethod,
                url: pURL,
                data: pData,
                timeout: 120000,
                cache: false,
                processData: true,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (pResults) {
                    if (pSuccess != undefined) {
                        pSuccess(pResults, pParms);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    if (pError != undefined) {
                        pError(pResults, pMessage, pErrorDetail, pParms);
                    } else {
                        alert("Error: " + pMessage);
                    }
                }
            });
        } catch (pErrorMessage) {
            alert("Error: " + pErrorMessage);
        }
    },


    /// A function to scan and repair the grid meta data objects against a master set.
    /// pMasterMetaData (JSON OBJECT) custom JSON object holding the schema, columns, and indices data. The same object is returned after repair.
    ///                               { "schema": schemaObject, "columns": columnsArray, "indices": indicesObject, "sources": sourcesObject }
    /// pIsAutoRebuild (BOOLEAN) Flag for automatically rebuilding the grid after the scan and repair is complete.
    /// pIsEditMode (BOOLEAN) Flag for indicating edit mode. OPTIONAL
    this.repairMetaDataObject = function (pMasterMetaData, pIsAutoRebuild, pIsEditMode) {
        this._isRebuildRequired = false;
        if (pMasterMetaData.schema !== undefined && pMasterMetaData.schema !== null) {
            pMasterMetaData.schema = this._repairMetaDataSchema(pMasterMetaData.schema);
        }
        if (pMasterMetaData.columns !== undefined && pMasterMetaData.columns !== null) {
            pMasterMetaData.columns = this._repairMetaDataColumns(pMasterMetaData.columns);
        }
        if (pMasterMetaData.indices !== undefined && pMasterMetaData.indices !== null) {
            pMasterMetaData.indices = this._repairMetaDataColumnIndices(pMasterMetaData.indices, pMasterMetaData.columns);
        }
        if (pMasterMetaData.sources !== undefined && pMasterMetaData.sources !== null) {
            pMasterMetaData.sources = this._repairMetaDataSources(pMasterMetaData.sources);
        }
        if (pIsAutoRebuild && this._isRebuildRequired) {
            if (pIsEditMode === undefined || pIsEditMode === null) {
                this.rebuildGrid(false, pMasterMetaData.schema, pMasterMetaData.columns, null, null, null, null, pMasterMetaData.indices, pMasterMetaData.sources);
            } else {
                this.rebuildGrid(pIsEditMode, pMasterMetaData.schema, pMasterMetaData.columns, null, null, null, null, pMasterMetaData.indices, pMasterMetaData.sources);
            }
        }
        pMasterMetaData["isRebuildRequired"] = this._isRebuildRequired;
        return pMasterMetaData;
    },


    /// A funciton to loop through a master schema object to compare to the existing schema object, and make and changes needed.
    /// Returns the repaired object for any client side adjustments needed to the grid, or null if an error or if nothing is passed in master object.
    /// pMasterSchema (JSON OBJECT) object of a kendo dataSource grid schema for compare and repair
    this._repairMetaDataSchema = function (pMasterSchema) {
        var zSchema = null;
        if (pMasterSchema !== undefined && pMasterSchema !== null && pMasterSchema.model.fields !== undefined && pMasterSchema.model.fields !== null) {
            zSchema = this.grid.dataSource.options.schema;
            if (pMasterSchema.model.fields !== undefined && pMasterSchema.model.fields !== null) {
                // ADD ANY FIELDS THAT ARE ADDED BUT MISSING
                for (var zField in pMasterSchema.model.fields) {
                    if (zField != undefined) {
                        if (zSchema.model.fields[zField] === undefined) {
                            zSchema.model.fields[zField] = pMasterSchema.model.fields[zField];
                            this._isRebuildRequired = true;
                        }
                    }
                }
                // REMOVE ANY FIELDS THAT ARE SUPPOSED TO BE REMOVED
                for (var zField in zSchema.model.fields) {
                    if (zField != undefined) {
                        if (pMasterSchema.model.fields[zField] === undefined) {
                            delete zSchema.model.fields[zField];
                            this._isRebuildRequired = true;
                        }
                    }
                }
            }
        }
        return zSchema;
    },


    /// A funciton to loop through a master columns array to compare to the existing columns array, and make and changes needed.
    /// Returns the repaired array for any client side adjustments needed to the grid, or null if an error or if nothing is passed in master object.
    /// pMasterColumns (ARRAY) array of a kendo dataSource grid columns for compare and repair
    this._repairMetaDataColumns = function (pMasterColumns) {
        var zColumns = null;
        var zIsMissing = true;
        var zField = "";
        if (pMasterColumns !== undefined && pMasterColumns !== null) {
            zColumns = this.grid.columns;
            // ADD ANY FIELDS THAT ARE ADDED BUT MISSING
            for (var x = 0; x < pMasterColumns.length; x++) {
                zIsMissing = true;
                for (var y = 0; y < zColumns.length; y++) {
                    if (pMasterColumns[x] != undefined && zColumns[y] != undefined) {
                        if (pMasterColumns[x].field != undefined && zColumns[y].field != undefined) {
                            if (pMasterColumns[x].field == zColumns[y].field) {
                                zIsMissing = false;
                                break;
                            }
                        }
                    }
                }
                if (zIsMissing) {
                    zColumns.push(pMasterColumns[x]);
                    this._isRebuildRequired = true;
                }
            }
            // REMOVE ANY FIELDS THAT ARE SUPPOSED TO BE REMOVED
            var zDeleteArray = new Array();
            for (var x = 0; x < zColumns.length; x++) {
                zIsMissing = true;
                for (var y = 0; y < pMasterColumns.length; y++) {
                    if (pMasterColumns[y] != undefined && zColumns[x] != undefined) {
                        if (pMasterColumns[y].field != undefined && zColumns[x].field != undefined) {
                            if (pMasterColumns[y].field == zColumns[x].field) {
                                zIsMissing = false;
                                break;
                            }
                        }
                    }
                }
                if (zIsMissing) {
                    zDeleteArray.push(x);
                }
            }
            if (zDeleteArray.length > 0) {
                for (var x = zDeleteArray.length - 1; x > -1; x--) {
                    zColumns.splice(zDeleteArray[x], 1);
                    this._isRebuildRequired = true;
                }
            }
        }
        return zColumns;
    },


    /// A funciton to loop through a master sources object to compare to the existing sources object, and make and changes needed.
    /// Returns the repaired object for any client side adjustments needed to the grid, or null if an error or if nothing is passed in master object.
    /// pMasterSources (OBJECT) array of a sources not related to kendo for compare and repair
    this._repairMetaDataSources = function (pMasterSources) {
        var zSources = null;
        if (pMasterSources !== undefined && pMasterSources !== null) {
            zSources = this.columnSources;
            // ADD ANY FIELDS THAT ARE ADDED BUT MISSING
            for (var zField in pMasterSources) {
                if (zField != undefined) {
                    if (zSources[zField] === undefined) {
                        zSources[zField] = pMasterSources[zField];
                        this._isRebuildRequired = true;
                    }
                }
            }
            // REMOVE ANY FIELDS THAT ARE SUPPOSED TO BE REMOVED
            for (var zField in zSources) {
                if (zField != undefined) {
                    if (pMasterSources[zField] === undefined) {
                        delete zSources[zField];
                        this._isRebuildRequired = true;
                    }
                }
            }
        }
        return zSources;
    },


    /// A funciton to loop through a master column indices object to compare to the existing column indices object, and make and changes needed.
    /// Returns the repaired object for any client side adjustments needed to the grid, or null if an error or if nothing is passed in master object.
    /// pMasterColumns (OBJECT) object of column indices for compare and repair
    this._repairMetaDataColumnIndices = function (pMasterIndices, pRepairedColumns) {
        var zIndices = null;
        var zNextIndexNumber = -1;
        if (pMasterIndices !== undefined && pMasterIndices !== null) {
            zIndices = this.columnIndices;
            // FIND THE HIGHEST INDEX NUMBER
            for (var zField in pMasterIndices) {
                if (zField != undefined) {
                    if (pMasterIndices[zField] > zNextIndexNumber) {
                        zNextIndexNumber = pMasterIndices[zField];
                    }
                }
            }
            // REPAIR THE LIST OF INDICES
            if (pMasterIndices !== undefined && pMasterIndices !== null) {
                // ADD ANY FIELDS THAT ARE ADDED BUT MISSING
                for (var zField in pMasterIndices) {
                    if (zField != undefined) {
                        if (zIndices[zField] === undefined) {
                            zIndices[zField] = zNextIndexNumber + 1;
                            zNextIndexNumber++;
                            this._isRebuildRequired = true;
                        }
                    }
                }
                // REMOVE ANY FIELDS THAT ARE SUPPOSED TO BE REMOVED
                for (var zField in zIndices) {
                    if (zField != undefined) {
                        if (pMasterIndices[zField] === undefined) {
                            delete zIndices[zField];
                            this._isRebuildRequired = true;
                        }
                    }
                }
            }
            // RE-ARRANGE THE INDICES TO MATCH THE CORRECTED COLUMNS OBJECT
            if (this._isRebuildRequired) {
                for (var x = 0; x < pRepairedColumns.length; x++) {
                    for (var zField in zIndices) {
                        if (zField != undefined) {
                            var zFieldSuffix = zField.replace("idx", "");
                            if (zFieldSuffix != undefined && zFieldSuffix == pRepairedColumns[x].field) {
                                zIndices[zField] = x;
                                this._isRebuildRequired = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
        return zIndices;
    },


    /// Rebuilds the DOM object and Kendo grid and re-apply all existing filters, sorts, pages, etc.
    /// pIsEditMode (BOOLEAN) Flag for indicating edit mode. OPTIONAL
    /// pSchema (OBJECT) New schema object to add to the grid rebuild. OPTIONAL
    /// pColumns (OBJECT) New columns object to add to the grid rebuild. OPTIONAL
    /// pData (OBJECT) New data set for the grid to be rebuilt. OPTIONAL
    /// pSort (JSON OBJECT) object indicating pre-sort. OPTIONAL
    /// pFilter (JSON OBJECT) object indicating pre-filter. OPTIONAL
    /// pPage (JSON OBJECT) object indicating the page to be set. OPTIONAL
    this.rebuildGrid = function (pIsEditMode, pSchema, pColumns, pData, pSort, pFilter, pPage, pColumnIndices, pColumnSources) {
        // CAPTURE THE DATA, FILTER, SORT, AND OTHER REQUIRED SETTINGS
        var zSchema = null;
        if (pSchema != undefined && pSchema != null) {
            zSchema = pSchema;
            if (this.optionsConstant.isServerLoading) {
                zSchema.data = this.optionsConstant.serverLoadingNodeNameData;
                zSchema.total = this.optionsConstant.serverLoadingNodeNameTotal;
            }
        } else {
            zSchema = this.grid.dataSource.options.schema;
        }
        var zColumns = null;
        if (pColumns != undefined && pColumns != null) { zColumns = pColumns; } else { zColumns = this.grid.columns; }
        var zData = null;
        if (pData != undefined && pData != null) { zData = pData; } else { zData = this.grid.dataSource.data(); }
        var zFilter = null;
        if (pFilter != undefined && pFilter != null) { zFilter = pFilter; } else { zFilter = this.grid.dataSource.filter(); }
        var zSort = null;
        if (pSort != undefined && pSort != null) { zSort = pSort; } else { zSort = this.grid.dataSource.sort(); }
        var zPage = null;
        if (pPage != undefined && pPage != null) { zPage = pPage; } else { zPage = this.grid.dataSource.page(); }
        var zColumnIndices = null;
        if (pColumnIndices != undefined && pColumnIndices != null) { zColumnIndices = pColumnIndices; } else { zColumnIndices = this.columnIndices; }
        var zColumnSources = null;
        if (pColumnSources != undefined && pColumnSources != null) { zColumnSources = pColumnSources; } else { zColumnSources = this.columnSources; }
        var zScrollLeft = this.grid.scrollables[0].scrollLeft;
        var zScrollTop = this.grid.wrapper.find(".k-grid-content")[0].scrollTop;
        var zSelectedRow = this.grid.select();
        var zUID = zSelectedRow.data("uid");

        // REBUILD THE GRID
        var zGridId = this._gridDOM.replace("#", "");
        this.grid.destroy();
        $(this._gridContainerDOM).html("");
        $(this._gridContainerDOM).html('<div id="' + zGridId + '"></div>');
        this._setupGrid(this._gridDOM, zData, zSchema, zColumns, pIsEditMode);

        // RE-APPLY THE SETTINGS
        this.grid.dataSource.filter(zFilter);
        this.grid.dataSource.page(zPage);
        this.grid.dataSource.sort(zSort);
        this.columnIndices = null;
        this.columnIndices = zColumnIndices;
        this.columnSources = null;
        this.columnSources = zColumnSources;
        this.grid.scrollables[0].scrollLeft = zScrollLeft;
        this.grid.scrollables[0].scrollTop = zScrollTop;
        this.grid.content[0].scrollLeft = zScrollLeft;
        this.grid.content[0].scrollTop = zScrollTop;
        var zNewRow = this.grid.table.find('tr[data-uid="' + zUID + '"]');
        this.grid.select(zNewRow);

        // RE-APPLY THE EVENTS
        this._setupEventsToolTips();
        this._setupColumnMenuHides();
    };
};