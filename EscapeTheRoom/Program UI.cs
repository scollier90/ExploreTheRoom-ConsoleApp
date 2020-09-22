using EscapeTheRoomRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheRoom
{
    public class Program_UI
    {
        public void Run()
        {
            //Player player = new Player();
            EscapeTheRoom_Repo repo = new EscapeTheRoom_Repo();

            Console.Clear();
            Console.WriteLine("Welcome to our Escape Game! \n" +
                "Acceptable commmands: \n" +
                    "Get, Use, Search \n" +
                "What is your name? \n");
            repo.AssignName(Console.ReadLine());

            Console.WriteLine("Good luck! \n \n" +
                "You have awoken in a strange room \n" +
                "The walls are a plain white and the floor is cheap faux wood - Martha Stewart wouldn't approve. \n" +
                "The only objects in the room are a DESK, a LAMP, a DOOR, and a VENT. The door has a KEYPAD beside it. \n" +
                "There appears to be a note beside you.\n");

            bool lockedDoor = true;
            while (lockedDoor == true)
            {
                Console.WriteLine("Enter a command.");
                string command = Console.ReadLine().ToLower();
                Console.WriteLine("What item do you want to interact with?");
                string item = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "get":
                        Console.WriteLine(repo.Get(item));
                        break;
                    case "use":
                        Console.WriteLine(repo.Use(item));
                        break;
                    case "search":
                        Console.WriteLine(repo.Search(item));
                        break;
                }
                //{
                //    Console.WriteLine("Get what?");
                //}
                //else if (command.StartsWith("use "))
                //{
                //    Console.WriteLine("I doubt you know how.");
                //}
                //else if (command.StartsWith("search "))
                //{
                //    Console.WriteLine("You search around...still trapped");
                //}
                //else
                //{
                //    Console.WriteLine("Please use the 'Get, Use, or Search' command - spelling matters!");
                //}
                //}
            }
        }
    }
}