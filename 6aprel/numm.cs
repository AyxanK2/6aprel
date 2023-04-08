using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6aprel
{
    internal static class numm
    {
        public static void NumSum(this int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine(sum);
        }

        //String daxilində hər simvoldan neçə ədəd olduğunu bildirən extension metod yazın.
        public static void Strsay(this string str)
        {
            foreach (char herf1 in str)
            {
                int count = 0;
                foreach (char herf2 in str)
                {
                    if (herf1 == herf2)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{herf1} = {count}");
            }

        }

    }
}
