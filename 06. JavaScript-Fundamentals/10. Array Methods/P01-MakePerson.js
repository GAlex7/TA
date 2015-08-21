/**
 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */
var i, j = 10;
for (i = 1; i <= j; i += 1) {
    console.log(createPerson('FN-' + i, 'LN-0' + i, i + 15, Math.floor(Math.random() + 0.5)));
}

function createPerson(firstname, lastname, age, gender) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age,
        gender: (gender ? 'F' : 'M')
    }
}