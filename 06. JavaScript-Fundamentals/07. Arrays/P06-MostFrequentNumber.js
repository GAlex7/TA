/**
 * Write a script that finds the most frequent number in an array.
 * Example: [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3] -> 4 (5 times)
 */
var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

console.log(mostFreqNumb(arr));

function mostFreqNumb(arr) {
    var elems = [],
        counts = [],
        i, j, len, maxCount;
    for (i = 0, len = arr.length; i < len; i += 1) {
        j = elems.indexOf(arr[i]);

        if (j < 0) {
            elems.push(arr[i]);
            counts[elems.length - 1] = 1;
        } else {
            counts[j] += 1;
        }
    }
    maxCount = counts[0];
    j = 0;
    for (i = 1, len = counts.length; i < len; i += 1) {
        if (counts[i] > maxCount) {
            maxCount = counts[i];
            j = i;
        }
    }
    return elems[j] + ' (' + maxCount + ' times)';
}