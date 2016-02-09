/* Task Description */
/*
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {

    function isTitleValid(title) {
        if (title === null || typeof title !== 'string') {
            throw new Error('Invalid type for title!');
        }

        if (title.trim() === '' || title !== title.trim()) {
            throw new Error('Invalid title!');
        }

        if (/[\s]{2,}/.test(title)) {
            throw new Error('Invalid spacing!');
        }
    }

    function isPresentationsValid(presentations) {
        if (presentations === null || !Array.isArray(presentations)) {
            throw new Error('Invalid type for presentations!');
        }

        if (presentations.length === 0) {
            throw new Error('Invalid length!');
        }

        presentations.forEach(function (title) {
            isTitleValid(title);
        });
    }

    function isNameValid(name) {
        if (!/^[A-Z][a-z]*$/.test(name.trim())) {
            throw new Error('Invalid first name!');
        }
    }

    var Course = {
        init: function (title, presentations) {
            isTitleValid(title);
            this.title = title;
            isPresentationsValid(presentations);
            this.presentations = presentations;
            this.students = [];

            return this;
        },
        addStudent: function (name) {
            var names = name.split(' '),
                getId = this.students.length + 1;

            if (names.length !== 2) {
                throw new Error('Student have only two names!');
            }

            isNameValid(names[0]);
            isNameValid(names[1]);

            this.students.push({
                firstname: names[0].trim(),
                lastname: names[1].trim(),
                id: getId
            });

            return getId;
        },
        getAllStudents: function () {
            return this.students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            if (isNaN(studentID) || isNaN(homeworkID)) {
                throw new Error('IDs must be numbers!')
            }

            if (studentID < 1 || homeworkID < 1) {
                throw new Error('IDs must be positive numbers!');
            }

            if (+studentID > this.students.length || +homeworkID > this.presentations.length) {
                throw new Error();
            }
        },
        pushExamResults: function (results) {
            var i, len, j;

            if (!Array.isArray(results)) {
                throw new Error();
            }

            for (i = 0, len = results.length; i < len; i += 1) {
                if (isNaN(results[i].StudentID) || isNaN(results[i].score) || results[i].StudentID < 1 || results[i].StudentID > this.students.length) {
                    throw new Error();
                }

                for (j = i + 1; j < len; j += 1) {
                    if (results[i].StudentID === results[j].StudentID) {
                        throw new Error();
                    }
                }
            }
            return this;
        },
        getTopStudents: function () {
        }
    };

    return Course;
}
module.exports = solve;