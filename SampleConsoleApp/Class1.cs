using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Book
    {
        public string name;
        public int id;

        public void Buy()
        {
            Console.WriteLine("You sucessfully bought" + this.name);
        }

        public void Name()
        {
            Console.WriteLine("This books id is" + this.id);
        }
    }
    internal class Class1
    {
    }
}
