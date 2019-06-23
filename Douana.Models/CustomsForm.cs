using System.Collections.Generic;
using Douana.Models.Enumerations;
using Douana.Models.Models.Abstractions;
using Douana.Models.Models.Travel;
using Douana.Models.Travel;

namespace Douana.Models
{
    public class CustomsForm: DouanaBaseEntity
    {
        public long? CitizenId { get; set; }
        public virtual Citizen Citizen { get; set; }

        public long? FlightId { get; set; }
        public Flight Flight { get; set; }

        public long? BoatTripId { get; set; }
        public BoatTrip BoatTrip { get; set; }

        public long? GuestCountryPlaceId { get; set; }
        public Place GuestCountryPlace { get; set; }

        public long? DestinationId { get; set; }
        public Place Destination { get; set; }

        public long? OriginId { get; set; }
        public Place Origin { get; set; }

        public long? NationalityId { get; set; }
        public  virtual Nationality Nationality { get; set; }

        public virtual ICollection<VisitingMotives> VisitingMotives { get; set; }
    }
}