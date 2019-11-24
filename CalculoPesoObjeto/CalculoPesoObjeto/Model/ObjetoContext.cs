﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CalculoPesoObjeto.Model
{
    public class ObjetoContext : DbContext
    {
        public ObjetoContext(DbContextOptions<ObjetoContext> options) : base(options)
        {

        }
        public DbSet<Objeto> Objetos { get; set; }

    }
}
