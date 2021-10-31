using System;

namespace CalculatorLogic
{
    public class Class1
    {
        //this method below in CalculatorLogics shared class library accepts two double data type numbers and return their sum
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        //this method below in CalculatorLogics shared class library accepts two double data type numbers and return the result by subtracting second number from the first number
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        //this method below in CalculatorLogics shared class library accepts two double data type numbers and return the result by multiplying the two numbers
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        //this method below in CalculatorLogics shared class library accepts two double data type numbers and return the result by dividing first number by secind number
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
