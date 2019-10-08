using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;
using CodeFirstTeste.Controller;

namespace GambCodeFirst
{
    public class Program
    {
        static CervejaController cervejaContext = new CervejaController();
        static void Main(string[] args)
        {
           cervejaContext.addCerveja(new Cerveja() { Nome = "Bohemia Cerveja" });
            
        }
    }
}
