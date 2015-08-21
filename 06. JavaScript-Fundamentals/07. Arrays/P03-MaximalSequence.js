/**
 * Write a script that finds the maximal sequence of equal elements in an array.
 * Example:
 * input                            result
 * 2, 1, 1, 2, 3, 3, 2, 2, 2, 1     2, 2, 2
 */
var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

console.log(getMaxEqualSequence(arr));

function getMaxEqualSequence(arr) {
    var best = [arr[0]],
        tmp = [arr[0]],
        i, len;
    for (i = 1, len = arr.length; i < len; i += 1) {
        if (arr[i] !== tmp[0]) {
            tmp = [arr[i]];
        } else {
            tmp.push(arr[i]);
        }
        if (tmp.length > best.length) {
            best = tmp;
        }
    }
    return best;
}