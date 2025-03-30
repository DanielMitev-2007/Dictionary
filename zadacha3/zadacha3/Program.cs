using System;
using System.Collections.Generic;
using zadacha3;

class Program
{
    static void Main()
    {
        EmployeeManager employeeManager = new EmployeeManager();

        while (true)
        {
            Console.WriteLine("Enter employee ID (or 'end' to stop):");
            string idInput = Console.ReadLine();

            if (idInput.ToLower() == "end")
            {
                break;
            }

            if (int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Enter employee name:");
                string name = Console.ReadLine();

                employeeManager.AddEmployee(id, name);
            }
            else
            {
                Console.WriteLine("Please enter a valid ID.");
            }
        }

        employeeManager.DisplayEmployees();

        Console.ReadKey();
    }
}
