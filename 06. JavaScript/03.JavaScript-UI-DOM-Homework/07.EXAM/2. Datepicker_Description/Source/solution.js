function solve() {
    $.fn.datepicker = function() {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function() {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function() {
            return WEEK_DAY_NAMES[this.getDay()];
        };

        // you are welcome :)
        var date = new Date();
        console.log(date.getDayName());
        console.log(date.getMonthName());


        var dateText = $('#date');
        var wrapper = $('<div>').addClass('datepicker-wrapper');
        var root = dateText.parent();

        root.append(wrapper);
        wrapper.append(dateText);

        dateText.addClass('datepicker');


        var datepicker = $('<div>')
            .addClass('datepicker-content')
            .appendTo(wrapper);

        var datepickerControls = $('<div>')
            .addClass('controls')
            .appendTo(datepicker);

        var currentDate = $('<div>')
            .addClass('current-date')
            .appendTo(datepicker)
            .html(date.getDate() + ' ' + date.getMonthName() + ' ' + date.getFullYear());

        var currentDateText = date.getDate() + '/' + date.getMonth() + '/' + date.getFullYear();
        currentDate.on('click', function() {
            dateText.val(currentDateText);
        });

        var btnLeft = $('<div>')
            .addClass('controls')
            .addClass('btn')
            .html('<')
            //.css('float', 'left')
            //.css('display', 'inline-block')
            .appendTo(datepickerControls);

        var currentMonth = $('<div>')
            .addClass('current-month')
            //.css('float', 'left')
            //.css('height', '30px')
            .appendTo(datepickerControls)
            .html('Some tex');

        var btnRight = $('<div>')
            .addClass('controls')
            .addClass('btn')
            .html('>')
            //.css('float', 'left')
            //.css('display', 'inline-block')
            .appendTo(datepickerControls);


        var calendar = $('<table>')
            .addClass('calendar')
            .appendTo(datepicker);

        var tHead = $('<thead>').appendTo(calendar);
        var thHeadRow = $('<tr>')
            .appendTo(tHead);
        for (var j = 0; j < 7; j++) {
            var th = $('<th>')
                .html(WEEK_DAY_NAMES[j])
                .appendTo(thHeadRow);
        }


        var tBody = $('<tbody>').appendTo(calendar);
        for (var i = 0; i < 6; i++) {
            var tr = $('<tr>');
            for (var j = 0; j < 7; j++) {
                tr.append('<td>');
            }
            tr.appendTo(tBody);
        }


        var allTD = calendar.find('td');
        // for (var i =0, len = allTD.length; i < len; i++) {

        //     $(allTD[i]).html();
        // }

        dateText.on('focus', function(event) {
            datepicker.addClass('datepicker-content-visible');
        });
        dateText.on('focusout', function(event) {
            datepicker.removeClass('datepicker-content-visible');
        });

        return this;
    };
}
