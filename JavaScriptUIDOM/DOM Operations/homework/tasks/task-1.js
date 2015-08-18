/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

    return function (element, contents) {
        var selectedElement, i, j, len = contents.length, child, div, contentOfDivs;
        if (!element || !contents) {
            throw new Error;
        }
        if (!contents || !element) {
            throw new Error;
        }

        if (typeof element !== 'string' && !(element instanceof HTMLElement)) {
            throw new Error;
        }

        for (i = 0; i < len; i += 1) {
            if (typeof contents[i] !== 'number' && typeof contents[i] !== 'string') {
                throw new Error;
            }
        }
        if (typeof element === 'string') {
            selectedElement = document.getElementById(element);
        }
        else {
            selectedElement = element;
        }

        child = selectedElement.firstChild;
        while (child) {
            selectedElement.removeChild(child);
            child = selectedElement.firstChild;
        }

        for (j = 0; j < len; j += 1) {
            div = document.createElement('div');
            contentOfDivs = contents[j];
            div.innerHTML = contentOfDivs;
            selectedElement.appendChild(div);
        }
    };
};