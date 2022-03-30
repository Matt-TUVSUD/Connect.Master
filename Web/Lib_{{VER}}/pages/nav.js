/////////////////////////////////////////////
////// FUNCTION FOR TREEVIEW SIDE NAV
function onExpanding(sender, args) {
    //// GET THE CURRENT PAGE
    var tempCurrentPage = "0";
    var tempGUID = getGSafeGUID();
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.loadPageIdTabId(tempGUID);
    for (i = 0; i < collDetail().length; i++) {
        if (collDetail()[i].DataName() == "currentPage") {
            tempCurrentPage = collDetail()[i].DataValue();
        }
    }

    //// WALK THROUGH NODES AND SET LAST EXPANDED TO BOLD
    //// LEAVE CURRENT PAGE BOLD
    var allNodes = sender.get_allNodes();
    for (var i = 0; i < allNodes.length; i++) {
        // LEAVE CURRENT PAGE ALONE
        if (allNodes[i]._properties._data.value !== tempCurrentPage) {
            allNodes[i].set_cssClass("notSelected");
        }
    }
    var currentNode = args.get_node();
    currentNode.set_cssClass("selected");
}

function onMouseOver(sender, args) {
    //// IF THIS NODE HAS CHILDRED, EXPAND IT
    var node = args.get_node();
    var childCount = node.get_nodes().get_count();
    if (childCount > 0) {
        node.expand();
    }

    //// IF THE NODE IS ONE OF THE MAIN PRACTICES, CHANGE THE BANNER AND DETAILS
    //// FIRE
    switch (node._getData().value) {
        case utilConstants.pageId_Fire:
            hoverBanner("1");
            break;
        case utilConstants.pageId_Boiler:
            hoverBanner("2");
            break;
        case utilConstants.pageId_Infrared:
            hoverBanner("3");
            break;
        case utilConstants.pageId_Juris:
            hoverBanner("4");
            break;
        case utilConstants.pageId_Seismic:
            hoverBanner("5");
            break;
        case utilConstants.pageId_Wind:
            hoverBanner("5");
            break;
        case utilConstants.pageId_Flood:
            hoverBanner("5");
            break;
        default:
            break;
    }
}