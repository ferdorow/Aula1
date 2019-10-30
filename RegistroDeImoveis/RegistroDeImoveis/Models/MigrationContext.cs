using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroDeImoveis.Models
{
    public class MigrationContext : DbContext
    {
        public virtual DbSet<Imovel> Imoveis { get; set; }
        public virtual DbSet<Proprietario> Proprietarios { get; set; }
    }
}