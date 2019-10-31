using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroDeImoveis.Models
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }
        [CustomValidator]
        public string Nome { get; set; }
        [CustomValidator]
        public DateTime DataNascimento { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }
}