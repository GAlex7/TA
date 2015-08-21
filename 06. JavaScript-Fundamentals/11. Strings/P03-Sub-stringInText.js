/**
 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:

 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */
var text = "We are living inin an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
    str = 'in';

console.log(getTimes(text, str));

function getTimes(text, str) {
    var i,
        len = text.length,
        strLen = str.length,
        result = 0;

    for (i = 0; i < (len - strLen); i += 1) {
        if (text.substring(i, i + strLen) === str) {
            result += 1;
            i += strLen - 1;
        }
    }
    return result;
}
