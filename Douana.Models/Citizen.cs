using System;
using System.Collections.Generic;
using Douana.Models.Models.Abstractions;

namespace Douana.Models
{
    public class Citizen : DouanaBaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MaidenName { get; set; }

        public long? CurrentResidenceId { get; set; }
        public Place CurrentResidence { get; set; }

        public DateTimeOffset BirthDate { get; set; }
        public long? BirthPlaceId { get; set; }
        public virtual Place BirthPlace { get; set; }

        public string Occupation { get; set; }
        public virtual ICollection<PassportNumber> PassportNumbers { get; set; }
    }
}