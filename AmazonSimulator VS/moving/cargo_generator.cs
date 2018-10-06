using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moving
{
    public class cargo_generator
{
        public char orderrandomizer()
        {
            string chars = "EFGHIJ";
            Random rnd = new Random();
            int r = rnd.Next(0, chars.Length - 1);
            return chars[r];
        }
}
}
