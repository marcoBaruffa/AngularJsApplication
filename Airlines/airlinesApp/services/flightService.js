﻿





(function (app) {
    var testData = [
            {
                id:1,
                airline: "United",
                flightNumber: "207",
                startTime: "13:00",
                endTime: "15:00",
                totalDuration: "2",
                price: 500,
                date: "12/11/2015",
                cities: ["ORD", "LAS"],
                approved: false

            },
            {
                id:2,
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

    var baseUrl = "/api/flights";

    var flightService = function ($http) {
        var flightFactory = {};
        flightFactory.getFlights = function () {
            return $http.get(baseUrl);
        };

        flightFactory.selectFlight = function (id) {

            return true;

        };
        return flightFactory;
    };

    app.factory("flightService",["$http", flightService]);


}(angular.module("airlineApp")));