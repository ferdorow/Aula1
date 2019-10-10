using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext : DbContext
    {      
        //Criei a 'lista' de livros no Banco de dados, em DbSet e dei o nome Livros
        public DbSet<Livro> Livros { get; set; }
        
    }
}
