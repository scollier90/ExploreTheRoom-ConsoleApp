using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheRoom
{
    public class Room
    {
        public string Door { get; set; }
        public string Vent { get; set; }
        public string Lamp { get; set; }
        public string Desk { get; set; }
        public string Drawer { get; set; } = "1150";
        public string Keypad { get; set; }
        public bool KeyAvailable { get; set; }
        public bool NoteAvailable { get; set; }
        public Player RoomContestant { get; set; }

        public Room() { }

        bool lockedDoor = true;

        public Room(string door, string vent, string lamp, string drawer, string keypad, bool keyAvailable, bool noteAvailable, string desk, Player roomContestant)
        {
            Door = door;
            Vent = vent;
            Lamp = lamp;
            Desk = desk;
            Drawer = drawer;
            Keypad = keypad;
            KeyAvailable = keyAvailable;
            NoteAvailable = noteAvailable;
        }
    }
}
