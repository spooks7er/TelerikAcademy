var Person = (function() {
    // Private fields
    var name,
        age;
    // Constructor
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }

    // Public field setters and getters
    Object.defineProperty(Person.prototype, 'name', {
        get: function() {
            return name;
        },

        set: function(value) {
            if (!(typeof value === 'string')) {
                throw new Error('must be string');
            }
            name = value;
        },
        enumerable: true,
    })

    Object.defineProperty(Person.prototype, 'age', {
        get: function() {
            return age;
        },

        set: function(value) {
            if (!(value * 1)) {
                throw new Error('must be number');
            }
            age = value;
        },
        enumerable: true,
    })

    // Public Property
    Person.prototype.sayHello = function() {
        return 'Hi, I am ' + name + ' and I am ' + age + ' years old.'
    };

    return Person
})();

var Student = (function(parent) {

    // Here the true inheritance happens, somewhat equivalent to c# ChildClass : ParentClass
    Student.prototype = parent.prototype;

    function Student(name, age, grade) {
        // Calling the base contructor (in c# :base())
        parent.call(this, name, age);
        this.grade = grade;
    }

    // Student.prototype.sayHello = function() {
    //     return parent.sayHello() + 'Iam in '+ this.grade +' grade';
    // };


    return Student
})(Person);

var st1 = new Student('Hugo', 12, 4)
console.log(st1.sayHello())
//console.log(st1 instanceof Person)

console.log(st1)

    // var p1 = new Person('Gosho', 35)
    // console.log(p1.sayHEllo())
    // console.log(p1.name);
    // console.log(p1.age);
    // p1.name = 'Pesho';
    // console.log(p1.name);

// console.log(p1.sayHello())

// var p2 = new Person('Vasil', 16);
// console.log(p2.sayHello())

for (var prop in st1) {
    console.log(prop)
}
