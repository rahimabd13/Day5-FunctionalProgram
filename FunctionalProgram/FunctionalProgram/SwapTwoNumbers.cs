using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class SwapTwoNumbers
    {
       
        public void Swapping()             
        {
            Console.WriteLine("Enter Two Number ");
            int numberone = int.Parse(Console.ReadLine());
            int numbertwo = int.Parse(Console.ReadLine());
            numberone = numberone + numbertwo;
            numbertwo = numberone - numbertwo;
            numberone = numberone - numbertwo;
            Console.WriteLine("After Swapping");
            Console.WriteLine(numberone);
            Console.WriteLine(numbertwo);

            Console.ReadLine();
        }
    }
}
