using System;



namespace CalculatorApp

{

    

    delegate int ArithmeticOperation(int a, int b);



    class Program

    {

        static void Main(string[] args)

        {

          

            ArithmeticOperation add = (a, b) => a + b;

            ArithmeticOperation subtract = (a, b) => a - b;

            ArithmeticOperation multiply = (a, b) => a * b;



           

            Console.Write("Enter the  1st integer: ");

            int num1 = int.Parse(Console.ReadLine());



            Console.Write("Enter the 2nd integer: ");

            int num2 = int.Parse(Console.ReadLine());



          

            int resultAddition = add(num1, num2);

            int resultSubtraction = subtract(num1, num2);

            int resultMultiplication = multiply(num1, num2);



           

            Console.WriteLine($"Addition Result: {resultAddition}");

            Console.WriteLine($"Subtraction Result: {resultSubtraction}");

            Console.WriteLine($"Multiplication Result: {resultMultiplication}");



            Console.ReadLine(); 

        }

    }

}