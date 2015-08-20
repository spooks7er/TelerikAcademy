var number,
	check,
	result,
	sideA,
	sideB,
	area,
	thirdDig,
	binary,
	thirdBitb,
	point, mult, rad, cart0, circle, rectangle, rectTop, rectLeft, rectW, rectH,
oX, oY, pX, pY, r, rectTop, rectLeft;
//
function pad(n, width, z) {
		z = z || '0';
		n = n + '';
		return n.length >= width ? n : new Array(width - n.length + 1).join(z) + n;
	}
	//1
function oddEven() {
		number = document.getElementById('oddEvenTb').value;
		result = document.getElementById('oddEvenLbl');
		check = number % 2 == 0;
		if (check) {
			result.style.color = 'green';
		} else {
			result.style.color = 'red';
		}
		result.innerHTML = check;
	}
	//
	//2
function fiveSeven() {
		number = document.getElementById('fiveSevenTb').value;
		result = document.getElementById('fiveSevenLbl');
		check = number % 5 == 0 && number % 7 == 0;
		if (check) {
			result.style.color = 'green';
		} else {
			result.style.color = 'red';
		}
		result.innerHTML = check;
	}
	//
	//3
function rectArea() {
		sideA = document.getElementById('sideA').value;
		sideB = document.getElementById('sideB').value;
		area = sideA * sideB;
		result = document.getElementById('rectAreaLbl');
		result.innerHTML = area;
		result.style.color = 'black';

		rectangle = document.getElementById('rectangle');
		rectangle.style.width = sideA + 'px';
		rectangle.style.height = sideB + 'px';
		rectangle.style.border = '1px solid black';
		rectangle.style.display = 'inline-block';
	}
	//
	//4
function thirdDigit() {
		number = document.getElementById('thirdDigitTb').value;
		result = document.getElementById('thirdDigitLbl');
		thirdDig = ((number % 10) / 1) | 0;
		check = thirdDig == 7;
		if (check) {
			result.style.color = 'green';
		} else {
			result.style.color = 'red';
		}
		result.innerHTML = check + ' ' + thirdDig;
	}
	//
	//5
var l, bit, index;

function thirdBit() {
		number = document.getElementById('thirdBitTb').value;
		result = document.getElementById('binaryLbl');
		binary = (number >> 0).toString(2);
		binary = pad(binary, 32);
		result.style.color = 'black';
		l = binary.length;
		index = l - 1 - 3;
		thirdBitb = binary[index];
		binary = binary.substring(0, index) +
			'<span id="thirdbit">' + binary.substring(index, index + 1) + '</span>' + binary.substring(index + 1);
		result.innerHTML = binary;
		// bit = document.getElementById('thirdBitLbl');
		// bit.innerHTML = thirdBitb;
		// bit.style.color = 'black';
	}
	//
	//6
function pointInCircle() {
	pX = document.getElementById('pointInCircleX').value * 1;
	pY = document.getElementById('pointInCircleY').value * 1;
	oX = document.getElementById('circ1X').value * 1;
	oY = document.getElementById('circ1Y').value * 1;
	r = document.getElementById('circ1R').value * 1;
	result = document.getElementById('pointInCircleLbl');

	check = (((pX - oX) * (pX - oX)) + ((pY - oY) * (pY - oY))) <= (r * r);

	if (check) {
		result.style.color = 'green';
	} else {
		result.style.color = 'red';
	}
	result.innerHTML = check;
	drawFigureCirclePoint(pX, pY, oX, oY, r);
}

function drawFigureCirclePoint(pX, pY, oX, oY, r) {
		mult = 50;
		cart0 = 350
		rad = r * mult;
		circle = document.getElementById('circ1');
		point = document.getElementById('p1');

		circle.style.width = (rad*2)+'px';
		circle.style.height = (rad*2)+'px';

		circle.style.left = (cart0 + oX * mult - rad) + 'px';
		circle.style.top = (cart0 - oY * mult - rad) + 'px';

		point.style.left = (cart0 + pX * mult - 3) + 'px';
		point.style.top = (cart0 - pY * mult - 3) + 'px';
	}
	//
	//7
