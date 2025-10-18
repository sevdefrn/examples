Baslangic:
try
{
	Console.Write("Lütfen bir sayı giriniz: ");
	int sayi = int.Parse(Console.ReadLine());
	Console.WriteLine("Girilen sayı: " + sayi + " ");
}
catch (Exception ex)
{
	Console.WriteLine("Uygulama hata verdi ama sen uygulamayı kullanmaya devam edebilirsin");
	goto Baslangic;
	throw;
}