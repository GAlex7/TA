/**
 * Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 */
var numb=9703;

console.log(isThirdDigit7(numb));

function isThirdDigit7(numb){
    return Math.floor(numb / 100) % 10 === 7;
}