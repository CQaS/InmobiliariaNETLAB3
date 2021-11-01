using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria_NetApi.Models
{
    public class Inmueble
    {
        [Key]
        [Column ("id_Inmu")]
        [Display(Name = "Codigo")]
        public int Id_inmu { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        public String Direccion_in { get; set; }
        [Required]
        public String Uso { get; set; }
        [Required]
        public String Tipo { get; set; }
        [Required]
        public int ambientes { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public int precio { get; set; }
        public int Estado{get; set;}

        public int Disponible{get; set;}
        
        public String foto { get; set; }       
        [Display(Name = "Elige una Foto:")]
        [NotMapped]
        public IFormFile FotoFile{ get; set; }

        [Display(Name = "Dueño")]
        public int id_propietario { get; set; }
        [ForeignKey(nameof(id_propietario))]
        public Propietario Duenio { get; set; }
    }
}