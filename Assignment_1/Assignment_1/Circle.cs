using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment_1
{
    public class Circle
    {
        public void Circumfernce()
        {
            Console.WriteLine("Enter the Radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
          
            double sum = 2 * 3.14 * radius;
            double area = 3.14 * radius * radius;
            Console.WriteLine("Circumference of a circle: {0}", Math.Round(sum, 2));
            Console.WriteLine("Area of a circle: {0}", Math.Round(area, 2));

        }
    }
}
