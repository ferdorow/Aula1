using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBicicleta.Model
{
    public class BicicletaContextDB : DbContext
    {
        public DbSet<Bicicleta> Bicicletas { get; set; }
    }
}
