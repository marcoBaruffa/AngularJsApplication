using System.Collections.Generic;
using AirlinesWebApi.Models;

namespace AirlinesWebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AirlinesWebApi.Models.FlightDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AirlinesWebApi.Models.FlightDb context)
        {
            var model = new List<Flight>
            {
                new Flight() { Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10),Price =50, FlightNumber = "256", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="259", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="253", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="255", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="257", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="25922", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="2593", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="2592", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="2599", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="2592", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="2592", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() {  Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="2593", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } }

            };


            if (!context.Flight.Any())
            {
                context.Flight.AddRange(model);
            }
        }
    }
}
