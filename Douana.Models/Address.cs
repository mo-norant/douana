using Douana.Models.Models.Abstractions;

namespace Douana.Models
{
    public class Address : DouanaBaseEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public long? CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}