using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{  public class Objects
    {
        
        public class Silo : AbstractModel
        {
            public Silo(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
            {
                this.type = "Silo";
            }
        }
        public class Windmill : AbstractModel
        {
            public Windmill(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
            {
                this.type = "Windmill";
            }
        }

    }
}

