using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace el_r3ad.models
{
    [Table("Producer")]
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProducerName { get; set; } = null!;
        [Required]
        public string ProducerGender { get; set; } = null!;
        public string ProducerBio { get; set; } = null!;
        [Required]
        public ICollection<Movies> Movies { get; set; } = null!;
    }
}
