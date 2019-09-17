using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            


        }
        
         /// <summary>
        /// metodo principal de inicialização do sistema
        /// </summary>
        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe um valor a ser convertido");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão");
            Console.WriteLine("DOLAR, EURO, YEN, BTC");

            var moedaALvoParaConverter = Console.ReadLine().ToUpper();
            ConvertMoeda(valorASerConvertido, moedaALvoParaConverter);

            Console.ReadKey();
        }



        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {


            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataRealDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataRealEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataRealIene(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataRealBitCoin(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("Nenhuma conversão informada");
                    break;
            }

        }
        /// <summary>
        /// Converte moeda para Dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealEuro(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));//dolar
        }
        /// <summary>
        /// COnverte moeda para Euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealDolar(double meuNumero)
        {
            return (meuNumero / 4.70).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));//euro
        }
        /// <summary>
        /// Converte moeda para Iene (YEN)
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealIene(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP"));//Iene japones
        }
        /// <summary>
        /// Converte moeda para BitCoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealBitCoin(double meuNumero)
        {
            return (meuNumero / 41824.47).ToString("C10").Replace("R$", "BitCoin");
        }
    }
}