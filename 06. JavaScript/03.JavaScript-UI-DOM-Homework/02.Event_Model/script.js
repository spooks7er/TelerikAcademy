// function fillElement(element, array) {
//     var i, arrayLen = array.length,
//         docFrag = document.createDocumentFragment();

//     if (typeof element === 'string') {
//         element = document.getElementById(element);
//     }

//     for (i = 0; i < arrayLen; i += 1) {
//         if (!(typeof array[i]  === 'string' || typeof array[i]  === 'number')) {
//             throw new Error('invalid content elements');
//         }
//         var newCont = document.createElement('button');
//         newCont.className = 'button';
//         newCont.innerHTML = array[i];
//         docFrag.appendChild(newCont);
//     }

//     element.innerHTML = '';
//     element.appendChild(docFrag);
// }


function hideAndShowContent(element) {

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

            if (ev.target.className !== 'button') {
                return;
            }

            button = ev.target;
            content = button.nextElementSibling;

            while (content.className !== 'content') {

                if (content.className === 'button') {
                    return;
                }
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
}

var el = document.getElementById('root');

var count = 3,
    contents = Array.apply(null, {
        length: count
    })
    .map(function(_, index) {
        return 'Button #' + index;
    });


// fillElement(el, contents);

hideAndShowContent(el);

// var button = el.querySelectorAll('.button')[3];
// button.innerHTML = 'asdasd';
