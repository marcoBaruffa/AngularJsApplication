(function(app) {

    var flightsController = function ($scope, flightService, $timeout) {


        var onError = function() {
            alert("error!");
        };

        var onFlights = function (response) {
            $scope.flights = response.data;
        }

        $scope.flights = flightService.getFlights().then(onFlights,onError);
           

        $scope.selectFlight = function (flight)
        {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }

            if (flightService.selectFlight(flight.id)) {
                $scope.status = "You have made a great decision!";
                $timeout(function() { $scope.status = null },3000);
            };
            flight.approved = !flight.approved;

        }

    };

    app.controller("flightsController", ["$scope", "flightService","$timeout", flightsController]);

}(angular.module("airlineApp")));