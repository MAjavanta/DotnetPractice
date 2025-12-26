namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please enter the first number");
            var firstNumber = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Please enter the second number");
            var secondNumber = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("[A]dd the numbers");
            Console.WriteLine("[S]ubtract the numbers");
            Console.WriteLine("[M]ultiply the numbers");
            var operation = Console.ReadLine() ?? String.Empty;
            if (operation == string.Empty)
            {
                Console.WriteLine("Invalid operation selected");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                return;
            }
            else
            {
                operation = operation.ToUpper();
            }

            if (operation == "A")
            {
                Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
                Console.WriteLine("Press any key to exit");
            }
            else if (operation == "S")
            {
                Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
                Console.WriteLine("Press any key to exit");
            }
            else if (operation == "M")
            {
                Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
                Console.WriteLine("Press any key to exit");
            }
            else
            {
                Console.WriteLine("Invalid operation selected");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
