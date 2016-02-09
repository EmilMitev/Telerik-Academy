function solve() {
    $.fn.datepicker = function () {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };

        var div = $('div');
        div.addClass('datepicker-wrapper');

        var input = $('#date');
        input.addClass('datepicker');

        input.on('click', function () {
            var createCal = document.createElement('div');
            createCal.className += 'picker';
            div.appendChild(createCal);
        });

        var date = new Date();
        console.log(date.getDayName());
        console.log(date.getMonthName());
    };
}

module.exports = solve;