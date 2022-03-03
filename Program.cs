using System;
using simple_game_abstraction.entities;

namespace simple_game_abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus Arus = new Arus("Arus", "Knight", "Sword", 42, 749, 72);
            Jenica Jenica = new Jenica("Jenica", "White Wizard", "Holy Scepter", 42, 601, 482);
            Topapa Topapa = new Topapa("Topapa", "Black Wizard", "Unholy Scepter", 42, 386, 641);
            Wedge Wedge = new Wedge("Wedge", "Ninja", "Katana", 42, 374, 89);


            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine(Arus);
                        Console.WriteLine(Jenica);
                        Console.WriteLine(Topapa);
                        Console.WriteLine(Wedge);
                        break;

                    case "2":

                        Console.WriteLine("---------------------");
                        Console.WriteLine($"Select a hero \n  1 - Arus \n  2 - Jenica \n  3 - Topapa \n  4 - Wedge");
                        Console.WriteLine("---------------------");
                        int HeroSelector = int.Parse(Console.ReadLine());

                        if (HeroSelector == 1)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine(Arus.Attack(20));
                            Console.WriteLine("---------------------");
                        }
                        else if (HeroSelector == 2)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine(Jenica.Attack(15, 10));
                            Console.WriteLine("---------------------");

                        }
                        else if (HeroSelector == 3)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine(Topapa.Attack(40, 20));
                            Console.WriteLine("---------------------");

                        }
                        else if (HeroSelector == 4)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine(Wedge.Attack(30));
                            Console.WriteLine("---------------------");
                        }
                        else
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("Select a valid hero");
                            Console.WriteLine("---------------------");
                        }

                        break;

                    default:
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Type 1, 2 or X");
                        Console.WriteLine("---------------------");
                        break;
                }
                
                Console.ReadLine();
                userOption = GetUserOption();
            }

            Console.ReadLine();






        }
        private static string GetUserOption()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"1 - View Party\n2 - Attack");
            Console.WriteLine("X- Quit");
            Console.WriteLine("---------------------");

            string userOption = Console.ReadLine();
            return userOption;
        }
    }


}



