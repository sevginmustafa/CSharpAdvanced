using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            for (int i = 1; i <= 4; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(list);
        }
    }
}


