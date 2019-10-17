using System;

namespace Dice2
{
    class Program
    {
        static void Main()
        {
            string userChoice1; //asking if want to play or not
            string userChoice2;

            bool diceRun1 = false; //Loop for rolling dice

            int rndGen1; //first dice
            int rndGen2; //second dice

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
                    Console.WriteLine("\n");
                    Console.WriteLine("Good bye!");
                }

                else if (userChoice1.ToUpper() == "Y") //roll dice if Y
                {
                    Random rndNr1 = new Random(); //Dice nr 1
                    rndGen1 = rndNr1.Next(1, 7);

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
                    rndGen2 = rndNr2.Next(1, 7);

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

                    Console.WriteLine("\n");
                    Console.WriteLine("Press Y to roll dice or N if you want to exit program TÜRA.");
                }                
            }
        }
    }
}
