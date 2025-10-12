#region 1.KISIMM 
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
using Metods;

OgrenciIslemleri ogrenci = new OgrenciIslemleri();
ogrenci.SelamVer();
ogrenci.SelamVer("Sevde");
Console.WriteLine($"Yaşınız parametsiz:{ogrenci.YasHesapla()}");
Console.WriteLine($"Yaşınız parametreli:{ogrenci.YasHesapla(2006)}");

#endregion
