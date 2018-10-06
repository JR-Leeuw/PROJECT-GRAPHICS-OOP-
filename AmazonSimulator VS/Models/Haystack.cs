using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Models
{
    public class Haystack : AbstractModel
    {
        public Haystack(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "Haystack";
        }
    }
}

