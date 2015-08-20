// $.fn.listview = function(data) {
//     var $this = this,
//         template = $('#' + $this.attr('data-template')),
//         addCollection = '{{#this}}' + template.html() + '{{/this}}';
//     template.remove();
//     var templateFunc = Handlebars.compile(addCollection),
//         output = templateFunc(data);
//     $this.html(output);
// };

function solve() {
    return function() {
        $.fn.listview = function(data) {
            var $this = this,
                template = $('#' + $this.attr('data-template')),
                addCollection = '{{#this}}' + template.html() + '{{/this}}';
            template.remove();
            var templateFunc = handlebars.compile(addCollection),
                output = templateFunc(data);
            $this.html(output);
            return $this;
        };
    };
}


module.exports = solve;


// var data = [],
//     count = 5,
//     id = 'students-table';

// document.body.innerHTML = '<table><thead><tr><th>#</th><th>Name</th><th>Mark</th></tr></thead>' +
//     '<tbody id="' + id + '" data-template="students-row-template"></tbody></table>' +
//     '<script id="students-row-template" type="text/handlebars-template"><tr class="student-row"><td>{{number}}</td><td>{{name}}</td><td>{{mark}}</td></tr></script>';

// for (var i = 0; i < count; i += 1) {
//     var number = i + 1;
//     var name = `Student ${i + 1}`;
//     var mark = i % 5 + 2;
//     data.push({
//         number, name, mark
//     });
// }

// $('#' + id).listview(data);
// var $listview = $('#' + id);
// var $rows = $listview.find('tr');
// console.log('expect($rows).to.have.length(count)');
// console.log($rows.length === count)


// $rows.each(function(index, row) {
//     var $row = $(row);
//     var $cells = $row.find('td');
//     console.log('expect($cells).to.have.length(Object.keys(data[index]).length)')
//     console.log($cells.length === Object.keys(data[index]).length)

//     $cells.each(function(i, cell) {
//         var isFound = Object.keys(data[index])
//             .some(function(key) {
//                 return data[index][key].toString() === cell.innerHTML
//             });

//         console.log(isFound)
//     });
// });



// var data = [],
//     count = 5,
//     id = 'list-view';

// document.body.innerHTML = '<ul id="' + id + '" data-template="item-template"></ul>' +
//     '<script id="item-template" type="text/handlebars-template"><li>{{this}}</li></script>';

//         var count = 5,
//       data = Array.apply(null, { length: count })
//         .map(Number.call, Number)


//     $('#' + id).listview(data);

// var data = [],
//     count = 5,
//     id = 'list-view';

// document.body.innerHTML = '<div id="' + id + '" data-template="item-template"></div>' +
//     '<script id="item-template" type="text/handlebars-template"><div class="outer"><h1>{{title}}</h1>{{#each numbers}}<div class="number-item">{{this}}</div>{{/each}}</div></script>';

// var i;

// for (i = 0; i < count; i += 1) {
//     data.push({
//         title: 'Title #' + (i + 1),
//         numbers: Array.apply(null, {
//                 length: (i + 5) % 6
//             })
//             .map(Number.call, Number)
//     });
// }

// $('#' + id).listview(data);

// var $listview = $('#' + id);
