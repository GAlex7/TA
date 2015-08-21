/**
 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');
 */
var obj = {fName: 'Ivan', lName: 'Peshov', age: 25},
    hasProp = hasProperty(obj, 'age');

console.log(obj);
console.log('Property "age"? -> ' + hasProp);

function hasProperty(obj, property) {
    for (var prop in obj) {
        if (prop === property) {
            return true;
        }
    }
    return false;
}