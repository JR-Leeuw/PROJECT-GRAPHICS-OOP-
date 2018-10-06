using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moving
{
    public class coordinaten
    {
        public int X;
        public int Z;

        public coordinaten(int X, int Z)
        {
            this.X = X;
            this.Z = Z;
        }

        public int GetXpos()
        {
            return X;
        }
        public int GetZpos()
        {
            return Z;
        }
    }
}

