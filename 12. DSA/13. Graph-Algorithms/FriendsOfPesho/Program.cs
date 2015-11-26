namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private class Node : IComparable<Node>
        {
            public Node(int v, byte w)
            {
                this.Vertex = v;
                this.Weight = w;
            }

            public int Vertex { get; set; }

            public byte Weight { get; set; }

            public int CompareTo(Node other)
            {
                if (this.Weight.CompareTo(other.Weight) == 0)
                {
                    return this.Vertex.CompareTo(other.Vertex);
                }

                return this.Weight.CompareTo(other.Weight);
            }
        }

        public static void Main()
        {
            //            var input = @"5 8 2
            //1 2
            //1 2 5
            //4 1 2
            //1 3 1
            //3 4 4
            //4 5 1
            //2 4 3
            //5 2 1
            //2 3 20";

            //            Console.SetIn(new StringReader(input));

            var nmh = Console.ReadLine().Split(' ');
            var n = int.Parse(nmh[0]);
            var m = int.Parse(nmh[1]);
            var h = int.Parse(nmh[2]);

            var s = new List<int>();
            var starts = Console.ReadLine().Split(' ');
            for (int i = 0; i < h; i++)
            {
                s.Add(int.Parse(starts[i]) - 1);
            }

            var graph = new List<Node>[n];

            for (int i = 0; i < m; i++)
            {
                var edge = Console.ReadLine().Split(' ');
                var from = int.Parse(edge[0]) - 1;
                var to = int.Parse(edge[1]) - 1;
                var dist = byte.Parse(edge[2]);
                AddToGraph(graph, from, to, dist);
            }

            var result = new SortedSet<int>();
            var d = new int[n];

            foreach (var start in s)
            {
                d = Dijksrta(graph, start);
                var currentSum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (!s.Contains(i))
                    {
                        currentSum += d[i];
                    }
                }

                result.Add(currentSum);
            }

            Console.WriteLine(result.Min);
        }

        private static int[] Dijksrta(List<Node>[] graph, int start)
        {
            var n = graph.Length;
            var visited = new bool[n];
            var d = Enumerable.Repeat(int.MaxValue, n).ToArray();
            d[start] = 0;

            var queue = new SortedSet<Node>();

            queue.Add(new Node(start, 0));

            visited[start] = true;

            while (queue.Count > 0)
            {
                var currentNode = queue.Min;
                queue.Remove(currentNode);
                visited[currentNode.Vertex] = true;

                // calculate distance
                if (graph[currentNode.Vertex] != null)
                {
                    foreach (var child in graph[currentNode.Vertex])
                    {
                        var currentD = d[child.Vertex];
                        var newD = d[currentNode.Vertex] + child.Weight;
                        if (currentD > newD)
                        {
                            d[child.Vertex] = newD;
                            queue.Add(new Node(child.Vertex, (byte)newD));
                        }
                    };
                }

                // remove top visited
                while (queue.Count > 0 && visited[queue.Min.Vertex])
                {
                    queue.Remove(queue.Min);
                }
            }
            return d;
        }

        private static void AddToGraph(List<Node>[] graph, int f, int t, byte w)
        {
            if (graph[f] == null)
            {
                graph[f] = new List<Node>();
            }

            graph[f].Add(new Node(t, w));

            if (graph[t] == null)
            {
                graph[t] = new List<Node>();
            }

            graph[t].Add(new Node(f, w));
        }
    }
}
