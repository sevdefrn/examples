#region S

//using SunumÖdevi._S_PresentationFile;

//InvoiceService invoiceService = new InvoiceService();
//invoiceService.InvoiceCreator();

//DataBase dataBase = new DataBase();
//dataBase.Saved();

//MailService mailService = new MailService();
//mailService.SendMail();

// Todo: Not yazdırma


using SunumÖdevi._S_PresentationFile;


Note note = new Note();
SaveNote saveNote = new SaveNote();
NotePrinter notePrinter = new NotePrinter();


Console.Write("Not girmek istiyor musunuz(E/H)? : ");
string notCevap = Console.ReadLine();
switch (notCevap)
{
    case "E":
        note.NotePad("Bu projeyi sunum için hazıladım :)");
        Console.WriteLine("Notunuzu kayıt etmek istiyor musunuz(E/H)? : ");
        string kayıtCevap = Console.ReadLine();
        if (kayıtCevap == "E")
        {
            saveNote.Save();
            Console.WriteLine("Notunuzu yazdırmak ister misiniz(Y/N)? : ");
            string yazdırmaCevap = Console.ReadLine();
            if (yazdırmaCevap == "Y")
            {
                notePrinter.Print();
            }
            else
            {
                Console.WriteLine("Notunuz yazdırılmadı...");
                Thread.Sleep(2000);
                break;
            }
        }
        else
        {
            Console.WriteLine("Notunuzu silindi...");

            Thread.Sleep(2000);
        }
        break;


    case "H":
        Console.WriteLine("Lütfen başka zaman geliciz :)");
        break;

}

#endregion

#region O/C

//using SunumÖdevi._Open_Close_PaymentSystem;
//using System.Net;

//Cart credit = new Cart(70);
//Console.WriteLine($"Ödemiz gereken tutar:{credit.Payment()}");


//Cash cash = new Cash(70);
//Console.WriteLine($"Ödeminiz gereken tutar:{cash.Payment()} ");



#endregion

#region L

//using SunumÖdevi._L_Pencils;

//Pen pen = new Pen();
//pen.Indelible();

//Pencil pencil = new Pencil();
//pencil.Indelible();

#endregion

#region I

//using SunumÖdevi.Phone;

//SmartPhone smartPhone = new SmartPhone();

//smartPhone.Charge();
//smartPhone.Game();
//smartPhone.PhoneCall();
//smartPhone.Touchscreen();

//ButtonPhone buttonPhone = new ButtonPhone();
//buttonPhone.Charge();
//buttonPhone.Game();
//buttonPhone.PhoneCall();

#endregion

#region D


//using SunumÖdevi._D_Car;
//Sold sold = new Sold();
//sold.Delivered();


#endregion