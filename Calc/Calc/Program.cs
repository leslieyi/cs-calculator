using System;
using Calc.Calculator;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

            int action = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case 1:
                    {
                        result = MyCalc.Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = MyCalc.Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = MyCalc.Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = MyCalc.Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }

    }
}
