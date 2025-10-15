using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    public class MarketAlisverisi
    {
        public void hesapla()
        {
            Console.Write("1.Ürün: ");
            string urunadi = Console.ReadLine();
            Console.Write("1.Fiyatı: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.Write("2.Ürün: ");
            string urunadi2 = Console.ReadLine();
            Console.Write("2.Fiyatı: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.Write("3.Ürün: ");
            string urunadi3 = Console.ReadLine();
            Console.Write("3.Fiyatı: ");
            double sayi3 = double.Parse(Console.ReadLine());

            double toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine($"Ürünlerin toplam fiyatı:{toplam}");

            double bolme = toplam / 3;
            Console.WriteLine($"Ürünlerin ortalama fiyatı:{bolme}");
        }
    }
}
