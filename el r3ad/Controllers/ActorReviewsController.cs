using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using el_r3ad.data;
using el_r3ad.models;

namespace el_r3ad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorReviewsController : ControllerBase
    {
        private readonly Datacontext _context;

        public ActorReviewsController(Datacontext context)
        {
            _context = context;
        }

        // GET: api/ActorReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActorReview>>> GetActorReviews()
        {
            return await _context.ActorReviews.ToListAsync();
        }

        // GET: api/ActorReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActorReview>> GetActorReview(int id)
        {
            var actorReview = await _context.ActorReviews.FindAsync(id);

            if (actorReview == null)
            {
                return NotFound();
            }

            return actorReview;
        }

        // PUT: api/ActorReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActorReview(int id, ActorReview actorReview)
        {
            if (id != actorReview.Id)
            {
                return BadRequest();
            }

            _context.Entry(actorReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActorReviewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ActorReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ActorReview>> PostActorReview(ActorReview actorReview)
        {
            _context.ActorReviews.Add(actorReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActorReview", new { id = actorReview.Id }, actorReview);
        }

        // DELETE: api/ActorReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActorReview(int id)
        {
            var actorReview = await _context.ActorReviews.FindAsync(id);
            if (actorReview == null)
            {
                return NotFound();
            }

            _context.ActorReviews.Remove(actorReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActorReviewExists(int id)
        {
            return _context.ActorReviews.Any(e => e.Id == id);
        }
    }
}
