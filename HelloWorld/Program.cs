using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine ("Welcome, What is your name?");
            String personName = "";
            personName = Console.ReadLine();

            Console.WriteLine("Hello "  +  personName);
            string carName = "";
            Console.WriteLine("Please type your car name here");
            carName = Console.ReadLine();
            Console.WriteLine("Your " + carName + " is a very nice brand");

            decimal number1;
            decimal number2;

            Console.WriteLine("Enter your first number here");
            
            number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number here");

            number2 = Decimal.Parse(Console.ReadLine());

            decimal sum = number1 + number2;

            decimal division = number1 / number2;
            Console.WriteLine("The Sum is " + sum);
            Console.WriteLine("The Division is " + division);
            Console.ReadLine();
        }
    }
}
