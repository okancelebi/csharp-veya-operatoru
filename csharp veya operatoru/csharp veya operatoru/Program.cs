using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_veya_operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veya Operatörü : Altgr+ z'nin yanındaki tuş ile yapılır.
            int sayi1 = 10;
            int sayi2 = 10;
            int sayi3 = 4;
            bool kontrolet = sayi1 == sayi2 || sayi1 < sayi3;
            Console.WriteLine(kontrolet);
            Console.ReadLine();
        }
    }
}
