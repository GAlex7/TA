/*
 * Problem 1. JavaScript literals
 * Assign all the possible JavaScript literals to different variables.
 *
 * Problem 2. Quoted text
 * Create a string variable with quoted text in it.
 * For example: `'How you doin'?', Joey said'.
 *
 * Problem 3. Typeof variables
 * Try typeof on all variables you created.
 *
 * Problem 4. Typeof null
 * Create null, undefined variables and try typeof on them.
 */
var int = 12,
    float = 3.14,
    string = '"How you doin\'?", Joey said',
    arr = [1, 2, 3],
    object = {course: 'JS', part: 1},
    func = function () {
        return;
    },
    nullValue = null,
    undefinedValue = undefined,
    boolean = false,
    variables = [int, float, string, arr, object, func, nullValue, undefinedValue, boolean],
    variable;

for (variable in variables) {
    console.log(getTypeAsString(variables[variable]));
}

function getTypeAsString(obj) {
    var result = obj;
    result += ' is ' + typeof obj;
    return result;
}