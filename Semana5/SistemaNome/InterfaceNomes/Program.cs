using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NomeLibrary.Model;
using NomeLibrary.Controller;


namespace InterfaceNomes
{
    public class Program
    {
        static NameController nameController = new NameController();
        static void Main(string[] args)
        {

            var opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Nome");                             
                Console.WriteLine("2 - Listar Celulares");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirNome();
                        break;
                    case 2:
                        ListarNomes();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        public static void InserirNome()
        {
            Console.WriteLine("--Inserir Nome--");

            Console.WriteLine("Informe o Nome para listar");
            var nome = Console.ReadLine();
        }
        public static void ListarNomes()
        {
            nameController.GetNomes().ToList().ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
                       
        }
    }
}
