/* globals $ */

function solve() {

    return function(selector) {
        var template = '\
        <table class="items-table" cellpadding="5" border="1" style="border-collapse:collapse">\
            <thead>\
                <tr>\
                    <th>#</th>\
                    {{#headers}}\
                    <th>{{this}}</th>\
                    {{/headers}}\
                </tr>\
            </thead>\
            <tbody>\
                {{#items}}\
                <tr>\
                    <td>{{@index}}</td>\
                    <td>{{col1}}</td>\
                    <td>{{col2}}</td>\
                    <td>{{col3}}</td>\
                </tr>\
                {{/items}}\
            </tbody>\
        </table>';
        $(selector).html(template);
    };
};

module.exports = solve;

// result = solve();

// result('#table-template')

// var headers = ['Title', 'Date #1', 'Duration'];
// var items = [],
//     count = 10;

// for (var i = 0; i < count; i += 1) {
//     items.push({
//         col1: 'Title #' + i,
//         col2: new Date() + '',
//         col3: i
//     });
// }

// var data = {
//     headers, items
// };
// var template = Handlebars.compile($('#table-template').html());
// var compiledHTML = template(data);
// document.body.innerHTML = compiledHTML;



// debugger;
// var html = $('#table-template').html();
// var tableTemplate = Handlebars.compile(html);

// var data = {
//     headers: ['Vendor', 'Model', 'OS'],
//     items: [{
//         col1: 'Nokia',
//         col2: 'Lumia 920',
//         col3: 'Windows Phone'
//     }, {
//         col1: 'LG',
//         col2: 'Nexus 5',
//         col3: 'Android'
//     }, {
//         col1: 'Apple',
//         col2: 'iPhone 6',
//         col3: 'iOS'
//     }
// };

// var tableResult = tableTemplate(data);
// $('body').html(tableResult);