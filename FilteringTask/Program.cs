using System;
using System.Collections.Generic;
using System.Linq;

namespace FilteringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Obj> collection = new List<Obj>()
            {
                new Obj() { Id = 1 },
                new Obj() { Id = 2 },
                new Obj() { Id = 3 },
            };

            // Method 1
            var obj1 = collection.Where(x => x.Id == 2);

            foreach (var o in obj1)
            {
                Console.WriteLine(o.Id);
            }

            // Method 2
            var obj2 = from x in collection
                       where x.Id == 3
                       select x;

            foreach (var o in obj2)
            {
                Console.WriteLine(o.Id);
            }

            // Method 3
            foreach (var o in collection)
            {
                if (o.Id == 2)
                {
                    Console.WriteLine(o.Id);
                }
            }

            // Method 4
            var obj4 = collection.First(x => x.Id == 3);
            Console.WriteLine(obj4.Id);

            // Method 5
            var obj5 = collection.FirstOrDefault(x => x.Id == 3);
            Console.WriteLine(obj5.Id);

            // Method 6
            var obj6 = collection.Last(x => x.Id == 1);
            Console.WriteLine(obj6.Id);

            // Method 7
            var obj7 = collection.LastOrDefault(x => x.Id == 1);
            Console.WriteLine(obj7.Id);
        }
    }
}
