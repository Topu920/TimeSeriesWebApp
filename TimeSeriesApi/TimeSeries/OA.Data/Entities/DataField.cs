using System.ComponentModel.DataAnnotations;

namespace OA.Data.Entities
{
    public class DataField
    {
        [Key]
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}
