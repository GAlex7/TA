/**
 * Write a script that finds the max and min number from a sequence of numbers.
 */
var minNumb,
    maxNumb,
    numbs = [1, 3, 5, 2, 4, 7, 9, -5],
    i, len;

console.log(getMinMax(numbs));

function getMinMax(arr) {
    minNumb = arr[0];
    maxNumb = arr[0];
    for (i = 1, len = arr.length; i < len; i += 1) {
        if (arr[i] > maxNumb) {
            maxNumb = arr[i];
        }
        if (arr[i] < minNumb) {
            minNumb = arr[i];
        }
    }
    return ('min = ' + minNumb + ', max = ' + maxNumb);
}