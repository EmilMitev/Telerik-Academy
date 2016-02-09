namespace Task2_OfficeSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        private static  HashSet<int> Visited = new HashSet<int>();
        private static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var depend = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                depend[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                graph[numbers[i]] = new List<int>();
            }


            for (int i = 0; i < depend.Length; i++)
            {
                var Dep = depend[i];

                for (int j = 0; j < Dep.Count; j++)
                {
                    var currDep = Dep[j];
                    if (currDep == 0)
                    {
                        continue;
                    }

                    graph[numbers[currDep - 1]].Add(numbers[i]);
                }

            }

            long maxSum = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long sum = DFS(numbers[i]);
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }

            Console.WriteLine(maxSum);



            //foreach (var node in graph)
            //{
            //    Console.Write(node.Key + " -> ");

            //    foreach (var neighbors in node.Value)
            //    {
            //        Console.Write(neighbors + " ");
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine();
        }

        public static long DFS(int node)
        {
            var nodes = new Stack<int>();
            nodes.Push(node);
            long sum = 0;
            Visited = new HashSet<int>();

            Visited.Add(node);

            while (nodes.Count != 0)
            {
                int currentNode = nodes.Pop();
                sum += currentNode;


                for (int i = 0; i < graph[currentNode].Count; i++)
                {
                    if (!Visited.Contains(graph[currentNode][i]))
                    {
                        nodes.Push(graph[currentNode][i]);
                        Visited.Add(graph[currentNode][i]);
                    }
                    else
                    {
                        sum = -1;
                        break;
                    }
                }
            }

            return sum;
        }
    }
}