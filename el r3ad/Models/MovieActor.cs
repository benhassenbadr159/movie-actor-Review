using System.ComponentModel.DataAnnotations.Schema;

namespace el_r3ad.models
{
    public class MovieActor

    {
        public int Id { get; set; }
        [ForeignKey("Movies")]
        public int MovieId { get; set; }
        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Movies Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
    