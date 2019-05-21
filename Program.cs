using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_numbers
{
    class Program
    {
        // This statement is swaping the two numbers
        static void Main(string[] args)
        {
            {
                int number5, number6, temp;
                Console.Write("\nInput the First Number : ");
                number5 = int.Parse(Console.ReadLine());
                Console.Write("\nInput the Second Number : ");
                number6 = int.Parse(Console.ReadLine());
                temp = number5;
                number5 = number6;
                number6 = temp;
                Console.Write("\nAfter Swapping : ");
                Console.Write("\nFirst Number : " + number5);
                Console.Write("\nSecond Number : " + number6);
                Console.Read();
            }
        }
    }
}
