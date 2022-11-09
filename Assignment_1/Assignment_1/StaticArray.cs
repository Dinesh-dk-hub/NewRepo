using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class StaticArray
    {
        public static int Method(int[] arr)
        {
           /* for(int i = 0; i<arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
               
            }*/
            int sum = arr.Sum();
            return sum; 
        }
    }
}
