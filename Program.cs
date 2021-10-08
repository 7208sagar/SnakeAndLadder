using System;

namespace SnakeAndLadder
{
    class Program
    {

        const int START_POSTION = 0;
        const int END_POSTION = 100;
        public static int currentpoistion = 0;
        public static int throwDice()
        {
            //Console.WriteLine("Hello World!");

            Random random = new Random();
            int number = random.Next(1, 7);
            return number;
        }

        static void Main(string[]args)
        {
            currentpoistion += throwDice();
            Console.WriteLine("Current postion is=" + currentpoistion);
            Console.WriteLine("Start postion is: " + START_POSTION);
            Console.WriteLine("End postion is: " + END_POSTION);
        }
    }
}
