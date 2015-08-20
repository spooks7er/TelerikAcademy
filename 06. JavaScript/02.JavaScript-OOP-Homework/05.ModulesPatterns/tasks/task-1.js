// /* Task Description */

// * Create a module for a Telerik Academy course
//   * The course has a title and presentations
//     * Each presentation also has a title
//     * There is a homework for each presentation
//   * There is a set of students listed for the course
//     * Each student has firstname, lastname and an ID
//       * IDs must be unique integer numbers which are at least 1
//   * Each student can submit a homework for each presentation in the course
//   * Create method init
//     * Accepts a string - course title
//     * Accepts an array of strings - presentation titles
//     * Throws if there is an invalid title
//       * Titles do not start or end with spaces
//       * Titles do not have consecutive spaces
//       * Titles have at least one character
//     * Throws if there are no presentations
//   * Create method addStudent which lists a student for the course
//     * Accepts a string in the format 'Firstname Lastname'
//     * Throws if any of the names are not valid
//       * Names start with an upper case letter
//       * All other symbols in the name (if any) are lowercase letters
//     * Generates a unique student ID and returns it
//   * Create method getAllStudents that returns an array of students in the format:
//     * {firstname: 'string', lastname: 'string', id: StudentID}
//   * Create method submitHomework
//     * Accepts studentID and homeworkID
//       * homeworkID 1 is for the first presentation
//       * homeworkID 2 is for the second one
//       * ...
//     * Throws if any of the IDs are invalid

//   * Create method pushExamResults
//     * Accepts an array of items in the format {StudentID: ..., Score: ...}
//       * StudentIDs which are not listed get 0 points
//     * Throw if there is an invalid StudentID
//     * Throw if same StudentID is given more than once ( he tried to cheat (: )
//     * Throw if Score is not a number

//   * Create method getTopStudents which returns an array of the top 10 performing students
//     * Array must be sorted from best to worst
//     * If there are less than 10, return them all
//     * The final score that is used to calculate the top performing students is done as follows:
//       * 75% of the exam result
//       * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course



{
    var validTitles = [
            'Modules and Patterns',
            'Ofcourse, this is a valid title!',
            'No errors hIr.',
            'Moar taitles',
            'Businessmen arrested for harassment of rockers',
            'Miners handed cabbages to the delight of children',
            'Dealer stole Moskvitch',
            'Shepherds huddle',
            'Retired Officers rally',
            'Moulds detonate tunnel',
            'sailors furious',
        ],
        validNames = [
            'Pesho',
            'Notaname',
            'Johny',
            'Marulq',
            'Keremidena',
            'Samomidena',
            'Medlar',
            'Yglomer',
            'Elegant',
            'Analogical',
            'Bolsheviks',
            'Reddish',
            'Arbitrage',
            'Toyed',
            'Willfully',
            'Transcribing',
        ];

    function getValidTitle() {
        return validTitles[(Math.random() * validTitles.length) | 0];
    }

    function getValidName() {
        return validNames[(Math.random() * validNames.length) | 0];
    }

    function checkStudentList(list1, list2) {
        if (list1.length !== list2.length)
            return false;

        function compare(a, b) {
            return a.id - b.id;
        }

        list1.sort(compare);
        list2.sort(compare);

        for (var i in list1) {
            if (list1[i].id !== list2[i].id)
                return false;
            if (list1[i].firstname !== list2[i].firstname)
                return false;
            if (list1[i].lastname !== list2[i].lastname)
                return false;
        }
        return true;
    }
}



