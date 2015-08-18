﻿/*Write a script that shows the sign (+, - or 0)
of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

var a = [5, -2, -2, 0, -1];
var b = [2, -2, 4, -2.5, -0.5];
var c = [2, 1, 3, 4, -5.1];

for (var i = 0; i < a.length; i++) {
	if (a[i]===0 || b[i]===0 || c[i]===0) {
		console.log('0');
	}
	else if (a[i] < 0 && b[i] > 0 && c[i] > 0) {
		console.log('-');
	}
	else if (a[i] > 0 && b[i] < 0 && c[i] > 0) {
		console.log('-');
	}
	else if (a[i] > 0 && b[i] > 0 && c[i] < 0) {
		console.log('-');
	}
	else if (a[i] < 0 && b[i] < 0 && c[i] < 0) {
		console.log('-');
	}
	else {
		console.log('+');
	}
}