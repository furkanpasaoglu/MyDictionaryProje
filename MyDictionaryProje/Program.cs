using System;
using System.Collections.Generic;

namespace MyDictionaryProje
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDictionary
            MyDictionary<int, string> product = new MyDictionary<int, string>();
            product.Add(145, "Laptop");
            product.Add(5, "Mouse");
            product.Add(150, "HeadSet");
            product.Add(100, "Phone");
            Console.WriteLine(product.Count);

        }
    }
}