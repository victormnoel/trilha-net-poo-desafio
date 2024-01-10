using DesafioPOO.Models;


Console.WriteLine("Testando o smartphone Nokia:\n ");

Smartphone nokia = new Nokia("232323232", "G11 Plus", "88888888", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n--------------------------------------------------------------------------");

Console.WriteLine("Testando o smartphone Iphone: ");

Smartphone iphone = new Iphone("232323232", "Iphone 11", "88888888", 64);
iphone.Ligar();
iphone.InstalarAplicativo("instragram");

Console.ReadKey();