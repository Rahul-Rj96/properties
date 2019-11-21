var Car = {
    Type: 1,
    Model: "",
    Name: "",
    PowerSteering: "",
    AirBags: null,
    Price: null,
    EngineDisplacement:null
}
var Bike = {
    Type: 0,
    Model: "",
    Name: "",
    KickStart: "",
    Price: null,
    EngineDisplacement: null
}
function SubmitCar() {
    Car = new Object();
    Car.Type = 1;
    Car.Name = $("#carName").val();
    Car.Model = $("#carModel").val();
    Car.PowerSteering = $('#powerSteering').is(':checked');
    Car.Price = $("#carPrice").val();
    Car.AirBags = $("#airBags").val();
    Car.EngineDisplacement = $("#carEngineDisplacement").val();
    VehicleAddCar(Car);

}

function SubmitBike() {
    Bike = new Object();
    Bike.Type = 0;
    Bike.Name = $("#bikeName").val();
    Bike.Model = $("#bikeModel").val();
    Bike.KickStart = $('#kickStart').is(':checked');
    Bike.Price = $("#bikePrice").val();
    Bike.EngineDisplacement = $("#bikeEngineDisplacement").val();
    VehicleAddBike(Bike);
}
function VehicleAddCar(Car) {
    $.ajax({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/car',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(Car),
        success: function (Car) {
        alert(Car);
        },
    });
}
function VehicleAddBike(Bike) {
    $.ajax({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/bike',
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(Bike),
        success: function (Bike) {
            alert(Bike);
        },
    });
}

function CarsList() {
    $.ajax
    ({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/car',
        type: 'GET',
        dataType: 'json',
        success: function (vehicles) {
            VehicleListSuccess(vehicles);
        }
    })
}
function BikesList() {
    $.ajax
    ({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/bike',
        type: 'GET',
        dataType: 'json',
        success: function (vehicles) {
            VehicleListSuccess(vehicles);
        }
    })
}
function BikesListId() {
    id = $("#bikeId").val();
    console.log(id);
        $.ajax
        ({
            url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/bike/' + id,
            type: 'GET',
            dataType: 'json',
            success: function (vehicle) {
                index = 0;
                VehicleAddRow(vehicle, index);
            }
        })
    
}
function CarsListId() {
    id = $("#carId").val();
    console.log(id);
    $.ajax
    ({
        url: 'http://vehicledata.dev19.grcdev.com/api/vehicle/car/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (vehicle) {
            index = 0;
            VehicleAddRow(vehicle, index);
        }
    });
}



function VehicleListSuccess(vehicles) {
    $.each(vehicles, function (index, vehicle) {
        VehicleAddRow(vehicle, index);
    })
}

function VehicleAddRow(vehicle, index) {
    if (index == 0) {
        $("#vehicleTable tbody").empty();
    }
    if ($("#vehicleTable tbody").length == 0) {
        $("#vehicleTable").append("<tbody></tbody>");
    }
    $("#vehicleTable tbody").append(
      VehicleBuildTableRow(vehicle, index));
}
function VehicleBuildTableRow(vehicle, index) {
    if (vehicle != null && vehicle.Type != undefined) {
        if (vehicle.Type == 1) {
            var type = "Car";
            var KickStart = "NuLL";
            var AirBags = vehicle.AirBags;
            var PowerSteering = vehicle.PowerSteering;
        }
        else if(vehicle.Type==0){
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
    else {
        alert("No Data To Show !!!");
    }
}



