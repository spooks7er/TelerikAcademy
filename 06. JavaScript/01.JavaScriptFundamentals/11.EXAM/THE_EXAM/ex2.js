function solve(params) {
    //debugger;
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        i, move, mls, mns, mle, mne, currPos, nextPos,
        board = params.slice(2, rows + 2).map(function(row) {
            return row.split('');
        });

    for (i = 0; i < tests; i += 1) {
        move = params[rows + 3 + i];

        mls = move.split(' ')[0][0];
        mns = move.split(' ')[0][1];

        mle = move.split(' ')[1][0];
        mne = move.split(' ')[1][1];

        currPos = getArrayCoords(mls, mns);
        nextPos = getArrayCoords(mle, mne);
        if (board[currPos[0]][currPos[1]] == '-') {
            console.log('no');
        }
        if (board[currPos[0]][currPos[1]] == 'R') {
            if (checkRook(currPos, nextPos)) {
                // board[currPos[0]][currPos[1]] = '-';
                // board[nextPos[0]][nextPos[1]] = 'R';
                console.log('yes');
            } else {
                console.log('no');
            }
        }
        if (board[currPos[0]][currPos[1]] == 'B') {
            if (checkBishop(currPos, nextPos)) {
                // board[currPos[0]][currPos[1]] = '-';
                // board[nextPos[0]][nextPos[1]] = 'B';
                console.log('yes');
            } else {
                console.log('no');
            }
        }
        if (board[currPos[0]][currPos[1]] == 'Q') {
            if (checkQueen(currPos, nextPos)) {
                // board[currPos[0]][currPos[1]] = '-';
                // board[nextPos[0]][nextPos[1]] = 'Q';
                console.log('yes');
            } else {
                console.log('no');
            }
        }


        // or console.log('no');
    }

    function getArrayCoords(letter, number) {
        var result = [],
            num1, num2;
        num1 = letter.charCodeAt(0) - 97;
        num2 = rows - number;
        result.push(num2);
        result.push(num1);
        return result;
    }

    function checkRook(rookNow, rookNext) {
        var n1 = +rookNow[0],
            n2 = +rookNow[1],
            n3 = +rookNext[0],
            n4 = +rookNext[1],
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
        var n1 = +Now[0],
            n2 = +Now[1],
            n3 = +Next[0],
            n4 = +Next[1],
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
        var n1 = +Now[0],
            n2 = +Now[1],
            n3 = +Next[0],
            n4 = +Next[1],
            moves = [
                [+1, -1, +1, -1, +1, -1, 0, 0],
                [+1, -1, -1, +1, 0, 0, -1, +1]
            ],
            i, y, q;


        for (i = 0; i < 8; i++){
            for (y = 0; y < rows; y++){
                if (!(n2 + moves[0][0 + i] + y * moves[0][0 + i] < 0 || n1 + moves[1][0 + i] + y * moves[1][0 + i] > 7)){
                    if (n4 == n2 + moves[0][0 + i] + y * moves[0][0 + i] && n3 == n1 + moves[1][0 + i] + y * moves[1][0 + i]) {
                        for (q = 1; q < y + 1; q++) {
                            n2 += moves[0][0 + i];//debugger;
                            n1 += moves[1][0 + i];
                            if (board[n1][n2] != '-') return false;
                        }
                        return true;
                    }
                }
            }
        }
        return false;
    }

    //console.log(board);
}


var tests = [
    [
        '3',
        '4',
        '--R-',
        'B--B',
        'Q--Q',
        '12',
        'd1 b3',
        'a1 a3',
        'c3 b2',
        'a1 c1',
        'a1 b2',
        'a1 c3',
        'a2 b3',
        'd2 c1',
        'b1 b2',
        'c3 b1',
        'a2 a3',
        'd1 d3'
    ],
    // [
    //     '5',
    //     '5',
    //     'Q---Q',
    //     '-----',
    //     '-B---',
    //     '--R--',
    //     'Q---Q',
    //     '10',
    //     'a1 a1',
    //     'a1 d4',
    //     'e1 b4',
    //     'a5 d2',
    //     'e5 b2',
    //     'b3 d5',
    //     'b3 a2',
    //     'b3 d1',
    //     'b3 a4',
    //     'c2 c5'
    // ]
];

tests.forEach(function(test) {
    solve(test)
});
