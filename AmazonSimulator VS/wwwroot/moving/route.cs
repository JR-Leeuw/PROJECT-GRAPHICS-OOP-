using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moving
{
    public class route
    {
        //in totaal 10 punten op de map

        //A connected met B
        //B connected met A, C, D
        //C connected met B, E
        //D connected met B, F
        //E connected met C, F, G
        //F connected met D, E, H
        //G connected met E, H, I
        //H connected met F, G, J
        //I connected met G, J
        //J connected met H, I

        static List<List<String>> input = new List<List<string>>{
               new List<String>() {"A","B"},
               new List<String>() {"B","A","C","D"},
               new List<String>() {"C","B","E"},
               new List<String>() {"D","B","F"},
               new List<String>() {"E","C","F","G"},
               new List<String>() {"F", "D", "E", "H"},
               new List<String>() {"G", "E", "H", "I"},
               new List<String>() {"H", "F", "G", "J"},
               new List<String>() {"I", "G", "J"},
               new List<String>() {"J", "H", "I"}
        };
                           

    }
}
