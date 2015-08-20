var input1, input2, input3;

//1
function lastDigit() {
    result = document.getElementById('1result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('1input1').value.trim();
    input1 %= 10;
    result.innerHTML = digitAsAWord(input1);
}

function digitAsAWord(number) {
    switch (number) {
        case 0:
            return 'Zero';
        case 1:
            return 'One';
        case 2:
            return 'Two';
        case 3:
            return 'Three';
        case 4:
            return 'Four';
        case 5:
            return 'Five';
        case 6:
            return 'Six';
        case 7:
            return 'Seven';
        case 8:
            return 'Eight';
        case 9:
            return 'Nine';
        default:
            return 'Not a Digit';
    }
}

//2
function reverseNumber() {
    result = document.getElementById('2result');
    result.style.visibility = 'visible';
    result.innerHTML = document.getElementById('2input1').value.trim().split('').reverse().join('');
}

//3
function wordOccurCountInvoker() {
    result = document.getElementById('3result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('3input1').innerHTML.trim();
    input2 = document.getElementById('3input2').value.trim();
    input3 = document.getElementById('3input3').checked;

    result.innerHTML = wordOccurCount(input1, input2, input3); //third argument is optional : value of 1 or true means case sensitive
}

function wordOccurCount(text, search, caseSens) {
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

//4
function FindAllDivsInvoker() {
    result = document.getElementById('4result');
    result.style.visibility = 'visible';
    result.innerHTML = FindAllElements('div');
}

function FindAllElements(tagname) {
    var divs = document.getElementsByTagName(tagname);
    return divs.length;
}

//5
function AppearanceCountInvoker() {
    result = document.getElementById('5result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('5input1').value.trim().split(' ');
    input2 = document.getElementById('5input2').value.trim();
    result.innerHTML = AppearanceCount(input1, input2);
}

function AppearanceCount(array, number) {
    debugger;
    var i, count = 0;
    len = array.length;
    number = number | 0;
    for (i = 0; i < len; i += 1) {
        if ((array[i] | 0) === number) {
            count += 1;
        }
    }
    return count;
}

//6
function largerThanNeighboursInvoker() {
    result = document.getElementById('6result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('6input1').value.trim().split(' ');
    input2 = document.getElementById('6input2').value.trim();
    result.innerHTML = largerThanNeighbours(input1, input2);
}

//
function largerThanNeighbours(array, position) {
    position |= 0;
    if ((array[position] | 0) > (array[position - 1] | 0) && (array[position] | 0) > (array[position + 1] | 0)) {
        return true;
    }
    return false;
}

//7
function FirstlargerThanNeighboursInvoker() {
    result = document.getElementById('7result');
    result.style.visibility = 'visible';
    input1 = document.getElementById('7input1').value.trim().split(' ');
    result.innerHTML = FirstlargerThanNeighbours(input1, input2);
}

function FirstlargerThanNeighbours(array, position) {
    var i,
        len = array.length;
    for (i = 1; i < len - 1; i += 1) {
        //used from previous exercise
        if (largerThanNeighbours(array, i)) {
            return i;
        }
    }
    return i = -1;
}
