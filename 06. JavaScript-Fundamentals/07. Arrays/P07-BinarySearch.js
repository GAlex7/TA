/**
 * Write a script that finds the index of given element
 * in a sorted array of integers by using the binary search algorithm.
 */
var numbers = [3, 9, 10, 11, 14, 18, 23, 24, 28, 29, 37, 38, 41, 44, 47];

console.log(23 + ' -> pos ' + binarySearch(numbers, 23, 0, numbers.length - 1));

function binarySearch(arr, num, min, max) {
    var mid = min + Math.floor((max - min) / 2);

    if (max < min || num > arr[max]) {
        return -1;
    }

    if (arr[mid] > num) {
        return binarySearch(arr, num, min, mid - 1);
    } else if (arr[mid] < num) {
        return binarySearch(arr, num, mid + 1, max);
    } else {
        return mid;
    }
}