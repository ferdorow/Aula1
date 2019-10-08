using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Deixamos nossa classe public
    public class CervejaContextDB : DbContext 
        //Herdamos nossa classe DbCOntext que faz  toda a parte do banco de dados
    {
        //Definimos nossa tabela (Cerveja) dentro do banco de dados 
        //DbSet seta a tabela, sem ele não é tabela
        public DbSet<Cerveja> Cervejas { get; set; }
    }
}
