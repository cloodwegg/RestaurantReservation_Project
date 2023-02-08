using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation_Project.Server.Data;
using RestaurantReservation_Project.Server.IRepository;
using RestaurantReservation_Project.Shared.Domain;

namespace RestaurantReservation_Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //refactored
        //public RatingsController(ApplicationDbContext context)
        public RatingsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Ratings
        [HttpGet]
        //Refactored 
        //public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
        public async Task<IActionResult> GetRatings()
        {
            //return await _context.Ratings.ToListAsync();
            var Ratings = await _unitOfWork.Ratings.GetAll(includes: q => q.Include(x => x.Reservation));
            return Ok(Ratings);
        }

        // GET: api/Ratings/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Rating>> GetRating(int id)
        public async Task<IActionResult> GetRating(int id)
        {
            //Refactored
            //var rating = await _context.Ratings.FindAsync(id);
            var Rating = await _unitOfWork.Ratings.Get(q => q.Id == id);

            if (Rating == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(Rating);
        }

        // PUT: api/Ratings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, Rating Rating)
        {
            if (id != Rating.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(rating).State = EntityState.Modified;
            _unitOfWork.Ratings.Update(Rating);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!RatingExists(id))
                if (!await RatingExists(id))
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

        // POST: api/Ratings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rating>> PostRating(Rating Rating)
        {
            //Refactored
            //_context.Ratings.Add(rating);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Ratings.Insert(Rating);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRating", new { id = Rating.Id }, Rating);
        }

        // DELETE: api/Ratings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            //Refactored
            //var rating = await _context.Ratings.FindAsync(id);
            var Rating = await _unitOfWork.Ratings.Get(q => q.Id == id);
            if (Rating == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Ratings.Remove(rating);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Ratings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool RatingExists(int id)
        private async Task<bool> RatingExists(int id)
        {
            //Refactored
            //return _context.Ratings.Any(e => e.Id == id);
            var Rating = await _unitOfWork.Ratings.Get(q => q.Id == id);
            return Rating != null;
        }
    }
}
