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
        Bocht b;
        Gate gg;
        Fence f;
        Fence f1;
        Fence f2;
        Fence f3;
        Fence f4;
        Fence f5;
        Fence f6;
        Fence f7;
        Fence f8;
        Fence f9;
        Fence f10;
        Fence f11;
        Fence f12;
        Fence f13;
        Fence f14;
        Fence f15;
        Fence f16;
        Fence f17;
        Fence f18;
        Fence f19;

        public World() {
            r = CreateRobot(0,0,0);
            r.Move(0, 0, 0);
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
            gg.Move(0, 0, -7);
            f = CreateFence(0, 0, 0);
            f.Move(2.8m, 0, -7);
            f1 = CreateFence(0, 0, 0);
            f1.Move(-2.8m, 0, -7);
            f2 = CreateFence(0, 0, 0);
            f2.Move(-5.3m, 0, -7);
            f3 = CreateFence(0, 0, 0);
            f3.Move(5.3m, 0, -7);
            f4 = CreateFence(0, 0, 0);
            f4.Move(6.55m, 0, -8.3m);
            f4.Rotate(0, 1.57m, 0);
            f5 = CreateFence(0, 0, 0);
            f5.Move(6.55m, 0, -10.8m);
            f5.Rotate(0, 1.57m, 0);
            f6 = CreateFence(0, 0, 0);
            f6.Move(6.55m, 0, -13.3m);
            f6.Rotate(0, 1.57m, 0);
            f7 = CreateFence(0, 0, 0);
            f7.Move(6.55m, 0, -15.8m);
            f7.Rotate(0, 1.57m, 0);
            f8 = CreateFence(0, 0, 0);
            f8.Move(6.55m, 0, -18.3m);
            f8.Rotate(0, 1.57m, 0);
            f9 = CreateFence(0, 0, 0);
            f9.Move(5.26m, 0, -19.56m);
            f10 = CreateFence(0, 0, 0);
            f10.Move(2.76m, 0, -19.56m);
            f11 = CreateFence(0, 0, 0);
            f11.Move(0.26m, 0, -19.56m);
            f12 = CreateFence(0, 0, 0);
            f12.Move(-2.24m, 0, -19.56m);
            f13 = CreateFence(0, 0, 0);
            f13.Move(-4.74m, 0, -19.56m);
            f14 = CreateFence(0, 0, 0);
            f14.Move(-6.60m, 0, -8.3m);
            f14.Rotate(0, 1.57m, 0);
            f15 = CreateFence(0, 0, 0);
            f15.Move(-6.60m, 0, -10.8m);
            f15.Rotate(0, 1.57m, 0);
            f16 = CreateFence(0, 0, 0);
            f16.Move(-6.60m, 0, -13.3m);
            f16.Rotate(0, 1.57m, 0);
            f17 = CreateFence(0, 0, 0);
            f17.Move(-6.60m, 0, -15.8m);
            f17.Rotate(0, 1.57m, 0);
            f18 = CreateFence(0, 0, 0);
            f18.Move(-6.60m, 0, -18.3m);
            f18.Rotate(0, 1.57m, 0);
            f19 = CreateFence(0, 0, 0);
            f19.Move(-5.35m, 0, -19.56m);
           






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