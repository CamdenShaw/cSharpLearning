using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithIntegers();
            OrderPrecedence();
            TestLimits();
            WorkWithDoubles();

            void TestLimits() {
                int a = 7;
                int b = 4;
                int c = 3;
                int d = (a + b) / c;
                int e = (a + b) % c;
                Console.WriteLine($"quotient: {d}");
                Console.WriteLine($"remainder: {e}");
                
                int maxInt = int.MaxValue;
                int minInt = int.MinValue;
                Console.WriteLine($"The range of integers is {minInt} to {maxInt}");

                int what = maxInt + 3;
                Console.WriteLine($"An example of overflow: {what}");
            }

            void WorkWithDoubles() {
                double aa = 5;
                double bb = 4;
                double cc = 2;
                double dd = (aa + bb) / cc;
                Console.WriteLine(dd);

                double ee = 19;
                double ff = 23;
                double gg = 8;
                double hh = (ee + ff) / gg;
                Console.WriteLine(hh);

                double maxDbl = double.MaxValue;
                double minDbl = double.MinValue;
                Console.WriteLine($"The range of double is {minDbl} to {maxDbl}");

                double third = 1.0 / 3.0;
                Console.WriteLine(third);

                double circumference = Math.PI * (30 * 30);
                Console.WriteLine(circumference);
            }

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
