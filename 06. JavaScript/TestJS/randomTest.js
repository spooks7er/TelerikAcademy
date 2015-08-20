var i, j, count = 1000,
    rand,
    arr = [],
    count0 = 0,
    count1 = 0,
    times0 = 0,
    times1 = 0,
    timesEq = 0;


for (var i = 0; i < 100; i++) {
    for (j = 0; j < count; j += 1) {
        rand = Math.random() * 2 | 0;
        if (rand === 0) {
            count0 += 1;
        }
        if (rand === 1) {
            count1 += 1;
        }
    }
    if (count0 > count1) {
        times0 += 1;
    } else if (count1 > count0) {
        times1 += 1;
    } else if (times0 === times1) {
        timesEq += 1;
    }
}
console.log(times0);
console.log(times1);
console.log(timesEq);
