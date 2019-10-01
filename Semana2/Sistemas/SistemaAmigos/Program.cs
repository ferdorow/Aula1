using SistemaAmigos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAmigos
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeAmigos = new List<Amigos>
            {
                new Amigos()
                {
                    Nome = "Fulano",
                    TempoDeAmizade = 10,

                },

                new Amigos()
                 {
                    Nome = "Ciclano",
                    TempoDeAmizade = 3,

                },
                new Amigos()
                 {
                    Nome = "Ciclano",
                    TempoDeAmizade = 5,

                },

            };

            listaDeAmigos.Add(new Amigos()
            {
                Nome = "Fernando",           //adicionando um como exemplo do metodo add pedido na questão
                TempoDeAmizade = 10,

            });

            listaDeAmigos.ForEach(i => Console.WriteLine($"Meu amigo é {i.Nome} e somos amigos há {i.TempoDeAmizade} anos"));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
