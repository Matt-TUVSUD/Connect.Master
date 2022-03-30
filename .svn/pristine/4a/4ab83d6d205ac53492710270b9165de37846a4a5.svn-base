function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecswitch !== undefined) {
        switch (pData.elecswitch.toString().toLowerCase()) {
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
        zReturn = "<div class='gridColorHighlight elecswitchColor' style='background-color: " + zColor + "'>" + pData.elecswitch + "</div>";
    }
    return zReturn;
}