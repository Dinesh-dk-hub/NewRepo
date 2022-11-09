using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Calculator
    {
        public void Console_Calculator()
        {
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
          
            Console.WriteLine("Enter your choice:");
            int num = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Enter the digits to perform calculation:");
            
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Addition to be performed");
                        int sum = 0;
                        sum = num1 + num2;
                        Console.WriteLine("Result: {0} ", sum);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Subraction to be performed");
                        int sum = 0;
                        sum = num1 - num2;
                        Console.WriteLine("Result: {0} ", 
                            +sum);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Multiplication to be performed");
                        int sum = 0;
                        sum = num1 * num2;
                        Console.WriteLine("Result:{0} ",+sum);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Division to be performed");
                        int sum = 0;
                        sum = num1/num2;
                        Console.WriteLine("Result: {0} ", +sum);
                        break;
                    }
               
                default:
                    {
                        Console.WriteLine("Wrong choice entered!");
                        break;
                     }
            }
          
            
            }
        }
    }

