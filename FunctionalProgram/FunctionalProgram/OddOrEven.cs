using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class OddOrEven
    {
       
        public void Calculate()             
        {
            Console.WriteLine("Enter the number");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("This is a even number");
            }
            else
            {
                Console.WriteLine("This is a odd number");
            }

            Console.ReadLine();
        }
    }
}
