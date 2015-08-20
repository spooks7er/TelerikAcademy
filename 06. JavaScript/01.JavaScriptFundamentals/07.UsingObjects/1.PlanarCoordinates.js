// function createPoint(px, py) {
//     return{
//         x: px,
//         y: py,
//         ppp: function() {
//             return this.x + this.y;
//         }
//     };
// }
function distanceBetweenPoints(p1, p2) {
    return Math.sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
}

function Point(x, y) {
    this.x = x || 0;
    this.y = y || 0;
    this.distance = function(point) {
        return Math.sqrt((this.x - point.x) * (this.x - point.x) + (this.y - point.y) * (this.y - point.y));
    };
}

function Line(pointA, pointB) {
    this.pointA = pointA || new Point(0, 0);
    this.pointB = pointB || new Point(0, 0);
    this.length = function() {
        return this.pointA.distance(this.pointB);
    };
    this.canFormTriangle = function(line2, line3) {
        if ((this.length + line2.length > line3.length) && (line2.length + line3.length > this.length) && (this.length + line3.length > line2.length)) {
            return true;
        }
        return false;
    };
}

var line1 = new Line(new Point(0, 0), new Point(0, 3));
var line2 = new Line(new Point(1, 0), new Point(1, 5));
var line3 = new Line(new Point(2, 0), new Point(2, 7));

console.log(line1.length());
console.log(line2.length());
console.log(line3.length());
console.log(line1.canFormTriangle(line2, line3));

// COPY ALL THE CODE AND PASTE IT IN THE BROWSER CONSOLE.