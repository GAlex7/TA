/**
 * Write a script that finds the greatest of given 5 variables.
 * Use nested if statements.
 */
var numbs = [5, 2, 2, 4, 1];

console.log(biggestNumb(numbs[0], numbs[1], numbs[2], numbs[3], numbs[4]));

function biggestNumb(a, b, c, d, e) {
    var result = e;
    if (a > result) {
        result = a;
    }
    if (b > result) {
        result = b;
    }
    if (c > result) {
        result = c;
    }
    if (d > result) {
        result = d;
    }
    if (e > result) {
        result = e;
    }
    return result;
}