using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectedGraph DG = new DirectedGraph();

            DG.InsertVertex("xyz");
            DG.InsertVertex("pqr");
            DG.InsertVertex("lmn");
            DG.InsertVertex("abc");

            DG.InserEdge("xyz", "pqr");
            DG.InserEdge("xyz", "abc");
            DG.InserEdge("pqr", "abc");
            DG.InserEdge("abc", "lmn");
            DG.Display();
            Console.ReadLine();

        }
    }
}
