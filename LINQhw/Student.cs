using System;

namespace LINQhw
{
    public class Student : IEquatable<Student>
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }


        public bool Equals(Student other)
        {
            if (StudentID == other.StudentID && StudentName.ToLower() == other.StudentName.ToLower() && Age == other.Age )
                return true;
            else
                return false;
        }
    }
}