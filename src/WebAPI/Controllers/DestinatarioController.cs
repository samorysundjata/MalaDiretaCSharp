using Core.Entities;
using Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DestinatarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DestinatarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("destinatarios")]
        public async Task<ActionResult<IEnumerable<Destinatario>>> GetDestinatarios()
        {
            return await _context.Destinatarios.ToListAsync();
        }

        [HttpGet("destinatario/{id}")]
        public async Task<ActionResult<Destinatario>> GetDestinatario(int id)
        {
            var destinatario = await _context.Destinatarios.FindAsync(id);

            if (destinatario == null)
            {
                return NotFound();
            }

            return destinatario;
        }

        [HttpPost("destinatario")]
        public async Task<ActionResult<Destinatario>> PostDestinatario(Destinatario destinatario)
        {
            _context.Destinatarios.Add(destinatario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDestinatario), new { id = destinatario.Id }, destinatario);
        }

        [HttpPut("destinatario/{id}")]
        public async Task<IActionResult> PutDestinatario(int id, Destinatario destinatario)
        {
            if (id != destinatario.Id)
            {
                return BadRequest();
            }

            _context.Entry(destinatario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinatarioExists(id))
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

        [HttpDelete("destinatario/{id}")]
        public async Task<IActionResult> DeleteDestinatario(int id)
        {
            var destinatario = await _context.Destinatarios.FindAsync(id);
            if (destinatario == null)
            {
                return NotFound("Destinatario não encontrado");
            }

            _context.Destinatarios.Remove(destinatario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinatarioExists(int id)
        {
            return _context.Destinatarios.Any(e => e.Id == id);
        }
    }
}
