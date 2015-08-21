/**
 * Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 */
var divisable = 70, notDivisable = 7;

console.log(isDivisable(divisable, 5, 7));
console.log(isDivisable(notDivisable, 5, 7));

function isDivisable(number, div1, div2) {
    return !((number % div1) || (number % div2));
}