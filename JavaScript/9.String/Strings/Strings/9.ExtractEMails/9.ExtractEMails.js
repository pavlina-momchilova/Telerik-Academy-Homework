/*
 *Write a function for extracting all email addresses from given text.
All sub-strings that match the format @… should be recognized as emails.
Return the emails as array of strings. 
 */

var text = 'In this text must have emails like this pesho@abv.bg or something like gosho56@gmail.com or maybe something like druj34Ab@yahoo.com and so on!';

function extractEmails(text) {
    var result = [], arr = [], len, i, regex;
    regex = /[A-z0-9._]+@[A-z0-9]+.[A-z0-9]+/g;
    arr = text.split(' ');
    len = arr.length;
    for (i = 0; i < len; i++) {
        if (regex.test(arr[i])) {
            result.push(arr[i]);
        }
    }

    return result;
}

console.log('The Emails from the text are: '+extractEmails(text));