/**
 * Write a script that allocates array of 20 integers and
 * initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.
 */
var n = 20,
    arr = [],
    i;
for (i = 0; i < n; i += 1) {
    arr[i] = i * 5;
}
console.log(arr);