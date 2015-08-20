function solve(args) {

    var rows = +args[0].split(' ')[0],
        cols = +args[0].split(' ')[1],
        matrix = args.slice(1).map(function(row) {
            return row.split(' ');
        }),
        row = 0,
        col = 0,
        sum = 0,
        curRow, curCol,
        dirs = {
            dr: [+1, +1],
            ur: [-1, +1],
            ul: [-1, -1],
            dl: [+1, -1]
        };
    var counter = 0;

    while (1) {
        curRow = row;
        curCol = col;
        sum += (1 << row) + col;
        row += dirs[matrix[curRow][curCol]][0];
        col += dirs[matrix[curRow][curCol]][1];
        matrix[curRow][curCol] = 'used';
        if ((row >= rows || row < 0) || (col >= cols || col < 0)) {
            return 'successed with ' + sum;
        }
        if (matrix[row][col] === 'used') {
            return 'failed at (' + row + ', ' + col + ')';
        }
    }
    return sum;
}


var tests = [
    [
        '3 5',
        'dr dl dr ur ul',
        'dr dr ul ur ur',
        'dl dr ur dl ur'
    ],
    [
        '3 5',
        'dr dl dl ur ul',
        'dr dr ul ul ur',
        'dl dr ur dl ur'
    ]
];

tests.forEach(function(test) {
    console.log(solve(test));
});
