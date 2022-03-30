//<!-- FOR KENDO GRID ROW DETAIL TEMPLATES -->
//<!-- CELL DATA REPLACERS USE #= NameOfField # -->
//<!-- AVOID USING # AS A CHARACTER IN THE TEMPLATE -->
//<!-- IF USING A CLASS LOOKUP TO THE GRID, MAKE SURE THAT CLASS IS IN THE COLUMN TEMPLATE -->
//<!-- SCRIPTS INCLUDED HERE GET RUN EVERY TIME THE DETAIL POPUP IS OPENED -->
//<!-- WHEN COPIED TO THE DATABASE, THE HTML AND JS MUST BE ALL IN ONE LINE -->

//function (pData){var zReturn=" "; var zColor="transparent"; if (pData.RecCategory !==undefined){switch (pData.RecCategory.toLowerCase()){case "high": zColor="{{tblMetaColorAlias.fldAlias=High}}"; break; case "moderate": zColor="{{tblMetaColorAlias.fldAlias=Moderate}}"; break; case "low": zColor="{{tblMetaColorAlias.fldAlias=Low}}"; break;}zReturn="<div class='gridColorHighlight RecCategoryColor' style='background-color: " + zColor + "'>" + pData.RecCategory + "</div>";}return zReturn;}


function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.RecCategory !== undefined) {
        switch (pData.RecCategory.toLowerCase()) {
            case "high":
                zColor = "{{tblMetaColorAlias.fldAlias=High}}";
                break;
            case "moderate":
                zColor = "{{tblMetaColorAlias.fldAlias=Moderate}}";
                break;
            case "low":
                zColor = "{{tblMetaColorAlias.fldAlias=Low}}";
                break;
        }
        zReturn = "<div class='gridColorHighlight RecCategoryColor' style='background-color: " + zColor + "'>" + pData.RecCategory + "</div>";
    }
    return zReturn;
}


function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.ResponseStatus !== undefined) {
        switch (pData.ResponseStatus.toLowerCase()) {
            case "overdue":
                zColor = "{{tblMetaColorAlias.fldAlias=Overdue}}";
                break;
            case "pending":
                zColor = "{{tblMetaColorAlias.fldAlias=Pending}}";
                break;
            case "completed":
                zColor = "{{tblMetaColorAlias.fldAlias=Completed}}";
                break;
        }
        zReturn = "<div class='gridColorHighlight ResponseStatusColor' style='background-color: " + zColor + "'>" + pData.ResponseStatus + "</div>";
    }
    return zReturn;
}
