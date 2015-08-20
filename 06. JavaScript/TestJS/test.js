// function getArrayCoords(letter, number) {
//     var result = [],
//         num1, num2;

//     num1 = letter.charCodeAt(0) - 97;
//     num2 = 5 - number;
//     result.push(num1);b
//     result.push(num2);
//     return result;
// }
    function getArrayCoords(letter, number) {
        var result = [],
            num1, num2;
        num1 = letter.charCodeAt(0) - 97;
        num2 = 3 - number;
        result.push(num2);
        result.push(num1);
        return result;
    }
console.log(getArrayCoords('a', '1'));
console.log(getArrayCoords('b', '2'));


// Rook(string[, ] board, int n2, int n1, int n4, int n3) {
//     bool valid = false;
//     int[, ] moves = new int[, ] {
//         {
//             +1, -1, 0, 0
//         }, {
//             0, 0, -1, +1
//         }
//     };
//     for (int i = 0; i < 4; i++)
//         for (int y = 0; y < 7; y++)
//             if (!(n2 + moves[0, 0 + i] + y * moves[0, 0 + i] < 0 || n1 + moves[1, 0 + i] + y * moves[1, 0 + i] > 7))
//                 if (n4 == n2 + moves[0, 0 + i] + y * moves[0, 0 + i] && n3 == n1 + moves[1, 0 + i] + y * moves[1, 0 + i]) {
//                     for (int q = 1; q < y + 1; q++) {
//                         n2 += moves[0, 0 + i];
//                         n1 += moves[1, 0 + i];
//                         if (board[n2, n1] != "   ") return valid;
//                     }
//                     return valid = true;
//                 }
//     return valid;
// }

function checkRook(rookNow, rookNext) {
    var n1 = rookNow[0],
        n2 = rookNow[1],
        n3 = rookNext[0],
        n4 = rookNext[1],
        moves = [
            [+1, -1, 0, 0],
            [0, 0, -1, +1]
        ],
        i, y, q;

    for (i = 0; i < 4; i++) {
        for (y = 0; y < 7; y++) {
            if (!(n2 + moves[0][0 + i] + y * moves[0][0 + i] < 0 || n1 + moves[1][0 + i] + y * moves[1][0 + i] > 7))
                if (n4 == n2 + moves[0][0 + i] + y * moves[0][0 + i] && n3 == n1 + moves[1][0 + i] + y * moves[1][0 + i]) {
                    for (q = 1; q < y + 1; q++) {
                        n2 += moves[0][0 + i];
                        n1 += moves[1][0 + i];
                        if (board[n2][n1] != '-') return false;
                    }
                    return true;
                }
        }
    }
    return false;
}

function checkBishop(Now, Next) {
    var n1 = Now[0],
        n2 = Now[1],
        n3 = Next[0],
        n4 = Next[1],
        moves = [
            [+1, -1, +1, -1],
            [+1, -1, -1, +1]
        ],
        i, y, q;


    for (i = 0; i < 4; i++)
        for (y = 0; y < 7; y++)
            if (!(n2 + moves[0][0 + i] + y * moves[0][0 + i] < 0 || n1 + moves[1][0 + i] + y * moves[1][0 + i] > 7))
                if (n4 == n2 + moves[0][0 + i] + y * moves[0][0 + i] && n3 == n1 + moves[1][0 + i] + y * moves[1][0 + i]) {
                    for (q = 1; q < y + 1; q++) {
                        n2 += moves[0][0 + i];
                        n1 += moves[1][0 + i];
                        if (board[n2][n1] != '-') return false;
                    }
                    return true;
                }
    return false;
}


function checkQueen(Now, Next) {
    var n1 = Now[0],
        n2 = Now[1],
        n3 = Next[0],
        n4 = Next[1],
        moves = [
            [+1, -1, +1, -1, +1, -1, 0, 0],
            [+1, -1, -1, +1, 0, 0, -1, +1]
        ],
        i, y, q;


    for (i = 0; i < 8; i++)
        for (y = 0; y < 7; y++)
            if (!(n2 + moves[0][0 + i] + y * moves[0][0 + i] < 0 || n1 + moves[1][0 + i] + y * moves[1][0 + i] > 7))
                if (n4 == n2 + moves[0][0 + i] + y * moves[0][0 + i] && n3 == n1 + moves[1][0 + i] + y * moves[1][0 + i]) {
                    for (q = 1; q < y + 1; q++) {
                        n2 += moves[0][0 + i];
                        n1 += moves[1][0 + i];
                        if (board[n2][n1] != '-') return false;
                    }
                    return true;
                }
    return false;
}
