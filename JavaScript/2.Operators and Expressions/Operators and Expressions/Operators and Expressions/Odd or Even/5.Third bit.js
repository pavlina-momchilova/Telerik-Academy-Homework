/*Write a boolean expression for finding if the bit #3
(counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/
var n = [5, 8, 0, 15, 5343, 62241];
var mask = 1 << 3;
console.log(mask);
for (var i = 0; i < n.length; i++) {
    console.log(((n[i] & mask)===8)?'1':'0');
}