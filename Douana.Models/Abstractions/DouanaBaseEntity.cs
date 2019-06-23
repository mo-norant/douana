using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Douana.Models.Models.Abstractions
{
    public abstract class DouanaBaseEntity
    {
        [Key]
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset LastChanged { get; set; }
        public bool Active { get; set; }
    }
}
