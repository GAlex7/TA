/**
 Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.

 var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
 arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
 */

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'],
    elementToRemove = 1;

Array.prototype.remove = function (element) {
    var index = this.indexOf(element);

    while (index > -1) {
        this.splice(index, 1);
        index = this.indexOf(element);
    }
};

console.log("REMOVE ELEMENTS");
console.log("Array:", arr);
arr.remove(elementToRemove);
console.log("Array after remove:", arr);