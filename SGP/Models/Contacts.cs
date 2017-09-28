using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Contact { get; set; }
        public string Coments { get; set; }
        public int ContactType { get; set; }
    }
}
