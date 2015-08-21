/**
 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
 */
var text = "We are <mixcase>living</mixcase> in a <upcase>fucking <miXcase>yellow submarine</miXcase></upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

console.log(changeText(text));

function changeText(str) {
    var startTagPos,
        endTagPos,
        tagName,
        i, len, j, k,
        textToChange = '',
        changedText = '';
    startTagPos = str.indexOf('<');

    while (startTagPos !== -1) {
        endTagPos = str.indexOf('>');
        tagName = str.substring(startTagPos + 1, endTagPos).toLowerCase();
        i = str.toLowerCase().indexOf('</' + tagName + '>');
        len = tagName.length + 3;
        textToChange = str.substring(endTagPos + 1, i);

        switch (tagName) {
            case 'upcase':
                changedText = textToChange.toUpperCase();
                break;
            case 'lowcase':
                changedText = textToChange.toLowerCase();
                break;
            case 'mixcase':
                for (j = 0, k = textToChange.length; j < k; j += 1) {
                    if (Math.floor(Math.random() + 0.5)) {
                        changedText += textToChange[j].toUpperCase();
                    } else {
                        changedText += textToChange[j].toLowerCase();
                    }
                }
                break;
        }

        str = str.substring(0, startTagPos) + changedText + str.substring(i + len);
        startTagPos = str.indexOf('<');
        changedText='';
    }
    return str;
}