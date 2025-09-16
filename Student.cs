using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Tạo danh sách học sinh
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 16 },
            new Student { Id = 2, Name = "Bob", Age = 17 },
            new Student { Id = 3, Name = "Charlie", Age = 14 },
            new Student { Id = 4, Name = "David", Age = 19 },
            new Student { Id = 5, Name = "Eva", Age = 15 },
            new Student { Id = 6, Name = "Anna", Age = 18 }
        };

        // a. In toàn bộ danh sách học sinh
        Console.WriteLine("Danh sách toàn bộ học sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
        var ageFilteredStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
        foreach (var student in ageFilteredStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        var nameFilteredStudents = students.Where(s => s.Name.StartsWith("A"));
        Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
        foreach (var student in nameFilteredStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả học sinh
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).First();
        Console.WriteLine($"\nHọc sinh có tuổi lớn nhất: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
        var sortedStudents = students.OrderBy(s => s.Age);
        Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}
