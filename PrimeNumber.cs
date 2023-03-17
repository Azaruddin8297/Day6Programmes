using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrames2
{
    internal class PrimeNumber
    {
        public static void call()
        {
            Console.WriteLine("Please Enter the Number");
            int num =Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i;
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }   
                if(count == 2)
                {
                    Console.WriteLine("Enterd Number is prime number");
                }
                else
                {
                    Console.WriteLine("Entered number is not a prime number");
                }
            
        }

    }

}
