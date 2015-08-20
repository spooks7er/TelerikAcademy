Array.prototype.remove = function (element) {
	var pos = this.indexOf(element);
    while (pos !== -1) {
    	this.splice(pos,1);
        pos = this.indexOf(element);
    }
};
var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
console.log(arr);
arr.remove(1);
console.log(arr);


// COPY ALL THE CODE AND PASTE IT IN THE BROWSER CONSOLE.