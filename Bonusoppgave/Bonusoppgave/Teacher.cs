using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonusoppgave
{
    internal class Teacher
    {
        private List<Course> _courses;
        public string Name { get; }
        
        public Teacher(string name)
        {
            _courses = new List<Course>();
            Name = name;
        }

    }
}
