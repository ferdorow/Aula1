using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {

        static CarroController controller = new CarroController();
        static void Main(string[] args)
        {
            controller.GetCarros().ForEach(i => Console.WriteLine($"{i.Id} {i.Marca} {i.Modelo}"));

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
