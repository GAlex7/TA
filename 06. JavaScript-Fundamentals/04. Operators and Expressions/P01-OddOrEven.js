/**
 * Write an expression that checks if given integer is odd or even.
 */
var evenNumb = 6,
    oddNumb = 5;

console.log('Is ' + evenNumb + ' odd? -> ' + isOdd(evenNumb));
console.log('Is ' + oddNumb + ' odd? -> ' + isOdd(oddNumb));

function isOdd(number) {
    return Boolean(number & 1);
}