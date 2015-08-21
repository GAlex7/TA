/**
 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */

console.log(deepCopy(5));
console.log(deepCopy({name: 'Ivan', age: 25}));

function deepCopy(obj) {
    return JSON.parse(JSON.stringify(obj));
}