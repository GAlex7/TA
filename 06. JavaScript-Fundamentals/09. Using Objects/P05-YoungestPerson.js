/**
 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstName, lastName and age.

 Example:

 var people = [
 { firstName : 'Gosho', lastName: 'Petrov', age: 32 },
 { firstName : 'Bay', lastName: 'Ivan', age: 81},… ];
 */
var people = [
    {firstName: 'Gosho', lastName: 'Petrov', age: 32},
    {firstName: 'Bay', lastName: 'Ivan', age: 81},
    {firstName: 'Chicho', lastName: 'Gosho', age: 17},
    {firstName: 'Bat', lastName: 'Bojko', age: 5},
    {firstName: 'Kaka', lastName: 'Pena', age: 31}
];

console.log(people);
console.log('The youngest of them is ' + getYoungestPerson(people));

function getYoungestPerson(arr) {
    var minAge = arr[0].age,
        youngestPerson = arr[0].firstName + ' ' + arr[0].lastName,
        i, len;
    for (i = 1, len = arr.length; i < len - 1; i += 1) {
        if (arr[i].age < minAge) {
            minAge = arr[i].age;
            youngestPerson = arr[i].firstName + ' ' + arr[i].lastName;
        }
    }

    return youngestPerson;
}