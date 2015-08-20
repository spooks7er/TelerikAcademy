function solve(params) {
    var nk = params[0].split(' ').map(Number), //[ 5, 1 ]
        s = params[1].split(' ').map(Number), //[ 9, 0, 2, 4, 1 ]
        result, //0 7 4 2 13
        i = 0,
        len = s.length,
        prI, neI,
        count = nk[1];
        newS = s.slice();
    while (count > 0) {

        for (i = 0; i < len; i += 1) {
            prI = i - 1;
            neI = i + 1;
            if (i === 0) {
                prI = len - 1;
            }
            if (i === len - 1) {
                neI = 0;
            }
            if (s[i] === 0) {
                newS[i] = Math.abs(s[prI] - s[neI]);
            } else if (s[i] === 1) {
                newS[i] = Math.abs(s[prI] + s[neI]);
            } else if ((s[i] % 2 === 0) && (s[i] !== 0)) {
                newS[i] = Math.max(s[prI], s[neI]);
            } else if ((s[i] % 2 !== 0) && (s[i] !== 1)) {
                newS[i] = Math.min(s[prI], s[neI]);
            }
        }
        count -= 1;
        s = newS.slice();
        // i++;
        // if (i == len) {
        //     i = 0;
        // }
    }
    result = newS.reduce(function(previousValue, currentValue, index, array) {
        return previousValue + currentValue;
    });
    return result;
}


var tests = [
    [
        '5 1',
        '9 0 2 4 1'
    ],
    [
        '10 3',
        '1 9 1 9 1 9 1 9 1 9'
    ],
    [
        '10 10',
        '0 1 2 3 4 5 6 7 8 9'
    ]
];

tests.forEach(function(test) {
    console.log(solve(test));
});
