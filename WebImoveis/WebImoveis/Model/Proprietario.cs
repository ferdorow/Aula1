using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebImoveis.Model
{
    public class Proprietario : Controle
    {
        [Key]
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Cpf { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }

    }
}
