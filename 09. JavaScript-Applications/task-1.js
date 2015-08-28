/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName` and `lastName` properties
 *   **Finds** all students whose `firstName` is before their `lastName` alphabetically
 *   Then **sorts** them in descending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   Then **prints** the fullname of founded students to the console
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        function isFirstBeforeLastName(man) {
            return man.firstName < man.lastName
        }

        var studentsWithFirstBeforeLastName = _.filter(students, isFirstBeforeLastName);

        var studentsWithFullName = _.map(studentsWithFirstBeforeLastName, function (man) {
            return man.firstName + ' ' + man.lastName;
        });

        var sortedStudents = _.sortBy(studentsWithFullName);
        sortedStudents.reverse();

        _.each(sortedStudents, console.log);

    };
}

module.exports = solve;