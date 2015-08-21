/**
 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
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

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}
;

console.log(youngestMale(arr));

function youngestMale(arr) {
    var maleArr = arr.filter(function (item) {
        return item.gender === 'M';
    });

    maleArr[-1] = {age: 100};

    return maleArr.find(function (item, index, arr1) {
        return item.age < arr1[index - 1].age ? item : item[index - 1];
    });
}