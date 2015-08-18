/*
 * Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 */

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var target = 'in';

function contains(text1, target1) {
    var text=text1.toLowerCase(), target=target1.toLowerCase(), index = 0, len = text.length, count = 0, next=0;
    for (var i = 0; i < len; i += 1) {

        if (text.indexOf(target, index) !== -1) {
            next = text.indexOf(target, index);
            index = next + 1;
            count += 1;
        }
        else {
            break;
        }
    }
    return count;
}

console.log('The result is: '+contains(text,target));