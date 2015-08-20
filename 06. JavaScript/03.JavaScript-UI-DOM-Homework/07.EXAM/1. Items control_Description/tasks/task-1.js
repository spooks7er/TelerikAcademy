function solve() {
    return function(selector, isCaseSensitive) {
    	if (!selector) {
    		throw new Error('selector error');
    	}
        isCaseSensitive = isCaseSensitive || false;
        var root = document.querySelector(selector);
        if (!root) {
            throw new Error('selector error');
        }
        root.className += 'items-control';
        
        // Add Controlls
        var addControls = document.createElement('div');
        addControls.className += 'add-controls';

        var enterText = document.createElement('label');
        enterText.innerHTML = 'Enter Text';

        var inputAdd = document.createElement('input');
        inputAdd.type = 'text';

        var btnAdd = document.createElement('button');
        btnAdd.className += 'button';
        btnAdd.innerHTML = 'Add';

        addControls.appendChild(enterText);
        addControls.appendChild(inputAdd);
        addControls.appendChild(btnAdd);

        root.appendChild(addControls);
        // End Add controlls

        // Search controlls 

        var searchControls = document.createElement('div');
        searchControls.className = 'search-controls';

        var searchText = document.createElement('label');
        searchText.innerHTML = 'Search';

        var inputSearch = document.createElement('input');
        inputSearch.type = 'text';
        searchControls.appendChild(searchText);
        searchControls.appendChild(inputSearch);

        root.appendChild(searchControls);
        // End Search controlls 

        // Result Controlls
        var resulthControls = document.createElement('div');
        resulthControls.className = 'result-controls';

        var itemsList = document.createElement('ul');
        itemsList.className = 'items-list';

        //list item do not append now
        var listItem = document.createElement('li');
        listItem.className = 'list-item';

        var btnRemove = document.createElement('button');
        btnRemove.className = 'button';
        btnRemove.innerHTML = 'X';

        listItem.appendChild(btnRemove);

        resulthControls.appendChild(itemsList);

        root.appendChild(resulthControls);

        // END REULT CONTROLLS

        //EVENTS 

        btnAdd.addEventListener('click', function(ev) {
            var target = ev.target;
            var item = inputAdd.value;
            var newItem = listItem.cloneNode(true);
            var span = document.createElement('span');
            span.innerHTML = item;
            newItem.appendChild(span);
            itemsList.appendChild(newItem);
        }, false);

        inputSearch.addEventListener('input', function(ev) {
            var target = ev.target;
            var value = target.value;
            var items = itemsList.children;
            for (var i = 0, len = items.length; i < len; i++) {
                var currentItemsTExt = items[i].childNodes[1].innerHTML;
                if (!isCaseSensitive) {
                    currentItemsTExt = items[i].childNodes[1].innerHTML.toLowerCase();
                    value = value.toLowerCase();
                }

                if (currentItemsTExt.indexOf(value) >= 0) {
                    items[i].style.display = '';
                } else {
                    items[i].style.display = 'none';
                }
            }
        }, false);

        itemsList.addEventListener('click', function(ev) {
            var target = ev.target;
            if (target.nodeName === 'BUTTON') {
            	target.parentNode.remove();
            }
        }, false);
    };
}

//module.exports = solve;
