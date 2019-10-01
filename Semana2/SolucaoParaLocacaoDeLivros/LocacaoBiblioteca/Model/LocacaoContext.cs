using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        //Propriedade que armazena o ID dos livros adicionado ao sistema
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;

        /// <summary>
        /// Metodo construtor que prepara a classe LocacaoContext
        /// </summary>
        public LocacaoContext()
        {
            //criamos uma lista de livros em memoria
            ListaDeLivros = new List<Livro>();
            //criamos uma lista de usuarios em memoria
            ListaDeUsuarios = new List<Usuario>();

            //adicionamos os livros
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Meu primeiro Livro",
                Id = IdContadorLivros++
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Meu segundo Livro",
                Id = IdContadorLivros++
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Meu terceiro Livro",
                Id = IdContadorLivros++
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Meu quarto Livro",
                Id = IdContadorLivros++
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "O Guia do Mochileiro das Galaxias",
                Id = IdContadorLivros++
            });
            


            //adicionamos o usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"
            });




        }

        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
    }
}
