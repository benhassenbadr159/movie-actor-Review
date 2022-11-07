using System.ComponentModel.DataAnnotations.Schema;

namespace el_r3ad.models
{
    public class MovieReview
    {
        

        public int Id { get; set; }
        public string ReviewContent { get; set; } = null!;
        public int ReviewRating { get; set; } = 0;

        [ForeignKey("Movies")]
        public int MovieId { get; set; }
        public Movies Movie { get; set; }

        [ForeignKey("Reviewer")]
        public int reviewerId;
        public Reviewer Reviewer { get; set; } = null!;
        public ICollection<MovieReview> MovieReviews { get; set; } = null!;
    }
}
    