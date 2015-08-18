/*Write a function to count the number of div elements on the web page*/
 
function numOfDivs() {
	var divs = document.getElementsByTagName("div");
	console.log('The num of divs is : '+divs.length);
}
numOfDivs();