using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace TestandoACerveja
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Lista de Cervejas---------------------");
            cervejaController.MostraListaCerveja().ForEach(x => Console.WriteLine($"Id:{x.Id}, Nome:{x.Nome}, Litros:{x.Litros}, Valor:{x.Valor}, Alcool:{x.Alcool} "));
            Console.ReadKey();
            AddCerveja();
            Console.WriteLine("-------------------Lista de Cervejas---------------------");
            cervejaController.MostraListaCerveja().ForEach(x => Console.WriteLine($"Id:{x.Id}, Nome:{x.Nome}, Litros:{x.Litros}, Valor:{x.Valor}, Alcool:{x.Alcool} "));
            Console.ReadKey();

            Valortotal();
            LitroNoTotal();
            Console.ReadKey();
          
        }                      

        public static void AddCerveja()
        {
            Cerveja cerveja = new Cerveja();
            Console.WriteLine("Informe o nome da cerveja para adicionar");
            cerveja.Nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade em litros:");
            cerveja.Litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o teor alcoolico em %:");
            cerveja.Alcool = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da cerveja:");
            cerveja.Valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Cerveja adicionada com sucesso!");
            cervejaController.AdicionarCerveja(cerveja);

            Console.ReadKey();
            
        }

        public static void Valortotal()
        {
            Console.WriteLine($"o custo total em pilas foi:{cervejaController.RetornaValorTotalDaLista()} ");
            Console.ReadKey();
        }
        public static void LitroNoTotal()
        {
            Console.WriteLine($"O total em litros é:{cervejaController.TotalEmLitros()} ");
            Console.ReadKey();
        }
    }
}
