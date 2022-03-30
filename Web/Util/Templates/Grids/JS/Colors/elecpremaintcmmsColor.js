function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecpremaintcmms !== undefined) {
        switch (pData.elecpremaintcmms.toString().toLowerCase()) {
            case "adequate":
            case "not applicable":
                zColor = "{{tblMetaColorAlias.fldAlias=Adequate}}";
                break;
            case "inadequate":
                zColor = "{{tblMetaColorAlias.fldAlias=Inadequate}}";
                break;
        }
        zReturn = "<div class='gridColorHighlight elecpremaintcmmsColor' style='background-color: " + zColor + "'>" + pData.elecpremaintcmms + "</div>";
    }
    return zReturn;
}