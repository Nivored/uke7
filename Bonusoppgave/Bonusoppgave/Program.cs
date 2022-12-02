using System.Text.RegularExpressions;

namespace Bonusoppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gymnasium = new ClassRoom(109, "Gymsal");
            var mathRoom = new ClassRoom(101, "Mate sal");
            var gym = new Course("Gym");
            var historie = new Course("Historie");
            var math = new Course("Mate");
            var frank = new Student("Frank");
            var anders = new Student("Anders");
            var per = new Teacher("Per");
            gym.AddStudent(frank);
            gym.AddStudent(anders);
            gym.AddTeacher(per);
            gym.AddClassRoom(gymnasium);
            math.AddClassRoom(mathRoom);
            math.AddStudent(frank);
            frank.AddCourse(historie);
            anders.AddCourse(gym);
            Console.WriteLine(gym.GetTeacher());
            Console.WriteLine(gym.GetStudent());
            Console.WriteLine(math.GetStudent());
            gym.GetClassRoom();
            math.GetClassRoom();
            Console.WriteLine();
            frank.CheckCourses();
            anders.CheckCourses();
        }
    }
}