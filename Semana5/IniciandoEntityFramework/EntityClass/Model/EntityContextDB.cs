using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : DbContext  //DbContext classe pronta que contem todos os processos de conexão
                                              //com o banco de dados listagem das tableas 
                                              //seleção das informações
    {
        public DbSet<Pessoa> ListaDePessoas { get; set; }  //DbSet> palavra reservada para o Entity que indica que vamos definir 
                                                           //uma tabela do nosso banco de dados
                                                           //Pessoa> aqui definimos nossa tabela  pessoa ou seja especificamos qual 
                                                           //de nossas classes será uma referencia de uma tabela no banco de dados
                                                           //ele vai ao banco com nome que definimos em nossa classe
                                                           //ListaDePessoas{get;set;} > nesta parte liberamos a tabela para acessar
    }
}
