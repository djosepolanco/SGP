using SGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Repository
{
    class ClientsRepository
    {
        public IEnumerable<Clients> FindAll()
        {
            return new DBContext().Set<Clients>().ToList();
        } 
    }
}
