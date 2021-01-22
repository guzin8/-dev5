using System;

namespace ödev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kelimeler = new MyDictionary<int, string>();
            kelimeler.Add(1, "elma");
            kelimeler.Add(2, "kitap");
            kelimeler.Add(3, "silgi");
            Console.WriteLine(kelimeler.Count());
        }
    }
}
