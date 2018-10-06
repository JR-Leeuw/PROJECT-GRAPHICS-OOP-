using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moving
{
    public class Graph
    {
        //generates the shortest path with a an output of characters
        public string Main1()
        {
            cargo_generator c = new cargo_generator();
            string cmdline = "A";
            char destination = 'J';
            //char destination = c.orderrandomizer();
            char destination1 = Convert.ToChar(destination);

            List<char> charlist = new List<char>();

            GraphAlgorithm g = new GraphAlgorithm();
            g.add_vertex('A', new Dictionary<char, int>() { { 'B', 4 } });
            g.add_vertex('B', new Dictionary<char, int>() { { 'C', 12 }, { 'D', 12 } });
            g.add_vertex('C', new Dictionary<char, int>() { { 'B', 12 }, { 'E', 4 } });
            g.add_vertex('D', new Dictionary<char, int>() { { 'B', 12 }, { 'F', 4 } });
            g.add_vertex('E', new Dictionary<char, int>() { { 'C', 4 }, { 'G', 4 }, { 'F', 24 } });
            g.add_vertex('F', new Dictionary<char, int>() { { 'D', 4 }, { 'E', 24 }, { 'H', 4 } });
            g.add_vertex('G', new Dictionary<char, int>() { { 'E', 4 }, { 'H', 24 }, { 'I', 4 } });
            g.add_vertex('H', new Dictionary<char, int>() { { 'F', 4 }, { 'G', 24 }, { 'J', 4 } });
            g.add_vertex('I', new Dictionary<char, int>() { { 'G', 4 }, { 'J', 24 } });
            g.add_vertex('J', new Dictionary<char, int>() { { 'H', 4 }, { 'I', 24 } });

            g.shortest_path('A', destination1).ForEach(x => charlist.Add(x));

            cmdline = string.Join(",", charlist.ToArray()) + ",A";
            GC.Collect();
            return cmdline;
        }
    }
}


