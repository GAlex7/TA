/**
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
var a = 8.5,
    b = 4.3,
    h = 2.7;

console.log('The area of trapezoid is ' + getArea(a, b, h));

function getArea(a, b, h) {
    return (a + b) / 2 * h;
}