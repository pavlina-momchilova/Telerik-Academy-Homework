/*Write a boolean expression that checks for given integer
  if it can be divided (without remainder) by 7 and 5 in the same 
  time.*/
var nums = [3, 0, 5, 7, 35, 140];
console.log('Divided by 7 and 5?');
for (var i = 0; i < nums.length; i++) {
    console.log((nums[i]%5===0 && nums[i]%7===0));
}