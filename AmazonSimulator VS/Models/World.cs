using System;
using System.Collections.Generic;
using Controllers;
using moving;
namespace Models
{
    public class World : IObservable<Command>, IUpdatable
    {
        private List<AbstractModel> worldObjects = new List<AbstractModel>();
        private List<IObserver<Command>> observers = new List<IObserver<Command>>();
        
        double xpos = 10;
        double ypos = 0.5;
        double zpos = 10;
        double xpos2 = 20;
        double ypos2 = 0.5;
        double zpos2 = 10;
        double ry = 0;
        double ry2 = 0;
        Robot r;
        Robot a;
        Tractor t;
        Tractor g;
        Propeller p;
        RoadOBJ Rob;
        RoadOBJ Roa;
        Cow c;
        Cow c1;
        Gate gg;

        Silo s1;
        Windmill wi;
        Barn Ba;
        Woodenpath wo;
        
        Fence f1;
        Fence f2;
        Fence f3;
        Fence f4;
        Fence f5;
        Fence f6;
        Fence f7;
        Fence f14;
        Fence f15;
        Fence f16;
        Fence f17;

        Wheat w1;
        Wheat w2;
        Wheat w3;
        Wheat w4;
        Wheat w5;
        Wheat w6;
        Wheat w7;

        
        //Fence f18;
        //Fence f19;

        public World() {
            r = CreateRobot(0,0,0);
            r.Move(0, 0, 0);

            Ba = CreateBarn(0, 0, 0);
            Ba.Move(0, 0, -28);

            wi = CreateWindmill(0, 0, 0);
            wi.Move(-13, 4.5m, -23);

            wo = CreateWoodenpath(0, 0, 0);
            wo.Move(-1, -0.2m, -13);

            a = CreateRobot(0, 0, 0);
            a.Move(0, 0, 0);

            t = CreateTractor(0, 0, 0);
            t.Rotate(0, -1.5m, 0);
            t.Move(25, 0, 5);

            p = CreatePropeller(0, 0, 0);
            p.Move(-12.76m, 9.1m, -21.5m);
            p.Rotate(0,0,0);

            Rob = CreateRoadOBJ(0, 0, 0);
            Rob.Move(-7.483m, -0.5455m, 4);
            Roa = CreateRoadOBJ(0, 0, 0);
            Roa.Move(7.483m, -0.5455m, 4);

            gg = CreateGate(0, 0, 0);
            gg.Move(-0.9m, 0, -14.4m);

            c = CreateCow(0, 0, 0);
            c.Move(0, 0, -16);
            c1 = CreateCow(0, 0, 0);
            c1.Move(2.8m, 0, -19);
            c1.Rotate(0, 1.2m, 0);
            f1 = CreateFence(0, 0, 0);
            f1.Move(-3.6m, 0, -14.4m);
            f2 = CreateFence(0, 0, 0);
            f2.Move(1.8m, 0, -14.4m);
            f3 = CreateFence(0, 0, 0);
            f3.Move(4.3m, 0, -14.4m);
            f4 = CreateFence(0, 0, 0);
            f4.Move(5.55m, 0, -15.6m);
            f4.Rotate(0, 1.57m, 0);
            f5 = CreateFence(0, 0, 0);
            f5.Move(5.55m, 0, -18.1m);
            f5.Rotate(0, 1.57m, 0);
            f6 = CreateFence(0, 0, 0);
            f6.Move(5.55m, 0, -20.6m);
            f6.Rotate(0, 1.57m, 0);
            f7 = CreateFence(0, 0, 0);
            f7.Move(5.55m, 0, -23.1m);
            f7.Rotate(0, 1.57m, 0);
            f14 = CreateFence(0, 0, 0);
            f14.Move(-5, 0, -15.5m);
            f14.Rotate(0, 1.57m, 0);
            f15 = CreateFence(0, 0, 0);
            f15.Move(-5, 0, -18); 
            f15.Rotate(0, 1.57m, 0);
            f16 = CreateFence(0, 0, 0);
            f16.Move(-5, 0, -20.5m);
            f16.Rotate(0, 1.57m, 0);
            f17 = CreateFence(0, 0, 0);
            f17.Move(-5m, 0, -23);
            f17.Rotate(0, 1.57m, 0);

            w1 = CreateWheat(0, 0, 0);
            w1.Move(-4.8m, 0, -13);
            w2 = CreateWheat(0, 0, 0);
            w2.Move(-3.8m, 0, -13);
            w3 = CreateWheat(0, 0, 0);
            w3.Move(-2.8m, 0, -13);
            w4 = CreateWheat(0, 0, 0);
            w4.Move(1.1m, 0, -13);
            w5 = CreateWheat(0, 0, 0);
            w5.Move(1.1m, 0, -13);
            w6 = CreateWheat(0, 0, 0);
            w6.Move(2.1m, 0, -13);
            w7 = CreateWheat(0, 0, 0);
            w7.Move(3.1m, 0, -13);

            s1 = CreateSilo(0, 0, 0);
            s1.Move(13, 4.5m, -23);

        }

