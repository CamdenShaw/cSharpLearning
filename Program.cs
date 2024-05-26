using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithIntegers();
            
            void WorkWithIntegers() {
                int a = 18;
                int b = 6;
                int c = a + b;
                Console.WriteLine(c);
                // subtraction
                c = a - b;
                Console.WriteLine(c);

                // multiplication
                c = a * b;
                Console.WriteLine(c);

                // division
                c = a / b;
                Console.WriteLine(c);

                // other experiments
                c = a + b - 12 * 17;
                Console.WriteLine(c);
                
                double d = a - b * 122 / 7 - Math.PI;
                Console.WriteLine(d);
            }
        }
    }
}
