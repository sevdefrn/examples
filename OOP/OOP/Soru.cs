using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Soru
    {
        // Sorular (kolaydan zora doğru)
        string[] sorular = {
    "1) Türkiye'nin başkenti neresidir?",
    "2) Ay'a ilk ayak basan insan kimdir?",
    "3) Dünyanın en uzun nehri hangisidir?",
    "4) 'Yıldızlı Gece' tablosunun ressamı kimdir?",
    "5) DNA'nın çift sarmal yapısını bulan bilim insanları kimlerdir?"
};

        // Şıklar
        string[,] siklar = {
    { "A) İstanbul", "B) Ankara", "C) İzmir", "D) Bursa" },
    { "A) Neil Armstrong", "B) Yuri Gagarin", "C) Buzz Aldrin", "D) Alan Shepard" },
    { "A) Amazon", "B) Nil", "C) Yangtze", "D) Mississippi" },
    { "A) Pablo Picasso", "B) Vincent van Gogh", "C) Leonardo da Vinci", "D) Claude Monet" },
    { "A) Watson ve Crick", "B) Newton ve Galileo", "C) Curie ve Einstein", "D) Darwin ve Mendel" }
};

        // Doğru cevaplar
        string[] cevaplar = { "B", "A", "B", "B", "A" };
        
        public string SoruSor(int indexNumarsı)
        {
            string soru = sorular[indexNumarsı];
            string cevaplar = " ";
            for(int i=0; i<4; i++)
            {
                cevaplar += " " + siklar[indexNumarsı, i];
            }
            return $"\n {soru} \n\n {cevaplar}";
        }
        public bool CevapKontrol(int index,string gelenCevap)
        {
            string cevap = cevaplar[index];
            if (cevap == gelenCevap)
            {
                return true;
            }
            else return false;
        }
    }
}
