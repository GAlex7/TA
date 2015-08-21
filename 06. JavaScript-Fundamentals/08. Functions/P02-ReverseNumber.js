/**
 * Write a function that reverses the digits of given decimal number.
 */
var n = 123.45;

console.log(revDigit(n));

function revDigit(numb) {
    var numbAsCharArr = [],
        str, i, len, sign = '';
    if (numb < 0) {
        sign = '-';
        numb *= -1;
    }
    str = numb.toString();
    for (i = 0, len = str.length; i < len; i += 1) {
        numbAsCharArr.push(str[i]);
    }
    numbAsCharArr.reverse();
    return +(sign + numbAsCharArr.join(''));
}
