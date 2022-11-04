using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Maksym", "Dobrynchuk", 1, Position.Middle);
            Console.WriteLine(employee.Salary.ToString());
            Console.WriteLine(employee.Tax.ToString());
        }
    }
}
