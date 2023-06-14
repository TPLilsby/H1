$(document).ready(function() {
    $.ajax({
        url: "https://localhost:7218/WeatherForecast"
    }).then(function(data) {
        for (i = 0; i < data.length; i++) {
            $('.year').append( `<br>` + data[i].year);
            $('.temperatureC').append(`<br>` + data[i].temperatureC);
            $('.temperatureF').append(`<br>` + data[i].temperatureF);
            $('.summaries').append(`<br>` + data[i].summary);

        }
    });
});