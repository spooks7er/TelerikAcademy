var myArray1, myArray2, result, res, value,
    i, j, tmp, len, count,
    char1, char2, charsum,
    currNum, bestNum, bestCount;

//1
myArray1 = [];
len = myArray1.length = 20;

function generateArray() {
    result = document.getElementById('result1');
    result.style.visibility = 'visible';

    for (i = 0; i < len; i += 1) {
        myArray1[i] = i * 5;
    }
    res = myArray1.join(' ');
    result.innerHTML = res;
    console.dir(myArray1);
}

//2
function compareLexi() {
    result = document.getElementById('result2');
    result.style.visibility = 'visible';
    myArray1 = document.getElementById('2input1').value.trim().split(' ');
    myArray2 = document.getElementById('2input2').value.trim().split(' ');

    if (myArray1.length != myArray2.length) {
        len = myArray1.length;
        alert('Sequences must be equal in lenght.')
        return;
    } else {
        len = myArray1.length;
    }

    for (i = 0; i < len; i += 1) {

        char1 = myArray1[i].charCodeAt(0)
        char2 = myArray2[i].charCodeAt(0)
        charsum = char1 - char2;
        if (charsum > 0) {
            charsum = 1;
        } else if (charsum === 0) {
            charsum = 0;
        } else if (charsum < 0) {
            charsum = -1;
        }
        console.log(char1 + ' ' + char2 + ' ' + charsum);
    }
}

//3
function maxSeq() {
    result = document.getElementById('result3');
    result.style.visibility = 'visible';
    myArray1 = document.getElementById('3input1').value.trim().split(' ');
    len = myArray1.length;

    count = 0;
    max = 0;
    sequence = [];
    maxSequence = [];
    myArray1[0] = myArray1[0] * 1;
    for (i = 0; i < len; i += 1) {

        if (i !== len - 2) {
            myArray1[i + 1] = myArray1[i + 1] * 1;
        }

        if (i === 0 && myArray1[i] === myArray1[i + 1]) {
            count += 1;
            sequence.push(myArray1[i]);
            if (count > max) {
                max = count;
                maxSequence = sequence.slice();
            }
        } else if ((i > 0 && i < len - 1) && (myArray1[i] === myArray1[i - 1] || myArray1[i] === myArray1[i + 1])) {
            if (myArray1[i] !== myArray1[i - 1]) {
                count = 0;
                sequence = [];
            }
            count += 1;
            sequence.push(myArray1[i]);
            if (count > max) {
                max = count;
                maxSequence = sequence.slice();
            }
        } else if (i === len - 1 && myArray1[i] === myArray1[i - 1]) {
            count++;
            sequence.push(myArray1[i]);
            if (count > max) {
                max = count;
                maxSequence = sequence.slice();
            }
        } else {
            count = 0;
            sequence = [];
        }
    }

    res = 'length: ' + max + '</br>' + maxSequence.join(' ');
    result.innerHTML = res;

    console.log(max);
    console.dir(maxSequence);
}

//4
function maxIncSeq() {
    result = document.getElementById('result4');
    result.style.visibility = 'visible';
    myArray1 = document.getElementById('4input1').value.trim().split(' ');
    len = myArray1.length;

    count = 0;
    max = 0;
    sequence = [];
    maxSequence = [];
    myArray1[0] = myArray1[0] | 0;
    for (i = 0; i < len; i += 1) {

        if (i !== len - 2) {
            myArray1[i + 1] = myArray1[i + 1] | 0;
        }

        if (i === 0 && myArray1[i] === myArray1[i + 1] - 1) {
            count += 1;
            sequence.push(myArray1[i]);
            if (count > max) {
                max = count;
                maxSequence = sequence.slice();
            }
        } else if ((i > 0 && i < len - 1) && (myArray1[i] === myArray1[i - 1] + 1 || myArray1[i] === myArray1[i + 1] - 1)) {
            if (myArray1[i] !== myArray1[i - 1] + 1) {
                count = 0;
                sequence = [];
            }
            count += 1;
            sequence.push(myArray1[i]);
            if (count > max) {
                max = count;
                maxSequence = sequence.slice();
            }
        } else if (i === len - 1 && myArray1[i] === myArray1[i - 1] + 1) {
            count++;
            sequence.push(myArray1[i]);
            if (count > max) {
                max = count;
                maxSequence = sequence.slice();
            }
        } else {
            count = 0;
            sequence = [];
        }
    }

    res = 'length: ' + max + '</br>' + maxSequence.join(' ');
    result.innerHTML = res;

    console.log(max);
    console.dir(maxSequence);
}

//5
function selectionSortInvoker() {
    result = document.getElementById('result5');
    result.style.visibility = 'visible';
    myArray1 = document.getElementById('5input1').value.trim().split(' ');
    len = myArray1.length;

    myArray1 = selectionSort(myArray1, len);

    res = myArray1.join(' ');
    result.innerHTML = res;
    console.log(res);
    console.dir(myArray1);
}

function selectionSort(array, len) {
    for (i = 0; i < len - 1; i += 1) {
        for (j = i + 1; j < len; j += 1) {
            if ((array[i] | 0) > (array[j] | 0)) {
                tmp = array[i] | 0;
                array[i] = array[j] | 0;
                array[j] = tmp;
            }
        }
    }
    return array;
}

//5
function frequentNumber() {
    result = document.getElementById('result6');

    result.style.visibility = 'visible';
    myArray1 = document.getElementById('6input1').value.trim().split(' ');
    len = myArray1.length;
    myArray1.sort(function(a, b) {
        return a - b
    });
    myArray1[0] = myArray1[0] | 0;
    count = 1;
    currNum = myArray1[0];
    bestNum = 0;
    bestCount = 1;

    for (i = 1; i < len; i += 1) {

        myArray1[i] = myArray1[i] | 0;

        if (currNum === myArray1[i]) {
            count += 1;
            if (count > bestCount) {
                bestNum = currNum;
                bestCount = count;
            }
        } else {
            count = 1;
        }
        currNum = myArray1[i];
    }
    res = 'The number ' + bestNum + ' is the most frequent, it\'s repeated ' + bestCount + ' times.';
    result.innerHTML = res;
    console.log(res);
}

//7
function binarySearchInvoker() {
    result = document.getElementById('result7');
    result.style.visibility = 'visible';
    myArray1 = document.getElementById('7input1').value.trim().split(' ');
    value = document.getElementById('7input2').value.trim() * 1;
    len = myArray1.length;
    myArray1 = selectionSort(myArray1, len);
    res = binarySearch(myArray1, value, 0, len)
    res = 'The sorted array:</br>' + myArray1.join(' ') + '</br>' +
        'The value ' + value + ' is at position ' + res + '.';
    result.innerHTML = res;
    console.log(res);
}

function binarySearch(array, value, left, right) {
    var middle;
    while (left <= right) {
        middle = ((left + right) / 2) | 0;
        if (array[middle] === value) {
            return middle;
        } else if (array[middle] > value) {
            right = middle - 1;
        } else {
            left = middle + 1;
        }
    }
    return -1;
}
