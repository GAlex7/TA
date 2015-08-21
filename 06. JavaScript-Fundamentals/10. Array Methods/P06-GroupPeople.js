/**
 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */
var arr = [
    {name: 'Ivan', lastName: 'Ivanov', age: 13, gender: 'M'},
    {name: 'Pesho', lastName: 'Peshev', age: 21, gender: 'M'},
    {name: 'Bay', lastName: 'Ivan', age: 19, gender: 'M'},
    {name: 'Petra', lastName: 'Petrova', age: 20, gender: 'F'},
    {name: 'Gosho', lastName: 'Goshev', age: 32, gender: 'M'},
    {name: 'Pepa', lastName: 'Petrova', age: 11, gender: 'F'},
    {name: 'Coko', lastName: 'Bokov', age: 17, gender: 'M'}
];

console.log(groupFirstLetter(arr));

function groupFirstLetter(arr) {
    arr = arr.sort(function (p1, p2) {
        return p1.name > p2.name;
    });

    return arr.reduce(function (obj, item) {
        if (obj[item.name[0]]) {
            obj[item.name[0]].push(item);
        } else {
            obj[item.name[0]] = [item];
        }
        return obj;
    }, {});
}