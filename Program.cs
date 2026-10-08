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

            Console.WriteLine("(+) (-) (*) (/)");
            Console.Write("Yapmak İstediğiniz İşelmi seçiniz: ");
            islem = Console.ReadLine();

            if (islem == "/" && sayi2 == 0)
            {
                while(sayi2 == 0)
                {
                    Console.WriteLine("Herhangi bir sayı 0'a bölünemez. Lütfen ikinci sayıyı tekrar giriniz: ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (islem != "+" && islem != "-" && islem != "*" && islem != "/")
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz...");
            }
      
            else
            {
                if (islem == "+")
                {
                    toplam = sayi1 + sayi2;
                    Console.WriteLine("Toplam: " + toplam);             
                }
                else if(islem == "-"){

                    fark = sayi1 - sayi2;
                    Console.WriteLine("Fark: " + fark);
                }
                else if(islem == "*")
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
