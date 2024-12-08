using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
    public class Game
    {
        private Player player;

        public Game()
        {
            player = new Player(new Sword());
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nChoose your weapon:");
                Console.WriteLine("1. Sword");
                Console.WriteLine("2. Bow");
                Console.WriteLine("3. Axe");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        player.SetWeapon(new Sword());
                        break;
                    case "2":
                        player.SetWeapon(new Bow());
                        break;
                    case "3":
                        player.SetWeapon(new Axe());
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        continue;
                }

                player.Attack();
            }
        }
    }
}
