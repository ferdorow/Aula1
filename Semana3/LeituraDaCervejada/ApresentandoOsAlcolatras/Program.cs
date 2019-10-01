using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionarCervejasALista(new Cerveja()
            {

                Nome = "Giomar",
                Alcool = 8,
                Valor = 0.98

            });

            cervejaController.RetornaListaDeCervejas().ForEach(x => Console.WriteLine($" Id:{x.Id} Nome:{x.Nome} Valor:{x.Valor} Ml/:{x.Litros} Teor Alcoolico {x.Alcool}"));

            Console.WriteLine(cervejaController.RetornaValorTotalLitrosCervejas());
            Console.WriteLine(cervejaController.RetornaValorTotalCervejas());

            Console.ReadKey();
        }
    }
}
