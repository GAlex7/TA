/**
 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */
var text = "We   are  LiVinG in   a YELLOW SUBMARINE. We dOn'T have anything else.";

console.log(nbspReplace(text));

function nbspReplace(str) {
    return str.replace(/ /g, '&nbsp');
}