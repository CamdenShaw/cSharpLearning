using System;

namespace IfsAndLoops
{
    class LogicProgram
    {
        public static void MainLogic()
        {
            // ExploreIf();
            // ExploreLoops();
            // ExploreNestedLoops();
            ExploreCombinations();

            void ExploreIf()
            {
                int a = 5;
                int b = 3;
                if (a + b > 10)
                {
                    Console.WriteLine("The answer is greater than 10.");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10.");
                }

                int c = 4;
                if ((a + b + c > 10) && (a == b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("And the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not equal to the second");
                }

                if ((a + b + c > 10) || (a > b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("Or the first number is greater than the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not greater than the second");
                }
            }

            void ExploreLoops()
            {
                int counter = 0;
                while (counter < 10)
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                }

                counter = 0;
                do
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                } while (counter < 10);

                for(int index = 0; index < 10; index++)
                {
                    Console.WriteLine($"Hello World! The index is {index}");
                }

                for(int index = 10; index > 0; index--)
                {
                    Console.WriteLine($"Hello World! The index is {index}");
                }
            }

            void ExploreNestedLoops()
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The column is {column}");
                    for (int row = 1; row < 11; row++)
                    {
                        Console.WriteLine($"The row is {row}");
                        Console.WriteLine($"The cell is {row}, {column}");
                    }
                }
            }
            void ExploreCombinations()
            {
                int sum3 = 0;
                for(int i = 0; i <= 20; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine($"{i} is divisible by three.");
                        sum3 += i;
                    }
                }
                Console.WriteLine($"The sum of all numbers divisible by three from zero to twenty is {sum3}");
            }

        }
    }
}