/**
 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */
var arr = [
    {name: 'Ivan', lastName: 'Ivanov', age: 13},
    {name: 'Pesho', lastName: 'Peshev', age: 21},
    {name: 'Bay', lastName: 'Ivan', age: 19},
    {name: 'Gosho', lastName: 'Goshev', age: 32},
    {name: 'Pepa', lastName: 'Petrova', age: 18},
    {name: 'Coko', lastName: 'Bokov', age: 17}
];

console.log(arr.some(isGreaterThan18));

function isGreaterThan18(arr) {
    return arr.age > 18;
}
