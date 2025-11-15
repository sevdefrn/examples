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

using DesignPatterns.Ödev;


var makarnazeytin = SiparisFactory.GetSiparis("zeytinli");
//var makarnamantar = SiparisFactory.GetSiparis("mantarlı");
//var makarnakorı = SiparisFactory.GetSiparis("körili");
//var makarnamacncehesee = SiparisFactory.GetSiparis("macnchesee");
//var makarnakozlu = SiparisFactory.GetSiparis("közlü");

makarnazeytin.Hazırla();
//makarnamantar.Hazırla();
//makarnakorı.Hazırla();
//makarnamacncehesee.Hazırla();
//makarnakozlu.Hazırla();
#endregion