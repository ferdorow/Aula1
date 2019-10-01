using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais
{
    class Program
    {
        static void Main(string[] args)
        {
            var DadosPessoa = new List<Pessoa>();

            DadosPessoa.Add(new Pessoa()
            {
                 Name = "Spears",
                 DataNasc = DateTime.Parse("07/11/2004"),
                 SaldoCarteira = 846.96

            });

            DadosPessoa.Add(new Pessoa()
            {
                Name = "Swanson",
                DataNasc = DateTime.Parse("20/06/2003"),
                SaldoCarteira = 233.09

            });
            DadosPessoa.Add(new Pessoa()
            {
                Name = "Gay",
                DataNasc = DateTime.Parse("03/12/2001"),
                SaldoCarteira = 911.92

            });
            DadosPessoa.Add(new Pessoa()
            {
                Name = "Gregory",
                DataNasc = DateTime.Parse("02/01/2000"),
                SaldoCarteira = 469.01

            });
            DadosPessoa.Add(new Pessoa()
            {
                Name = "Olson",
                DataNasc = DateTime.Parse("18/07/2001"),
                SaldoCarteira = 261.90

            });
            DadosPessoa.Add(new Pessoa()
            {
                Name = "Garza",
                DataNasc = DateTime.Parse("01/04/2000"),
                SaldoCarteira = 360.41

            });
            DadosPessoa.Add(new Pessoa()
            {
                Name = "Sweet",
                DataNasc = DateTime.Parse("12/03/2003"),
                SaldoCarteira = 312.76

            });
            DadosPessoa.Add(new Pessoa()
            {
                Name = "Cline",
                DataNasc = DateTime.Parse("26/03/2002"),
                SaldoCarteira = 484.51

            });




            DadosPessoa.OrderBy(x => x.Name).ToList<Pessoa>().
                ForEach(i => Console.WriteLine($"Listando em ordem crescente por nome: {i.Name}"));

            DadosPessoa.OrderByDescending(x => x.DataNasc).ToList<Pessoa>().
                ForEach(i => Console.WriteLine($"Listando em ordem decrescente por data de nascimento - Nome {i.Name} e Nascimento:{i.DataNasc.ToShortDateString()}"));

                       
            var filtroPorSaldo = DadosPessoa
                
                .Where(x => x.SaldoCarteira > 500).OrderBy(x => x.Name);
                filtroPorSaldo.ToList<Pessoa>().ForEach(i => Console.WriteLine($" Pessoas com mais de 500 na carteira: {i.Name} "));
                                     
            

            Console.ReadKey();
                              







        }
    }
}
