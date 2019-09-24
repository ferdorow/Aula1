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

        //Aqui crio uma propriedade para acessar a lista de livros disponiveis


        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = contextDB.IdContadorLivros++;
            contextDB.ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            //retorna agora somente a lista de livros ativos com a expressão "Where(x => x.Ativo)"
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        /// <summary>
        /// Metoodo para desativar o registro de livro pelo Id
        /// </summary>
        /// <param name="identificadoID">Id do livro a ser desativado
        public void RemoverLivroPorId(int identificadoID)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadoID);
            //Tratamento do valor quando ele não encontrar um livro com ID
            if (livro != null)
                livro.Ativo = false;
        }
    }
}
