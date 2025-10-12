#region 1.KISIMM 
DortIslem(4, 2, global::DortIslem.Toplam);
DortIslem(4, 2, global::DortIslem.Cıkartma);
DortIslem(4, 2, global::DortIslem.Carpma);
DortIslem(4, 2, global::DortIslem.Bolme);

static void DortIslem (double say1, double say2, DortIslem İslemTipi)
{
	switch (İslemTipi)
	{
		case global::DortIslem.Toplam:
			Console.WriteLine($"Toplam işlem sonucu:{say1 + say2}");
			break;
		case global::DortIslem.Cıkartma:
            Console.WriteLine($"Çıkartma işlem sonucu:{say1 - say2}");
            break;
		case global::DortIslem.Carpma:
            Console.WriteLine($"Çarpma işlem sonucu:{say1 * say2}");
            break;
		case global::DortIslem.Bolme:
            Console.WriteLine($"Bölme işlem sonucu:{say1 / say2}");
            break;
		default:
			break;
	}
}

enum DortIslem
{
	Toplam,
	Cıkartma,
	Carpma,
	Bolme
}
#endregion
