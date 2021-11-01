using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Inmobiliaria_NetApi.Models;

namespace Inmobiliaria_NetApi.ApiController
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class inquilinosController : ControllerBase
    {
        private readonly InmobiliariaApiDbContext _context;

        public inquilinosController(InmobiliariaApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<InquilinoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var usuario = User.Identity.Name;
                //var res = _context.Inquilino.Select(x => new { x.Nombre, x.Apellido, x.Email }).SingleOrDefault(x => x.Email == inquilino);
                var res = await _context.Contrato
                            .Include(x => x.Inquilino)
                            .Include(e => e.Inmueble.Duenio)
                            .Where(e => e.Inmueble.Duenio.Email == usuario)
                            .Select(x => x.Inquilino).Distinct()
                            .ToListAsync();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<InquilinoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return NotFound();

            var res = await _context.Inquilinos.FirstOrDefaultAsync(x => x.Id == id);

            if (res != null)
            {
                return Ok(res);
            }
            else
            {
                return NotFound();
            }
        }


        // POST api/<InquilinoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Inquilino inquilino)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _context.Inquilinos.Add(inquilino);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction(nameof(Get), new { id = inquilino.Id }, inquilino);
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<InquilinoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Inquilino inquilino)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Inquilinos.Update(inquilino);
                    await _context.SaveChangesAsync();

                    return Ok(inquilino);
                }

                return BadRequest();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InquilinoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }
        private bool InquilinoExists(int id)
        {
            return _context.Inquilinos.Any(e => e.Id == id);
        }

        // DELETE api/<InquilinoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var p = _context.Inquilinos.Find(id);
                    if (p == null)
                        return NotFound();
                    _context.Inquilinos.Remove(p);
                    await _context.SaveChangesAsync();
                    
                    return Ok(p);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /* private bool InquilinoExists(int id)
        {
            return _context.Inquilinos.Any(e => e.Id == id);
        } */
    }
}
