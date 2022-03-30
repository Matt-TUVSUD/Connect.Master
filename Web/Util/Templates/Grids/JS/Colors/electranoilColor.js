﻿function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.electranoil !== undefined) {
        switch (pData.electranoil.toString().toLowerCase()) {
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
        zReturn = "<div class='gridColorHighlight electranoilColor' style='background-color: " + zColor + "'>" + pData.electranoil + "</div>";
    }
    return zReturn;
}