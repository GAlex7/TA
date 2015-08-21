/**
 * Write a script that compares two char arrays lexicographically (letter by letter).
 */
var arr1 = ['a', 'b', 'c', 'd'],
    arr2 = ['a', 'b', 'e', 'd'],
    len,
    i,
    result = true;
for (i = 0, len = arr1.length; i < len; i += 1) {
    if (arr1[i] !== arr2[i]) {
        result = false;
    }
}
console.log(result);