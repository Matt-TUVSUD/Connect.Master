function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecother !== undefined) {
        switch (pData.elecother.toString().toLowerCase()) {
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
        zReturn = "<div class='gridColorHighlight elecotherColor' style='background-color: " + zColor + "'>" + pData.elecother + "</div>";
    }
    return zReturn;
}