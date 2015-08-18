/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
    return function (selector) {
        var elementi,j,classButton=[],classContent=[],childNode,topmost;
        if (typeof selector !=='string' && !(selector instanceof HTMLElement)) {
            throw new Error;
        }
        if (typeof selector === 'string') {
            element = document.getElementById(selector);
        } else {
            element = selector;
        }
        if (!element) {
            throw new Error;
        }
        childNode=element.childNodes;
        for (i = 0,len=childNode.length; i < len; i+=1) {
            if (childNode[i].className === 'button') {
                childNode[i].innerHTML='hide';
                classButton.push(childNode[i]);
            }
            if (childNode[i].className === 'content') {
                classContent.push(childNode[i])
            }
        }

        for (j = 0; j < classButton.length; j += 1) {
            var btn = classButton[j];
            classButton[j].addEventListener('click', function (event) {
                var selectedBtn=event.target;
                topmost = selectedBtn.nextElementSibling;
                if (topmost.className === 'button') {
                    return;
                }
                while (!(topmost.className === 'content') && !(topmost.className === 'button')) {
                    topmost = topmost.nextElementSibling;
                }
                if (topmost.style.display === 'none') {
                    topmost.style.display = '';
                    selectedBtn.innerHTML = 'hide';
                }
                else {
                    topmost.style.display = 'none';
                    selectedBtn.innerHTML = 'show';
                }
            },false);
        }
    };
};

module.exports = solve;