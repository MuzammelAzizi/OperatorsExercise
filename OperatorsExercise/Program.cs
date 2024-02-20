using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Use these variables names and values:

            int a = 17;
            int b = 4;

            //Write out operations for addition, subtraction, and multiplication.
            //Use the a and b variables you have already created and store the answer in a new variable

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division = a / b;

            //Addition
            int sum = a + b;
            Console.WriteLine($"{a} + {b} + is the {sum}");

            int Subtraction = a - b;
            Console.WriteLine($"{a} - {b} is {Subtraction}");
    
            int Multiplication = a * b;
            Console.WriteLine($"{a} * {b} is the {Multiplication}");

            //Division
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient}) remainder {remainder}");

            Console.WriteLine("What is the radius of the circle");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            Console.WriteLine(AreaOfCircle(radius));

            //Exercise 2
            //Write your AreaOfCircle method outside of the main method. Call the AreaOfACircle method in the main method.

             static double AreaOfCircle(double radius)
            {
                
                var AreaOfCircle = Math.PI * Math.Pow(radius, 2);
                return AreaOfCircle; 
            }

          



        }
    }
}
