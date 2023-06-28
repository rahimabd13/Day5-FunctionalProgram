using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class HarmonicNumber
    {
       
        public void Harmonic()             
        {
          int n;
          double s = 0;
          Console.WriteLine("Enter a number");
          n = Convert.ToInt32(Console.ReadLine());
          for (int i = 1; i <= n; i++)
          {
            Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
          }
            Console.WriteLine("\nSum of Series updo {0} terms : {1} ", n, s);

          Console.ReadLine();
        }
    }
}
