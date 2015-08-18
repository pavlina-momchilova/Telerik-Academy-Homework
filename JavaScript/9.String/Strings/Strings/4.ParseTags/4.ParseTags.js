/*
 You are given a text. Write a function that changes the text in all regions:

<upcase>text</upcase> to uppercase.
<lowcase>text</lowcase> to lowercase
<mixcase>text</mixcase> to mix casing(random)
 */

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';
function mixcase(text) {
    var len = text.length;
    for (var i = 0; i < len; i+=1) {
        if ((i+(Math.random()*10|0))%2===0) {
            text = text.replace(text[i], text[i].toUpperCase());
        }
    }
    return text;
}

function parseTags(text) {
    var parsedText = '', arr = [],regex,arrLen,i,j=1;
    regex = /[<>]/g;
    arr = text.split(regex);
    arrLen = arr.length;
    for (i = 0; i <arrLen ; i+=1) {
        switch (arr[i]) {
            case 'mixcase':
                while (arr[i + j] !== '/mixcase') {
                    arr[i + j] = mixcase(arr[i + j]);
                    j++;
                };
                j = 1;
                break;
            case 'upcase':
                while (arr[i + j] !== '/upcase') {
                    arr[i + j] = arr[i + j].toUpperCase();
                    j++;
                };
                j = 1;
                break;
            case 'lowcase':
                while (arr[i + j] !== '/lowcase') {
                    arr[i + j] = arr[i + j].toLowerCase();
                    j++;
                };
                j = 1;
                break;
        }
    }
    for (var i = 0; i < arrLen; i+=1) {
        if (arr[i] !== 'mixcase' && arr[i] !== '/mixcase' && arr[i] !== 'upcase' && arr[i] !== '/upcase' && arr[i] !== 'lowcase' && arr[i] !== '/lowcase') {
            parsedText += arr[i] + ' ';
        }
    }
    return parsedText;
}
console.log(parseTags(text));