using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POSTION = 0;
        const int END_POSTION = 100;
        public static int currentpoistion = 0;
        public static int selectoption = 0;
        static Random random = new Random();

        public static int throwDice()
        {
            return random.Next(1, 7);
        }

        public static int checkForOption()
        {
            return random.Next(1, 4);
        }

        public static int playeroption()
        {
            int throwDices = throwDice();
            int selectoption =checkForOption();
            if (selectoption == 2)
            {
                currentpoistion += throwDices;
            }
            else if (selectoption == 3)
            {
                currentpoistion -= throwDices;
                if(currentpoistion<0)
                {
                    currentpoistion = START_POSTION;
                }
            }
        
        else
        {
        Console.WriteLine("Do nothing player stay in same postion");
            }
            return currentpoistion;
        }

        static void Main(string[] args)
        {
    //Console.WriteLine("Hello World!");
    Console.WriteLine("Start postion is :"+ START_POSTION);
    Console.WriteLine("end postion is is :"+END_POSTION);
    Console.WriteLine("current poistion is:"+ playeroption());
        }
    }
}
