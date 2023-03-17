using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrames2
{
    internal class PerfectNumber
    {
        public static void call()
        {
            int n, i, sum;
            int min, max;
            Console.WriteLine("Find the perfect number with in a given Range");
            Console.WriteLine("Input the Starting Range");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Ending Range");
            max = Convert.ToInt32(Console.ReadLine());
            for(n=min; n<=max; n++)
            {
                i = 1;
                sum = 0;
                while(i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
        }
    }
}
