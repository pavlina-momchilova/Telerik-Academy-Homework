/*
 * Write a JavaScript function that reverses a string and returns it.
 */
var str = 'sample';

function reverse(str) {
    var len = str.length, reversedStr='', i;
    for (i = len-1; i >=0 ; i-=1) {
        reversedStr += str[i];
    }
    return reversedStr;
}

console.log(reverse(str));