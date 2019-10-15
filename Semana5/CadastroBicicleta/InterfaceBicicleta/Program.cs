using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroBicicleta.Controller;
using CadastroBicicleta.Model;

namespace InterfaceBicicleta
{
    class Program
    {
        static BicicletaController bicicletas = new BicicletaController();
        static void Main(string[] args)
        {

        }
        public static void InserirBicicleta()
        {
            Console.WriteLine("--**--Inserir Bicicleta no sistema--**--");

            Console.WriteLine("Informe a Marca da Bicicleta");
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo da Bicicleta");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do Bicicleta");
            var valor = double.Parse(Console.ReadLine());

            var variavel = bicicletas.InserirBicicleta(new Bicicleta()
            {
                Marca = marca,
                Modelo = modelo,
                Valor = valor

            });
            if (variavel)
                Console.WriteLine("Bicicleta Cadastrada com sucesso");
            else //Caso False apresenta o aviso
                Console.WriteLine("Erro ao cadastrar bicicleta");
        }
        public static void RemoverBicicleta()
        {
            
            Console.WriteLine("--Remover Bicicleta--");

            ListarBicicletas();

            Console.WriteLine("Informe o Id para para a remoção do registro");
           
            var bicicletaId = int.Parse(Console.ReadLine());
            
            var resultado = bicicletas.RemoverBicicleta(bicicletaId);

            if (resultado) //Apresentação do resultado da operação
                Console.WriteLine("Bicicleta removida com sucesso");
            else
                Console.WriteLine("Erro ao remover bicicleta");

        }
        public static void ListarBicicletas()
        {
            Console.WriteLine("--Lista Bicicleta--");


            bicicletas.GetBicicletas()
                .ToList<Bicicleta>()
                .ForEach(x => Console.WriteLine($"Id:{x.Id} Modelo: {x.Modelo} Marca {x.Marca} Preço: {x.Valor}"));


        }

    }
}
