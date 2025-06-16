using System;

namespace SimpleConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Console Calculatorssss");
                Console.WriteLine("------------------------");

                // Get first number
                double num1;
                Console.Write("Enter the first number: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter the first number: ");
                }

                // Get operator
                Console.Write("Enter an operator (+, -, *, /): ");
                string operation = Console.ReadLine();

                while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    Console.Write("Enter an operator (+, -, *, /): ");
                    operation = Console.ReadLine();
                }

                // Get second number
                double num2;
                Console.Write("Enter the second number: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter the second number: ");
                }

                // Perform calculation
                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                            validOperation = false;
                        }
                        break;
                }

                // Display result
                if (validOperation)
                {
                    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                }

                // Ask to continue
                Console.WriteLine("\nDo you want to perform another calculation? (yes/no)");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                {
                    Console.WriteLine("Thank you for using the calculator. Goodbye!");
                    break;
                }

                Console.WriteLine(); // Add a blank line for readability
            }
        }
    }
}