﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesWebApi.Models
{

    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalDuration { get; set; }
        public decimal Price { get; set; }
        public string[] Cities { get; set; }
        public bool Approved { get; set; }
    }
}