using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebImoveis.Model
{
    public class Controle
    {
        public bool Ativo { get; set; } = true;
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime DataInc { get; set; } = DateTime.Now;
        public DateTime DataAlt { get; set; } = DateTime.Now;

    }
}
