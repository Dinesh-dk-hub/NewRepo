using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class SwapNumbers
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter the number to swap");
            Console.WriteLine("Num1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Num2:");
            int b = Convert.ToInt32(Console.ReadLine());
            

            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Numbers After Swaping");
            Console.WriteLine("Num1: {0}", a);
            Console.WriteLine("Num2: {0}", b);
        }
    }
}
