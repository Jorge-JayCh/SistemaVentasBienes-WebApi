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
    public class Forma_PagoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Forma_PagoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Forma_Pago
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Forma_Pago>>> GetForma_Pago()
        {
            return await _context.Forma_Pago.ToListAsync();
        }

        // GET: api/Forma_Pago/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Forma_Pago>> GetForma_Pago(int id)
        {
            var forma_Pago = await _context.Forma_Pago.FindAsync(id);

            if (forma_Pago == null)
            {
                return NotFound();
            }

            return forma_Pago;
        }

        // PUT: api/Forma_Pago/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForma_Pago(int id, Forma_Pago forma_Pago)
        {
            if (id != forma_Pago.Id_Forma_Pago)
            {
                return BadRequest();
            }

            _context.Entry(forma_Pago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Forma_PagoExists(id))
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

        // POST: api/Forma_Pago
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Forma_Pago>> PostForma_Pago(Forma_Pago forma_Pago)
        {
            _context.Forma_Pago.Add(forma_Pago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForma_Pago", new { id = forma_Pago.Id_Forma_Pago }, forma_Pago);
        }

        // DELETE: api/Forma_Pago/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForma_Pago(int id)
        {
            var forma_Pago = await _context.Forma_Pago.FindAsync(id);
            if (forma_Pago == null)
            {
                return NotFound();
            }

            _context.Forma_Pago.Remove(forma_Pago);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Forma_PagoExists(int id)
        {
            return _context.Forma_Pago.Any(e => e.Id_Forma_Pago == id);
        }
    }
}
