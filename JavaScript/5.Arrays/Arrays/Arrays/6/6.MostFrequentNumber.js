/*Write a script that finds the most frequent
number in an array.
*/
var i, j, countFreq, num, countMax = 0, tempNum, arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3], len = arr.length;

for (i = 0; i < len; i++) {
	countFreq = 0;
	tempNum = arr[i];
	for (j = 0; j < len; j++) {
		if (arr[j] === tempNum) {
			countFreq += 1;
			if (countMax < countFreq) {
				countMax = countFreq;
			}
		}
	}
	if (countFreq === countMax) {
		num = tempNum;
	}
}
if (countMax === 1) {
	console.log(num + '(' + countMax + ' time)');
}
else {
	console.log(num + '(' + countMax + ' times)');
}
