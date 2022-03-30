function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecpremaintadequate !== undefined) {
        switch (pData.elecpremaintadequate.toString().toLowerCase()) {
            case "adequate":
                zColor = "{{tblMetaColorAlias.fldAlias=Adequate}}";
                break;
            case "inadequate":
                zColor = "{{tblMetaColorAlias.fldAlias=Inadequate}}";
                break;
            case "tolerable":
                zColor = "{{tblMetaColorAlias.fldAlias=Tolerable}}";
                break;
        }
        zReturn = "<div class='gridColorHighlight elecpremaintadequateColor' style='background-color: " + zColor + "'>" + pData.elecpremaintadequate + "</div>";
    }
    return zReturn;
}