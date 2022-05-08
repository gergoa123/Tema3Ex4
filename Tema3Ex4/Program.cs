using System;

namespace Tema3Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n;
            Console.WriteLine("introduceti numere");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                m += n;
                n = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("suma numerelor este " + m  );
        }
    }
}
