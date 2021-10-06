using System;


namespace CalculatorProgram

{
    public class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Welcome To My Calculater!\r");
            Console.WriteLine("------------------------\n");

            Console.Write("press any other key and Enter to start, or Press 'n' and Enter to close the app : ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");

            //CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();

            while (!endApp)
            {
                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                double cleanNum1;
                cleanNum1 = GetNumberFromUser();

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                double cleanNum2;
                cleanNum2 = GetNumberFromUser();

                //double[] n = new double[10];
                //for (int i = 0; i < 10; i++)
                //{
                //    n[i] = GetNumberFromUser();
                //}

                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                DoOperation(cleanNum1, cleanNum2, op);
               

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("To close the app Press 'n' and Enter, To Continue Press any other key and Enter: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }

            return;
        }
        public static double GetNumberFromUser()
        {
            bool succeeded = false;
            double userInput = 0;
            while (!succeeded)
            {
                succeeded = double.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }

        public static double DoOperation(double num1, double num2, string op)
        {
            double result = 0;

            switch (op)
            {
                case "a":
                    Add(num1, num2);
                    break;
                case "s":
                    Subtract(num1, num2);
                    break;
                case "m":
                    Multiply(num1, num2);
                    break;
                case "d":
                    Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    break;
            }
            return result;
        }
        

        public static double Add(double num1, double num2)
        {
            double result;
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
           
            return result;
        }

        //public static double Add(double num1, double num2, params double[] n)
        //{
        //    double result;

        //    result = num1 + num2;
            
        //    if (n != null)
        //    {
        //        foreach (int i in n)
        //        {

        //            Console.WriteLine($"Your result: " + (result += i));
        //        }
        //    }
        //    return result;
        //}

        public static double Subtract(double num1, double num2)
        {
            double result;
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            
            return result;
        }

        //public static double Subtract(double num1, double num2, params double[] n)
        //{
        //    double result;
        //    result = num1 - num2;
            
            
        //    if (n != null)
        //    {
        //        foreach (int i in n)
        //        {
        //            Console.WriteLine($"Your result: " + (result -= i));
        //        }
        //    }
        //    return result;
        //}

        public static double Multiply(double num1, double num2)
        {
            double result;
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            
            return result;
        }

        public static double Divide(double num1, double num2)
        {
            double result;
            result = num1 / num2;
            while (num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor: ");
                Console.WriteLine();
                num2 = GetNumberFromUser();
            }
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            
            return result;
        }
    }
}