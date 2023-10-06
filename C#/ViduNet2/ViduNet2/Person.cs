using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViduNet2
{
    internal class Person
    {
        public string Name { get; set; }
        public int NameId { get; set; }
        public int Age { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("NameId: ");
            NameId = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Age: ");
            Age = Convert.ToInt32( Console.ReadLine());

        }
        public void Display() {
            Console.WriteLine($" {Name} - {NameId} - {Age}");

        }


    }
}
