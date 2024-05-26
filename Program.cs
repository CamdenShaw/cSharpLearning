using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithIntegers();
            OrderPrecedence();

            void OrderPrecedence() {
                int a = 5;
                int b = 4;
                int c = 2;
                int d = a + b * c;
                Console.WriteLine(d);

                d = (a + b) * c;
                Console.WriteLine(d);

                d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
                Console.WriteLine(d);

                d = (a + c) * 4 / a * (a / b) - 14 + 7 - (7 * 3 - (4 - (5 + 6)));
                Console.WriteLine(d);

                int e = 7;
                int f = 4;
                int g = 3;
                int h = (e + f) / g;
                Console.WriteLine(h);
            }

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
