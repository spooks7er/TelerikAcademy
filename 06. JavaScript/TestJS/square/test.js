var Person = (function() {

    function Person(name) {
        this._name = name
    }

    Object.defineProperty(Person.prototype, 'name', {
        get: function() {
            //console.log('getter')
            return this._name
        },
        set: function(value) {
            //console.log('getter')
            this._name = value
        },
        //enumerable: true,
    })

    Person.prototype.sayHello = function() {
        return 'Hi, I am ' + this.name + '.';
    };

    return Person;
})();

var Student = (function(parent) {

    // Here the true inheritance happens, somewhat equivalent to c# ChildClass : ParentClass
    Student.prototype = Object.create(parent.prototype)

    function Student(name, grade) {
        // Calling the base contructor (in c# :base())
        parent.call(this, name);
        this.grade = grade;
    }

    Student.prototype.sayHello = function() {
        return parent.prototype.sayHello.call(this) + ' I am in ' + this.grade + ' grade.';
    };


    return Student
})(Person);

var p = new Person('pesho');
console.log(p.name)

var st = new Student('dragan', 5);

console.log(st.sayHello());



// p.name = 'asdasd'
// console.log(p)

// for (var prop in p) {
// 	console.log(prop.valueOf())
// }

// var asdf = 'Asdf'
// asdf[1] = 'G'
// console.log(asdf.slice(-1))
// console.log(asdf)


// console.log(/^[A-Z]/.test(asdf))
