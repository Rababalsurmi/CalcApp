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

                //Ask user to type Array.
                double[] array = new double[5];
                Console.Write("Input 5 elements in the array :\n");

                for (int j = 0; j < 5; j++)
                {
                    Console.Write("element - {0} : ", j);
                    array[j] = Convert.ToDouble(Console.ReadLine());
                }

                //Display Menu
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                DoOperation(cleanNum1, cleanNum2, op, array);
               

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

        public static double DoOperation(double num1, double num2, string op, params double[] array)
        {
            double result = 0;

            switch (op)
            {
                case "a":
                    Add(num1, num2);
                    Add(array);
                    break;
                case "s":
                    Subtract(num1, num2);
                    Subtract(array);
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

        public static double Add(params double[] array)
        {
            double result = 0;
            for (int i = 0; i < array.Length; i++)
                result += array[i];
            Console.WriteLine("The sum of the elements of the array is {0}", result);
            return result;


            //if (n != null)
            //{
            //    foreach (int i in n)
            //    {

            //        Console.WriteLine($"Your result: " + (result += i));
            //    }
            //}
            //return result;
        }

        public static double Subtract(double num1, double num2)
        {
            double result;
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            
            return result;
        }

        public static double Subtract(params double[] array)
        {
            double result = array[0];

            for (int i = 1; i < array.Length; i++)
                result -= array[i];

            Console.WriteLine("The subtraction of the elements of the array is {0}", result);
            return result;

        }

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
            
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            
            else
            {
                Console.WriteLine("Oops! Cannot proceed with a Zero divisor!");
                return 0;
            }
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            return result;
            
        }
    }
}
