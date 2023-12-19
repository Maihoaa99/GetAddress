using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTMDT60.Models
{
    [Table("communes")]
    public class Commune
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int code { get; set; }
        [Required]
        public string? name { get; set; }
       
        public Guid district_id { get; set; }
        [ForeignKey("district_id")]
        public District? district { get; set; }
        public Commune()
        {
            Id = Guid.NewGuid();
        }
    }
}
