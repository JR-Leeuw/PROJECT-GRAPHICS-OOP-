using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Models
{
    public class Propeller : AbstractModel
    {
        public Propeller(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "propeller";
        }

        public void spin()
        {
            Rotate(rotationX, rotationY, rotationZ + 0.08m);
        }

        public override bool Update(int tick)
        {
            spin();
            if (needsUpdate)
            {
                needsUpdate = false;
                return true;
            }
            return false;
        }
    }
}
