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
    {
        static LivrosController livroController = new LivrosController();

        static UsuarioController usuarioController = new UsuarioController();
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
            Console.Clear();
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
            Console.WriteLine("1 - Listar Usuários");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("3 - Cadastrar Livro");
            Console.WriteLine("4 - Fazer Logoff");
            Console.WriteLine("0 - Sair");

            //Aqui vamos pegar o numero digitado
            var menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
            //executar proxima funcao
            switch (menuEscolhido)
            {
                case 1:
                    MostrarUsuarios();
                    break;
                case 2:
                    MostrarLivros();                                        
                    break;
                case 3:
                    break;
                case 4:
                    while (!RealizarLoginSistema())
                        Console.WriteLine("Login e senha inválidos");
                    break;
                case 0: return;
                default:
                    break;
            }


            //Aqui vamos pegar numero digitado
            //Executar proxima funcao
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

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;
            usuario.Id = 003;

            return usuarioController.LoginSistema(usuario);

        }
        private static void MostrarLivros()
        {
            livroController.Livros.ForEach(item => Console.WriteLine($"Nome do livor: {item.Nome}"));
            Console.ReadKey();
        }
        private static void MostrarUsuarios()
        {
            usuarioController.Usuario.ForEach(item => Console.WriteLine($"Usuário: {item.Login}"));
            Console.ReadKey();
        }
    }
}
           



            





