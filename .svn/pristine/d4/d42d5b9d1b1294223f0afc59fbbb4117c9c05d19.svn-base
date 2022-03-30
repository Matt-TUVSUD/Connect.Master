function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecmotor !== undefined) {
        switch (pData.elecmotor.toString().toLowerCase()) {
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
        zReturn = "<div class='gridColorHighlight elecmotorColor' style='background-color: " + zColor + "'>" + pData.elecmotor + "</div>";
    }
    return zReturn;
}