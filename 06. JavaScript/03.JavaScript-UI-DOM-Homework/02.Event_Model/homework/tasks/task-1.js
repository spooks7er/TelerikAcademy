/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve() {
    return function(element) {

        if (typeof element === 'string') {
            element = document.getElementById(element);
        }

        var buttons = element.querySelectorAll('.button');
        for (var i = 0, len = buttons.length; i < len; i += 1) {
            var button = buttons[i];
            button.innerHTML = 'hide';
        }

        element.addEventListener('click', function(ev) {
            var button,
                content;

            button = ev.target;
            content = button.nextElementSibling;

            while (content.className !== 'content') {
                content = content.nextElementSibling;
            }

            if (content.className !== 'content') {
                return;
            }

            if (button.innerHTML === 'hide') {
                button.innerHTML = 'show';
                content.style.display = 'none';
            } else {
                button.innerHTML = 'hide';
                content.style.display = '';
            }
        }, false);
    };
}

module.exports = solve;
