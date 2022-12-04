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
    public class CondicionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CondicionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Condicions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condicion>>> GetCondicion()
        {
            return await _context.Condicion.ToListAsync();
        }

        // GET: api/Condicions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Condicion>> GetCondicion(int id)
        {
            var condicion = await _context.Condicion.FindAsync(id);

            if (condicion == null)
            {
                return NotFound();
            }

            return condicion;
        }

        // PUT: api/Condicions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCondicion(int id, Condicion condicion)
        {
            if (id != condicion.Id_Condicion)
            {
                return BadRequest();
            }

            _context.Entry(condicion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CondicionExists(id))
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

        // POST: api/Condicions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Condicion>> PostCondicion(Condicion condicion)
        {
            _context.Condicion.Add(condicion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCondicion", new { id = condicion.Id_Condicion }, condicion);
        }

        // DELETE: api/Condicions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCondicion(int id)
        {
            var condicion = await _context.Condicion.FindAsync(id);
            if (condicion == null)
            {
                return NotFound();
            }

            _context.Condicion.Remove(condicion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CondicionExists(int id)
        {
            return _context.Condicion.Any(e => e.Id_Condicion == id);
        }
    }
}
