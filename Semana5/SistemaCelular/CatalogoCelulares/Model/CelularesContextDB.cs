using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Public passo deixar publica
    public class CelularesContextDB
        : //Definimmos nossa herança
        DbContext  //Aqui definimos que vamos herdar toda a caixa de 
                   //ferramenteas do Entity Framework
    {
        //Definimos nossa primeira tabela no bando de dados
        public DbSet<Usuario> Usuarios { get; set; }
        //Definimos nossa tabela de celulares no bando de dados
        public DbSet<Celular> Celulares { get; set; }
    }

}
