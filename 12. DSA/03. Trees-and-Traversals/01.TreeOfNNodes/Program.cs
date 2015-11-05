namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class TreeExample
    {
        public static void Main()
        {
            // TODO Comment to first empty line :)
            var input = @"7
            2 4
            3 2
            5 0
            3 5
            5 6
            5 1";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var nodesCount = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[nodesCount];

            for (int i = 0; i < nodesCount; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= nodesCount - 1; i++)
            {
                var pair = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

                var parentId = pair[0];
                var childId = pair[1];
                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            var root = FindRoot(nodes);

            var leafs = FindAllLeafs(nodes);

            var middleNodes = FindAllMiddleNodes(nodes);

            var longestPath = FindLongestPathFromRoot(FindRoot(nodes));

            var sum = 5;
            var pathWithGivenSum = new List<Node<int>>();
            FindPathWithGivenSum(FindRoot(nodes), sum, 0, pathWithGivenSum);
        }

        // global ResultList
        // function ProcessNode(CurrentNode, CurrentSum)
        //    CurrentSum += CurrentNode->Value
        //    if (CurrentSum == SumYouAreLookingFor)
        //                AddNodeTo ResultList
        //    for all Children of CurrentNode
        //          ProcessNode(Child, CurrentSum)
        private static void FindPathWithGivenSum(Node<int> node, int sum, int currentSum, List<Node<int>> pathWithGivenSum)
        {
            currentSum += node.Value;

            if (currentSum == sum)
            {
                pathWithGivenSum.Add(node);
            }

            foreach (var child in node.Children)
            {
                FindPathWithGivenSum(child, sum, currentSum, pathWithGivenSum);
            }
        }

        private static int FindLongestPathFromRoot(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;

            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPathFromRoot(node));
            }

            return maxPath + 1;
        }

        private static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            var result = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count > 0 && node.HasParent)
                {
                    result.Add(node);
                }
            }

            return result;
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            var result = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    result.Add(node);
                }
            }

            return result;
        }

        private static Node<int> FindRoot(Node<int>[] nodes)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                if (!nodes[i].HasParent)
                {
                    return nodes[i];
                }
            }

            throw new ArgumentNullException("The tree has not a root!");
        }
    }
}