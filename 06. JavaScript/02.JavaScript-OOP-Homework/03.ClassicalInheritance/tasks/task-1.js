/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, 
			containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 
		'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed 
		to return other value
		*	enables method-chaining
*/

function solve() {
    var Person = (function() {

        function Person(firstname, lastname, age) {
            if (firstname.length < 3 || firstname.length > 20) {
                throw 'firstname must be strings between 3 and 20 characters.';
            }
            if (lastname.length < 3 || lastname.length > 20) {
                throw 'lastname must be strings between 3 and 20 characters.';
            }
            if (!/^[a-zA-Z]+$/.test(firstname) || !/^[a-zA-Z]+$/.test(lastname)) {
                throw 'firstname and lastname must contain only Latin letters';
            }
            if (age < 0 || age > 150) {
                throw 'age must be in the range 0-150';
            }
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Person.prototype.introduce = function() {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function() {
                return this.firstname + ' ' + this.lastname;
            },
            set: function(n) {
            	//TODO verification
            	var nameArr = n.split(' ');
                this.firstname = nameArr[0];
                this.lastname = nameArr[1];
            }
        });
        return Person;
    }());
    return Person;
}

//module.exports = solve;


//testing

var Person = solve();

var CONSTS = {
    VALID: {
        FIRSTNAME: 'Firsttest',
        LASTNAME: 'Lasttest',
        FULLNAME: 'full test',
        AGE: 5
    },
    INVALID: {
        FIRSTNAME: {
            SHORT: 'Ff',
            LONG: 'F' + (new Array(21).join('f')),
            SYMBOLS: 'Abc&'
        },
        LASTNAME: {
            SHORT: 'Ll',
            LONG: 'L' + (new Array(21).join('l')),
            SYMBOLS: 'Abc12'
        },
        AGE: {
            SMALLER: -1,
            LARGER: 151
        }
    }
};

var p;
p = new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.VALID.AGE);
// p = new Person(CONSTS.VALID.FIRSTNAME,CONSTS.INVALID.LASTNAME.SYMBOLS,CONSTS.VALID.AGE);
// p = new Person(CONSTS.VALID.FIRSTNAME, CONSTS.INVALID.LASTNAME.SHORT, CONSTS.VALID.AGE);
// p = new Person(CONSTS.VALID.FIRSTNAME, CONSTS.INVALID.LASTNAME.LONG, CONSTS.VALID.AGE);
// p = new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.INVALID.AGE.LARGER);

// console.log(p.introduce());
// p.fullname = 'dedo lazo';

// console.log(p.firstname);
// console.log(p.lastname);
// console.log(p.introduce());

console.log(p instanceof Person);

