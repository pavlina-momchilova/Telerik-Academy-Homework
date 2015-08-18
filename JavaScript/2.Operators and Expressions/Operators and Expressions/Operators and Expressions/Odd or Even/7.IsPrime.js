/*
Write an expression that checks if
given positive integer number n (n ≤ 100) is prime.
*/
var n = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];
var flag=true;
for (var i = 0; i < n.length; i++) {
	flag = true;
	if (n[i] <= 0) {
		flag = false;
	}
	else if (n[i] === 1) {
		flag = false;
	}
	else if (n[i] === 2) {
		flag = true;
	}
	else {
		for (var j = 2; j <= Math.sqrt(n[i]) ; j++) {
			if ((n[i] % j )=== 0) {
				flag = false;
				break;
			}
		}
	}
	console.log(flag);
}