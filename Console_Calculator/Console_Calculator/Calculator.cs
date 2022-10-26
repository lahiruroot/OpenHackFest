using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class Calculator
    {
        public void myCalc()
        {
            Double number1;
            Double number2;

            String num1 = null;
            String num2 = null;
            bool isValidate = false;

            do
            {
                Console.WriteLine("Please Enter Number_1:");
                num1 = Console.ReadLine();
                isValidate = string.IsNullOrEmpty(num1);
                if (isValidate)
                {
                    Console.WriteLine("Sorry, Enter a Number...");
                    num1 = Console.ReadLine();
                }
                else if (!double.TryParse(num1, out number1))
                {
                    Console.WriteLine("Please Enter a Valueable Number...");
                    num1 = Console.ReadLine();
                }
                else
                {
                    //Console.WriteLine("Continue...");
                }
                isValidate = string.IsNullOrEmpty(num1);
            } while (isValidate);
            //////////////////////////////////////////////////////////////////////////////////////
            do
            {
                Console.WriteLine("Please Enter Number_2:");
                num2 = Console.ReadLine();
                isValidate = string.IsNullOrEmpty(num2);
                if (isValidate)
                {
                    Console.WriteLine("Sorry, Enter a Number...");
                    num2 = Console.ReadLine();
                }
                else if (!double.TryParse(num2, out number2))
                {
                    Console.WriteLine("Please Enter a Valueable Number...");
                    num2 = Console.ReadLine();
                }
                else
                {
                    // Console.WriteLine("Continue...");
                }
                isValidate = string.IsNullOrEmpty(num2);
            } while (isValidate);

            number1 = double.Parse(num1);
            number2 = double.Parse(num2);

            Console.WriteLine("{0}+{1}=" + (number1 + number2), number1, number2);
            Console.ReadLine();
        }
    }
}
