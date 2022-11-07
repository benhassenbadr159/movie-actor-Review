using el_r3ad.models;
using Microsoft.EntityFrameworkCore;

namespace el_r3ad.data
{
    public class Datacontext: DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {

        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; } 
        public DbSet<MovieActor> MovieActor { get; set; }
        public DbSet<ActorReview> ActorReviews { get; set; }
        public DbSet<MovieReview> MovieReviews { get; set; }
        
        
    }
}

 