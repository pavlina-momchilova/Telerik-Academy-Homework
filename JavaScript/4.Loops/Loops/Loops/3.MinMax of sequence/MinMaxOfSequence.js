var arrOfNums = [2, 2, 5, 6, 9, 8, 4, 23, 65, 55, 63, 3, 0, 12, 15];

var max = arrOfNums[0];
var min = arrOfNums[0];

for (var i = 1; i < arrOfNums.length; i++) {
    if (arrOfNums[i] < min) {
        min = arrOfNums[i];
    }
    if (arrOfNums[i] > max) {
        max = arrOfNums[i];
    }
}
console.log('max num is: ' + max);
console.log('min num is: ' + min);
