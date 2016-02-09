/* globals $ */

/* 

 Create a function that takes an id or DOM element and:


 */

function solve() {
    return function (selector) {
        var buttons,
            div,
            content,
            button,
            element;

        if (typeof selector !== 'string') {
            throw new Error('Selector must be a string');
        }

        element = document.getElementById(selector);

        if (element === null) {
            throw new Error('There is no such element');
        }

        buttons = document.getElementsByClassName('button');
        div = document.getElementById('root');


        for (var item in buttons) {
            buttons[item].innerHTML = 'hide';
        }

        div.addEventListener('click', function (ev) {
            if (ev.target.className === 'button') {
                button = ev.target;
                content = ev.target;

                while (content) {
                    if (content.className === 'content') {
                        break;
                    }
                    content = content.nextElementSibling;
                }

                if (content.style.display === '') {
                    button.innerHTML = 'show';
                    content.style.display = 'none';
                } else if (content.style.display === 'none') {
                    button.innerHTML = 'hide';
                    content.style.display = '';
                }
            }
        }, false);
    };
}

module.exports = solve;