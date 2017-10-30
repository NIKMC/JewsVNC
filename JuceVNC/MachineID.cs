using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewsVNC
{
    class MachineID
    {
          public string ip { get; set; }
        public string message { get; set; }

        public MachineID(string ip, string message)
        {
            this.ip = ip;
            this.message = message;
          
        }
        public MachineID()
        {        }
    }
}
