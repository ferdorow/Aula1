using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceRelatorioDeVendas.Model;

namespace InterfaceRelatorioDeVendas.Controller
{
    public class VendasController
    {
        private SistemaDeVendaContext context = new SistemaDeVendaContext();

        public VendasController()
        {

        }

        public List<Veiculo> RetornaListaDeVeiculos(int mes)
        {
            return context.ListaDeVeiculos.Where(x => x.Data.Month == mes).ToList();

        }
    }


}
