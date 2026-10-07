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
            int sayi1, sayi2;
            string islem;
            int toplam, fark, carpim, bolum;
            Console.Write("İlk sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Yapmak İstediğiniz İşelmi seçiniz: (toplama, çıkarma, çarpma, bölme");
            islem = Console.ReadLine();
            
            if(islem != "toplama" && islem != "çıkarma" && islem != "çarpma" && islem != "bölme")
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz...");
            }
      
            else
            {
                if (islem == "toplama")
                {
                    toplam = sayi1 + sayi2;
                    Console.WriteLine("Toplam: " + toplam);             
                }
                else if(islem == "çıkarma"){

                    fark = sayi1 - sayi2;
                    Console.WriteLine("Fark: " + fark);
                }
                else if(islem == "çarpma")
                {
                    carpim = sayi1 * sayi2;
                    Console.WriteLine("Çarpım: " + carpim);
                }
                else
                {
                    bolum = sayi1 / sayi2;
                    Console.WriteLine("Bölüm: " + bolum);
                }

            }



        }
    }
}
