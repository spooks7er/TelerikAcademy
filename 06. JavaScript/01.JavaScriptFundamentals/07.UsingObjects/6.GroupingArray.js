var people = [{
    firstname: 'Gosho',
    lastname: 'Petrov',
    age: 32
}, {
    firstname: 'Gosho',
    lastname: 'Ivan',
    age: 45
}, {
    firstname: 'Stamat',
    lastname: 'Geshev',
    age: 74
}, {
    firstname: 'Frederico',
    lastname: 'Mainatamu',
    age: 27
}, {
    firstname: 'Hlapoch',
    lastname: 'Perushev',
    age: 11
}, {
    firstname: 'Buba',
    lastname: 'Lazi',
    age: 11
}, {
    firstname: 'Semi',
    lastname: 'Etaq',
    age: 11
}, ];

function group(people, property) {
    if (!people[0].hasOwnProperty(property)) {
        throw new Error('no such property!');
    }
    groups = {};
    people.forEach(function(current) {
        if (!groups[current[property]]) {
            groups[current[property]] = [];
        }
        groups[current[property]].push(current);
    });
    return groups;
}

var groupedByFirstName = group(people, 'firstname');
var groupedByLastName = group(people, 'lastname');
var groupedByAge = group(people, 'age');

console.log(people);
console.log(groupedByAge);
