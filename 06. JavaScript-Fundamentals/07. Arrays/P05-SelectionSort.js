/**
 * Sorting an array means to arrange its elements in increasing order.
 * Write a script to sort an array.
 * Use the selection sort algorithm:
 * Find the smallest element,
 * move it at the first position,
 * find the smallest from the rest,
 * move it at the second position, etc.
 * Hint: Use a second array
 */
var arr = [1, 5, 2, 4, 0, 3, 6, 8, 7, 9];
selectSort(arr);
console.log(arr);

function selectSort(arr) {
    var i, j, minNumb, minPos, tmp, len;
    for (i = 0, len = arr.length; i < len; i += 1) {
        minNumb = arr[i];
        minPos = i;
        for (j = i; j < len; j += 1) {
            if (arr[j] < minNumb) {
                minPos = j;
                minNumb = arr[j];
            }
        }
        tmp = arr[minPos];
        arr[minPos] = arr[i];
        arr[i] = tmp;
    }
}