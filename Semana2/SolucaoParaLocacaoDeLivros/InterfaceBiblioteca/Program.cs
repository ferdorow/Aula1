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
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            while (!RealizarLoginSistema())
                Console.WriteLine("Login e senha inválidos");

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
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
                Console.WriteLine("1 - Listar Usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Cadastrar Usuario");
                Console.WriteLine("5 - Remover Usuario");
                Console.WriteLine("6 - Remover Livro");
                Console.WriteLine("7 - Trocar Usuário");
                Console.WriteLine("0 - Sair");

                //Aqui vamos pegar o numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        //Realiza a chamada do menu de listagem do usuario
                        MostrarUsuarios();
                        break;
                    case 2:
                        ////Realiza a chamada do menu de listagem do livro
                        MostrarLivros();
                        break;
                    case 3:
                        ////adiciona um livro a lista
                        AdicionarLivro();
                        break;
                    case 4:
                        AdicionarUsuario();
                        break;
                    case 5:
                        RemoverUsuarioPorId();
                        break;
                    case 6:
                        RemoverLivroPorId ();
                        break;
                    case 7:
                        while (!RealizarLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;
                    case 0: return;
                    default:
                        break;
                }

            }
            //Aqui vamos pegar numero digitado
            //Executar proxima funcao
        }
        private static void RemoverUsuarioPorId()
        {
            Console.WriteLine("Remover um usuario pelo id no sistema");
            ///Metodo que mostra os usuarios criados anteriormente
            MostrarUsuarios();

            Console.WriteLine("Informe o ID para desativar do sistema");
            var usuarioID = int.Parse(Console.ReadLine());

            //aqui chamamos RemoverUsuariosID da nossa classe que controla os usuarios do sistema
            usuarioController.RemoverUsuarioPorId(usuarioID);

            ///Informamos que o usuario foi desativado com sucesso
            Console.WriteLine("Usuario Removido com Sucesso!");
            Console.ReadKey();
            
        }

        private static void RemoverLivroPorId()
        {
            Console.WriteLine("Remover um Livro pelo id no sistema");

            MostrarLivros();

            Console.WriteLine("Informe o ID para desativar o livro do sistema:");
            var livroId = int.Parse(Console.ReadLine());
            livroController.RemoverLivroPorId(livroId);

            Console.WriteLine("Livro Removido com Sucesso!");
            Console.ReadKey();
        }

        /// <summary>
        /// /Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
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


        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do 
        /// sistema como solicitaçao de login e senha pelo console assim como as
        /// respectivas validções que o mesmo precisa pra entrar no sistema
        ///<summary
        ///<returns> Retorna verdadeiro quando o login e senha informados
        /// estiverem corretos</returns> 
        private static bool RealizarLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha");
            var senhaDoUsuario = Console.ReadLine();

            // UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;


            return usuarioController.LoginSistema(usuario);

        }
        private static void MostrarLivros()
        {
            Console.WriteLine("--Mostrar Livro--");

            livros.GetLivros() 
                .ToList<Livro>() 
                .ForEach(x => 
                Console.WriteLine($"Id: {x.Id}, Nome: {x.Nome}"));
        }
        private static void MostrarUsuarios()
        {
            usuarioController.RetornaListaDeUsuario().ForEach(item => Console.WriteLine($" id {item.Id} Usuário: {item.Login}"));
            Console.ReadKey();
        }
       

            public static void AtualizarLivro()
            {
                //Apresentamos a tela em que estamos
                Console.WriteLine("--Atualizar Livros--");

            MostrarLivros();
                            
                Console.WriteLine("Informe o Id para alteração de registro.");
                
                var livroId = int.Parse(Console.ReadLine());
                            
                var livro = livros //Nossa controller
                    .GetLivros() //Obtemos os celulares
                    .FirstOrDefault(x => x.Id == livroId); //Laço de repetição para mostrarcada celular


                if (livro == null)
                {
                    Console.WriteLine("Id Informado inválido");
                    return;
                }

                Console.WriteLine("Informe a Marca do celular");
                livro.Nome = Console.ReadLine();
                         

                var resultado = livros.
                    AtualizarLivro(livro);

                if (resultado)
                    Console.WriteLine("Livro atualizado com sucesso");
                else
                    Console.WriteLine("Erro ao atualizar livro");
            }
        }
    }
}










