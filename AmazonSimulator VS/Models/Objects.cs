using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models { 
  
        
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

    public class Gate : AbstractModel
    {
        public Gate(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "Gate";
        }
    }

    public class Fence : AbstractModel
    {
        public Fence(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "Fence";
        }
    }

    public class Cow : AbstractModel
    {
        public Cow(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "cow";
        }
    }

    public class Wheat : AbstractModel
    {
        public Wheat(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "wheat";
        }
    }

    public class RoadOBJ : AbstractModel
    {
        public RoadOBJ(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "RoadOBJ";
        }
    }

    public class Barn : AbstractModel
    {
        public Barn(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "Barn";
        }
    }

    public class Woodenpath : AbstractModel
    {
        public Woodenpath(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "Woodenpath";
        }
    }


}

