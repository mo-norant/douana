using Douana.Models.Models.Abstractions;

namespace Douana.Models
{
    public class Country : DouanaBaseEntity
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public bool IsEuropeanUnion { get; set; }
    }
}