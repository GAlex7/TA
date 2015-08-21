/**
 * Write an expression that checks if given positive integer number n (n ? 100) is prime.
 */
var numb = 12,
    divisor;

console.log(numb + ' ' + (isPrime(numb) ? 'is' : 'is not') + ' prime.');

function isPrime(number) {
    if (number < 2) return false;

    for (divisor = 2; divisor <= Math.sqrt(number); divisor++) {
        if (!(number % divisor)) return false;
    }

    return true;
}