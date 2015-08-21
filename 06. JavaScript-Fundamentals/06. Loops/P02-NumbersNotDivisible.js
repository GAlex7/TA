/**
 * Write a script that prints all the numbers from 1 to N,
 * that are not divisible by 3 and 7 at the same time
 */
var n = 50,
    i,
    result = '';
for (i = 1; i <= n; i += 1) {
    if (!(!(i % 3) && !(i % 7))) { /* ((i % 3) && (i % 7)) ??? ?????? ?? ?? ?? ????? ?? 3 ??? ?? 7 */
        result += i + ' ';
    }
}
console.log(result);