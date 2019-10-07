﻿using AlunosEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlunosEntity.Controller
{
    public class AlunoController
    {
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable<Aluno> GetAlunos()
        {
            return contextDB.ListaDeAlunos;  
        }

        public void AddAluno(Aluno item)
        {
            contextDB.ListaDeAlunos.Add(item);
            contextDB.SaveChanges();
        }
    }
}
