/**
 * Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
 * The bits are counted from right to left, starting from bit #0.
 * The result of the expression should be either 1 or 0.
 */
var numb = 5343;

console.log('The bit #3 of ' + numb + ' is ' + getBitAt(numb, 3));

function getBitAt(numb, position) {
    return (numb >> position) & 1;
}