#region SINGLE RESPONSIBILTY PRINCIPLE (Tek Sorumluluk)
// Bir sınıf yanlızca bir sorumluluğa sahip olmalıdır. De
//Bir sinif yalnizca bir sorumluluga sahip olmalidir. Degigiklik gereksinimi yalnizca bu sorumluluga göre olmalidir.
//using SOLID.Soliti;

//using SOLID.Soliti;

//StudentService studentService = new StudentService();
//studentService.CreateStudent();

//MailService mailService = new MailService();
//mailService.SendMail("Mail konusu", "Mail içeriği");
#endregion

#region Open/Close PRINCIPLE
//using SOLID.OpenClose;

//Daire daire = new Daire(5);
//Console.WriteLine($"Dairenin alanı:{daire.Alan()}");

//Kare kare = new Kare(5);
//Console.WriteLine($"Karenin alanı:{kare.Alan()}");
#endregion

#region LİSKOV SUBSTİTUTİON PRINCIPLE

//using SOLID.LiskovSubstitution;
//using System.Collections.Specialized;

//Eagle eagle = new Eagle();
//eagle.Fly();

//Penguen penguen = new Penguen();
//penguen.Fly();

#endregion

#region INRETFACE SEGREGATITON

//using SOLID.InterfaceSegregatiton;

//Human human = new Human();
//Brid brid = new Brid();

//human.Talk();
//human.Work();

//brid.Talk();
//brid.Work();
//brid.Fly();

//WashingMachine washingMachine = new WashingMachine();
//DeepFrezee deepFrezee = new DeepFrezee();

//washingMachine.Washing();
//washingMachine.UseElectric();

//deepFrezee.UseElectric();
//deepFrezee.Freezing();
#endregion

#region DEPENDENCY INVERSİON

//using SOLID.DependencyInversion;

//Order order = new Order();
//order.Onay();

#endregion



