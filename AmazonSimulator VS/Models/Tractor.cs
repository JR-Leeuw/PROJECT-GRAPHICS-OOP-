using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Models
{
    public class Tractor : AbstractModel
    {
        bool needcargo = true;

        public Tractor(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "tractor";
        }

        //public void bringcargo()
        //{
        //        if(x > 0)
        //    {
        //        move(x - 0.16m, y, z);
        //    }
        //}

        //public void takecargo()
        //{
        //    if (x > -15 && x <= 0)
        //    {
        //        Move(x - 0.16m, y, z);
        //    }
        //}

        //public void cargohandler()
        //{
        //    if(needcargo == true)
        //    {
        //        bringcargo();
        //        needcargo = false;
        //    }

        //    else
        //    {
        //        takecargo();
        //        needcargo = true;
        //    }
        //}

        //public override bool Update(int tick)
        //{
        //    cargohandler();
        //    if (needsUpdate)
        //    {
        //        needsUpdate = false;
        //        return true;
        //    }
        //    return false;
        //}
    }
}