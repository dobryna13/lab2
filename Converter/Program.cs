using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.57, 40, 0.3);
            Console.WriteLine(converter.ConvertToEur(4000));
            Console.WriteLine(converter.ConvertToUsd(4000));
            Console.WriteLine(converter.ConvertToRub(4000));
            Console.WriteLine(converter.ConvertEur(4000));
            Console.WriteLine(converter.ConvertUsd(4000));
            Console.WriteLine(converter.ConvertRub(4000));
        }
    }
}
