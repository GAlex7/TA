namespace Problem5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program5
    {
        static void Main()
        {
            string input;
            string result = string.Empty;
            string subRes = string.Empty;

            int step = int.Parse(Console.ReadLine());

            for (int i = 0; i < step; i++)
            {
                input = Console.ReadLine();

                bool isAfter = input.IndexOf("after") != -1 ? true : false;

                subRes = isAfter ?
                    input[input.Length - 1] + input[0].ToString() :
                    input[0].ToString() + input[input.Length - 1];

                if (subRes[0] == subRes[1])
                    continue;
                //int first = int.Parse(input[0].ToString());
                //int second = int.Parse(input[input.Length - 1].ToString());

                int posFirst = result.IndexOf(subRes[0]);
                int posSecond = result.IndexOf(subRes[1]);

                if (result.Length == 0)
                {
                    result = subRes;
                    continue;
                }

                if (posFirst == -1 && posSecond == -1)
                {
                    bool check = false;
                    if (result[0] > subRes[0])
                    {
                        result = result.Insert(0, subRes);
                        continue;
                    }
                    else
                    {
                        for (int j = 1; j < result.Length; j++)
                        {
                            if ((result[j - 1] < subRes[0]) && (subRes[0] < result[j]))
                            {
                                result = result.Insert(j, subRes);
                                check = true;
                                break;
                            }
                        }
                    }
                    if (!check)
                    {
                        result = result + subRes;
                        continue;
                    }

                }
                else if (posSecond == -1)
                {
                    result = result.Insert(posFirst + 1, subRes[1].ToString());
                }
                else if (posFirst == -1)
                {
                    result = result.Insert(posSecond, subRes[0].ToString());
                }
            }


            Console.WriteLine(result);
        }
    }
}
