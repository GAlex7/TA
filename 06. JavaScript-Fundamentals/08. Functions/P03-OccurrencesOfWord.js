/**
 * Write a function that finds all the counter of word in a text.
 * The search can be case sensitive or case insensitive.
 * Use function overloading.
 */

console.log(countWord('Write a Function that finds all the occurrences of word in a text. The search can be case sensitive or case insensitive. Use function overloading.', 'function'));

function countWord(text, word, sensitive) {
    var caseSens = sensitive || false,
        words, counter = 0, i, len;

    text = text.replace(/\W+/g, ' ');

    if (caseSens) {
        words = text.split(' ');
    } else {
        words = text.toLowerCase().split(' ');
        word = word.toLowerCase();
    }

    len = words.length;
    for (i = 0; i < len; i += 1) {
        if (words[i] === word) {
            counter += 1;
        }
    }

    return counter;
}