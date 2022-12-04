using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentasBienes.Context;
using SistemaVentasBienes.Models;

namespace SistemaVentasBienes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tipo_InmuebleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Tipo_InmuebleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tipo_Inmueble
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo_Inmueble>>> GetTipo_Inmueble()
        {
            return await _context.Tipo_Inmueble.ToListAsync();
        }

        // GET: api/Tipo_Inmueble/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tipo_Inmueble>> GetTipo_Inmueble(int id)
        {
            var tipo_Inmueble = await _context.Tipo_Inmueble.FindAsync(id);

            if (tipo_Inmueble == null)
            {
                return NotFound();
            }

            return tipo_Inmueble;
        }

        // PUT: api/Tipo_Inmueble/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo_Inmueble(int id, Tipo_Inmueble tipo_Inmueble)
        {
            if (id != tipo_Inmueble.Id_Tipo_Inmueble)
            {
                return BadRequest();
            }

            _context.Entry(tipo_Inmueble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_InmuebleExists(id))
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

        // POST: api/Tipo_Inmueble
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tipo_Inmueble>> PostTipo_Inmueble(Tipo_Inmueble tipo_Inmueble)
        {
            _context.Tipo_Inmueble.Add(tipo_Inmueble);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipo_Inmueble", new { id = tipo_Inmueble.Id_Tipo_Inmueble }, tipo_Inmueble);
        }

        // DELETE: api/Tipo_Inmueble/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipo_Inmueble(int id)
        {
            var tipo_Inmueble = await _context.Tipo_Inmueble.FindAsync(id);
            if (tipo_Inmueble == null)
            {
                return NotFound();
            }

            _context.Tipo_Inmueble.Remove(tipo_Inmueble);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Tipo_InmuebleExists(int id)
        {
            return _context.Tipo_Inmueble.Any(e => e.Id_Tipo_Inmueble == id);
        }
    }
}
