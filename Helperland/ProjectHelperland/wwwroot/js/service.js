$(document).ready(() => {
    getData();

});
function getData() {
    var events = [];
    $.ajax({
        url: "/Home/GetServiceReqCalendar",
        method: "GET",
        dataType: "JSON",

        success: (data) => {
            console.log(data);

            if (data != "notfound") {
                for (var i in data) {
                    events.push({
                        id: data[i].id,
                        title: data[i].title,
                        start: data[i].start,
                        color: data[i].color
                    });
                }
            }
            var calendarEl = document.getElementById('calendar');
            var calendar = new FullCalendar.Calendar(calendarEl, {
                initialView: 'dayGridMonth',
                headerToolbar: {
                    left: 'prev,next,title',
                    center: '',
                    right: ''
                },
                events: events
            });
            calendar.render();
        },
        error: (err) => {
            console.log(err);
        }
    });
}


