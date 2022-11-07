using System.ComponentModel.DataAnnotations.Schema;

namespace el_r3ad.models
{
    public class ActorReview
    {
        public int Id { get; set; }
        public string? ReviewContent { get; set; }
        public int? ReviewRating { get; set; }
        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        [ForeignKey("Reviewer")]
        public int ReviewerId { get; set; }
        public Reviewer Reviewer { get; set; }
        public ICollection<ActorReview> ActorReviews { get; set; } = null!; 
    }
}
