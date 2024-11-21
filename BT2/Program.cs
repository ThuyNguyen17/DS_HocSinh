using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

// query syntax 
// method syntax
// lambda 
namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student(1, "Nguyen Van A", 28),
                new Student(2, "Nguyen Van B", 17),
                new Student(3, "Nguyen Van C", 18),
                new Student(4, "Nguyen Van D", 16),
                new Student(5, "A Van E", 20)
            };
            // a. In danh sách toàn bộ danh sách học sinh
            Console.WriteLine("===Danh Sach Hoc Sinh===");
            list.ForEach(s => Console.WriteLine(s.ToString()));
            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var ageFilter = from student in list
                            where student.Age >= 15 && student.Age <= 18
                            select student;

            Console.WriteLine("===Danh Sach hoc sinh co tuoi tu 15 den 18===");
            foreach (Student student in ageFilter)
            {
                Console.WriteLine(student.ToString());
            }
            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            IEnumerable<Student> nameStartsWithA = from student in list
                                  where student.Name.StartsWith("A")
                                  select student;

            Console.WriteLine("===Danh Sach hoc sinh co ten bat dau bang chu A===");
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine(student.ToString());
            }
            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            int totalAge = list.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi cua tat ca hoc sinh: {totalAge}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = list.OrderByDescending(s => s.Age).FirstOrDefault();
            if (oldestStudent != null)
            {
                Console.WriteLine($"Hoc sinh co tuoi lon nhat: {oldestStudent.Name}, Age: {oldestStudent.Age}");
            }

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            Console.WriteLine("===Danh Sach hoc sinh tang dan theo tuoi==");
            var sortedStudents = list.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
