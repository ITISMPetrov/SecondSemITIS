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
            lst.AddLast(100);

            lst.Show();   
        }
    }
}
