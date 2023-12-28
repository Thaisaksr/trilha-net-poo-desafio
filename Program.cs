using DesafioPOO.Models;


Console.WriteLine("Smartphone NOKIA");
Smartphone nokia= new Nokia("987456", "G11 Plus", "55555555", 256);
nokia.Ligar ();
nokia.InstalarAplicativo ("GoogleChrome");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone= new Iphone("123456", "Iphone12", "999999", 512);
iphone.Ligar ();
iphone.InstalarAplicativo ("Instagram");