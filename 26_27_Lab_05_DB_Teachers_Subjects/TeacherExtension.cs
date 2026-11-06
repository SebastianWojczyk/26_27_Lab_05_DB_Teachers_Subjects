using System.Linq;

namespace _26_27_Lab_05_DB_Teachers_Subjects
{
    partial class Teacher
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Subjects.Count()} przedmiotów)";
        }
    }
}
