using EntityF;

//var numbers = new List<int> { 1, 2, 3, 4, 5 };

#region LINQ 
//var result = from q in numbers where q > 3 select q;
//foreach(var number in result)
//{
//    Console.WriteLine(number);
//}
#endregion

#region LAMBDA 

//var lamdaResult = numbers.Where(x => x > 3).ToList();
//lamdaResult.ForEach(x => Console.WriteLine(x));

#endregion

var products = new List<Product>
{
    new Product { ID = 1, Name = "Frambuazlı Pasta", Price = 1200 },
    new Product { ID = 2, Name = "Yaban Mersinli Pasta", Price = 1200 },
    new Product { ID = 3, Name = "Yaban Mersinli Rolls", Price = 400 },
    new Product { ID = 4, Name = "Profiterol", Price = 300 },
    new Product { ID = 5, Name = "Sufle", Price = 300 },
    new Product { ID = 6, Name = "Böğürtlenli Pasta", Price = 1200 },
    new Product { ID = 7, Name = "Limonlu Cheesecake", Price = 600 },
    new Product { ID = 8, Name = "Frambuazlı Cheesecake", Price = 600 },
    new Product { ID = 9, Name = "Çikolata Parçalı Kurabiye", Price = 300 },
    new Product { ID = 10, Name = "New York Cheesecake", Price = 600 },
    new Product { ID = 11, Name = "Vanilyalı Cupcake", Price = 250 },
    new Product { ID = 12, Name = "Beyaz Çikolatalı Sufle", Price = 300 },
    new Product { ID = 13, Name = "Ekler Vanilya", Price = 600 },
    new Product { ID = 14, Name = "Portakallı Kek", Price = 150 },
    new Product { ID = 15, Name = "Tereyağlı Kurabiye", Price = 200 },
    new Product { ID = 16, Name = "Makaron Çilek", Price = 600 },
    new Product { ID = 17, Name = "Çikolatalı Cupcake", Price = 250 },
    new Product { ID = 18, Name = "Bitter Çikolata", Price = 600 },
    new Product { ID = 19, Name = "Sütlü Çikolata", Price = 600 },
    new Product { ID = 20, Name = "Türk Kahvesi", Price = 250 }
};

#region LINQ 

var urunler = from q in products where (q.Price > 1000) select q;
foreach (var item in urunler)
{
    Console.WriteLine($"Linq ----> {item.Name} Fiyat:{item.Price}");
}

#endregion

#region LAMBDA
var lamdaurunler = products.Where(x => x.Price > 1000).ToList();
lamdaurunler.ForEach(x => Console.WriteLine($"Lamda -----> {x.Name}  Fiyat: {x.Price}"));
#endregion