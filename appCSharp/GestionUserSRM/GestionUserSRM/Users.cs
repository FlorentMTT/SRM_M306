using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUserSRM
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        public int id { get; set; }
    }
}
