/* globals $ */

function solve() {
  
  return function (selector) {
    var template = '<div class="container">'+
    '<h1>Animals</h1>'+
    '<ul class="animals-list">'+
        '{{#animals}}'+
        '<li>'+
            '{{#if url}}'+
            '<a href={{url}}>See a {{name}}</a>'+
            '{{else }}'+
            '<a href="http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg">No link for {{name}} , here is Batman!</a>'+
            '{{/if}}'+
        '</li>'+
        '{{/animals}}'+
    '</ul>'+
'</div>';
    $(selector).html(template);   
  };
};

module.exports = solve;

//result = solve();

// result('#table-template');

// var data = {
//   animals: [{
//    name: 'Lion',
//    url: 'https://susanmcmovies.files.wordpress.com/2014/12/the-lion-king-wallpaper-the-lion-king-2-simbas-pride-4685023-1024-768.jpg'
//   }, {
//    name: 'Turtle',
//     url: 'http://www.enkivillage.com/s/upload/images/a231e4349b9e3f28c740d802d4565eaf.jpg'
//   }, {
//     name: 'Dog'              
//   }, {
//     name: 'Cat',
//     url: 'http://i.imgur.com/Ruuef.jpg'
//   }, {
//     name: 'Dog Again'              
//   }] 
// }
// var template = Handlebars.compile($('#table-template').html());
// var compiledHTML = template(data);
// document.body.innerHTML = compiledHTML;


// const BATMAN_LINK = 'http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg';
// document.body.innerHTML = '<script id="template"></script>';
// result('#template');

// var animals = [],
//     count = 15,
//     animal,
//     i;
// for (i = 0; i < count; i += 1) {
//     animal = {
//         name: 'Animal #' + i,
//     };
//     if (i % 3 !== 0) {
//         animal.url = 'http://animal-' + i + '.com';
//     }
//     animals.push(animal);
// }

// var data = {
//     animals
// };

// var templateFunc = Handlebars.compile($('#template').html());

// var output = templateFunc(data);

// $(document.body).html(output);

// var $container = $('div.container');
// var $list = $container.find('ul.animals-list');

// var $items = $list.find('li');

// $items.each(function(index, item) {
//     var $item = $(item);
//     var $link = $item.find('a');
//     console.log('expect($link).to.have.length(1)');
//     $link.length === 1;
//     if (animals[index].url) {
//         console.log('expect($link.attr("href")).to.equal(animals[index].url)');
//         console.log($link.attr('href') === animals[index].url);
//         console.log('expect($link.html()).to.equal(`See a ${animals[index].name}`)');
//         console.log($link.html() === 'See a ' + animals[index].name);
//     } else {
//         console.log('expect($link.attr("href")).to.equal(BATMAN_LINK)');
//         console.log($link.attr('href') === BATMAN_LINK);
//         console.log('expect($link.html()).to.equal(`No link for ${animals[index].name} , here is Batman!`)');
//         console.log($link.html() === 'No link for ' + animals[index].name +', here is Batman!');
//     }
// });
