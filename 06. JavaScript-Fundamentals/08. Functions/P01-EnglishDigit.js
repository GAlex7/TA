/**
 * Write a function that returns the last digit of given integer as an English word.
 */
console.log(getLastDigitAsWord(512));
console.log(getLastDigitAsWord(1024));
console.log(getLastDigitAsWord(12309));

function getLastDigitAsWord(numb){
    switch (Math.floor(numb % 10)){
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default: return 'invalid number';
    }
}