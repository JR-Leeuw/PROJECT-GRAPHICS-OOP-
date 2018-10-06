using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Models {
    public class AbstractModel : IUpdatable {
        protected decimal _x = 0;
        protected decimal _y = 0;
        protected decimal _z = 0;
        protected decimal _rX = 0;
        protected decimal _rY = 0;
        protected decimal _rZ = 0;

        public string type { get; set; }
        public Guid guid { get; set; }
        public decimal x { get { return _x; } }
        public decimal y { get { return _y; } }
        public decimal z { get { return _z; } }
        public decimal rotationX { get { return _rX; } }
        public decimal rotationY { get { return _rY; } }
        public decimal rotationZ { get { return _rZ; } }

        public bool needsUpdate = true;

        public AbstractModel(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ)
        {
            this.guid = Guid.NewGuid();

            this._x = x;
            this._y = y;
            this._z = z;

            this._rX = rotationX;
            this._rY = rotationY;
            this._rZ = rotationZ;
        }

        public virtual void Move(decimal x, decimal y, decimal z) {
            this._x = x;
            this._y = y;
            this._z = z;

            needsUpdate = true;
        }

        public virtual void Rotate(decimal rotationX, decimal rotationY, decimal rotationZ) {
            this._rX = rotationX;
            this._rY = rotationY;
            this._rZ = rotationZ;

            needsUpdate = true;
        }

        public virtual bool Update(int tick)
        {
            if(needsUpdate) {
                needsUpdate = false;
                return true;
            }
            return false;
        }
    }
}