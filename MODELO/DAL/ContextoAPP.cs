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
        public DbSet<RedSocial> RedSocial { get; set; }
    }
}
