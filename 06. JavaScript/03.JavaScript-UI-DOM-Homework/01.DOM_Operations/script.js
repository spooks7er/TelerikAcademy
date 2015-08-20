function fillElement(element, array) {
    var i, arrayLen = array.length,
        docFrag = document.createDocumentFragment();

    if (typeof element === 'string') {
        element = document.getElementById(element);
    }

    for (i = 0; i < arrayLen; i += 1) {
    	if (!(typeof array[i]  === 'string' || typeof array[i]  === 'number')) {
    		throw new Error('invalid content elements');
    	}
        var newCont = document.createElement('div');
        newCont.innerHTML = array[i];
        docFrag.appendChild(newCont);
    }

    element.innerHTML = '';
    element.appendChild(docFrag);
}

var el = document.getElementById('root');
var count = 15,
    contents = Array.apply(null, {
        length: count
    })
    .map(function(_, index) {
        return 'Content #' + index;
    });


fillElement(el, contents);

console.log('3');
