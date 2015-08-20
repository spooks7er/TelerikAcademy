/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
    var i, primes = [];

    if (isNaN(from) || isNaN(to)) {
        throw 'Error';
    }

    function checkForPrime(number) {
        if (number <= 1) {
            return false;
        }
        var i, boundary = Math.floor(Math.sqrt(number));
        for ( i = 2; i <= boundary; i += 1) {
            if (number % i === 0) {
                return false;
            }
        }
        return true;
    }

    for (i = +from; i <= +to; i += 1) {
        if (checkForPrime(i)) {
            primes.push(i);
        }
    }
    return primes;
}

module.exports = findPrimes;
