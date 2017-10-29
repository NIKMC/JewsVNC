using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuceVNC
{
    class Computer
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public Computer(string ID, string password, string name, string ip){
            this.ID = ID;
            this.Password = password;
            this.Name = name;
            this.IP = ip;
        }
        public Computer()
        {        }
    }
}
