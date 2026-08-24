using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Core.Graphs
{
    /// <summary>
    /// Adjacenty Matrix Implementation
    /// - Represents an N vertex graph using an NxN matrix.
    /// </summary>
    public class AdjacencyMatrix<T> : IGraph<T> where T : notnull
    {
        public int NumberOfNodes { get; private set; }
        public decimal[,] Matrix { get; private set; }
        public Dictionary<T, int> LookUpTable { get; private set; }

        private int Index { get; set; }

        public AdjacencyMatrix(int nodes)
        {
            NumberOfNodes = nodes;
            LookUpTable = new Dictionary<T, int>();
            Matrix = new decimal[nodes, nodes];
            Index = 0;
        }

        public bool AddEdge(T source, T target, decimal weight = 1)
        {
            try
            {
                if (LookUpTable.ContainsKey(source) == false)
                {
                    LookUpTable.Add(source, Index++);
                }

                if (LookUpTable.ContainsKey(target) == false)
                {
                    LookUpTable.Add(target, Index++);
                }

                if (!HasEdge(source, target))
                {
                    Matrix[LookUpTable[source], LookUpTable[target]] = weight;
                    Matrix[LookUpTable[target], LookUpTable[source]] = weight;

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }

            return false;
        }

        public bool RemoveEdge(T source, T target)
        {
            try
            {
                if (HasEdge(source, target))
                {
                    Matrix[LookUpTable[source], LookUpTable[target]] = 0;
                    Matrix[LookUpTable[target], LookUpTable[source]] = 0;

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }

            return false;
        }

        public bool HasEdge(T source, T target)
        {
            if (!ContainsVertex(source) || !ContainsVertex(target))
            {
                return false;
            }

            return Matrix[LookUpTable[source], LookUpTable[target]] > 0 || Matrix[LookUpTable[target], LookUpTable[source]] > 0;
        }

        public bool ContainsVertex(T vertex)
        {
            return LookUpTable.ContainsKey(vertex);
        }

        public decimal GetWeight(T source, T target)
        {
            if (!ContainsVertex(source) || !ContainsVertex(target))
            {
                return decimal.Zero;
            }

            return Matrix[LookUpTable[source], LookUpTable[target]];
        }

        public List<T> OutEdges(T source)
        {
            var edges = new List<T>();

            if (!ContainsVertex(source))
            {
                return edges;
            }

            var vertices = LookUpTable.Keys.ToArray();
            for (int j = 0; j < NumberOfNodes && j < vertices.Length; j++)
            {
                if (Matrix[LookUpTable[source], j] > 0)
                {
                    edges.Add(vertices[j]);
                }
            }

            return edges;
        }

        public List<T> InEdges(T source)
        {
            var edges = new List<T>();

            if (!ContainsVertex(source))
            {
                return edges;
            }

            var vertices = LookUpTable.Keys.ToArray();
            for (int i = 0; i < NumberOfNodes && i < vertices.Length; i++)
            {
                if (Matrix[i, LookUpTable[source]] > 0)
                {
                    edges.Add(vertices[i]);
                }
            }

            return edges;
        }
    }
}