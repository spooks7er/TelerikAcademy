var str1 = 'bbca';
var str2 = 'abcb';
var result = lexicographicComparison(str1, str2);

if (result == 1) {
    console.log('str1 is greater');
} else if (result == -1) {
    console.log('str2 is greater');
} else if (result == 0) {
    console.log('str1 is equal to str2');
}

function lexicographicComparison(str1, str2) {
    var len1 = str1.length;
    var len2 = str2.length;
    var sum1 = 0;
    var sum2 = 0;
    var i = 0;
    while (i < len1) {
        if (str1.charCodeAt(i) < 97)
            sum1 += str1.charCodeAt(i) + 32;
        else
            sum1 += str1.charCodeAt(i);
        i++;
    }
    i = 0;
    while (i < len2) {
        if (str2.charCodeAt(i) < 97)
            sum2 += str2.charCodeAt(i) + 32;
        else
            sum2 += str2.charCodeAt(i);
        i++;
    }
    console.log(sum1);
    console.log(sum2);
    if (sum1 > sum2)
        return 1;
    else if (sum1 < sum2)
        return -1;
    else if (sum1 == sum2)
        return 0;
}