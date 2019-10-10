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
        
        LocacaoContext contextDB = new LocacaoContext();

        //Iqueryable prepara e o GetLivros lista de fato
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
            contextDB.SaveChanges();
        }
        public bool AtualizarLivro(Livro item)
        {
            var findLivro = //Definimos uma variavel para o livro 
                contextDB //Usamos o banco de dados
                .Livros //Nossa tabela que tem os livros
                .FirstOrDefault //Buscamos em nossa tabela o livro
                (x => x.Id == item.Id); //Regra para realizar a busca
                       
            if (findLivro == null) 
                return false; 
            else
            {
                findLivro.DataAlteracao = DateTime.Now; 
            }
            
            contextDB.SaveChanges(); 

            return true; 
        }

    }
}
