﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class Factors
    {
       
        public void Factor()             
        {
            int num;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
