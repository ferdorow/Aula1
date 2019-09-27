using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Litros { get; set; }
        public int Alcool { get; set; }
        public int Valor { get; set; }
        public int Portas { get; set; }
    }
}
