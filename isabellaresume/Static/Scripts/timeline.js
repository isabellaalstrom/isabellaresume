jQuery(document).ready(function ($) {
    var timelineBlocks = $('.cd-timeline-block'),
		offset = 0.8;

    //hide timeline blocks which are outside the viewport
    hideBlocks(timelineBlocks, offset);

    //on scolling, show/animate timeline blocks when enter the viewport
    $(window).on('scroll', function () {
        (!window.requestAnimationFrame)
			? setTimeout(function () { showBlocks(timelineBlocks, offset); }, 100)
			: window.requestAnimationFrame(function () { showBlocks(timelineBlocks, offset); });
    });

    function hideBlocks(blocks, offset) {
        blocks.each(function () {
            ($(this).offset().top > $(window).scrollTop() + $(window).height() * offset) && $(this).find('.cd-timeline-img, .cd-timeline-content').addClass('is-hidden');
        });
    }

    function showBlocks(blocks, offset) {
        blocks.each(function () {
            ($(this).offset().top <= $(window).scrollTop() + $(window).height() * offset && $(this).find('.cd-timeline-img').hasClass('is-hidden')) && $(this).find('.cd-timeline-img, .cd-timeline-content').removeClass('is-hidden').addClass('bounce-in');
        });
    }

    $("#education").click(function () {
        $(".workplace-block").addClass("hidden");
        $(".project-block").addClass("hidden");
        $(".course-block").addClass("hidden");
        $(".education-block").removeClass("hidden");
        $(".education-block").children().addClass("bounce-in");
    });

    $("#workplace").click(function () {
        $(".education-block").addClass("hidden");
        $(".project-block").addClass("hidden");
        $(".course-block").addClass("hidden");
        $(".workplace-block").removeClass("hidden");
        $(".workplace-block").children().addClass("bounce-in");
    });

    $("#project").click(function () {
        $(".workplace-block").addClass("hidden");
        $(".education-block").addClass("hidden");
        $(".course-block").addClass("hidden");
        $(".project-block").removeClass("hidden");
        $(".project-block").children().addClass("bounce-in");
    });

    $("#course").click(function () {
        $(".workplace-block").addClass("hidden");
        $(".project-block").addClass("hidden");
        $(".education-block").addClass("hidden");
        $(".course-block").removeClass("hidden");
        $(".course-block").children().addClass("bounce-in");
    });

});