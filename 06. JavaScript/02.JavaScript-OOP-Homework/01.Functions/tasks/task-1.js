/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

// function() {
//     return function(arr) {
//         if (arr.length === 0) {
//             return null;
//         }
//         return arr.reduce(function(s, n) {
//             n = +n;

//             // if (isNaN(n)) {
//             //     throw 'Error';
//             // }
//             return s + n;
//         }, 0)
//     }
// }


// function sum(arr) {
//     if (arr.length === 0) {
//         return null;
//     }
//     return arr.reduce(function(s, n) {
//         n = +n;

//         if (isNaN(n)) {
//             throw 'Error';
//         }
//         return s + n;
//     }, 0)
// }


function f(arr) {
	var i, len = arr.length, sum = 0;

    if (len === 0) {
        return null;
    }
    
    for (i = 0; i < arr.length; i++) {
        if (isNaN(arr[i])) {
            throw 'Error';
        }
        sum += +arr[i];
    }
    return sum;
}

module.exports = f;