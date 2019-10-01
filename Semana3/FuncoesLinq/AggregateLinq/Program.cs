using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "irineudson"
            };

            //No Aggregate temos o nome atual que estamos lendo e o proximo nome da lista
            //no passo seguinte temos o nome 'proximo' vira o atual e pega o proximo da lista
            var texto = listaDeNomes.Aggregate((nome1, nome2) => nome1 + "; " + nome2);

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
