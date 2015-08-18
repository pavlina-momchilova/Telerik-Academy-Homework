/*
 * Write a JavaScript function to check if in a given expression the brackets are put correctly.
 */
var str1 = '((a+b)/5-d)';
var str2 = ')(a+b))';
var str3 = '(a+b(a+b)a+b))a+b)((a+b';
function correctBreckets(str) {
    var flag = true, len=str.length,countOpen=0,countClose=0,i,j;
    for (i = 0; i < len; i+=1) {
        if(str[i]==='('){
            countOpen+=1;
        }
        if(str[i]===')'){
            countClose+=1;
        }
        if (countClose > countOpen) {
            flag = false;
        }
    }
    return flag;
}

console.log(correctBreckets(str1) ? 'The breckets are correct' : 'The breckets are incorrect');;
console.log(correctBreckets(str2) ? 'The breckets are correct' : 'The breckets are incorrect');;
console.log(correctBreckets(str3) ? 'The breckets are correct' : 'The breckets are incorrect');;
