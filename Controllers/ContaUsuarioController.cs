using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaContaUsuario.Models;

namespace SistemaContaUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaUsuarioController : ControllerBase
    {
        private readonly ContaUsuarioContext _context;

        public ContaUsuarioController(ContaUsuarioContext context)
        {
            _context = context;
        }

        // GET: api/ContaUsuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaUsuario>>> GetContasUsuarios()
        {
          if (_context.ContasUsuarios == null)
          {
              return NotFound();
          }
            return await _context.ContasUsuarios.ToListAsync();
        }

        // GET: api/ContaUsuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaUsuario>> GetContaUsuario(long id)
        {
          if (_context.ContasUsuarios == null)
          {
              return NotFound();
          }
            var contaUsuario = await _context.ContasUsuarios.FindAsync(id);

            if (contaUsuario == null)
            {
                return NotFound();
            }

            return contaUsuario;
        }

        // PUT: api/ContaUsuario/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContaUsuario(long id, ContaUsuario contaUsuario)
        {
            if (id != contaUsuario.id)
            {
                return BadRequest();
            }

            _context.Entry(contaUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaUsuarioExists(id))
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

        // POST: api/ContaUsuario
        [HttpPost]
        public async Task<ActionResult<ContaUsuario>> PostContaUsuario(ContaUsuario contaUsuario)
        {
          if (_context.ContasUsuarios == null)
          {
              return Problem("Entity set 'ContaUsuarioContext.ContasUsuarios'  is null.");
          }
            _context.ContasUsuarios.Add(contaUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContaUsuario", new { id = contaUsuario.id }, contaUsuario);
        }

        // DELETE: api/ContaUsuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContaUsuario(long id)
        {
            if (_context.ContasUsuarios == null)
            {
                return NotFound();
            }
            var contaUsuario = await _context.ContasUsuarios.FindAsync(id);
            if (contaUsuario == null)
            {
                return NotFound();
            }

            _context.ContasUsuarios.Remove(contaUsuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContaUsuarioExists(long id)
        {
            return (_context.ContasUsuarios?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
