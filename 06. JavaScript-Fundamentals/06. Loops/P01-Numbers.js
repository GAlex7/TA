/**
 * Write a script that prints all the numbers from 1 to N.
 */
var n = -5,
    i;
if (n < 0) {
    for (i = 1; i >= n; i -= 1) {
        console.log(i);
    }
} else {
    for (i = 1; i <= n; i += 1) {
        console.log(i);
    }
}