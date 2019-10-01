using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRelatorioDeVendas.Model
{
    public class SistemaDeVendaContext
    {
        //public int IdContadorVeiculos { get; set; } = 1;


        public SistemaDeVendaContext()
        {

            ListaDeVeiculos = new List<Veiculo>();

            ListaDeVeiculos.Add(new Veiculo() { Id = 1, Carro = "Risus Company", Valor = 7200, Quantidade = 18, Data = DateTime.Parse("29/01/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 2, Carro = "Risus Associates", Valor = 9961, Quantidade = 4, Data = DateTime.Parse("10/02/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 3, Carro = "Et Libero Proin Foundation	    ", Valor = 8710, Quantidade = 17, Data = DateTime.Parse("24/01/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 4, Carro = "Cursus Et Ltd", Valor = 9010, Quantidade = 17, Data = DateTime.Parse("26/10/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 5, Carro = "Odio Etiam Ligula Company", Valor = 5245, Quantidade = 8, Data = DateTime.Parse("16/02/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 6, Carro = "Eu Nibh Inc.", Valor = 7922, Quantidade = 9, Data = DateTime.Parse("27/06/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 7, Carro = "Tellus Limited", Valor = 7294, Quantidade = 7, Data = DateTime.Parse("26/01/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 8, Carro = "Imperdiet PC", Valor = 8305, Quantidade = 5, Data = DateTime.Parse("06/09/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 9, Carro = "Elit Inc.", Valor = 5398, Quantidade = 18, Data = DateTime.Parse("09/06/2019") });
            ListaDeVeiculos.Add(new Veiculo() { Id = 10, Carro = "Quam A Limited", Valor = 5398, Quantidade = 14, Data = DateTime.Parse("09/09/2019") });
        }
        public List<Veiculo> ListaDeVeiculos { get; set; }


    }

}

