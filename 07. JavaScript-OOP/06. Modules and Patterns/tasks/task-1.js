function solve() {
    var Course = {
        init: function (title, presentations) {
            validateTitle(title);
            this._title = title;

            validatePresentations(presentations);
            this._presentations = presentations;

            this._students = [];

            return this;
        },
        addStudent: function (name) {
            validateName(name);
            var id = this._students.length + 1;
            var names = name.split(' ');
            this._students.push({
                firstname: names[0],
                lastname: names[1],
                id: id
            });

            return id;
        },
        getAllStudents: function () {

            return this._students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            if (!isIdValid(studentID, this._students.length)) {
                throw new Error('Invalid student ID')
            }

            if (!isIdValid(homeworkID, this._presentations.length)) {
                throw new Error('Invalid Homework ID')
            }
        },
        pushExamResults: function (results) {
            validateResults(results);

            this._results = results.map(function(result) {
                return isIdValid(result.StudentID, this._students.length)
                    ? result
                    : {
                    StudentID: result.StudentID,
                    Score: 0
                };
            });

            return this;
        },
        getTopStudents: function () {
            return this;
        }
    };

    function isString(literal) {
        return typeof literal === 'string';
    }

    function validateName(name) {
        if (!/^[A-Z][a-z]* *[A-Z][a-z]*$/.exec(name)) {
            throw 'Student name must be a string in format "Firstname Lastname"';
        }

        return true;
    }

    function validateTitle(title) {
        if (!isString(title)) {
            throw 'Title must be a string!';
        }

        if (/^ | $/.exec(title)) {
            throw 'Titles must not start or end with spaces!'
        }

        if (/ {2,}/.exec(title)) {
            throw 'Titles must not have consecutive spaces!'
        }

        if (!/.+/.exec(title)) {
            throw 'Titles must have at least one character!'
        }

        return true;
    }

    function validatePresentations(presentations) {
        if (!presentations || !Array.isArray(presentations) || presentations.length === 0) {
            throw 'Invalid presentation Titles array!';
        }

        presentations.forEach(function (title) {
            if (!validateTitle(title)) {
                throw 'Invalid presentation title at init()!';
            }
        });

        return true;
    }

    function isIdValid(id, maxId) {
        if (isNaN(id) || id < 1 || id > maxId || (id !== (id | 0))) {
            return false;
        }
        return true;
    }

    function validateResults(results) {
        var uniqueIDs = [],
            studentID,
            score;

        results.forEach(function(result) {
            studentID = result.StudentID;
            score = result.Score;
            uniqueIDs.push(studentID);
        })
    }

    return Course;
}
module.exports = solve;