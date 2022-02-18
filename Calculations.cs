using System;
using System.Globalization;

namespace Calculator
{
    class Calculations
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Calculator!!");
            Console.WriteLine("------------");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - divison");
            Console.WriteLine("5 - Potentiation");
            Console.WriteLine("6 - Square Root");

            Console.Write("Which Calculation?  ");
            var op = short.Parse(Console.ReadLine());

            switch (op)
            {
                case 0: Console.WriteLine("Closing Program..."); Environment.Exit(0); break;
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: Potentiation(); break;
                case 6: SquareRoot(); break;
                default: Console.WriteLine("choose an option between 0 and 5!!"); Menu(); break;
            }
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Sum!!!");
            Console.WriteLine();
            Console.Write("Enter with first value: ");
            var n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter with second value: ");
            var n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var result = n1 + n2;
            Console.WriteLine();
            Console.WriteLine("The sum result is " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }
        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Subtraction!!!");
            Console.WriteLine();
            Console.Write("Enter with first value: ");
            var n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter with second value: ");
            var n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var result = n1 - n2;
            Console.WriteLine();
            Console.WriteLine("The subtraction result is " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Multiplication!!!");
            Console.WriteLine();
            Console.Write("Enter with first value: ");
            var n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter with second value: ");
            var n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var result = n1 * n2;
            Console.WriteLine();
            Console.WriteLine("The multiplication result is " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Division!!!");
            Console.WriteLine();
            Console.Write("Enter with first value: ");
            var n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter with second value: ");
            var n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n1 == 0 || n2 == 0) throw new ArithmeticException("Não existe divisão por 0");

            var result = n1 / n2;
            Console.WriteLine();
            Console.WriteLine("The division result is " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }
        static void Potentiation()
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Potentiation!!!");
            Console.WriteLine();
            Console.Write("Enter with basis of potentiation: ");
            var n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter with exponent of potentiation: ");
            var n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var result = Math.Pow(n1, n2);
            Console.WriteLine();
            Console.WriteLine("The potentiation result is " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }

        static void SquareRoot()
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Square Root");
            Console.WriteLine();
            Console.Write("You want to know the square root of which number? ");
            var n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var result = Math.Sqrt(n1);
            Console.WriteLine();
            Console.WriteLine($"The square root of {n1} is " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();

        }
    }
}
