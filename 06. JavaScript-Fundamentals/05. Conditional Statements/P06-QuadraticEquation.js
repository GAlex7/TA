/**
 * Write a script that reads the coefficients a, b and c of
 * a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 * Calculates and prints its real roots.
 * Note: Quadratic equations may have 0, 1 or 2 real roots.
 */

console.log(getRoots(-1, 3, 0));

function getRoots(a, b, c) {
    var D = b * b - 4 * a * c;

    if (D < 0) {
        return ('no real roots');
    } else if (!D) {
        return ('x1=x2=' + getRoot(-1, D, b, a));
    } else {
        return ('x1=' + getRoot(-1, D, b, a) + '; x2=' + getRoot(1, D, b, a));
    }
}

function getRoot(sign, D, b, a) {
    return (-b + Math.sqrt(D) * sign) / (2 * a);
}