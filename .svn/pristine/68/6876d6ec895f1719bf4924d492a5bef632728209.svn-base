function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecrelay !== undefined) {
        switch (pData.elecrelay.toString().toLowerCase()) {
            case "adequate":
            case "not applicable":
                zColor = "{{tblMetaColorAlias.fldAlias=Adequate}}";
                break;
            case "inadequate":
                zColor = "{{tblMetaColorAlias.fldAlias=Inadequate}}";
                break;
            case "tolerable":
                zColor = "{{tblMetaColorAlias.fldAlias=Tolerable}}";
                break;
        }
        zReturn = "<div class='gridColorHighlight elecrelayColor' style='background-color: " + zColor + "'>" + pData.elecrelay + "</div>";
    }
    return zReturn;
}