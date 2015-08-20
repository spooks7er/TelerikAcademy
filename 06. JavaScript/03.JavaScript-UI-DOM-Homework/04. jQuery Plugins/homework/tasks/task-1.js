function solve() {
    return function(selector) {
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
                'data-value': selectChildren[index].value,
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
    };
}

module.exports = solve;
