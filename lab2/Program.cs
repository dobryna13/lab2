using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address {Index="1", Country="Ukraine", City="Kiev", Street="Lobachewskogo", House="23", Apartment=423};
            Console.WriteLine(address.ToString());
        }
    }
}
