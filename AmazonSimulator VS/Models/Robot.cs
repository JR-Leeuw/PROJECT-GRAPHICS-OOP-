using System;
using moving;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Models
{
    public class Robot : AbstractModel
    {

        decimal destination = 0;
        string direction = null;
        int dir = 0;
        int des = 0;
        decimal currotation;
        decimal destinationx;
        decimal destinationz;
        bool count;
        bool stop;
        bool init;
        movement_control m = new movement_control();
        List<int> destinations = new List<int>();
        List<string> directions = new List<string>();

        public Robot(decimal x, decimal y, decimal z, decimal rotationX, decimal rotationY, decimal rotationZ) : base(x, y, z, rotationX, rotationY, rotationZ)
        {
            this.type = "robot";
        }

        public void movehandler()
        {
            if (stop == false)
            {
                var destiny = m.main();
                var inverted = m.inverted();
                destinations.Add(destiny.Item1);
                destinations.Add(destiny.Item3);
                destinations.Add(destiny.Item5);
                destinations.Add(destiny.Item7);
                destinations.Add(destiny.Item9);
                directions.Add(destiny.Item2);
                directions.Add(destiny.Item4);
                directions.Add(destiny.Item6);
                directions.Add(destiny.Item8);
                directions.Add(destiny.Item10);
                directions.Add(inverted.Item1);
                directions.Add(inverted.Item2);
                directions.Add(inverted.Item3);
                directions.Add(inverted.Item4);
                directions.Add(inverted.Item5);
                if(destiny.Item7 == 0)
                {
                    destinations.Add(destiny.Item5);
                    destinations.Add(destiny.Item3);
                    destinations.Add(destiny.Item1);
                    destinations.Add(destiny.Item7);
                    destinations.Add(destiny.Item9);
                }
                else if(destiny.Item7 != 0 && destiny.Item9 == 0)
                {
                    destinations.Add(destiny.Item7);
                    destinations.Add(destiny.Item5);
                    destinations.Add(destiny.Item3);
                    destinations.Add(destiny.Item1);
                    destinations.Add(destiny.Item9);
                }
                else
                {
                    destinations.Add(destiny.Item9);
                    destinations.Add(destiny.Item7);
                    destinations.Add(destiny.Item5);
                    destinations.Add(destiny.Item3);
                    destinations.Add(destiny.Item1);
                }
               
                //controlls the roots position, direction and rotation

                if (direction == null && destination == 0)
                {
                    direction = directions[dir];
                    destination = destinations[des];
                }
                if (direction == "left" || direction == "right")
                {
                    if (count == false && direction == "right")
                    {
                        destinationx = destinationx + destination;
                        count = true;
                    }

                    if(count == false && direction == "left")
                    {
                        destinationx = destinationx - destination;
                        count = true;
                    }

                    if(direction == "left" && destinationx > 0)
                    {
                        destinationx = destinationx * -1;
                    }
                    if (destinationx < x)
                    {
                        if (direction == "left" && currotation <  1.52m)
                        {
                            Rotate(0, currotation += 0.08m, 0);
                        }
                        else if (direction == "left" && currotation >  1.52m)
                        {
                            Rotate(0, currotation -= 0.08m, 0);
                        }
                        else
                        {
                            Move(x - 0.08m, y, z);
                        }

                    }

                    else if (destinationx == x)
                    {
                        des += 1;
                        dir += 1;
                        count = false;
                        if (des < destinations.Count())
                        {
                            direction = directions[dir];
                            destination = destinations[des];
                        }
                    }

                    else
                    {
                        if (direction == "right" && currotation < - 1.52m)
                        {
                            Rotate(0, currotation += 0.08m, 0);
                        }
                        else if(direction == "right" && currotation > - 1.52m)
                        {
                            Rotate(0, currotation -= 0.08m, 0);
                        }
                        else
                        {
                            Move(x + 0.08m, y, z);
                        }
                    }
                }
                else
                {
                    if (count == false && direction == "up")
                    {
                        destinationz = destinationz + destination;
                        count = true;
                    }

                    if( count == false && direction == "down")
                    {
                        destinationz = destinationz - destination;
                        count = true;
                    }
                    if (destinationz < z * -1)
                    {
                        if (direction == "down" && currotation < 3.04m)
                        {
                            Rotate(0, currotation += 0.08m, 0);
                        }
                        else
                        {
                            Move(x, y, z + 0.08m);
                        }
                    }

                    else if (destinationz == z * -1)
                    {
                        des += 1;
                        dir += 1;
                        count = false;

                        if (des < destinations.Count())
                        {
                            direction = directions[dir];
                            destination = destinations[des];
                        }
                        else if (des == destinations.Count())
                        {
                            stop = true;
                            GC.Collect();
                        }
                    }
                    else
                    {
                        if (direction == "up" && currotation < 0)
                        {
                            Rotate(0, currotation += 0.08m, 0);
                        }
                        else if (direction == "up" && currotation > 0)
                        {
                            Rotate(0, currotation -= 0.08m, 0);
                        }
                        else
                        {
                            Move(x, y, z - 0.08m);
                        }
                    }
                }
            }
            GC.Collect();
        }

        public override bool Update(int tick)
        {
            movehandler();
            if (needsUpdate)
            { 
                needsUpdate = false;
                return true;
            }
            return false;
        }
    }
}