/**
 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b));)a+(b-(c)
 */
var input = '(d/b+c)(a-c)';

console.log(isBracketsOk(input));

function isBracketsOk(text) {
    var lastOpenBr = 0,
        nextCloseBr = 0;
    do {
        lastOpenBr = text.lastIndexOf('(');
        nextCloseBr = text.indexOf(')', lastOpenBr);

        if (nextCloseBr === -1) {
            if (lastOpenBr === -1) {
                return true;
            } else {
                return false;
            }
        } else if (lastOpenBr === -1) {
            return false;
        } else {
            text = text.slice(0, lastOpenBr) + text.slice(lastOpenBr + 1);
            text = text.slice(0, nextCloseBr - 1) + text.slice(nextCloseBr);
        }
    } while (nextCloseBr !== -1);
    return true;
}