/* globals $ */
$.fn.gallery = function(cols) {
    cols = cols || 4;
    var gallery = this,
        galleryList = gallery.children('.gallery-list'),
        selected = gallery.children('.selected'),
        disabled = $('<div>').addClass('disabled-background');

    gallery.addClass('gallery');
    selected.hide();

    galleryList.children().each(function(index, el) {
        if (index % cols === 0) {
            $(el).addClass('clearfix');
        }
    });

    galleryList.on('click', '.image-container', function(ev) {

        disabled.appendTo(gallery);
        galleryList.addClass('blurred');
        var image = $(ev.target),
            prevImage = selected.find('.previous-image').find('img'),
            currentImage = selected.find('.current-image').find('img'),
            nextImage = selected.find('.next-image').find('img');

        var prev = getImg(image, -1);
        setSrcAndDataInfo(prevImage, prev);

        setSrcAndDataInfo(currentImage, image);

        var next = getImg(image, 1);
        setSrcAndDataInfo(nextImage, next);

        selected.show();
    });

    selected.on('click', function(ev) {
        var image = $(ev.target),

            img2 = $('#current-image'),
            img3 = $('#next-image'),
            prev, curr, next;

        if (image.attr('id') === 'previous-image') {

            prev = getImg(image, -1);
            setSrcAndDataInfo(image, prev);

            curr = getImg(prev, 1);
            setSrcAndDataInfo(img2, curr);

            next = getImg(curr, 1);
            setSrcAndDataInfo(img3, next);

        } else if (image.attr('id') === 'current-image') {
            selected.hide();
            disabled.remove();
            galleryList.removeClass('blurred');
        } else if (image.attr('id') === 'next-image') {
            img3 = $('#previous-image');

            prev = getImg(image, 1);
            setSrcAndDataInfo(image, prev);

            curr = getImg(prev, -1);
            setSrcAndDataInfo(img2, curr);

            next = getImg(curr, -1);
            setSrcAndDataInfo(img3, next);
        }
    });

    function setSrcAndDataInfo(destination, element) {
        destination.attr({
            src: element.attr('src'),
            'data-info': element.attr('data-info')
        });
        return destination;
    }

    function getImg(image, prevOrNext) {
        var index = (image.attr('data-info') * 1) - 1;
        var nextImage;
        if (index === galleryList.children().length - 1 && prevOrNext > 0) {
            index = -1 + prevOrNext;
        } else if (index === 0 && prevOrNext < 0) {
            index = galleryList.children().length + prevOrNext;
        } else {
            index += prevOrNext;
        }
        nextImage = $(galleryList.children()[index]).find('img');
        return nextImage;
    }
    return gallery; //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
};
