/* 
 Create a function that:
 *   Takes an array of students
 *   Each student has:
 *   `firstName`, `lastName`, `age` and `marks` properties
 *   `marks` is an array of decimal numbers representing the marks
 *   **finds** the student with highest average mark (there will be only one)
 *   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        var studentWithHighestAverageMark = _.chain(students)
            .map(function (student) {
                student.fullname = student.firstName + ' ' + student.lastName;

                var sumOfMarks = _.reduce(student.marks, function (memo, mark) {
                    return memo + mark;
                }, 0);

                var averageMark = sumOfMarks / student.marks.length;
                student.averageMark = averageMark;

                return student;
            })
            .max(function (student) {
                return student.averageMark;
            })
            .value();

        console.log(studentWithHighestAverageMark.fullname + ' has an average score of ' + studentWithHighestAverageMark.averageMark);
    };
}

module.exports = solve;
