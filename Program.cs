using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceOfJeans = new List<int>
            {
                2, 3
            };

            var priceOfShoes = new List<int>
            {
                4, 5
            };

            var priceOfSkirt = new List<int>
            {
                2, 5, 6
            };

            var priceOfTops = new List<int>
            {
                1, 2, 3, 4
            };

            long result = Result.getNumberOfOptions(priceOfJeans, priceOfShoes, priceOfSkirt, priceOfTops, 13);
        }
    }

    class Result
    {
        public static long getNumberOfOptions(List<int> priceOfJeans, List<int> priceOfShoes, List<int> priceOfSkirt, List<int> priceOfTops, int m)
        {
            long nOptions = 0;
            int flag = 0;
            int je = 0, sh = 0, sk = 0, to = 0;

            while(true)
            {
                if(flag == 0)
                {
                    flag = 4;
                }
                else if(flag == 4)
                {
                    if (to >= priceOfTops.Count - 1)
                    {
                        to = 0;
                        flag = 3;

                        continue;
                    }
                    else
                    {
                        to++;
                    }
                }
                else if (flag == 3)
                {
                    if (sk >= priceOfSkirt.Count - 1)
                    {
                        flag = 2;
                        sk = 0;

                        continue;
                    }
                    else
                    {
                        sk++;
                        flag = 4;
                    }
                    
                }
                else if(flag == 2)
                {
                    if (sh >= priceOfShoes.Count - 1)
                    {
                        flag = 1;
                        sh = 0;

                        continue;
                    }
                    else
                    {
                        sh++;
                        flag = 4;
                    }
                    
                }
                else if(flag == 1)
                {
                    if (je >= priceOfJeans.Count - 1)
                    {
                        break;
                    }
                    else
                    {
                        je++;
                        flag = 4;
                    }
                }

                var sum = priceOfJeans[je] + priceOfShoes[sh] + priceOfSkirt[sk] + priceOfTops[to];

                if (sum <= m)
                    nOptions++;
            }

            return nOptions;
        }
    }
}
