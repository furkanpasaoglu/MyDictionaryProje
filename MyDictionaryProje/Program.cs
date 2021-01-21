using System;

namespace MyDictionaryProje
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDictionary
            MyDictionary<int, string> product = new MyDictionary<int, string>();
            product.Add(145, "Laptop");
            product.Add(125, "Mouse");
            product.Add(42, "Keyboard");
            product.Add(12, "Camera");
            product.Add(5, "HeadSet");

            Console.WriteLine(product.Yazdir(5));

            Console.WriteLine();

        }
    }
}
