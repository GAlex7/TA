/**
 Write a function that formats a string. The function should have placeholders, as shown in the example
 Add the function to the String.prototype
 Input:
 var options = {name: 'John', age: 13};
 'My name is #{name} and I am #{age}-years-old').format(options);
 Result:
 'My name is John and I am 13-years-old'
 */
if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var option,
            regex,
            text = this;
        for (option in options) {
            regex = new RegExp('#{' + option + '}', 'gi');
            text = text.replace(regex, options[option]);
        }
        return text;
    }
}

var options = {name: 'John', age: 13};
console.log('My name is #{name} and I am #{age}-years-old'.format(options));
