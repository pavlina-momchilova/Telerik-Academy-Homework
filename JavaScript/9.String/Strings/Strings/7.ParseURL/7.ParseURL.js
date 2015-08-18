/*
 * Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.
 */

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';
var url1 = 'https://github.com/TelerikAcademy/JavaScript-Fundamentals/blob/master/11.%20Strings/README.md';
function parseURL(url) {
    var result = {}, i, len = url.length, portocol1 = '', server1 = '', resource1 = '';
    for (i = 0; i < len; i += 1) {
        while (url[i] !== ':' && i !== len) {
            portocol1 += url[i];
            i++;
        }
        i = i + 3;
        while (url[i] !== '/' && i !== url) {
            server1 += url[i];
            i++;
        }
        while (i !== len) {
            resource1 += url[i];
            i++;
        }
    }

    result['portocol'] = portocol1;
    result['server'] = server1;
    result['resource'] = resource1;
    return result;
}

function objToString(obj) {
    console.log('{ portocol: ' + obj.portocol + ', server: ' + obj.server + ', resource: ' + obj.resource+' }');
}

objToString(parseURL(url));
objToString(parseURL(url1));