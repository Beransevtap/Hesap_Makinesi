using Hesap_Makinesi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HesapMakinesi
{
    class Test
    {

        static void Main(string[] args)
        {
            Islemler islem = new Islemler();
            float sonuc = 0;
            Console.WriteLine("*************HESAP MAKİNESİ*************");
            Console.WriteLine("Lütfen işlem yapılacak ilk sayıyı giriniz...");
            float deger1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen işlem yapılacak ikinci sayıyı giriniz...");
            float deger2 = float.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("***********************İŞLEMLER***********************");
           
            Console.WriteLine("Bölme işlemi için 3 seçiniz...");
            Console.WriteLine("Seçiminizi Giriniz...");
            int secim = int.Parse(Console.ReadLine());
         
           if (secim == 3)
            {
                Console.WriteLine(islem.Bolme(deger1, deger2));
            }
           

            Console.ReadKey();

        }
    }
}

