using System;

namespace MyDictionaryProje
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDictionary
            MyDictionary<int, string> product = new MyDictionary<int, string>();
            product.Add(1, "Laptop");
            product.Add(2, "Mouse");
            product.Add(3, "Keyboard");
            product.Add(4, "Camera");
            product.Add(5, "HeadSet");

            int sayac = 0;
            foreach (var x in product.Values)
            {
                Console.WriteLine(product.Keys[sayac] + " " + x);
                sayac++;
            }
            //Key List
            Console.WriteLine("\n");
            Console.WriteLine("KeyList");
            foreach (var x in product.Keys)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
            Console.WriteLine("ValueList");
            foreach (var x in product.Values)
            {
                Console.WriteLine(x);
            }
        }
    }
}
