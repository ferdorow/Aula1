using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoBicicletas.Model;


namespace CatalogoBicicletas.Controller
{
    public class BicicletaController
    {
        BicicletaContextDB contextDB = new BicicletaContextDB();

        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDB.Bicicletas.Where(x => x.Id != 0);


        }
        public bool AtualizarBicicletas(Bicicleta item)
        {
            var Bicicleta = contextDB.Bicicletas.FirstOrDefault (x => x.Id == item.Id);

            if (Bicicleta == null) 
                return false;       

            contextDB.SaveChanges(); 
            return true; 
        }
        public bool InserirBicicleta(Bicicleta item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                      return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Valor <= 0) 
                return false;  

            contextDB.Bicicletas.Add(item); 
            contextDB.SaveChanges(); 
            return true; 
        }
        public bool RemoverBicicleta(int id)
        {
            var bicicleta = contextDB.Bicicletas.FirstOrDefault(x => x.Id == id); 
                

            if (bicicleta == null) 
                return false;
            

            contextDB.SaveChanges(); 

            return true; 
        }
    }
}
