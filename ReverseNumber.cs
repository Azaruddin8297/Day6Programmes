﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrames2
{
    internal class ReverseNumber
    {
        public static void call()
        {
            Console.WriteLine("Please Enter the Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reveresed Number is : "+reverse);

        }
    }
}
