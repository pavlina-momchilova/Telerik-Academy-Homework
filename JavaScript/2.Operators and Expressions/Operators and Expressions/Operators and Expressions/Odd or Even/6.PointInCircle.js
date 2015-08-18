/*Write an expression that checks if given point P(x, y) 
is within a circle K({0,0}, 5). //{0,0} is the centre and 5 
is the radius*/

var x = [0, -5, -4, 1.5, -4, 100, 0, 0.2, 0.9, 2];
var y = [1, 0, 5, -3, -3.5, -30, 0, -0.8, -4.93, 2.655];
var r = 5;

for (var i = 0; i < x.length; i++) {
    console.log((Math.pow((x[i] - 0), 2) + Math.pow((y[i] - 0), 2)) <= r * r);
}