using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JewsVNC
{
    class Computer
    {
        public string id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string ip { get; set; }
        public string guid { get; set; }
        public string status { get; set; }
        public string owner { get; set; }
        public string hash { get; set; }
        public string mac { get; set; }

        public Computer(string ID, string password, string name, string ip,string status, string guid, string owner, string hash,string mac)
        {
            this.id = ID;
            this.password = password;
            this.name = name;
            this.ip = ip;
            this.status = status;
            this.guid = guid;
            this.owner = owner;
            this.hash = hash;
            this.mac = mac;
        }
        public Computer()
        {        }
    }
}
