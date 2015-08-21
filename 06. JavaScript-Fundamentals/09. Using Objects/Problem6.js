/**
 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)

 Example:

 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');
 */
var people = [
    {firstName: 'Gosho', lastName: 'Petrov', age: 31},
    {firstName: 'Bay', lastName: 'Ivan', age: 17},
    {firstName: 'Gosho', lastName: 'Gosho', age: 17},
    {firstName: 'Bat', lastName: 'Bojko', age: 5},
    {firstName: 'Kaka', lastName: 'Pena', age: 31}
];

console.log(people);
console.log('-----------------------------');
console.log(groupBy(people, 'firstName'));


function groupBy(arr, key) {
    var keys = [],
        i, len, groups, result = [];

    for (i = 0, len = arr.length; i < len; i += 1) {
        keys[i] = arr[i][key];
    }
    groups = keys.filter(function onlyUnique(value, index, self) {
        return self.indexOf(value) === index;
    });

    for (i = 0, len = groups.length; i < len; i += 1) {
        result['Group: ' + groups[i]] = arr.filter(function (item) {
            return item[key] === groups[i];
        })
    }

    return result;
}
