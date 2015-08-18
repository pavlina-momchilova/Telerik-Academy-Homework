/*Write a script that finds the greatest of given 5 variables.
Use nested if statements.*/
var a = [5, -2, -2, 0, -3];
var b = [2, -22, 4, -2.5, -0.5];
var c = [2, 1, 3, 0, -1.1];
var d = [4, 0, 2, 5, -2];
var e = [1, 0, 0, 5, -0.1];

var max = 0;
var maxOfThree = 0;
var maxOfTwo = 0;

for (var i = 0; i < a.length; i++) {
    max = 0;
    maxOfTwo = 0;
    maxOfThree = 0;
    if (a[i] > b[i]) {
        maxOfTwo = a[i];
    }
    else {
        maxOfTwo = b[i];
    }
    if (c[i] > d[i]) {
        maxOfThree = c[i];
        if (c[i] < e[i]) {
            maxOfThree = e[i];
        }
    }
    else {
        maxOfThree = d[i];
        if (d[i] < e[i]) {
            maxOfThree = e[i];
        }
    }
    if (maxOfTwo > maxOfThree) {
        max = maxOfTwo;
    }
    else {
        max = maxOfThree;
    }
    console.log(max);
}