using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSemITIS
{
    class Elem
    {
        public int Info { get; set; }
        public Elem Next { get; set; }
    }

    class MyList
    {
        public Elem First { get; set; }

        public void AddFirst(int x)
        {
            Elem elem = new Elem();
            elem.Info = x;
            elem.Next = First;

            First = elem;
        }

        public void AddLast(int x)
        {
            if (First == null)
            {
                First = new Elem() { Info = x };
            }
            else
            {
                Elem last = First;
                while (last.Next != null)
                    last = last.Next;

                last.Next = new Elem() { Info = x };
            }
        }


        public void Show()
        {
            Elem elem = First;
            while (elem != null)
            {
                Console.Write($"{elem.Info}->");
                elem = elem.Next;
            }
            Console.WriteLine("null");
        }
    }
}
