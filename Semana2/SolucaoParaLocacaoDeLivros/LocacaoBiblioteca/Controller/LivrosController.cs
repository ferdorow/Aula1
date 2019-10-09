using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController

    {

        /// <summary>
        /// Metodo construtor que prepara o terreno para ja iniciar  com livros pré cadastrados
        /// </summary>
        LocacaoContext contextDB = new LocacaoContext();

        public IQueryable<Livro> GetLivros()
        {
            return contextDB 
                .Livros 
                .Where(x => x.Ativo == true); 
        }


        public void AdicionarLivro(Livro item)
        {
            contextDB.Livros.Add(item); 
            contextDB.SaveChanges(); 
            
        }
        
        public void RemoverLivroPorId(int identificadoID)
        {
            
            var livro = contextDB.Livros.FirstOrDefault(x => x.Id == identificadoID);
                if (livro != null)
                livro.Ativo = false;
        }
        public bool AtualizarLivro(Livro item)
        {
            var Livro = //Definimos uma variavel para o livro
                contextDB //Usamos o banco de dados
                .Livros //Nossa tabela que tem os livros
                .FirstOrDefault //Buscamos em nossa tabela o livro
                (x => x.Id == item.Id); //Regra para realizar a busca
                       
            if (Livro == null) 
                return false; 
            else
            {                
                Livro.DataAlteracao = DateTime.Now; 
            }
            
            contextDB.SaveChanges(); 

            return true; 
        }

    }
}
