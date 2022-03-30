function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecgrounding !== undefined) {
        switch (pData.elecgrounding.toString().toLowerCase()) {
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
        zReturn = "<div class='gridColorHighlight elecgroundingColor' style='background-color: " + zColor + "'>" + pData.elecgrounding + "</div>";
    }
    return zReturn;
}