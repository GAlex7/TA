/**
 * Write a function that counts how many times given number appears in given array.
 * Write a test function to check if the function is working correctly.
 */

console.log(appearCounter([1, 2, 3, 4, 1, 2, 3, 4, 4, 3, 2, 1], 2));

function appearCounter(arr, num) {
    var answer = 0, i, len=arr.length;

    for ( i = 0; i < len; i+=1) {
        if (arr[i] === num) {
            answer+=1;
        }
    }

    return answer;
}

