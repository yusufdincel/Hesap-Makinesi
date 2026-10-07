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
            string x, y;
            string islem;
            int toplam, fark, carpim, bolum;
            Console.Write("İlk sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine();
            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Yapmak İstediğiniz İşelmi seçiniz: (numarasını yazınız)");
            Console.WriteLine("1) Toplama");
            Console.WriteLine("2) Çıkarma");
            Console.WriteLine("3) Çarpma");
            Console.WriteLine("4) Bölme");
            islem = Console.ReadLine();
            if (islem == "4" && sayi2 == 0)
            {
                while(sayi2 == 0)
                {
                    Console.WriteLine("Herhangi bir sayı 0'a bölünemez. Lütfen ikinci sayıyı tekrar giriniz: ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (islem != "1" && islem != "2" && islem != "3" && islem != "4")
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz...");
            }
      
            else
            {
                if (islem == "1")
                {
                    toplam = sayi1 + sayi2;
                    Console.WriteLine("Toplam: " + toplam);             
                }
                else if(islem == "2"){

                    fark = sayi1 - sayi2;
                    Console.WriteLine("Fark: " + fark);
                }
                else if(islem == "3")
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
