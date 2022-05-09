using System;

namespace CalculatorTS
{
    public class Calculator
    {
        public Calculator() { }

        public double Addition(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        public double Subtraction(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public double Multiplication(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public double Division(double firstNum, double secondNum)
        {
            if (firstNum == 0)
                throw new ArgumentOutOfRangeException("firstNum", firstNum, "Division by zero encounter!");

            return firstNum / secondNum;
        }

        public static void Main()
        {
            double answer = 0;
            Calculator calculator = new Calculator();

            answer = calculator.Addition(2,5);
            Console.WriteLine(answer.ToString());

            answer = calculator.Division(10,2);
            Console.WriteLine(answer.ToString());

            answer = calculator.Subtraction(7,1);
            Console.WriteLine(answer.ToString());

            answer = calculator.Multiplication(3,4);
            Console.WriteLine(answer.ToString());
        }
    }   
}
