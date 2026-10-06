using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("İlk sayıyı giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("TOPLAM: " + (x+y));



        }
    }
}
