/**
 * Write a script that shows the sign (+, - or 0) of the product of
 * three real numbers, without calculating it.
 * Use a sequence of if operators.
 */
var numbers = [5, 2, 2];

console.log(numbers + ' -> ' + getSign(numbers));

function getSign(numbers) {
    var negativeCount = 0,
        i;

    for (i = 0; i < numbers.length; i += 1) {
        if (numbers[i]) {
            if (numbers[i] * -1 > numbers[i]) {
                negativeCount += 1;
            }
        } else {
            return 0;
        }
    }
    return (negativeCount % 2) ? '-' : '+';
}