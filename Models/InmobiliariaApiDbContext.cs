using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_NetApi.Models
{
    public class InmobiliariaApiDbContext : DbContext
    {
        public InmobiliariaApiDbContext(DbContextOptions<InmobiliariaApiDbContext> options)
        :base (options){}
        
        
        public DbSet<Propietario> Propietarios{get; set;}
        //........<nomb en clase>..nomb en base
        public DbSet<Inmueble> Inmueble{get; set;}
        public DbSet<Contrato> Contrato{get; set;}
        public DbSet<Inquilino> Inquilinos{get; set;}
        public DbSet<Pago> Pagos{get; set;}
    }
}