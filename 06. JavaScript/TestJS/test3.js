var someobj = {
        id: 12,
        name: 'asd213',
        description: 'fooooo qwe',
        isbn: 1234567890,
        genre: 'Horror'
    },
    secondobj = {
        id: 33,
        name: 'second',
        description: 'barrrrr asd qwe',
        isbn: 1234567890,
        genre: 'Horror'
    };

var arr = [someobj, secondobj];


console.log(arr.filter(function(obj) {
    return obj.id === 12 && obj.name === 'asd213' && obj.genre === 'Horror';
}));
