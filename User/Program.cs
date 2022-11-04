using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Login = "Maks", Name = "Maksym", SurName = "Dobrynchuk", Age = 18 };
            Console.WriteLine(user.ToString());
        }
    }
}
