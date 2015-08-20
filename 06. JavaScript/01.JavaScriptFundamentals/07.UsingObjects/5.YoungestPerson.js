var people = [{
    firstname: 'Gosho',
    lastname: 'Petrov',
    age: 32
}, {
    firstname: 'Bay',
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
    age: 39
}, {
    firstname: 'Semi',
    lastname: 'Etaq',
    age: 23
}, ];


function youngestPerson(arr) {
    var max = 150,
        personWithMaxAge = {};

    // for (var person of arr) {
    //     if (person.age < max) {
    //         max = person.age;
    //         personWithMaxAge = person;
    //     }
    // }

    var i, len = arr.length;
    for (i = 0; i < arr.length; i += 1) {
        if (arr[i].age < max) {
            max = arr[i].age;
            personWithMaxAge = arr[i];
        }
    }
    return personWithMaxAge;
}

console.log(youngestPerson(people));
