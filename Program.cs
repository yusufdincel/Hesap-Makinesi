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
            float sayi1, sayi2;
            string islem;
            Console.WriteLine("İlk sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Yapmak İstediğiniz İşelmi seçiniz: (toplama, çıkarma, çarpma, bölme");
            islem = Console.ReadLine();
            if(islem != "toplama" && islem != "çıkarma" && islem != "çarpma" && islem != "bölme")
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz...");
            }




        }
    }
}
