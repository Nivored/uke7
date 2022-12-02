using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    internal class House
    {
        public Room Location { get; private set; }

        public House()
        {
            var roomA = new Room('A');
            var roomB = new Room('B');
            var roomC = new Room('C');

            Location = roomA;

            new ConnectedToRoom(roomA, roomB);
            new ConnectedToRoom(roomC, roomB);
        }

        public void Move(char newRoom)
        {
            var room = Location.FindConnectionToRoom(newRoom);
            if (room != null)
            {
                Location = room;
            }
        }

    }
}
