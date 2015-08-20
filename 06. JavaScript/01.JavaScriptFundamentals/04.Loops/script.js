var result, numeber1;

//1
function numbersFrom1toN() {
    number1 = document.getElementById('1number1').value * 1;
    result = document.getElementById('numbersFrom1toNRes');
    result.style.visibility = 'visible';

    var numbers = 1;

    for (var i = 2; i <= number1; i += 1) {
        numbers += ', ' + i;
    }

    result.innerHTML = numbers;
}

//2
function numbersFrom1toNnotd57() {
    number1 = document.getElementById('2number1').value * 1;
    result = document.getElementById('numbersFrom1toNnotd57Res');
    result.style.visibility = 'visible';

    var numbers = 1;

    for (var i = 2; i <= number1; i += 1) {
        if (!fiveSeven(i)) {
            numbers += ', ' + i;
        }
    }

    result.innerHTML = numbers;
}

function fiveSeven(num) {
    return num % 5 === 0 && num % 7 === 0;
}

//3
function minMaxOfSeq() {
    number1 = document.getElementById('3number1').value;
    result = document.getElementById('minMaxOfSeqRes');
    result.style.visibility = 'visible';

    number1 = (number1.trim()).split(' ').sort(function(a, b) {
        return a - b
    });
    var len = number1.length;
    result.innerHTML = 'min: ' + number1[0] + ' ; max: ' + number1[len - 1];
}

//4
function lexSmallest() {
    var arr1 = [window, navigator, document],
    outTxt, arr, i, property, id, result;

    for (i = 0; i < 3; i+=1) {

        outTxt = "";

        for (property in arr1[i]) {
            outTxt += property + " ";
        }

        arr = outTxt.split(" ");

        arr.sort();
        outTxt = "Min: " + arr[1] + ";\nMax: " + arr[arr.length - 1] + ";";
        id = "lexSmallestRes" + (i + 1);
        result = document.getElementById(id);
        result.innerHTML = outTxt;
        result.style.visibility = 'visible';
    }
}
