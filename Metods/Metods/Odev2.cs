using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Metods
//{
//    public class Market
//    {
//        public void FiyatGir()
//        {
//            string[] urunListesi = new string[3];
//            double[] fiyatListesi = new double[3];
//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write($"{i + 1} ürünün adını giriniz: ");
//                urunListesi[i] = Console.ReadLine();

//                Console.Write($"{i + 1} ürünün fiyatını giriniz: ");
//                fiyatListesi[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine($"Toplam tutar:{ToplamHesapla(fiyatListesi)}");
//            Console.WriteLine($"Ortalama ürün fiyat:{OrtalamaHesapla(fiyatListesi)}");

//        }
//          public double ToplamHesapla(double[] fiyatListesi)
//        {
//            double toplam = 0;
//            for(int i=0; i< fiyatListesi.Length; i++)
//            {
//                toplam += fiyatListesi[i];
//            }
//            return toplam;

//        }
//        public double OrtalamaHesapla(double[] fiyatListesi)
//        {
//            double toplam = 0;
//            for (int i=0; i<fiyatListesi.Length; i++)
//            {
//                toplam += fiyatListesi[i];
//            }
//            return toplam / fiyatListesi.Length;
//        }
//    }
//}
