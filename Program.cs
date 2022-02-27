using System;
using simple_game_abstraction.entities;

namespace simple_game_abstraction
{

    class Program
    {
        static void Main(string[] args)
        {
            Arus Arus = new Arus("Arus", "Knight", "Sword", 42, 749, 72);
            Jenica Jenica = new Jenica("Jenica", "White Wizard", "Holy Scepter", 42, 601, 482 );
            Topapa Topapa = new Topapa("Topapa", "Black Wizard", "Unholy Scepter", 42, 386, 641);
            Wedge Wedge = new Wedge("Wedge", "Ninja", "Katana", 42, 374, 89 );

            Console.WriteLine("1 - View Party \n" + "2 - Atack");
            int i = int.Parse(Console.ReadLine());

            switch(i)
            {
                case 1:
                Console.WriteLine(Arus);
                Console.WriteLine(Jenica);
                Console.WriteLine(Topapa);
                Console.WriteLine(Wedge);
                break;

                case 2:
                Console.WriteLine("Select a hero \n" + "1 - Arus \n" + "2 - Jenica \n" + "3 - Topapa \n" + "4 - Wedge");
                int HeroSelector = int.Parse(Console.ReadLine());
                
                if (HeroSelector == 1)
                {
                    Console.WriteLine(Arus.Attack(20));
                }
                else if (HeroSelector == 2)
                {
                    Console.WriteLine(Jenica.Attack(15));
                    Console.WriteLine("-10 MP");
                }
                else if (HeroSelector == 3)
                {
                    Console.WriteLine(Topapa.Attack(40));
                    Console.WriteLine("-20 MP");
                }
                else if (HeroSelector == 4)
                {
                    Console.WriteLine(Wedge.Attack(30));
                }
                else
                {
                    Console.WriteLine("Select a valid hero");
                }

                break;

                default:
                Console.WriteLine("Type 1 or 2");
                break;
            }
        
        
                

            
        
    }
}}

