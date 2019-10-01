using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Area
{
    class Program
    {
        static void Main(string[] args)

        {
            //Declaração das variáveis
            double b, h, area;
            //mensagem para digitar a base
            Console.Write("DIGITE O VALOR DA BASE (cm): ");
            //variável b recebe o valor convertido para
            //o tipo correto que no caso é double
            b = Convert.ToDouble(Console.ReadLine());
            //mensagem para digitar a base
            Console.Write("DIGITE O VALOR DA ALTURA (cm): ");
            //variável h recebe o valor convertido para
            //o tipo correto que no caso também é double
            h = Convert.ToDouble(Console.ReadLine());
            //Área recebe o resultado da "fórmula"
            area = b * h / 2;
            //exibo o resultado
            Console.WriteLine("A área do triangulo é: " + area.ToString("F2") + " (cm²)");
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey();
        }
    }
}
