using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    // 1 - Colocar console app para startar o projeto
    // 2 - Adicionar referencia CatalogoCelulares
    // 3 - Adicionar Entity em nosso projeto
    // 4 - Adicionar using ao nosso projeto Model, Controller
   
    class Program
    {
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //Definimos uma opção de menu inicial
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Atualizar Celular");
                Console.WriteLine("3 - Remover Celular");
                Console.WriteLine("4 - Listar Celulares");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        AtualizarCelular();
                        break;
                    case 3:
                        RemoverCelular();
                        break;
                    case 4:
                        ListarCelular();
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
        //Inserir
        public static void InserirCelular()
        {
            Console.WriteLine("--Inserir Celular--");

            Console.WriteLine("Informe a Marca do celular");
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do aparelho");
            var preco = double.Parse(Console.ReadLine());

            var resultado = celulares
                .InserirCelular(new Celular()
                {
                    Marca = marca,
                    Modelo = modelo,
                    Preco = preco

                });
            //Verificamos se o resultado e verdadeiro ou falso
            if(resultado)
                Console.WriteLine("Celular Cadastrado com sucesso");
            else //Caso False apresenta o aviso
                Console.WriteLine("Erro ao cadastrar aparelho");

        }
        //Atualizar
        public static void AtualizarCelular()
        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("--Atualizar Celular--");

            ListarCelular();

            //Informamos ao usuario que ele precisa colocar o Id para realizar a alteração
            Console.WriteLine("Informe o Id para alteração de registro.");
            //obtemos o Id informado
            var celularId = int.Parse(Console.ReadLine());

            // Obtemos do banco o item completo que vamos atualizar
            var celular = celulares //Nossa controller
                .GetCelulares() //Obtemos os celulares
                .FirstOrDefault(x => x.Id == celularId); //Laço de repetição para mostrarcada celular
               

            if (celular == null)
            {
                Console.WriteLine("Id Informado inválido");
                return;
            }               

            Console.WriteLine("Informe a Marca do celular");
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do aparelho");
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares.
                AtualizarCelular(celular);

            if(resultado)
                Console.WriteLine("Celular atualizado com sucesso");
            else
                Console.WriteLine("Erro ao atualizar aparelho");
        }
        public static void RemoverCelular()
        {
            //Remover
            //Apresentamos a tela em que estamos
            Console.WriteLine("--Remover Celular--");

            ListarCelular();

            //Informamos ao usuario que ele precisa colocar o Id para realizar a alteração
            Console.WriteLine("Informe o Id para para a remoção do registro");
            //obtemos o Id informado
            var celularId = int.Parse(Console.ReadLine());

            //Metodo que 'remove' o celular de nosso sistema
            var resultado = celulares.RemoverCelular(celularId);

            if (resultado) //Apresentação do resultado da operação
                Console.WriteLine("Celular removido com sucesso");
            else
                Console.WriteLine("Erro ao remover aparelho");

        }
         //Listar
         public static void ListarCelular()
        {
            Console.WriteLine("--Lista Celular--");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares() //Obtemos a lista de celulares
                .ToList<Celular>() // Convertemos paraa uma lista em memoria
                .ForEach(x => //Laço de repetição para mostrar cada celular
                Console.WriteLine($"Id:{x.Id} Marca: {x.Marca} Modelo {x.Modelo} Preço: {x.Preco}"));

        }
    }
}
