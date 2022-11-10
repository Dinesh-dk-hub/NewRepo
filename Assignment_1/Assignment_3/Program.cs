using System;

namespace Assignment_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*  Employee_Management_System emp = new Employee_Management_System();
              emp.EmployeeDetails();
              Console.ReadKey();

              Manager manager = new Manager();
              manager.EmployeeDetails();
              Console.ReadKey();

              MarketingExcutive marketing_exe = new MarketingExcutive();
              marketing_exe.EmployeeDetails();
              Console.ReadKey();*/

            MyStack myStack = new MyStack();

            myStack.Push(5);
            myStack.Push(20);
            myStack.Push(3);
            myStack.Push(25);
            myStack.PrintStack();
            Console.WriteLine("Clone The Stack: Yes/No");
            string action = Console.ReadLine();
            MyStack myStack_copy;
            switch (action)
            {
                case "Yes":
                    {
                        myStack_copy = myStack;
                        Console.WriteLine("Copied Stack: ");
                        myStack_copy.PrintStack();
                        Console.WriteLine();
                        break;
                    }
                case "No":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect choice!!");
                        break;
                    }
            }
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();

        }
    }
}