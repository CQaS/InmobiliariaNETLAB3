using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria_NetApi.Models
{
    public class Pago
    {
        [Key]
        [Column ("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "N° Pago")]
        [Required]
        public int Num_Pago { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Importe { get; set; }
        
        [Display(Name = "Contrato Nro.")]
        public int ContratoId { get; set; }

        [ForeignKey(nameof(ContratoId))]
        public Contrato Contrato { get; set; }       
        public Inquilino inquilino { get; set; }
        public Inmueble inmueble { get; set; }
        
    }
}