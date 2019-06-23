using System;
using System.Collections.Generic;
using System.Text;
using Douana.Models.Models.Abstractions;

namespace Douana.Models.Models.Travel
{
    public class BoatTrip : DouanaBaseEntity
    {
        public string TripId { get; set; }

        public long? DepartureId { get; set; }
        public Place Departure { get; set; }

        public long? DestinationId { get; set; }
        public Place Destination { get; set; }

    }
}
