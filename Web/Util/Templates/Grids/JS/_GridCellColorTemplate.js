

function(pData) {
    var zReturn = " ";
    var zField = "{{tblMetaGridColumn.field}}";
    var zFieldColor = "{{tblMetaGridColumn.FldFieldNameBackColor}}";
    zReturn = "<div class='gridColorHighlight elecequipcColor' style='background-color: " + pData[zFieldColor] + "'>" + pData[zField] + "</div>";
    return zReturn;
}


function(pData) {
    var zTemplate = ' ';
    var zFieldName = 'totalscore';
    var zFieldNameColor = 'totalscoreColor';
    var zTemplate = "<div class='gridColorHighlight " + zFieldNameColor + "' style='background-color: " + pData[zFieldNameColor] + "'>" + pData[zFieldName] + "</div>";return zTemplate;}
