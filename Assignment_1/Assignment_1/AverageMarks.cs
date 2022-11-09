using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment_1
{
    public class AverageMarks
    {
        public void AvgMarks()
        {
            Console.WriteLine("Enter the average of five students");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sum = arr.Max();
            Console.WriteLine("Highest Mark:  {0}" ,sum);
        }
           }
}
