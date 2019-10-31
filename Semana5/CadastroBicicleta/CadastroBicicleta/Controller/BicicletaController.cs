using CadastroBicicleta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBicicleta.Controller
{
    public class BicicletaController
    {
        BicicletaContextDB contextDB = new BicicletaContextDB();

        public bool InserirBicicleta(Bicicleta bicicleta)
        {
            if (bicicleta == null)
                return false;
            contextDB.Bicicletas.Add(bicicleta);
            contextDB.SaveChanges();
            return true;
        }
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDB.Bicicletas.Where(x => x.Id > 0);

        }
        public bool RemoverBicicleta(int id)
        {
            var bicicleta = contextDB.Bicicletas.FirstOrDefault(x => x.Id == id);

            if (bicicleta != null)
            {
                contextDB.Bicicletas.Remove(bicicleta);
                contextDB.SaveChanges();
                return true;
            }
            else
                return false;                       
        }

        public void AtualizarBicicleta(Bicicleta bicicleta)
        {
            var Bike = contextDB.Bicicletas.FirstOrDefault(x => x.Id == bicicleta.Id);
            contextDB.SaveChanges();

        }
        


    }
}
