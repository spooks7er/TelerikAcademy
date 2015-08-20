Function.prototype.extend = function(parent) {
    var child = this;
    child.prototype = parent;
    child.prototype = new child(Array.prototype.slice.call(1, arguments));
    child.prototype.constructor = child;
}

var Animal = {
    name: 'noname',
    // speak: function(food) {
    //     return 'I would like to eat ' + food + '!';
    // },

    sayHello: function() {
        return 'Hi, I\'m ' + this.name + '.';
    }
};

Animal.prototype.speak = function(food) {
    return 'I would like to eat ' + food + '!';
}

var Rabbit = function(name) {
    if (name) this.name = name;

    this.speak = function(food) {
        return Animal.speak.call(this, food);
    };
}

Rabbit.extend(Animal);

var rabbit2 = new Rabbit('Rebel');
rabbit2.sayHello = function() {
    return Animal.sayHello();
}

console.log(rabbit2.speak('carrots'))