        private Robot CreateRobot(decimal x, decimal y, decimal z) {
            Robot r = new Robot(x,y,z,0,0,0);
            worldObjects.Add(r);
            return r;
        }

        private Tractor CreateTractor(decimal x, decimal y, decimal z)
        {
            Tractor t = new Tractor(x, y, z, 0, 0, 0);
            worldObjects.Add(t);
            return t;
        }
        private RoadOBJ CreateRoadOBJ(decimal x, decimal y, decimal z)
        {
            RoadOBJ Ro = new RoadOBJ(x, y, z, 0, 0, 0);
            worldObjects.Add(Ro);
            return Ro;
        }

        private Propeller CreatePropeller(decimal x, decimal y, decimal z)
        {
            Propeller p = new Propeller(x, y, z, 0, 0, 0);
            worldObjects.Add(p); 
            return p;
        }
       
        private Haystack CreateHaystack(decimal x, decimal y, decimal z)
        {
            Haystack h = new Haystack(x, y, z, 0, 0, 0);
            worldObjects.Add(h);
            return h;
        }
        private Fence CreateFence(decimal x, decimal y, decimal z)
        {
            Fence f = new Fence(x, y, z, 0, 0, 0);
            worldObjects.Add(f);
            return f;
        }
        private Gate CreateGate(decimal x, decimal y, decimal z)
        {
            Gate g = new Gate(x, y, z, 0, 0, 0);
            worldObjects.Add(g);
            return g;
        }
        private Cow CreateCow(decimal x, decimal y, decimal z)
        {
            Cow c = new Cow(x, y, z, 0, 0, 0);
            worldObjects.Add(c);
            return c;
        }
        private Wheat CreateWheat(decimal x, decimal y, decimal z)
        {
            Wheat w = new Wheat(x, y, z, 0, 0, 0);
            worldObjects.Add(w);
            return w;
        }

        private Silo CreateSilo(decimal x, decimal y, decimal z)
        {
            Silo s = new Silo(x, y, z, 0, 0, 0);
            worldObjects.Add(s);
            return s;
        }

        private Windmill CreateWindmill(decimal x, decimal y, decimal z)
        {
            Windmill i = new Windmill(x, y, z, 0, 0, 0);
            worldObjects.Add(i);
            return i;
        }

        private Barn CreateBarn(decimal x, decimal y, decimal z)
        {
            Barn b = new Barn(x, y, z, 0, 0, 0);
            worldObjects.Add(b);
            return b;
        }

        private Woodenpath CreateWoodenpath(decimal x, decimal y, decimal z)
        {
            Woodenpath o = new Woodenpath(x, y, z, 0, 0, 0);
            worldObjects.Add(o);
            return o;
        }

        public IDisposable Subscribe(IObserver<Command> observer)
        {
            if (!observers.Contains(observer)) {
                observers.Add(observer);

                SendCreationCommandsToObserver(observer);
            }
            return new Unsubscriber<Command>(observers, observer);
        }

        private void SendCommandToObservers(Command c) {
            for(int i = 0; i < this.observers.Count; i++) {
                this.observers[i].OnNext(c);
            }
        }

        private void SendCreationCommandsToObserver(IObserver<Command> obs) {
            foreach(AbstractModel m3d in worldObjects) {
                obs.OnNext(new UpdateModel3DCommand(m3d));
            }
        }
        

        public bool Update(int tick)
        {
            //xpos += 0.01;
            //zpos -= 0.07;
            //ry += 0.01;
            //r.Rotate(0, ry, 0);
            //zpos2 += 0.01;
            //r.Move(xpos, ypos, zpos);
            //a.Move(xpos2, ypos2, zpos2);
            //t.Move(10, zpos, 0);
            for (int i = 0; i < worldObjects.Count; i++) {
                AbstractModel u = worldObjects[i];

                if(u is IUpdatable) {
                    bool needsCommand = ((IUpdatable)u).Update(tick);

                    if(needsCommand) {
                        SendCommandToObservers(new UpdateModel3DCommand(u));
                    }
                }
            }

            return true;
        }

        public void Logic()
        {
            /*
                foreach (AbstractModel m in worldObjects)
                {
                    if (m is Robot)
                    {
                        if (m.guid == m.guid)
                        {
                            //m.GiveTask("insert job here");
                        }
                    }
                }*/
        }


    }

    internal class Unsubscriber<Command> : IDisposable
    {
        private List<IObserver<Command>> _observers;
        private IObserver<Command> _observer;

        internal Unsubscriber(List<IObserver<Command>> observers, IObserver<Command> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose() 
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }


}