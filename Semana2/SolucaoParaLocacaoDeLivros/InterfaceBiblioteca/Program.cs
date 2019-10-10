using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {   //Instanciamos "Carregamos para a memoria nosso controlador dos livros
        static LivrosController livros = new LivrosController();

        static void Main(string[] args)

        {
            Console.WriteLine("*****SISTEMA DE LOCAÇÃO DE LIVRO 1.0*****");


            MostraMenuSistema();

            Console.ReadKey();

        }
        /// <summary>
        /// Mostra no console o menu disponivel do sistema
        /// </summary>
        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                               
                Console.Clear();
                Console.WriteLine("*****SISTEMA DE LOCAÇÃO DE LIVRO 1.0*****");
                Console.WriteLine("-------------------------------------\r\n");
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Atualizar Livro");
                Console.WriteLine("3 - Remover Livro");
                Console.WriteLine("4 - Listar");
                Console.WriteLine("0 - Sair");

                //Aqui vamos pegar o numero digitado
                menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
                //executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        AtualizarLivro();
                        break;
                    case 3:
                        RemoverLivroPorId();
                        break;
                    case 4:
                        MostrarLivros();
                        break;

                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                }

            }

        }


        private static void RemoverLivroPorId()
        {
            Console.Clear();
            Console.WriteLine("Remover um Livro pelo id no sistema");

            MostrarLivros();

            Console.WriteLine("Informe o ID para desativar o livro do sistema:");
            var livroId = int.Parse(Console.ReadLine());
            livros.RemoverLivroPorId(livroId);

            Console.WriteLine("Livro Removido com Sucesso!");
            Console.ReadKey();
        }

        /// <summary>
        /// /Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            Console.Clear();
            //identficamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro no sistema");
            //Informamos que para dar continuidade ele deve informar um livro
            Console.WriteLine("Nome do livro para cadastro");
            //obtemos essa informação do usuario
            var nomeDoLivro = Console.ReadLine();
            //*livrosController livros controle eh nosso "objet" em memoria
            //Com isso temos disponivel nele ferramentas que nos ajudam a realizar as tarefas
            //Como adicionar um item  a nossa lista de livros

            livros.AdicionarLivro(new Livro()
            {
                //Aqui atribuimos o nome que demos ao livro na propriedade do nosso livro
                //com o sinal de aoenas im "=" temos atribuição, passagem de valor
                Nome = nomeDoLivro
            });

            //Indico que finalizamos o processo de cadastro do livro, assim o usuario ja sabe
            //que o mesmo foi realizado  e sem erros
            Console.WriteLine("Livro cadastrado com sucesso");
            //Readkey apenas para que ele visualize esta informação
            Console.ReadKey();
        }

               

        private static void MostrarLivros()
        {
            Console.Clear();
            Console.WriteLine("--Lista de Livros--");

            livros.GetLivros()
                .ToList()
                .ForEach(x =>
                Console.WriteLine($"Id: {x.Id}, Nome: {x.Nome}"));
            Console.ReadKey();
        }
        

        public static void AtualizarLivro()
        {
            Console.Clear();
            //Apresentamos a tela em que estamos
            Console.WriteLine("--Atualizar Livros--");

            MostrarLivros();

            Console.WriteLine("Informe o Id para alteração de registro.");

            var livroId = int.Parse(Console.ReadLine());

            var livro = livros.GetLivros().FirstOrDefault(x => x.Id == livroId);



            if (livro == null)
            {
                Console.WriteLine("Id Informado inválido");
                Console.ReadKey();
                return;

            }

            Console.WriteLine("Informe o nome do livro");
            livro.Nome = Console.ReadLine();


            var resultado = livros.
                AtualizarLivro(livro);

            if (resultado)
                Console.WriteLine("Livro atualizado com sucesso");
            else
                Console.WriteLine("Erro ao atualizar livro");

            Console.ReadKey();
        }
    }
}











