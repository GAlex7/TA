/**
 * Sort 3 real values in descending order.
 * Use nested if statements.
 */
var numbs = [-1.1, -0.5, -0.1];
sortNumbs(numbs);
printNumbs(numbs);

function printNumbs(arr) {
    console.log(arr.join(' '));
}

function sortNumbs(arr) {
    var i, j, temp;
    for (i = 0; i < arr.length; i += 1) {
        for (j = i + 1; j < arr.length; j += 1) {
            if (arr[j] > arr[i]) {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}