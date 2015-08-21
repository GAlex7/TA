/**
 * Write an expression that checks for given point
 * P(x, y) if it is within the circle K( (1,1), 3) and
 * out of the rectangle R(top=1, left=-1, width=6, height=2).
 */
var rect = [1, -1, -1, 5],
    circle = [1, 1, 3],
    point = [2, 2];

console.log('The point ' + (isInCircle(point[0], point[1], circle[0], circle[1], circle[2]) &&
isOutRect(point[0], point[1], rect[0], rect[1], rect[2], rect[3]) ? 'is' : 'is not') + ' in the circle AND out of rect.');

function isInCircle(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}

function isOutRect(x, y, top, bottom, left, right) {
    return !(x >= left && x <= right && y <= top && y >= bottom);
}