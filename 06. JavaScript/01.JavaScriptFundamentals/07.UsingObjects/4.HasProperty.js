// function hasProperty(obj, propname) {
//     for (var attribute in obj) {
//         if (attribute === propname) {
//             return true;
//         }
//     }
//     return false;
// }

Object.prototype.hasProperty = function(propname) {
    for (var attribute in this) {
        if (attribute === propname) {
            return true;
        }
    }
    return false;
};


// objects used from previous exersize
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

// console.log(hasProperty(line1.pointA, 'distance'));

console.log(line1.pointA.hasProperty('distance'));