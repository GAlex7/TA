/**
 * Write a function that checks if the element at given position in given array of integers
 * is bigger than its two neighbours (when such exist).
 */

console.log(isBiggerThanNeighbours([1, 2, 3, 4, 1, 2, 3, 4, 4, 3, 2, 1], 2));

function isBiggerThanNeighbours(arr, pos) {
    if (pos <= 0 || pos >= arr.length - 1) {
        return 'This position is not correct.';
    } else {
        return (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
    }
}

