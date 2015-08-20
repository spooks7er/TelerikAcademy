function solve(selector) {
    selector = $(selector);
    var select = $('select'),
        dropDownDiv = $('<div>').addClass('dropdown-list'),
        current = $('<div>').addClass('current'),
        optionContainer = $('<div>').addClass('option-container'),
        options = selector.find('option');

    current.text($(options[0]).text());

    if (!selector.is('select')) {
        throw new Error(e);
    }
    selectChildren = select.children();

    // selectChildren.each(function(index, el) { // fixes broken test
    //     el.value = 'value-' + (index + 1);
    // });

    dropDownDiv
        .insertAfter(select)
        .append(select);

    select
        .hide();

    current.insertAfter(select);

    optionContainer
        .insertAfter(current)
        .hide();

    options.each(function(index, el) {
        var dropDownItem = $('<div>').addClass('dropdown-item');
        dropDownItem.attr({
            'data-value': (index + 1),
            'data-index': index,
        }).append($(el).text()).appendTo(optionContainer);
    });

    current.on('click', function() {
        var $this = $(this);
        $this.text('Select Value').attr('data-value', '');
        optionContainer.show();
    });
    optionContainer.on('click', '.dropdown-item', function() {
        var $this = $(this);
        select.val($this.attr('data-value').slice(-1));
        current.text($this.text()).attr('data-value', $this.attr('data-value'));
        optionContainer.hide();
    });
}


//solve('select');


var id = 'the-select',
    select = document.createElement('select'),
    count = 5;
select.id = id;

for (var i = 0; i < count; i += 1) {
    var option = document.createElement('option');
    option.innerHTML = 'Option #' + (i + 1);
    option.value = (i + 1) + '';
    select.appendChild(option);
}

document.body.innerHTML = select.outerHTML;

solve('#' + id);

var clickEvent = document.createEvent('MouseEvents');
clickEvent.initMouseEvent('click', true, true);

var $dropdown = $('.dropdown-list');

var $current = $dropdown.find('.current');
$current.get(0).dispatchEvent(clickEvent);

var clickedOption = $dropdown.find('.dropdown-item').get(Math.floor(count / 2));
clickedOption.dispatchEvent(clickEvent);



// expect($('#' + id).val()).to.equal(clickedOption.getAttribute('data-value'));
console.log($('#' + id));
console.log($('#' + id).val());

console.log(clickedOption);
console.log(clickedOption.getAttribute('data-value'));
// var $options = $dropdown.find('.dropdown-item');

// $options.each(function(index, option) {
//     var $option = $(option);
//     var $node = $option;
//     while (!($node.hasClass('dropdown-list')) && $node.css('display') !== 'none') {
//         $node = $node.parent();
//     }

//     expect($node.hasClass('dropdown-list')).not.to.be.true;
// });
