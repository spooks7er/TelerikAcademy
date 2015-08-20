var input1, input2, input3,
    temp, result;

//1
String.prototype.reverse = function() {
    for (var i = this.length - 1, o = ''; i >= 0; i -= 1) {
        o += this[i]
    }
    return o;
}

function revStrInvoke() {
    result = document.getElementById('1result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('1input1').value.trim();
    result.innerHTML = input1.reverse();
}

//2
function bracketChecker(input) {
    var i, len = input.length,
        bracketCounter = 0;

    for (i = 0; i < len; i += 1) {
        if (input[i] === '(') {
            bracketCounter += 1;
        } else if (input[i] === ')') {
            bracketCounter -= 1;
        }
        if (bracketCounter < 0) {
            return false;
        }
    }
    return bracketCounter === 0;
}

function bracketCheckerStrInvoke() {
    result = document.getElementById('2result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('2input1').value.trim();
    result.innerHTML = bracketChecker(input1);
}

//3
function substringOccurCount(text, search, caseSens) {
    caseSens = caseSens || 0;
    if (!caseSens) {
        text = text.toLowerCase();
        search = search.toLowerCase();
    }
    var count = 0;
    var pos = text.indexOf(search);
    while (pos !== -1) {
        count += 1;
        pos = text.indexOf(search, pos + 1);
    }
    return count;
}

function substringOccurCountInvoker() {
    result = document.getElementById('3result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('3input1').innerHTML.trim();
    input2 = document.getElementById('3input2').value.trim();
    input3 = document.getElementById('3input3').checked;

    result.innerHTML = substringOccurCount(input1, input2, input3); //third argument is optional : value of 1 or true means case sensitive
}


//4
function findTagsInvoker() {
    result = document.getElementById('4result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('4input1').innerHTML.trim();
    result.innerHTML = findTags(replaceBrackets(input1));
}

function replaceBrackets(string) { //reverse escaping becasue the browser escapes all brackets that we need for the function to work
    string = string.replace(/&lt;/g, '<');
    string = string.replace(/&gt;/g, '>');
    string = string.replace(/\\'/g, '\'');
    return string;
}

function findTags(string) {
    var i,
        currentTag,
        processedString = '',
        tagStack = [], //<-- this holds the tags in order of nesting, say we have <tag1> text <tag2>text2</tag2> </tag1>, it will hold 2 items [tag1, tag2], items with bigger index are deeper in the nesting tree
        len = string.length,
        tags = {
            u: '<upcase>',
            l: '<lowcase>',
            m: '<mixcase>'
        };

    for (i = 0; i < len; i += 1) {
        if (string[i] === '<') {
            if (string[i + 1] === '/') { // closing tags
                i += tagStack.slice(-1)[0].length; //the indexer is again increased with the tag name lenght, in is case the closing tag
                tagStack.pop(); //the current tag is removed from the tail stack
                currentTag = tagStack.slice(-1)[0]; // current tag becomes the next element in the tag stack, .slice(-1)[0] gets the last element of the array
            } else { //open tags
                currentTag = tags[string[i + 1]]; //current tag is saved using the tags object
                tagStack.push(currentTag) //the current tag is added to the tail of the tag stack
                i += tagStack.slice(-1)[0].length - 1; //the indexer is increased with the lenght of the tag name so we dont proccess the tag name text
            }
        } else { //process tags
            if (!currentTag) { //if there is no current tag we skip any processing
                processedString += string[i];
                continue;
            }
            processedString += processTags(currentTag, string[i])
        }
    }
    return processedString;
}

function processTags(currTag, currChar) {
    switch (currTag) {
        case '<upcase>':
            return currChar.toUpperCase();
        case '<lowcase>':
            return currChar.toLowerCase();
        case '<mixcase>':
            var rand = Math.random() * 2 | 0; // | 0 rounds to lower
            if (rand === 0)
                return currChar.toUpperCase();
            if (rand === 1)
                return currChar.toLowerCase();
    }
}

//5
function replaceNbpsInvoker() {
    result = document.getElementById('5result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('5input1').innerHTML.trim();
    result.innerHTML = replaceNbps(input1) + ' <=== this is the result label element';
}

function replaceNbps(string) {
    return string.replace(/\s/g, '&nbsp;')
}

//6
function extractHTMLInvoker() {
    result = document.getElementById('6result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('6input1').value.trim();
    result.innerHTML = extractHTML(input1);
}

function extractHTML(text) {
    var len = text.length,
        inTag = false,
        newText = '';

    for (i = 0; i < len; i += 1) {
        if (text[i] === '<') {
            inTag = true;
        } else if (text[i] === '>') {
            inTag = false;
        } else {
            if (!inTag) {
                newText += text[i];
            }
        }
    }
    return newText;
}

//7
function ParseURLInvoker() {
    result = document.getElementById('7result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('7input1').value.trim();
    result.innerHTML = ParseURL(input1);
}

function ParseURL(url) {
    var protocol = url.substr(0, url.indexOf(':')),

        server = url.substr(protocol.length + 3, url.indexOf('/', (protocol.length + 3)) - (protocol.length + 3)),

        resource = url.substr(server.length + protocol.length + 3, url.length - (server.length + protocol.length + 3));

    return '[protocol] = ' + protocol + '<br>[server] = ' + server + '<br>[resource] = ' + resource;
}

//8
function replaceTagsInvoker() {
    result = document.getElementById('8result');
    input1 = document.getElementById('8input1').value.trim();
    result.value = replaceTags(input1);
}

function replaceTags(text) {
    var openTag2 = "[URL=",
        openTagEnd2 = "]",
        closeTag2 = "[/URL]";

    text = text.replace(/<a href=\"/g, openTag2).
    replace(/\">/g, openTagEnd2).
    replace(/<\/a>/g, closeTag2);
    return text;
}

//99
function extractEmailsInvoker() {
    result = document.getElementById('9result');
    input1 = document.getElementById('9input1').value.trim();
    var emailsArray = extractEmails(input1);
    result.value = emailsArray.join('\n');
}

function extractEmails(text) {
    var i,
        emailRegex = /(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})/,
        emails = [],
        textarr = text.split(' '),
        len = textarr.length;

    for (i = 0; i < len; i += 1) {
        if (emailRegex.test(textarr[i])) {
            emails.push(textarr[i])
        }
    }
    return emails;
}

//10
function findPalindromesInvoker(argument) {
    result = document.getElementById('10result');
    input1 = document.getElementById('10input1').value.trim();
    result.value = findPalindromes(input1).join('\n');
}

function findPalindromes(text) {
    var i,
        separatos = /[\,\.]/g,
        //text = 'ABBA  , hasdas ,lamal  ,a231dwsw , jojoj  , exe asdasdasd, bob,a sd. asd ,  shish, alkukla',
        arr = text.replace(/\s/g, '').split(separatos)
    len = arr.length;
    for (i = 0; i < len; i += 1) {
        if (!(arr[i] === arr[i].split('').reverse().join(''))) {
            arr.splice(i, 1)
            i -= 1;
            len -= 1;
        }
    }
    return arr;
}

//11
function stringFormatInvoker(argument) {
    result = document.getElementById('11result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('11input1').value.trim();
    result.innerHTML = 'TEST THIS IN THE CONSOLE : stringFormat(\'asd {0}, {1}, {2}\', \'pesho\', \'stamat\', \'OK\')';
    console.log(stringFormat('asd {0}, {1}, {2}', 'pesho', 'stamat', 'OK'))
}

function stringFormat(format) {
    var i, plhRegx
    len = arguments.length,
        formatLen = format.length;
    for (i = 1; i < len; i += 1) {
        plhRegx = new RegExp('\\{' + (i - 1) + '\\}', 'g')
        format = format.replace(plhRegx, arguments[i])
    }
    return format;
}

//12

var arrPpl = [{
        name: 'Peter',
        age: 14
    }, {
        name: 'Ivan',
        age: 15
    }, {
        name: 'Stamat',
        age: 17
    }, {
        name: 'Vasilka',
        age: 12
    }, {
        name: 'Hlapoch',
        age: 11
    }, {
        name: 'Gosho',
        age: 16
    }, {
        name: 'Ginka',
        age: 14
    }],
    stringUl = '<ul>';

function generateListInvoker(argument) {
    result = document.getElementById('12result');
    result.innerHTML = generateList(arrPpl);
}

function generateList(arrObj) {
    var i,
        len = arrObj.length,
        stringUl = '<ul>';
    for (i = 0; i < len; i += 1) {
        stringUl += stringFormat('<li><strong>{0}</strong> <span>{1}</span></li>', arrObj[i].name, arrObj[i].age);
    }
    return stringUl += '</ul>';
}
