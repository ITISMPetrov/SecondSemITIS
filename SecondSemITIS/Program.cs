using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSemITIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new MyList();

            lst.AddFirst(1);
            lst.AddLast(2);
            lst.AddLast(3);
            lst.AddLast(4);
            lst.AddLast(5);
            lst.AddLast(6);
            lst.AddLast(7);
            lst.AddLast(8);
            lst.AddLast(9);
            lst.Show();
            Console.WriteLine(lst.Count());
            lst.DeleteK(5);
            lst.Show();
            Console.WriteLine(lst.Count());
        }
    }
}
