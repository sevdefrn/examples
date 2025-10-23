#region Constructor/ Destructor
//using OOP;

//Araba marka = new Araba("Opel");

#endregion

#region Encapsulation (Kapsülleme)

//using OOP;

//Ogrenci ogrenci = new Ogrenci();
//ogrenci.a1 = "Aaakdcmmrgles";
//ogrenci.a2 = "Wadkgffs";
//ogrenci.harcama = 60000;

//Console.WriteLine($"ApiKey:{ogrenci.a1} , ApiSecter:{ogrenci.a2} , Maaş:{ogrenci.harcama}");

#endregion

#region Inheritance (Kalıtım)

//using OOP;

//Kedi kedi = new Kedi();
//kedi.SesCikar("Miyavvv!!!");

//Kopek kopek = new Kopek();
//kopek.SesCikar("Hav Hav!!!");

#endregion

#region Polymorphism (Çok Biçimli)

//using OOP.Polymorphism;

//Dog dog = new Dog();
//dog.Sound();

//Cat cat = new Cat();
//cat.Sound();

#endregion

#region Kim Milyoner olmak ister

using OOP;
using System.Reflection;
using System.Threading.Tasks.Dataflow;

//YarişmaMesajlar.YarismaBaslangicMesajiVer();
//YarismaSeslei.AlkısSesleri(5, 2000);
//string[] yarismacilar = { "Sevde", "Hilal", "Alper" };
//Random rnd = new Random();
//Baslangıc:
//Console.ForegroundColor = ConsoleColor.Green;
//Console.Write($"\n (Sunucu) Merhaba {yarismacilar[rnd.Next(0, 3)]} yarışmaya hoşgeldiniz. Heycanlı mısınız(E/H): ");
//string heyecanCevap = Console.ReadLine();
//switch (heyecanCevap.ToUpper())
//{
//    case "E":
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("(Sunucu) Heyacanlı olmanıza gerek yok. Sakin olmanız size yarışmada şans getirir. Bol şanslar. ");
//        break;
//    case "H":
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("(Sunucu) Süper.. Yarışmada sakin olmanız başarı şansınızı artırır. Bol şanslar.");

//        break;
//    default:
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("(Sunucu) Yanlış cevap verdiniz. Ben size heycanlı mısınız diyo sordu sordum?");
//        goto Baslangıc;
//        break;
//}

//Thread.Sleep(2000);
//Console.ForegroundColor = ConsoleColor.Magenta;
//Console.Write("(Sunucu) Şimdi!!! Yarışmaya başlıyalım mı (E/H): ");
//string yarişamBaslamaCevap = Console.ReadLine();
//if (yarişamBaslamaCevap.ToUpper().Equals("E"))
//{
//    int kazanc = 500;
//    SoruCevap sorucevap = new SoruCevap();
//    for (int i = 0; i < 15; i++)
//    {
//    SoruyuTekrarla:
//        Console.WriteLine(sorucevap.SoruSor(i));
//        Console.Write("Cevabınız: ");
//        string cevap = Console.ReadLine();
//        Thread.Sleep(2000);
//        if (cevap.ToUpper() == "A" || cevap.ToUpper() == "B" || cevap.ToUpper() == "C" || cevap.ToUpper() == "D")
//        {
//            bool cevapDonus = sorucevap.CevapKontorl(i, cevap.ToUpper());
//            if (!cevapDonus)
//            {
//                Console.WriteLine("Tüh!!!! Elendiniz!!! Yarışmacımaza kocaman bir alkış.");
//                YarismaSeslei.AlkısSesleri(20, 0);
//                Console.WriteLine($"Kazancınız:{kazanc} TL");
//                break;
//            }
//            else
//            {
//                kazanc *= 2;
//                YarismaSeslei.AlkısSesleri(5, 0);
//                Console.WriteLine("Tebrikler . Cevabınız doğru..");
//            }
//            Console.WriteLine($"Kazancınız:{kazanc}");
//        }
//        else
//        {
//            Console.WriteLine("(Sunucu) Sen kafayı mı yedin? Şıklar belli sen ne seçtin ? Soruyu tekrarlıyorum. İyi dinle.....");
//            Thread.Sleep(1000);
//            goto SoruyuTekrarla;
//        }
//    }

