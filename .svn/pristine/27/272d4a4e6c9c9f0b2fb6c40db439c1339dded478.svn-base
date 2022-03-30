$(document).ready(function () {

    // Enable Sticky Header
    $("#bluebar").sticky({topSpacing:0});


    // Enable printThis
    $(".content").on("click",".printThis",function(){
        var setID = $(this).closest("div").attr("id");
        var buildID = "#" + setID;
        $(buildID).printThis();
        return false;
    });

    // Enable printAll
    $(".printAllContainer").on("click", ".printAll", function () {
        window.print();
        return false;
    });
    

    // targetblank trick (keep code validated strict!!)
    $('a.targetblank').click( function(){
        window.open(this.href);
        return false;
    });


    // Search Box (find)
    $("#searchbox").on("change keyup copy paste cut", function () {
        // clear any current highlighted items
        $("body").unhighlight();
        
        // get current search term
        var searchTerm = $(this).val();

        // find search term in document
        $("body .content").highlight(searchTerm);

        // look for ie x clear on searchbox
        var startTimer = setInterval(function () {
            var checkifempty = $("#searchbox").val().length;
            if (checkifempty === 0) {
                $("body").unhighlight();
                clearInterval(startTimer);
                $("#count").html("");
            }
        }, 500);

        // set search results text
        var y = $("span.highlight").length;
        if (y > 100) {
            $("#count").html("More than 100 matches");
            $("#ifFound").show();
        } else if (y == 0) {
            $("#count").html("No matches found");
            $("#ifFound").hide();
        } else {
            $("#count").html(y + " matches");
            $("#ifFound").show();
        }
    });


    // Select Drop Down Pick & Scroll to Section
    var bluebar = $("#bluebar").outerHeight();
    $("#pickTopic").change(function () {
        function triggerAnimate(getoffset) {
            $("html, body").animate({
                scrollTop: getoffset
            }, 1000);
        }

        var target = "#" + $(this).val();
        var getoffset = 0;

        if (target === "#") {
            getoffset = 0;
            triggerAnimate(getoffset);
        } else if ($(target).length > 0) {
            getoffset = $(target).offset().top;
            getoffset = getoffset - bluebar;
            getoffset = getoffset - 14;
            triggerAnimate(getoffset);
        } else {
            alert ("Error: This section (" + target + ") does not exist.");
        }
        $(this).blur(); //unfocus on dropdown box (prevent highlighting)
    });
    

    // Set padding to height of window so scroll can reach bottom items
	var curWinHeight = $(window).height();
	$("#content").css("padding-bottom", curWinHeight + "px");
	$(window).resize(function () {
        curWinHeight = $(window).height();      // viewport
        $("#content").css("padding-bottom", curWinHeight + "px");
	});


    // Set Select Dropdown to Item you are actively on as you scroll
    $(window).scroll(function () {
        var windscroll = $(window).scrollTop();
        var fixSize = 60;

        if (windscroll >= fixSize){
	        $(".content,h5,h6").each(function () {
	            var scrollSpot = $(document).scrollTop();   // scroll position
	            var elmPosition = $(this).offset().top;     // position of element on page
	            var checkInView = elmPosition - scrollSpot;
                
	            if (checkInView < fixSize+25) {
	                $("#pickTopic").val($(this).attr("id"));
                }
	        });

	    } else {
	        $("#pickTopic").val("");
	    }
	}).scroll();

});