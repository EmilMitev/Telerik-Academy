function solve() {
    return function (selector, isCaseSensitive) {
        isCaseSensitive = isCaseSensitive || false;

        var root = document.querySelector(selector);
        var dFrag = document.createDocumentFragment();

        //Adding elements.
        var addDiv = document.createElement('div');
        addDiv.className += ' add-controls';
        var addLabel = document.createElement('label');
        addLabel.innerHTML = 'Enter text';
        var addInput = document.createElement('input');
        var addButton = document.createElement('button');
        addButton.className += ' button';
        addButton.innerHTML = 'Add';


        //Searching elements
        var searchDiv = document.createElement('div');
        searchDiv.className += ' search-controls';
        var searchLabel = document.createElement('label');
        searchLabel.innerHTML = 'Search';
        var searchInput = document.createElement('input');

        //Result elements
        var resultDiv = document.createElement('div');
        resultDiv.className += ' result-controls';
        var resultUl = document.createElement('UL');
        resultUl.className += ' items-list';
        resultUl.style.listStyleType = 'none';


        addDiv.appendChild(addLabel);
        addDiv.appendChild(addInput);
        addDiv.appendChild(addButton);
        dFrag.appendChild(addDiv);

        searchDiv.appendChild(searchLabel);
        searchDiv.appendChild(searchInput);
        dFrag.appendChild(searchDiv);

        resultDiv.appendChild(resultUl);
        dFrag.appendChild(resultDiv);

        root.appendChild(dFrag);

        addButton.addEventListener('click', function () {
            var addLiElement = document.createElement('li');
            addLiElement.className += ' list-item';
            var resultButton = document.createElement('button');
            resultButton.className = ' button';
            resultButton.innerHTML = 'X';
            var labelResult = document.createElement('label');
            labelResult.innerHTML = addInput.value;
            if(labelResult.innerHTML !== ''){
                addLiElement.appendChild(resultButton);
                addLiElement.appendChild(labelResult);
                addInput.value = '';

                resultUl.appendChild(addLiElement);
            }
        });

        resultUl.addEventListener('click', function (ev) {
            if (ev.target.className === ' button') {
                var selectedElement = ev.target.parentNode;
                selectedElement.parentNode.removeChild(selectedElement);
            }
        });

        searchInput.addEventListener("change", function (ev) {
            var text = ev.target.value;
            var liChildren = resultUl.getElementsByTagName('li');
            for (var i = 0; i < liChildren.length; i++) {
                var currentLi = liChildren[i];
                var header = currentLi.lastElementChild.innerHTML;
                if(isCaseSensitive){
                    if (header.indexOf(text) >= 0) {
                        currentLi.style.display = 'block';
                    } else {
                        currentLi.style.display = 'none';
                    }
                } else{

                    if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                        currentLi.style.display = 'block';
                    } else {
                        currentLi.style.display = 'none';
                    }
                }
            }
        });
    };
}

module.exports = solve;