using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace el_r3ad.models
{
    [Table("Reviewer")] 
  public class Reviewer
    {
        [Key]
        public int ReviewerId { get; set; }
        public string ReviewerName { get; set; } = null!;
        [Required]
        public string ReviewerGender { get; set; } = null!;
        public string ReviewerBio { get; set; } = null!;
        [Required]
        public ICollection<MovieReview> MovieReviews { get; set; } = null!;
        public ICollection<ActorReview> ActorReviews { get; set; } = null!;

    }
}
