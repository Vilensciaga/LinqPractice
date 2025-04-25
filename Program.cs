// See https://aka.ms/new-console-template for more information
using LinqPractice;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;


var students =  StudentService.populateArray();



List <string> firstName = new List<string>();
firstName = StudentService.ListAllUserFirstNames(students);

foreach (var name in firstName)
{
    Console.WriteLine(name);
}




Console.WriteLine();



List<string> fullName = new List<string>();
fullName = StudentService.ListUserFullNames(students);

foreach(var name in fullName)
{
    Console.WriteLine(name);
}


Console.WriteLine();


Console.WriteLine($"Number Of Students: {StudentService.NumberOfStudents(students)}");
Console.WriteLine();


Console.WriteLine($"Number Of Active Students: {StudentService.NumberOfActiveStudents(students)}");
Console.WriteLine();



foreach (var student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
    Console.WriteLine(student.Email);
    Console.WriteLine("Phone: " + string.Join(", ", student.Number));
    Console.WriteLine("Grades:");
    foreach (var grade in student.Grades)
    {
        Console.WriteLine($" - {grade.Key}: {grade.Value}");
    }
    Console.WriteLine($"isActive: {student.isActive}");
    Console.WriteLine();
}

















