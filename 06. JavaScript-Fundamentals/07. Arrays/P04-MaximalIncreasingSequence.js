/**
 * Write a script that finds the maximal increasing sequence in an array.
 * Example: 3, 2, 3, 4, 2, 2, 4 -> 2, 3, 4
 */
var arr = [3, 2, 3, 4, 2, 2, 4];

console.log(getMaxIncreasingSequence(arr));

function getMaxIncreasingSequence(arr) {
    var best = [arr[0]],
        tmp = [arr[0]],
        i, len;
    for (i = 1, len = arr.length; i < len; i += 1) {
        if (arr[i] > arr[i - 1]) {
            tmp.push(arr[i]);
        } else {
            tmp = [arr[i]];
        }
        if (tmp.length > best.length) {
            best = tmp;
        }
    }
    return best;
}