using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        SistemaCarrosContext carroContext = new SistemaCarrosContext();

        /// <summary>
        /// Metodo que retorna a nossa lista de carros completa
        /// </summary>
        /// <returns>Retona mossa lista de carros
        public List<Carro> MostraCarros()
        {

            return carroContext.ListaDeCarros;
        }
    }
}
