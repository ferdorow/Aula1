using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRelatorioDeVendas.Model
{
    class Venda
    {
        public int Id { get; set; }
        public string Carro { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        
    }
}
