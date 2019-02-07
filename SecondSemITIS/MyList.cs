using System;

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

        public void DeleteK(int k)
        {
            if (k == 1)
            {
                First = First.Next;
                return;
            }

            Elem pred = First;
            for (int i = 2; i < k; i++)
            {
                pred = pred.Next;
            }
            pred.Next = pred.Next.Next;
        }

        public int Count()
        {
            var count = 0;
            Elem last = First;
            while (last != null)
            {
                last = last.Next;
                count++;
            }

            return count;
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
