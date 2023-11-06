using API_Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly QlchXeMayVietTrungContext _dbcontext;
        public MenusController(QlchXeMayVietTrungContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        [HttpGet("getData")]
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


        [HttpPost("create")]
        public async Task<IActionResult> Create(Menu menu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dbcontext.Menus.Add(menu);
            await _dbcontext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(int id, Menu menu)
        {
            if (id != menu.MaMenu)
            {
                return BadRequest();
            }
            var detail = await _dbcontext.Menus.AsTracking().FirstOrDefaultAsync(x => x.MaMenu == id);
            if (detail == null)
            {
                throw new Exception("Không hợp lệ");
            }
            detail.TenMenu = menu.TenMenu;
            detail.MoTa = menu.MoTa;
            detail.TrangThai = menu.TrangThai;

            _dbcontext.Entry(detail).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
            return Ok();

        }


        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_dbcontext.Menus == null)
            {
                return BadRequest();
            }

            var data = await _dbcontext.Menus.FindAsync(id);
            _dbcontext.Menus.Remove(data);
            await _dbcontext.SaveChangesAsync();

            return Ok();
        }



        [HttpGet("search/{key}")]
        public async Task<IActionResult> Search(string key)
        {
            var data = await _dbcontext.Menus.Where(x => x.TenMenu.Contains(key) || x.MoTa.Contains(key)).ToListAsync();
            return Ok(data);
        }
    }
}
