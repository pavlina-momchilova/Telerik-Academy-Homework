/*Write an expression that checks for
  given integer if its third digit (right-to-left) is 7.*/

var nums = [5, 701, 1732, 9703, 877, 777877, 9999799];
console.log('Third digit 7?');
for (var i = 0; i < nums.length; i++) {
console.log(Math.floor((nums[i] / 100)%10)===7);
}