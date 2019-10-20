using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
   public class PessoaController
    {
        //Realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();

               //Iqueryable> Aqui temos nossa primeira interface com a classe iqueruable essa classe contem
               //varias funcionalidades prontas para usar igual ao banco de dados com os selects
               //<Pessoa> Definimos o tipo que ira retornar
               //GetPessoas> damos um nome ao nosso metodo
        public IQueryable<Pessoa> GetPessoas()  
        {
            return contextDB.ListaDePessoas;   //retornamos nossa lista de pessoas
        }

        /// <summary>
        /// Metodo para adicionar Pessoa no bano de dados
        /// </summary>
        /// <param name="item">Item pessoa
        public void AddPessoa(Pessoa item)
        {
            contextDB.ListaDePessoas.Add(item); //Nosso banco de dados e nossa tabela de pessoas
                                                //adicionamos o item

            contextDB.SaveChanges();  //salvamos no banco
        }
    }
}
