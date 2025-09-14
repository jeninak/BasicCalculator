namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                char operation = Console.ReadLine()[0];

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Error: Division by zero");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        continue;
                }

                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

                Console.Write("Do you want to calculate again? (y/n): ");
                string again = Console.ReadLine().Trim().ToLower();
                if (again != "y")
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Keeps console open until user prompts it to exit
        }
    }
}