/* Task description */
/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `string`
 3) it must throw an Error if any of the range params is missing
 */
function solve() {
    return function findPrimes(s, e) {
        s = +s;
        e = +e;
        if (isNaN(s) || isNaN(e)) {
            throw new Error('Fuck');
        }
        var i, num,
            sqrtNum,
            isPrime, arr = [];
        s = s < 2 ? 2 : s;
        for (num = s; num <= e; num += 1) {
            isPrime = true;
            sqrtNum = Math.sqrt(num);
            for (i = 2; isPrime && i <= sqrtNum; i += 1) {
                if (!(num % i)) {
                    isPrime = false;
                }
            }
            if (isPrime) {
                arr.push(num);
            }
        }
        return arr;
    }
}

module.exports = findPrimes;