using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public bool? Ativo { get; set; }
        public int UsuarioInc { get; set; }
        public int UsurioAlt { get; set; }
        public DateTime DataInc { get; set; }
        public DateTime DataAlt { get; set; }
    }
}
