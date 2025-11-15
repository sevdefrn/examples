#region Singleton
//using DesignPatterns.Singleton;
//using DesignPatterns.Student;

//var logger = Logger.GetInstance();
//logger.Log("Sistem sağlıklı çalıştı.");

//StudentService studentService = new StudentService(logger);
//studentService.Add();
//studentService.Delete();
//studentService.List();
//studentService.Update();
#endregion

#region Factory
//using DesignPatterns.Factory;

//var sekildaire = SekilFactory.GetSekil("daire");
//var sekilkare = SekilFactory.GetSekil("kare");
//sekildaire.Ciz();
//sekilkare.Ciz();
#endregion

#region ÖDEV

//using DesignPatterns.Ödev;


//var makarnazeytin = SiparisFactory.GetSiparis("zeytinli");
//var makarnamantar = SiparisFactory.GetSiparis("mantarlı");
//var makarnakorı = SiparisFactory.GetSiparis("körili");
//var makarnamacncehesee = SiparisFactory.GetSiparis("macnchesee");
//var makarnakozlu = SiparisFactory.GetSiparis("közlü");

//makarnazeytin.Hazırla();
//makarnamantar.Hazırla();
//makarnakorı.Hazırla();
//makarnamacncehesee.Hazırla();
//makarnakozlu.Hazırla();
#endregion

#region STRATEGY PATTENY

using DesignPatterns.Strategy;

int cebimdekiPara = 1000;
int anlikFiyat = 0;
Console.Write("Lütfen ürün kodunu giriniz: ");
string kod = Console.ReadLine();
if (kod == "adidas")
    anlikFiyat = 1100;
else if (kod == "zara")
    anlikFiyat = 1300;
else
    anlikFiyat = 1000;
if (anlikFiyat > cebimdekiPara)
{
    //Kredi Kart
    var f = new FiyatStrategy { strateji = new Yuzde10() };
    Console.WriteLine($"Ödeme yöntemi kredi kartı----> ürün satış fiyatı {anlikFiyat} ,indirimli fiyat {f.Hesapla(anlikFiyat)}");
}
else
{
    var f = new FiyatStrategy { strateji = new Yuzde20() };
    Console.WriteLine($"Ödeme yöntemi nakit----> ürün satış fiyatı {anlikFiyat} ,indirimli fiyat {f.Hesapla(anlikFiyat)}");
}

#endregion
