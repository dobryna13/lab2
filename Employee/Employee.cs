using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
    {
        public enum Position
        {
            Cleaner = 1,
            Trainee,
            Junior,
            Middle,
            Senior,
            TeamLead,
            Manager
        }

        public class Employee
        {
            private string name;
            private string surname;
            private double workPeriod;
            private Position position;
            private const int baseSalary = 4900;

            public Employee(string name, string surname, double workPeriod, Position position)
            {
                Name = name;
                Surname = surname;
                this.workPeriod = workPeriod;
                this.position = position;
            }

            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }

            public double Salary => baseSalary * (int)position * (workPeriod / 1.5 + 1);
            public double Tax => baseSalary * (int)position * 0.15;

        }
    }
