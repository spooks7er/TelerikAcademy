function createImagesPreviewer(selector, items) {
    var root = document.querySelector(selector);
    root.className += ' image-previewer';

    var table = document.createElement('table');
    table.style.height = '400px';
    table.style.overflow = 'hidden';

    var theRow = document.createElement('tr');
    table.appendChild(theRow);
    root.appendChild(table);

    /* Left panel */
    var leftPanel = document.createElement('td');
    leftPanel.className += ' left-panel';

    var title = document.createElement('h1');
    title.innerHTML = items[0].title;
    title.style.textAlign = 'center';

    var bigImage = document.createElement('img');
    bigImage.style.width = '250px';
    bigImage.src = items[0].url;
    bigImage.style.borderRadius = '10px'; //
    leftPanel.appendChild(title);
    leftPanel.appendChild(bigImage);
    /* End of left panel */

    /* Right panel */
    var rightPanel = document.createElement('td');
    rightPanel.className += ' right-panel';
    rightPanel.style.textAlign = 'center';
    rightPanel.style.overflowY = 'scroll';

    var filter = document.createElement('div');
    filter.className = 'filter';
    filter.style.marginBottom = '-30px'; //
    var filterTitle = document.createElement('span');
    filterTitle.innerHTML = 'Filter';
    var filterBox = document.createElement('input');
    filterBox.type = 'text';
    filterBox.style.width = '70%'; //
    filter.appendChild(filterTitle);
    filter.appendChild(document.createElement('br'));
    filter.appendChild(filterBox);

    rightPanel.appendChild(filter);

    var imgsList = document.createElement('ul');
    imgsList.style.listStyleType = 'none';
    imgsList.style.height = '200px';

    imgsList.style.padding = '25px'; //

    for (var i = 0; i < items.length; i += 1) {

        var imgItem = document.createElement('li');
        imgItem.setAttribute('data-index', i + '');
        imgItem.style.width = '150px';

        var imgItemTitle = document.createElement('span');
        imgItemTitle.innerHTML = items[i].title;
        imgItem.appendChild(imgItemTitle);

        var imgItemImg = document.createElement('img');
        imgItemImg.src = items[i].url;
        imgItemImg.style.maxWidth = '95%'; //
        imgItemImg.style.borderRadius = '10px'; //
        imgItem.appendChild(imgItemImg);
        imgsList.appendChild(imgItem);
    }

    rightPanel.appendChild(imgsList);

    /* End of right panel */

    imgsList.addEventListener('mouseover', function(ev) {
        var target = ev.target;

        if (target.tagName !== 'IMG') {
            return;
        }
        var parent = target.parentNode
        parent.style.backgroundColor = 'lightgrey';
    }, false);

    imgsList.addEventListener('mouseout', function(ev) {
        var target = ev.target;

        if (target.tagName !== 'IMG') {
            return;
        }
        var parent = target.parentNode;
        parent.style.backgroundColor = '';
    }, false);

    imgsList.addEventListener('click', function(ev) {
        var target = ev.target;

        if (target.tagName !== 'IMG') {
            return;
        }
        bigImage.src = target.src;
    }, false);

    filterBox.addEventListener('input', function(ev) {
        var target = ev.target;
        var images = imgsList.children;
        for (var i = 0, len = images.length; i < len; i++) {
            var currentImageTitle = images[i].firstChild.innerHTML.toLowerCase();

            if (currentImageTitle.indexOf(target.value.toLowerCase()) >= 0) {
                images[i].style.display = '';
            } else {
                images[i].style.display = 'none';
            }
        }
    }, false);


    theRow.appendChild(leftPanel);
    theRow.appendChild(rightPanel);
}
