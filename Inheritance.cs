using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Programs
{
    public class Inheritance
    {
        public Inheritance()
        {
            Console.WriteLine("Calling the human being class constructor");
        }
        public void Display()
        {
            Console.WriteLine("I'm a human being");
        }
    }

    public class Man : Inheritance
    {
        public Man()
        {
            Console.WriteLine("I'm a man, a male human being");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Man yann = new Man();
            yann.Display();
            Console.ReadKey();
        }
    }
}
