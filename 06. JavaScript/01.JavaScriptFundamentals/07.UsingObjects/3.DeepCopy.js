function deepCopy(obj) {
    if (obj === null || typeof obj != 'object') {
        return obj;
    }
    if (obj instanceof Array) {
        var arrayCopy = [];
        for (var i = 0; i < obj.length; i++) {
            arrayCopy[i] = deepCopy(obj[i]);
        }
        return arrayCopy;
    }
    if (obj instanceof Object) {
        var objectCopy = {};
        for (var attribute in obj) {
            objectCopy[attribute] = deepCopy(obj[attribute]);
        }
        return objectCopy;
    }
}


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

//
debugger;
//creating a new object of type Line
var line1 = new Line(new Point(0, 0), new Point(0, 3));
// making a deep copy of the instance of the Line object type
var linecopy = deepCopy(line1);

console.log('printing the starting values of both the Line and the copy');
console.dir(line1);
console.dir(linecopy);
console.log(line1.length());
console.log(linecopy.length());
line1.pointA.x = 45;
line1.pointA.y = 9;
line1.pointB.x = 9;
line1.pointB.y = 12;
console.log('modified the original, the copy stays the same');
console.dir(line1);
console.dir(linecopy);
console.log(line1.length());
console.log(linecopy.length());
linecopy.pointA.x = 6;
linecopy.pointA.y = 7;
linecopy.pointB.x = 8;
linecopy.pointB.y = 22;
console.log('modified the copy, the original stays the same');
console.dir(line1);
console.dir(linecopy);
console.log(line1.length());
console.log(linecopy.length());

// COPY ALL THE CODE AND PASTE IT IN THE BROWSER CONSOLE.
