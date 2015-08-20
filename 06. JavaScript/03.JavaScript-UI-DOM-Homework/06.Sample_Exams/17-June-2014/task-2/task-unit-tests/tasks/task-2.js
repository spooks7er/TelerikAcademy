function solve() {
    return function() {
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

                var prev = getPrevImg(image);
                prevImage.attr('src', prev.attr('src'));
                prevImage.attr('data-info', prev.attr('data-info'));

                currentImage.attr('src', image.attr('src'));
                currentImage.attr('data-info', image.attr('data-info'));

                var next = getNextImg(image);
                nextImage.attr('src', getNextImg(image).attr('src'));
                nextImage.attr('data-info', next.attr('data-info'));
                selected.show();
            });

            selected.on('click', function(ev) {
                var image = $(ev.target);

                if (image.attr('id') === 'previous-image') {
                    var img2 = $('#current-image'),
                        img3 = $('#next-image');

                    var prev = getPrevImg(image);
                    image.attr('src', prev.attr('src'));
                    image.attr('data-info', prev.attr('data-info'));

                    var curr = getNextImg(prev);
                    img2.attr('src', curr.attr('src'));
                    img2.attr('data-info', curr.attr('data-info'));

                    var next = getNextImg(curr);
                    img3.attr('src', next.attr('src'));
                    img3.attr('data-info', next.attr('data-info'));

                } else if (image.attr('id') === 'current-image') {
                    selected.hide();
                    disabled.remove();
                    galleryList.removeClass('blurred')
                } else if (image.attr('id') === 'next-image') {
                    var img2 = $('#current-image'),
                        img3 = $('#previous-image');

                    var prev = getNextImg(image);
                    image.attr('src', prev.attr('src'));
                    image.attr('data-info', prev.attr('data-info'));

                    var curr = getPrevImg(prev);
                    img2.attr('src', curr.attr('src'));
                    img2.attr('data-info', curr.attr('data-info'));

                    var next = getPrevImg(curr);
                    img3.attr('src', next.attr('src'));
                    img3.attr('data-info', next.attr('data-info'));
                }
            });

            function getPrevImg(image) {
                var index = (image.attr('data-info') * 1) - 1;
                var nextImage;
                if (index === 0) {
                    index = galleryList.children().length - 1;
                } else {
                    index -= 1;
                }
                nextImage = $(galleryList.children()[index]).find('img');
                return nextImage;
            }

            function getNextImg(image) {
                var index = (image.attr('data-info') * 1) - 1;
                var prevImage;
                if (index === galleryList.children().length - 1) {
                    index = 0;
                } else {
                    index += 1;
                }
                prevImage = $(galleryList.children()[index]).find('img');
                return prevImage;
            }
        };
    };
}

module.exports = solve;
