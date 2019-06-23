using Douana.Models.Models.Abstractions;

namespace Douana.Models
{
    public class Place : DouanaBaseEntity
    {
        public long? AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}