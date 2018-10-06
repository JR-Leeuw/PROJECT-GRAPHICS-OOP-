using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Gate : AbstractModel
    {
        public Gate(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "Gate";
        }
    }
}
