using System;
using Douana.Models.Models.Abstractions;
using Douana.Models.Travel;

namespace Douana.Models
{
    public class CustomsRequest : DouanaBaseEntity
    {
        public long? CustomsFormId { get; set; }
        public virtual CustomsForm CustomsForm { get; set; }
    }
}
