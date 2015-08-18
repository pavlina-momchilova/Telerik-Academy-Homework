/*Write a script that reads the coefficients a, b and c
of a quadratic equation ax2 + bx + c = 0 and solves it
(prints its real roots).
Calculates and prints its real roots.*/
function roots(){
	var a = document.getElementById('a').value;
	var b = document.getElementById('b').value;
	var c = document.getElementById('c').value;
	var x1=0;
	var x2=0;
	var root=0;

	var discriminant = b * b - 4 * a * c;
	if(discriminant>0){
		x1=(-b+Math.sqrt(discriminant))/(2*a);
	    x2=(-b-Math.sqrt(discriminant))/(2*a);
		root='x1='+x1+'; x2='+x2;
	}
	else if(discriminant===0){
		x1=(-b)/(2*a);
		root='x1=x2='+x1;
	}
	else{
		root='no real roots';
	}
	document.getElementById('roots').innerHTML = root;
	console.log(root);
}