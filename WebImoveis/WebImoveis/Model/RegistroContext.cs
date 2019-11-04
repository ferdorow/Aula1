using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebImoveis.Model
{
    public class RegistroContext : DbContext
    {
        public RegistroContext(DbContextOptions<RegistroContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
    }

}