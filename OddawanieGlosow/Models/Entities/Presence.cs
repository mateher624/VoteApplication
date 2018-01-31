using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OddawanieGlosow.Models.Entities
{
    public class Presence
    {
        public string Pesel { get; set; }
        public Poll Poll { get; set; }
    }
}