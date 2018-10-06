using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moving
{
    public class movement_control
    {
        private static string cmdcommand;
        private string rotation;
        private string movement;
        private string item1;
        private string item2;
        private int a;
        private int b;
        private int c;
        private int d;
        private int distance;
        private int a2;
        private int b2;
        private int c2;
        private int d2;
        private int e2;
        private string a3;
        private string b3;
        private string c3;
        private string d3;
        private string e3;
            

        int[] A = new int[] { 0, 4 };
        int[] B = new int[] { 0, 8 };
        int[] C = new int[] { -12, 8 };
        int[] D = new int[] { 12, 8 };
        int[] E = new int[] { -12, 12 };
        int[] F = new int[] { 12, 12 };
        int[] G = new int[] { -12, 16 };
        int[] H = new int[] { 12, 16 };
        int[] I = new int[] { -12, 20 };
        int[] J = new int[] { 12, 20 };

        string[] coordinates;

        bool count;
        int calc;
        
        //outputs all all directions and destinations
        public (int, string, int, string, int, string, int, string, int, string) main()
        {
            Graph b = new Graph();
            cmdcommand = b.Main1();
            coordinates = cmdcommand.Split(',');
            var a1 = Distance();
            var b1 = Distance();
            var c1 = Distance();
            a2 = a1.Item1;
            a3 = a1.Item2;
            b2 = b1.Item1;
            b3 = b1.Item2;
            c2 = c1.Item1;
            c3 = c1.Item2;
            if (calc == 5)
            {
                var d1 = Distance();
                d2 = d1.Item1;
                d3 = d1.Item2;
            }
            else if (calc == 6)
            {
                var d1 = Distance();
                var e1 = Distance();
                d2 = d1.Item1;
                d3 = d1.Item2;
                e2 = e1.Item1;
                e3 = e1.Item2;
            }
            else
            {
                d2 = 0;
                d3 = "0";
                e2 = 0;
                e3 = "0";
            }

            return (a2, a3, b2, b3, c2, c3, d2, d3, e2, e3);
        }

        //returns the opposite path of the main method
       public (string, string, string, string, string)inverted()
        {
            var instructions = main();
            List<string> olddirections = new List<string>();
            List<string> newdirections = new List<string>();
            olddirections.Add(e3);
            olddirections.Add(d3);
            olddirections.Add(c3);
            olddirections.Add(b3);
            olddirections.Add(a3);
            foreach (string s in olddirections)
            {
                if(s == "up")
                {
                    newdirections.Add("down");
                }
                else if(s == "down")
                {
                    newdirections.Add("up");
                }
                else if(s == "right")
                {
                    newdirections.Add("left");
                }
                else if(s == "left")
                {
                    newdirections.Add("right");
                }
                else
                {
                    //do nothing
                }
            }
            if(newdirections.Count() == 3)
            {
                newdirections.Add("0");
                newdirections.Add("0");
            }

            else if(newdirections.Count == 4)
            {
                newdirections.Add("0");
            }

            string a4 = newdirections[4];
            string b4 = newdirections[3];
            string c4 = newdirections[2];
            string d4 = newdirections[1];
            string e4 = newdirections[0];
            return (e4, d4, c4, b4, a4);
        }

        //calculates the distance and direction for moving between two coordinates
        public (int, string) Distance()
        {
            a = 100;
            c = 100;
            var items = cordscalc();
            item1 = items.Item1;
            item2 = items.Item2;
            var coordinaten = arrayselector();
            int x1 = coordinaten.Item1;
            int z1 = coordinaten.Item2;
            coordinaten = arrayselector();
            int x2 = coordinaten.Item1;
            int z2 = coordinaten.Item2;
            string direction;

            if(x1 == x2)
            {
                if(z1 > z2)
                {
                    distance = z1 - z2;
                    direction = "down";
                }

                else
                {
                    distance = z2 - z1;
                    direction = "up";
                }
            }

            else
            {
                if (x1 > x2)
                {
                    distance = x1 - x2;
                    direction = "left";
                }

                else
                {
                    distance = x2 - x1;
                    direction = "right";
                }
            }

            return (distance, direction);
        }

        public (string, string) cordscalc()
        {
            if (count == false)
            {
                count = true;
                calc = coordinates.Count();
            }
            item1 = coordinates[coordinates.Count() - 1];
            item2 = coordinates[coordinates.Count() - 2];
            Array.Resize(ref coordinates, coordinates.Count() - 1);
            return (item1, item2);
        }

        //gets information about the x and z of each points (or character) and returns it
        public (int, int) arrayselector()
        {
            if (item1 == "A" || item2 == "A")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = A[0];
                    b = A[1];
                    return (a,b);
                }
                else if(c == 100)
                {
                    c = A[0];
                    d = A[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "B" || item2 == "B")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = B[0];
                    b = B[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = B[0];
                    d = B[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "C" || item2 == "C")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = C[0];
                    b = C[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = C[0];
                    d = C[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "D" || item2 == "D")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = D[0];
                    b = D[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = D[0];
                    d = D[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "E" || item2 == "E")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = E[0];
                    b = E[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = E[0];
                    d = E[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "F" || item2 == "F")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = F[0];
                    b = F[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = F[0];
                    d = F[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "G" || item2 == "G")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = G[0];
                    b = G[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = G[0];
                    d = G[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "H" || item2 == "H")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = H[0];
                    b = H[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = H[0];
                    d = H[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "I" || item2 == "I")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = I[0];
                    b = I[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = I[0];
                    d = I[1];
                    return (c, d);
                }
                return (0, 0);
            }

            if (item1 == "J" || item2 == "J")
            {
                if (a == 100)
                {
                    item1 = "AA";
                    a = J[0];
                    b = J[1];
                    return (a, b);
                }
                else if (c == 100)
                {
                    c = J[0];
                    d = J[1];
                    return (c, d);
                }
                return (0, 0);
            }
            else
            {
                return (0, 0);
            }
        }
    }
}
