/**
 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 Example:

 <html>
 <head>
 <title>Sample site</title>
 </head>
 <body>
 <div>text
 <div>more text</div>
 and more...
 </div>
 in body
 </body>
 </html>
 */
var text = '<html> <head> <title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body> </html>';

console.log(removeTags(text));

function removeTags(str) {
    return str.replace(/<[A-z/]+>/g, '');
}
