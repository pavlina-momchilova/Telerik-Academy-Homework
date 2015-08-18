/*
 * Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */
var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
function replace(text) {
    var pattern = /\s/g;
    text=text.replace(pattern, '&nbsp;');
    return text;
}
console.log(replace(text));
