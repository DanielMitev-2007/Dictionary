using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    internal class EmployeeManager
    {
        private SortedDictionary<int, string> employees = new SortedDictionary<int, string>();

        public void AddEmployee(int id, string name)
        {
            if (employees.ContainsKey(id))
            {
                Console.WriteLine($"An employee with ID {id} already exists. The name will be updated.");
                employees[id] = name;
            }
            else
            {
                employees.Add(id, name);
            }
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("\nList of employees, sorted by ID:");

            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }
        }
    }
}
