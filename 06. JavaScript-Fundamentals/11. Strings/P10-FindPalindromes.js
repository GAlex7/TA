/**
 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */
var text = 'ala bala oxoxo nica helleh'

console.log(palindromes(text));

function palindromes(str) {
    var words = str.split(' '),
        i, len, result = [];
    for (i = 0, len = words.length; i < len; i += 1) {
        if (words[i] === reverse(words[i])) {
            result.push(words[i]);
        }
    }
    return result;
}

function reverse(text) {
    var i, result = '';
    text = '' + text;

    for (i = text.length - 1; i >= 0; i -= 1) {
        result += text[i];
    }

    return result;
}