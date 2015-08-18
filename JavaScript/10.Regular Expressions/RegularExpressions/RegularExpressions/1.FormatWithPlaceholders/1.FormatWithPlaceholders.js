/*
 Write a function that formats a string. The function should have placeholders, as shown in the example
Add the function to the String.prototype
 */

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var prop, i, result=this, regex;
        for (prop in options) {
            regex = new RegExp('#\{' + prop + '\}','g');
            result = result.replace(regex, options[prop]);
        }
        return result;
    }
}
console.log('First Example:');
console.log(' ');
var options = { name: 'John', age: 13 };
var str = 'My name is #{name} and I am #{age}-years-old'
console.log(str.format(options));
console.log(' ');
console.log('Second Example:');
console.log(' ');
var options2 = { name: 'John' };
var str2 = 'Hello, there! Are you #{name}?';
console.log(str2.format(options2));

