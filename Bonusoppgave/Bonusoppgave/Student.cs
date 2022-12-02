using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonusoppgave
{
    internal class Student
    {
        private List<Course> _courses;
        public string Name { get; }

        public Student(string name)
        {
            _courses = new List<Course>();
            Name = name;
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public void CheckCourses()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Valg fag for {Name}: {course.Name}");
            }
        }
    }
}
