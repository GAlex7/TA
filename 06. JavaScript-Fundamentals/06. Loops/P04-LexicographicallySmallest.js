/**
 * Write a script that finds the lexicographically smallest and
 * largest property in document, window and navigator objects.
 */
function getProperties(element) {
    var elements = Object.getOwnPropertyNames(element);
    elements.sort();

    console.log('Element ' + element.toString());
    console.log('Lexicographically first: ' + elements[0] +
        ' and last: ' + elements[elements.length - 1]);
    console.log();
}
getProperties(document);
getProperties(window);
getProperties(navigator);