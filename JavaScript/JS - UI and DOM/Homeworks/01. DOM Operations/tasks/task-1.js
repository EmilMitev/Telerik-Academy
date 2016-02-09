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
        var div = document.createElement('div'),
            cloneDiv,
            fragment = document.createDocumentFragment(),
            item,
            getElement;

        if (!element || !contents) {
            throw new Error('Argument cannot be undefined!');
        }

        if (typeof element !== 'string' && !(element instanceof HTMLElement)) {
            throw new Error('The element must be a string or DOM element!');
        }

        if (typeof element === 'string') {
            getElement = document.getElementById(element);
        } else {
            getElement = element;
        }

        if (getElement === null) {
            throw new Error('There is no such element');
        }

        for (item in contents) {
            if (typeof contents[item] !== 'string' && typeof contents[item] !== 'number') {
                throw new Error('Contents must be string or number!');
            }
        }

        getElement.innerHTML = '';

        for (item in contents) {
            cloneDiv = div.cloneNode(true);
            cloneDiv.innerHTML = contents[item];
            fragment.appendChild(cloneDiv);
        }

        getElement.appendChild(fragment);
    };
};