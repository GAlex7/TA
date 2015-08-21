/**
 * Write a script that finds the biggest of three numbers.
 * Use nested if statements.
 */
var numbs = [-2, -2, 1];

console.log(biggestNumb(numbs[0], numbs[1], numbs[2]));

function biggestNumb(a, b, c) {
    if (a > b) {
        if (a > c) {
            return a;
        }
        return c;
    } else {
        if (b > c) {
            return b;
        }
        return c;
    }
}