namespace RegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistroDeImoveis.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistroDeImoveis.Models.MigrationContext context)
        {
            context.Proprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietario()
            {
                Nome = "Fernando",
                DataNascimento = DateTime.Parse("26/04/1983"),
                Email = "blablabla@gmail.com"
                
            });

            context.SaveChanges();

            var proprietarioId = context.Proprietarios.FirstOrDefault(x => x.Nome == "Fernando").id;

            context.Imoveis.AddOrUpdate(x => x.ProprietarioId, new Models.Imovel()
            {
                Cep = "89046130",
                Logradouro = "Rua Ze das Couves",
                Bairoo = "Velha",
                Municipio = "Blumenau",
                Numero = 455,
                Complemento = "Casa",
                ProprietarioId = proprietarioId

            });

            context.SaveChanges();
        }
    }
}



