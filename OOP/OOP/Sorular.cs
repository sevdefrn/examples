using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class SoruCevap()
    {
        private string[] sorular = {
    "1. Türkiye’nin başkenti resmen hangi yılda Ankara olmuştur?",
    "2. Güneş’e en yakın gezegen hangisidir?",
    "3. Ses hangi ortamda yayılmaz?",
    "4. Dünya’nın uydusu hangisidir?",
    "5. İlk Türk alfabesi olarak kabul edilen yazı hangisidir?",
    "6. Türkiye’nin yüzölçümü bakımından en küçük ili hangisidir?",
    "7. Elektrik akımının birimi nedir?",
    "8. Leonardo da Vinci’nin ünlü eseri Mona Lisa hangi müzede sergilenmektedir?",
    "9. İnsan vücudunda en güçlü kas hangisidir?",
    "10. Türkiye’nin en uzun nehri hangisidir?",
    "11. 1 byte kaç bit’ten oluşur?",
    "12. Dünya’da en fazla konuşulan dil hangisidir?",
    "13. Bilgisayarlarda geçici veri depolamak için kullanılan bellek türü hangisidir?",
    "14. Türk lirasından 6 sıfır hangi yıl atılmıştır?",
    "15. İlk yapay uydu Sputnik 1 hangi ülke tarafından uzaya gönderilmiştir?"
};

        private string[,] secenekler = {
    {"A) 1920", "B) 1923", "C) 1927", "D) 1930"},
    {"A) Merkür", "B) Venüs", "C) Mars", "D) Jüpiter"},
    {"A) Katı", "B) Sıvı", "C) Gaz", "D) Boşluk"},
    {"A) Ay", "B) Güneş", "C) Mars", "D) Venüs"},
    {"A) Arap Alfabesi", "B) Göktürk Alfabesi", "C) Latin Alfabesi", "D) Uygur Alfabesi"},
    {"A) Yalova", "B) Kilis", "C) Bartın", "D) Düzce"},
    {"A) Volt", "B) Amper", "C) Ohm", "D) Watt"},
    {"A) British Museum", "B) Louvre Müzesi", "C) Prado Müzesi", "D) Hermitage Müzesi"},
    {"A) Kalp", "B) Dil", "C) Bacak", "D) Karın"},
    {"A) Fırat", "B) Dicle", "C) Kızılırmak", "D) Yeşilırmak"},
    {"A) 4", "B) 8", "C) 16", "D) 32"},
    {"A) İngilizce", "B) Çince", "C) İspanyolca", "D) Hintçe"},
    {"A) ROM", "B) RAM", "C) SSD", "D) HDD"},
    {"A) 2000", "B) 2003", "C) 2005", "D) 2007"},
    {"A) Amerika", "B) Almanya", "C) Rusya", "D) Çin"}
};

        private string[] dogruCevaplar = {
    "C", "A", "D", "A", "B",
    "B", "B", "B", "B", "C",
    "B", "B", "B", "C", "C"
};



        public string SoruSor(int indexNumarasi)
        {
            string soru = sorular[indexNumarasi];
            string cevaplar = " ";
            for (int i = 0; i < 4; i++)
            {
                cevaplar += " " + secenekler[indexNumarasi, i];

            }
            return $"\n{soru}\n\n{cevaplar}";
        }


        public bool CevapKontorl(int index, string gelencevap)
        {
            string cevap = dogruCevaplar[index];
            if (cevap == gelencevap)
            {
                return true;
            }
            else return false;
        }
    }
}

