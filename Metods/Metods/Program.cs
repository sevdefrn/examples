#region 1.KISIM
//DortIslemParmetreli(4, 2, global::DortIslem.Toplam);
//DortIslemParmetreli(4, 2, global::DortIslem.Cıkartma);
//DortIslemParmetreli(4, 2, global::DortIslem.Carpma);
//DortIslemParmetreli(4, 2, global::DortIslem.Bolme);

//static void DortIslemParmetreli(double say1, double say2, DortIslem İslemTipi)
//{
//	switch (İslemTipi)
//	{
//		case global::DortIslem.Toplam:
//			Console.WriteLine($"Toplam işlem sonucu:{say1 + say2}");
//			break;
//		case global::DortIslem.Cıkartma:
//			Console.WriteLine($"Çıkartma işlem sonucu:{say1 - say2}");
//			break;
//		case global::DortIslem.Carpma:
//			Console.WriteLine($"Çarpma işlem sonucu:{say1 * say2}");
//			break;
//		case global::DortIslem.Bolme:
//			Console.WriteLine($"Bölme işlem sonucu:{say1 / say2}");
//			break;
//		default:
//			break;
//	}
//}


#endregion

#region 2.KISIM

//static double DortİslemGeriDonuslu(int sayi1, int sayi2,DortIslem ıslemTipi)
//{
//	switch (ıslemTipi)
//	{
//		case DortIslem.Toplam:
//			return sayi1 + sayi2;
//		case DortIslem.Cıkartma:
//			return sayi1 - sayi2;
//		case DortIslem.Carpma:
//			return sayi1 * sayi2;
//		case DortIslem.Bolme:
//			return sayi1 / sayi2;
//		default:
//			return 0;
//	}
//}
//double sonuc = DortİslemGeriDonuslu(4, 2, DortIslem.Toplam);
//Console.WriteLine($"Toplama işleminin sonucu:{sonuc}");

//enum DortIslem
//{
//    Toplam,
//    Cıkartma,
//    Carpma,
//    Bolme
//}

#endregion

#region 3.KISIM

//OgrenciIslemleri ogrenci = new OgrenciIslemleri();
//ogrenci.SelamVer();
//ogrenci.SelamVer("Sevde");
//Console.WriteLine($"Yaşınız parametsiz:{ogrenci.YasHesapla()}");
//Console.WriteLine($"Yaşınız parametreli:{ogrenci.YasHesapla(2006)}");

#endregion

#region Ödev 1: Kahve Sipariş Uygulaması

//using Metods;

//Console.Write("Lütfen bir içicek seçiniz: 1-Türk Kahvesi, 2-Latte, 3-Esperrso: ");
//string kahveTuru = Console.ReadLine();
//Console.Write("Lütfen şeker sayısı giriniz: ");
//int sekerSayisi = int.Parse(Console.ReadLine());
//Console.Write("Süt ister misiniz(E/H): ");
//string sutKontrol = Console.ReadLine();
//bool sutVarmı = false;
//if (sutKontrol == "E")
//{
//    sutVarmı = true;
//}
//switch (kahveTuru)
//{
//    case "1":
//        kahveTuru = "Türk Kahvesi";
//       break;
//    case "2":
//        kahveTuru = "Latte";
//        break;
//    case "3":
//        kahveTuru = "Esperroso";
//        break;
//}

//KahveSiparisi siparis = new KahveSiparisi();
//Console.WriteLine(siparis.Hazırla(kahveTuru, sekerSayisi, sutVarmı));
//Console.WriteLine($"Ödenicek tutar: {siparis.UcretHesaplama(kahveTuru)} TL");

#endregion

#region Ödev 2: Market Alışverişi Toplam Hesaplama

//using Metods;

//Market market = new Market();
//market.FiyatGir();

#endregion

#region Constructor Destructor

//using Metods.oop;
//Araba araba = new Araba("Opel");

// Kapsülleme
//Ogrenci ogrenci = new Ogrenci();
//ogrenci.a1 = "ABVX213";
//ogrenci.a2 = "TESLKIWQEKQWOEQ";
//ogrenci.harcama = 4500;

//Console.WriteLine($"ApiKey:{ogrenci.a1}, ApiSecret:{ogrenci.a2}, Maaş:{ogrenci.harcama}");

// Kalıtım
//using Metods.oop;

//Kedi kedi = new Kedi();
//kedi.SesCikar("Miyavv!!!");

//Kopek kopek = new Kopek();
//kopek.SesCikar("Hav Hav!!!");


#endregion