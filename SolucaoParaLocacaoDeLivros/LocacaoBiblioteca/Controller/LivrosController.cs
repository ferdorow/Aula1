﻿using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        public List<Livro> Livros { get; set; }
        public LivrosController()
        {
            Livros = new List<Livro>();

            Livros.Add(new Livro()
            {
                Nome = "Meu primeiro Livro"
            });

            Livros.Add(new Livro()
            {
                Nome = "Meu segundo Livro"
            });
        }      
                         
    }
}
