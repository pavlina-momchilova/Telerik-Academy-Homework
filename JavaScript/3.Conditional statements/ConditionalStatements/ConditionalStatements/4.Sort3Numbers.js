/*Sort 3 real values in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/

var a = [5, -2, -2, 0, -1.1, 10, 1];
var b = [1, -2, 4, -2.5, -0.5, 20, 1];
var c = [2, 1, 3, 5, -0.1, 30, 1];

for (var i = 0; i < a.length; i++) {
    if (a[i] > b[i]) {
        if (a[i] > c[i]) {
            if (c[i] < b[i]) {
                console.log(a[i]+' '+b[i]+' '+c[i]);
            }
            else {
                console.log(a[i] + ' ' + c[i] + ' ' + b[i]);
            }
        }
        else {
            console.log(c[i] + ' ' + a[i] + ' ' + b[i]);
        }
    }
    else {
        if (b[i] > c[i]) {
            if (a[i] < c[i]) {
                console.log(b[i] + ' ' + c[i] + ' ' + a[i]);
            }
            else {
                console.log(b[i] + ' ' + a[i] + ' ' + c[i]);
            }
        }
        else {
            console.log(c[i] + ' ' + b[i] + ' ' + a[i]);
        }
    }
}