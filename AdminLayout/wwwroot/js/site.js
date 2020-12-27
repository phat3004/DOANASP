// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(window).on("load", function () {
    var cityname = "ho+chi+minh";
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

showInPopUp = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $('#form-modal .modal-body').html(res);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
            //$.notify('Create completed', { globalPosition: "top center", className ="success" });
        }
    })
}

showCheckoutFail = (title) => {
    $.ajax({
        success: function (res) {
            var result = '<h3 style="text-align: center; " class="alert alert - danger">Giỏ hàng trống - Không thể tiến hành thanh toán</h3>';
            $('#form-modal .modal-body').html(result);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
            //$.notify('Create completed', { globalPosition: "top center", className ="success" });
        }
    })
}

