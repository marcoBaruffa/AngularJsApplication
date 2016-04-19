(function(app) {

    var flightsController = function($scope) {

            $scope.flights =
            [
            {
                airline: "United",
                flightNumber: "207",
                startTime: "13:00",
                endTime: "15:00",
                totalDuration: "2",
                price: 500,
                date: "12/11/2015",
                cities: ["ORD", "LAS"],
                approved:false

        },
            {
                airline: "United",
                flightNumber: "207",
                startTime: "13:00",
                endTime: "15:00",
                totalDuration: "2",
                price: 500,
                date: "12/11/2015",
                cities: ["SFO", "LAS"],
                approved: false

            }
        ];


        $scope.selectFlight = function (flight)
        {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }

            flight.approved = !flight.approved;

        }

    };

    app.controller("flightsController", ["$scope", flightsController]);

}(angular.module("airlineApp")));