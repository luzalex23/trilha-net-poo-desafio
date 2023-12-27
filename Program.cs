using DesafioPOO.Models;

Console.WriteLine("Bem vindo ao Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "7199875", modelo: "M-75", imei:"22321", memoria: 128);
nokia.Ligar();
 Console.BackgroundColor = ConsoleColor.Green;
nokia.InstalarAplicativo("whatsapp");
Console.WriteLine("\n");


Console.WriteLine("Bem vindo ao Seu novo Iphone:");
Smartphone iphone = new Iphone(numero:"001235", modelo: "S20", imei:"5545", memoria:256);
iphone.ReceberLigacao();
 Console.BackgroundColor = ConsoleColor.DarkMagenta;
iphone.InstalarAplicativo("Instagran");
Console.WriteLine("\n");
