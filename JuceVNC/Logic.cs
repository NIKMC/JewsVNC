using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JewsVNC
{
    static class Logic
    {
        public static bool Confirm(string s1, string s2)
        {
            return String.Compare(s1, s2) == 0;
        }
    }
}
