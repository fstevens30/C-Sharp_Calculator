using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here: "); //Enter the first number
            double num1 = Convert.ToDouble(Console.ReadLine()); //Converts the number to a double (meaning it accepts decimals)
            Console.WriteLine("Enter another number: "); //Number two entry
            double num2 = Convert.ToDouble(Console.ReadLine()); //Converting number 2 to a double
            Console.WriteLine("Choose an operator from the following list:"); //Choosing an operator
            Console.WriteLine("\ta - Add"); //Entering the string "a" will make it Add the two numbers and so on 
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tp - Power");
            Console.WriteLine("\tr - Remainder");
            Console.WriteLine("Enter your operator: ");
            string op = Console.ReadLine(); //Reads the string entered and saves it as a string 
            double result = 0; //Sets a double of result to 0 to be further modified
            switch (op) //Switch statement for the previously entered string
            {
                case "a":
                    result = num1 + num2; //E.G when "a" is entered it will perform this equation
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear(); //Clears the console and changes the colors of the console when answer is displayed 
                    break;
                case "s":
                    result = num1 - num2;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case "m":
                    result = num1 * num2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                case "d":
                    result = num1 / num2;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    break;
                case "p":
                    result = Math.Pow(num1, num2);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    break;
                case "r":
                    result = num1 % num2;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid operator input"); //If the input is any different from the inputs provided it will show this error
                    break;

            }
            Console.WriteLine("Your result is: "); //It now prints the answer
            Console.WriteLine(result);
        }
    }
}
