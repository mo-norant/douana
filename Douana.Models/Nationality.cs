using Douana.Models.Models.Abstractions;

namespace Douana.Models
{
    public class Nationality : DouanaBaseEntity
    {
        public long? CountryId { get; set; }
        public virtual Country Country { get; set; }
        public string TranslationKey { get; set; }
        public bool VisumRequired { get; set; }
        
    }
}