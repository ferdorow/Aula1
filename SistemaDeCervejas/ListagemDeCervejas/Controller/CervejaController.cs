using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext cervejaContext = new SistemaCervejaContext();


        public List<Cerveja> MostraListaCerveja()
        {
            return cervejaContext.ListaDeCervejas;
        }

        public void AdicionarCerveja(Cerveja cerveja)
        {
            cerveja.Id = cervejaContext.contadorCerveja++;
            cervejaContext.ListaDeCervejas.Add(cerveja);
        }
        public double RetornaValorTotalDaLista()
        {
            return cervejaContext.ListaDeCervejas.Sum(x => x.Valor);
                
        }
        public double TotalEmLitros()
        {
            return cervejaContext.ListaDeCervejas.Sum(x => x.Litros);

        }

    }
}
