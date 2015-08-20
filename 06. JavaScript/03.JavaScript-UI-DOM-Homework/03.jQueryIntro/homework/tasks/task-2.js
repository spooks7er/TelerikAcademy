/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function(element) {

        element = $(element);

        if (element.length === 0) {
            throw new Error('Invalid or empty selector');
        }

        element.children('.button').text('hide');
        element.on('click', '.button', function(ev) {
            var button = $(this),
                content = button.next();

            while (!content.hasClass('content')) {
                content = content.next();
            }

            if (content.css('display') === 'none') {
                content.css('display', '');
                button.text('hide');
            } else {
                content.css('display', 'none');
                button.text('show');
            }
        });
    };
}

module.exports = solve;
