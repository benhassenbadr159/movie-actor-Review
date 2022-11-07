using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace el_r3ad.models
{
    [Table("Actor")]
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; } = null!;
        [Required]
        public string? ActorGender { get; set; } = null!;
        public string? ActorBio { get; set; } = null!;
        [Required]
        public ICollection<MovieReview> Reviews { get; set; } = null!;
        public ICollection<MovieActor> ActorMovie { get; set; } = null!;
    }
}
    