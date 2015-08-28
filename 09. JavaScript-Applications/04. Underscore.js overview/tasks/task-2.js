/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName`, `lastName` and `age` properties
 *   **finds** the students whose age is between 18 and 24
 *   **prints**  the fullname of found students, sorted lexicographically ascending
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        function isAgeBetween18and24(man) {
            return ((man.age >= 18) & (man.age <= 24))
        }

        var studentsWithCorrectAge = _.filter(students, isAgeBetween18and24);

        var studentsWithFullName = _.map(studentsWithCorrectAge, function (man) {
            return man.firstName + ' ' + man.lastName;
        });

        var sortedStudents = _.sortBy(studentsWithFullName);

        _.each(sortedStudents, console.log);
    };
}

module.exports = solve;
