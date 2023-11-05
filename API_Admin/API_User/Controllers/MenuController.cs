using API_Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly QlchXeMayVietTrungContext _dbcontext;
        public MenuController (QlchXeMayVietTrungContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        
        [HttpGet]
        public async Task<IActionResult> getalldata()
        {
            var data = await _dbcontext.Menus.ToListAsync();
            return Ok(data);
        }


        [HttpGet("getData/{id}")]
        public async Task<IActionResult> getdatabyID(int id)
        {
            var data = await _dbcontext.Menus.FindAsync(id);
            return Ok(data);
        }


        [HttpPost("Menus/create")]
        public async Task<IActionResult> Create(Menu menu)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dbcontext .Menus.Add(menu);
            await _dbcontext.SaveChangesAsync();
            return Ok();
        }
    }
}