function solve() {

    function deepCopy(obj) {
        if (obj === null || typeof obj != 'object') {
            return obj;
        }
        if (obj instanceof Array) {
            var arrayCopy = [];
            for (var i = 0; i < obj.length; i++) {
                arrayCopy[i] = deepCopy(obj[i]);
            }
            return arrayCopy;
        }
        if (obj instanceof Object) {
            var objectCopy = {};
            for (var attribute in obj) {
                objectCopy[attribute] = deepCopy(obj[attribute]);
            }
            return objectCopy;
        }
    }

    function dynamicSort(property) {
        var sortOrder = 1;
        if (property[0] === "-") {
            sortOrder = -1;
            property = property.substr(1);
        }
        return function(a, b) {
            var result = (a[property] < b[property]) ? -1 : (a[property] > b[property]) ? 1 : 0;
            return result * sortOrder;
        };
    }

    var Course = {

        init: function(title, presentations) {
            if (title[0] === ' ' || title.slice(-1) === ' ') {
                throw new Error('invalid course title');
            }

            if (!presentations || presentations.length === 0) {
                throw new Error('no presentations');
            }

            presentations.forEach(function(title) {
                if (!title || /  +/g.test(title)) {
                    throw new Error('invalid presentation title');
                }
            });

            this._students = [];
            this._examScores = [];

            this.title = title;
            this.presentations = presentations;

            return this;
        },
        addStudent: function(name) {

            if (typeof(name) !== 'string') {
                throw new Error('name must be a string');
            }

            var nameArr = name.split(' ');

            if (nameArr.length !== 2) {
                throw new Error('student must have two names');
            }

            if (!(/^[A-Z]/.test(nameArr[0])) || !(/^[A-Z]/.test(nameArr[1]))) {
                throw new Error('student names must start with a capital letter');
            }

            var newStudent = {
                firstname: nameArr[0],
                lastname: nameArr[1],
                id: this._students.length + 1,
                homeworks: [],
                score: 0,
            };
            this._students.push(newStudent);
            return newStudent.id;
        },
        getAllStudents: function() {
            //return this._students.slice();
            return deepCopy(this._students); //Deep Copy <-- VERY IMPORTANT TO RETURN ANOTHER ARRAY AND NOT THE ORIGINAL
        },
        submitHomework: function(studentID, homeworkID) {
            if (studentID === 0 || studentID > this._numberOfStudents || (studentID) !== (studentID | 0)) {
                throw new Error('invalid student id 1');
            }
            if (homeworkID === 0 || (homeworkID) !== (homeworkID | 0)) {
                throw new Error('invalid homework id 2');
            }
            if (studentID !== homeworkID) {
                throw new Error('invalid homework id 3');
            }

            var currentStudent = this._students.filter(function(student) {
                    return student.id === studentID;
                })[0],
                currentHomework = {
                    id: homeworkID
                }

            currentStudent.homeworks.push(currentHomework)

            return this;
        },
        pushExamResults: function(results) {
            var currentStudent,
                currentScore,
                i,
                len = results.length
            for (i = 0; i < len; i += 1) {
                currentStudent = this._students.filter(function(student) {
                    return student.id === results[i].StudentID;
                })[0]
                if (!currentStudent) {
                    throw new Error('invalid student id');
                }

                this._examScores.forEach(function(score) {
                    if (score.StudentID === results[i].StudentID) {
                        throw new Error('Student score allready submited');
                    }
                })

                currentStudent.score = results[i].Score;
                this._examScores.push(results[i])
            }
            return this;
        },
        getTopStudents: function() {
            var topStudents = this.getAllStudents().sort(dynamicSort('-score'));
            if (topStudents.length > 10) {
                topStudents = topStudents.slice(0, 10);
            }
            return topStudents;
        },
    };

    return Course;
}

//module.exports = solve;

var Course = solve();

var jsoop = Object.create(Course)
    .init(getValidTitle(), [getValidTitle()]);

// jsoop.addStudent('Pesho' + ' ' + 'Grudev');
// jsoop.addStudent('Zevcho' + ' ' + 'Lolov');
// jsoop.addStudent('Fffd' + ' ' + 'Dsad');
// jsoop.submitHomework(1, 1);
var firstname, lastname, listed = [];
for (var i = 0; i < 12; ++i) {
    firstname = getValidName();
    lastname = getValidName();
    listed.push({
        firstname: firstname,
        lastname: lastname,
        id: jsoop.addStudent(firstname + ' ' + lastname)
    });
}

//console.log(checkStudentList(listed, jsoop.getAllStudents()) === true);

var gg = jsoop.getAllStudents();

gg[0].age = -1;
//console.log(jsoop.getAllStudents());


var scores = [{
    StudentID: 1,
    Score: 5.88
}, {
    StudentID: 2,
    Score: 6
}, {
    StudentID: 3,
    Score: 4
},{
    StudentID: 4,
    Score: 3.5
}, {
    StudentID: 5,
    Score: 4.5
}, {
    StudentID: 6,
    Score: 4
},{
    StudentID: 7,
    Score: 3
}, {
    StudentID: 8,
    Score: 5
}, {
    StudentID: 9,
    Score: 4
},{
    StudentID: 10,
    Score: 3
}, {
    StudentID: 11,
    Score: 6
}, {
    StudentID: 12,
    Score: 6.5
},]

jsoop.pushExamResults(scores)

console.log(jsoop.getTopStudents());
