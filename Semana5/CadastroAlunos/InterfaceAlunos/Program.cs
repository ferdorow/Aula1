using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosEntity.Model;
using AlunosEntity.Controller;


namespace InterfaceAlunos
{
    public class Program
    {
        static AlunoController alunoController = new AlunoController();
        static void Main(string[] args)
        {
            alunoController.AddAluno(new Aluno()
            {
                Nome = "Fernando",
                Idade = 28

            }) ;

            alunoController.AddAluno(new Aluno()
            {
                Nome = "Maria",
                Idade = 25

            });
            alunoController.AddAluno(new Aluno()
            {
                Nome = "João",
                Idade = 44

            });
            alunoController.GetAlunos()  
               .ToList<Aluno>()
               .ForEach(x => Console.WriteLine($" Nome: {x.Nome}, Idade: {x.Idade}"));


            Console.ReadKey();


        }
    }
}
