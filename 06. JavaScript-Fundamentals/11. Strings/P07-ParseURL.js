/**
 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 Example:

 URL                                                        result
 http://telerikacademy.com/Courses/Courses/Details/239        {   protocol: http,
                                                                server: telerikacademy.com
                                                                resource: /Courses/Courses/Details/239
 */
var text = 'http://telerikacademy.com/Courses/Courses/Details/239';

console.log(parseURL(text));

function parseURL(str) {
    var i, j;
    i = str.indexOf('://');
    j = str.indexOf('/', i + 3);
    return {
        'protocol': str.substring(0, i),
        'server': str.substring(i + 3, j),
        'resource': str.substring(j)
    }
}
