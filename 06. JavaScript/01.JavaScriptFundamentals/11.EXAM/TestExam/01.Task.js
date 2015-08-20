function solve(params) {
    var i,
        j,
        k,
        all,
        s = +params[0],
        count = 0,
        c1 = 4,
        c2 = 10,
        c3 = 3;

    for (i = 0; i <= (s / c1) + 1; i+=1) {
        for (j = 0; j <= (s / c2) + 1; j+=1) {
            for (k = 0; k <= (s / c3) + 1; k+=1) {

                all = (i * c1) + (j * c2) + (k * c3);

                if (all === s) {
                    count+=1;
                }
            }
        }
    }
    return count;
}

var tests = [
    ['7'],
    ['10'],
    ['40']
];

tests.forEach(function(test) {
    console.log(solve(test));
});
