using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosEntity.Model
{
    public class EntityContextDB: DbContext
    {
        public DbSet<Aluno> ListaDeAlunos { get; set; }
    }
}
