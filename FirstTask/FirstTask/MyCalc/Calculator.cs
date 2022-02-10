using System;
using System.Linq;

namespace FirstTask.MyCalc
{
    public class Calculator
    {
        public void RunCalculation()
        {
            //We declare our variables
            string[] allowedOperators = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;
            string restartCheck;

            //Get or Grab the Operator Type
            Console.WriteLine("What Type of calculation do you want to perform? ( +, -, * or /)");
            type = GetCalcType(allowedOperators);

            //We get the first number
            Console.WriteLine("Write the first number");
            num1 = GetCalcNum();

            //We get the second number
            Console.WriteLine("Write the second number");
            num2 = GetCalcNum();

            //Calculation running
            answer = Calculate(num1, num2, type);

            //Write the asnwer
            Console.WriteLine("The Answer is " + answer + "\r\n Write 'yes' to restart application.");

            //check if the user wants to restart the app
            restartCheck = Console.ReadLine();
            if (restartCheck == "yes")
            {
                RunCalculation();
            }
            else
            {
                Environment.Exit(0);
            }

        }

        private static string GetCalcType(string[] allowedOperators)
        {
            //we get the operator
            string type = Console.ReadLine();

            //Check if valid operator is selected
            while (!allowedOperators.Contains(type))
            {
                Console.WriteLine("Choose a valid operator type!");
                type = Console.ReadLine();
            }
            return type;
        }

        private int GetCalcNum()
        {
            int num;
            //checking if the parse is succesful
            //return as boolean
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);

            //as long as boolean is false, it keeps looping the input
            while (!parseCheck)
            {
                Console.WriteLine("Try again! This time with actual nujbers....");
                parseCheck = Int32.TryParse(Console.ReadLine(), out num);
            }

            return num;

        }

        public int Calculate(int num1, int num2, string type)
        {
            //we declare our variables
            int result;

            //check operator type
            if (type == "+")
            {
                result = num1 + num2;
                return result;
            }
            else if (type == "-")
            {
                result = num1 - num2;
                return result;

            }
            else if (type == "*")
            {
                result = num1 * num2;
                return result;
            }
            else
            {
                result = num1 / num2;
                return result;
            }
        }
    }
}
