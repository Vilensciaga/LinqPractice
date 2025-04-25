using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Student
    {
      
            public Guid Id { get; set; } = Guid.NewGuid(); // Unique identifier
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Number { get; set; } = string.Empty;
            public int isActive { get; set; } = 0;
            public Dictionary<string, double> Grades { get; set; } = new Dictionary<string, double>();
        
    }
}
