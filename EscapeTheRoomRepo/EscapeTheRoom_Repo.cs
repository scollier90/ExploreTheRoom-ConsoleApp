using EscapeTheRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheRoomRepo
{
    public class EscapeTheRoom_Repo
    {
        // Desk
        // Door
        // Lamp
        // Vent
        // Drawer
        // Keypad
        // Note


        // GET Method
        // console.readline()=GET LAMP
        // parse command commandlet <get> object <lamp>
        // repo.<commandlet>(<object>)

        Player player = new Player();

        public string Get(string item)
        {
            switch (item)
            {
                case "desk":
                    Console.Clear();
                    return "The desk is too big to pick up!";
                //break;
                case "door":
                    Console.Clear();
                    return "What are you going to do with a door?";
                //break;
                case "lamp":
                    Console.Clear();
                    return "The lamp cannot be moved.";
                //break;
                case "vent":
                    Console.Clear();
                    return "Your efforts are appreciated, but pointless.";
                case "drawer":
                    Console.Clear();
                    return "You try to steal the drawer. It's locked.";
                case "keypad":
                    Console.Clear();
                    return "It occurs to you that ripping the Keypad off the wall isn't the best idea.";
                case "note":
                    Console.Clear();
                    return "You picked up the note.";
                default:
                    Console.Clear();
                    return "The GET command you used is invalid. Please try again";
            }
        }
        public string Use(string item)
        {
            switch (item)
            {
                case "desk":
                    Console.Clear();
                    return "How do you USE a desk?";
                //break;
                case "door":
                    Console.Clear();
                    return "The handle does not budge.";
                //break;
                case "lamp":
                    Console.Clear();
                    return "You turn on the lamp. The room has that 'glow in the window' feel.";
                //break;
                case "vent":
                    Console.Clear();
                    return "You feel cool air coming out.";
                //break;
                case "drawer":
                    Console.Clear();
                    if (player.HasKey)
                    {
                        player.HasCode = true;
                        return ("You insert the key into the drawer and turn it. It unlocked!\n" +
                                "Inside you find eteched into the wood a code: 1150.");
                    }
                    else
                    {
                        return "The drawer appears to be locked.";
                    } 
                //break;
                case "keypad":
                    Console.Clear();
                    if (player.HasCode)
                    {
                        ;
                        return ("You enter the code into the keypad. You hear a distinct clicking sound near the door.\n" +
                            "Congratulations! You have escaped the room and beat the game.");
                    }
                    else
                    {
                        return "You don't know what numbers to put into it.";
                    }
                //break;
                case "note":
                    Console.Clear();
                    return "You feel the paper against your skin.";
                default:
                    Console.Clear();
                    return "The USE command you used is invalid. Please try again.";
                    //break;
            }
        }
        public string Search(string item)
        {
            switch (item)
            {
                case "desk":
                    Console.Clear();
                    return "The desk contains a single drawer, and is otherwise empty.";
                //break;
                case "door":
                    Console.Clear();
                    return "A plain door with a mechancial lock of some kind and no visible hinges or handle. What a bother.";
                //break;
                case "lamp":
                    Console.Clear();
                    return "The lamp looks familiar. It's of a woman's leg dressed in a fishnet stocking and a red heel. Where have you seen this before?";
                //break;
                case "vent":
                    Console.Clear();
                    player.HasKey = true;
                    return "Something glints in the back of the vent - it's a key! Congradulations, you've obtained a Key!";
                case "drawer":
                    Console.Clear();
                    return "The desk's drawer is locked. If only there was a way to fix that";
                case "keypad":
                    Console.Clear();
                    return "A numeric keypad with the numbers 0-9.";
                case "note":
                    Console.Clear();
                    return "You look at the note. It says the following:\n\n" +
                          "'I dare you to escape from my puzzle! \n" +
                          "Search the room for clues and find a way out.' \n";
                default:
                    Console.Clear();
                    return "The SEARCH command you used is invalid. Please try again";
            }
        }

        public void AssignName(string name)
        {
            player.PlayerName = name;
        }
    }
}

