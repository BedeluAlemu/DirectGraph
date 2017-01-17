using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectGraph
{
    class DirectedGraph
    {
        int max = 50;
        int n;
        int e;
        bool[,] adj;
        vertex[] vertexList;
        public DirectedGraph()
        {
            adj = new bool[max,max];
            vertexList = new vertex[max];
        }
        public int GetnumVertices()
        {
            return n;
        }
        public int GetnumEdge()
        {
            return e;
        }
        public void Display()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (adj[i,j])
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void InsertVertex(string name)
        {
            vertexList[n++] = new vertex(name);
        }
        public int GetIndex(string s)
        {
            for (int i = 0; i < n; i++)
            {
                if (s.Equals(vertexList[i].name))
                    return i;
            }
            throw new System.InvalidOperationException("Not a valid edge");
        }
        public void InserEdge(string s1, string s2)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (u == v)
                throw new System.InvalidOperationException("Not a valid edge");
            else if (adj[u,v]== true)
            {
                Console.WriteLine("Edge already Exist");
            }
            else
            {
                adj[u, v] = true;
                e++;
            }
        }
        public void DeleteEdge(string s1, string s2)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (adj[u,v]== false)
            {
                Console.WriteLine("Edge does not Exist");
            }
            else
            {
                adj[u, v] = false;
                e--;
            }
        }
        public int Outdegree(string s)
        {
            int row = GetIndex(s);
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                if (adj[row, i] == true)
                     num ++;
            }
           
           return num;
        }
        public int Indegree(string s)
        {
            int col = GetIndex(s);
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                if (adj[i, col] == true)
                    num++;
            }

            return num;
        }
    }
}
