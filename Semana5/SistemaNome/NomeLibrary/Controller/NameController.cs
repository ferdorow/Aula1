using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NomeLibrary.Model;

namespace NomeLibrary.Controller
{
    public class NameController
    {
        NameContextDB contextDB = new NameContextDB();

        public bool InserirNome(Name item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;

            contextDB.Nome.Add(item);
            contextDB.SaveChanges();
            return true;
        }
        public IQueryable<Name> GetNomes()
        {
            return contextDB.Nome.Where(x => x.Id > 0);
                                 
        }
    }
}
