using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    internal class Room
    {
        public char Name { get; }
        private List<ConnectedToRoom> _connectedToRooms;

        public Room(char name)
        {
            Name = name;
            _connectedToRooms = new List<ConnectedToRoom>();
        }

        public void AddConnection(ConnectedToRoom connection)
        {
            _connectedToRooms.Add(connection);
        }

        public Room FindConnectionToRoom(char newRoom)
        {
            foreach (var connection in _connectedToRooms)
            {
                if (connection.Room1.Name == newRoom)
                {
                    return connection.Room1;
                }
                else if (connection.Room2.Name == newRoom)
                {
                    return connection.Room2;
                }
            }

            return null;
        }
    }
}
