﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas.Model
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Carteira { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}