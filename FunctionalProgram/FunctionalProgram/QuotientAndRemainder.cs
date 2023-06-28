using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class QuotientAndRemainder
    {
       
        public void Calculate()             
        {
            Console.WriteLine("Enter the Dividend number");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ivisor number");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend is:" + dividend);
            Console.WriteLine("Divisor is:" + divisor);
            Console.WriteLine("Quotient Number is : " + quotient);
            Console.WriteLine("Remainder Number is : " + remainder);

            Console.ReadLine();
        }
    }
}
