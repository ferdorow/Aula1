using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContextDb cervejaContext = new CervejaContextDb(@"data source = (localdb)\MSSQLlocalDB; initial catalog = RevisandoEntity.Model.CervejaContextDB; integrated security = True; MultipleActiveResultSets=True;App=EntityFramework");

        public void addCerveja(Cerveja item)
        {
            cervejaContext.Cervejas.Add(item);
            cervejaContext.SaveChanges();


        }

    }
}

