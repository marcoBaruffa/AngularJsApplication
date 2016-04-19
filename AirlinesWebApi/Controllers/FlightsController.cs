using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AirlinesWebApi.Models;

namespace AirlinesWebApi.Controllers
{
    public class FlightsController : ApiController
    {
        public IHttpActionResult GetAllFlights()
        {
            var model = new List<Flight>
            {
                new Flight() { Id = 1, Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10),Price =50, FlightNumber = "256", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } },
                new Flight() { Id = 1, Airline = "United", StartTime = new DateTime(2015,10,10), EndTime =new DateTime(2019,10,10), Price =100, FlightNumber ="259", TotalDuration = 2, Approved = false, Cities = new[] { "ORD", "LAS" } }

            };


            return Ok(model);

        }
    }
}
