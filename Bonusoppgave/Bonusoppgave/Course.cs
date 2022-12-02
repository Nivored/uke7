using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bonusoppgave
{
    internal class Course
    {
        private List<Student> _students;
        private List<Teacher> _teachers;
        private List<ClassRoom> _classrooms;
        public string Name { get; set; }

        public Course(string name)
        {
            _students = new List<Student>();
            _teachers = new List<Teacher>();
            _classrooms = new List<ClassRoom>();
            Name = name;
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddClassRoom(ClassRoom classroom)
        {
            _classrooms.Add(classroom);
        }

        public string GetTeacher()
        {
            var text = $"Fag {Name} Lærer:";
            foreach (var teacher in _teachers)
            {
                text += teacher.Name ;
            }
            return text;
        }

        public string GetStudent()
        {
            var text = $"Fag {Name} Studenter:";
            foreach (var student in _students)
            {
                text += $" - {student.Name}";
            }
            return text;
        }

        public void GetClassRoom()
        {
            foreach (var classroom in _classrooms)
            {
                Console.WriteLine($"{classroom.Name}");
            }
        }
    }
}
