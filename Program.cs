using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "G11 Plus", imei:"97415695566", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Linkedin");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "88888-8888", modelo: "Iphone 12", imei:"265811454", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");