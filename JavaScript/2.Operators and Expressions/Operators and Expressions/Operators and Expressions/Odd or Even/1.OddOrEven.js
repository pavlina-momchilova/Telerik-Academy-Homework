/*Write an expression that checks if given integer is odd or even.*/
var numbers = [3, 2, -2, -1, 0];
console.log('Odd?');
for (var i = 0; i < numbers.length; i++) {
    console.log(numbers[i] % 2 !== 0);
}