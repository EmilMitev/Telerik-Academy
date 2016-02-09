var cookiesController = function () {

    function all(context) {
        var events,
            category = this.params.category || null,
            i,
            len;

        data.cookies.get()
            .then(function (resEvents) {
                $('#selectForm').show();
                for (i = 0, len = resEvents.length; i < len; i++) {
                    var event = resEvents[i];
                    event.before = moment(event.shareDate).fromNow();
                }
                events = _.chain(resEvents)
                    .groupBy(controllerHelpers.groupByCategory)
                    .map(controllerHelpers.parseGroups)
                    .value();

                if (category) {
                    events = events.filter(controllerHelpers.filterByCategory(category));
                    console.log(events);
                }

                var selectedSort = $('.target option:selected').text();

                for (i = 0, len = events.length; i < len; i += 1) {
                    var event = events[i];
                    var ev = _.sortBy(event.items, selectedSort).reverse();
                    events[i].items = ev;
                }

                if (category) {
                    events = events.filter(controllerHelpers.filterByCategory(category));
                }

                return templates.get('cookies');
            })
            .then(function (template) {
                toastr.success("Sorted!");
                context.$element().html(template(events));
            })
            .catch(function (err) {
                toastr.error(JSON.stringify(err));
            });
    }

    function getMyCookies(){
        $('#selectForm').hide();

        var events;

        var category = this.params.category || null;

        data.cookies.getMyCookies()
            .then(function(resEvents) {
                events = resEvents;

                if (category) {
                    events = events.filter(controllerHelpers.filterByCategory(category));
                }
                console.log(events)
                return templates.get('cookies');
            })
            .then(function(template) {
                context.$element().html(template(events));
            })
            .catch(function(err) {
                toastr.error(JSON.stringify(err));
            });
    }

    return {
        all: all,
        getMyCookies: getMyCookies
    };
}();
