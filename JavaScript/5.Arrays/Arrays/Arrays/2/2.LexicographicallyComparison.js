/*Write a script that compares two char
arrays lexicographically (letter by letter).*/
var arr1 = ['a', 's', 'j', 'k', 'o', 'h'], arr2 = ['f', 'a', 'l', 'w', 'z', 'h'],
	len1 = arr1.length, len2 = arr2.length,i;

if (len1 === len2) {
	console.log('The arrays are with the same length!');
	for (i = 0; i < len1; i++) {
		if (arr1[i] > arr2[i]) {
			console.log('arr1[' + i + '] is after than arr2[' + i + ']');
		}
		else if (arr1[i] < arr2[i]) {
			console.log('arr1[' + i + '] is before than arr2[' + i + ']');
		}
		else {
			console.log('arr1[' + i + '] is equal to arr2[' + i + ']');
		}
	}
}
else {
	console.log('The arrays are with different length and cannot be compared!');
}