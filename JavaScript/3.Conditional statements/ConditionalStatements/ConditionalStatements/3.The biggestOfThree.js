/*
Write a script that finds the biggest of three numbers.
Use nested if statements.
*/
var a = [5, -2, -2, 0, -0.1];
var b = [2, -2, 4, -2.5, -0.5];
var c = [2, 1, 3, 5, -1.1];

var max = 0;

for (var i = 0; i < a.length; i++) {
	if (a[i] > b[i]) {
		max = a[i];
		if (a[i] < c[i]) {
			max = c[i];
		}
	}
	else {
		max = b[i];
		if (b[i] < c[i]) {
			max = c[i];
		}
	}
	console.log(max);
}