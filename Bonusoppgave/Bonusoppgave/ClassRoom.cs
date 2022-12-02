using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonusoppgave
{
    internal class ClassRoom
    {
        public int RoomNumber { get; }
        public string Name { get; }

        public ClassRoom(int roomNumber, string name)
        {
            RoomNumber = roomNumber;
            Name = name;
        }
    }
}
