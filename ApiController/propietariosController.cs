using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Inmobiliaria_NetApi.Models;

namespace Inmobiliaria_NetApi.ApiController
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class propietariosController : ControllerBase
    {
        private readonly InmobiliariaApiDbContext _context;
        private readonly IConfiguration config;

        public propietariosController(InmobiliariaApiDbContext context, IConfiguration config)
        {
            _context = context;
            this.config = config;
        }

        // GET: api/propietarios
        [HttpGet]
        public async Task<ActionResult<Propietario>> Get()
        {
            try
            {
                var usuario = User.Identity.Name;

                return await _context.Propietarios.SingleOrDefaultAsync(x => x.Email == usuario);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    

        // GET api/<PropietarioController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var usuario = User.Identity.Name;

                if (id <= 0)
                    return NotFound();

                var res = await _context.Propietarios.SingleOrDefaultAsync(x => x.Id == id && x.Email == usuario);
                if (res != null)
                    return Ok(res);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<PropietarioController>/5
        [HttpPost]
        public async Task<ActionResult> Post([FromForm] Propietario propietario)
        {
            
            try
            {
               
                var res = await _context.Propietarios.FirstOrDefaultAsync(x => x.Email == propietario.Email);

                if ((ModelState.IsValid )&&(res != null))
                {
                    _context.Propietarios.Update(propietario);
                    await _context.SaveChangesAsync();
                    
                    return Ok(propietario);
                }

                return BadRequest();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropietarioExists(propietario.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


        }
        // PUT api/<PropietarioController>/
        [HttpPut]
        public async Task<IActionResult> Put(Propietario propietario)
        {
            try
            {               
                var usuario = User.Identity.Name;
                var res = _context.Propietarios.AsNoTracking()
                                .FirstOrDefault(x => x.Email == usuario  && x.Email == propietario.Email);
                
                if ((ModelState.IsValid) && (res != null))
                {
                    _context.Propietarios.Update(propietario);
                    await _context.SaveChangesAsync();
                    
                    var cambios = _context.Propietarios.AsNoTracking()
                                .FirstOrDefault(x => x.Email == usuario  && x.Email == propietario.Email);
                
                    return Ok(cambios);
                }

                return BadRequest();
            }
            catch (DbUpdateConcurrencyException) 
            {
                if (!PropietarioExists(propietario.Id))
                {
                    return NotFound();
                }
                else 
                {
                    throw;
                }
            }

            
        }

        private bool PropietarioExists(int id)
        {
            return _context.Propietarios.Any(e=>e.Id == id);
        }

        // DELETE api/<PropietarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    var p = await _context.Propietarios.FindAsync(id);
                    if (p == null)
                    {
                        return NotFound();
                    }

                    _context.Propietarios.Remove(p);
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


        // POST api/<controller>/5
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromForm]LoginView loginView)
        {
            try
            {
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: loginView.Clave,
                    salt: System.Text.Encoding.ASCII.GetBytes(config["Salt"]),
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 1000,
                    numBytesRequested: 256 / 8));
                
                var p = await _context.Propietarios.FirstOrDefaultAsync(x => x.Email == loginView.Usuario);                
                if (p == null || p.Clave != hashed)
                {
                    return BadRequest("Nombre de usuario o clave incorrecta");
                }
                else
                {                    
                    var key = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(config["TokenAuthentication:SecretKey"]));
                    var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, p.Email),
                        new Claim("FullName", p.Nombre),
                        new Claim(ClaimTypes.Role, "Propietario"),
                    };

                    var token = new JwtSecurityToken
                    (
                        issuer: config["TokenAuthentication:Issuer"],
                        audience: config["TokenAuthentication:Audience"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(300),
                        signingCredentials: credenciales
                    );
                    
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
