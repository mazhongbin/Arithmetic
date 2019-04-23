using System;

namespace Arithmetic.TestData
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public int CompareTo(Student student)
        {
            return this.Name.CompareTo(student.Name);
        }

        public override string ToString()
        {
            return $"Name:{Name}, Socre:{Score}";
        }
    }
}
