/*
 * Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */
var text = 'ABBA lamal exe Write a function that extracts the content of a htmlmth page given as text The function should return anything that isi in a tag without the tags'

function reverseString(str) {
    var len = str.length, i, reversedStr = '';
    for (i = len - 1; i >= 0 ; i -= 1) {
        reversedStr += str[i];
    }
    return reversedStr;
}

function palindromes(text) {
    var i, j, k, arrOfWords = [], len , result = [];
    arrOfWords = text.split(' ');
    len = arrOfWords.length;

    for (i = 0; i < len; i += 1) {
        if (arrOfWords[i].length !== 1) {
            var lengthOfword = arrOfWords[i].length;
            if (lengthOfword % 2 === 0) {
                var firstSide = '', secondSide = '';
                for (j = 0; j < lengthOfword/2; j += 1) {
                    firstSide += (arrOfWords[i])[j];
                }
                for (k = lengthOfword/2; k < lengthOfword; k+=1) {
                    secondSide += ((arrOfWords[i])[k]);
                }
                secondSide = reverseString(secondSide);
                if (secondSide === firstSide) {
                    result.push(arrOfWords[i]);
                }
            }
            else {
                var firstSide = '', secondSide = '';
                for (j = 0; j < Math.floor(lengthOfword / 2); j += 1) {
                    firstSide += (arrOfWords[i])[j];
                }
                for (k = Math.floor(lengthOfword / 2)+1; k < lengthOfword; k += 1) {
                    secondSide += ((arrOfWords[i])[k]);
                }
                secondSide = reverseString(secondSide);
                if (secondSide === firstSide) {
                    result.push(arrOfWords[i]);
                }
            }

        }
    }
    return result;
}

console.log('The palindromes words are: '+palindromes(text).join(', '));