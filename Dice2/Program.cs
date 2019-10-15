using System;

namespace Dice2
{
    class Program
    {
        static void Main()
        {
            string userChoice1;
            string userChoice2;
            bool diceRun = false;
            bool case1 = false;  //Asking for correct input
            int rndGen1;

            Console.WriteLine("Hello! This is \"DICE\". This program rolls dice for you just like you would roll them in Casino.");       
            Console.WriteLine("Lets roll the dice!");
            Console.WriteLine("\n");
            Console.WriteLine("Press Y if you want to start rolling dice or press N if you want to exit program.");

            while (!case1)
            {
                userChoice1 = Console.ReadLine();

                switch (userChoice1.ToUpper())
                {
                    case "Y":
                        case1 = true;
                        break;
                    case "N":
                        case1 = true;
                        break;
                    default:
                        Console.WriteLine("Insert Y or N.");
                        break;
                }
                Console.WriteLine("\n");

                if (userChoice1.ToUpper() == "Y")
                {
                    Console.WriteLine("Press Y to roll dice or N if you want to exit program.");
                    while (!diceRun)
                    {
                        
                        userChoice2 = Console.ReadLine();

                        switch (userChoice2.ToUpper())
                        {
                            case "Y":
                                break;
                            case "N":
                                break;
                            default:
                                Console.WriteLine("Insert Y or N.");
                                break;
                        }

                        Console.WriteLine("\n");
                        if (userChoice2.ToUpper() == "Y")
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
                            rndGen1 = rndNr2.Next(1, 7);

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
                            Console.WriteLine("\n");
                            Console.WriteLine("Press Y to roll dice or N if you want to exit program.");
                        }

                        else if (userChoice2.ToUpper() == "N")
                        {
                            diceRun = true;
                            Console.WriteLine("Come again!");
                        }
                    }
                }

                else if (userChoice1.ToUpper() == "N")
                {
                    Console.WriteLine("Good bye!");
                }
            }
            Console.ReadLine();
        }
    }
}
