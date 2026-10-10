using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            float toplam, fark, carpim, bolum;
            double kok;

            Console.Write("İlk sayıyı giriniz: ");       
            sayi1 = Single.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("(+) (-) (*) (/) (sqrt)");
            Console.Write("Yapmak İstediğiniz İşelmi seçiniz: ");
            islem = Console.ReadLine();

            if(islem == "sqrt")
            {
                if(sayi1 < 0)
                {
                    Console.WriteLine(sayi1 + " sayısının karekökü alınamaz...");
                }
                else
                {
                    kok = Math.Sqrt(sayi1);
                    Console.WriteLine("karekök " + sayi1 + " = " + kok);
                }
                System.Environment.Exit(1);
                  
            }
            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Single.Parse(Console.ReadLine());
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("----------------");


            if (islem == "/" && sayi2 == 0)
            {
                while(sayi2 == 0)
                {
                    Console.WriteLine("Herhangi bir sayı 0'a bölünemez. Lütfen ikinci sayıyı tekrar giriniz: ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                }
            }

            if((sayi1 % Convert.ToInt32(sayi1) == 0 && (sayi2 % Convert.ToInt32(sayi2)) == 0))
            {
                sayi1 = Convert.ToInt32(sayi1);
                sayi2 = Convert.ToInt32(sayi2);
            }
           


            if (islem != "+" && islem != "-" && islem != "*" && islem != "/" && islem != "sqrt")
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz...");
            }
            

            else
            {
                if (islem == "+")
                {
                    toplam = sayi1 + sayi2;
                    Console.WriteLine(sayi1 + islem + sayi2 + " = " + toplam);             
                }
                else if(islem == "-"){

                    fark = sayi1 - sayi2;
                    Console.WriteLine(sayi1 + islem + sayi2 + " = " + fark);
                }
                else if(islem == "*")
                {
                    carpim = sayi1 * sayi2;
                    Console.WriteLine(sayi1 + islem + sayi2 + " = " + carpim);
                }

                else
                {
                    bolum = sayi1 / sayi2;
                    Console.WriteLine(sayi1 + islem + sayi2 + " = " + bolum);
                }

            }

            Console.WriteLine("----------------");


        }
    }
}
