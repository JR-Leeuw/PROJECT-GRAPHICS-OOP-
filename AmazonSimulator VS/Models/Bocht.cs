using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Bocht : AbstractModel
    {
        public Bocht(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "bocht";
        }
    }
}
