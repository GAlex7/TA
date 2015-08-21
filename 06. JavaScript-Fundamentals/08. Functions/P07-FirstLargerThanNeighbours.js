/**
 * Write a function that returns the index of the first element in array that is
 * larger than its neighbours or -1, if there’s no such element.
 * Use the function from the previous exercise.
 */

console.log(firstBigger([1, 2, 3, 4, 1, 2, 4, 2, 3, 1, 4, 2, 3, 2]));
console.log(firstBigger([1, 1, 1, 1, 1]));

function firstBigger(arr) {
    var i, len = arr.length;

    for (i = 1; i < len - 1; i += 1) {
        if (isBiggerThanNeighbours(arr, arr[i])) {
            return i;
        }
    }
    return -1;
}

function isBiggerThanNeighbours(arr, pos) {
    if (pos <= 0 || pos >= arr.length - 1) {
        return 'This position is not correct.';
    } else {
        return (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
    }
}