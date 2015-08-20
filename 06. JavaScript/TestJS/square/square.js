var square = document.getElementById('square');
var x = 0;
var y = 0;
var speed = 2;
function moveSquare () {debugger;
	moveX ();
	moveY ();
	
	// movex = setInterval(function(){moveSquareX(-5);
	// 	if (x<=0) {
	// 		clearInterval(movex);
	// 	}
	// }, 1);
	// movey = setInterval(function(){moveSquareY(-5);
	// 	if (y<=0) {
	// 		clearInterval(movey);
	// 	}
	// }, 1);
}
function moveX () {
	if (x<700) {
		var movex = setInterval(function(){moveSquareX(speed);
			if (x>=700) {
				clearInterval(movex);
			}
		}, 1);
	}
}
function moveY () {
	if (x=700 && y<700) {
		var movey = setInterval(function(){moveSquareY(speed);
			if (y>=700) {
				clearInterval(movey);
			}
		}, 1);
	}
}
function moveSquareX (one) {
	x+=one
	square.style.left = x + 'px';
}
function moveSquareY (one) {
	y+=one
	square.style.top = y + 'px';
}
moveSquare();