using System;
using System.Collections.Generic;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            List<int> masWithAllInt = NumberToMas(number);
            List<int> theBestList = new List<int>();
            MasWithAllInt(masWithAllInt, theBestList);
            theBestList.Sort();
            foreach (int item in theBestList)
            {
                if (item > number)
                {
                    return item;
                }
            }
            return null;
        }


        public static List<int> NumberToMas(int number)
        {
            List<int> list = new List<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number /= 10;
            }
            return list;
        }


        public static void MasWithAllInt(List<int> digitMas, List<int> masWithOllInt, int number = 0)
        {
            number *= 10;

            foreach (int item in digitMas)
            {
                number += item;
                if (digitMas.Count == 1)
                {
                    masWithOllInt.Add(number);
                    break;
                }
                List<int> lhelp = new List<int>();
                bool b = false;

                foreach (var item1 in digitMas)
                {
                    if (item1 != item || b)
                    {
                        lhelp.Add(item1);
                    }
                    else
                    {
                        b = true;
                    }
                }
                MasWithAllInt(lhelp, masWithOllInt, number);
                number -= item;
            }
        }
    }
}
