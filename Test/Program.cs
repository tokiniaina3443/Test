using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        public class Person
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            Person person = new Person { Name = "toki" };
            Console.WriteLine($"Hello {person.Name}");
            Console.ReadLine();
        }
    }
}
