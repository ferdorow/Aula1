using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoFlores.Model;


namespace CatalogoFlores.Controller
{
    public class FloresController
    {
        FloresContextDB contextDB = new FloresContextDB();

        public void InserirNome(Flor item)
        {
            contextDB.Flores.Add(item);
            contextDB.SaveChanges();
        }
        public IQueryable<Flor> GetFlores()
        {
            return contextDB.Flores.Where(x => x.Id > 0);

        }

    }
}
