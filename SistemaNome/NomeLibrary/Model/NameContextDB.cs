using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeLibrary.Model
{
    public class NameContextDB : DbContext
    {
        public DbSet<Name> Nome { get; set; }
    }
}
