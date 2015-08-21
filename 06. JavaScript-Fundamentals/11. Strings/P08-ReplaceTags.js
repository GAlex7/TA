/**
 Write a JavaScript function that replaces in a HTML document
 given as string all the tags <a href="…">…</a> with
 corresponding tags [URL=…]…/URL].
 */
var text='<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(replaceTag(text));

function replaceTag(str){
    str=str.replace(/<a href="/g,'[URL=');
    str=str.replace(/">/g,']');
    return str.replace(/<\/a>/g,'[/URL]');
}