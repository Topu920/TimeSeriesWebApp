using System;
using System.ComponentModel.DataAnnotations;

namespace OA.Data.Entities
{
    public class Reading
    {
        [Key]
        public int Id { get; set; }

        public short BuildingId { get; set; }
        public virtual Building Building { get; set; }

        public byte ObjectId { get; set; }
        public virtual Object Object { get; set; }

        public byte DataFieldId { get; set; }
        public virtual DataField DataField { get; set; }

        public decimal Value { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
