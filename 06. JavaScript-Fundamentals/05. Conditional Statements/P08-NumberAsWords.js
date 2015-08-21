/**
 * Write a script that converts a number in the range [0…999] to words,
 * corresponding to its English pronunciation.
 */
console.log(numbAsWords(-999));

function numbAsWords(number) {
    var words = '',
        unitsMap = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
        tensMap = ['zero', 'ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
    if (number === 0)
        return 'zero';
    if (number < 0)
        return 'minus ' + numbAsWords(number * -1);
    if ((Math.floor(number / 100)) > 0) {
        words += numbAsWords(Math.floor(number / 100)) + ' hundred ';
        number = Math.floor(number % 100);
    }
    if (number > 0) {
        if (words !== '')
            words += 'and ';
        if (number < 20) {
            words += unitsMap[number];
        } else {
            words += tensMap[Math.floor(number / 10)];
            if ((Math.floor(number % 10)) > 0)
                words += ' ' + unitsMap[Math.floor(number % 10)];
        }
    }
    return words;
}