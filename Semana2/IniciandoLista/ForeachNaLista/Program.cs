using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDeDecimais();

            Console.ReadKey();
          
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));
           
        }
        /// <summary>
        /// Mostra lista de string definidas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(item => Console.WriteLine(item)); //foreach simplificado para lista/coleções

        }
                
        /// <summary>
        ///minha lista de inteiros
        /// </summary>
        private static void ListaDeInteiros()
        {

            var minhaLista = new List<int>();

            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);

            minhaLista.ForEach(i => Console.WriteLine(i));
                                                            
        }
        /// <summary>
        /// minha lista de decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") +" "+ FormataNumeroDecimalEmDolar(meuDecimal)+"  "+ FormataRealemYen(meuDecimal)+" "+ FormataRealemEuro(meuDecimal)+"  "+FormataRealemBitcoin(meuDecimal)));

        }
        /// <summary>
        /// Metodo que converte o meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns> Retorna o valor formatado em dolar
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

        }
        /// <summary>
        /// Metodo que converte o numero em real para Yen
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns> Retorna o numero formatado em Yen
        private static string FormataRealemYen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));

        }
        /// <summary>
        /// Metodo que converte o numero em real para Euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns> Retorna o numero formatado em Euro
        private static string FormataRealemEuro(double meuNumero)
        {
            return (meuNumero / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("de-DE"));

        }
        /// <summary>
        /// Metodo que converte o numero em real para Bitcoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns> Retorna o numero formatado em Bitcoin
        private static string FormataRealemBitcoin(double meuNumero)
        {
            return (meuNumero / 41853.32).ToString("C10").Replace("$", "BTC");

        }




    }
}