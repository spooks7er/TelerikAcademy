//1
var intNum = 17;
var floatNum = 1.618;
var bool = true;
var string = 'String literal';
var object = {};
var array = ['array'];
var nAn = NaN;
var nullLit = null;
var undefinedLit;
var result = intNum + ', '  + floatNum + ', ' + bool + ', ' + string + ', ' + object + ', ' + array + ', ' + nAn + ', ' + nullLit + ', ' + undefinedLit;
console.log(result);
document.body.innerHTML += '<p>01. '+result+'</p>';
//
//2
var myQuotedString = '"Hasta la vista, baby", said the Terminator.';
console.log(myQuotedString)
document.body.innerHTML += '<p>02. '+myQuotedString+'</p>';
//
//3
var typeofAll = 
typeof(intNum)+', '+
typeof(floatNum)+', '+
typeof(bool)+', '+
typeof(string)+', '+
typeof(object)+', '+
typeof(array)+', '+
typeof(nAn)+', '+
typeof(nullLit)+', '+
typeof(undefinedLit);
document.body.innerHTML += '<p>03. '+typeofAll+'</p>';
console.log(typeofAll);
//
//4
document.body.innerHTML += '<p>04. see above^</p>';
console.log('see above^');
//