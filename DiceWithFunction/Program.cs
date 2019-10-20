using System;

namespace DiceWithFunction
{
    class Program
    {
        static void Main()
        {
            bool diceRun1 = false;

            int userCash;
            string userChoice1; //asking if want to play or not

            Console.WriteLine("Hello! This is \"DICE\". This program rolls dice for you just like you would roll them in Casino.");
            Console.WriteLine("Lets roll the dice!");
            Console.WriteLine("\n");
            Console.WriteLine("Press Y to roll dice or N if you want to exit program.");

            while (!diceRun1) //game on or off
            {
                userChoice1 = Console.ReadLine();

                switch (userChoice1.ToUpper()) //checking for correct user input
                {
                    case "Y":
                        break;
                    case "N":
                        break;
                    default:
                        Console.WriteLine("Insert Y or N.");
                        break;
                }

                if (userChoice1.ToUpper() == "N") //exit if N
                {
                    diceRun1 = true;
                    Exit();
                }

                else if (userChoice1.ToUpper() == "Y") //roll dice if Y
                {
                    Play(diceRun1);
                }
            }
        }

        public static void Exit()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Good bye!");
        }

        public static void Play(bool diceRun1)
        {
            CashAgain:
            Console.WriteLine("\n");
            Console.WriteLine("Please, insert Cash.");
            int userCash = int.Parse(Console.ReadLine());

            if (userCash == 0)
            {
                goto CashAgain;
            }

            while (userCash > 0 && diceRun1 == false)
            {
                Console.WriteLine("\n");
                Console.WriteLine("ODD or EVEN. Press N to exit.");
                string userChoice2 = Console.ReadLine();

                switch (userChoice2.ToUpper())
                {
                    case "ODD":
                        break;
                    case "EVEN":
                        break;
                    case "N":
                        break;
                    default:
                        break;
                }

                if (userChoice2.ToUpper() == "N")
                {
                    diceRun1 = true;
                    Console.WriteLine("\n");
                    Console.WriteLine($"Your cash after game is: {userCash}.");
                    Console.WriteLine("\n");
                    Console.WriteLine("Good bye!");
                }

                else if (userChoice2.ToUpper() == "ODD" || userChoice2.ToUpper() == "EVEN")
                {
                    Random rndNr1 = new Random(); //Dice nr 1
                    int rndGen1 = rndNr1.Next(1, 7);

                    switch (rndGen1)
                    {
                        case 1:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|        O         |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 2:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("| O                |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|               O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 3:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O               |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|         O        |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|               O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 4:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 5:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|         O        |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 6:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|__________________|");
                            break;
                    }

                    Random rndNr2 = new Random(); //Dice nr 2
                    int rndGen2 = rndNr2.Next(1, 7);

                    switch (rndGen2)
                    {
                        case 1:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|        O         |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 2:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("| O                |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|               O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 3:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O               |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|         O        |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|               O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 4:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 5:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|         O        |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|__________________|");
                            break;
                        case 6:
                            Console.WriteLine(" __________________");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|                  |");
                            Console.WriteLine("|  O            O  |");
                            Console.WriteLine("|__________________|");
                            break;
                    }

                    if (userChoice2.ToUpper() == "EVEN")
                    {
                        int a = (rndGen1 + rndGen2) % 2; //if sum of dice can be divided by 2, then its even
                        Console.WriteLine("\n");

                        if (a == 0)
                        {
                            userCash += 10;
                            Console.WriteLine("IT IS EVEN");

                            if (rndGen1 == 6 && rndGen2 == 6) //full points
                            {
                                userCash += 50;
                            }

                            else if ((rndGen1 + rndGen2) == 6) //half points
                            {
                                userCash += 25;
                            }
                        }

                        else
                        {
                            userCash -= 20;

                            if (userCash <= 0)
                            {
                                diceRun1 = true;
                                Console.WriteLine("GAME OVER! YOU LOST!");
                            }

                            Console.WriteLine("IT IS ODD");
                        }

                        Console.WriteLine($"You now have {userCash} points.");
                    }

                    else if (userChoice2.ToUpper() == "ODD")
                    {
                        int a = (rndGen1 + rndGen2) % 2; //if sum of dice can not be divided by 2, then its ODD
                        Console.WriteLine("\n");

                        if (a != 0)
                        {
                            userCash += 10;
                            Console.WriteLine("IT IS ODD");
                        }

                        else
                        {
                            userCash -= 20;

                            if (userCash <= 0)
                            {
                                diceRun1 = true;
                                Console.WriteLine("GAME OVER! YOU LOST!");
                            }

                            Console.WriteLine("IT IS EVEN");

                            if ((rndGen1 + rndGen2) == 6) //half points
                            {
                                userCash -= 25;
                            }
                        }

                        Console.WriteLine($"You now have {userCash} points.");
                    }
                }
            }
        }
    }
}
