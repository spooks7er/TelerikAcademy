function createCalendar(selector, events) {
    var element = document.querySelector(selector),
        fragment = document.createDocumentFragment(),
        day = document.createElement('div');
    element.style.width = '1064px';
    dayTtle = document.createElement('h4');
    dayTtle.style.margin = '0';
    dayTtle.style.padding = '2px 5px 2px 5px';
    dayTtle.style.borderBottom = '1px solid black';
    dayTtle.style.backgroundColor = 'lightgray';

    day.style.width = '150px';
    day.style.height = '150px';
    day.style.cssFloat = 'left';
    day.style.border = '1px solid black';
    day.style.textAlign = 'center';

    day.appendChild(dayTtle);
    var d = 0;
    for (var i = 1; i <= 30; i++) {
        var newDay = day.cloneNode(true);
        var dayOfWeek = '';
        d += 1;
        if (d > 7) {
            d = 1;
        }
        switch (true) {
            case d % 7 === 0:
                dayOfWeek = 'Sat';
                break;
            case d % 6 === 0:
                dayOfWeek = 'Fri';
                break;
            case d % 5 === 0:
                dayOfWeek = 'Thu';
                break;
            case d % 4 === 0:
                dayOfWeek = 'Wed';
                break;
            case d % 3 === 0:
                dayOfWeek = 'Tue';
                break;
            case d % 2 === 0:
                dayOfWeek = 'Mon';
                break;
            case d % 1 === 0:
                dayOfWeek = 'Sun';
                break;
        }

        newDay.firstChild.innerHTML = dayOfWeek + ' ' + i + ' June 2014';
        var evetData = document.createElement('p');
        var curEvent;
        for (var j = 0, len = events.length; j < len; j++) {
            if (events[j].date * 1 === i) {
                curEvent = events[j];
                evetData.innerHTML = curEvent.title + ' ' + curEvent.hour + ' ' + curEvent.duration;
                newDay.appendChild(evetData);
                break;
            }
        }
        fragment.appendChild(newDay);
    }
    element.appendChild(fragment);

    var clicked = document.createElement('p');
    element.addEventListener('click', function(ev) {
        day = ev.target;
        clicked.style.backgroundColor = '';
        if (day.nodeName !== 'DIV') {
            return;
        }

        day.style.backgroundColor = 'lightgreen';
        clicked = day;
    });

    element.addEventListener('mouseover', function(ev) {
        dayTitle = ev.target.firstChild;

        if (day.nodeName !== 'DIV') {
            return;
        }
        dayTitle.style.backgroundColor = 'gray';
    });
    element.addEventListener('mouseout', function(ev) {
        dayTitle = ev.target.firstChild;

        if (day.nodeName !== 'DIV') {
            return;
        }
        dayTitle.style.backgroundColor = 'lightgray';
    });
}
