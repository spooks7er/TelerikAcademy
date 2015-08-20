var person,
    areAllAdults,
    allKids,
    allFemales,
    sumAge;

console.log('Problem 1. Make person and an array of people\n');

function Person(firstName, lastName, age, gender) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

var people = [
    new Person('Stamat', 'Geshev', 74, 'male'),
    new Person('Palka', 'Gudeva', 22, 'female'),
    new Person('Frederico', 'Mainatamu', 27, 'male'),
    new Person('Smachkana', 'Salfetka', 17, 'female'),
    new Person('Hlapoch', 'Perushev', 11, 'male'),
    new Person('Granata', 'Limonkova', 39, 'female'),
    new Person('Mojo', 'Jojo', 35, 'male'),
    new Person('Buba', 'Lazi', 41, 'female'),
    new Person('Semi', 'Etaq', 42, 'male'),
    new Person('Kaka', 'Ginka', 29, 'female')
];

people.forEach(function(person) {
    console.log(person);
});

console.log('\nProblem 2. People of age\n');

areAllAdults = people.every(function(person) {
    return person.age >= 18;
});
console.log('Are all people in the array adults? ' + areAllAdults.toString().toUpperCase());

console.log('\nProblem 3. Underaged people\n');

allKids = people.filter(function(person) {
    return person.age < 18;
});

allKids.forEach(function(person) {
    console.log(person)
});

console.log('\nProblem 4. Average age of females\n');

allFemales = people.filter(function(person) {
    return person.gender == 'female';
});

sumAge = allFemales.reduce(function(sumAge, person) {
    return sumAge + person.age;
}, 0);
console.log('The average age of the females in the aray is ' + sumAge / allFemales.length + ' years');

console.log('\nProblem 5. Youngest person\n');

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}
person = people.find(function(person) {
    return person.age == 11;
})
console.log(person.firstName + ' ' + person.lastName + ', Age: ' + person.age);

function youngestPeople(people) {
    var i,
        len = people.length,
        minAge = 150,
        yngstPersonArr = [];
    for (i = 0; i < len; i += 1) {
        if (people[i].age < minAge) {
            yngstPersonArr = [];
            minAge = people[i].age
            yngstPerson = people[i];
            yngstPersonArr.push(yngstPerson);
        }
        if (yngstPerson.age === people[i].age && yngstPerson!==people[i]) {
            yngstPersonArr.push(people[i]);
        }
    }
    return yngstPersonArr;
}

youngestPeople(people).forEach(function(person){
    console.log(person.firstName + ' ' + person.lastName + ', Age: ' + person.age);
});

console.log('\nProblem 6. Group people\n');

var sorted = people.reduce(function(obj, person) {
    debugger;
    if (obj[person.firstName[0]]) {
        obj[person.firstName[0]].push(person);
    } else {
        obj[person.firstName[0]] = [person];
    }
    return obj;
}, {});

console.log(sorted)
