/*
Write a function that finds all the occurrences of word in a text.
The search can be case sensitive or case insensitive.
Use function overloading.
*/

var word = "page";
var text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.It is a long established fact that a reader will be distracted by the readable content of a Page when looking at its layout.";


function wordInText(text, word, isSensitive) {
	switch (arguments[2]) {
		case true:
			return sensitive();
			break;
		case false:
			return insensitive();
			break;
		default:
			console.log("Error. Sensitive or insensitive!");
			break;
	}
	function sensitive() {
		var counting = 0;
		var index = 0;
		var next = 0;
		while (text.indexOf(word, index) !== -1) {
			counting += 1;
			index = text.indexOf(word,next);
			if (index !== -1) {
				next = index+1;
			}
			else {
				break;
			}
		}
		return counting;
	}
	function insensitive() {
		var word1 = word.toUpperCase();
		var text1 = text.toUpperCase();
		var counting = 0;
		var index = 0;
		var next = 0;

		while (text1.indexOf(word1, index) !== -1) {
			counting += 1;
			index = text1.indexOf(word1, next);
			if (index !== -1) {
				next = index+1;
			}
			else {
				break;
			}
		}
		return counting;
	}


}

console.log(wordInText(text, word, true));
console.log(wordInText(text, word, false));