/**
 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */
var arr = [
    {name: 'Ivan', lastName: 'Ivanov', age: 13, gender: 'M'},
    {name: 'Pesho', lastName: 'Peshev', age: 21, gender: 'M'},
    {name: 'Bay', lastName: 'Ivan', age: 19, gender: 'M'},
    {name: 'Petra', lastName: 'Petrova', age: 20, gender: 'F'},
    {name: 'Gosho', lastName: 'Goshev', age: 32, gender: 'M'},
    {name: 'Pepa', lastName: 'Petrova', age: 35, gender: 'F'},
    {name: 'Coko', lastName: 'Bokov', age: 17, gender: 'M'}
];

console.log(averageAgeOfFemales(arr));

function averageAgeOfFemales(arr) {
    var femaleArr = arr.filter(function (item) {
        return item.gender === 'F';
    });

    return femaleArr.reduce(function (sum, number) {
            return sum + number.age;
        }, 0) / femaleArr.length;
}