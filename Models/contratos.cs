using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria_NetApi.Models
{
    public class Contrato
    {
        [Key]
        [Column ("id")]
        [Display(Name = "Codigo")]        
        public int Id { get; set; }
        [Required]
        [Display(Name = "Fecha Inicio")]
        [DataType(DataType.Date)]
        public DateTime fe_ini { get; set; }
        [Required]
        [Display(Name = "Fecha Finalizacion")]
        [DataType(DataType.Date)]
        public DateTime fe_fin { get; set; }
        [Required]
        public int monto { get; set; }
        [Display(Name = "Inquilino")]
        public int id_inquilino { get; set; }

        [Display(Name = "Inmueble")]
        public int id_inmueble { get; set; }
        
        [ForeignKey(nameof(id_inquilino))]
        public Inquilino Inquilino { get; set; }

        [ForeignKey(nameof(id_inmueble))]
        public Inmueble Inmueble {get; set;}      
    }
}