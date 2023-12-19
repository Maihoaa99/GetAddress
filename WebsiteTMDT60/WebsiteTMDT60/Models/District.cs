using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTMDT60.Models
{
    [Table("district")]
    public class District
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int code { get; set; }
        [Required]
        public string? name { get; set; }
        
        public Guid city_id { get; set; }
        [ForeignKey("city_id")]
        public City city { get; set; }
        public ICollection<Commune> wards { get; set; }

        public District()
        {
            wards = new HashSet<Commune>();
            Id = Guid.NewGuid();
        }
    }
}
