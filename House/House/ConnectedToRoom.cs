using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    internal class ConnectedToRoom
    {
        public Room Room1 { get; }
        public Room Room2 { get; }

        public ConnectedToRoom(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
            Room1.AddConnection(this);
            Room2.AddConnection(this);
        }
    }
}