//}
//else
//{
//    Thread.Sleep(1000);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("(Sunucu) Anladım! Hazır olduğunuzda lütfen tekrar yarışmamıza katılın. Size yol parası hediye ediyoruz !!! Alkışlar yarışmacımız için !!!");
//    YarismaSeslei.AlkısSesleri(10, 2000);
//}

//Console.ReadKey();
#endregion

#region Ödev
// Program başlarken kullanıcıdan adını alsın.
//Sorular rastgele sıralansın.
//Her doğru cevap için 10 puan, yanlış cevapta ise oyun bitsin
//Oyuncunun toplam puanı en sonunda gösterilsin.

//Console.Write("(Sunucu) Merhabalar lütfen adınızı giriniz: ");
//string ad = Console.ReadLine();

//Console.WriteLine("========================= BİLGİ YARIŞMASI ======================");
//Console.WriteLine($"(Sunucu) Bilgi oyununa hoşgeldin {ad}!");



//Console.ForegroundColor = ConsoleColor.Magenta;
////Console.Write($"{ad} Şimdi!!! Oyuna başlıyalım mı (E/H): ");
////string oyunaBaslamaCevap = Console.ReadLine();
////if (oyunaBaslamaCevap.ToUpper().Equals("E"))
////{
//    int puan = 10;
//    Sorular soru = new Sorular();
//    foreach (string item in soru.sorular)
//    {
//    SoruyuTekrarla:
//        Console.WriteLine(soru.sorular);
//        Console.WriteLine("Cevabınız: ");
//        string cevap = Console.ReadLine();
//        Thread.Sleep(2000);
//        if (cevap.ToUpper() == "A" || cevap.ToUpper() == "B" || cevap.ToUpper() == "C" || cevap.ToUpper() == "D")
//        {

//        }
//    }
//}


#endregion

//Program başlarken kullanıcıdan adını alsın.
Baslangic:
Console.Write("Lütfen adınızı giriniz: ");
string ad = Console.ReadLine();

Console.Write($"Merhaba {ad}. Oyuna başlıyalım mı(E/H): ");
string baslamaCevap = Console.ReadLine();

switch (baslamaCevap.ToUpper())
{
    case "E":
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Harika {ad}!!!!! O zaman oyuna başlıyalım...");
        Thread.Sleep(2000);
        Soru soru = new Soru();
        int puan = 0;
        int sayac = 10;
        for (int i = 0; i < 5; i++)
        {
        SoruyuTekrarla:
            Console.WriteLine(soru.SoruSor(i));
            Console.Write("Cevabınız: ");
            string cevap = Console.ReadLine();
            if(cevap.ToUpper()=="A"|| cevap.ToUpper() == "B" || cevap.ToUpper() == "C" || cevap.ToUpper() == "D")
            {
                bool cevapDonus = soru.CevapKontrol(i, cevap.ToUpper());
                if (!cevapDonus)
                {
                    puan += sayac;
                    puan = sayac;
                    Console.WriteLine("Yanlış cevap verdiniz! Oyun bitti.");
                    Console.WriteLine($"Toplam puanınız:{puan}");
                    break;
                }
                else
                {
                    puan += sayac;
                    Console.WriteLine($"Doğru! Toplam puanınız:{puan}");
                }
            }

        }
        break;
    case "H":
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Üzgünüm {ad}:( Oynamak istediğin zaman tekrar gel...");
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{ad} ben sana oyuna başlıyalım mı diye soru sordum...");
        goto Baslangic;
        break;
}

