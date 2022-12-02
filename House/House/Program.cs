using System.Threading.Channels;

namespace House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var house = new House();

            while (true)
            {
                Console.WriteLine($"You are in room {house.Location.Name}");
                Console.WriteLine($"Where do you want to go?");
                var input = Console.ReadLine().ToUpper();
                var newRoom = input[0];
                house.Move(newRoom);
            }
        }
    }
}