using Core.Entities;
using Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EnderecoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("enderecos")]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetEnderecos()
        {
            var enderecos = await _context.Enderecos.ToListAsync();
            return Ok(enderecos);
        }

        [HttpPost("endereco")]
        public async Task<ActionResult<Endereco>> PostEndereco(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEndereco", new { id = endereco.Id }, endereco);
        }

        [HttpDelete("endereco/{id}")]
        public async Task<ActionResult<Endereco>> DeleteEndereco(int id)
        {
            var endereco = await _context.Enderecos.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            _context.Enderecos.Remove(endereco);
            await _context.SaveChangesAsync();

            return endereco;
        }

        [HttpPut("endereco/{id}")]
        public async Task<IActionResult> PutEndereco(int id, Endereco endereco)
        {
            if (id != endereco.Id)
            {
                return BadRequest();
            }

            _context.Entry(endereco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
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

        private bool EnderecoExists(int id)
        {
            return _context.Enderecos.Any(e => e.Id == id);
        }
    }
}
