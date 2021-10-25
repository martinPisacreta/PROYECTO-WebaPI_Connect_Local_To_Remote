using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliasController : ControllerBase
    {
        private readonly CarritoComprasContext _context;

        public FamiliasController(CarritoComprasContext context)
        {
            _context = context;
        }

        // GET: api/Familias
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Familia>>> GetFamilia()
        {
            var familia = await _context.Familia
                         //.AsEnumerable()
                         //.Where(x => x.FecUltModif.ToShortDateString() == DateTime.Now.ToShortDateString())
                         .ToListAsync();

            if (familia == null)
            {
                return NotFound();
            }

            return familia;
        }

        // GET: api/Familias/5
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpGet("{id}")]
        public async Task<ActionResult<Familia>> GetFamilia(int id)
        {
            var familia = await _context.Familia.FindAsync(id);

            if (familia == null)
            {
                return NotFound();
            }

            return familia;
        }

        // PUT: api/Familias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamilia(int id, Familia familia)
        {
            if (id != familia.IdTablaFamilia)
            {
                return BadRequest();
            }

            _context.Entry(familia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamiliaExists(id))
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

        // POST: api/Familias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpPost]
        public async Task<ActionResult<Familia>> PostFamilia(Familia familia)
        {
            _context.Familia.Add(familia);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FamiliaExists(familia.IdTablaFamilia))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFamilia", new { id = familia.IdTablaFamilia }, familia);
        }

        // DELETE: api/Familias/5
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpDelete("{id}")]
        public async Task<ActionResult<Familia>> DeleteFamilia(int id)
        {
            var familia = await _context.Familia.FindAsync(id);
            if (familia == null)
            {
                return NotFound();
            }

            _context.Familia.Remove(familia);
            await _context.SaveChangesAsync();

            return familia;
        }

        private bool FamiliaExists(int id)
        {
            return _context.Familia.Any(e => e.IdTablaFamilia == id);
        }
    }
}
