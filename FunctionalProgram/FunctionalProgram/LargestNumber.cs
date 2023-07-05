using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class LargestNumber
    {
       
        public void Find()             
        {
            Console.WriteLine("Enter Three Number");
            int numone = Convert.ToInt32(Console.ReadLine());
            int numtwo = Convert.ToInt32(Console.ReadLine());
            int numthree = Convert.ToInt32(Console.ReadLine());
            if ((numone > numtwo) && (numone > numthree))
            {
                Console.WriteLine("NumOne is a Largest Number");
            }
            else if (numtwo > numthree)
            {
                Console.WriteLine("NumTwo is a Largest Number");
            }
            else
            {
                Console.WriteLine("NumThree is a Largest Number");
            }
            Console.ReadLine();
        }
            
           
    }
}
