String.prototype.format = function(obj) {
    var prop,
        regex,
        newFormat = this;
    for (prop in obj) {
        regex = new RegExp('#{' + prop + '}', 'g');
        newFormat = newFormat.replace(regex, obj[prop]);
    }
    return newFormat;
};

console.log('The oresident of the United States is #{name}?'.format({
    name: 'Obama'
}));
console.log('This is #{name} and he is #{age} years old'.format({
    name: 'Jonny',
    age: 11
}));
