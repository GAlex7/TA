/**
 Write a JavaScript function that reverses a string and returns it.
 Example:

 input    output
 sample    elpmas
 */
var str = 'sample';

console.log(reverse(str));

function reverse(text) {
    var i, result = '';
    text = '' + text;

    for (i = text.length - 1; i >= 0; i -= 1) {
        result += text[i];
    }

    return result;
}