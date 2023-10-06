using System;

namespace ViduNet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] ps = new Person[3];
            for(int i = 0; i < ps.Length; i++)
            {
                Console.WriteLine("Nhap phan tu {0}: ",i);
                Person p = new Person();
                p.EnterData();
                ps[i] = p;
            }
            foreach(Person p in ps)
            {
                p.Display();
            }
            
        }
    }
}
