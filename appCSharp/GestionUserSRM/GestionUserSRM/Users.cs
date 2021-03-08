using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUserSRM
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }
        public bool banned { get; set; }
        public int idUser { get; set; }
        public int idRole { get; set; }
    }
}
