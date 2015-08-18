/*
 * Write a function that formats a string using placeholders.
    The function should work with up to 30 placeholders and all types.
 */

var str = stringFormat('Hello {0}!', 'Peter');
console.log('Example with 1 placeholders');
console.log(str);
console.log(' ');
var frmt = '{0}, {1}, {0} text {2}';
var str1 = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log('Example with 3 placeholders');
console.log(str1);
console.log(' ');
str = '';
for (i = 0; i < 30; i += 1) {
    str += 'Text : {' + i + '} \n';
}
console.log('Example with 30 placeholders');
console.log(stringFormat(str, 1, 'o', null, NaN, undefined, {}, typeof [], [], 'a', 0, 9, 8, 7, 6, 5, 4, 3, 2, 'must to be 30 things ala bala', 2,
    '222', 123.23, 1, 2, 3, 4, 5, 6, 7, 8));

function stringFormat(str) {
    var i, len = str.length;
    for (i = 0; i < len; i += 1) {
        if (str[i] === '{') {
            switch (str[i + 1]) {
                case '0': str = str.replace('{0}', arguments[1]);
                    len = str.length;
                    break;
                case '1': if (str[i + 2] === '}') {
                    str = str.replace('{1}', arguments[2]);
                    len = str.length;
                }
                else {
                    switch (str[i + 2]) {
                        case '0': str = str.replace('{10}', arguments[11]);
                            len = str.length;
                            break;
                        case '1': str = str.replace('{11}', arguments[12]);
                            len = str.length;
                            break;
                        case '2': str = str.replace('{12}', arguments[13]);
                            len = str.length;
                            break;
                        case '3': str = str.replace('{13}', arguments[14]);
                            len = str.length;
                            break;
                        case '4': str = str.replace('{14}', arguments[15]);
                            len = str.length;
                            break;
                        case '5': str = str.replace('{15}', arguments[16]);
                            len = str.length;
                            break;
                        case '6': str = str.replace('{16}', arguments[17]);
                            len = str.length;
                            break;
                        case '7': str = str.replace('{17}', arguments[18]);
                            len = str.length;
                            break;
                        case '8': str = str.replace('{18}', arguments[19]);
                            len = str.length;
                            break;
                        case '9': str = str.replace('{19}', arguments[20]);
                            len = str.length;
                            break;
                    }
                }
                    break;
                case '2': if (str[i + 2] === '}') {
                    str = str.replace('{2}', arguments[3]);
                    len = str.length;
                }
                else {
                    switch (str[i + 2]) {
                        case '0': str = str.replace('{20}', arguments[21]);
                            len = str.length;
                            break;
                        case '1': str = str.replace('{21}', arguments[22]);
                            len = str.length;
                            break;
                        case '2': str = str.replace('{22}', arguments[23]);
                            len = str.length;
                            break;
                        case '3': str = str.replace('{23}', arguments[24]);
                            len = str.length;
                            break;
                        case '4': str = str.replace('{24}', arguments[25]);
                            len = str.length;
                            break;
                        case '5': str = str.replace('{25}', arguments[26]);
                            len = str.length;
                            break;
                        case '6': str = str.replace('{26}', arguments[27]);
                            len = str.length;
                            break;
                        case '7': str = str.replace('{27}', arguments[28]);
                            len = str.length;
                            break;
                        case '8': str = str.replace('{28}', arguments[29]);
                            len = str.length;
                            break;
                        case '9': str = str.replace('{29}', arguments[30]);
                            len = str.length;
                            break;
                    }
                }
                    break;
                case '3': if (str[i + 2] === '}') {
                    str = str.replace('{3}', arguments[4]);
                    len = str.length;
                }
                else {
                    str = str.replace('{30}', arguments[31]);
                    len = str.length;
                }
                    break;
                case '4': str = str.replace('{4}', arguments[5]);
                    len = str.length;
                    break;
                case '5': str = str.replace('{5}', arguments[6]);
                    len = str.length;
                    break;
                case '6': str = str.replace('{6}', arguments[7]);
                    len = str.length;
                    break;
                case '7': str = str.replace('{7}', arguments[8]);
                    len = str.length;
                    break;
                case '8': str = str.replace('{8}', arguments[9]);
                    len = str.length;
                    break;
                case '9': str = str.replace('{9}', arguments[10]);
                    len = str.length;
                    break;
                default: i += 1;
                    break;
            }

        }
    }

    return str;
}