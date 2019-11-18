
function carsList() {
    $.ajax
    ({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/car',
        type: 'GET',
        dataType: 'json',
        success: function (vehicles) {
            vehicleListSuccess(vehicles);
        }
    })
}
function bikesList() {
    $.ajax
    ({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/bike',
        type: 'GET',
        dataType: 'json',
        success: function (vehicles) {
            vehicleListSuccess(vehicles);
        }
    })
}
function bikesListId() {
    id = $("#bikeId").val();
    $.ajax
    ({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/bike/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (vehicle) {
            index = 0;
            vehicleAddRow(vehicle, index);
        }
    })
}
function carsListId() {
    id = $("#carId").val();
    $.ajax
    ({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/car/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (vehicle) {
            index = 0;
            vehicleAddRow(vehicle, index);
        }
    })
}
function vehicleListSuccess(vehicles) {
    $.each(vehicles, function (index, vehicle) {
        console.log(vehicle);
        vehicleAddRow(vehicle, index);
    })
}
function vehicleAddRow(vehicle, index) {
    if (index == 0) {
        $("#vehicleTable tbody").empty();
    }
    if ($("#vehicleTable tbody").length == 0) {
        $("#vehicleTable").append("<tbody></tbody>");
    }
    $("#vehicleTable tbody").append(
      productBuildTableRow(vehicle, index));
}
function productBuildTableRow(vehicle, index) {
    if (vehicle.Type == 1) {
        var type = "Car";
        var KickStart = "NuLL";
        var AirBags = vehicle.AirBags;
        var PowerSteering = vehicle.PowerSteering;
    }
    else {
        var type = "Bike";
        var KickStart = vehicle.KickStart;
        var PowerSteering = "NuLL";
        var AirBags = "NuLL";
    }
    var ret =
      "<tr>" +
       "<td>" + index + "</td>" +
       "<td>" + type + "</td>" +
       "<td>" + vehicle.Model + "</td>"
        + "<td>" + vehicle.Name + "</td>" +
        "<td>" + PowerSteering + "</td>"
        + "<td>" + KickStart + "</td>"
        + "<td>" + AirBags + "</td>"
        + "<td>" + vehicle.Price + "</td>" +
        "<td>" + vehicle.EngineDisplacement + "</td>"
    "</tr>";
    return ret;
}


