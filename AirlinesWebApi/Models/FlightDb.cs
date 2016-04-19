using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AirlinesWebApi.Models
{
    public class FlightDb:DbContext
    {
        public FlightDb()
        {
            Database.SetInitializer<FlightDb>(null);
        }
        public DbSet<Flight> Flight { get; set; }
    }
}