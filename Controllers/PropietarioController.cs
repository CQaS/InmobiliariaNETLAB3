using Inmobiliaria_NetApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria_NetApi.Controllers
{
    public class PropietarioController : Controller
    {
        private readonly ILogger<PropietarioController> _logger;
        private readonly RepositorioPropietario repositorioPropietario;
        private readonly RepositorioUsuario repositorioUsuario;
        private readonly RepositorioInmueble repoInmu;
        private readonly IConfiguration config;
        private readonly IWebHostEnvironment environment;
        public PropietarioController(ILogger<PropietarioController> logger, IConfiguration config, IWebHostEnvironment environment)
        {
            this.environment = environment;
            this.repositorioPropietario = new RepositorioPropietario(config);
            this.repositorioUsuario = new RepositorioUsuario(config);
            this.repoInmu = new RepositorioInmueble(config);
            this.config = config;
            _logger = logger;
        }

        // GET: 
        [Authorize]
        public IActionResult Index()
        {
            var lta = repositorioPropietario.obtener();
            ViewData[nameof(Propietario)] = lta;
            return View();
        }

        // GET: 
        [Authorize]
        public IActionResult Alta()
        {
            return View();
        }

        // POST: 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Alta(Propietario p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var prop = repositorioPropietario.ObtenerPorEmail(p.Email);
                    var user = repositorioUsuario.ObtenerPorEmail(p.Email);

                    if (user == null && prop == null)
                    {
                       p.Clave = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                       password: p.Clave,
                       salt: System.Text.Encoding.ASCII.GetBytes(config["Salt"]),
                       prf: KeyDerivationPrf.HMACSHA1,
                       iterationCount: 1000,
                       numBytesRequested: 256 / 8));

                       if(p.AvatarFile !=null)
                        {
                            string wwwPath = environment.WebRootPath;
                            string path = Path.Combine(wwwPath, "img/avatars/propietarios");
                            if(!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            //Path.GetFileName(u.AvatarFile.FileName);//este nombre se puede repetir
                            string fileName = "avatar_" + p.Email + Path.GetExtension(p.AvatarFile.FileName);
                            string pathCompleto = Path.Combine(path, fileName);
                            p.Avatar = Path.Combine("/img/avatars/propietarios", fileName);
                            using (FileStream stream = new FileStream(pathCompleto, FileMode.Create))
                            {
                                p.AvatarFile.CopyTo(stream);
                            }
                        }
                        else
                        {
                            p.Avatar = "/img/default.jpg";
                        }

                       repositorioPropietario.Alta(p);
                       TempData["Id"] = p.Id;
                       
                       return RedirectToAction(nameof(Index));

                    }
                    else
                    {
                        TempData["Error"] = "El Email ingresado ya se encuentra registrado en el sistema! ";
                        ViewBag.Error = TempData["Error"];
                        return View();
                    }
                }
                else
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrace = ex.StackTrace;
                return RedirectToAction("Index");
            }
        }

        // 
        [Authorize]
        public IActionResult Editar(int id)
        { 
            Propietario p = repositorioPropietario.Buscar(id);            
            return View(p);
        }

        // 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Editar(Propietario p)
        {
            
            try
            {
                Propietario propActual = repositorioPropietario.Buscar(p.Id);
                
                if(p.Clave !=null)
                {
                    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                            password: p.Clave,
                            salt: System.Text.Encoding.ASCII.GetBytes(config["Salt"]),
                            prf: KeyDerivationPrf.HMACSHA1,
                            iterationCount: 1000,
                            numBytesRequested: 256 / 8));
                        p.Clave = hashed;
                }
                else
                {
                    p.Clave = propActual.Clave;
                }

                if(p.AvatarFile !=null)
                {
                    string wwwPath = environment.WebRootPath;
                    string path = Path.Combine(wwwPath, "img/avatars/propietarios");
                    if(!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    //Path.GetFileName(u.AvatarFile.FileName);//este nombre se puede repetir
                    string fileName = "avatar_" + p.Email + Path.GetExtension(p.AvatarFile.FileName);
                    string pathCompleto = Path.Combine(path, fileName);
                    p.Avatar = Path.Combine("/img/avatars/propietarios", fileName);
                    using (FileStream stream = new FileStream(pathCompleto, FileMode.Create))
                    {
                        p.AvatarFile.CopyTo(stream);
                    }
                }
                else
                {
                    p.Avatar = propActual.Avatar;
                }

                repositorioPropietario.Editar(p);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(p);
            }
        }

        [Authorize]
        public IActionResult Detalles(int id)
        { 
            var lta = repoInmu.obtenerPorPropietario(id);
            ViewData[nameof(Inmueble)] = lta;
            Propietario p = repositorioPropietario.Buscar(id);            
            return View(p);
        }

        // GET
        [Authorize(Policy = "Administrador")]
        public IActionResult Delete(int id)
        {
            repositorioPropietario.Borrar(id);
            return RedirectToAction("Index");
        }

        // POST: /Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
