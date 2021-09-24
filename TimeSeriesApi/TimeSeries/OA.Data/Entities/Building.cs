using System.ComponentModel.DataAnnotations;

namespace OA.Data.Entities
{
    public class Building
    {
        [Key]
        public short Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
