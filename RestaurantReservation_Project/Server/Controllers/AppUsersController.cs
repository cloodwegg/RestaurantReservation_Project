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
    public class AppUsersController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public AppUsersController(ApplicationDbContext context)
        public AppUsersController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/AppUsers
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers()
        public async Task<IActionResult> GetAppUsers()
        {
            //Refactored
            //return await _context.AppUsers.ToListAsync();
            var appusers = await _unitOfWork.AppUsers.GetAll();
            return Ok(appusers);
        }

        // GET: api/AppUsers/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<AppUser>> GetAppUser(int id)
        public async Task<IActionResult> GetAppUser(int id)
        {
            //Refactored
            //var appUser = await _context.AppUsers.FindAsync(id);
            var appuser = await _unitOfWork.AppUsers.Get(q => q.Id == id);

            if (appuser == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(appuser);
        }

        // PUT: api/AppUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(int id, AppUser appuser)
        {
            if (id != appuser.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(appUser).State = EntityState.Modified;
            _unitOfWork.AppUsers.Update(appuser);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!AppUserExists(id))
                if (!await AppUserExists(id))
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

        // POST: api/AppUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppUser>> PostAppUser(AppUser appuser)
        {
            //Refactored
            //_context.AppUsers.Add(appUser);
            //await _context.SaveChangesAsync();
            await _unitOfWork.AppUsers.Insert(appuser);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAppUser", new { id = appuser.Id }, appuser);
        }

        // DELETE: api/AppUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            //Refactored
            //var appUser = await _context.AppUsers.FindAsync(id);
            var appuser = await _unitOfWork.AppUsers.Get(q => q.Id == id); 
            if (appuser == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.AppUsers.Remove(appUser);
            //await _context.SaveChangesAsync();
            await _unitOfWork.AppUsers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool AppUserExists(int id)
        private async Task<bool> AppUserExists(int id)
        {
            //Refactored
            //return _context.AppUsers.Any(e => e.Id == id);
            var appuser = await _unitOfWork.AppUsers.Get(q => q.Id == id);
            return appuser != null;
        }
    }
}
