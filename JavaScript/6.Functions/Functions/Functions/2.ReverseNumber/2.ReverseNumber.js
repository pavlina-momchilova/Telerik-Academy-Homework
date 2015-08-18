/*Write a function that reverses the digits of given decimal number.*/
function reverse(number) {
    var  temp = '', i, reversedNum='';
    number = number || 0;
    temp += number;
    for (var i = temp.length-1; i >= 0; i -= 1) {
        reversedNum += temp[i];
    }
    return reversedNum;
}

console.log(reverse(256));
console.log(reverse(123.45));