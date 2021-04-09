using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUserSRM
{
    public class Messages
    {
        public int id { get; set; }
        public string date { get; set; }
        public string content { get; set; }
        public int senderUserID { get; set; }
        public int receiverUserID { get; set; }
        public int receiverGroupID { get; set; }
        public int receiverChannelID { get; set; }
        public bool active { get; set; }
        
    }
}
