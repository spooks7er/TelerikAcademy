var ul = $('#menu');

//sample menu mouse events template
ul.on({
    mousedown: function() {
        $(this).css('color', 'pink');
    },
    mouseup: function() {
        $(this).css('color', 'black');
    },
    mouseover: function() {
        $(this).css('color', 'red');
    },
    mouseleave: function() {
        $(this).css('color', 'black');
    },
}, 'li');

var div = $('<div>')
    .addClass()
    .attr('id', 'my-menu');
$('body').append(div);

// function listAppender(selector, count) {

//     var element = $(selector)

//     if (!element || element.length === 0) {
//         return;
//     }

//     if (!(count | 0) || count < 1) {
//         return;
//     }

//     var ul = $('<ul>').appendTo(element).attr('id', 'my-ul'),
//         listring = '';


//     for (var i = 0; i < count; i += 1) {
//         var li = $('<li>')
//             .addClass("list-item")
//             .append('List item ' + i)
//             .appendTo(ul);
//     }
// }

// function listAppender(element, count) {
//     if (!element || element.length === 0) {
//         throw new Error('selector is null or invalid');
//     }

//     element = $(element);

//     if (count < 1) {
//         return;
//     }

//     var ul = $('<ul>')
//         .appendTo(element)
//         .addClass('items-list'),
//         listring = '';

//     for (var i = 0; i < count; i += 1) {
//         listring += '<li class="list-item">List item #' + i + '</li>';
//     }
//     ul.append(listring);
// }

// var elem = $('#my-menu');
// listAppender(elem, 5);

// for (var i = 0; i < 5; i++) {
//     div.append('<button class="button">');
//     div.append('<span class="asd">NOT CONTENT');
//     div.append('<p class="content">CONTENT');
// }

// function showHide(element) {
//     element = $(element);
//     element.children('.button').text('hide');

//     element.on('click', '.button', function() {
//         var $this = $(this),
//             toBeHidden = $this.next();
//         while (!toBeHidden.hasClass('content')) { // class name without a dot
//             toBeHidden = toBeHidden.next();
//         }
//         if (toBeHidden.is(':visible')) {
//             toBeHidden.hide();
//             $this.text('show');
//         } else {
//             toBeHidden.css('display', '');
//             $this.text('hide');
//         }
//     });
// }

// function showHide(element) {
//     element = $(element);
//     element.children('.button').text('hide');

//     element.on('click', '.button', function(ev) {
//         var $this = $(this),
//             toBeHidden = $this.next();
//         while (!toBeHidden.hasClass('content')) { // class name without a dot
//             toBeHidden = toBeHidden.next();
//         }
//         if (toBeHidden.is(':visible')) { // this shit doesnt work with mocha tests but it work otherwise
//             toBeHidden.hide();
//             $this.text('show');
//         } else {
//             toBeHidden.css('display', '');
//             $this.text('hide');
//         }
//     });
// }

function showHide(element) {
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
}



function createDummyNode() {
    var tags = ['a', 'button', 'p', 'div', 'ul', 'li', 'ol', 'input', 'table', 'tr', 'br', 'hr', 'span'];
    var node = document.createElement(tags[(Math.random * tags.length) | 0]);
    node.innerHTML = 'Dummy Element: ' + Math.random();
    return node;
}
var container = document.createElement('div'),
    count = 150,
    possibleTags = ['a', 'button', 'p', 'div'],
    i,
    buttonNode,
    contentNode,
    tag;

container.id = 'root';
var dymmyObjectChance = 70;
for (i = 0; i < count; i += 1) {
    if (Math.random() * 100 < dymmyObjectChance) {
        container.appendChild(createDummyNode());
    }
    tag = possibleTags[(Math.random() * possibleTags.length) | 0];
    buttonNode = document.createElement(tag);
    buttonNode.className = 'button';
    if (i === ((count / 2) | 0)) {
        buttonNode.id = 'the-button';
    }
    container.appendChild(buttonNode);

    contentNode = document.createElement(tag);
    contentNode.className = 'content';

    if (Math.random() * 100 < dymmyObjectChance) {
        container.appendChild(createDummyNode());
    }
    container.appendChild(contentNode);

    if (Math.random() * 100 < dymmyObjectChance) {
        container.appendChild(createDummyNode());
    }
}
document.body.innerHTML = container.outerHTML;

showHide('#root');

var theButton = document.getElementById('the-button');

var theContent = theButton.nextElementSibling;
while (theContent && theContent.className.indexOf('content') < 0) {
    theContent = theContent.nextElementSibling;
}

var event = document.createEvent('MouseEvents');
event.initMouseEvent('click', true, true);
theButton.dispatchEvent(event);


console.log('expect(theButton).to.exist');
console.log(theButton);
console.log('expect(theContent).to.exist');
console.log(theContent);
console.log('expect(theButton.innerHTML).to.equal("show")');
console.log(theButton.innerHTML === 'show');
console.log(theButton.innerHTML);
console.log('expect(theContent.style.display).to.equal("none")');
console.log(theContent.style.display === 'none');
console.log(theContent.style.display);

theButton.dispatchEvent(event);
console.log('expect(theButton.innerHTML).to.equal("hide")');
console.log(theButton.innerHTML === 'hide');
console.log(theButton);
console.log(theButton);
console.log(theButton);
console.log(theButton);
console.log(theButton);
console.log(theButton);
console.log(theButton);

console.log('expect(theContent.style.display).to.equal("")');
console.log(theContent.style.display === '');
console.log(theContent.style.display);
