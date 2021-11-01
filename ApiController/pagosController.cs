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
    public class pagosController : ControllerBase
    {
        private readonly InmobiliariaApiDbContext _context;

        public pagosController(InmobiliariaApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<PagoController>
        [HttpGet]
        public async Task<ActionResult<Pago>> Get()
        {
            try
            {
                var usuario = User.Identity.Name;
                var res = await _context.Pagos
                                        .Include(e => e.Contrato)
                                        .Where(e => e.Contrato.Inmueble.Duenio.Email == usuario)
                                        .Select(x => new 
                                        { 
                                           x.Id, x.Num_Pago, x.Fecha, x.Importe, x.ContratoId
                                        })
                                        .ToListAsync();

                                        /*
                        var pagos = await applicationDbContext.Pago
                                                .Include(x=>x.Contrato)
                                                .Where(x => x.ContratoId == id)
                                                .ToListAsync();
                                        */

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<PagoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {         
            try
            {
                var usuario = User.Identity.Name;
                var res = await _context.Pagos
                                    .Include(e => e.Contrato)
                                    .Where(e => e.Contrato.Inmueble.Duenio.Email == usuario && e.ContratoId == id)
                                    .Select(x => new 
                                    { 
                                        x.ContratoId, x.Num_Pago, x.Fecha, x.Importe 
                                    })
                                    .ToListAsync();

                if(res != null)
                {
                   return Ok(res); 
                }

                return BadRequest();
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<PagoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Pago pago)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = User.Identity.Name;
                    pago.ContratoId = _context.Contrato.FirstOrDefault(e => e.Inmueble.Duenio.Email == usuario).Id;
                    _context.Pagos.Add(pago);
                    await _context.SaveChangesAsync();
                    return CreatedAtAction(nameof(Get), new { id = pago.Id }, pago);
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
    }

    // PUT api/<PagoController>/5
    [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Pago pago)
        {
            try
            {
                var usuario = User.Identity.Name;
                                        
                if (ModelState.IsValid)
                {
                    pago.Id = id;
                    _context.Pagos.Update(pago);
                    await _context.SaveChangesAsync();

                    var cambios = await _context.Pagos
                                    .Include(e => e.Contrato)
                                    .Where(e => e.Contrato.Inmueble.Duenio.Email == usuario 
                                            && e.Id == id
                                    )
                                    .Select(x => new 
                                    { 
                                        x.Num_Pago, x.Fecha, x.Importe 
                                    })
                                    .ToListAsync();

                    return Ok(cambios);
                }
                
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<PagoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
