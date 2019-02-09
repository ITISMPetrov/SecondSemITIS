using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList lst = new MyList();
            lst.AddFirst(1);
            lst.AddFirst(2);
            lst.AddFirst(3);

            Console.WriteLine(lst);

            Console.WriteLine(lst.GetSum());

            Console.WriteLine(lst.GetInfoByPos(0));

            Console.WriteLine(lst.GetPosByInfo(2));


        }
    }
}
