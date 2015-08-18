/*Write an if statement that takes two double variables a
and b and exchanges their values if the first one is greater 
than the second.
As a result print the values a and b, separated by a space.*/
var a = [5, 3, 5.5];
var b = [2, 4, 4.5];
var temp = 0;
for (var i = 0; i < a.length; i++) {
	if (a[i] > b[i]) {
		temp = a[i];
		a[i] = b[i];
		b[i] = temp;
	}
	console.log(a[i] + ' ' + b[i]);
}