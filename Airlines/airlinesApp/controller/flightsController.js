﻿(function(app) {

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
                cities: ["ORD", "LAS"]

            },
            {
                airline: "United",
                flightNumber: "207",
                startTime: "13:00",
                endTime: "15:00",
                totalDuration: "2",
                price: 500,
                date: "12/11/2015",
                cities: ["SFO", "LAS"]

            }
        ];

    };

    app.controller("flightsController", ["$scope", flightsController]);

}(angular.module("airlineApp")));