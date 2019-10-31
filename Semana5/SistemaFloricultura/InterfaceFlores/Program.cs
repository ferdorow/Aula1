using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoFlores.Model;
using CatalogoFlores.Controller;


namespace InterfaceFlores
{
    class Program
    {
        static FloresController floresController = new FloresController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.WriteLine("--------Menu Floricultura--------\r\n");
                Console.WriteLine("1 - Inserir Flor para cadastro");
                Console.WriteLine("2 - Listar Flores");
                Console.WriteLine("3 - Listar Flores de Forma decrescente");
                Console.WriteLine("4 - Listar Flores Pela quantidade");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        InserirNome();
                        break;
                    case 2:
                        Console.Clear();
                        ListarFlores();
                        break;
                    case 3:
                        Console.Clear(); 
                        OrdenarFlores();
                        break;
                    case 4:
                        Console.Clear();
                        QuantidadeTotalDeFlores();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;

                }
                Console.WriteLine(" \r\n Pressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        public static void ListarFlores()
        {
            floresController.GetFlores().ToList().ForEach(x => Console.WriteLine($" Id: {x.Id} -- Nome: {x.Nome} -- Quantidade: {x.Quantidade}"));
            Console.ReadKey();

        }
        public static void InserirNome()
        {
            Console.WriteLine("---Cadastrar Flor---");

            Console.WriteLine("Informe a Flor para listar");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe Quantidade de flores para listar");
            var quantidade = int.Parse(Console.ReadLine());
            floresController.InserirNome(new Flor()
            {
                Nome = nome,
                Quantidade = quantidade

            });

            if (nome != null)
                Console.WriteLine("Flor cadastrada com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar flor");
        }
        public static void OrdenarFlores()
        {
            var flor = floresController.GetFlores();
            flor.OrderByDescending(p => p.Quantidade).ToList<Flor>().ForEach(x => Console.WriteLine($"ID: {x.Id}  Nome: {x.Nome} Quantidade: {x.Quantidade} "));
        }
        public static void QuantidadeTotalDeFlores()
        {
            Console.WriteLine($"A Quantidade Total de Flores Cadastrada é: {floresController.GetFlores().Sum(p => p.Quantidade)}");
        }
    }
}
