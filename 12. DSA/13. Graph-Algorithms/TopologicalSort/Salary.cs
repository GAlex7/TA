namespace TopologicalSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Salary
    {
        static void Main()
        {
            var c = int.Parse(Console.ReadLine());
            var matrix = new bool[c, c];
            var childrensCounts = new int[c];

            for (int row = 0; row < c; row++)
            {
                var rowData = Console.ReadLine().ToLower();
                for (int col = 0; col < c; col++)
                {
                    if (rowData[col] == 'y')
                    {
                        matrix[row, col] = true;
                        childrensCounts[row] += 1;
                    }
                }
            }

            var salary = new long[c];
            var listOfSorted = new List<int>();
            var setWhitoutChildren = new Queue<int>();

            for (int i = 0; i < c; i++)
            {
                if (childrensCounts[i] == 0)
                {
                    setWhitoutChildren.Enqueue(i);
                    salary[i] = 1;
                }
            }

            while (setWhitoutChildren.Count > 0)
            {
                var node = setWhitoutChildren.Dequeue();
                listOfSorted.Add(node);

                for (int i = 0; i < c; i++)
                {
                    if (matrix[i,node])
                    {
                        childrensCounts[i]--;
                        matrix[i,node] = false;
                        salary[i] += salary[node];
                        if (childrensCounts[i]==0)
                        {
                            setWhitoutChildren.Enqueue(i);
                        }
                    }
                }                
            }

            Console.WriteLine(salary.Sum());
        }
    }
}
