using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Identification { get; set; }
        public int ClientType { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public int Deleted { get; set; }

        public ICollection<Contacts> Contacts { get; set; }
    }
}
