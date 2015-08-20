$.fn.tabs = function () {
	element = this;
	element.addClass('tabs-container');
	var current = $('p');
	element.on('click', '.tab-item', function(ev) {
		current.hide();
		tab = $(ev.target);
		current = tab;

		tab.show();


	});
};