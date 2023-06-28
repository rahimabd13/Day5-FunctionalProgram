using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class PowerOfTwo
    {
       
        public void Power()             
        {
            int p, n;
            for (int i = 0; i < 10; i++)
            {
                p = 1;
                n = i;
                while(n>0)
                {
                    p *= 2;
                    n--;
                }

                Console.WriteLine("Two to the " + i + " Power is " + p);
            }



            Console.ReadLine();
        }
    }
}
