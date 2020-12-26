// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(window).on("load", function () {
    var cityname = "Ho+Chi+Minh";
    $.ajax({
        //type: GET,
        url: "/API/WeatherAPI/GetWeather",
        data: { "city": cityname },
        success: function (files) {
            var data = JSON.parse(files);
            var doC = data.temp - 273.15;
            var result = data.city + ": " + doC + "&#8451";
            console.log(doC);
            $("#lblWeather").html(result);
        }
    })
});
