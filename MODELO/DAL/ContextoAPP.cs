using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ContextoAPP : DbContext
    {
        public DbSet<Archivo> Archivos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Entretenimiento> Entretenimientos { get; set; }
        public DbSet<RedSocial> RedesSociales { get; set; }
        public DbSet<MotorBusqueda> MotoresBusqueda { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public ContextoAPP() : base("BDEureK")
        {
            Database.SetInitializer<ContextoAPP>(new DropCreateDatabaseIfModelChanges<ContextoAPP>());

            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }
    }
}
