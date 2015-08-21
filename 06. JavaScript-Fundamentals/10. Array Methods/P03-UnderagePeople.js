/**
 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
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

console.log(underagedThan18(arr));

function underagedThan18(arr) {
    return arr.filter(function (item) {
        return item.age < 18;
    })
}