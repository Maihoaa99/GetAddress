using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTMDT60.Models
{
    [Table("cities")]
    public class City
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int code { get; set; }
        [Required]
        public string? name { get; set; }
        public ICollection<District> districts { get; set; }

        public City()
        {
            districts = new HashSet<District>();
            Id = Guid.NewGuid();
        }
     

    }
}
