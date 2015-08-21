/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number
 */

// ?? bgcoder!!!

function solve() {
    return function (arr) {
        if (!arr) {
            throw new Error('Fuck!');
        }
        if (!arr.length) {
            return null;
        }
        var i, len = arr.length, num, sum = 0;
        for (i = 0; i < len; i += 1) {
            num = +arr[i];
            if (isNaN(num)) {
                throw new Error('Is not a number');
            }
            sum += num;
        }
        return sum;
    }
}

module.exports = sum;