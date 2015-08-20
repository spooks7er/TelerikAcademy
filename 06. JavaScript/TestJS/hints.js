var array = [1, 2, 3, 4, 5, 6, 7, 8, 9];

// removes and returns the last n elements from array
console.log(array.splice(-2));

console.log(array.slice((array.length-2))); // get last n element
console.log(array);
console.log(array.splice(3, 2)); // removes n elemets from index 3

console.log(array);
// removes 0 el from index 3 and adds 4, 5
console.log(array.splice(3, 0, 4, 5)); 

console.log(array);

var arrayCopy = array.slice(); //copy an array
array[1] = 100;
console.log(array);
console.log(arrayCopy);

var newarr = array.map(function(item) {
    return item % 2 === 0;
});

console.log(newarr);

var whitespaces = /\x20\\t\\r\\n\\f/g; // \s combines all
// removes empty entries from string array
var str = 'djdjd \r     jskdkfk  \n   dfdsalkjd  sdlfnsd kksldkf ';
var strArr = str.trim().split(/\s+/g); //str.trim().split(/ +/g);
console.log(strArr);
// filter needed to remove any rogue whitespaces if there is no trim
strArr = strArr.filter(function(item) {
    return item;
});

console.log(strArr);

console.log(5 < -Infinity);

// to power extension function
Number.prototype.toPow = function toPow(pow) {
    var i, result = 1;
    for (i = 0; i < pow; i += 1) {
        result *= this;
    }
    return result;
};

function Pow(num, pow) {
    var i, result = 1;
    for (i = 0; i < pow; i += 1) {
        result *= num;
    }
    return result;
}

var num = 4;
console.log(num.toPow(3));

var unsortedArr = [5, 2, 6, 7, 1, 3, 4, 8, 9, 10];
console.log(unsortedArr.sort(function(a, b) {
    return a - b;
}));

console.log(unsortedArr.reverse());
