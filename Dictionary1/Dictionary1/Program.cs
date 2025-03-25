using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 1, "Иван" },
            { 2, "Пешо" },
            { 3, "Георги" },
            { 4, "Елена" },
            { 5, "Петър" },
            { 6, "Виктория" }
        };

            Console.WriteLine("Въведете идентификационен номер на студент:");
            int studentId = int.Parse(Console.ReadLine());

            if (students.ContainsKey(studentId))
            {
                Console.WriteLine($"Студент с номер {studentId} е {students[studentId]}.");
            }
            else
            {
                Console.WriteLine("Няма такъв студент.");
            }

            Console.ReadKey();
        }
    }
}
