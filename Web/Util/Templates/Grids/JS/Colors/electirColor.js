function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.electir !== undefined) {
        switch (pData.electir.toString().toLowerCase()) {
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
        zReturn = "<div class='gridColorHighlight electirColor' style='background-color: " + zColor + "'>" + pData.electir + "</div>";
    }
    return zReturn;
}