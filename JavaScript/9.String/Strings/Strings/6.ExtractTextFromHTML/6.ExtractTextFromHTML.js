/*
 Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags.
 */

var text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
function extract(text) {
    var result = '', len = text.length, index = 0;
    for (var i = 0; i < len; i+=1) {
        if (text[i] === '>' && text[i + 1] !== '<') {
            index = i + 1;
            while (text[index] !== '<' && index<len) {
                result += text[index];
                index += 1;
            }
            i = index;
        }
    }
    return result;
}
console.log('Result: '+extract(text));