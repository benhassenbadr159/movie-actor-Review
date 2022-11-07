using System.ComponentModel.DataAnnotations;

namespace el_r3ad.models
{
    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } = null!;
        public string? Genre { get; set; }
        public int? Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public string? Notes { get; set; }
        public ICollection<MovieReview> Reviews { get; set; }
        public Producer producer { get; set; }
        public ICollection<MovieActor> MovieActor { get; set; }

    }
}
