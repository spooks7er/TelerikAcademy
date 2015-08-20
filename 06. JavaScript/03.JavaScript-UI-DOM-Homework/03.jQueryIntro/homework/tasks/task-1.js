/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
    return function(element, count) {
        
        if (!element || element.length === 0) {
            throw new Error('selector is null or invalid');
        }

        element = $(element);

        if (!(count | 0) || count < 1) {
            throw new Error('count is zero or invalid');
        }

        var ul = $('<ul>')
            .appendTo(element)
            .addClass('items-list'),
            listring = '';

        for (var i = 0; i < count; i += 1) {
            listring += '<li class="list-item">List item #' + i + '</li>';
        }
        ul.append(listring);
    };
}

module.exports = solve;
