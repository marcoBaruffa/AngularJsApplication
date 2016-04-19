(function(app) {

    var flightsController = function ($scope, flightService) {

        $scope.flights = flightService.getFlights();
           

        $scope.selectFlight = function (flight)
        {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }

            if (flightService.selectFlight(flight.id)) {
                $scope.status = "You have made a great decision!";
            };
            flight.approved = !flight.approved;

        }

    };

    app.controller("flightsController", ["$scope", "flightService", flightsController]);

}(angular.module("airlineApp")));