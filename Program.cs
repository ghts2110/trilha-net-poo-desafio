using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia("123456", "modelo 1", "11111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.DadosSmartphone();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Nokia("654321", "modelo 2", "22222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
iphone.DadosSmartphone();