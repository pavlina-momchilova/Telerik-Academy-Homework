/*
 * Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */
var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTags(text) {
    var result = '', i, len = text.length, regex;
    regex = /<a href="/g;
    text = text.replace(regex, '[URL=');
    regex = /">/g;
    text = text.replace(regex, ']');
    regex = /<\/a>/g;
    text = text.replace(regex, '[/URL]');
    return text;
}

console.log(replaceTags(html));