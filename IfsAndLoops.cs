using System;

namespace IfsAndLoops
{
    class LogicProgram
    {
        public static void MainLogic()
        {
            runIfs();

            void runIfs()
            {
                int a = 5;
                int b = 6;
                if (a + b > 10)
                    Console.WriteLine("The answer is greater than 10.");
            }
        }
    }
}