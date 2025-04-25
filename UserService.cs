using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public static class UserService
    {


        public static List<string> ListAllUserFirstNames(Student[] students)
        {
            return students.Select(x => x.FirstName).ToList();

        }

        public static List<string> ListUserFullNames(Student[] students)
        {
            return students.Select(x => $"{x.FirstName}  {x.LastName} ").ToList();
        }

        public static int NumberOfStudents(Student[] students)
        {
            return students.Count();
        }

        public static int NumberOfActiveStudents(Student[] students)
        {
            return students.Count(x => x.isActive == 1);
        }

        public static Student[] populateArray()
        {
            Student[] students = new Student[10];

            var firstNames = new[] { "Alice", "Bob", "Charlie", "Diana", "Ethan", "Fiona", "George", "Hannah", "Ian", "Julia" };
            var lastNames = new[] { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Martinez", "Clark" };
            int active = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (i % 2 == 0)
                {
                    active = 0;
                }
                else
                {
                    active = 1;
                }
                students[i] = new Student
                {
                    FirstName = firstNames[i],
                    LastName = lastNames[i],
                    Email = $"{firstNames[i].ToLower()}.{lastNames[i].ToLower()}@example.com",
                    Number = $"555-01{i:D2}",
                    isActive = active,
                    Grades = new Dictionary<string, double>
                    {
                    { "Math", 85 + i },
                    { "Science", 80 + i },
                    { "English", 78 + i }
                    }
                };
            }

            return students; 

        }






    }
}
