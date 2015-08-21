/**
 * Write an expression that checks if given point P(x, y) is
 * within a circle K({0,0}, 5).
 * {0,0} is the centre and 5 is the radius
 */
var point = [3, 3.5];

console.log('Is the point P('+point[0]+', '+point[1]+') in circle K({0,0}, 5)? -> ' + isInside(point[0], point[1], 0, 0, 5));

function isInside(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}