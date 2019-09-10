using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //texto informativo para consultar o livro
            //pelo numero de registro do sistema
            Console.WriteLine("Informe o livro a ser consultado:");
            //Parte do codigo que recebe as informações
            //de registro do livro e coloca na variavel
            //numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();
            //Aqui realizo a comparação das informações
            //do livro informado com o que tenho disponível
            //em estoque

            if (numeroDoLivro == "123456")
            {
                //informo que este livro ja esta açocado
                Console.WriteLine("Livro Indisponível!");
                Console.ReadKey();
                //Finaliza o metodo
                return;
            }
            else
            {

                Console.WriteLine("Deseja alocar o livro? (1)sim (2)não");

                var resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.WriteLine("livro locado");
                    Console.ReadKey();
                    return;
                }
            }
        }
        




    }
}


