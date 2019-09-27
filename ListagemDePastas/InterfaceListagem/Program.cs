using DllPastaWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceListagem
{
    class Program
    {
        static DocumentsAutoGenerate documentAutoGenerate = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pasta");
                Console.WriteLine("1 - Criar Pasta em Meus Documentos");
                Console.WriteLine("2 - Deletar Pasta em Meus Documentos");
                Console.WriteLine("3 - Listas Pastas no Meus Docmentos");
                Console.WriteLine("4 - Bonus Sextou");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Informe o nome da pasta");
                        var nomePasta = Console.ReadLine();

                        documentAutoGenerate.CriarPastaMeusDocumentos(nomePasta);
                        break;

                    case 2:
                        Console.WriteLine("Informar o nome da pasta para excluir");
                        var nomePasta1 = Console.ReadLine();

                        documentAutoGenerate.DeletarPastaMeusDocumentos(nomePasta1, true);
                        break;

                    case 3:
                        documentAutoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
                        break;

                    case 4:
                        new HoraDoShow().Birllllllllll();
                        Console.ReadKey();
                        break;

                       
                                              

                } 


            }
                
        }
    }
}