function IsPrime() {
		number = document.getElementById('IsPrimeTb').value;
		result = document.getElementById('IsPrimeLbl');
		check = checkForPrime(number);
		if (check) {
			result.style.color = 'green';
		} else {
			result.style.color = 'red';
		}
		result.innerHTML = check;
	} //
function checkForPrime(number) {
		if (number <= 1) {
			return false;
		}
		var boundary = Math.floor(Math.sqrt(number));
		for (var i = 2; i <= boundary; i += 1) {
			if (number % i == 0) {
				return false;
			}
		}
		return true;
	}
	//
	//8
function trapezoidAr() {
		sideA = document.getElementById('trsideA').value * 1;
		sideB = document.getElementById('trsideB').value * 1;
		height = document.getElementById('trheight').value * 1;
		area = ((sideA + sideB) / 2) * height;
		result = document.getElementById('trapezoidArLbl');
		result.innerHTML = area;
		result.style.color = 'black';

		var trapezoid = document.getElementById('trapezoid');
		trapezoid.style.display = 'inline-block';
		trapezoid.style.height = '0px'
		var borders;

		if (sideB >= sideA) {
			trapezoid.style.width = sideA + 'px';
			borders = (sideB - sideA) / 2;
			trapezoid.style.borderLeft = borders + 'px solid transparent';
			trapezoid.style.borderRight = borders + 'px solid transparent';
			trapezoid.style.borderTop = 0;
			trapezoid.style.borderBottom = height + 'px solid black';

		} else if (sideA > sideB) {
			trapezoid.style.width = sideB + 'px';
			borders = (sideA - sideB) / 2;
			trapezoid.style.borderLeft = borders + 'px solid transparent';
			trapezoid.style.borderRight = borders + 'px solid transparent';
			trapezoid.style.borderTop = height + 'px solid black';
			trapezoid.style.borderBottom = 0;
		}
	}
	//
	//9
function pointInCircleRect() {
	pX = document.getElementById('pointInCircleRectX').value * 1;
	pY = document.getElementById('pointInCircleRectY').value * 1;
	oX = document.getElementById('circ2X').value * 1;
	oY = document.getElementById('circ2Y').value * 1;
	r = document.getElementById('circ2R').value * 1;
	rectTop = document.getElementById('rectTop').value * 1;
	rectLeft = document.getElementById('rectLeft').value * 1;
	rectW = document.getElementById('rectW').value * 1;
	rectH = document.getElementById('recth').value * 1;

	result = document.getElementById('pointInCircleRectLbl');

	check = (((pX - oX) * (pX - oX)) + ((pY - oY) * (pY - oY))) <= (r * r) && (pX > (rectW + rectLeft) || pX < rectLeft || pY < rectTop - rectH || pY > rectTop);

	if (check) {
		result.style.color = 'green';
	} else {
		result.style.color = 'red';
	}
	result.innerHTML = check;
	drawFigureCircleRectPoint(pX, pY, oX, oY, r, rectTop, rectLeft, rectW, rectH);
}

function drawFigureCircleRectPoint(pX, pY, oX, oY, r, rectTop, rectLeft, rectW, rectH) {
		mult = 50;
		cart0 = 350
		rad = r * mult;
		circle = document.getElementById('circ2');
		rectangle = document.getElementById('rect');
		point = document.getElementById('p2');
		circle.style.width = (rad * 2) + 'px';
		circle.style.height = (rad * 2) + 'px';

		circle.style.left = (cart0 + oX * mult - rad) + 'px';
		circle.style.top = (cart0 - oY * mult - rad) + 'px';

		rectangle.style.width = (mult * rectW) + 'px';
		rectangle.style.height = (mult * rectH) + 'px';
		rectangle.style.left = (cart0 + rectLeft * mult) + 'px';
		rectangle.style.top = (cart0 - rectTop * mult) + 'px';

		point.style.left = (cart0 + pX * mult - 3) + 'px';
		point.style.top = (cart0 - pY * mult - 3) + 'px';
	}
	//