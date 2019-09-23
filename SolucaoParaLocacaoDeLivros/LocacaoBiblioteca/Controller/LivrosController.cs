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
        private int idCount = 0;
        /// <summary>
        /// Metodo construtor que prepara o terreno para ja iniciar  com livros pré cadastrados
        /// </summary>
        public LivrosController()
        {
            //criamos uma lista de livros em memoria
            ListadDeLivros = new List<Livro>();

            ListadDeLivros.Add(new Livro()
            {
                Nome = "Meu primeiro Livro",
                Id = idCount++
            });

            ListadDeLivros.Add(new Livro()
            {
                Nome = "Meu segundo Livro",
                Id = idCount++
            });
        }
        //Aqui crio uma propriedade para acessar a lista de livros disponiveis
        private List<Livro> ListadDeLivros { get; set; }

        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = idCount++;
            ListadDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListadDeLivros;
        }

    }
}
