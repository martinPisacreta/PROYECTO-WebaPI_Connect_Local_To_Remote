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
    public class MarcasController : ControllerBase
    {
        private readonly CarritoComprasContext _context;

        public MarcasController(CarritoComprasContext context)
        {
            _context = context;
        }

        // GET: api/Marcas
     
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marca>>> GetMarca()
        {
            var marca = await _context.Marca
                       //.AsEnumerable()
                       //.Where(x => x.FecUltModif.ToShortDateString() == DateTime.Now.ToShortDateString())
                       .ToListAsync();

            if (marca == null)
            {
                return NotFound();
            }

            return marca;
        }

        // GET: api/Marcas/5
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpGet("{id}")]
        public async Task<ActionResult<Marca>> GetMarca(int id)
        {
            var marca = await _context.Marca.FindAsync(id);

            if (marca == null)
            {
                return NotFound();
            }

            return marca;
        }

        // PUT: api/Marcas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarca(int id, Marca marca)
        {
            if (id != marca.IdTablaMarca)
            {
                return BadRequest();
            }

            _context.Entry(marca).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaExists(id))
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

        // POST: api/Marcas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpPost]
        public async Task<ActionResult<Marca>> PostMarca(Marca marca)
        {
            _context.Marca.Add(marca);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MarcaExists(marca.IdTablaMarca))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMarca", new { id = marca.IdTablaMarca }, marca);
        }

        // DELETE: api/Marcas/5
        [Authorize] // SOLO USUARIOS AUTENTICADOS
        [HttpDelete("{id}")]
        public async Task<ActionResult<Marca>> DeleteMarca(int id)
        {
            var marca = await _context.Marca.FindAsync(id);
            if (marca == null)
            {
                return NotFound();
            }

            _context.Marca.Remove(marca);
            await _context.SaveChangesAsync();

            return marca;
        }

        private bool MarcaExists(int id)
        {
            return _context.Marca.Any(e => e.IdTablaMarca == id);
        }
    }
}
