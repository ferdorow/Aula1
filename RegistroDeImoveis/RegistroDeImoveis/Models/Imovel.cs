using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroDeImoveis.Models
{
    public class Imovel
    {
        public int id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairoo { get; set; }
        public string Municipio { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set;}
        public int ProprietarioId { get; set; }


    }
}