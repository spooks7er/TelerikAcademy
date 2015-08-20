function solve(args) {
    var result = '',
        i, len = args.length;
    for (i = 0; i < len; i++) {
        args[i] = args[i].split(/\t|\s|\n/g);
        args[i] = args[i].filter(function(item) {
            return item;
        });
        //console.log(args[i]);
    }
    for (i = 0; i < len; i++) {
        //console.log(args[i]);
        if (args[i].indexOf('all{') > 0 ) {debugger;
        	args[i][args[i].indexOf('all{')] = ' '+'all{';
        }
    }
    for (i = 0; i < len; i++) {
        result += args[i];
    }
    result = result.replace(/,/g, '');
    result = result.split(';}').join('}');

    console.log(result);
}




var tests = [
    [
        '#the-big-b    all{',
        '  color: yellow;',
        '  size: big;',
        '}',
        '.muppet{',
        '  powers: all;',
        '  skin: fluffy;',
        '}',
        '     .water-spirit         {',
        '  powers: water;',
        '             alignment    : not-good;',
        '				}',
        'all{',
        '  meant-for: nerdy-children;',
        '}',
        '.muppet      {',
        '	powers: everything;',
        '}',
        'all            .muppet {',
        '	alignment             :             good                             ;',
        '}',
        '   .muppet+             .water-spirit{',
        '   power: everything-a-muppet-can-do-and-water;',
        '}',
    ],
];


tests.forEach(function(test) {
    solve(test);
});
