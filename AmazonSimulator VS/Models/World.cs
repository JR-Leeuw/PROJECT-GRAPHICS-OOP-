using System;
using System.Collections.Generic;
using System.Linq;
using Controllers;

namespace Models {
    public class World : IObservable<Command>, IUpdatable
    {
        private List<Robot> worldObjects = new List<Robot>();
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


        public World() {
            r = CreateRobot(0,0,0);
            r.Move(0, 0, 0);
            a = CreateRobot2(0, 0, 0);
            a.Move(0, 0, 0);
        }

        public Robot CreateRobot(double x, double y, double z) {
            Robot r = new Robot(x,y,z,0,0,0);
            worldObjects.Add(r);
            return r;
        }

        public Robot CreateRobot2(double x, double y, double z)
        {
            Robot r = new Robot(x, y, z, 0, 0, 0);
            worldObjects.Add(r);
            return r;
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
            foreach(Robot m3d in worldObjects) {
                obs.OnNext(new UpdateModel3DCommand(m3d));
            }
        }

        public bool Update(int tick)
        {   
            xpos += 0.01;
            ry += 0.01;
            r.Rotate(0, ry, 0);
            zpos2 += 0.01;
            r.Move(xpos, ypos, zpos);
            a.Move(xpos2, ypos2, zpos2);
            for (int i = 0; i < worldObjects.Count; i++) {
                Robot u = worldObjects[i];

                if(u is IUpdatable) {
                    bool needsCommand = ((IUpdatable)u).Update(tick);

                    if(needsCommand) {
                        SendCommandToObservers(new UpdateModel3DCommand(u));
                    }
                }
            }

            return true;
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