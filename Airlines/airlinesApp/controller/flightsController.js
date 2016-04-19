(function(app) {

    var flightsController = function ($scope, flightService, $timeout) {

        $scope.flights = flightService.getFlights();
           

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