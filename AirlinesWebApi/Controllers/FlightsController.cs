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
           var db = new FlightDb();
            var model = db.Flight;


            return Ok(model);

        }
    }
}
