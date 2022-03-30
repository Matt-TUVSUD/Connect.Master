function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecultrasound !== undefined) {
        switch (pData.elecultrasound.toString().toLowerCase()) {
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
        zReturn = "<div class='gridColorHighlight elecultrasoundColor' style='background-color: " + zColor + "'>" + pData.elecultrasound + "</div>";
    }
    return zReturn;
}