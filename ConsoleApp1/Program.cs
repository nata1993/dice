using System;

namespace Kivipaberkäärid
{
    class Program
    {
        static void Main(string[] args)
        {
            //string value;
            int userRoll;
            int cpuRoll;
            int rolls = 0;
            int userScore = 0;
            int cpuScore = 0;

            /*int kivi = 4;
            int käärid = 5;
            int paber = 6;*/


            //DICE ROLLING
            Random rnd = new Random();
            while (rolls < 50)
            {
                userRoll = rnd.Next(1, 7);
                cpuRoll = rnd.Next(1, 7);

                Console.WriteLine($"You rolled {userRoll}, cpu rolled {cpuRoll}");
                if (userRoll > cpuRoll)
                {
                    userScore++;
                }

                else if (userRoll < cpuRoll)
                {
                    cpuScore++;
                }

                else
                {
                    continue;
                }
                rolls++;
            }

            if (cpuScore > userScore)
            {
                Console.WriteLine("you lose");
            }

            else if (cpuScore < userScore)
            {
                Console.WriteLine("you win");
            }

            else
            {
                Console.WriteLine("tie");
            }
            Console.WriteLine($"your score {userScore}, cpu score {cpuScore}");
            Console.ReadLine();
        }
    }
}
