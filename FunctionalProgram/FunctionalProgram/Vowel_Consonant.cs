using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class Vowel_Consonant
    {
       
        public void CheckAlphabet()             
        {
            while(true)
            {
                Console.Write(" Enter the Alphabet (A-Z or a-z) : ");
                char choice = char.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
                Console.ReadLine();
            }
            
           
         }
         
    }
}
