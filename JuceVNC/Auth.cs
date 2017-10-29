using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuceVNC
{
    class Auth
    {
        public string Token { get; set; }
        public string Message { get; set; }

        public Auth(string token, string message)
        {
            this.Token = token;
            this.Message = message;
          
        }
        public Auth()
        {        }
    }
}
