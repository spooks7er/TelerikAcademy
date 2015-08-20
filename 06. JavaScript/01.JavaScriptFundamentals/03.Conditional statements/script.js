var number1, number2, number3, number4, number5,
    temp, result;

//1
function exchange() {
    number1 = document.getElementById('1number1').value * 1;
    number2 = document.getElementById('1number2').value * 1;
    result = document.getElementById('exchangeRes');

    if (number1 > number2) {
        temp = number1;
        number1 = number2;
        number2 = temp;
    }

    result.style.visibility = 'visible';
    result.innerHTML = number1 + ' ' + number2;
}

//2
function multSign() {
    number1 = document.getElementById('2number1').value * 1;
    number2 = document.getElementById('2number2').value * 1;
    number3 = document.getElementById('2number3').value * 1;
    result = document.getElementById('multSignRes');

    temp = number1 * number2 * number3;

    var sign;

    if (temp > 0) {
        sign = '+';
    } else if (temp === 0) {
        sign = '0';
    } else if (temp < 0) {
        sign = '-';
    }

    result.style.visibility = 'visible';
    result.innerHTML = sign;
}

//3
function biggestNumber() {
    number1 = document.getElementById('3number1').value * 1;
    number2 = document.getElementById('3number2').value * 1;
    number3 = document.getElementById('3number3').value * 1;
    result = document.getElementById('biggestRes');

    var biggest;

    if (number1 > number2) {
        if (number1 > number3) {
            biggest = number1;
        } else {
            biggest = number3;
        }
    } else {
        if (number2 > number3) {
            biggest = number2;
        } else {
            biggest = number3;
        }
    }

    result.style.visibility = 'visible';
    result.innerHTML = biggest;
}

//4
function sortNumbers() {
    number1 = document.getElementById('4number1').value * 1;
    number2 = document.getElementById('4number2').value * 1;
    number3 = document.getElementById('4number3').value * 1;
    result = document.getElementById('sortRes');

    var biggest;
    var middle;
    var smallest;

    if (number1 > number2) {
        if (number1 > number3) {
            biggest = number1;
            if (number2 > number3) {
                middle = number2;
                smallest = number3;
            } else {
                middle = number3;
                smallest = number2;
            }
        } else {
            biggest = number3;
            if (number2 > number1) {
                middle = number2;
                smallest = number1;
            } else {
                middle = number1;
                smallest = number2;
            }
        }
    } else {
        if (number2 > number3) {
            biggest = number2;
            if (number1 > number3) {
                middle = number1;
                smallest = number3;
            } else {
                middle = number3;
                smallest = number1;
            }
        } else {
            biggest = number3;
            if (number2 > number1) {
                middle = number2;
                smallest = number1;
            } else {
                middle = number1;
                smallest = number2;
            }
        }
    }
    result.style.visibility = 'visible';
    result.innerHTML = biggest + ' ' + middle + ' ' + smallest;
}

//5
function digitAsAWord() {
    number1 = document.getElementById('5number1').value;
    result = document.getElementById('digitAsAWordRes');

    var word;

    switch (number1) {
        case '0':
            word = 'Zero';
            break;
        case '1':
            word = 'One';
            break;
        case '2':
            word = 'Two';
            break;
        case '3':
            word = 'Three';
            break;
        case '4':
            word = 'Four';
            break;
        case '5':
            word = 'Five';
            break;
        case '6':
            word = 'Six';
            break;
        case '7':
            word = 'Seven';
            break;
        case '8':
            word = 'Eight';
            break;
        case '9':
            word = 'Nine';
            break;
        default:
            word = 'Not a Digit';
    }

    result.style.visibility = 'visible';
    result.innerHTML = word;
}

//6
function quadratic() {

    number1 = document.getElementById('6number1').value * 1;
    number2 = document.getElementById('6number2').value * 1;
    number3 = document.getElementById('6number3').value * 1;
    result = document.getElementById('quadraticRes');
    result.style.visibility = 'visible';
    var x1, x2, D;

    if (number1 === 0) {
        result.innerHTML = '"a" must not be equal to 0';
        return;
    }

    D = Math.pow(number2, 2) - 4 * number1 * number3;

    if (D < 0) {
        result.innerHTML = 'The equation has no real roots.';
        return;
    } else if (D === 0) {
        result.innerHTML = 'x= ' + (-number2 / 2 * number1);
        return;
    }

    x1 = (-number2 + Math.sqrt(D)) / 2 * number1;

    x2 = (-number2 - Math.sqrt(D)) / 2 * number1;

    result.innerHTML = 'x1= ' + x1 + ' ' + 'x2= ' + x2;
}

//7
function biggestNumberOf5() {
    number1 = document.getElementById('7number1').value * 1;
    number2 = document.getElementById('7number2').value * 1;
    number3 = document.getElementById('7number3').value * 1;
    number4 = document.getElementById('7number4').value * 1;
    number5 = document.getElementById('7number5').value * 1;

    result = document.getElementById('biggestOf5Res');

    var biggest;

    if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5) {
        biggest = number1;
    }
    if (number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5) {
        biggest = number2;
    }
    if (number3 > number2 && number3 > number1 && number3 > number4 && number3 > number5) {
        biggest = number3;
    }
    if (number4 > number2 && number4 > number3 && number4 > number1 && number4 > number5) {
        biggest = number4;
    }
    if (number5 > number2 && number5 > number3 && number5 > number4 && number5 > number1) {
        biggest = number5;
    }

    result.style.visibility = 'visible';
    result.innerHTML = biggest;
}

//8
var ones = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
var tens = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
var teens = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];

function numberAsAWord() {
    number1 = document.getElementById('8number1').value * 1;
    result = document.getElementById('nigitAsAWordRes');

    var word = convert(number1);

    result.style.visibility = 'visible';
    result.innerHTML = word;
}

function convert_millions(num) {
    if (num >= 1000000) {
        return convert_millions(Math.floor(num / 1000000)) + " million " + convert_thousands(num % 1000000);
    } else {
        return convert_thousands(num);
    }
}

function convert_thousands(num) {
    if (num >= 1000) {
        return convert_hundreds(Math.floor(num / 1000)) + " thousand " + convert_hundreds(num % 1000);
    } else {
        return convert_hundreds(num);
    }
}

function convert_hundreds(num) {
    if (num > 99) {
        return ones[Math.floor(num / 100)] + " hundred " + convert_tens(num % 100);
    } else {
        return convert_tens(num);
    }
}

function convert_tens(num) {
    if (num < 10) return ones[num];
    else if (num >= 10 && num < 20) return teens[num - 10];
    else {
        return tens[Math.floor(num / 10)] + " " + ones[num % 10];
    }
}

function convert(num) {
    if (num === 0) return "zero";
    else return convert_millions(num);
}