/**
 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 */

console.log(stringFormat('{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho'));

function stringFormat() {
    var args = arguments,
        result = args[0],
        placeholder, i, len;

    for (i = 1, len = args.length; i < len; i += 1) {
        placeholder = '{' + (i - 1) + '}';

        while (result.indexOf(placeholder) !== -1) {
            result = result.replace(placeholder, args[i]);
        }
    }

    return result;
}
