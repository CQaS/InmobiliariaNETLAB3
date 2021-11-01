using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Inmobiliaria_NetApi.Models
{
    public class Propietario
    {
        [Column ("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Dni { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Tel { get; set; }
        [Required]
        public string Email{get; set;}
        public string Avatar { get; set; }

		[Display(Name = "Avatar")]
		[NotMapped]
        public IFormFile AvatarFile{ get; set; }
        [Required]
        public string Clave{get; set;}        
    }
}